using Library.Business.Abstruct;
using Library.DataAccess.Abstruct;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Concrete
{
    public class MemberManager : IMemberService
    {
        private IMemberDal _memberDal;
        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }
        public List<Member> GetAll()
        {
            return _memberDal.GetAll();
        }
    }
}
