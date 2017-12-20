using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_lab6_7
{
    class PasswordValidator
    {
        private StringChecker checker;
        private StringChecker next;

        public PasswordValidator(StringChecker Checker)
        {
            this.checker = Checker;
            this.next = Checker;
        }

        public void SetNextChecker(StringChecker next)
        {
            this.next.SetNext(next);
            this.next = next;
        }

        public bool Validate(string stringToCheck)
        {
            return checker.Check(stringToCheck);
        }
        
    }
}

