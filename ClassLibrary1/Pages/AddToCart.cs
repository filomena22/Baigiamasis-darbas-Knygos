using Framework.Pages;
using System;

namespace Framework
{
    public class AddToCart
    {

        public static void ClickDovanuKuponaiButton()
        {
            Common.ClickElement(Locators.AddToCart.dovanuKuponaiButton);
        }


        public static void Click10Button()
        {

            Common.ClickElement(Locators.AddToCart.Button);
        }

        public static void ClickIKrepseliButton()
        {

            Common.ClickElement(Locators.AddToCart.IKrepseliButton);
        }


        public static string CartMessage()
        {
            return Common.GetElementText(Locators.AddToCart.dovanukuponasTitle);

        }
    }
}
