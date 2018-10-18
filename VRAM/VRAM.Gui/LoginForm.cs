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
            boardForm.ShowDialog();
        }
    }
}
