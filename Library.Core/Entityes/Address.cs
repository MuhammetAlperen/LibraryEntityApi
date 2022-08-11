using Library.Core.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entityes
{
    public class Address : EntityBase<int>
    {
        #region Prop.
        public string Coutry { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string BuildingName { get; set; }
        public int Floor { get; set; }
        public int PostCode { get; set; }
        #endregion
    }
}
