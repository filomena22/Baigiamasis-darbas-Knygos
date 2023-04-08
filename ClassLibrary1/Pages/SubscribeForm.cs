namespace Framework.Pages
{
    public class SubscribeForm
    {
        public static void InputElPastoAdresas(string valueElPastoAdresas)
        {
            Common.SendKeys(Locators.SubscribeForm.inputElPastoAdresas, valueElPastoAdresas);
        }

        public static void ClickButtonCheckBox1()
        {
            Common.ClickElement(Locators.SubscribeForm.buttonCheckBox1);
        }

        public static void ClickButtonCheckBox2()
        {
            Common.ClickElement(Locators.SubscribeForm.buttonCheckBox2);
        }

        public static void ClickButtonPrenumeruoti()
        {
            Common.ClickElement(Locators.SubscribeForm.buttonPrenumeruoti);
        }

        public static string SubscribeMessage()
        {
            return Common.GetElementText(Locators.SubscribeForm.Subscribe);

        }
        public static string GetRedirectedUrl()
        {
            return Driver.GetDriver().Url;
        }
    }
}
