using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class2 : IClass2
    {
        private readonly IClass1 _class1;
        private readonly IClass3 _class3;
        public Class2(IClass1 class1, IClass3 class3)
        {
            _class1 = class1;
            _class3 = class3;
        }

        public void CreateBooking()
        {
            _class1.CreatePNR();
            Console.WriteLine("Create Booking");
            _class3.ModifyBooking();
        }
    }
}
