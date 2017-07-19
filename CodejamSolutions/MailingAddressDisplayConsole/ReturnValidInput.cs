using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportLibrary;

namespace MailingAddressDisplayConsole
{
    public class ReturnValidInput
    {
        InputFromConsole newScanner = new InputFromConsole();          //Custom console object
        ValidateCredentials newValidator = new ValidateCredentials();  //Custom validation object
    }
}
