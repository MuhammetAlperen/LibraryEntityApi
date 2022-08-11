using Library.Core.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entityes
{
    public class Book : EntityBase<int>
    {
        #region Prop.
        public string BookName { get; set; }
        public string Contents { get; set; }
        public int Page { get; set; }
        public DateTime? FirstEdition { get; set; }
        public int Printing { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        #endregion

        #region Nav. Prop.
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        #endregion
    }
}
