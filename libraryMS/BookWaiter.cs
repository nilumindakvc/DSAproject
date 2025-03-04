using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryMS
{
    public class BookWaiter
    {
        public string WaiterId;
        public string BookWaitFor;
        public DateTime RequestedDay;

        public BookWaiter(string waiterId, string bookWaitFor, DateTime requestedDay)
        {
            WaiterId = waiterId;
            BookWaitFor = bookWaitFor;
            RequestedDay = requestedDay;
        }
    }

    
}
