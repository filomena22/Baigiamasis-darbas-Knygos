using NUnit.Framework;
using Framework.Pages;

namespace Tests
{
    internal class RegistrationTest : BaseTest
    {
        [Test]
        public void RegistrationFormWithInvalidEmail()
        {
            string expectedText = "KLAIDA Nurodytas klaidingas el.pašto adresas";
            string valueVardas = "testas";
            string valuePavarde = "testukas";
            string valueTelefonas = "+370600000000";
            string valueElPastoAdresas = "test@22";
            string valueSlaptazodis = "testukas22";
            string valuePakartotiSlaptazodi = "testukas22";

            Registration.ClickPrisijungtiButton();
            Registration.ClickRegistruotisButton();
            Registration.InputVardas(valueVardas);
            Registration.InputPavarde(valuePavarde);
            Registration.InputTelefonas(valueTelefonas);
            Registration.InputElPastoAdresas(valueElPastoAdresas);
            Registration.InputSlaptazodis(valueSlaptazodis);
            Registration.InputPakartotiSlaptazodi(valuePakartotiSlaptazodi);
            Registration.ClickCheckbox();
            Registration.ClickSubmitButton();

            Assert.AreEqual(expectedText, Registration.MessageFail());
        }
    }
}


