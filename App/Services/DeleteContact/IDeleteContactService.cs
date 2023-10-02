using App.Dto;

namespace App.Services.DeleteContact
{
    public interface IDeleteContactService
    {
        ResultDto Execue(int id);
    }
}
