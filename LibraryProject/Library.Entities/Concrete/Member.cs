using Library.Entities.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concrete
{
    public class Member:IEntity
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public int BookId { get; set; }
        public string DateOfRegistration { get; set; }
        public int RemainingReturnDay { get; set; }
    }
}
