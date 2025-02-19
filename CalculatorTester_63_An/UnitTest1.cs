using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using B1_Calcualator_63_An;

namespace CalculatorTester_63_An
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation_63_An c_63_An;
        [TestInitialize] // Thiet lap DL dung chung cho cac TC
        public void SetUp_63_An()
        {
            c_63_An = new Calculation_63_An(10, 5);
        }
        [TestMethod]
        // TC1: a=10, b=5, kq = 15
        public void TC1_Cong_63_An()
        {
            int expected_63_An, actual_63_An; // Tao 2 bien luu gia tri mong doi va gia tri that su
            expected_63_An = 15; // gia tri mong doi = 15
            actual_63_An = c_63_An.Execute_63_An("+"); //goi ham tinh gia tri that su
            Assert.AreEqual(expected_63_An, actual_63_An); // so sanh kq mong doi voi kq that su
        }

        [TestMethod]
        // TC2: a=10, b=5, kq = 5
        public void TC2_Tru_63_An()
        {
            int expected_63_An, actual_63_An; // Tao 2 bien luu gia tri mong doi va gia tri that su
            expected_63_An = 5; // gia tri mong doi = 5
            actual_63_An = c_63_An.Execute_63_An("-"); //goi ham tinh gia tri that su
            Assert.AreEqual(expected_63_An, actual_63_An); // so sanh kq mong doi voi kq that su
        }

        [TestMethod]
        // TC3: a=10, b=5, kq = 50
        public void TC3_Nhan_63_An()
        {
            int expected_63_An, actual_63_An; // Tao 2 bien luu gia tri mong doi va gia tri that su
            expected_63_An = 50; // gia tri mong doi = 50
            actual_63_An = c_63_An.Execute_63_An("*"); //goi ham tinh gia tri that su
            Assert.AreEqual(expected_63_An, actual_63_An); // so sanh kq mong doi voi kq that su
        }

        [TestMethod]
        // TC4: a=10, b=5, kq = 2
        public void TC4_Chia_63_An()
        {
            int expected_63_An, actual_63_An; // Tao 2 bien luu gia tri mong doi va gia tri that su
            expected_63_An = 5; // gia tri mong doi = 2
            actual_63_An = c_63_An.Execute_63_An("/"); //goi ham tinh gia tri that su
            Assert.AreEqual(expected_63_An, actual_63_An); // so sanh kq mong doi voi kq that su
        }

        [TestMethod]
        // TC5: a=10, b=0
        [ExpectedException(typeof(DivideByZeroException))] // Ngoai le chia cho 0
        public void TC5_Chia0_63_An()
        {
            c_63_An = new Calculation_63_An(10, 0); //Khoi tao lai gia tri moi cho c voi a=10, b=0
            c_63_An.Execute_63_An("/");
        }
    }
}
