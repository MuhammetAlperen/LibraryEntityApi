using Library.Core.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entityes
{
    public class Category : EntityBase<int>
    {
        #region Prop.
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int AdressId { get; set; }
        #endregion
    }
}
