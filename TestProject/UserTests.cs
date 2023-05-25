using OOP.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestProject
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        [Category("Method_NewPostBox")]
        public void NewPostBox_Test_CorrectParameters()
        {
            //Arrange
            PostBoxList packages = new PostBoxList();
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987900", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            int appraised_price = 100;
            string full_name = user.Surname + " " + user.Name + " " + user.SecondName;
            string receiver_full_name = "Михайленко Оксана Павлівна";
            string receiver_adress = "м. Полтава, вул. Зелена 15";
            City receiver_town = City.Полтава;
            string receiver_phone = "+380505366212";
            string description = "Одяг";
            double weight = 0.2;
            //Act
            bool result = user.NewPostBox(appraised_price, full_name, user.Adress, City.Харків, user.Phone, receiver_full_name, receiver_adress, receiver_town, receiver_phone, description, weight, packages);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [Category("Method_NewPostBox")]
        public void NewPostBox_Test_CorrectParameters_EmptyDescription()
        {
            //Arrange
            PostBoxList packages = new PostBoxList();
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380903987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            int appraised_price = 100;
            string full_name = user.Surname + " " + user.Name + " " + user.SecondName;
            string receiver_full_name = "Михайленко Оксана Павлівна";
            string receiver_adress = "м. Полтава, вул. Зелена 15";
            City receiver_town = City.Полтава;
            string receiver_phone = "+380505366212";
            string description = "";
            double weight = 0.2;
            //Act
            bool result = user.NewPostBox(appraised_price, full_name, user.Adress, City.Харків, user.Phone, receiver_full_name, receiver_adress, receiver_town, receiver_phone, description, weight, packages);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [Category("Method_NewPostBox")]
        public void NewPostBox_Test_WeightIsMore1100()
        {
            //Arrange
            PostBoxList packages = new PostBoxList();
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            int appraised_price = 100;
            string full_name = user.Surname + " " + user.Name + " " + user.SecondName;
            string receiver_full_name = "Михайленко Оксана Павлівна";
            string receiver_adress = "м. Полтава, вул. Зелена 15";
            City receiver_town = City.Полтава;
            string receiver_phone = "+380505366212";
            string description = "";
            double weight = 1200;
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user.NewPostBox(appraised_price, full_name, user.Adress, City.Харків, user.Phone, receiver_full_name, receiver_adress, receiver_town, receiver_phone, description, weight, packages));
        }
        [TestMethod]
        [Category("Method_NewPostBox")]
        public void NewPostBox_Test_WeightIsLess_01()
        {
            //Arrange
            PostBoxList packages = new PostBoxList();
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            int appraised_price = 100;
            string full_name = user.Surname + " " + user.Name + " " + user.SecondName;
            string receiver_full_name = "Михайленко Оксана Павлівна";
            string receiver_adress = "м. Полтава, вул. Зелена 15";
            City receiver_town = City.Полтава;
            string receiver_phone = "+380505366212";
            string description = "";
            double weight = 0.05;
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user.NewPostBox(appraised_price, full_name, user.Adress, City.Харків, user.Phone, receiver_full_name, receiver_adress, receiver_town, receiver_phone, description, weight, packages));
        }
        [TestMethod]
        [Category("Method_NewPostBox")]
        public void NewPostBox_Test_IncorrectFormatOfReceiverPhone()
        {
            //Arrange
            PostBoxList packages = new PostBoxList();
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            int appraised_price = 100;
            string full_name = user.Surname + " " + user.Name + " " + user.SecondName;
            string receiver_full_name = "Михайленко Оксана Павлівна";
            string receiver_adress = "м. Полтава, вул. Зелена 15";
            City receiver_town = City.Полтава;
            string receiver_phone = "0505366212";
            string description = "";
            double weight = 0.2;
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user.NewPostBox(appraised_price, full_name, user.Adress, City.Харків, user.Phone, receiver_full_name, receiver_adress, receiver_town, receiver_phone, description, weight, packages));
        }
        [TestMethod]
        [Category("Method_NewPostBox")]
        public void NewPostBox_Test_EmptyString_ReceiverPhone()
        {
            //Arrange
            PostBoxList packages = new PostBoxList();
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            int appraised_price = 100;
            string full_name = user.Surname + " " + user.Name + " " + user.SecondName;
            string receiver_full_name = "Михайленко Оксана Павлівна";
            string receiver_adress = "м. Полтава, вул. Зелена 15";
            City receiver_town = City.Полтава;
            string receiver_phone = " ";
            string description = "";
            double weight = 0.2;
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user.NewPostBox(appraised_price, full_name, user.Adress, City.Харків, user.Phone, receiver_full_name, receiver_adress, receiver_town, receiver_phone, description, weight, packages));
        }
        [TestMethod]
        [Category("Method_NewPostBox")]
        public void NewPostBox_Test_EmptyReceiverAddress()
        {
            //Assert
            PostBoxList packages = new PostBoxList();
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            int appraised_price = 100;
            string full_name = user.Surname + " " + user.Name + " " + user.SecondName;
            string receiver_full_name = "Михайленко Оксана Павлівна";
            string receiver_adress = "";
            City receiver_town = City.Полтава;
            string receiver_phone = "+380505366212";
            string description = "Одяг";
            double weight = 0.2;
            //Act and Assert
            Assert.ThrowsException<ArgumentException>(() => user.NewPostBox(appraised_price, full_name, user.Adress, City.Харків, user.Phone, receiver_full_name, receiver_adress, receiver_town, receiver_phone, description, weight, packages));
        }
        [TestMethod]
        [Category("Method_NewPostBox")]
        public void NewPostBox_Test_EmptyReceiverFullName()
        {
            //Arrange
            PostBoxList packages = new PostBoxList();
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            int appraised_price = 100;
            string full_name = user.Surname + " " + user.Name + " " + user.SecondName;
            string receiver_full_name = "";
            string receiver_adress = "м. Полтава, вул. Зелена 15";
            City receiver_town = City.Полтава;
            string receiver_phone = "+380505366212";
            string description = "Одяг";
            double weight = 0.2;
            //Act and Assert
            Assert.ThrowsException<ArgumentException>(() => user.NewPostBox(appraised_price, full_name, user.Adress, City.Харків, user.Phone, receiver_full_name, receiver_adress, receiver_town, receiver_phone, description, weight, packages));
        }
        [TestMethod]
        [Category("Method_NewPostBox")]
        public void NewPostBox_Test_IncorrectFormatOfReceiverFullName_NoSecondname()
        {
            //Arrange
            PostBoxList packages = new PostBoxList();
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            int appraised_price = 100;
            string full_name = user.Surname + " " + user.Name + " " + user.SecondName;
            string receiver_full_name = "Михайленко Оксана";
            string receiver_adress = "м. Полтава, вул. Зелена 15";
            City receiver_town = City.Полтава;
            string receiver_phone = "+380505366212";
            string description = "Одяг";
            double weight = 0.2;
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user.NewPostBox(appraised_price, full_name, user.Adress, City.Харків, user.Phone, receiver_full_name, receiver_adress, receiver_town, receiver_phone, description, weight, packages));
        }
        [TestMethod]
        [Category("Method_NewPostBox")]
        public void NewPostBox_Test_IncorrectFormatOfReceiverFullName_NoName()
        {
            //Arrange
            PostBoxList packages = new PostBoxList();
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            int appraised_price = 100;
            string full_name = user.Surname + " " + user.Name + " " + user.SecondName;
            string receiver_full_name = "Михайленко Павлівна";
            string receiver_adress = "м. Полтава, вул. Зелена 15";
            City receiver_town = City.Полтава;
            string receiver_phone = "+380505366212";
            string description = "Одяг";
            double weight = 0.2;
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user.NewPostBox(appraised_price, full_name, user.Adress, City.Харків, user.Phone, receiver_full_name, receiver_adress, receiver_town, receiver_phone, description, weight, packages));
        }
        [TestMethod]
        [Category("Method_NewPostBox")]
        public void NewPostBox_Test_IncorrectFormatOfReceiverFullName_NoSurName()
        {
            //Arrange
            PostBoxList packages = new PostBoxList();
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            int appraised_price = 100;
            string full_name = user.Surname + " " + user.Name + " " + user.SecondName;
            string receiver_full_name = "Оксана Павлівна";
            string receiver_adress = "м. Полтава, вул. Зелена 15";
            City receiver_town = City.Полтава;
            string receiver_phone = "+380505366212";
            string description = "Одяг";
            double weight = 0.2;
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user.NewPostBox(appraised_price, full_name, user.Adress, City.Харків, user.Phone, receiver_full_name, receiver_adress, receiver_town, receiver_phone, description, weight, packages));
        }

        [TestMethod]
        [Category("Method_ChangeOwnInfo")]
        public void ChangeOwnInfo_Test_ChangeSurname()
        {
            //Arrange
            User user1 = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@gmail.com", "143post555");
            User user2 = new User("Попова", "Тамара", "Дмитрівна", "+380505966212", "м. Полтава, вул. Незалежності, 4", "tamara.popova@gmail.com", "I3B&U6Us7RgO");
            
            UserList.users.Add(user1);
            UserList.users.Add(user2);

            string password = "143post555";
            string surname = "Петренко";
            //Act
            user1.ChangeOwnInfo(surname, user1.Name, user1.SecondName, "", user1.Adress, user1.Email, password);
            //Assert
            Assert.AreEqual(surname, user1.Surname);

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_ChangeOwnInfo")]
        public void ChangeOwnInfo_Test_ChangeSurname_Exception_NotFullSurname ()
        {
            //Arrange
            User user1 = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            User user2 = new User("Попова", "Тамара", "Дмитрівна", "+380505966212", "м. Полтава, вул. Незалежності, 4", "tamara.popova@gmil.com", "I3B&U6Us7RgO");

            UserList.users.Add(user1);
            UserList.users.Add(user2);

            string password = "143post555";
            string surname = "Пе";
            //Act and Assert
           Assert.ThrowsException<Exception>(() => user1.ChangeOwnInfo(surname, user1.Name, user1.SecondName, user1.Phone, user1.Adress, user1.Email, password));

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_ChangeOwnInfo")]
        public void ChangeOwnInfo_Test_ChangeSurnameOnNumbers_Exception()
        {
            //Arrange
            User user1 = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            User user2 = new User("Попова", "Тамара", "Дмитрівна", "+380505966212", "м. Полтава, вул. Незалежності, 4", "tamara.popova@gmil.com", "I3B&U6Us7RgO");

            UserList.users.Add(user1);
            UserList.users.Add(user2);

            string password = "143post555";
            string surname = "123";
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user1.ChangeOwnInfo(surname, user1.Name, user1.SecondName, user1.Phone, user1.Adress, user1.Email, password));

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_ChangeOwnInfo")]
        public void ChangeOwnInfo_Test_ChangeName()
        {
            //Arrange
            User user1 = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@gmail.com", "143post555");
            User user2 = new User("Попова", "Тамара", "Дмитрівна", "+380505966212", "м. Полтава, вул. Незалежності, 4", "tamara.popova@gmail.com", "I3B&U6Us7RgO");
            string password = "143post555";
            string name = "Тетяна";

            UserList.users.Add(user1);
            UserList.users.Add(user2);

            //Act
            user1.ChangeOwnInfo(user1.Surname, name, user1.SecondName, "", user1.Adress, user1.Email, password);
            //Assert
            Assert.AreEqual(name, user1.Name);

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_ChangeOwnInfo")]
        public void ChangeOwnInfo_Test_ChangeName_Exception_NotFullName()
        {
            //Arrange
            User user1 = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            User user2 = new User("Попова", "Тамара", "Дмитрівна", "+380505966212", "м. Полтава, вул. Незалежності, 4", "tamara.popova@gmil.com", "I3B&U6Us7RgO");
            string password = "143post555";
            string name = "Те";

            UserList.users.Add(user1);
            UserList.users.Add(user2);

            //Act and Assert
            Assert.ThrowsException<Exception>(() => user1.ChangeOwnInfo(user1.Surname, name, user1.SecondName, user1.Phone, user1.Adress, user1.Email, password));

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_ChangeOwnInfo")]
        public void ChangeOwnInfo_Test_ChangeNameOnNumbers_Exception()
        {
            //Arrange
            User user1 = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            User user2 = new User("Попова", "Тамара", "Дмитрівна", "+380505966212", "м. Полтава, вул. Незалежності, 4", "tamara.popova@gmil.com", "I3B&U6Us7RgO");
            string name = "123";
            string password = "143post555";

            UserList.users.Add(user1);
            UserList.users.Add(user2);

            //Act and Assert
            Assert.ThrowsException<Exception>(() => user1.ChangeOwnInfo(user1.Surname, name, user1.SecondName, user1.Phone, user1.Adress, user1.Email, password));

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_ChangeOwnInfo")]
        public void ChangeOwnInfo_Test_ChangeSecondName()
        {
            //Arrange
            User user1 = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@gmail.com", "143post555");
            User user2 = new User("Попова", "Тамара", "Дмитрівна", "+380505966212", "м. Полтава, вул. Незалежності, 4", "tamara.popova@gmail.com", "I3B&U6Us7RgO");
            string password = "143post555";
            string secondname = "Михайлівна";

            UserList.users.Add(user1);
            UserList.users.Add(user2);

            //Act
            user1.ChangeOwnInfo(user1.Surname, user1.Name, secondname, "", user1.Adress, user1.Email, password);
            //Assert
            Assert.AreEqual(secondname, user1.SecondName);

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_ChangeOwnInfo")]
        public void ChangeOwnInfo_Test_ChangeSecondName_Exception_NotFullLine()
        {
            //Arrange
            User user1 = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            User user2 = new User("Попова", "Тамара", "Дмитрівна", "+380505966212", "м. Полтава, вул. Незалежності, 4", "tamara.popova@gmil.com", "I3B&U6Us7RgO");
            string password = "143post555";
            string secondname = "Ми";

            UserList.users.Add(user1);
            UserList.users.Add(user2);

            //Act and Assert
            Assert.ThrowsException<Exception>(() => user1.ChangeOwnInfo(user1.Surname, user1.Name, secondname, user1.Phone, user1.Adress, user1.Email, password));

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_ChangeOwnInfo")]
        public void ChangeOwnInfo_Test_ChangeSecondNameOnNumbers_Exception()
        {
            //Assert
            User user1 = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            User user2 = new User("Попова", "Тамара", "Дмитрівна", "+380505966212", "м. Полтава, вул. Незалежності, 4", "tamara.popova@gmil.com", "I3B&U6Us7RgO");
            string password = "143post555";
            string secondname = "123";

            UserList.users.Add(user1);
            UserList.users.Add(user2);

            //Act and Assert
            Assert.ThrowsException<Exception>(() => user1.ChangeOwnInfo(user1.Surname, user1.Name, secondname, user1.Phone, user1.Adress, user1.Email, password));

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_ChangeOwnInfo")]
        public void ChangeOwnInfo_Test_ChangePhone()
        {
            //Arrange
            User user1 = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@gmail.com", "143post555");
            User user2 = new User("Попова", "Тамара", "Дмитрівна", "+380505966212", "м. Полтава, вул. Незалежності, 4", "tamara.popova@gmail.com", "I3B&U6Us7RgO");
            string password = "143post555";
            string phone = "+380505366212";

            UserList.users.Add(user1);
            UserList.users.Add(user2);

            //Act and Assert
            user1.ChangeOwnInfo(user1.Surname, user1.Name, user1.SecondName, phone, user1.Adress, user1.Email, password);

            Assert.AreEqual(phone, user1.Phone);

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_ChangeOwnInfo")]
        public void ChangeOwnInfo_Test_ChangePhone_WrongInput_Exception()
        {
            //Arrange
            User user1 = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            User user2 = new User("Попова", "Тамара", "Дмитрівна", "+380505966212", "м. Полтава, вул. Незалежності, 4", "tamara.popova@gmil.com", "I3B&U6Us7RgO");
            string password = "143post555";
            string phone = "0505366212";

            UserList.users.Add(user1);
            UserList.users.Add(user2);

            //Act and Assert
            Assert.ThrowsException<Exception>(() => user1.ChangeOwnInfo(user1.Surname, user1.Name, user1.SecondName, phone, user1.Adress, user1.Email, password));

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_ChangeOwnInfo")]
        public void ChangeOwnInfo_Test_ChangePhone_NotNumbers_Exception()
        {
            //Arrange
            User user1 = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            User user2 = new User("Попова", "Тамара", "Дмитрівна", "+380505966212", "м. Полтава, вул. Незалежності, 4", "tamara.popova@gmil.com", "I3B&U6Us7RgO");
            string password = "143post555";
            UserList.users.Add(user1);
            UserList.users.Add(user2);
            string phone = "abc";
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user1.ChangeOwnInfo(user1.Surname, user1.Name, user1.SecondName, phone, user1.Adress, user1.Email, password));

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_ChangeOwnInfo")]
        public void ChangeOwnInfo_Test_ChangeAddress()
        {
            //Arrange
            User user1 = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@gmail.com", "143post555");
            User user2 = new User("Попова", "Тамара", "Дмитрівна", "+380505966212", "м. Полтава, вул. Незалежності, 4", "tamara.popova@gmail.com", "I3B&U6Us7RgO");
            string password = "143post555";
            string address = "м. Харків, вул. Полтавський Шлях, 40";

            UserList.users.Add(user1);
            UserList.users.Add(user2);

            //Act
            user1.ChangeOwnInfo(user1.Surname, user1.Name, user1.SecondName, "", address, user1.Email, password);
            //Assert
            Assert.AreEqual(address, user1.Adress);

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_ChangeOwnInfo")]
        public void ChangeOwnInfo_Test_ChangeEmail()
        {
            //Arrange
            User user1 = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@gmail.com", "143post555");
            User user2 = new User("Попова", "Тамара", "Дмитрівна", "+380505966212", "м. Полтава, вул. Незалежності, 4", "tamara.popova@gmail.com", "I3B&U6Us7RgO");
            string password = "143post555";
            string email = "yuliakolyandra@gmail.com";

            UserList.users.Add(user1);
            UserList.users.Add(user2);
            //Act
            user1.ChangeOwnInfo(user1.Surname, user1.Name, user1.SecondName, "", user1.Adress, email, password);
            //Assert
            Assert.AreEqual(email, user1.Email);

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_ChangeOwnInfo")]
        public void ChangeOwnInfo_Test_ChangeEmail_WithoutAsperand_Exception()
        {
            //Arrange
            User user1 = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            User user2 = new User("Попова", "Тамара", "Дмитрівна", "+380505966212", "м. Полтава, вул. Незалежності, 4", "tamara.popova@gmil.com", "I3B&U6Us7RgO");
            string password = "143post555";
            string email = "yuliakolyandra";

            UserList.users.Add(user1);
            UserList.users.Add(user2);
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user1.ChangeOwnInfo(user1.Surname, user1.Name, user1.SecondName, user1.Phone, user1.Adress, email, password));

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_ChangeOwnInfo")]
        public void ChangeOwnInfo_Test_InputIncorrectPassword()
        {
            //Arrange
            User user1 = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            User user2 = new User("Попова", "Тамара", "Дмитрівна", "+380505966212", "м. Полтава, вул. Незалежності, 4", "tamara.popova@gmil.com", "I3B&U6Us7RgO");
            string password = "3lI#pV7Ntfe6";

            UserList.users.Add(user1);
            UserList.users.Add(user2);
            //Act and Assert
            Assert.ThrowsException<ArgumentException>(() => user1.ChangeOwnInfo(user1.Surname, user1.Name, user1.SecondName, user1.Phone, user1.Adress, user1.Email, password));

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_ChangeOwnInfo")]
        public void ChangeOwnInfo_Test_InputPasswordEmptyLine_Exception()
        {
            //Arrange
            User user1 = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            User user2 = new User("Попова", "Тамара", "Дмитрівна", "+380505966212", "м. Полтава, вул. Незалежності, 4", "tamara.popova@gmil.com", "I3B&U6Us7RgO");
            string password = " ";

            UserList.users.Add(user1);
            UserList.users.Add(user2);

            //Act and Assert
            Assert.ThrowsException<ArgumentException>(() => user1.ChangeOwnInfo(user1.Surname, user1.Name, user1.SecondName, user1.Phone, user1.Adress, user1.Email, password));

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }

        [TestMethod]
        [Category("Method_ChangePostBoxInfo")]
        public void ChangePostBoxInfo_Test_CorrectParameters()
        {
            //Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postBox1 = new PostBox(Status.У_дорозі, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
    "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox();
            postBox2.Code = "987654321";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2);

            string description = "Книги";
            //Act
            user.ChangePostBoxInfo("123456798", description);
            //Assert
            Assert.AreEqual(description, postBox1.Description);

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }
        [TestMethod]
        [Category("Method_ChangePostBoxInfo")]
        public void ChangePostBoxInfo_Test_WrongCode_Exception()
        {
            //Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postBox1 = new PostBox(Status.У_дорозі, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
    "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox();
            postBox2.Code = "987654321";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2);

            string description = "Книги та журнали";
            //Aact and Assert
            Assert.ThrowsException<ArgumentException>(() => user.ChangePostBoxInfo("987654320", description));

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }
        [TestMethod]
        [Category("Method_ChangePostBoxInfo")]
        public void ChangePostBoxInfo_Test_PostBoxIsArrived_Exception()
        {
            //Assert
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postBox1 = new PostBox(Status.Доставлено, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
    "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox();
            postBox2.Code = "987654321";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2);

            string description = "Книги та журнали";
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user.ChangePostBoxInfo("123456798", description));

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }
        [TestMethod]
        [Category("Method_ChangePostBoxInfo")]
        public void ChangePostBoxInfo_Test_PostBoxIsGetting_Exception()
        {
            //Assert
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postBox1 = new PostBox(Status.Одержано, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
    "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox();
            postBox2.Code = "987654321";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2);

            string description = "Книги та журнали";
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user.ChangePostBoxInfo("123456798", description));

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }

        [TestMethod]
        [Category("Method_Pay")]
        public void Pay_Test_CorrectParameters()
        {
            //Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postBox1 = new PostBox(Status.У_дорозі, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
    "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox();
            postBox2.Code = "987654321";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2);

            string card_number = "120004860234";
            string code = "123456798";
            string mm_yy = "12/24";
            string cvv = "312";
            //Act
            user.Pay(code, card_number, mm_yy, cvv, "+380505966212");
            //Assert
            Assert.AreEqual(PaymentStatus.Оплачено, postBox1.PaymentStatus);

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }
        [TestMethod]
        [Category("Method_Pay")]
        public void Pay_Test_WrongPostCode_Exception()
        {
            //Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postBox1 = new PostBox(Status.У_дорозі, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
    "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox();
            postBox2.Code = "987654321";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2);

            string card_number = "120004860234";
            string code = "987654320";
            string mm_yy = "12/24";
            string cvv = "312";
            //Act and Assert
            Assert.ThrowsException<ArgumentException>(() => user.Pay(code, card_number, mm_yy, cvv, user.Phone));

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }
        [TestMethod]
        [Category("Method_Pay")]
        public void Pay_Test_WrongCardNumber_Exception()
        {
            //Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postBox1 = new PostBox(Status.У_дорозі, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
    "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox();
            postBox2.Code = "987654321";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2);

            string card_number = "652830";
            string code = "123456798";
            string mm_yy = "12/24";
            string cvv = "312";
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user.Pay(code, card_number, mm_yy, cvv, "+380505966212"));

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }
        [TestMethod]
        [Category("Method_Pay")]
        public void Pay_Test_Wrong_MMYY_Exception()
        {
            //Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postBox1 = new PostBox(Status.У_дорозі, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
    "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox();
            postBox2.Code = "987654321";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2); 
            ;
            string card_number = "120004860234";
            string code = "123456798";
            string mm_yy = "1224";
            string cvv = "312";
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user.Pay(code, card_number, mm_yy, cvv, "+380505966212"));

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }
        [TestMethod]
        [Category("Method_Pay")]
        public void Pay_Test_Wrong_CVV_Exception()
        {
            //Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postBox1 = new PostBox(Status.У_дорозі, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
    "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox();
            postBox2.Code = "987654321";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2);

            string card_number = "120004860234";
            string code = "123456798";
            string mm_yy = "12/24";
            string cvv = "31245";
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user.Pay(code, card_number, mm_yy, cvv, "+380505966212"));

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }
        [TestMethod]
        [Category("Method_Pay")]
        public void Pay_Test_EmptyCardNumber_Exception()
        {
            //Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postBox1 = new PostBox(Status.У_дорозі, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
    "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox();
            postBox2.Code = "987654321";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2);

            string card_number = "";
            string code = "123456798";
            string mm_yy = "12/24";
            string cvv = "312";
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user.Pay(code, card_number, mm_yy, cvv, "+380505966212"));

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }
        [TestMethod]
        [Category("Method_Pay")]
        public void Pay_Test_EmptyMMYY_Exception()
        {
            //Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postBox1 = new PostBox(Status.У_дорозі, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
    "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox();
            postBox2.Code = "987654321";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2);

            string card_number = "120004860234";
            string code = "123456798";
            string mm_yy = "";
            string cvv = "312";
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user.Pay(code, card_number, mm_yy, cvv, "+380505966212"));

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }
        [TestMethod]
        [Category("Method_Pay")]
        public void Pay_Test_EmptyCVV_Exception()
        {
            //Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postBox1 = new PostBox(Status.У_дорозі, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
    "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox();
            postBox2.Code = "987654321";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2);

            string card_number = "120004860234";
            string code = "123456798";
            string mm_yy = "12/24";
            string cvv = "";
            //Act and Assert
            Assert.ThrowsException<Exception>(() => user.Pay(code, card_number, mm_yy, cvv, "+380505966212"));

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }


        [TestMethod]
        [Category("Method_CheckPostBox")]
        public void CheckPostBox_CorrectPackageInfo()
        {
            // Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postBox1 = new PostBox(Status.Створено, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
    "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox(Status.У_дорозі, DateTime.Now, DateTime.Now.AddDays(13), PaymentStatus.Оплачено, 100.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Соколова Тамара Дмитрівна", "м. Херсон, вул. Незалежності, 123", City.Херсон,
    "+380505966212", "Одяг", "Харків--Полтава", 1, "987654321");
            string expectedPackageInfo = $"Код посилки: {postBox1.Code}\nСтатус: {postBox1.Status}\nДата відправки: {postBox1.StartDate}\n" +
    $"Дата отримання: {postBox1.LastDate}\nСтатус оплати: {postBox1.PaymentStatus}\nЦіна: {postBox1.Price}\nЦіна відшкодування: {postBox1.AppraisedPrice}\n" +
    $"Відправник: {postBox1.Sender}\nАдреса відправника: {postBox1.SenderAdress}\nМісто відправника: {postBox1.SenderTown}\nТелефон відправника: {postBox1.SenderPhone}\n" +
    $"Одержувач: {postBox1.Receiver}\nАдреса одержувача: {postBox1.ReceiverAdress}\nМісто одержувача: {postBox1.ReceiverTown}\nТелефон одержувача: {postBox1.ReceiverPhone}\n" +
    $"Опис: {postBox1.Description}\nДеталі: {postBox1.Details}\nВага: {postBox1.Weight}\n";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2);

            string code = "123456798";
            // Act
            string packageInfo = user.CheckPostBox(code);
            //Assert
            Assert.AreEqual(expectedPackageInfo, packageInfo);

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }
        [TestMethod]
        [Category("Method_CheckPostBox")]
        public void CheckPostBox_WrongCode_PostBoxNotFound_Exception()
        {
            // Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postBox1 = new PostBox(Status.Створено, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
    "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox(Status.У_дорозі, DateTime.Now, DateTime.Now.AddDays(13), PaymentStatus.Оплачено, 100.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Соколова Тамара Дмитрівна", "м. Херсон, вул. Незалежності, 123", City.Херсон,
    "+380505966212", "Одяг", "Харків--Полтава", 1, "987654321");
            string expected = "Посилку не знайдено.";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2);

            string code = "123456780";
            // Act
            string actual = user.CheckPostBox(code);
            // Assert
            Assert.AreEqual(expected, actual);

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }
        [TestMethod]
        [Category("Method_CheckPostBox")]
        public void CheckPostBox_WrongCode_PostBoxHasAlreadyGotten_Exception()
        {
            // Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postBox1 = new PostBox(Status.Створено, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
    "+380505966212", "Книги", " ", 0.2, "123456798");
            PostBox postBox2 = new PostBox(Status.Одержано, DateTime.Now, DateTime.Now.AddDays(13), PaymentStatus.Оплачено, 100.0,
    60, "Коляндра Юлія Миколаївна", user.Adress, City.Харків, user.Phone, "Соколова Тамара Дмитрівна", "м. Херсон, вул. Незалежності, 123", City.Херсон,
    "+380505966212", "Одяг", "Харків--Полтава", 1, "987654321");
            string expected = "Посилку не знайдено.";

            PostBoxList.packages.Add(postBox1);
            PostBoxList.packages.Add(postBox2);

            string code = "987654321";
            // Act
            string actual = user.CheckPostBox(code);
            // Assert
            Assert.AreEqual(expected, actual);

            PostBoxList.packages.Remove(postBox1);
            PostBoxList.packages.Remove(postBox2);
        }

        [TestMethod]
        [Category("Method_CalculatePay")]
        public void CalculatePay_Test_CorrectParameters()
        {
            //Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            City sender = City.Дніпро;
            City receiver = City.Львів;
            double weight = 3.5;
            decimal expected = 242.5m;
            //Act
            decimal result=user.CalculatePay(sender, receiver, weight);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [Category("Method_CalculatePay")]
        public void CalculatePay_Test_WrongWeight_Exception()
        {
            //Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            City sender = City.Дніпро;
            City receiver = City.Львів;
            double weight = 0.01;
            //Act and Assert
            Assert.ThrowsException<ArgumentException>(() => user.CalculatePay(sender, receiver, weight));
        }

        [TestMethod]
        [Category("Method_Print")]
        public void Print_ReturnsCorrectString_WhenPackagesExist()
        {
            // Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            postbox1.Status=Status.Створено;
            postbox1.Price = 100;
            postbox1.PaymentStatus = PaymentStatus.Оплачено;
            postbox1.SenderPhone = "+380993987910";
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";
            postbox2.Status = Status.У_дорозі;
            postbox2.Price = 150;
            postbox2.PaymentStatus = PaymentStatus.Неоплачено;
            postbox2.SenderPhone = "+380505966212";
            PostBox postbox3 = new PostBox();
            postbox3.Code = "POST-003";
            postbox3.Status = Status.Доставлено;
            postbox3.Price = 75.5;
            postbox3.PaymentStatus = PaymentStatus.Неоплачено;
            postbox3.SenderPhone = "+380993987910";
            PostBox postbox4 = new PostBox();
            postbox4.Code = "POST-004";
            postbox4.Status = Status.Одержано;
            postbox4.Price = 60;
            postbox4.PaymentStatus = PaymentStatus.Неоплачено;
            postbox4.SenderPhone = "+380505966212";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);
            PostBoxList.packages.Add(postbox3);
            PostBoxList.packages.Add(postbox4);

            // Act
            var result = user.Print();

            // Assert
            string expected = user.Print();
            Assert.AreEqual(expected, result);

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
            PostBoxList.packages.Remove(postbox3);
            PostBoxList.packages.Remove(postbox4);
        }
        [TestMethod]
        [Category("Method_Print")]
        public void Print_ReturnsCorrectString_AllUsersPostsIsGetting()
        {
            // Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            postbox1.Status = Status.Одержано;
            postbox1.Price = 100;
            postbox1.PaymentStatus = PaymentStatus.Оплачено;
            postbox1.SenderPhone = "+380993987910";
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";
            postbox2.Status = Status.Одержано;
            postbox2.Price = 150;
            postbox2.PaymentStatus = PaymentStatus.Неоплачено;
            postbox2.SenderPhone = "+380505966212";
            PostBox postbox3 = new PostBox();
            postbox3.Code = "POST-003";
            postbox3.Status = Status.Одержано;
            postbox3.Price = 75.5;
            postbox3.PaymentStatus = PaymentStatus.Неоплачено;
            postbox3.SenderPhone = "+380993987910";
            PostBox postbox4 = new PostBox();
            postbox4.Code = "POST-004";
            postbox4.Status = Status.Одержано;
            postbox4.Price = 60;
            postbox4.PaymentStatus = PaymentStatus.Неоплачено;
            postbox4.SenderPhone = "+380505966212";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);
            PostBoxList.packages.Add(postbox3);
            PostBoxList.packages.Add(postbox4);

            // Act
            var result = user.Print();

            // Assert
            string expected = user.Print();
            Assert.AreEqual(expected, result);

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
            PostBoxList.packages.Remove(postbox3);
            PostBoxList.packages.Remove(postbox4);
        }
        [TestMethod]
        [Category("Method_Print")]
        public void Print_ReturnsEmptyString_WhenNoPackagesExist_UserNotSendPosts()
        {
            // Arrange
            User user = new User("Коляндра", "Юлія", "Миколаївна", "+380993987910", "м. Харків, вул. Астрономічна, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            postbox1.Status = Status.Створено;
            postbox1.Price = 100;
            postbox1.PaymentStatus = PaymentStatus.Оплачено;
            postbox1.SenderPhone = "+380935757421";
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";
            postbox2.Status = Status.У_дорозі;
            postbox2.Price = 150;
            postbox2.PaymentStatus = PaymentStatus.Неоплачено;
            postbox2.SenderPhone = "+380505966212";
            PostBox postbox3 = new PostBox();
            postbox3.Code = "POST-003";
            postbox3.Status = Status.Доставлено;
            postbox3.Price = 75.5;
            postbox3.PaymentStatus = PaymentStatus.Неоплачено;
            postbox3.SenderPhone = "+380506213303";
            PostBox postbox4 = new PostBox();
            postbox4.Code = "POST-004";
            postbox4.Status = Status.Одержано;
            postbox4.Price = 60;
            postbox4.PaymentStatus = PaymentStatus.Неоплачено;
            postbox4.SenderPhone = "+380505966212";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);
            PostBoxList.packages.Add(postbox3);
            PostBoxList.packages.Add(postbox4);

            // Act
            var result = user.Print();

            // Assert
            Assert.AreEqual("Посилок не знайдено.", result);

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
            PostBoxList.packages.Remove(postbox3);
            PostBoxList.packages.Remove(postbox4);
        }
    }
}