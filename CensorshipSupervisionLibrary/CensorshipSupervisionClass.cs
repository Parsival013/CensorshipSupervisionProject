using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CensorshipSupervisionLibrary
{
    public class CensorshipSupervisionClass
    {
        /// <summary>
        /// Проверка и замена слова 'Редиска' на '***'(Звёздочки)
        /// </summary>
        /// <param name="textString">
        /// Строка, содержащая нецензурное слово
        /// </param>
        /// <returns>
        /// Возвращает запиканую строчку с нецензурным словом в звездочках
        /// </returns>
        public static string Supervision(string textString)
        { 
  
            switch (textString)
            {
                
                case "редиска":
                       return Regex.Replace(textString, "редиска", "***", RegexOptions.IgnoreCase);//Именительный падеж
                case "редисочка":
                    return Regex.Replace(textString, "редисочка", "***", RegexOptions.IgnoreCase);
                case "редиски":
                    return Regex.Replace(textString, "редиски", "***", RegexOptions.IgnoreCase);//Родительный падеж
                case "редиске":
                    return Regex.Replace(textString, "редиске", "***", RegexOptions.IgnoreCase);//Дательный падеж
                case "редиску":
                    return Regex.Replace(textString, "редиску", "***", RegexOptions.IgnoreCase);//Винительный падеж
                case "редиской":
                    return Regex.Replace(textString, "редиской", "***", RegexOptions.IgnoreCase);//Творительный падеж
                case "rediska":
                    return Regex.Replace(textString, "rediska", "***", RegexOptions.IgnoreCase);
                case "РЕДИСКА":
                    return Regex.Replace(textString, "РЕДИСКА", "***", RegexOptions.IgnoreCase);
                case "Редиска":
                    return Regex.Replace(textString, "Редиска", "***", RegexOptions.IgnoreCase);
                default:
                    if (textString == string.Empty)
                throw new ArgumentNullException("Поле не заполнено! Заполните поле!");
                    break;
            }
            return textString;
        }
    }
}
