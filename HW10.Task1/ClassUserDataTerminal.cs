using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Task1
{
    class UserData
    {
        readonly string _passengerName = string.Empty;
        readonly string _passengerSurname = string.Empty;
        readonly string _passengerPatronymic = string.Empty;
        readonly string _passengerPassportNumber = string.Empty;
        readonly int _passengerBuggageWeight = 0;
        readonly int _carryOnBaggage = 0;
        readonly int _numberFlight = 0;
        readonly string _numberBaggage = string.Empty;
        readonly string _passengerTalonNumber = string.Empty;
        Random random = new Random();
        internal string PassengerName
        {
            get { return _passengerName; }
        }
        internal string PassengerSurname
        {
            get { return _passengerSurname; }
        }
        internal string PassengerPatronymic
        {
            get { return _passengerPatronymic; }
        }
        internal string PassengerPassportNumber
        {
            get { return _passengerPassportNumber; }
        }
        internal int NumberFlight
        {
            get { return _numberFlight; }
        }
        internal string PassengerTalonNumber
        {
            get { return _passengerTalonNumber; }
        }
        internal string NumberBaggage
        {
            get { return _numberBaggage; }
        }

        internal UserData(string passengerSurname, string passengerName, string passengerPatronymic, string passengerPassportNumber, int numberFlight)
        {
            _passengerName = passengerName;
            _passengerSurname = passengerSurname;
            _passengerPatronymic = passengerPatronymic;
            _passengerPassportNumber = passengerPassportNumber;
             _numberFlight = numberFlight;
            _passengerTalonNumber = random.Next(10000, 99999).ToString();
        }
        internal UserData(string passengerSurname, string passengerName, string passengerPatronymic, string passengerPassportNumber,  int numberFlight, int carryOnBaggag)
        {
            _passengerName = passengerName;
            _passengerSurname = passengerSurname;
            _passengerPatronymic = passengerPatronymic;
            _passengerPassportNumber = passengerPassportNumber;
            _carryOnBaggage = carryOnBaggag;
            _numberFlight = numberFlight;
            _passengerTalonNumber = random.Next(10000, 99999).ToString();
        }
        internal UserData(string passengerSurname, string passengerName, string passengerPatronymic, int passengerBuggageWeight, string passengerPassportNumber, int numberFlight)
        {
            _passengerName = passengerName;
            _passengerSurname = passengerSurname;
            _passengerPatronymic = passengerPatronymic;
            _passengerPassportNumber = passengerPassportNumber;
            _passengerBuggageWeight = passengerBuggageWeight;
            _numberFlight = numberFlight;
            _numberBaggage = random.Next(10000, 99999).ToString();
            _passengerTalonNumber = random.Next(10000, 99999).ToString();
        }
        internal UserData(string passengerSurname, string passengerName, string passengerPatronymic, int passengerBuggageWeight, string passengerPassportNumber,  int numberFlight, int carryOnBaggag)
        {

            _passengerName = passengerName;
            _passengerSurname = passengerSurname;
            _passengerPatronymic = passengerPatronymic;
            _passengerPassportNumber = passengerPassportNumber;
            _passengerBuggageWeight = passengerBuggageWeight;
            _carryOnBaggage = carryOnBaggag;
            _numberFlight = numberFlight;
            _numberBaggage = random.Next(10000, 99999).ToString();
            _passengerTalonNumber = random.Next(10000, 99999).ToString();
        }
    }
    class TerminalChekIn
    {

        readonly LanguageTerminalCheckIn _language;
        readonly LanguageTerminalTest _languageTest;
        internal LanguageTerminalCheckIn Language
        {
            get { return _language; }
        }
        internal LanguageTerminalTest LanguageTest
        {
            get { return _languageTest; }
        }
        internal TerminalChekIn (LanguageTerminalCheckIn language, LanguageTerminalTest languageTest)
        {
            _language = language;
            _languageTest = languageTest;
        }
        internal void TerminalChekInGreeting(int numberFlight)
        {
            Console.WriteLine(Language.Greetingday() + Language.Greeting, numberFlight);
        }
        internal string[] TerminalChekInNameSurnamePatronymic()
        {
            char separator = ' ';
            string[] nameSurnamePatronymic = new string[3];
            Console.WriteLine(Language.InputNameUser);
            return nameSurnamePatronymic = Console.ReadLine().Split(separator);
        }
        internal string TerminalChekInPassportNumber()
        {
            string passportNumber = string.Empty;
            Console.WriteLine(Language.InputPassportNumber);
            return passportNumber = Console.ReadLine();
        }
        internal int TerminalChekInBuggageWeight()
        {
            int buggageWeight = 0;
            while (true)
            {
                Console.WriteLine(Language.ReadBuggageWeight);
                Console.WriteLine(LanguageTest.TestBuggageWeight); // Test
                buggageWeight = Convert.ToInt32(Console.ReadLine());
                if (buggageWeight > 50)
                {
                    Console.WriteLine(Language.ReadBuggageWeightAndPay);
                    Console.WriteLine(LanguageTest.TestBuggageWeightPay); // Test
                    int numberTest = Convert.ToInt32(Console.ReadLine());
                    if (numberTest == 1)
                    {
                        Console.WriteLine(Language.ReadBuggageWeightPay);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(Language.ReadBuggageWeightagаin);
                    }
                }
                else
                    break;
            }
            Console.WriteLine(Language.ReadBuggageWeightYes);
            return buggageWeight;
        }
        internal int TerminalChekInCarryOnBaggage()
        {
            int carryOnBaggage = 0;
            while (true)
            {
                Console.WriteLine(Language.ReadCarryOnBaggage);
                Console.WriteLine(LanguageTest.TestCarryOnBaggage); // Test
                carryOnBaggage = Convert.ToInt32(Console.ReadLine());
                if (carryOnBaggage > 10)
                    Console.WriteLine(Language.ReadCarryOnBaggageFail);
                else
                    break;
            }
            Console.WriteLine(Language.ReadCarryOnBaggageYes);
            return carryOnBaggage;
        }
        internal void TerminalChekInRegistrationSuccessful(string talonNumber, string numberBaggage)
        {
            Console.WriteLine(Language.RegistrationSuccessful, talonNumber, numberBaggage);
            Console.WriteLine(Language.NextTerminal);
        }
    }
    class TerminalSecurity
    {
        readonly LanguageTerminalCheckIn _language;
        readonly LanguageTerminalSecurity _languageSecurity;
        readonly LanguageTerminalTest _languageTest;
        readonly string _passengerName = string.Empty;
        readonly string _passengerSurname = string.Empty;
        readonly string _passengerPatronymic = string.Empty;
        readonly string _passengerTalonNumber = string.Empty;
        bool passengerMetalObjects = false;
        bool passengerMetalDetectorFrame = false;
        internal LanguageTerminalCheckIn Language
        {
            get { return _language; }
        }
        internal LanguageTerminalSecurity LanguageSecurity
        {
            get { return _languageSecurity; }
        }
        internal LanguageTerminalTest LanguageTest
        {
            get { return _languageTest; }
        }
        internal string PassengerName
        {
            get { return _passengerName; }
        }
        internal string PassengerSurname
        {
            get { return _passengerSurname; }
        }
        internal string PassengerPatronymic
        {
            get { return _passengerPatronymic; }
        }
        internal string PassengerTalonNumber
        {
            get { return _passengerTalonNumber; }
        }
        internal bool PassengerMetalObjects
        {
            get { return passengerMetalObjects; }
            set { passengerMetalObjects = value; }
        }
        internal bool PassengerMetalDetectorFrame
        {
            get { return passengerMetalDetectorFrame; }
            set { passengerMetalDetectorFrame = value; }
        }
        internal TerminalSecurity(LanguageTerminalCheckIn language, LanguageTerminalSecurity languageSecurity, LanguageTerminalTest languageTest, string passengerSurname, string passengerName, string passengerPatronymic, string passengerTalonNumber)
        {
            _language = language;
            _languageSecurity = languageSecurity;
            _languageTest = languageTest;
            _passengerName = passengerName;
            _passengerSurname = passengerSurname;
            _passengerPatronymic = passengerPatronymic;
            _passengerTalonNumber = passengerTalonNumber;

        }
        internal void TerminalSecurityGreeting()
        {
            Console.WriteLine(Language.Greetingday() + LanguageSecurity.Greeting);
        }
        internal void SecurityCheckTalonNumber()
        {
            Console.WriteLine(LanguageSecurity.CheckTalonNumber);
            while (true)
            {
                string talonNumber = Console.ReadLine();
                if (talonNumber.Equals(PassengerTalonNumber))
                {
                    Console.WriteLine(LanguageTest.TestCheckOk);
                    break;
                }
                else
                {
                    Console.WriteLine(LanguageTest.TestCheckFail);
                }
            }
        }
        internal void CheckMetalObjects()
        {
            bool check = false;
            Console.WriteLine(LanguageSecurity.CheckMetalObjects);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(LanguageTest.TestMetalObjects); //Test
                int numberTest = Convert.ToInt32(Console.ReadLine());
                if (numberTest == 1)
                    check = true;
                if (check == true)
                {
                    Console.WriteLine(LanguageTest.TestCheckOk);
                    passengerMetalObjects = true;
                    break;
                }
                else
                {
                    Console.WriteLine(LanguageSecurity.CheckFailMetalObjects);
                    passengerMetalObjects = false;
                }
            }

            while (true)
            {
                if (!passengerMetalObjects)
                    Console.WriteLine(LanguageSecurity.VerificationMetalObjectsFail);
                if (PassengerMetalObjects)
                    break;
                else
                {
                    Console.WriteLine(LanguageTest.TestVerificationChange); //Test
                    int numberTest = Convert.ToInt32(Console.ReadLine());
                    if (numberTest == 1)
                    {
                        PassengerMetalObjects = true;
                    }
                }
            }
        }
        internal void CheckMetalDetectorFrame()
        {
            Console.WriteLine(LanguageSecurity.CheckMetalDetectorFrame);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(LanguageTest.TestMetalDetectorFrame);
                int numberTest = Convert.ToInt32(Console.ReadLine());
                if (numberTest == 1)
                {
                    Console.WriteLine(LanguageTest.TestCheckOk);
                    passengerMetalDetectorFrame = true;
                    break;
                }
                else
                {
                    Console.WriteLine(LanguageSecurity.CheckFailMetalDetectorFrame);
                    passengerMetalDetectorFrame = false;
                }
            }
            while (true)
            {
                if (!passengerMetalDetectorFrame)
                    Console.WriteLine(LanguageSecurity.VerificationMetalObjectsFail);
                if (passengerMetalDetectorFrame)
                    break;
                else
                {

                    Console.WriteLine(LanguageTest.TestVerificationChange); //Test
                    int numberTest = Convert.ToInt32(Console.ReadLine());
                    if (numberTest == 1)
                    {
                        passengerMetalDetectorFrame = true;
                    }
                }
            }
        }
        internal void TerminalSecuritySuccessful(string passengerSurname, string passengerName, string passengerPatronymic)
        {
            if (PassengerMetalObjects && PassengerMetalDetectorFrame)
            {
                Console.WriteLine(LanguageSecurity.VerificationSuccessful, passengerSurname, passengerName, passengerPatronymic);
            }
        }
    }
    class TerminalBoarding
    {
        readonly LanguageTerminalCheckIn _language;
        readonly LanguageTerminalBoarding _languageBoarding;
        readonly LanguageTerminalTest _languageTest;
        readonly string _passengerName = string.Empty;
        readonly string _passengerSurname = string.Empty;
        readonly string _passengerPatronymic = string.Empty;
        readonly string _passengerPassportNumber = string.Empty;
        readonly int  _passengerFlight = 0;
        readonly string _passengerTalonNumber = string.Empty;
        internal LanguageTerminalCheckIn Language
        {
            get { return _language; }
        }
        internal LanguageTerminalBoarding LanguageBoarding
        {
            get { return _languageBoarding; }
        }
        internal LanguageTerminalTest LanguageTest
        {
            get { return _languageTest; }
        }
        internal TerminalBoarding(LanguageTerminalCheckIn language, LanguageTerminalBoarding languageBoarding, LanguageTerminalTest languageTest, string passengerSurname, string passengerName, string passengerPatronymic, string passengerPassportNumber, int passengerFlight, string passengerTalonNumber)
        {
            _language = language;
            _languageBoarding = languageBoarding;
            _languageTest = languageTest;
            _passengerName = passengerName;
            _passengerSurname = passengerSurname;
            _passengerPatronymic = passengerPatronymic;
            _passengerPassportNumber = passengerPassportNumber;
            _passengerFlight = passengerFlight;
            _passengerTalonNumber = passengerTalonNumber;
        }
        internal string PassengerName
        {
            get { return _passengerName; }
        }
        internal string PassengerSurname
        {
            get { return _passengerSurname; }
        }
        internal string PassengerPatronymic
        {
            get { return _passengerPatronymic; }
        }
        internal string PassengerPassportNumber
        {
            get { return _passengerPassportNumber; }
        }
        internal string PassengerTalonNumber
        {
            get { return _passengerTalonNumber; }
        }
        internal int PassengerFlight
        {
            get { return _passengerFlight; }
        }
        internal void TerminalBoardingGreeting(int numberFlight)
        {
            Console.WriteLine(Language.Greetingday() + LanguageBoarding.Greeting, numberFlight);
        }
        internal void BoardingCheckTalonNumber(string passengerTalonNumber)
        {
            Console.WriteLine(LanguageBoarding.CheckTalonNumber);
            while (true)
            {
                Console.WriteLine(LanguageTest.TestCheckTalonNumber);
                string talonNumber = Console.ReadLine();
                if (talonNumber.Equals(passengerTalonNumber, StringComparison.Ordinal))
                {
                    Console.WriteLine(LanguageTest.TestCheckOk);
                    break;
                }
                else
                {
                    Console.WriteLine(LanguageTest.TestCheckFail);
                }
            }
        }
        internal void BoardingCheckPassportNumber(string passengerPassportNumber)
        {
            Console.WriteLine(LanguageBoarding.CheckPassportNumber);
            while (true)
            {
                Console.WriteLine(LanguageTest.TestCheckPassportNumber);
                string talonNumber = Console.ReadLine();
                if (talonNumber.Equals(passengerPassportNumber, StringComparison.Ordinal))
                {
                    Console.WriteLine(LanguageTest.TestCheckOk);
                    break;
                }
                else
                {
                    Console.WriteLine(LanguageTest.TestCheckFail);
                }
            }
        }
        internal void TerminalBoardingSuccessful(string passengerSurname, string passengerName, string passengerPatronymic)
        {
            Console.WriteLine(LanguageBoarding.CheckSuccessful, passengerSurname, passengerName, passengerPatronymic);
        }
    }
}
