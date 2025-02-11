using BusinessLogic.DapperCode;
using Domain.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class ContactServices
    {
        private readonly DapperRepo _dapperRepo;
        public async Task<bool> CreateAsync(ContactCreateMdl.Request contact)
        {
            var parameters = new
            {
                contact.ContactID,
                contact.Name,
                contact.MobileNumber,
                contact.Status,
                contact.EntryDate,
                contact.Description,
                contact.RefrenceName,
                contact.SheetName
            };

            string query = @"INSERT INTO Contacts (Name, MobileNumber, Status, EntryDate, Description, RefrenceName, SheetName) 
                 OUTPUT INSERTED.ContactID 
                 VALUES (@Name, @MobileNumber, @Status, @EntryDate, @Description, @RefrenceName, @SheetName)";

            int result = await _dapperRepo.InsertAsync<int>(query, parameters, CommandTypeEnum.Text);
            return result > 0;
        }


    }
}
