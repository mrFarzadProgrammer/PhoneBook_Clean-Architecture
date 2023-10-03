using App.Dto;

namespace App.Services.GetContactDetails
{
    public interface IGetContactDetailsService
    {
        ResultDto<ContactDetailDto> Execute(int id);
    }
}
