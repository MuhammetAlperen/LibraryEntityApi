using Library.Core.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entityes
{
    public class Process : EntityBase<int>
    {
        #region Prop.
        public int CustomerId { get; set; }
        public int BookId { get; set; }
        public int PublisherId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime IssueDate { get; set; }
        #endregion

        #region Nav. Prop.
        public Customer Customer { get; set; }
        public Book Book { get; set; }
        public Publisher Publisher { get; set; }
        public Employee Employee { get; set; }
        #endregion
    }

}
