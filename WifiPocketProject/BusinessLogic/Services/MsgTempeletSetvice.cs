using BusinessLogic.DapperCode;
using Domain.Contacts;
using Domain.MsgTemplete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusinessLogic.Services
{
    public class MsgTempeletSetvice
    {
        private readonly DapperRepo _dapperRepo;
        public MsgTempeletSetvice()
        {
            _dapperRepo = new DapperRepo();
        }
        public bool CreateAsync(MsgTempleteMdl.Request mdl)
        {
            var parameters = new
            {
                MessageId = mdl.MessageId,
                MessageText = mdl.MessageText,
                CreatedAt = DateTime.Now,
                Status = mdl.Status,
                Description = mdl.Description,
                Refrence = mdl.Refrence,
                MsgType = mdl.MsgType
            };

            string query = @"
                   INSERT INTO tblMessages (MessageText, CreatedAt, Status, Description, Refrence, MsgType) 
                  OUTPUT INSERTED.MessageId 
                   VALUES (@MessageText, @CreatedAt, @Status, @Description, @Refrence, @MsgType)";

            int result = _dapperRepo.Insert<int>(query, parameters, CommandTypeEnum.Text);
            return result > 0;
        }


        public List<MsgTempleteMdl.Response> GetListAsync()
        {
            string query = @"SELECT * FROM tblMessages";
            List<MsgTempleteMdl.Response> list = null;
            list = _dapperRepo.ExecuteList<MsgTempleteMdl.Response>(query, null, CommandTypeEnum.Text).ToList();
            return list;
        }
    }
}
