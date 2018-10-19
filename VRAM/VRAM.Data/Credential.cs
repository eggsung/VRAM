using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace VRAM.Data
{
    public class Credential
    {

        #region Instance

        private static Credential _instance = null;
        private static readonly object padlock = new object();

        public Credential()
        {
        }

        public static Credential Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Credential();
                    }
                    return _instance;
                }
            }
        }
        #endregion

        private HashSet<String> _roleNames = new HashSet<string>();

        public Member member { get; private set; }

        public bool HasRole(string role)
        {
            return _roleNames.Contains(role);
        }

        public void Load(Member member)
        {
            Member m = member;
            Role r = new Role();
            List<Role> roles = new List<Role>();
            

            foreach (var role in roles)
            {
                _roleNames.Add(r.RoleName);

            }
        }



    }
}
