using App.DataBase;
using App.Dto;

namespace App.Services.DeleteContact
{
    public class DeleteContactService : IDeleteContactService
    {
        private readonly IDataBaseContext context;

        public DeleteContactService(IDataBaseContext dataBaseContext)
        {
            this.context = dataBaseContext;
        }
        public ResultDto Execue(int id)
        {
            var contact = context.Contacts.Find(id);
            if (contact != null)
            {
                context.Contacts.Remove(contact);
                context.SaveChanges();
                return new ResultDto
                {
                    IsSuccess = true,
                    message = "مخاطب با موفقیت حذف شد."
                };
            }
            return new ResultDto
            {
                IsSuccess = false,
                message = "مخاطب یافت نشد."
            };
        }
    }
}
