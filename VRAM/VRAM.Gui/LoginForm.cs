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
               MessageBox.Show("ID와 Password를 입력해주세요.");
               return;
           }
        else if (MemberData.GetMemberId().Contains(txtMemeberId.Text) && MemberData.GetMemberPassword().Contains(txtPassword.Text))
        {
            Credential.Instance.Load(txtMemeberId.Text);
            this.Hide();
            BoardForm boardForm = new BoardForm();
            boardForm.ShowDialog();
            this.Close();
        }
        else if (MemberData.GetMemberId().Contains(txtMemeberId.Text))
        {
            MessageBox.Show("비밀번호를 확인해주세요.");
        }

            try
                {

                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show("회원이 아닙니다. ");
                }
            
        }

    }
}
