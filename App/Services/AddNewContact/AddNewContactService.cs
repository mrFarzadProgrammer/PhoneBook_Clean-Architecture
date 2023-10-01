using App.DataBase;
using App.Dto;
using Domain.Entities;

namespace App.Services.AddNewContact
{
    public class AddNewContactService : IAddNewContactService
    {
        private readonly IDataBaseContext context;

        public AddNewContactService(IDataBaseContext dataBaseContext)
        {
            this.context = dataBaseContext;
        }
        public ResultDto Execute(AddNewContactDto newContact)
        {
            Contact contact = new Contact(newContact.Name, newContact.LastName, newContact.PhoneNumber, newContact.Company);


            context.Contacts.Add(contact);
            context.SaveChanges();

            return new ResultDto { IsSuccess = true, message = $"مخاطب {contact.Name} {contact.LastName} با موفقیت در دیتابیس ذخیره شد." };
        }
    }
}
