using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFlight = 154896;
            LanguageSelection languageSelection = new LanguageSelection();
            string language = languageSelection.LanguageSelect();
            LanguageTerminalCheckIn languageTerminalCheckIn = new LanguageTerminalCheckIn(language);
            LanguageTerminalSecurity languageTerminalSecurity = new LanguageTerminalSecurity(language);
            LanguageTerminalBoarding languageTerminalBoarding = new LanguageTerminalBoarding(language);
            LanguageTerminalTest languageTerminalTest = new LanguageTerminalTest(language);
            TerminalChekIn terminalChekIn = new TerminalChekIn(languageTerminalCheckIn, languageTerminalTest);
            terminalChekIn.TerminalChekInGreeting(numberFlight);
            string[] user = terminalChekIn.TerminalChekInNameSurnamePatronymic();
            string passportNumber = terminalChekIn.TerminalChekInPassportNumber();
            int buggageWeight = terminalChekIn.TerminalChekInBuggageWeight();
            int carryOnBaggage = terminalChekIn.TerminalChekInCarryOnBaggage();
            UserData userData = new UserData(user[0], user[1], user[2], buggageWeight, passportNumber , numberFlight, carryOnBaggage);
            TerminalSecurity userTerminalSecurity = new TerminalSecurity(languageTerminalCheckIn, languageTerminalSecurity, languageTerminalTest, userData.PassengerSurname, userData.PassengerName, userData.PassengerPatronymic, userData.PassengerTalonNumber);
            TerminalBoarding userTerminalBoarding = new TerminalBoarding(languageTerminalCheckIn, languageTerminalBoarding, languageTerminalTest, userData.PassengerSurname, userData.PassengerName, userData.PassengerPatronymic, userData.PassengerPassportNumber,userData.NumberFlight, userData.PassengerTalonNumber);
            terminalChekIn.TerminalChekInRegistrationSuccessful(userData.PassengerTalonNumber, userData.NumberBaggage);
            userTerminalSecurity.TerminalSecurityGreeting();
            userTerminalSecurity.SecurityCheckTalonNumber();
            userTerminalSecurity.CheckMetalObjects();
            userTerminalSecurity.CheckMetalDetectorFrame();
            userTerminalSecurity.TerminalSecuritySuccessful(userTerminalSecurity.PassengerSurname, userTerminalSecurity.PassengerName, userTerminalSecurity.PassengerPatronymic);
            userTerminalBoarding.TerminalBoardingGreeting(userTerminalBoarding.PassengerFlight);
            userTerminalBoarding.BoardingCheckTalonNumber(userTerminalBoarding.PassengerTalonNumber);
            userTerminalBoarding.BoardingCheckPassportNumber(userTerminalBoarding.PassengerPassportNumber);
            userTerminalBoarding.TerminalBoardingSuccessful(userTerminalBoarding.PassengerSurname, userTerminalBoarding.PassengerName, userTerminalBoarding.PassengerPatronymic);
            Console.Read();
        }
    }
}
