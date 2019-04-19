using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLogin.DAL.ORM.Enum;
using TestLogin.DAL.ORM.Interface;

namespace TestLogin.DAL.ORM.Entity
{
   public  class BaseEntity : IBaseEntity
    {

        public Guid ID { get; set; }

        private DateTime _addDate = DateTime.Now;
        public DateTime AddDate { get { return _addDate; } set { _addDate = value; } }

        private DateTime _updateDate = DateTime.Now;
        public DateTime UpdateDate { get { return _updateDate; } set { _updateDate = value; } }

        private DateTime _deleteDate = DateTime.Now;
        public DateTime DeleteDate { get { return _deleteDate; } set { _deleteDate = value; } }

        private Status _status = TestLogin.DAL.ORM.Enum.Status.Active;
        public Status Status { get { return _status; } set { _status = value; } }
    }
}
