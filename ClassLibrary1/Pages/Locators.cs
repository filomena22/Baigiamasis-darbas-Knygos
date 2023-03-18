using OpenQA.Selenium;
using System;
using System.Deployment.Internal;

namespace Framework.Pages
{
    internal class Locators
    {
        

        internal static class Login
        {
           
            internal static string ClickButtonPrisijungti = "//*[@id='username']";
            internal static string inputEmail = "//*[@id='emailInput']";
            internal static string inputPassword = "//*[@id='passwordInput']";
            internal static string buttonPrisijungti = "/html/body/main/div/div[2]/div[1]/div/div/div/form/div[4]/div/input";
            internal static string inputElPastoAdresas;
            internal static string buttonPrisijngti;
            internal static string inputSlaptazodis;
        }

        internal static class AddToCart
        {
            internal static string buttonDovanuKuponai = "//*[@id='footer-wrapper']/div/div[8]/ul/li[1]/h4/a";
            internal static string button10 = "//*[@id='add_to_cart_single_custom_params_value_value_preset']/span[1]/label";
            internal static string buttonIKrepseli = "//*[@id='add_to_cart_single_add_to_cart']";
            internal static string dovanuKuponaiButton;
            internal static string IKrepseliButton;
            internal static string dovanukuponasTitle;
            internal static string Button;
        }

        internal static class RemoveFromCart
        {
            internal static string buttonPrisijungti;
            internal static string buttonDovanuKuponai = "//*[@id='footer-wrapper']/div/div[8]/ul/li[1]/h4/a";
            internal static string button20 = "//*[@id='add_to_cart_single_custom_params_value_value_preset']/span[2]/label";
            internal static string buttonIKrepseli = "//*[@id='add_to_cart_single_add_to_cart']";
            internal static string buttonRecycle = "//*[@id='cart_items_items_16054655_remove']/span";
            internal static string DovanuKuponaiButton;
            internal static string cartmessage;
        }

        internal static class SubscribeForm
        {

            internal static string inputElPastoAdresas = "//*[@id='mce-EMAIL']";
            internal static string buttonCheckBox1 = "//*[@id='mc_embed_signup_scroll']/fieldset/div[1]/label";
            internal static string buttonCheckBox2 = "//*[@id='mc_embed_signup_scroll']/fieldset/div[2]/label";
            internal static string buttonPrenumeruoti = "//*[@id='mc-embedded-subscribe']";
            internal static string Subscribe;
        }

        internal static class Registration
        {
            internal static string checkbox = "";
            internal static string inputPakartotiSlaptazodi;
            internal static string inputPavarde;
            internal static string ClickPrisijungtiButton = "//*[@id='hr-1']/div[4]/div/div[2]/a/span[2]";
            internal static string ClickRegistruotisButton = "/html/body/main/div/div[2]/div[2]/div/div[1]/div/div[3]/div/a";
            internal static string InputVardas = "//*[@id='registration_user_firstname']";
            internal static string inputVardas;
            internal static string InputPavarde = "//*[@id='registration_user_lastname']";
            internal static string InputTelefonas = "//*[@id='registration_user_phone']";
            internal static string inputTelefonas;
            internal static string InputElPastoAdresas = "//*[@id='registration_user_email']";
            internal static string InputSlaptazodis = "//*[@id='registration_password_first']";
            internal static string InputPakartotiSlaptazodi = "//*[@id='registration_password_second']";
            internal static string ClickCheckbox = "//*[@id='registration_agree_to_tos']";
            internal static string ClickSubmitButton = "//*[@id='registration_submit']";
            internal static string prisijungtiButton;
            internal static string registruotisButton;
            internal static string registerButton;
            internal static string klaida;
        }
    }
}

