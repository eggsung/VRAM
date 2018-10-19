using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRAM.Data
{
    public class MemberData<T> : EntityData<Member>
    {
        
       
        public Member SelectById(String entityId)
        {
           // return CreateContext().Set<T>().First(x => x.MemberId.Equals(entityId);
        }

        
        public Member GetLast()
        {
           // return Context.Members.OrderByDescending(x => x.MemberId).First();
        }
    }
}
