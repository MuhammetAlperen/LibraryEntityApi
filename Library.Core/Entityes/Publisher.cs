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
        public string Description { get; set; }
        #endregion
    }
}
