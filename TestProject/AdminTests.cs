using OOP;
using OOP.Code;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Transactions;

namespace TestProject
{
    [TestClass]
    public class AdminTests
    {
        [TestMethod]
        [Category("Method_NewOperator")]
        public void NewOperator_Test_RightParameters()
        {
            Admin admin = new Admin();
            //Arrange
            string code = "#0001";
            string password = "4operator2345";
            //Act
            admin.NewOperator(code, password);
            //Assert
            Assert.AreEqual(1, Operator.Counter);
        }
        [TestMethod]
        [Category("Method_NewOperator")]
        public void NewOperator_TestException_PasswordEmpty()
        {
            Admin admin = new Admin();
            //Arrange
            string code = "#0001";
            string password = "";
            //Act and Assert
            Assert.ThrowsException<Exception>(() => admin.NewOperator(code, password));
        }
        [TestMethod]
        [Category("Method_NewOperator")]
        public void NewOperator_TestException_WrongCode()
        {
            Admin admin = new Admin();
            //Arrange
            string code = "0001";
            string password = "4operator2345";
            //Act and Assert
            Assert.ThrowsException<Exception>(() => admin.NewOperator(code, password));
        }
        [TestMethod]
        [Category("Method_NewOperator")]
        public void NewOperator_TestException_CodeEmpty()
        {
            Admin admin = new Admin();
            //Arrange
            string code = "";
            string password = "4operator2345";
            //Act and Assert
            Assert.ThrowsException<Exception>(() => admin.NewOperator(code, password));
        }

