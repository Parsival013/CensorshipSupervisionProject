using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CensorshipSupervisionLibrary;

namespace CensorshipSupervisionLibraryTests
{
    [TestClass]
    public class CensorshipSupervisionClassTests
    {
        /// <summary>
        /// Проверка на пустую строку
        /// </summary>
        [TestMethod]
        public void Supervision_StringEmpty_ReturnedStars()
        {
            //Arrange
            string text = string.Empty;
            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => CensorshipSupervisionClass.Supervision(text));
        }

        /// <summary>
        /// Замена звёздочками слова редиска, написанная на кириллице
        /// </summary>
        [TestMethod]
        public void Supervision_CensoreWord_ReturnedStars()
        {
            //Arrange
            string text = "редиска";
            string excepted = "***";
            //Act

            string actual = CensorshipSupervisionClass.Supervision(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Замена звёздочками слова редиска в родительном падеже, написанная на кириллице
        /// </summary>
        [TestMethod]
        public void Supervision_CensoreRoditelWord_ReturnedStars()
        {
            //Arrange
            string text = "редиски";
            string excepted = "***";
            //Act

            string actual = CensorshipSupervisionClass.Supervision(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Замена звёздочками слова редиска в дательном падеже, написанная на кириллице
        /// </summary>
        [TestMethod]
        public void Supervision_CensoreDatelWord_ReturnedStars()
        {
            //Arrange
            string text = "редиске";
            string excepted = "***";
            //Act

            string actual = CensorshipSupervisionClass.Supervision(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Замена звёздочками слова редиска в винительном падеже, написанная на кириллице
        /// </summary>
        [TestMethod]
        public void Supervision_CensoreVinitelWord_ReturnedStars()
        {
            //Arrange
            string text = "редиску";
            string excepted = "***";
            //Act

            string actual = CensorshipSupervisionClass.Supervision(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Замена звёздочками слова редиска в винительном падеже, написанная на кириллице
        /// </summary>
        [TestMethod]
        public void Supervision_CensoreTvoritelWord_ReturnedStars()
        {
            //Arrange
            string text = "редиской";
            string excepted = "***";
            //Act

            string actual = CensorshipSupervisionClass.Supervision(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }

        /// <summary>
        /// Замена звёздочками слова редиска, написанная на латинице
        /// </summary>
        [TestMethod]
        public void Supervision_EngCensoreWord_ReturnedStars()
        {
            //Arrange
            string text = "rediska";
            string excepted = "***";
            //Act

            string actual = CensorshipSupervisionClass.Supervision(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Замена звёздочками слова редиска, написанная на кириллице
        /// </summary>
        [TestMethod]
        public void Supervision_CensoreSoftWord_ReturnedStars()
        {
            //Arrange
            string text = "редисочка";
            string excepted = "***";
            //Act

            string actual = CensorshipSupervisionClass.Supervision(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Замена звёздочками слова РЕДИСКА
        /// </summary>
        [TestMethod]
        public void Supervision_CensoreWordUpper_ReturnedStars()
        {
            //Arrange
            string text = "РЕДИСКА";
            string excepted = "***";
            //Act

            string actual = CensorshipSupervisionClass.Supervision(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Замена звёздочками слова Редиска
        /// </summary>
        [TestMethod]
        public void Supervision_CensoreWordUpperFirstSymbol_ReturnedStars()
        {
            //Arrange
            string text = "Редиска";
            string excepted = "***";
            //Act

            string actual = CensorshipSupervisionClass.Supervision(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
      
}
