using InnerExceptionApp.Models;
using InnerExceptionApp.Repository;
using InnerModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace InnerExceptionApp.Good;

public class GoodService
{

    private GoodMemberRepo repo = new GoodMemberRepo();
    private 외부라이브러리 lib = new 외부라이브러리();

    public Member 함수(string data, int i)
    {
        var isConnection = lib.isConnection();

        var 암튼 = repo.insert(new Member() { Name = data });

        if (isConnection)
        {
            var 변경된암튼 = repo.update(암튼);
        }
        lib.실행해주세요();
        return 암튼;
    }
}
