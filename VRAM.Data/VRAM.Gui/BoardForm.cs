using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRAM.Gui
{
    public partial class BoardForm : Form
    {
        public BoardForm()
        {
            InitializeComponent();
        }

       

        private void btnWrite_Click(object sender, EventArgs e)
        {
            WriteForm writeForm = new WriteForm();
            writeForm.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void tabMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    lbl_Board.Text = "게시판";
                    //                    userControl_nonadmin1.Show();//if 들어가야됨
                    break;

                case 1:
                    lbl_Board.Text = "내 글 모음";
                    break;

                case 2:
                    lbl_Board.Text = "출결 현황";
                    MessageBox.Show("본다고 달라지니?", "Notice");
                    break;
            }
        }
    }
}
