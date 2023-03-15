namespace Framework.Pages
{
    public class Login
    {
        public static void InputElPastoAdresas (string valueElPastoAdresas)
        {
            Common.SendKeys(Locators.Login.inputElPastoAdresas, valueElPastoAdresas);
        }

        public static void InputSlaptazodis(string valueSlaptazodis)
        {
            Common.SendKeys(Locators.Login.inputSlaptazodis, valueSlaptazodis);
        }

        public static void ClickButtonPrisijungti()
        {
            Common.ClickElement(Locators.Login.buttonPrisijungti);
        }

        public static string GetRedirectedUrl()
        {
            return Driver.GetDriver().Url;
        }
    }
}
        

    

