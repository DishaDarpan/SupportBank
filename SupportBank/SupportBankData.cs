using System;
using System.IO;

namespace SupportBank
{
    public class SupportBankData
    {
        public  DateTime Date {get; set;}
        public string Emp_Name {get; set;}
        public string OwedTo {get; set;}
        public string Narrative {get; set;}
        public float Amount {get; set;}
        // public SupportBankData(string from, string to, string narrative)
        // {
        //     Emp_Name = from;
        //     OwedTo = to;
        //     Narrative = narrative;
        // }
    }
}

// Object reference not set to an instance of an object.

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
