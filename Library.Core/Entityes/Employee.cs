using Library.Core.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entityes
{
    public class Employee : EntityBase<int>
    {
        #region Prop
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TcNo { get; set; }
        public string PhoneNo { get; set; }
        public int AddressId { get; set; }
        public string Password { get; set; }
        public DateTime BirthDay { get; set; }
        public string EMail { get; set; }
        public bool Gender { get; set; }
        public int RoleId { get; set; }
        #endregion
    }
}
