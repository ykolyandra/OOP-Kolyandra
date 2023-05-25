using OOP;
using OOP.Code;
using System.ComponentModel;
using System.Transactions;

namespace TestProject
{
    [TestClass]
    public class OperatorTests
    {
        [TestMethod]
        [Category("Method_ChangeStatus")]
        public void ChangeStatus_Test_StatusInTransit()
        {
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            postbox1.Status = Status.Створено;
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";
            postbox2.Status = Status.Одержано;
            string code = "POST-001";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);

            Operator post_operator= new Operator();

            Status status = Status.У_дорозі;

            // Act
            post_operator.ChangeStatus(code, status);

            // Assert
            Assert.AreEqual(status, postbox1.Status);


            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }
        [TestMethod]
        [Category("Method_ChangeStatus")]
        public void ChangeStatus_Test_StatusDelivered()
        {
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            postbox1.Status = Status.Створено;
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";
            postbox2.Status = Status.Одержано;
            string code = "POST-001";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);

            Operator post_operator = new Operator();

            Status status = Status.Одержано;

            // Act
            post_operator.ChangeStatus(code, status);

            // Assert
            Assert.AreEqual(status, postbox1.Status);

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }
        [TestMethod]
        [Category("Method_ChangeStatus")]
        public void ChangeStatus_Test_StatusCreated()
        {
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            postbox1.Status = Status.Створено;
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";
            postbox2.Status = Status.Одержано;
            string code = "POST-001";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);
            Operator post_operator = new Operator();
            //Assert
            Status status = Status.Створено;

            // Act
            post_operator.ChangeStatus(code, status);

            // Assert
            Assert.AreEqual(status, postbox1.Status);

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }

        [TestMethod]
        [Category("Method_ChangePayStatus")]
        public void ChangePay_Test_SetStatusPaid()
        {
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            postbox1.Status = Status.У_дорозі;
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";
            postbox2.Status = Status.Одержано;
            string code = "POST-002";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);

            PaymentStatus status = PaymentStatus.Оплачено;
            postbox1.PaymentStatus = PaymentStatus.Неоплачено;
            postbox2.PaymentStatus = PaymentStatus.Оплачено;

            Operator post_operator = new Operator();

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => post_operator.ChangePayStatus(code, status));


            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }
        [TestMethod]
        [Category("Method_ChangePayStatus")]
        public void ChangePay_Test_ThrowException_SetStatusNoPaid()
        {
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            postbox1.Status = Status.У_дорозі;
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";
            postbox2.Status = Status.Одержано;
            string code = "POST-002";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);

            PaymentStatus status = PaymentStatus.Неоплачено;
            postbox1.PaymentStatus = PaymentStatus.Неоплачено;
            postbox2.PaymentStatus = PaymentStatus.Оплачено;

            Operator post_operator = new Operator();

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => post_operator.ChangePayStatus(code, status));


            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }

        [TestMethod]
        [Category("Method_ChangeDetails")]
        public void ChangeDetails_Test_AddNewLocation()
        {
            Operator post_operator = new Operator();
            PostBox postbox1 = new PostBox(Status.Створено, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
     60, "Коляндра Юлія Миколаївна", " ", City.Харків, " ", "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
     "+380505966212", "Книги", "Суми", 0.2, "POST-001");
            PostBox postbox2 = new PostBox(Status.Створено, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
   60, "Коляндра Юлія Миколаївна", " ", City.Харків, " ", "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
   "+380505966212", "Книги", "Суми", 0.2, "POST-002");
            string code = "POST-001";
            string add_location = "Харків";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);
            // Act
            post_operator.ChangeDetails(code, add_location);

            // Assert
            Assert.AreEqual("Суми---Харків", postbox1.Details);

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }
        [TestMethod]
        [Category("Method_ChangeDetails")]
        public void ChangeDetails_Test_AddNothing()
        {
            Operator post_operator = new Operator();
            PostBox postbox1 = new PostBox(Status.Створено, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
     60, "Коляндра Юлія Миколаївна", " ", City.Харків, " ", "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
     "+380505966212", "Книги", "Суми", 0.2, "POST-001");
            PostBox postbox2 = new PostBox(Status.Створено, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, 50.0,
   60, "Коляндра Юлія Миколаївна", " ", City.Харків, " ", "Петренко Микола Павлович", "м. Дніпро, вул. Перемоги, 49", City.Дніпро,
   "+380505966212", "Книги", "Суми", 0.2, "POST-002");
            string code = "POST-001";
            string add_location = "";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);
            // Act
            post_operator.ChangeDetails(code, add_location);

            // Assert
            Assert.AreEqual("Суми", postbox1.Details);

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }

        [TestMethod]
        [Category("Method_SetLastDay")]
        public void SetLastDay_Test_SetArrivalDate_WrongPostCode()
        {
            // Arrange
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);

            postbox1.Status = Status.Одержано;
            Operator post_operator = new Operator();

            string code = "POST-00";

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => post_operator.SetLastDay(code, new DateTime(2023, 4, 27)));

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }
        [TestMethod]
        [Category("Method_SetLastDay")]
        public void SetLastDay_ThrowException_WhenArrivalDayLessThanStartDay()
        {
            // Arrange
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            postbox1.StartDate = DateTime.Now;
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);

            postbox1.Status = Status.Одержано;
            Operator post_operator = new Operator();

            string code = "POST-001";

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => post_operator.SetLastDay(code, new DateTime(2023, 4, 27)));

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }
        [TestMethod]
        [Category("Method_SetLastDay")]
        public void SetLastDay_ThrowException_WhenPackageIsGetting()
        {
            // Arrange
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);

            postbox1.Status = Status.Одержано;
            Operator post_operator = new Operator();

            string code = "POST-001";

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => post_operator.SetLastDay(code, new DateTime(2023, 4, 27)));

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }

        [TestMethod]
        [Category("Method_Print")]
        public void Print_ReturnsCorrectString_WithoutGettedPostBoxes()
        {
            // Arrange
            Operator post_operator = new Operator();
            PostBox postbox1 = new PostBox(Status.Створено, new DateTime(2023, 4, 27), new DateTime(2023, 5, 27), PaymentStatus.Неоплачено, 115,
            100, "Коляндра Юлія Миколаївна", "вул. Незалежності, 3", City.Дніпро, "+380993987910", "Максименко Дар'я Дмитрівна",
            "вул. Астрономічна, 3", City.Запоріжжя, "+380505966212", "Книги", "", 3, "POST-001");
            PostBox postbox2 = new PostBox(Status.У_дорозі, new DateTime(2023, 4, 30), new DateTime(2023, 5, 15), PaymentStatus.Неоплачено, 60,
            1000, "Коляндра Юлія Миколаївна", "вул. Незалежності, 3", City.Полтава, "+380993987910", "Максименко Дар'я Дмитрівна",
            "вул. Астрономічна, 3", City.Львів, "+380505966212", "Одяг", "Полтава---Київ", 1.5, "POST-002");
            PostBox postbox3 = new PostBox(Status.Доставлено, new DateTime(2023, 5, 1), new DateTime(2023, 5, 23), PaymentStatus.Оплачено, 75.5,
            200, "Коляндра Юлія Миколаївна", "вул. Незалежності, 3", City.Черкаси, "+380993987910", "Максименко Дар'я Дмитрівна",
            "вул. Астрономічна, 3", City.Миколаїв, "+380505966212", "Одяг", "Полтава---Київ", 1, "POST-003");
            PostBox postbox4 = new PostBox(Status.Одержано, new DateTime(2023, 4, 15), new DateTime(2023, 5, 5), PaymentStatus.Неоплачено, 50,
            200, "Коляндра Юлія Миколаївна", "вул. Незалежності, 3", City.Суми, "+380993987910", "Максименко Дар'я Дмитрівна",
            "вул. Астрономічна, 3", City.Одеса, "+380505966212", "Одяг", "Полтава---Київ", 0.5, "POST-004");

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);
            PostBoxList.packages.Add(postbox3);
            PostBoxList.packages.Add(postbox4);

            // Act
            var result = post_operator.Print();

            // Assert
            string expected = post_operator.Print();
            Assert.AreEqual(expected, result);

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
            PostBoxList.packages.Remove(postbox3);
            PostBoxList.packages.Remove(postbox4);
        }
        [TestMethod]
        [Category("Method_Print")]
        public void Print_ReturnsEmptyString_WhenNoPackagesExist()
        {
            // Arrange
            Operator post_operator = new Operator();
            // Act
            var result = post_operator.Print();

            // Assert
            Assert.AreEqual("Посилок не знайдено.", result);
        }
    }
}

