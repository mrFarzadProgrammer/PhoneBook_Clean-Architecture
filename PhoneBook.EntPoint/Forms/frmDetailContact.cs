using System;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class frmDetailContact : Form
    {
        private readonly int ContactId;
        public frmDetailContact(int ContactId)
        {
            InitializeComponent();
            this.ContactId = ContactId;
        }

        private void frmDetailContact_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
