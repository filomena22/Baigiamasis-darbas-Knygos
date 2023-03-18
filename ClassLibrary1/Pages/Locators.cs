using OpenQA.Selenium;
using System;
using System.Deployment.Internal;

namespace Framework.Pages
{
    internal class Locators
    {
        

        internal static class Login
        {
           
           
            internal static string buttonSubmit = "//*[@type='submit']";
            internal static string buttonPrisijungti = "//*[@class='ico-user']";
            internal static string inputElPastoAdresass = "//*[@id='emailInput']";
            internal static string inputSlaptazodiss = "//*[@id='passwordInput']";
        }

        internal static class AddToCart
        {
            internal static string dovanuKuponaiButton = "//*[@id='footer-wrapper']/div/div[8]/ul/li[1]/h4/a";
            internal static string IKrepseliButton = "//*[@id='add_to_cart_single_add_to_cart']";
            internal static string dovanukuponasTitle = "//*[@id='cart-items']/div[2]/div[1]/div/div[1]/a";
            internal static string Button = "//*[@id='add_to_cart_single_custom_params_value_value_preset']/span[1]/label";
        }

        internal static class RemoveFromCart
        {
            internal static string DovanuKuponaiButton = "//*[@id='footer-wrapper']/div/div[8]";
            internal static string button20 = "//*[@id='add_to_cart_single_custom_params_value_value_preset_1'];";
            internal static string buttonIKrepseli = "//*[@id='add_to_cart_single_add_to_cart']";
            internal static string buttonRecycle = "//*[@id='cart_items_items_16087986_remove']";
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
            internal static string checkbox = "//*[@id='registration_agree_to_tos']";
            internal static string inputPavarde = "//*[@id='registration_user_lastname']";
            internal static string inputVardas = "//*[@id='registration_user_phone']";
            internal static string inputTelefonas = "//*[@id='registration_user_phone']";
            internal static string prisijungtiButton = "//*[@class='ico-user']";
            internal static string registruotisButton = "//*[@class='btn-primary']";
            internal static string registerButton = "//*[@id='registration_submit']";
            internal static string klaida;
            internal static string inputPakartotiSlaptazodi;
        }
    }
}

