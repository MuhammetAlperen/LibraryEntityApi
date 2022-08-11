using Library.Core.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entityes
{
    public class Publisher : EntityBase<int>
    {
        #region Prop.
        public string PublisherName { get; set; }
        public string Historical { get; set; }
        public string AdressId { get; set; }
        #endregion

        #region Nav. Prop.
        public Address Address { get; set; }
        #endregion
    }
}
