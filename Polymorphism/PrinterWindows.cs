using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class PrinterWindows
    {
        public String printer { get; set; }
        public virtual void Show()
        {
            Console.WriteLine("Print display dimension: ");
        }
        public void Print()
        {
            Console.WriteLine("Print printer printing....");
        }
    }
}
