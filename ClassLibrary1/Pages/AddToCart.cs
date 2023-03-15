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


        public static void ClickButton()
        {
           
            Common.ClickElement(Locators.AddToCart.Button);
        }

        public static void ClickIKrepseliButton()
        {
           
            Common.ClickElement(Locators.AddToCart.IKrepseliButton);
        }

        }
    }
}
