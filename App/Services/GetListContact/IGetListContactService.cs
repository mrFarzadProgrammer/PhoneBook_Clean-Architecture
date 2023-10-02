using System.Collections.Generic;

namespace App.Services.GetListContact
{
    public interface IGetListContactService
    {
        List<ContactListDto> Execute(string searchKey = null);
    }
}
