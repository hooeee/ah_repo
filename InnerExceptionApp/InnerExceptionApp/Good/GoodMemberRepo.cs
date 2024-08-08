using InnerExceptionApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerExceptionApp.Repository;

public class GoodMemberRepo
{

    public Member update(Member member)
    {
        member.Name += member.Name;
        throw new Exception("123");
        return member;
    }


    public Member insert(Member member)
    {
        return member;
    }


}
