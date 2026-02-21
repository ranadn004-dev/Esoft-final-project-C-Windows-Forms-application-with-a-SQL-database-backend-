namespace Esoft_Final_project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.gbStudentReg = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.gbPatrentDetails = new System.Windows.Forms.GroupBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbContactDetails = new System.Windows.Forms.GroupBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbBasicDetails = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRegNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.lnkExit = new System.Windows.Forms.LinkLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbStudentReg.SuspendLayout();
            this.gbPatrentDetails.SuspendLayout();
            this.gbContactDetails.SuspendLayout();
            this.gbBasicDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(238, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(319, 42);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Skills International";
            // 
            // gbStudentReg
            // 
            this.gbStudentReg.Controls.Add(this.btnSearch);
            this.gbStudentReg.Controls.Add(this.btnDelete);
            this.gbStudentReg.Controls.Add(this.btnClear);
            this.gbStudentReg.Controls.Add(this.btnUpdate);
            this.gbStudentReg.Controls.Add(this.btnRegister);
            this.gbStudentReg.Controls.Add(this.gbPatrentDetails);
            this.gbStudentReg.Controls.Add(this.gbContactDetails);
            this.gbStudentReg.Controls.Add(this.gbBasicDetails);
            this.gbStudentReg.Controls.Add(this.cmbRegNo);
            this.gbStudentReg.Controls.Add(this.label1);
            this.gbStudentReg.Location = new System.Drawing.Point(12, 55);
            this.gbStudentReg.Name = "gbStudentReg";
            this.gbStudentReg.Size = new System.Drawing.Size(780, 717);
            this.gbStudentReg.TabIndex = 1;
            this.gbStudentReg.TabStop = false;
            this.gbStudentReg.Text = "Student registration";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(645, 678);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 39);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClear.Location = new System.Drawing.Point(495, 676);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 39);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(210, 677);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 39);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegister.Location = new System.Drawing.Point(51, 677);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(107, 39);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // gbPatrentDetails
            // 
            this.gbPatrentDetails.Controls.Add(this.txtContactNo);
            this.gbPatrentDetails.Controls.Add(this.txtNIC);
            this.gbPatrentDetails.Controls.Add(this.txtParentName);
            this.gbPatrentDetails.Controls.Add(this.label12);
            this.gbPatrentDetails.Controls.Add(this.label11);
            this.gbPatrentDetails.Controls.Add(this.label10);
            this.gbPatrentDetails.Location = new System.Drawing.Point(51, 466);
            this.gbPatrentDetails.Name = "gbPatrentDetails";
            this.gbPatrentDetails.Size = new System.Drawing.Size(701, 193);
            this.gbPatrentDetails.TabIndex = 3;
            this.gbPatrentDetails.TabStop = false;
            this.gbPatrentDetails.Text = "Parent Details";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(127, 146);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(240, 22);
            this.txtContactNo.TabIndex = 5;
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(127, 87);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(240, 22);
            this.txtNIC.TabIndex = 4;
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(127, 27);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(240, 22);
            this.txtParentName.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Contact No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "NIC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Parent Name";
            // 
            // gbContactDetails
            // 
            this.gbContactDetails.Controls.Add(this.txtHomePhone);
            this.gbContactDetails.Controls.Add(this.label9);
            this.gbContactDetails.Controls.Add(this.txtMobile);
            this.gbContactDetails.Controls.Add(this.label8);
            this.gbContactDetails.Controls.Add(this.txtEmail);
            this.gbContactDetails.Controls.Add(this.label7);
            this.gbContactDetails.Controls.Add(this.txtAddress);
            this.gbContactDetails.Controls.Add(this.label6);
            this.gbContactDetails.Location = new System.Drawing.Point(51, 258);
            this.gbContactDetails.Name = "gbContactDetails";
            this.gbContactDetails.Size = new System.Drawing.Size(701, 193);
            this.gbContactDetails.TabIndex = 3;
            this.gbContactDetails.TabStop = false;
            this.gbContactDetails.Text = "Contact Details";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(464, 163);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(219, 22);
            this.txtHomePhone.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Home Phone";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(123, 161);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(202, 22);
            this.txtMobile.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mobile Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(444, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Email";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(105, 20);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(445, 56);
            this.txtAddress.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address";
            // 
            // gbBasicDetails
            // 
            this.gbBasicDetails.Controls.Add(this.rdoFemale);
            this.gbBasicDetails.Controls.Add(this.rdoMale);
            this.gbBasicDetails.Controls.Add(this.dateTimePicker1);
            this.gbBasicDetails.Controls.Add(this.txtLastName);
            this.gbBasicDetails.Controls.Add(this.txtFirstName);
            this.gbBasicDetails.Controls.Add(this.label5);
            this.gbBasicDetails.Controls.Add(this.label4);
            this.gbBasicDetails.Controls.Add(this.label3);
            this.gbBasicDetails.Controls.Add(this.label2);
            this.gbBasicDetails.Location = new System.Drawing.Point(51, 59);
            this.gbBasicDetails.Name = "gbBasicDetails";
            this.gbBasicDetails.Size = new System.Drawing.Size(701, 193);
            this.gbBasicDetails.TabIndex = 2;
            this.gbBasicDetails.TabStop = false;
            this.gbBasicDetails.Text = "Basic Details";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(294, 159);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(74, 20);
            this.rdoFemale.TabIndex = 8;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(144, 158);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(58, 20);
            this.rdoMale.TabIndex = 7;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(123, 74);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(291, 22);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(123, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(291, 22);
            this.txtFirstName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // cmbRegNo
            // 
            this.cmbRegNo.FormattingEnabled = true;
            this.cmbRegNo.Location = new System.Drawing.Point(131, 29);
            this.cmbRegNo.Name = "cmbRegNo";
            this.cmbRegNo.Size = new System.Drawing.Size(261, 24);
            this.cmbRegNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg No";
            // 
            // lnkLogout
            // 
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLogout.Location = new System.Drawing.Point(12, 5);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(84, 25);
            this.lnkLogout.TabIndex = 2;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);
            // 
            // lnkExit
            // 
            this.lnkExit.AutoSize = true;
            this.lnkExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkExit.Location = new System.Drawing.Point(737, 775);
            this.lnkExit.Name = "lnkExit";
            this.lnkExit.Size = new System.Drawing.Size(51, 25);
            this.lnkExit.TabIndex = 3;
            this.lnkExit.TabStop = true;
            this.lnkExit.Text = "Exit";
            this.lnkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExit_LinkClicked);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(469, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 32);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.lnkExit);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.gbStudentReg);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form2";
            this.Text = "Form2";
            this.gbStudentReg.ResumeLayout(false);
            this.gbStudentReg.PerformLayout();
            this.gbPatrentDetails.ResumeLayout(false);
            this.gbPatrentDetails.PerformLayout();
            this.gbContactDetails.ResumeLayout(false);
            this.gbContactDetails.PerformLayout();
            this.gbBasicDetails.ResumeLayout(false);
            this.gbBasicDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox gbStudentReg;
        private System.Windows.Forms.ComboBox cmbRegNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbBasicDetails;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.LinkLabel lnkExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox gbPatrentDetails;
        private System.Windows.Forms.GroupBox gbContactDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Button btnSearch;
    }
}