using OOP.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class GuestTests
    {
        [TestMethod]
        [Category("Method_Registration")]
        public void Registration_Test_CorrectParameters()
        {
            // Arrange
            Guest guest = new Guest();
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            string surname = "Курашова";
            string name = "Анастасія";
            string secondname = "Олександрівна";
            string phone = "+380567912389";
            string address = "м. Потава, вул. Калинова, 43";
            string email = "kurashva@gmail.com";
            string password = "9ZZ=[*FtvkZ4hC<)";
            string password1 = "9ZZ=[*FtvkZ4hC<)";

            UserList.users.Add(user);   
            // Act
            guest.Registration(surname, name, secondname, phone, address, email, password, password1);

            // Assert
            Assert.AreEqual(2, UserList.users.Count);

            UserList.users.Remove(user);
        }
        [TestMethod]
        [Category("Method_Registration")]
        public void Registration_Test_EmptyParameters_Exception()
        {
            Guest guest = new Guest();
            // Arrange
            string surname = "";
            string name = "";
            string secondname = "";
            string phone = "";
            string address = "";
            string email = "";
            string password = "";
            string password1 = "";

            // Act and Assert
            Assert.ThrowsException<Exception>(() => guest.Registration(surname, name, secondname, phone, address, email, password, password1));
        }
        [TestMethod]
        [Category("Method_Registration")]
        public void Registration_Test_WrongSurname_Exception()
        {
            // Arrange
            Guest guest = new Guest();
            string surname = "Ку";
            string name = "";
            string secondname = "";
            string phone = "";
            string address = "";
            string email = "";
            string password = "";
            string password1 = "";

            // Act and Assert
            Assert.ThrowsException<Exception>(() => guest.Registration(surname, name, secondname, phone, address, email, password, password1));
        }
        [TestMethod]
        [Category("Method_Registration")]
        public void Registration_Test_SurnameIsNumber_Exception()
        {
            // Arrange
            Guest guest = new Guest();
            string surname = "123";
            string name = "";
            string secondname = "";
            string phone = "";
            string address = "";
            string email = "";
            string password = "";
            string password1 = "";

            // Act and Assert
            Assert.ThrowsException<Exception>(() => guest.Registration(surname, name, secondname, phone, address, email, password, password1));
        }
        [TestMethod]
        [Category("Method_Registration")]
        public void Registration_Test_WrongName_Exception()
        {
            // Arrange
            Guest guest = new Guest();
            string surname = "";
            string name = "Ку";
            string secondname = "";
            string phone = "";
            string address = "";
            string email = "";
            string password = "";
            string password1 = "";

            // Act and Assert
            Assert.ThrowsException<Exception>(() => guest.Registration(surname, name, secondname, phone, address, email, password, password1));
        }
        [TestMethod]
        [Category("Method_Registration")]
        public void Registration_Test_NameIsNumber_Exception()
        {
            // Arrange
            Guest guest = new Guest();
            string surname = "";
            string name = "123";
            string secondname = "";
            string phone = "";
            string address = "";
            string email = "";
            string password = "";
            string password1 = "";

            // Act and Assert
            Assert.ThrowsException<Exception>(() => guest.Registration(surname, name, secondname, phone, address, email, password, password1));
        }
        [TestMethod]
        [Category("Method_Registration")]
        public void Registration_Test_WrongSecondName_Exception()
        {
            // Arrange
            Guest guest = new Guest();
            string surname = "";
            string name = "";
            string secondname = "Ку";
            string phone = "";
            string address = "";
            string email = "";
            string password = "";
            string password1 = "";

            // Act and Assert
            Assert.ThrowsException<Exception>(() => guest.Registration(surname, name, secondname, phone, address, email, password, password1));
        }
        [TestMethod]
        [Category("Method_Registration")]
        public void Registration_Test_SecondNameIsNumber_Exception()
        {
            // Arrange
            Guest guest = new Guest();
            string surname = "";
            string name = "";
            string secondname = "123";
            string phone = "";
            string address = "";
            string email = "";
            string password = "";
            string password1 = "";

            // Act and Assert
            Assert.ThrowsException<Exception>(() => guest.Registration(surname, name, secondname, phone, address, email, password, password1));
        }
        [TestMethod]
        [Category("Method_Registration")]
        public void Registration_Test_WrongPhoneIsLetters_Exception()
        {
            // Arrange
            Guest guest = new Guest();
            string surname = "";
            string name = "";
            string secondname = "";
            string phone = "Ку";
            string address = "";
            string email = "";
            string password = "";
            string password1 = "";

            // Act and Assert
            Assert.ThrowsException<Exception>(() => guest.Registration(surname, name, secondname, phone, address, email, password, password1));
        }
        [TestMethod]
        [Category("Method_Registration")]
        public void Registration_Test_PhoneIsLessNumber_Exception()
        {
            // Arrange
            Guest guest = new Guest();
            string surname = "";
            string name = "";
            string secondname = "";
            string phone = "123";
            string address = "";
            string email = "";
            string password = "";
            string password1 = "";

            // Act and Assert
            Assert.ThrowsException<Exception>(() => guest.Registration(surname, name, secondname, phone, address, email, password, password1));
        }
        [TestMethod]
        [Category("Method_Registration")]
        public void Registration_Test_EmailWithoutAmpersand_Exception()
        {
            // Arrange
            Guest guest = new Guest();
            string surname = "";
            string name = "";
            string secondname = "";
            string phone = "";
            string address = "";
            string email = "kurashva";
            string password = "";
            string password1 = "";

            // Act and Assert
            Assert.ThrowsException<Exception>(() => guest.Registration(surname, name, secondname, phone, address, email, password, password1));
        }
        [TestMethod]
        [Category("Method_Registration")]
        public void Registration_Test_WrongAddress_Exception()
        {
            // Arrange
            Guest guest = new Guest();
            string surname = "";
            string name = "";
            string secondname = "";
            string phone = "";
            string address = "1";
            string email = "";
            string password = "";
            string password1 = "";

            // Act and Assert
            Assert.ThrowsException<Exception>(() => guest.Registration(surname, name, secondname, phone, address, email, password, password1));
        }
        [TestMethod]
        [Category("Method_Registration")]
        public void Registration_Test_PasswordMismatch_Exception()
        {
            // Arrange
            Guest guest = new Guest();
            string surname = "";
            string name = "";
            string secondname = "";
            string phone = "";
            string address = "";
            string email = "";
            string password = "password123";
            string password1 = "123password";

            // Act and Assert
            Assert.ThrowsException<Exception>(() => guest.Registration(surname, name, secondname, phone, address, email, password, password1));
        }

        [TestMethod]
        [Category("Method_CheckPostBox")]
        public void CheckPostBox_CorrectPackageInfo()
        {
            // Arrange
            Guest guest = new Guest();
            PostBox postBox1 = new PostBox(Status.Створено, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
    60, "Коляндра Юлія Миколаївна", "м. Харків, вул. Астрономічна, 17", City.Харків, "+380993987910", "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
    "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox(Status.У_дорозі, DateTime.Now, DateTime.Now.AddDays(13), PaymentStatus.Оплачено, 100.0,
    60, "Коляндра Юлія Миколаївна", "м. Харків, вул. Астрономічна, 17", City.Харків, "+380993987910", "Соколова Тамара Дмитрівна", "м. Херсон, вул. Незалежності, 123", City.Херсон,
    "+380505966212", "Одяг", "Харків--Полтава", 1, "987654321");
            string code = "123456798";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2);
            // Act
            string packageInfo = guest.CheckPostBox(code);

            // Assert
            string expectedPackageInfo = $"Посилка 123456798; Статус: Створено; Ціна: 50; Статус оплати: Неоплачено; Опис посилки: Книги; Маршрут:  .";
            Assert.AreEqual(expectedPackageInfo, packageInfo);

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }
        [TestMethod]
        [Category("Method_CheckPostBox")]
        public void CheckPostBox_WrongCode_PostBoxNotFound_Exception()
        {
            // Arrange
            Guest guest = new Guest();
            PostBox postBox1 = new PostBox(Status.Створено, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
   60, "Коляндра Юлія Миколаївна", "м. Харків, вул. Астрономічна, 17", City.Харків, "+380993987910", "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
   "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox(Status.У_дорозі, DateTime.Now, DateTime.Now.AddDays(13), PaymentStatus.Оплачено, 100.0,
    60, "Коляндра Юлія Миколаївна", "м. Харків, вул. Астрономічна, 17", City.Харків, "+380993987910", "Соколова Тамара Дмитрівна", "м. Херсон, вул. Незалежності, 123", City.Херсон,
    "+380505966212", "Одяг", "Харків--Полтава", 1, "987654321");
            string code = "123456789";
            string expected = "Посилку не знайдено.";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2);
            // Act
            string result=guest.CheckPostBox(code);
            // Assert
            Assert.AreEqual(expected, result);

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }
        [TestMethod]
        [Category("Method_CheckPostBox")]
        public void CheckPostBox_WrongCode_PostBoxHasAlreadyGotten_Exception()
        {
            // Arrange
            Guest guest = new Guest();
            PostBox postBox1 = new PostBox(Status.Створено, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
   60, "Коляндра Юлія Миколаївна", "м. Харків, вул. Астрономічна, 17", City.Харків, "+380993987910", "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
   "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox(Status.Одержано, DateTime.Now, DateTime.Now.AddDays(13), PaymentStatus.Оплачено, 100.0,
    60, "Коляндра Юлія Миколаївна", "м. Харків, вул. Астрономічна, 17", City.Харків, "+380993987910", "Соколова Тамара Дмитрівна", "м. Херсон, вул. Незалежності, 123", City.Херсон,
    "+380505966212", "Одяг", "Харків--Полтава", 1, "987654321");
            string code = "987654321";
            string expected = "Посилку не знайдено.";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2);
            // Act
            string result = guest.CheckPostBox(code);
            // Assert
            Assert.AreEqual(expected, result);

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }

        [TestMethod]
        [Category("Method_CalculatePay")]
        public void CalculatePay_Test_CorrectParameters()
        {
            //Arrange
            Guest guest = new Guest();
            City sender = City.Київ;
            City receiver = City.Харків;
            double weight = 3.5;
            decimal expected = 117.5m;
            //Act
            decimal result = guest.CalculatePay(sender, receiver, weight);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [Category("Method_CalculatePay")]
        public void CalculatePay_Test_WrongWeight_Exception()
        {
            //Arrange
            Guest guest = new Guest();
            City sender = City.Дніпро;
            City receiver = City.Львів;
            double weight = 0.01;
            //Act and Assert
            Assert.ThrowsException<ArgumentException>(() => guest.CalculatePay(sender, receiver, weight));
        }

    }
}
