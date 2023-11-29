namespace RolesAndUserMigrationGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtRoleName = new TextBox();
            grpRoles = new GroupBox();
            chkRole = new CheckBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            chkUser = new CheckBox();
            txtDomain = new TextBox();
            txtUserName = new TextBox();
            btnGenerate = new Button();
            txtSQLResult = new TextBox();
            chkLink = new CheckBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txtCSharpUp = new TextBox();
            tabPage3 = new TabPage();
            txtCSharpDown = new TextBox();
            grpRoles.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // txtRoleName
            // 
            txtRoleName.Location = new Point(106, 24);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(209, 23);
            txtRoleName.TabIndex = 1;
            // 
            // grpRoles
            // 
            grpRoles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpRoles.Controls.Add(chkRole);
            grpRoles.Controls.Add(txtRoleName);
            grpRoles.Location = new Point(12, 12);
            grpRoles.Name = "grpRoles";
            grpRoles.Size = new Size(335, 67);
            grpRoles.TabIndex = 2;
            grpRoles.TabStop = false;
            grpRoles.Text = "Role";
            // 
            // chkRole
            // 
            chkRole.AutoSize = true;
            chkRole.Checked = true;
            chkRole.CheckState = CheckState.Checked;
            chkRole.Location = new Point(17, 26);
            chkRole.Name = "chkRole";
            chkRole.Size = new Size(84, 19);
            chkRole.TabIndex = 0;
            chkRole.Text = "Role Name";
            chkRole.UseVisualStyleBackColor = true;
            chkRole.CheckedChanged += chkRole_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(chkUser);
            groupBox1.Controls.Add(txtDomain);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Location = new Point(12, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 89);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 27);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 9;
            label2.Text = "Pass";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(229, 24);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(86, 23);
            txtPassword.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 56);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 10;
            label1.Text = "Domain";
            // 
            // chkUser
            // 
            chkUser.AutoSize = true;
            chkUser.Checked = true;
            chkUser.CheckState = CheckState.Checked;
            chkUser.Location = new Point(17, 26);
            chkUser.Name = "chkUser";
            chkUser.Size = new Size(84, 19);
            chkUser.TabIndex = 2;
            chkUser.Text = "User Name";
            chkUser.UseVisualStyleBackColor = true;
            chkUser.CheckedChanged += chkUser_CheckedChanged;
            // 
            // txtDomain
            // 
            txtDomain.Location = new Point(106, 53);
            txtDomain.Name = "txtDomain";
            txtDomain.Size = new Size(209, 23);
            txtDomain.TabIndex = 5;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(106, 24);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(86, 23);
            txtUserName.TabIndex = 3;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGenerate.Location = new Point(13, 203);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(334, 26);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtSQLResult
            // 
            txtSQLResult.Dock = DockStyle.Fill;
            txtSQLResult.Location = new Point(3, 3);
            txtSQLResult.Multiline = true;
            txtSQLResult.Name = "txtSQLResult";
            txtSQLResult.Size = new Size(332, 189);
            txtSQLResult.TabIndex = 8;
            // 
            // chkLink
            // 
            chkLink.AutoSize = true;
            chkLink.Location = new Point(105, 84);
            chkLink.Name = "chkLink";
            chkLink.Size = new Size(149, 19);
            chkLink.TabIndex = 6;
            chkLink.Text = "Link (AspNetUserRoles)";
            chkLink.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(9, 245);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(346, 223);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtSQLResult);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(338, 195);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "SQL Script";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtCSharpUp);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(338, 195);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "C# Migration (UP)";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCSharpUp
            // 
            txtCSharpUp.Dock = DockStyle.Fill;
            txtCSharpUp.Location = new Point(3, 3);
            txtCSharpUp.Multiline = true;
            txtCSharpUp.Name = "txtCSharpUp";
            txtCSharpUp.Size = new Size(332, 189);
            txtCSharpUp.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txtCSharpDown);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(338, 195);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "C# Migration (Down)";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtCSharpDown
            // 
            txtCSharpDown.Dock = DockStyle.Fill;
            txtCSharpDown.Location = new Point(0, 0);
            txtCSharpDown.Multiline = true;
            txtCSharpDown.Name = "txtCSharpDown";
            txtCSharpDown.Size = new Size(338, 195);
            txtCSharpDown.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 474);
            Controls.Add(tabControl1);
            Controls.Add(chkLink);
            Controls.Add(btnGenerate);
            Controls.Add(groupBox1);
            Controls.Add(grpRoles);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Role & User Migration Script Generator";
            grpRoles.ResumeLayout(false);
            grpRoles.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRoleName;
        private GroupBox grpRoles;
        private CheckBox chkRole;
        private GroupBox groupBox1;
        private CheckBox chkUser;
        private TextBox txtUserName;
        private Button btnGenerate;
        private TextBox txtSQLResult;
        private CheckBox chkLink;
        private Label label1;
        private TextBox txtDomain;
        private TextBox txtPassword;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtCSharpUp;
        private TabPage tabPage3;
        private TextBox txtCSharpDown;
    }
}
