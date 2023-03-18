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
            internal static string inputEmail = "//*[@id=\"emailInput\"]";
            internal static string inputPassword = "//*[@id=\"passwordInput\"]";
            internal static string buttonPrisijungti = "/html/body/main/div/div[2]/div[1]/div/div/div/form/div[4]/div/input";
            internal static object inputElPastoAdresas;
            internal static string buttonPrisijngti;

            public static object inputSlaptazodis { get; internal set; }
        }

        internal static class AddToCart
        {
            internal static string buttonDovanuKuponai = "//*[@id=\"footer-wrapper\"]/div/div[8]/ul/li[1]/h4/a";
            internal static string button10 = "//*[@id=\"add_to_cart_single_custom_params_value_value_preset\"]/span[1]/label";
            internal static string buttonIKrepseli = "//*[@id=\"add_to_cart_single_add_to_cart\"]";
            internal static string dovanuKuponaiButton;

            public static string IKrepseliButton { get; internal set; }
            public static string Button { get; internal set; }
        }

        internal static class RemoveFromCart
        {
            internal static readonly string buttonPrisijungti;
            internal static string buttonDovanuKuponai = "//*[@id=\"footer-wrapper\"]/div/div[8]/ul/li[1]/h4/a";
            internal static string button20 = "//*[@id=\"add_to_cart_single_custom_params_value_value_preset\"]/span[2]/label";
            internal static string buttonIKrepseli = "//*[@id=\"add_to_cart_single_add_to_cart\"]";
            internal static string buttonRecycle = "//*[@id=\"cart_items_items_16054655_remove\"]/span";
            
            

            public static string DovanuKuponaiButton { get; internal set; }
        }

        internal static class SubscribeForm
        {

            internal static string inputElPastoAdresas = "//*[@id=\"mce-EMAIL\"]";
            internal static string buttonCheckBox1 = "//*[@id=\"mc_embed_signup_scroll\"]/fieldset/div[1]/label";
            internal static string buttonCheckBox2 = "//*[@id=\"mc_embed_signup_scroll\"]/fieldset/div[2]/label";
            internal static string buttonPrenumeruoti = "//*[@id=\"mc-embedded-subscribe\"]";
        }

        internal static class Registration
        {
            internal static readonly string checkbox;
            internal static readonly string inputPakartotiSlaptazodi;
            internal static readonly string inputPavarde;
            internal static string ClickPrisijungtiButton = "//*[@id=\"hr-1\"]/div[4]/div/div[2]/a/span[2]";
            internal static string ClickRegistruotisButton = "/html/body/main/div/div[2]/div[2]/div/div[1]/div/div[3]/div/a";
            internal static string InputVardas = "//*[@id=\"registration_user_firstname\"]";
            internal static string InputPavarde = "//*[@id=\"registration_user_lastname\"]";
            internal static string InputTelefonas = "//*[@id=\"registration_user_phone\"]";
            internal static string InputElPastoAdresas = "//*[@id=\"registration_user_email\"]";
            internal static string InputSlaptazodis = "//*[@id=\"registration_password_first\"]";
            internal static string InputPakartotiSlaptazodi = "//*[@id=\"registration_password_second\"]";
            internal static string ClickCheckbox = "//*[@id=\"registration_agree_to_tos\"]";
            internal static string ClickSubmitButton = "//*[@id=\"registration_submit\"]";
            internal static string prisijungtiButton;
            internal static string registruotisButton;

            public static string buttonPrisijungti { get; internal set; }
            public static string registerButton { get; internal set; }
            public static string inputTelefonas { get; internal set; }
            public static string inputVardas { get; internal set; }
        }

        
        }

    }

