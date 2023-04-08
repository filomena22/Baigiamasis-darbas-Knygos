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
            Common.ScrollAndClickElement(Locators.SubscribeForm.buttonCheckBox1);
        }

        public static void ClickButtonCheckBox2()
        {
            Common.ScrollAndClickElement(Locators.SubscribeForm.buttonCheckBox2);
        }

        public static string ClickButtonPrenumeruoti()
        {
            string currentWindowHandle = Common.GetCurrentWindowHandle();
            Common.ScrollAndClickElement(Locators.SubscribeForm.buttonPrenumeruoti);

            return currentWindowHandle;
        }

        public static string SubscribeMessage(string parentWindowHandle)
        {
            Common.SwitchToNewTabFromParentTab(parentWindowHandle);
            Common.WaitForElementToBeVisible(Locators.SubscribeForm.Subscribe);
            return Common.GetElementText(Locators.SubscribeForm.Subscribe);

        }
    }
}
