using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Fine
    {
        public static int FineForBook(DateTime dateTime)
        {
            int fine = 0;
            TimeSpan timeSpan = dateTime - DateTime.Now;
            if(timeSpan.Days>30)
            {
                fine = 2 * (timeSpan.Days - 30);
            }
            return fine;
        }
    }
}
