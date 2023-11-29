using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace RolesAndUserMigrationGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkRole_CheckedChanged(object sender, EventArgs e)
        {
            this.txtRoleName.Enabled = chkRole.Checked;
        }

        private void chkUser_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPassword.Enabled = this.txtDomain.Enabled = this.txtUserName.Enabled = chkUser.Checked;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (Check())
                Generate();
        }

        private bool Check()
        {
            txtRoleName.Text = txtRoleName.Text.Trim();
            txtUserName.Text = txtUserName.Text.Trim();
            txtPassword.Text = txtPassword.Text.Trim();
            txtDomain.Text = txtDomain.Text.Trim();

            if (chkRole.Checked && string.IsNullOrWhiteSpace(txtRoleName.Text))
            {
                MessageBox.Show("Invalid Role Input");
                return false;
            }


            if (chkUser.Checked && (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                                    string.IsNullOrWhiteSpace(txtDomain.Text)))
            {
                MessageBox.Show("Invalid User Input");
                return false;
            }

            if(chkLink.Checked && (!chkRole.Checked || !chkUser.Checked))
            {
                MessageBox.Show("In case of Link you should specify a Role & a User");
                return false;
            }


            return true;


        }

        private void Generate()
        {
            List<string> retSql = new List<string>();
            List<string> retCSharpUp = new List<string>();
            List<string> retCSharpDown = new List<string>();

            var role = new
            {
                Id = Guid.NewGuid().ToString(),
                Name = txtRoleName.Text.Trim()
            };

            var user = new
            {
                Id = Guid.NewGuid().ToString(),
                Name = txtUserName.Text.Trim() + "@" + txtDomain.Text,
                Email = txtUserName.Text.Trim() + "@" + txtDomain.Text,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, this.txtPassword.Text),
                SecurityStamp = Guid.NewGuid().ToString("D")
            };

            if (chkRole.Checked)
            {
                retSql.Add($"INSERT INTO dbo.AspNetRoles(Id,Name,NormalizedName) VALUES('{role.Id}', '{role.Name}', '{role.Name.ToUpper()}')");
                retCSharpUp.Add($"migrationBuilder.Sql(\"{retSql.Last()}\");");
                retCSharpDown.Add($"migrationBuilder.Sql(\"DELETE FROM [dbo].[AspNetRoles] WHERE Id = '{role.Id}'\");");
            }

            if (chkUser.Checked)
            {
                retSql.Add($"INSERT INTO dbo.AspNetUsers(Id, UserName, NormalizedUserName,  Email, NormalizedEmail, EmailConfirmed,PhoneNumberConfirmed, LockoutEnabled,TwoFactorEnabled, AccessFailedCount, PasswordHash,SecurityStamp) VALUES('{user.Id}','{user.Name}','{user.Name.ToUpper()}','{user.Email}','{user.Email.ToUpper()}',1,0,0,0,0,'{user.PasswordHash}','{user.SecurityStamp}')");
                retCSharpUp.Add($"migrationBuilder.Sql(\"{retSql.Last()}\");");
                retCSharpDown.Add($"migrationBuilder.Sql(\"DELETE FROM [dbo].[AspNetUsers] WHERE Id = '{user.Id}'\");");
            }

            if (chkLink.Checked)
            {
                retSql.Add($"INSERT INTO [dbo].[AspNetUserRoles]([UserId],[RoleId])VALUES('{user.Id}','{role.Id}')");
                retCSharpUp.Add($"migrationBuilder.Sql(\"{retSql.Last()}\");");
            }

            this.txtSQLResult.Text = string.Join(Environment.NewLine, retSql);
            this.txtCSharpUp.Text = string.Join(Environment.NewLine, retCSharpUp);
            this.txtCSharpDown.Text = string.Join(Environment.NewLine, retCSharpDown);
        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtSQLResult.Text);
            MessageBox.Show("Text Copied To Clipboard");
        }
    }
}
