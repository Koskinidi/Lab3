using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Purchase_request
    {
        private string? full_name;
        public string? getFull_name() { return full_name; }
        public void setFull_name(string full_name) { this.full_name = full_name; }

        private string telephone_number;
        public string getTelephone_number() { return telephone_number; }
        public void setTelephone_number(string telephone_number) { this.telephone_number = telephone_number; }
    }
}
