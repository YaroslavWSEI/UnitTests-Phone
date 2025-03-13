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
            Assert.AreEqual(wlasciciel, phone.Owner);
            Assert.AreEqual(numerTelefonu, phone.PhoneNumber);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_konstruktor_pusty_wlasciciel_ArgumentException()
        {
            // Arrange
            var wlasciciel = "";
            var numerTelefonu = "123456789";

            // Act
            var phone = new Phone(wlasciciel, numerTelefonu);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_konstruktor_pusty_numerTelefonu_ArgumentException()
        {
            // Arrange
            var wlasciciel = "Furmanov";
            var numerTelefonu = "";

            // Act
            var phone = new Phone(wlasciciel, numerTelefonu);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_konstruktor_numerTelefonu_niepoprawna_dlugosc_ArgumentException()
        {
            // Arrange
            var wlasciciel = "Furmanov";
            var numerTelefonu = "12345";

            // Act
            var phone = new Phone(wlasciciel, numerTelefonu);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_konstruktor_null_wlasciciel_ArgumentException()
        {
            // Arrange
            string wlasciciel = null;
            var numerTelefonu = "123456789";

            // Act
            var phone = new Phone(wlasciciel, numerTelefonu);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_konstruktor_null_numerTelefonu_ArgumentException()
        {
            // Arrange
            var wlasciciel = "Furmanov";
            string numerTelefonu = null;

            // Act
            var phone = new Phone(wlasciciel, numerTelefonu);
        }
    }
}