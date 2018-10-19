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
            RegisterForm registerFrForm = new RegisterForm();
            registerFrForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            BoardForm boardForm = new BoardForm();

            // 로그인 기능 구현 
            List<string> IdList = MemberData.GetMemberId();
            List<string> PwList = MemberData.GetMemberPassword();

            foreach (var Id in IdList)
            {
                foreach (var Pw in PwList)
                {
                    CheckLogin(Id, Pw);
                }
            }

            void CheckLogin(string id, string pw)
            {

                if (id == txtMemeberId.Text && pw == txtPassword.Text)
                {
                    Credential.Instance.Load(txtMemeberId.Text);
                    if (Credential.Instance.HasRole("Admin"))
                    {
                        Show(new AdminForm());
                    }
                    else
                    {
                        Show(new BoardForm());
                    }

                    this.Visible = false;
                    boardForm.ShowDialog();

                }

                this.Close();

            }
        }
    }
}
