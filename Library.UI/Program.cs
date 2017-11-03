using Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                context.Books.ToArray();
            }
        }
    }
}
