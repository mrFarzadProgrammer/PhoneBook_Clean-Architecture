using App.Dto;

namespace App.Services.EditContact
{
    public interface IEditContactService
    {
        ResultDto Execute(EditContactDto editContact);
    }
}
