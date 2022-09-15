using System;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Linq;

namespace SupportBank
{
    public class SupportBankData
    {
        public  DateTime Date {get;}
        public string[] From {get;}
        public string[] To {get;}
        public string Narrative {get;}
        public float Amount {get;}
        public SupportBankData(string[] from, string[] to, string narrative)
        {
            From = from;
            To = to;
            Narrative = narrative;
        }
    }
}
// account{  is it a list?
// name: Bob,
//         owes[
//             {
            //     to: mary
            //     narative: drinking
            //     amount:30
//             }
//             {
//              to: john
//             narative: drinking
//             amount:30
//             }
//             {
//              to: Rob
//             narative: drinking
//             amount:30
//             }             
//         ]
//     }
// }
