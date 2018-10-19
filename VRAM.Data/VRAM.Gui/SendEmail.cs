using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRAM.Cui;

namespace VRAM.Gui
{
    public partial class SendEmail : Form
    {
        
        public SendEmail()
        {
            InitializeComponent();
        }

        private void txtToAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            string toAddress = this.txtToAddress.Text;
            string subject = this.txtSubject.Text;
            string body = txtBody.Text;
            string sendAddress = txtFromAddress.Text;

            Mail mail = new Mail(sendAddress);

            if (toAddress == null)
            {
                MessageBox.Show("받을 사람 메일 주소를 입력해 주세요");

            }
            if (subject == null)
            {
                MessageBox.Show("받을 사람 메일 주소를 입력해 주세요");

            }
            if (body == null)
            {
                MessageBox.Show("받을 사람 메일 주소를 입력해 주세요");

            }

            mail.SetToAddress(toAddress);
        }
    }
}
