using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_lab6_7
{
    class StringLengthChecker : StringChecker
    {
        private int lenght;
        public StringLengthChecker(int StringLenght)
        {
            this.lenght = StringLenght;
        }

        protected override bool PerformCheck(string stringToCheck)
        {

            if (stringToCheck.Count() >= lenght) return true;
            else return false;
        }
    }
}
