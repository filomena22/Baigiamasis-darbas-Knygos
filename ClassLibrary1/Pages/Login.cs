

namespace Framework.Pages
{
    public class Login
    {

        public static void ClickButtonPrisijungtiRegistruotis()
        {
            Common.ClickElement(Locators.Login.buttonPrisijungti);
            

        }

        public static void InputElPastoAdresas (string valueElPastoAdresas)
        {
            Common.SendKeys(Locators.Login.inputElPastoAdresass, valueElPastoAdresas);
        }

        public static void InputSlaptazodis(string valueSlaptazodis)
        {
            Common.SendKeys(Locators.Login.inputSlaptazodiss, valueSlaptazodis);
        }

        public static void ClickButtonPrisijungti()
        {
            Common.ClickElement(Locators.Login.buttonSubmit);
            
        }

        public static string GetRedirectedUrl()
        {
            return Driver.GetDriver().Url;
        }
    }
}
        

    

