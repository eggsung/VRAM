using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRAM.Data
{
    public class MemberData : EntityData<Member>
    {
        public static List<string> GetMemberId()
        {
            var context = CreateContext();

            var query = from x in context.Members
                select x.MemberId;

            return query.ToList();
        }

        public static string GetOwnMemberId(string memberId)
        {
            var context = CreateContext();

            var query = from x in context.Members
                where x.MemberId == memberId
                select x.MemberId;

            return query.ToString();
        }

        public static List<string> GetMemberPassword()
        {
            var context = CreateContext();

            var query = from x in context.Members
                select x.Password;

            return query.ToList();
        }

    }
}
