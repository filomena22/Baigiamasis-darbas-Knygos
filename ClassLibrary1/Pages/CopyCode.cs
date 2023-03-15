using System;

namespace Framework.Pages
{
    public class CopyCode
    {

            public static void ClickButtonNuolaiduKuponai()
        {
            Common.ClickElement(Locators.CopyCode.buttonNuolaiduKuponai);

        }
        public static void ClickButtonKopijuotiKoda()
        {
            Common.ClickElement(Locators.CopyCode.buttonKopijuotiKoda);

        }

        public static void ClickEnterCode()
        {
            string copyCode = Clipboard.GetText();

        }

        public static object Liuks10()
        {
            throw new NotImplementedException();
        }
    }

}