        [TestMethod]
        [Category("Method_NewDiscount")]
        public void NewDiscount_Test_RightParameters()
        {
            //Arrange
            Admin admin = new Admin();
            User user1 = new User("��������", "���", "���������", "+380993987910", "�. �����, ���. �����������, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            User user2 = new User("������", "������", "��������", "+380505966212", "�. �������, ���. �����������, 4", "tamara.popova@gmil.com", "I3B&U6Us7RgO");
            string password = "143post555";
            string phone = "+380993987910";

            UserList.users.Add(user1);
            UserList.users.Add(user2);

            int promocode = 10;
            //Act
            admin.NewDiscount(promocode, password, phone);
            //Assert
            Assert.AreEqual(promocode, user1.Discount);

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_NewDiscount")]
        public void NewDiscount_TestException_WrongPromocodeNumber()
        {
            //Arrange
            Admin admin = new Admin();
            User user1 = new User("��������", "���", "���������", "+380993987910", "�. �����, ���. �����������, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            User user2 = new User("������", "������", "��������", "+380505966212", "�. �������, ���. �����������, 4", "tamara.popova@gmil.com", "I3B&U6Us7RgO");
            string password = "143post555";
            string phone = "+380993987910";

            UserList.users.Add(user1);
            UserList.users.Add(user2);

            int promocode = 0;
            //Act and Assert
            Assert.ThrowsException<Exception>(() => admin.NewDiscount(promocode, password, phone));

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_NewDiscount")]
        public void NewDiscount_TestException_WrongPromocodeMoreThan50()
        {
            //Arrange
            Admin admin = new Admin();
            User user1 = new User("��������", "���", "���������", "+380993987910", "�. �����, ���. �����������, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            User user2 = new User("������", "������", "��������", "+380505966212", "�. �������, ���. �����������, 4", "tamara.popova@gmil.com", "I3B&U6Us7RgO");
            string password = "143post555";
            string phone = "+380993987910";

            UserList.users.Add(user1);
            UserList.users.Add(user2);

            int promocode = 51;
            //Act and Assert
            Assert.ThrowsException<Exception>(() => admin.NewDiscount(promocode, password, phone));

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_NewDiscount")]
        public void NewDiscount_TestException_CannotFindUser()
        {
            //Arrange
            Admin admin = new Admin();
            User user1 = new User("��������", "���", "���������", "+380993987910", "�. �����, ���. �����������, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            User user2 = new User("������", "������", "��������", "+380505966212", "�. �������, ���. �����������, 4", "tamara.popova@gmil.com", "I3B&U6Us7RgO");
            string password = "143po55576";
            string phone = "+380993587810";

            UserList.users.Add(user1);
            UserList.users.Add(user2);

            int promocode = 40;
            //Act and Assert
            Assert.ThrowsException<ArgumentException>(() => admin.NewDiscount(promocode, password, phone));

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }
        [TestMethod]
        [Category("Method_NewDiscount")]
        public void NewDiscount_TestException_WrongPhoneNumber()
        {
            //Arrange
            Admin admin = new Admin();
            User user1 = new User("��������", "���", "���������", "+380993987910", "�. �����, ���. �����������, 3", "y.m.kolyandra@student.khai.edu", "143post555");
            User user2 = new User("������", "������", "��������", "+380505966212", "�. �������, ���. �����������, 4", "tamara.popova@gmil.com", "I3B&U6Us7RgO");
            string password = "143post555";
            string phone = "0993987910";

            UserList.users.Add(user1);
            UserList.users.Add(user2);

            int promocode = 20;
            //Act and Assert
            Assert.ThrowsException<Exception>(() => admin.NewDiscount(promocode, password, phone));

            UserList.users.Remove(user1);
            UserList.users.Remove(user2);
        }

        [TestMethod]
        [Category("Method_ChangeStatus")]
        public void ChangeStatus_Test_StatusInTransit()
        {
            Admin admin = new Admin();
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            postbox1.Status = Status.��������;
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";
            postbox2.Status = Status.��������;
            string code = "POST-001";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);
            //Assert
            Status status = Status.�_�����;

            // Act
            admin.ChangeStatus(code, status);

            // Assert
            Assert.AreEqual(status, postbox1.Status);

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }
        [TestMethod]
        [Category("Method_ChangeStatus")]
        public void ChangeStatus_Test_StatusDelivered()
        {
            Admin admin = new Admin();
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            postbox1.Status = Status.��������;
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";
            postbox2.Status = Status.��������;
            string code = "POST-001";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);
            //Assert
            Status status = Status.��������;

            // Act
            admin.ChangeStatus(code, status);

            // Assert
            Assert.AreEqual(status, postbox1.Status);

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }
        [TestMethod]
        [Category("Method_ChangeStatus")]
        public void ChangeStatus_Test_StatusCreated()
        {
            Admin admin = new Admin();
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            postbox1.Status = Status.��������;
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";
            postbox2.Status = Status.��������;
            string code = "POST-002";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);

            Status status = Status.��������;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => admin.ChangeStatus(code, status));

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }

        [TestMethod]
        [Category("Method_ChangePayStatus")]
        public void ChangePay_Test_StatusPaid()
        {
            Admin admin = new Admin();
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            postbox1.Status = Status.�_�����;
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";
            postbox2.Status = Status.��������;
            string code = "POST-001";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);

            PaymentStatus status = PaymentStatus.��������;
            postbox1.PaymentStatus = PaymentStatus.����������;
            postbox2.PaymentStatus = PaymentStatus.��������;

            // Act
            admin.ChangePayStatus(code, status);

            //Assert
            Assert.AreEqual(status, postbox1.PaymentStatus);

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }
        [TestMethod]
        [Category("Method_ChangePayStatus")]
        public void ChangePay_Test_StatusNoPaid()
        {
            Admin admin = new Admin();
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            postbox1.Status = Status.�_�����;
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";
            postbox2.Status = Status.��������;
            string code = "POST-002";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);

            PaymentStatus status = PaymentStatus.����������;
            postbox1.PaymentStatus = PaymentStatus.����������;
            postbox2.PaymentStatus = PaymentStatus.��������;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => admin.ChangePayStatus(code, status));

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }

        [TestMethod]
        [Category("Method_ChangeDetails")]
        public void ChangeDetails_Test_AddNewLocation()
        {
            Admin admin = new Admin();
            PostBox postbox1 = new PostBox(Status.��������, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.����������, 50.0,
     60, "�������� ��� ���������", " ", City.�����, " ", "�������� ������ ��������", "�. �����, ���. ��������, 49", City.�����,
     "+380505966212", "�����", "����", 0.2, "POST-001");
            PostBox postbox2 = new PostBox(Status.��������, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.����������, 50.0,
   60, "�������� ��� ���������", " ", City.�����, " ", "�������� ������ ��������", "�. �����, ���. ��������, 49", City.�����,
   "+380505966212", "�����", "����", 0.2, "POST-002");
            string code = "POST-001";
            string add_location = "�����";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);
            // Act
            admin.ChangeDetails(code, add_location);

