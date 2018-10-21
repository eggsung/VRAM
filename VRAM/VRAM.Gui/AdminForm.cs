using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRAM.Data;

namespace VRAM.Gui
{
    public partial class AdminForm : Form
    {
        private Member member = new Member();
        private MemberData memberData = new MemberData();
        public AdminForm()
        {
            InitializeComponent();
            PopulateDataGridView();
        }
        
        void Clear()
        {
            txtMemberName1.Text = txtEmail.Text = txtMemberId.Text = txtPassword.Text = txtPhoneNum.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            
        }
        void PopulateDataGridView()
        {
            dgvSearch.AutoGenerateColumns = false;
            memberData = new MemberData();
            dgvSearch.DataSource = memberData.Select();

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            dgvSearch.DataSource = MemberInfoData.GetMemberInfo(txtMemberName.Text);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            member.MemberId = txtMemberId.Text.Trim();
            member.MemberName = txtMemberName1.Text.Trim();
            member.Password = txtPassword.Text.Trim();
            member.PhoneNum = txtPhoneNum.Text.Trim();
            member.Email = txtEmail.Text.Trim();

            using (VRAMEntities db = new VRAMEntities())
            {
                dgvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                if (dgvSearch.SelectionMode == 0) //insert

                    db.Members.Add(member);
                else //update
                    db.Entry(member).State = EntityState.Modified;
                db.SaveChanges();
            }

         
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Success");
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?", "EF_CRUD_OPERATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (VRAMEntities db = new VRAMEntities())
                {
                    var entry = db.Entry(member);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Members.Attach(member);
                    }

                    db.Members.Remove(member);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Delete Success");
                }
        }

        private void dgvSearch_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSearch.CurrentRow.Index != -1)
            {
                member.MemberName = (dgvSearch.CurrentRow.Cells["MemberName"].Value).ToString();
                using (VRAMEntities db = new VRAMEntities())
                {
                    member = db.Members.FirstOrDefault(x => x.MemberName == member.MemberName);
                    txtMemberName1.Text = member.MemberName;
                    txtMemberId.Text = member.MemberId;
                    txtPassword.Text = member.Password;
                    txtPhoneNum.Text = member.PhoneNum;
                    txtEmail.Text = member.Email;

                }

                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }
    }
}
