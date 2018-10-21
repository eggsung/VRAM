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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }


        // 리셋
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMemberId.Clear();
            txtMemberName.Clear();
            txtPhoneNum.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }

        // 등록
        public void btnRegister_Click(object sender, EventArgs e)
        {
            Member m = new Member();
            m.MemberId = txtMemberId.Text.Trim();
            m.MemberName = txtMemberName.Text.Trim();
            m.PhoneNum = txtPhoneNum.Text.Trim();
            m.Email = txtEmail.Text.Trim();
            m.Password = txtPassword.Text.Trim();

            // 기존의 ID가 있는 경우
            if (MemberData.GetMemberId().Contains(m.MemberId))
            {
                MessageBox.Show("이미 존재하는 ID입니다.");
            }
            else
            {
                DataRepository.Member.Insert(m);
                MessageBox.Show("회원가입이 완료되었습니다.");
            }

        }
    }
}
