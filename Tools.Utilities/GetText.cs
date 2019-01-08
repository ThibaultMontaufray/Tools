using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Utilities
{
    public static class GetText
    {
        public enum Language
        {
            FRENCH,
            ENGLISH
        }
        public static Language CurrentLanguage = Language.ENGLISH;
        public static string Text(string text)
        {
            string retStr = string.Empty;
            CurrentLanguage = (Language)Enum.Parse(typeof(Language), Settings.Default.language);
            switch (CurrentLanguage)
            {
                case Language.FRENCH:
                    retStr = ResourceFrench.ResourceManager.GetString(text);
                    break;
                case Language.ENGLISH:
                    retStr = ResourceEnglish.ResourceManager.GetString(text);
                    break;
                default:
                    retStr = text;
                    break;
            }
            return string.IsNullOrEmpty(retStr) ? text : retStr;
        }
    }
}
