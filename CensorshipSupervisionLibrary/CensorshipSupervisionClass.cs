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
                       return Regex.Replace(textString, "редиска", "***");//Именительный падеж
                case "редисочка":
                    return Regex.Replace(textString, "редисочка", "***");
                case "редиски":
                    return Regex.Replace(textString, "редиски", "***");//Родительный падеж
                case "редиске":
                    return Regex.Replace(textString, "редиске", "***");//Дательный падеж
                case "редиску":
                    return Regex.Replace(textString, "редиску", "***");//Винительный падеж
                case "редиской":
                    return Regex.Replace(textString, "редиской", "***");//Творительный падеж
                case "rediska":
                    return Regex.Replace(textString, "rediska", "***");
                case "РЕДИСКА":
                    return Regex.Replace(textString, "РЕДИСКА", "***");
                case "Редиска":
                    return Regex.Replace(textString, "Редиска", "***");
                default:
                    if (textString == string.Empty)
                throw new ArgumentNullException("Поле не заполнено! Заполните поле!");
                    break;
            }
            return textString;
        }
    }
}
