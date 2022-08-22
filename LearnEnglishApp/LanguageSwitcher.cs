using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglishApp
{
    public static class LanguageSwitcher
    {
        private static InputLanguage? GetInputLanguageByName(string inputName)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.EnglishName.ToLower().StartsWith(inputName))
                    return lang;
            }
            return null;
        }

        public static void SetEn()
        {
            InputLanguage.CurrentInputLanguage = GetInputLanguageByName("english (united kindom)");
        }

        public static void SetRu()
        {
            InputLanguage.CurrentInputLanguage = GetInputLanguageByName("russian (russia)");
        }

    }
}
