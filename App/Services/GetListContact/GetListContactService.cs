using App.DataBase;
using System.Collections.Generic;
using System.Linq;

namespace App.Services.GetListContact
{
    public class GetListContactService : IGetListContactService
    {
        private readonly IDataBaseContext dataBaseContext;

        public GetListContactService(IDataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }
        public List<ContactListDto> Execute(string searchKey = null)
        {
            var contactQuery = dataBaseContext.Contacts.AsQueryable();

            if (!string.IsNullOrEmpty(searchKey))
            {
                contactQuery = contactQuery.Where(c =>
                      c.Name.Contains(searchKey)
                   || c.LastName.Contains(searchKey)
                   || c.PhoneNumber.Contains(searchKey)
                   || c.Company.Contains(searchKey)
                );
            }

            var data = contactQuery.Select(c => new ContactListDto
            {
                Id = c.Id,
                FullName = $"{c.Name} {c.LastName}",
                PhoneNumber = c.PhoneNumber
            }).ToList();

            return data;
        }
    }
}
