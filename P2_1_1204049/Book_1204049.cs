using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204049
{
    public class Book_1204049 : Product_1204049
    {
        protected string pageCount;
        public Book_1204049(string type, string title, string PageCount) : base(type, title)
        {
            this.pageCount = PageCount;
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }
            set
            {
                pageCount = value;
            }
        }
    }
}
