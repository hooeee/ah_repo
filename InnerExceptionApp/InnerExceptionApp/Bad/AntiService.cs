using InnerExceptionApp.Models;
using InnerExceptionApp.Repository;
using InnerModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace InnerExceptionApp.Services;

public class AntiService
{

    private AntiMemberRepo repo = new AntiMemberRepo();
    private 외부라이브러리 lib = new 외부라이브러리();

    public bool 함수(string data, int i)
    {
        var isConnection = lib.isConnection();
        var inserted = repo.insert(new Member() { Name = data });

        if (!inserted) return false;

       if (isConnection)
        {
            // bool 을 처리해서
            var member = repo.get(1);
            var updatedMember = repo.update(member);
        }
        lib.실행해주세요();
        return true;
    }
}
