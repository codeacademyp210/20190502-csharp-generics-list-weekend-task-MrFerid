using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterForm
{
    class ExtraMethods
    {
        public string CheckInput(string header, string input, string pattern)
        {
            string patrn;
            string error = "";
            switch (pattern)
            {
                case "onlyString":
                    patrn = @"^[A-Za-z]+$";
                    error += header + " bolmesine yalniz herf yazin ve bosh buraxmayin \n";
                    break;
                case "emailType":
                    patrn = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
                    error += header + "i duzgun formatda yazin ve bosh buraxmayin \n";
                    break;
                case "onlyNumber":
                    patrn = @"^\d+$";
                    error += header + " bolmesine yalniz reqem yazin ve bosh buraxmayin \n";
                    break;
                case "any":
                    patrn = @".*\S.*";
                    error += header + " bolmesini bosh buraxmayin \n";
                    break;
                case "onlyDouble":
                    input = input.Replace(",", ".");
                    patrn = @"^[0-9\.]+$";
                    error += header + " bolmesine kesr veya tam reqem yazin ve bosh buraxmayin \n";
                    break;
                default:
                    patrn = @"^[A-Za-z0-9]+$";
                    break;
            }
            if (Regex.IsMatch(input, patrn, RegexOptions.IgnoreCase))
            {
                return "ok";
            }
            else
            {
                return error;
            }
        }

    }
}
