﻿using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Abstruct
{
    public interface IMemberService
    {
        List<Member> GetAll();
    }
}