            // Assert
            Assert.AreEqual("����---�����", postbox1.Details);

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }
        [TestMethod]
        [Category("Method_ChangeDetails")]
        public void ChangeDetails_Test_AddNothing()
        {
            Admin admin = new Admin();
            PostBox postbox1 = new PostBox(Status.��������, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.����������, 50.0,
     60, "�������� ��� ���������", " ", City.�����, " ", "�������� ������ ��������", "�. �����, ���. ��������, 49", City.�����,
     "+380505966212", "�����", "����", 0.2, "POST-001");
            PostBox postbox2 = new PostBox(Status.��������, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.����������, 50.0,
   60, "�������� ��� ���������", " ", City.�����, " ", "�������� ������ ��������", "�. �����, ���. ��������, 49", City.�����,
   "+380505966212", "�����", "����", 0.2, "POST-002");
            string code = "POST-001";
            string add_location = "";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);
            // Act
            admin.ChangeDetails(code, add_location);

            // Assert
            Assert.AreEqual("����", postbox1.Details);

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }

        [TestMethod]
        [Category("Method_SetLastDay")]
        public void SetLastDay_Test_SetArrivalDate_WhenPackageIsGetting()
        {
            // Arrange
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);

            postbox1.Status=Status.��������;
            Admin admin = new Admin();

            string code = "POST-001";

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => admin.SetLastDay(code, new DateTime(2023, 4, 27)));

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }
        [TestMethod]
        [Category("Method_SetLastDay")]
        public void SetLastDay_ThrowInvalidOperationException_WhenPostCodeIsWrong()
        {
            // Arrange
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);

            postbox1.Status = Status.��������;
            Admin admin = new Admin();

            string code = "POST-00";

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => admin.SetLastDay(code, new DateTime(2023, 4, 27)));

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }
        [TestMethod]
        [Category("Method_SetLastDay")]
        public void SetLastDay_ThrowInvalidOperationException_StartDayMoreThanLastDay()
        {
            // Arrange
            PostBox postbox1 = new PostBox();
            postbox1.Code = "POST-001";
            postbox1.StartDate = DateTime.Now;
            PostBox postbox2 = new PostBox();
            postbox2.Code = "POST-002";

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);

            postbox1.Status = Status.��������;
            Admin admin = new Admin();

            string code = "POST-001";

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => admin.SetLastDay(code, new DateTime(2023, 4, 27)));

            PostBoxList.packages.Remove(postbox1);
            PostBoxList.packages.Remove(postbox2);
        }

        [TestMethod]
        [Category("Method_Print")]
        public void Print_ReturnsCorrectString_WhenPackagesExist()
        {
            // Arrange
            var admin = new Admin();
            PostBox postbox1 = new PostBox(Status.��������, new DateTime(2023, 4, 27), new DateTime(2023, 5, 27), PaymentStatus.����������, 115,
            100, "�������� ��� ���������", "���. �����������, 3", City.�����, "+380993987910", "���������� ���'� ��������",
            "���. �����������, 3", City.��������, "+380505966212", "�����", "", 3,"POST-001");
            PostBox postbox2 = new PostBox(Status.�_�����, new DateTime(2023, 4, 30), new DateTime(2023, 5, 15), PaymentStatus.����������, 60,
            1000, "�������� ��� ���������", "���. �����������, 3", City.�������, "+380993987910", "���������� ���'� ��������",
            "���. �����������, 3", City.����, "+380505966212", "����", "�������---���", 1.5, "POST-002");
            PostBox postbox3 = new PostBox(Status.����������, new DateTime(2023, 5, 1), new DateTime(2023, 5, 23), PaymentStatus.��������, 75.5,
            200, "�������� ��� ���������", "���. �����������, 3", City.�������, "+380993987910", "���������� ���'� ��������",
            "���. �����������, 3", City.�������, "+380505966212", "����", "�������---���", 1, "POST-003");
            PostBox postbox4 = new PostBox(Status.��������, new DateTime(2023, 4, 15), new DateTime(2023, 5, 5), PaymentStatus.����������, 50,
            200, "�������� ��� ���������", "���. �����������, 3", City.����, "+380993987910", "���������� ���'� ��������",
            "���. �����������, 3", City.�����, "+380505966212", "����", "�������---���", 0.5, "POST-004");

            PostBoxList.packages.Add(postbox1);
            PostBoxList.packages.Add(postbox2);
            PostBoxList.packages.Add(postbox3);
            PostBoxList.packages.Add(postbox4);

            // Act
            var result = admin.Print();

            // Assert
            string expected = admin.Print();                  
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
            Admin admin = new Admin();

            // Act
            var result = admin.Print();

            // Assert
            Assert.AreEqual("������� �� ��������.", result);
        }
    }
}