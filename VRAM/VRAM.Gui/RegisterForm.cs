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
            m.MemberId = txtMemberId.ToString();
            m.MemberName = txtMemberName.ToString();
            m.PhoneNum = txtPhoneNum.ToString();
            m.Email = txtEmail.ToString();
            m.Password = txtPassword.ToString();
            
            // 관리자 버튼이 클릭되면
            if (rbAdmin.Checked == true)
            {
                using (VRAMEntities context = new VRAMEntities())
                {
                    MemberRole mr = new MemberRole();
                    //mr.MemberId = ;
                    mr.RoleId = 1;
                    context.MemberRoles.Add(mr);
                    context.SaveChanges();
                }
            }
            else
            {
                using (VRAMEntities context = new VRAMEntities())
                {
                    MemberRole mr = new MemberRole();
                    mr.MemberId = MemberData.GetOwnMemberId(txtMemberId.Text);
                    mr.RoleId = 2;
                    context.MemberRoles.Add(mr);
                    context.SaveChanges();
                }
            }

            DataRepository.Member.Insert(m);
        }
    }
}
