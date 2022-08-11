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
        public string Content { get; set; }
        public int NumberOfPages { get; set; }
        public int FirstYearOfPrinting { get; set; }
        public int Oppression { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public int CategoryId { get; set; }
        #endregion

        #region Nav. Prop.
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public Category Category { get; set; }

        #endregion
    }
}
