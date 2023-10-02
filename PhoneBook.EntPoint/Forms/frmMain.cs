using App.Dto;
using App.Services.AddNewContact;
using App.Services.DeleteContact;
using App.Services.GetListContact;
using PhoneBook.EntPoint;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class frmMain : Form
    {
        private readonly IGetListContactService getListContactService;
        private readonly IDeleteContactService deleteContactService;

        public frmMain(IGetListContactService getListContactService, IDeleteContactService deleteContactService)
        {
            InitializeComponent();
            this.getListContactService = getListContactService;
            this.deleteContactService = deleteContactService;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            var contactList = getListContactService.Execute();
            SettingGridView(contactList);

            this.Cursor = Cursors.Default;
        }

        private void SettingGridView(List<ContactListDto> contactList)
        {
            dataGridView1.DataSource = contactList;
            dataGridView1.Columns[0].HeaderText = "شناسه";
            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[2].HeaderText = "شماره تماس";


            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var contstList = getListContactService.Execute(txtSearchKey.Text);
            SettingGridView(contstList);
            this.Cursor = Cursors.Default;
        }

        private void deleteContact_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ResultDto result = deleteContactService.Execue(id);
            if (result.IsSuccess)
            {
                MessageBox.Show(result.message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain_Load(null, null);
            }
            else
                MessageBox.Show(result.message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void ShowDetail()
        {
            var id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frmDetailContact frmDetail = new frmDetailContact(id);
            frmDetail.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var serviceAdd = (IAddNewContactService)Program.ServiceProvider.GetService(typeof(IAddNewContactService));
            frmAddContact addContact = new frmAddContact(serviceAdd);
            addContact.ShowDialog();
            frmMain_Load(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frmEditContact editContact = new frmEditContact(id);
            editContact.ShowDialog();
            frmMain_Load(null, null);
        }
    }
}
