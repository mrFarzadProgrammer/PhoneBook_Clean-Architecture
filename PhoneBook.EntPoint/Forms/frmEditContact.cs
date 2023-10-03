using App.Services.EditContact;
using App.Services.GetContactDetails;
using System;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class frmEditContact : Form
    {
        private readonly int ContactId;
        private readonly IGetContactDetailsService getContactDetailsService;
        private IEditContactService EditContactService { get; }

        public frmEditContact(int ContactId, IEditContactService editContactService, IGetContactDetailsService getContactDetailsService)
        {
            InitializeComponent();
            this.ContactId = ContactId;
            EditContactService = editContactService;
            this.getContactDetailsService = getContactDetailsService;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            var result = EditContactService.Execute(new EditContactDto
            {
                Id = ContactId,
                Name = txtName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Company = txtCompany.Text,
                Description = rtxtDescription.Text,
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditContact_Load(object sender, EventArgs e)
        {
            var contact = getContactDetailsService.Execute(ContactId);
            if (!contact.IsSuccess)
            {
                MessageBox.Show(contact.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtName.Text = contact.Data.Name;
                txtLastName.Text = contact.Data.LastName;
                txtPhoneNumber.Text = contact.Data.PhoneNumber;
                rtxtDescription.Text = contact.Data.Description;
                txtCompany.Text = contact.Data.Company;
            }
        }
    }
}
