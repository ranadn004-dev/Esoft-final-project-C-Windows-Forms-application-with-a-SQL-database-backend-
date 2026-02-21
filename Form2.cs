using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Esoft_Final_project
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.myConnection());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbRegNo.Text = string.Empty;
            txtFirstName.Clear();
            txtLastName.Clear();
            dateTimePicker1.Value = DateTime.Now;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtAddress.Clear();
            txtMobile.Clear();
            txtHomePhone.Clear();
            txtEmail.Clear();
            txtParentName.Clear();
            txtNIC.Clear();
            txtContactNo.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO Registration([Reg No],[First Name],[Last Name],[Date Of Birth],[Gender],[Address],[Mobile Phone],[Home Phone],[Email],[Parent Name],[NIC]," +
                "[Contact No]) VALUES(@RegNo,@FirstName,@LastName,@DateOfBirth, @Gender,@Address,@Mobile,@HomePhone,@Email,@ParentName,@NIC,@ContactNo)", con);
            cmd.Parameters.AddWithValue("@RegNo", cmbRegNo.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Gender", rdoMale.Checked ? "Male" : "Female");
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
            cmd.Parameters.AddWithValue("@HomePhone", txtHomePhone.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@ParentName", txtParentName.Text);
            cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
            cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbRegNo.Text = string.Empty;
            txtFirstName.Clear();
            txtLastName.Clear();
            dateTimePicker1.Value = DateTime.Now;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtAddress.Clear();
            txtMobile.Clear();
            txtHomePhone.Clear();
            txtEmail.Clear();
            txtParentName.Clear();
            txtNIC.Clear();
            txtContactNo.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("UPDATE Registration SET [First Name]=@FirstName,[Last Name]=@LastName,[Date Of Birth]=@DateOfBirth,[Gender]=@Gender," +
                "[Address]=@Address,[Mobile Phone]=@Mobile,[Home Phone]=@HomePhone,[Email]=@Email,[Parent Name]=@ParentName,[NIC]=@NIC,[Contact No]=@ContactNo WHERE [Reg No]=@RegNo", con);
            cmd.Parameters.AddWithValue("@RegNo", cmbRegNo.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Gender", rdoMale.Checked ? "Male" : "Female");
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
            cmd.Parameters.AddWithValue("@HomePhone", txtHomePhone.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@ParentName", txtParentName.Text);
            cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
            cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Student Details Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmbRegNo.Text = string.Empty;
            txtFirstName.Clear();
            txtLastName.Clear();
            dateTimePicker1.Value = DateTime.Now;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtAddress.Clear();
            txtMobile.Clear();
            txtHomePhone.Clear();
            txtEmail.Clear();
            txtParentName.Clear();
            txtNIC.Clear();
            txtContactNo.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Registration WHERE [Reg No]=@RegNo", con);
            cmd.Parameters.AddWithValue("@RegNo", cmbRegNo.Text);

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtFirstName.Text = dr["First Name"].ToString();
                txtLastName.Text = dr["Last Name"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dr["Date Of Birth"]);
                string gender = dr["gender"].ToString();
                rdoMale.Checked = (gender == "Male");
                rdoFemale.Checked = (gender == "Female");
                txtAddress.Text = dr["Address"].ToString();
                txtMobile.Text = dr["Mobile Phone"].ToString();
                txtHomePhone.Text = dr["Home Phone"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtParentName.Text = dr["Parent Name"].ToString();
                txtNIC.Text = dr["NIC"].ToString();
                txtContactNo.Text = dr["Contact No"].ToString();
            }
            else
            {
                                MessageBox.Show("Record not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM Registration WHERE [Reg No]=@RegNo", con);
                cmd.Parameters.AddWithValue("@RegNo", cmbRegNo.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbRegNo.Text = string.Empty;
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    dateTimePicker1.Value = DateTime.Now;
                    rdoMale.Checked = false;
                    rdoFemale.Checked = false;
                    txtAddress.Clear();
                    txtMobile.Clear();
                    txtHomePhone.Clear();
                    txtEmail.Clear();
                    txtParentName.Clear();
                    txtNIC.Clear();
                    txtContactNo.Clear();
                }
                else
                {
                    MessageBox.Show("Record not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void lnkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure, Do you really want to Exit...?",
                                                "Exit",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}








        


