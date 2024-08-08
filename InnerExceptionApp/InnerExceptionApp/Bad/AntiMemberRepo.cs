using InnerExceptionApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerExceptionApp.Repository;

public class AntiMemberRepo
{

    public bool update(Member member)
    {
        try
        {

            member.Name += member.Name;
            throw new Exception("123");
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }


    public Member get(int id)
    {
        try
        {

            return new Member() { Id = id};
        }
        catch (Exception ex)
        {
            return null;
        }
    }


    public bool insert(Member member)
    {
        try
        {
            return false;
        }
        catch {
            return false; 
        }
        
    }


}
