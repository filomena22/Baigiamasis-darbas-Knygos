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
            internal static string buttonSubmit = "//*[@type='submit']";
            internal static string buttonPrisijungti = "//*[@class='ico-user']";
            internal static string inputElPastoAdresas = "//*[@id='emailInput']";
            internal static string inputSlaptazodis = "//*[@id='passwordInput']";
        }

        internal static class AddToCart
        {
            internal static string buttonDovanuKuponai = "//*[@id='footer-wrapper']/div/div[8]/ul/li[1]/h4/a";
            internal static string button10 = "//*[@id='add_to_cart_single_custom_params_value_value_preset']/span[1]/label";
            internal static string buttonIKrepseli = "//*[@id='add_to_cart_single_add_to_cart']";
            internal static string dovanuKuponaiButton = "//*[@id='footer-wrapper']/div/div[8]/ul/li[1]/h4/a";
            internal static string IKrepseliButton = "//*[@id='add_to_cart_single_add_to_cart']";
            internal static string dovanukuponasTitle = "//*[@id='cart-items']/div[2]/div[1]/div/div[1]/a";
            internal static string Button = "//*[@id='add_to_cart_single_custom_params_value_value_preset']/span[1]/label";
        }

        internal static class RemoveFromCart
        {
            internal static string buttonDovanuKuponai = "//*[@id='footer-wrapper']/div/div[8]/ul/li[1]/h4/a";
            internal static string buttonIKrepseli = "//*[@id='add_to_cart_single_add_to_cart']";
            internal static string DovanuKuponaiButton = "//*[@id='footer-wrapper']/div/div[8]";
            internal static string button20 = "//*[@id='add_to_cart_single_custom_params_value_value_preset_1'];";
            internal static string buttonRecycle = "//*[@id='cart_items_items_16087986_remove']";
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
            internal static string ClickPrisijungtiButton = "//*[@id='hr-1']/div[4]/div/div[2]/a/span[2]";
            internal static string ClickRegistruotisButton = "/html/body/main/div/div[2]/div[2]/div/div[1]/div/div[3]/div/a";
            internal static string InputVardas = "//*[@id='registration_user_firstname']";
            internal static string InputPavarde = "//*[@id='registration_user_lastname']";
            internal static string InputTelefonas = "//*[@id='registration_user_phone']";
            internal static string InputElPastoAdresas = "//*[@id='registration_user_email']";
            internal static string InputSlaptazodis = "//*[@id='registration_password_first']";
            internal static string InputPakartotiSlaptazodi = "//*[@id='registration_password_second']";
            internal static string ClickCheckbox = "//*[@id='registration_agree_to_tos']";
            internal static string ClickSubmitButton = "//*[@id='registration_submit']";
            internal static string checkbox = "//*[@id='registration_agree_to_tos']";
            internal static string inputPavarde = "//*[@id='registration_user_lastname']";
            internal static string inputVardas = "//*[@id='registration_user_phone']";
            internal static string inputTelefonas = "//*[@id='registration_user_phone']";
            internal static string prisijungtiButton = "//*[@class='ico-user']";
            internal static string registruotisButton = "//*[@class='btn-primary']";
            internal static string registerButton = "//*[@id='registration_submit']";
        }
    }
}

