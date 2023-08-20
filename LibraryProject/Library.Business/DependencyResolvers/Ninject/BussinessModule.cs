using Library.Business.Abstruct;
using Library.Business.Concrete;
using Library.DataAccess.Abstruct;
using Library.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.DependencyResolvers.Ninject
{
    public class BussinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMemberService>().To<MemberManager>().InSingletonScope();
            Bind<IMemberDal>().To<EfMemberDal>().InSingletonScope();
        }
    }
}
