using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_lab6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            StringChecker digitChecker = new StringDigitChecker();
            StringChecker lenghtChecker = new StringLengthChecker(6);
            StringChecker upperCaseChecker = new StringUpperCaseChecker();
            StringChecker lowerCaseChecker = new StringLowerCaseChecker();
            PasswordValidator passwordValidator = new PasswordValidator(lenghtChecker);
            passwordValidator.SetNextChecker(digitChecker);
            passwordValidator.SetNextChecker(upperCaseChecker);
            passwordValidator.SetNextChecker(lowerCaseChecker);
            Console.WriteLine(passwordValidator.Validate("luDilo321"));
        }
    }
}
