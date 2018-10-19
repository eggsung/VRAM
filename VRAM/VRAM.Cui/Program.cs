using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using VRAM.Data;

namespace VRAM.Cui
{
    class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member();
            member.MemberId = "Thomas";
            member.MemberName = "토마스";
            member.Email = "Thomas123@gmail.com";
            member.Password = "123123";
            member.PhoneNum = "010-123-1234";

            VRAMEntities context = new VRAMEntities();
            context.Members.Add(member);
            context.SaveChanges();




            if (Credential.Instance.HasRole("Admin"))
            {
                
            }

          
            Credential.Instance.Load("akjd882");

            MemberInfoData.GetMemberInfo("akjd882");

        }

        
    }
}
