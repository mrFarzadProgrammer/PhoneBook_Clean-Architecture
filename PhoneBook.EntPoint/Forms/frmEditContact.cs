using System;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class frmEditContact : Form
    {
        private readonly int ContactId;
        public frmEditContact(int ContactId)
        {
            InitializeComponent();
            this.ContactId = ContactId;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditContact_Load(object sender, EventArgs e)
        {

        }
    }
}
