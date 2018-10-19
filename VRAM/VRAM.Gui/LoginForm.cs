using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRAM.Data;

namespace VRAM.Gui
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        if (txtMemeberId.Text == "" || txtPassword.Text == "")
           {
               MessageBox.Show("Please provide MemberId and Password");
               return;
           }
           try
           {
              
               if (MemberData.GetMemberId().Contains(txtMemeberId.Text) && MemberData.GetMemberPassword().Contains(txtPassword.Text))
               {
                   Credential.Instance.Load(txtMemeberId.Text);
                        MessageBox.Show("Login Successful!");
                        this.Hide();
                        BoardForm boardForm = new BoardForm();
                        boardForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
           }
    }
}
