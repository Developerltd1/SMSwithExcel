using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Contacts
{
    public class ContactCreateMdl
    {
        #region Create
        public class Request
        {
            public int ContactID { get; set; }  // Not nullable (unchecked in DB)

            [Required(ErrorMessage = "Name is required.")]
            [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Mobile number is required.")]
            [StringLength(30, ErrorMessage = "Mobile number cannot exceed 30 characters.")]
            public string MobileNumber { get; set; }

            [StringLength(15, ErrorMessage = "Status cannot exceed 15 characters.")]
            public string Status { get; set; }

            public DateTime? EntryDate { get; set; }  // Nullable

            [StringLength(99, ErrorMessage = "Description cannot exceed 99 characters.")]
            public string Description { get; set; }

            [StringLength(99, ErrorMessage = "Reference name cannot exceed 99 characters.")]
            public string RefrenceName { get; set; }

            [StringLength(99, ErrorMessage = "Sheet name cannot exceed 99 characters.")]
            public string SheetName { get; set; }
            public string SheetSNo { get; set; }
            public string LoopRowNo { get; set; }


            public string ChechStatus { get; set; }

        }
        public class Response
        {

        }
        #endregion

    }
}
