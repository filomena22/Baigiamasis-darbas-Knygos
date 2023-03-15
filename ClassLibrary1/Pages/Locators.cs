using OpenQA.Selenium;
using System;

namespace Framework.Pages
{
    internal class Locators
    {
        internal static class Login
        {
            internal static readonly object inputSlaptazodis;
            internal static string ClickButtonPrisijungti = "//*[@id='username']";
            internal static string inputEmail = "//*[@id=\"emailInput\"]";
            internal static string inputPassword = "//*[@id=\"passwordInput\"]";
            internal static string buttonPrisijungti = "/html/body/main/div/div[2]/div[1]/div/div/div/form/div[4]/div/input";
            internal static object inputElPastoAdresas;
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
        }

        internal static class CopyCode
        {
            internal static string buttonNuolaiduKuponai = "//*[@id=\"hr-1\"]/div[4]/div/div[1]/a/span[1]/img";
            internal static string button = "//*[@id=\"homepage\"]/div[2]/div/div[2]/div/div[2]/div/div[2]/div[2]/label/span[1]";
            internal static string inputsearchbutton = "//*[@id=\"product-search\"]";
            internal static string buttonKopijuotiKoda;

            public static string buttonPrisijungti { get; internal set; }
        }

        
        }

    }

