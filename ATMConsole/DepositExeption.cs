using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsole
{
    public class DepositExeption : Exception //inherits
    {
        public DepositExeption() : base() { }
        public DepositExeption(string message) : base(message) { }

        public DepositExeption(string message, Exception innerException) : base(message, innerException) {}


    }
}
