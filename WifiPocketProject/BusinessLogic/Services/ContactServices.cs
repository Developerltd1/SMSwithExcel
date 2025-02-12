using BusinessLogic.DapperCode;
using Domain.Contacts;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Contacts.ContactCreateMdl;

namespace BusinessLogic.Services
{
    public class ContactServices
    {
        private readonly DapperRepo _dapperRepo;
        public ContactServices()
        {
            _dapperRepo = new DapperRepo();
        }
        public bool CreateAsync(ContactCreateMdl.Request contact, out int IsMobileNumberExists )
        {
            // Ensure the out parameter is always assigned
            IsMobileNumberExists = 0;

            if (!string.IsNullOrEmpty(contact.MobileNumber))
            {
                // Check if the MobileNumber already exists
                string checkQuery = "SELECT ContactID FROM tblContacts WHERE MobileNumber = @MobileNumber";
                var parameters1 = new
                {
                    MobileNumber = contact.MobileNumber
                };
                IsMobileNumberExists = _dapperRepo.ExecuteScalar<int>(checkQuery, parameters1, CommandTypeEnum.Text);
                if (IsMobileNumberExists > 0)
                {

                    var parameters0 = new
                    {
                        Contact_Id = IsMobileNumberExists,
                        Name = contact.Name,
                        MobileNumber = contact.MobileNumber,
                        Status = "Duplicate",
                        EntryDate = DateTime.Now,
                        Description = contact.Description,
                        RefrenceName = contact.RefrenceName,
                        SheetName = contact.SheetName,
                        LoopRowNo = contact.LoopRowNo,
                        SheetSNo = contact.SheetSNo
                    };

                    string query0 = @"INSERT INTO tblDuplicateContacts (Contact_Id, Name, MobileNumber, Status, EntryDate, Description, RefrenceName, SheetName, LoopRowNo, SheetSNo) 
                                      OUTPUT INSERTED.DuplicateContactID 
                                      VALUES (@Contact_Id, @Name, @MobileNumber, @Status, @EntryDate, @Description, @RefrenceName, @SheetName, @LoopRowNo, @SheetSNo)";

                    int result0 = _dapperRepo.Insert<int>(query0, parameters0, CommandTypeEnum.Text);



                    return false; // MobileNumber already exists, do not insert
                }
            }

            var parameters = new
            {
                ContactID = contact.ContactID,
                Name = contact.Name,
                MobileNumber = contact.MobileNumber,
                Status = contact.Status,
                EntryDate = DateTime.Now,
                Description = contact.Description,
                RefrenceName = contact.RefrenceName,
                SheetName = contact.SheetName,
                LoopRowNo = contact.LoopRowNo,
                SheetSNo = contact.SheetSNo
            };

            string query = @"INSERT INTO tblContacts (Name, MobileNumber, Status, EntryDate, Description, RefrenceName, SheetName, LoopRowNo, SheetSNo) 
                 OUTPUT INSERTED.ContactID 
                 VALUES (@Name, @MobileNumber, @Status, @EntryDate, @Description, @RefrenceName, @SheetName, @LoopRowNo, @SheetSNo)";

            int result = _dapperRepo.Insert<int>(query, parameters, CommandTypeEnum.Text);
            return result > 0;
        }

        public bool ExceptionAsync(ExceptionMdl.Request model)
        {
            var parameters = new
            {
                ErrorMessage = model.ErrorMessage,
                ErrorInnerMessage = model.ErrorInnerMessage,
                FuncationName = model.FuncationName,
                EntryDate = DateTime.Now,
                SheetName = model.SheetName,
                SheetSNo = model.SheetSNo,
                Status = model.Status
            };

            string query = @"
                    INSERT INTO tblError (ErrorMessage, ErrorInnerMessage, FuncationName, EntryDate, SheetName, SheetSNo,Status)
                    VALUES (@ErrorMessage, @ErrorInnerMessage, @FuncationName, @EntryDate, @SheetName, @SheetSNo,@Status)";

            int result = _dapperRepo.Insert<int>(query, parameters, CommandTypeEnum.Text);
            return result > 0;
        }


    }
}
