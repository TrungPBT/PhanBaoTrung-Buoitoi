using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanBaoTrung_Buoitoi
{
    internal class Animal
    {
    }
    internal class Cat : Animal, ILiveBirth
    {
        string ILiveBirth.BaByRedCalled()
        {
            return "mèo méo meo mèo meoooo";
        }
    }
    internal class Dog : Animal, ILiveBirth
    {
        string ILiveBirth.BaByRedCalled()
        {
            return "Sì nốp đóttttt đà đà đà đa";
        }
    }
    internal class Bird : Animal { }
}
