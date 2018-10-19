using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRAM.Data
{
    public class DataRepository
    {
        #region MemberData

        private static MemberData _member;

        public static MemberData Member
        {
            get
            {
                if (_member == null)
                    _member = new MemberData();

                return _member;
            }
        }

        #endregion

        #region RoleData

        private static RoleData _role;

        public static RoleData Role
        {
            get
            {
                if (_role == null)
                    _role = new RoleData();

                return _role;
            }
        }

        #endregion

        #region BoardData

        private static BoardData _borad;

        public static BoardData Borad
        {
            get
            {
                if (_borad == null)
                    _borad = new BoardData();

                return _borad;
            }
        }

        #endregion

        #region AttendanceData

        private static AttendanceData _attendanceData;

        public static AttendanceData Attendance
        {
            get
            {
                if (_attendanceData == null)
                    _attendanceData = new AttendanceData();

                return _attendanceData;
            }
        }

        #endregion
    }
}
