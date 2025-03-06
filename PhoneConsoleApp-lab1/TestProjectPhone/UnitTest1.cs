using ClassLibrary;


namespace TestProjectPhone
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_konstruktor_dane_poprawne_Dzia³anie_ok()
        {
            ///AAA


            ///Arrange
            var wlasciciel = "Furmanov";
            var numerTelefonu = "123456789";
            ///act
            var phone = new Phone(wlasciciel, numerTelefonu);

            ///assert
            Assert.AreEqual(wlasciciel,phone.Owner);
            Assert.AreEqual(numerTelefonu, phone.PhoneNumber);
        }
    }
}