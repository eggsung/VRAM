using System.Collections.Generic;
using System.Linq;

namespace VRAM.Data
{
    public class RoleData : EntityData<Role>
    {
        public static List<Role> GetOwnRoles(string memberId)
        {
            var context = CreateContext();

            var query = from x in context.MemberRoles
                where x.MemberId == memberId
                select x.Role;

            return query.ToList();
        }

       
    }

    
}