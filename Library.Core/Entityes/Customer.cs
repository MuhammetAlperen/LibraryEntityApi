using Library.Core.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entityes
{
    public class Customer : EntityBase<int>
    {
        #region Prop
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDay { get; set; }
        #endregion
    }
}
