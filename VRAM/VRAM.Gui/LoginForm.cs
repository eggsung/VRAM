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

        // 등록
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }


        // 로그인
        private void btnLogin_Click(object sender, EventArgs e)
        {           
            if (txtMemeberId.Text != "" && txtPassword.Text != "")
            {
                // 로그인 성공
                if (MemberData.GetMemberId().Contains(txtMemeberId.Text) &&
                    MemberData.GetMemberPassword().Contains(txtPassword.Text))
                {
                    this.Hide();
                    BoardForm boardForm = new BoardForm();
                    boardForm.ShowDialog();
                    this.Close();
                }
                
                // 아이디만 일치
                else if (MemberData.GetMemberId().Contains(txtMemeberId.Text))

                {
                    MessageBox.Show("비밀번호를 다시 확인해주세요.");
                }

                // 회원이 아닐 경우
                else
                {
                    MessageBox.Show("회원이 아닙니다.");
                }
            }
            else
            {
                MessageBox.Show("ID와 Password를 입력해주세요.");
             
            }
        }
    }
}
