using Library.Core.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entityes
{
    public class Author : EntityBase<int>
    {
        #region Prop.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AuthorBiography { get; set; } 
        #endregion
    }
}
