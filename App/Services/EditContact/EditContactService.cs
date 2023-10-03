using App.DataBase;
using App.Dto;

namespace App.Services.EditContact
{
    public class EditContactService : IEditContactService
    {
        private readonly IDataBaseContext context;

        public EditContactService(IDataBaseContext dataBaseContext)
        {
            this.context = dataBaseContext;
        }
        public ResultDto Execute(EditContactDto editContact)
        {
            var contact = context.Contacts.Find(editContact.Id);
            if (contact == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    message = "مخاطب یافت نشد."
                };
            }
            contact.Name = editContact.Name;
            contact.LastName = editContact.LastName;
            contact.PhoneNumber = editContact.PhoneNumber;
            contact.Address = editContact.Address;
            contact.Company = editContact.Company;
            contact.Description = editContact.Description;

            context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                message = "اطلاعات مخاطب با موفقیت ویرایش شد."
            };
        }
    }
}
