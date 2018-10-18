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
    }
}
