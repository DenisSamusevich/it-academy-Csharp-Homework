using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Task1
{
    class LanguageSelection
    {
        readonly string _textLanguageSelection = "Выберете язык/Language selection \"RU\" или \"EN\"";
        internal string TextLanguageSelection
        {
            get { return _textLanguageSelection; }
        }
        internal string LanguageSelect()
        {
            Console.WriteLine(TextLanguageSelection);
            return Console.ReadLine();
        }
            
    }
        class LanguageTerminalCheckIn
    {
        const string RU = "RU";
        const string EN = "EN";
        readonly string _language = string.Empty;
        readonly string _greetingNight = string.Empty;
        readonly string _greetingMorning = string.Empty;
        readonly string _greetingAfternoon = string.Empty;
        readonly string _greetingEvening = string.Empty;
        readonly string _greeting = string.Empty;
        readonly string _inputNameUser = string.Empty;
        readonly string _inputPassportNumber = string.Empty;
        readonly string _readBuggageWeight = string.Empty;
        readonly string _readBuggageWeightAndPay = string.Empty;
        readonly string _readBuggageWeightPay = string.Empty;
        readonly string _readBuggageWeightagаin = string.Empty;
        readonly string _readBuggageWeightYes = string.Empty;
        readonly string _readCarryOnBaggage = string.Empty;
        readonly string _readCarryOnBaggageFail = string.Empty;
        readonly string _readCarryOnBaggageYes = string.Empty;
        readonly string _registrationSuccessful = string.Empty;
        readonly string _nextTerminal = string.Empty;
        internal string Language
        {
            get { return _language; }
        }
        internal string GreetingNight
        {
            get { return _greetingNight; }
        }
        internal string GreetingMorning
        {
            get { return _greetingMorning; }
        }
        internal string GreetingAfternoon
        {
            get { return _greetingAfternoon; }
        }
        internal string GreetingEvening
        {
            get { return _greetingEvening; }
        }
        internal string Greeting
        {
            get { return _greeting; }
        }
        internal string InputNameUser
        {
            get { return _inputNameUser; }
        }
        internal string InputPassportNumber
        {
            get { return _inputPassportNumber; }
        }
        internal string ReadBuggageWeight
        {
            get { return _readBuggageWeight; }
        }
        internal string ReadBuggageWeightAndPay
        {
            get { return _readBuggageWeightAndPay; }
        }
        internal string ReadBuggageWeightPay
        {
            get { return _readBuggageWeightPay; }
        }
        internal string ReadBuggageWeightagаin
        {
            get { return _readBuggageWeightagаin; }
        }
        internal string ReadBuggageWeightYes
        {
            get { return _readBuggageWeightYes; }
        }
        internal string ReadCarryOnBaggage
        {
            get { return _readCarryOnBaggage; }
        }
        internal string ReadCarryOnBaggageFail
        {
            get { return _readCarryOnBaggageFail; }
        }
        internal string ReadCarryOnBaggageYes
        {
            get { return _readCarryOnBaggageYes; }
        }
        internal string RegistrationSuccessful
        {
            get { return _registrationSuccessful; }
        }
        internal string NextTerminal
        {
            get { return _nextTerminal; }
        }
        internal LanguageTerminalCheckIn(string languageSelect)
        {
            if (languageSelect.Equals(RU, StringComparison.Ordinal))
            {
                _language = RU;
                _greetingNight = "\nДоброй ночи. ";
                _greetingMorning = "\nДоброe утро. ";
                _greetingAfternoon = "\nДобрый день. ";
                _greetingEvening = "\nДобрый вечер. ";
                _greeting = "Вас приветствует терминал регистрации на рейс №{0} Национального аэропорта Минск.";
                _inputNameUser = "Введите ваше фамилию, имя и отчество, разделяя пробелами.";
                _inputPassportNumber = "Введите серию и номер паспорта.";
                _readBuggageWeight = "Положите пожалуйста ваш багаж на весы для взвешивания, максимальная масса 50 кг.";
                _readBuggageWeightAndPay = "У вас превышение веса багажа, уменьшите вес или доплатите за перевес.";
                _readBuggageWeightPay = "Благодорим вас за оплату.";
                _readBuggageWeightagаin = "Производим повторное взвешивание.";
                _readBuggageWeightYes = "Багаж взвешен.";
                _readCarryOnBaggage = "Положите пожалуйста ручную кладь на весы для взвешивания, максимальная масса 10 кг.";
                _readCarryOnBaggageFail = "У вас превышение веса ручной клади, уменьшите вес и произведите повторное взвешивание.";
                _readCarryOnBaggageYes = "Ручная кладь взвешена.";
                _registrationSuccessful = "Регистрация прошла успешна, возмите свой посадоный талон №{0} и бирку для багажа №{1}.";
                _nextTerminal = "Теперь вы можете проходить к терминалу безопасности Национального аэропорта Минск.";
            }
            else if (languageSelect.Equals(EN, StringComparison.Ordinal))
            {
                _language = EN;
                _greetingNight = "\nGood night. ";
                _greetingMorning = "\nGood mornin. ";
                _greetingAfternoon = "\nGood afternoon. ";
                _greetingEvening = "\nGood evening. ";
                _greeting = "Welcome to the check-in terminal for flight №{0} Minsk National Airport.";
                _inputNameUser = "Enter your surname, first name and patronymic, separated by spaces.";
                _inputPassportNumber = "Enter passport number.";
                _readBuggageWeight = "Please put your baggage on a weighing scale, maximum weight 50 kg.";
                _readBuggageWeightAndPay = "You have excess baggage weight, reduce weight or pay extra for overweight.";
                _readBuggageWeightPay = "Thanks for the payment.";
                _readBuggageWeightagаin = "Re-weigh.";
                _readBuggageWeightYes = "Buggage weighed.";
                _readCarryOnBaggage = "Please place your carry-on the weighing scale, maximum weight 10 kg.";
                _readCarryOnBaggageFail = "You have an excess of carry-on weight, reduce weight and re-weigh.";
                _readCarryOnBaggageYes = "Carry-on baggage weighed.";
                _registrationSuccessful = "Check-in was successful, take your boarding card №{0} and number for baggage №{1}.";
                _nextTerminal = "Now you can go to the security terminal of the National Airport Minsk.";
            }
            else
                throw new Exception("Error selection language");
        }
        internal string Greetingday()
        {
            int hour = DateTime.Now.Hour;
            if (hour >= 0 && hour < 4)
                return GreetingNight;
            else if (hour >= 4 && hour < 12)
                return GreetingMorning;
            else if (hour >= 12 && hour < 17)
                return GreetingAfternoon;
            else
                return GreetingEvening;
        }
    }
    class LanguageTerminalSecurity
    {
        const string RU = "RU";
        const string EN = "EN";
        readonly string _greeting = string.Empty;
        readonly string _checkTalonNumber = string.Empty;
        readonly string _checkMetalObjects = string.Empty;
        readonly string _checkMetalDetectorFrame = string.Empty;
        readonly string _verificationMetalObjectsFail = string.Empty;
        readonly string _checkFailMetalObjects = string.Empty;
        readonly string _checkFailMetalDetectorFrame = string.Empty;
        readonly string _verificationSuccessful = string.Empty;
        internal string Greeting
        {
            get { return _greeting; }
        }
        internal string CheckTalonNumber
        {
            get { return _checkTalonNumber; }
        }
        internal string CheckMetalObjects
        {
            get { return _checkMetalObjects; }
        }
        internal string CheckMetalDetectorFrame
        {
            get { return _checkMetalDetectorFrame; }
        }
        internal string VerificationMetalObjectsFail
        {
            get { return _verificationMetalObjectsFail; }
        }
        internal string CheckFailMetalObjects
        {
            get { return _checkFailMetalObjects; }
        }
        internal string CheckFailMetalDetectorFrame
        {
            get { return _checkFailMetalDetectorFrame; }
        }
        internal string VerificationSuccessful
        {
            get { return _verificationSuccessful; }
        }

        internal LanguageTerminalSecurity(string languageSelect)
        {

            if (languageSelect.Equals(RU, StringComparison.Ordinal))
            {
                _greeting = "Вас приветствует терминал безопасности Национального аэропорта Минск.";
                _checkTalonNumber = "Для прохождения терминла безопасности введите ваш номер талона.";
                _checkMetalObjects = "Просим вас положить верхнюю одежду, кошельки, ремни, все содержимое корманов и ручную кладь в корзину для проверки.";
                _checkMetalDetectorFrame = "Просим вас пройти рамку металодетектора.";
                _verificationMetalObjectsFail = "Досмотр предметов не пройден. Дождитесь охраны.";
                _checkFailMetalObjects = "Найдены небезопасные предметы, вам придется их оставить, и попробуйте снова.";
                _checkFailMetalDetectorFrame = "Металодетектор зафиксировал металические предметы, положите их в корзину для досмотра и пройдите рамку снова.";
                _verificationSuccessful = "{0} {1} {2}, вами пройден досмотр успешно. Можете одеваться и проходить в зал ожидания.";
            }
            else if (languageSelect.Equals(EN, StringComparison.Ordinal))
            {
                _greeting = "Welcome to the security terminal of the National Airport Minsk.";
                _checkTalonNumber = "To pass the security terminal, enter your talon number.";
                _checkMetalObjects = "We ask you to put outerwear, wallets, belts and hand luggage into the basket for inspection.";
                _checkMetalDetectorFrame = "We ask you to go through the frame of the metal detector.";
                _verificationMetalObjectsFail = "Check items failed. Wait for the police.";
                _checkFailMetalObjects = "Unsafe items found, you must leave them and try again.";
                _checkFailMetalDetectorFrame = "Metal detector found metal objects. Put them in the inspection basket and go through the frame again.";
                _verificationSuccessful = "{0} {1} {2}, You have successfully passed the test. You can get dressed and go to the waiting room.";
            }
        }
    }
    class LanguageTerminalBoarding
    {
        const string RU = "RU";
        const string EN = "EN";
        readonly string _greeting = string.Empty;
        readonly string _checkTalonNumber = string.Empty;
        readonly string _checkPassportNumber = string.Empty;
        readonly string _checkSuccessful = string.Empty;
        internal string Greeting
        {
            get { return _greeting; }
        }
        internal string CheckTalonNumber
        {
            get { return _checkTalonNumber; }
        }
        internal string CheckPassportNumber
        {
            get { return _checkPassportNumber; }
        }
        internal string CheckSuccessful
        {
            get { return _checkSuccessful; }
        }
        internal LanguageTerminalBoarding(string languageSelect)
        {

            if (languageSelect.Equals(RU, StringComparison.Ordinal))
            {
                _greeting = "Вас приветствует терминал посадки на рейс №{0}.";
                _checkTalonNumber = "Для прохождения терминала посадки просим вас предъявить посадочный талон.";
                _checkPassportNumber = "Просим вас предъявить паспорт.";
                _checkSuccessful = "{0} {1} {2} сохраняйте талон до тех пор пока не получите багаж по прилету. Пройдя далее по коридору вы попадете на борт самолета.\nЖелаем удачного полета.";
            }
            else if (languageSelect.Equals(EN, StringComparison.Ordinal))
            {
                _greeting = "Welcome to the terminal of the landing flight №{0}.";
                _checkTalonNumber = "To pass the landing terminal, please present your boarding talon.";
                _checkPassportNumber = "Please present your passport.";
                _checkSuccessful = "{0} {1} {2} keep your talon until your baggage is received upon arrival. Going further down the corridor you will board the aircraft.\nWe wish you a successful flight.";
            }
        }

    }
    class LanguageTerminalTest
    {
        const string RU = "RU";
        const string EN = "EN";
        readonly string _testCheckOk = string.Empty;
        readonly string _testCheckFail = string.Empty;
        readonly string _testBuggageWeight = string.Empty;
        readonly string _testBuggageWeightPay = string.Empty;
        readonly string _testCarryOnBaggage = string.Empty;
        readonly string _testMetalObjects = string.Empty;
        readonly string _testMetalDetectorFrame = string.Empty;
        readonly string _testVerificationChange = string.Empty;
        readonly string _testCheckTalonNumber = string.Empty;
        readonly string _testCheckPassportNumber = string.Empty;
        internal string TestCheckOk
        {
            get { return _testCheckOk; }
        }
        internal string TestCheckFail
        {
            get { return _testCheckFail; }
        }
        internal string TestBuggageWeight
        {
            get { return _testBuggageWeight; }
        }
        internal string TestBuggageWeightPay
        {
            get { return _testBuggageWeightPay; }
        }
        internal string TestCarryOnBaggage
        {
            get { return _testCarryOnBaggage; }
        }
        internal string TestMetalObjects
        {
            get { return _testMetalObjects; }
        }
        internal string TestMetalDetectorFrame
        {
            get { return _testMetalDetectorFrame; }
        }
        internal string TestVerificationChange
        {
            get { return _testVerificationChange; }
        }
        internal string TestCheckTalonNumber
        {
            get { return _testCheckTalonNumber; }
        }
        internal string TestCheckPassportNumber
        {
            get { return _testCheckPassportNumber; }
        }
        internal LanguageTerminalTest(string languageSelect)
        {

            if (languageSelect.Equals(RU, StringComparison.Ordinal))
            {
                _testCheckOk = "<Проверка успешна>";
                _testCheckFail = "<Неверное значение, попробуйте снова>";
                _testBuggageWeight = "<Введите вес багажа в кг>";
                _testBuggageWeightPay = "<Доплатить за превышение> - 1\n<Уменьшить вес введите> - любое число";
                _testCarryOnBaggage = "<Введите вес ручной клади в кг>";
                _testMetalObjects = "<Если нет запрещенных предметов введите> - 1\n<Иначе введите> любое число";
                _testMetalDetectorFrame = "<Если рамка металодетектора пройдена успешно введите> - 1\n<Иначе введите> - любой символ";
                _testVerificationChange = "<Если охрана решает проблемы досмотра то нажмите> - 1";
                _testCheckTalonNumber = "<Введите номер талона для проверки>";
                _testCheckPassportNumber = "<Введите серию и номер паспорта для проверки>";
            }
            else if (languageSelect.Equals(EN, StringComparison.Ordinal))
            {
                _testCheckOk = "<Verification successful> ";
                _testCheckFail = "<Invalid value, try again>";
                _testBuggageWeight = "<Enter luggage weight in kg>";
                _testBuggageWeightPay = "<Pay extra for excess> - 1\n<To reduce the weight> - any number";
                _testCarryOnBaggage = "<Enter the weight of carry-on in kg>";
                _testMetalObjects = "<If there are no prohibited items, enter> - 1\n<Else> - any number";
                _testMetalDetectorFrame = "<If the frame of the metal detector is successful, enter > - 1\n<Else> - any number";
                _testVerificationChange = "<If security solves verification problems, enter> - 1";
                _testCheckTalonNumber = "<Enter talon number to check>";
                _testCheckPassportNumber = "<Enter passport number to check>";
            }
        }
    }
    
}
