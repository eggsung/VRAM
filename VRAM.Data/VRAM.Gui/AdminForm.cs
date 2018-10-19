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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (VRAMEntities db = new VRAMEntities())
            {
                dgvSearch.AutoGenerateColumns = false;
                //List<Member> list = db.Members.ToList();
                string Searchname= txtMemberName.Text.Trim();
                if (Searchname.Equals(""))
                {
                    MessageBox.Show("이름을 적지 않았습니다.");
                }
                else
                {
                    List<Member> list = db.Members.SqlQuery("SELECT * FROM Member WHERE MemberName = '" + Searchname + "'").ToList();
                    dgvSearch.DataSource = list;
                    
                }


            }

            
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            using (VRAMEntities db = new VRAMEntities())
            {
                dgvSearch.AutoGenerateColumns = false;
                List<Member> list = db.Members.SqlQuery("SELECT * FROM Member").ToList();
                dgvSearch.DataSource = list;
            }
        }
    }
}
