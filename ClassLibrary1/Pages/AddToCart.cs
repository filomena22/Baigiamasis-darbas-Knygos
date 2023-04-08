namespace Framework.Pages
{
    public class AddToCart
    {
        public static void Click10Button()
        {
            Common.ScrollAndClickElement(Locators.AddToCart.Button);
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
