using App.DataBase;
using App.Services.AddNewContact;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook.EntPoint.Forms
{
    public partial class AddNewContact : Form
    {
        private readonly IAddNewContactService iAddNewContactService;

        public AddNewContact(IAddNewContactService IAddNewContactService)
        {
            InitializeComponent();
            iAddNewContactService = IAddNewContactService;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = iAddNewContactService.Execute(new AddNewContactDto
            {
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rtxtDescription_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCompany_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
