using App.DataBase;
using App.Dto;

namespace App.Services.GetContactDetails
{
    public class GetContactDetailsService : IGetContactDetailsService
    {
        private readonly IDataBaseContext dataBaseContext;

        public GetContactDetailsService(IDataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }
        public ResultDto<ContactDetailDto> Execute(int id)
        {
            var contact = dataBaseContext.Contacts.Find(id);
            if (contact == null)
            {
                return new ResultDto<ContactDetailDto>
                {
                    IsSuccess = false,
                    Message = "مخاطب یافت نشد."
                };

            }

            var data = new ContactDetailDto
            {
                Id = contact.Id,
                Name = contact.Name,
                LastName = contact.LastName,
                Company = contact.Company,
                PhoneNumber = contact.PhoneNumber,
                Address = contact.Address,
                CreateAt = contact.CreateAt,
                Description = contact.Description
            };

            return new ResultDto<ContactDetailDto>
            {
                IsSuccess = true,
                Data = data
            };
        }
    }
}
