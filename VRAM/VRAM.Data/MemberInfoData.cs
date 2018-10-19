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
        #region Instance

        private static MemberInfoData _instance = null;
        private static readonly object padlock = new object();

        public MemberInfoData()
        {
        }

        public static MemberInfoData Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new MemberInfoData();
                    }
                    return _instance;
                }
            }
        }
        #endregion

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
