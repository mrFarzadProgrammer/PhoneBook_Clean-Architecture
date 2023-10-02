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
        public List<ContactListDto> Execute()
        {
            var contacts = dataBaseContext.Contacts.Select(c => new ContactListDto
            {
                Id = c.Id,
                FullName = $"{c.Name} {c.LastName}",
                PhoneNumber = c.PhoneNumber,
            }).ToList();
            return contacts;
        }
    }
}
