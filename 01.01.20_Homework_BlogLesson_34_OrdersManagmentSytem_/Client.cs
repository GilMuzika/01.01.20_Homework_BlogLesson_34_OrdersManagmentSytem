using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._01._20_Homework_BlogLesson_34_OrdersManagmentSytem_
{
    class Client
    {
        public int NUM { get; set; }
        public string userName { get; set; }
        public string pass { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public string credit { get; set; }

        public Client(string userName, string pass, string name, string family, string credit)
        {
            this.userName = userName;
            this.pass = pass;
            this.name = name;
            this.family = family;
            this.credit = credit;
        }

        public Client()
        {
        }

        public override string ToString()
        {
            string str = string.Empty;
            foreach (var s in this.GetType().GetProperties()) str += $"{s.Name}: {s.GetValue(this)}\n";

            return str;
        }
    }
}
