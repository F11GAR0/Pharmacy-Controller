using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Controller
{
    class InternalSellsMaster
    {
        Random r = new Random(DateTime.Now.Millisecond);
        public int GetFreeCheckNumber()
        {
            //put here real check number from inet-cass
            return r.Next(11234, 9210001);
        }
        public int GetFreeFD()
        {
            return r.Next(11234, 510001);
        }
        public int GetFreeReceptID()
        {
            return r.Next(3910, 23004);
        }
    }
}
