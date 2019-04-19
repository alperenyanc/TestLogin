using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLogin.DAL.ORM.Enum;

namespace TestLogin.DAL.ORM.Interface
{
    public interface IBaseEntity
    {
        Guid ID { get; set; }
        DateTime AddDate { get; set; }
        DateTime UpdateDate { get; set; }
        DateTime DeleteDate { get; set; }
        Status Status { get; set; }
    }
}
