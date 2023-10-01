using App.Dto;
using System;

namespace App.Services.AddNewContact
{
    public interface IAddNewContactService
    {
        ResultDto Execute(AddNewContactDto addNewContactDto);
    }
}
