using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanBaoTrung_Buoitoi
{
    internal interface IIfc1
    {
        string PrintOut(string s);
    }
    class MyClass : IIfc1
    {
        public string PrintOut(string s)
        {
            return s;
        }
    }
}
