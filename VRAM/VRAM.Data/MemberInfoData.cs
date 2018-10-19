using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VRAM.Data
{
    public class MemberInfoData : EntityData<Member>
    {
 
        public static List<Member> GetMemberInfo(string memberId)
        {
            var context = CreateContext();

            var query = from x in context.Members
                where x.MemberId == memberId
                select x;

            return query.ToList();
        }
    }
}
