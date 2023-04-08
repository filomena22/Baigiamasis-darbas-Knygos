namespace Framework.Pages
{
    public class Registration
    {
        public static void ClickPrisijungtiButton()
        {
            Common.ClickElement(Locators.Registration.prisijungtiButton);
        }

        public static void ClickRegistruotisButton()
        {
            Common.ClickElement(Locators.Registration.registruotisButton);
        }

        public static void InputVardas(string valueVardas)
        {
            Common.SendKeys(Locators.Registration.inputVardas, valueVardas);
        }

        public static void InputPavarde(string valuePavarde)
        {
            Common.SendKeys(Locators.Registration.inputPavarde, valuePavarde);
        }

        public static void InputTelefonas(string valueTelefonas)
        {
            Common.SendKeys(Locators.Registration.inputTelefonas, valueTelefonas);
        }

        public static void InputElPastoAdresas(string valueElPastoAdresas)
        {
            Common.SendKeys(Locators.Registration.inputElPastoAdresas, valueElPastoAdresas);
        }

        public static void InputSlaptazodis(string valueSlaptazodis)
        {
            Common.SendKeys(Locators.Registration.inputSlaptazodis, valueSlaptazodis);
        }

        public static void InputPakartotiSlaptazodi(string valuePakartotiSlaptazodi)
        {
            Common.SendKeys(Locators.Registration.inputPakartotiSlaptazodi, valuePakartotiSlaptazodi);
        }

        public static void ClickCheckbox()
        {
            Common.ClickElement(Locators.Registration.checkbox);
        }

        public static void ClickSubmitButton()
        {
            Common.ClickElement(Locators.Registration.registerButton);
        }

        public static string MessageFail()
        {
            return Common.GetElementText(Locators.Registration.klaida);

        }

        public static string GetRedirectedUrl()
        {
            return Driver.GetDriver().Url;
        }
    }
}