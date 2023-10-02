using App.Services.AddNewContact;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class frmAddContact : Form
    {
        private readonly IAddNewContactService addNewContactService;

        public frmAddContact(IAddNewContactService addNewContactService)
        {
            InitializeComponent();
            this.addNewContactService = addNewContactService;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var result = addNewContactService.Execute(new AddNewContactDto
            {
                Name = txtName.Text,
                LastName = txtLastName.Text,
                Company = txtCompany.Text,
                Description = rtxtDescription.Text,
                PhoneNumber = txtPhoneNumber.Text,
            });

            if (result.IsSuccess)
            {
                MessageBox.Show(result.message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result.message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
