using System;
using NUnit.Framework; //меняем стандартную библиотеку от MS на вот эту


namespace DayOfYear.UnitTests
{
    [TestFixture]
    public class UnitTest
    {
        //тест корректный
        [Test]
        public void TestMethod1()
        {
            TheDayOfYear doy = new TheDayOfYear();
            Assert.AreEqual(60, doy.CalculateDayOfYear(2012, 02, 29));
        }
        //тест фэйл
        [Test]
        public void TestMethod2()
        {
            TheDayOfYear doy = new TheDayOfYear();
            Assert.AreEqual(50, doy.CalculateDayOfYear(2012, 02, 29));
        }
    }
}


//для работы с nUnit устанавливаем nUnit Test Adapter (TOOLS -> Extensions and Updates...)
//создаем второй проект в солюшене
//во второй проект добавляем (использую NuGet) NUnit
//удаляем ссылку на стандартную MS библиотеку, добавляем NUnit.Framework
//перед классом пишем [TestFixture]
// перед каждым тестом [Test]