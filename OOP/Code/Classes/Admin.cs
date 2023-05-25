using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    public class Admin: IWorker, IPrintable
    {
        public void NewOperator(string new_operator_code, string new_operator_password)
        {
            if (new_operator_code == null || new_operator_password == null)
                throw new Exception("Один з рядків не введений");
            else if (!new_operator_code.Contains('#'))
                throw new Exception("Код оператора має містити символ #");
            else if (new_operator_code.Length != 5)
                throw new Exception("Код оператора повинен мати 4 числа");
            else if (new_operator_password.Length < 8&&!new_operator_password.Contains("operator"))
                throw new Exception("Пароль оператора має бути мінімум 8 символів");
            else
            {
                Operator newOperator = new Operator(new_operator_code, new_operator_password);
                OperatorList.operators.Add(newOperator);
            }
        }
        public void NewDiscount(int discount, string password, string phone)
        {
            if (!phone.Contains("+380") || phone.Length != 13 || phone.Any(c => Char.IsLetter(c)))
                throw new Exception("Неправильно вказаний номер телефону.");
            User user = UserList.users.FirstOrDefault(u => u.Password == password && u.Phone == phone);
            if (user == null)
            {
                throw new ArgumentException("Користувача не знайдено.");
            }
            if (discount <= 0 || discount > 50)
                throw new Exception("Знижка має бути не більшою за 50%");
            user.Discount = discount;
        }

        //успадковані від інтерфейсу IWorker
        public void ChangeStatus(string code, Status newStatus)
        {
            // Пошук посилки за кодом
            PostBox post = PostBoxList.packages.FirstOrDefault(p => p.Code == code);
            // Якщо посилку не знайдено, викинути виключення
            if (post == null)
            {
                throw new ArgumentException("Неправильно вказаний код посилки.");
            }
            if (post.Status == Status.Доставлено && (newStatus == Status.Створено||newStatus==Status.У_дорозі))
            {
                throw new ArgumentException("Посилка вже доставлена.");
            }
            if (post.Status == Status.Одержано && (newStatus == Status.Створено || newStatus == Status.У_дорозі||newStatus==Status.Доставлено))
                throw new ArgumentException("Посилку вже отримано.");
            if (post.Status == Status.У_дорозі && newStatus == Status.Створено)
                throw new ArgumentException("Посилка вже у дорозі.");

            if (newStatus == Status.Одержано)
                post.PaymentStatus = PaymentStatus.Оплачено;
            post.Status = newStatus;
        }
        public void ChangePayStatus(string code, PaymentStatus newStatus)
        {
            // Пошук посилки за кодом
            PostBox post = PostBoxList.packages.FirstOrDefault(p => p.Code == code);
            // Якщо посилку не знайдено, викинути виключення
            if (post == null)
            {
                throw new ArgumentException("Неправильно вказаний код посилки.");
            }
            if (post.PaymentStatus==PaymentStatus.Оплачено)
            {
                throw new ArgumentException("Посилка вже оплачена.");
            }
            if (post.Status == Status.Одержано)
                throw new ArgumentException("Посилку вже отримано.");

            post.PaymentStatus = newStatus;
        }
        public void ChangeDetails(string code, string new_location)
        {
            // Пошук посилки за кодом
            PostBox post = PostBoxList.packages.FirstOrDefault(p => p.Code == code);
            // Якщо посилку не знайдено, викинути виключення
            if (post == null)
            {
                throw new ArgumentException("Неправильно вказаний код посилки.");
            }
            if (post.Status == Status.Одержано)
                throw new ArgumentException("Посилку вже отримано.");
            else if (new_location != "")
                post.Details += "---" + new_location;
        }
        public void SetLastDay(string code, DateTime arrivalDate)
        {
            // Пошук посилки за кодом
            PostBox post = PostBoxList.packages.FirstOrDefault(p => p.Code == code);
            // Якщо посилку не знайдено, викинути виключення
            if (post == null)
            {
                throw new ArgumentException("Неправильно вказаний код посилки.");
            }
            if (arrivalDate < post.StartDate)
            {
                throw new ArgumentException("Дата прибуття не може бути раніше за дату відправки.");
            }
            if(post.Status==Status.Одержано)
                throw new ArgumentException("Посилку вже отримано.");

            post.LastDate = arrivalDate;
        }

        //вивід на екран
        public string Print()
        {
            var taken_postboxes = PostBoxList.packages
        .Where(package => package.Status == Status.Одержано)
        .Select(package => package.ShowFullPropertiesForAdmin());

            var delivered_postboxes = PostBoxList.packages
                .Where(package => package.Status == Status.Доставлено)
                .Select(package => package.ShowFullPropertiesForAdmin());

            var transit_postboxes = PostBoxList.packages
                .Where(package => package.Status == Status.У_дорозі)
                .Select(package => package.ShowFullPropertiesForAdmin());

            var created_postboxes = PostBoxList.packages
                .Where(package => package.Status == Status.Створено)
                .Select(package => package.ShowFullPropertiesForAdmin());

            if (!taken_postboxes.Any() && !delivered_postboxes.Any() && !transit_postboxes.Any() && !created_postboxes.Any())
                return "Посилок не знайдено.";

            string result = "Створені:\n" + string.Join("\n", created_postboxes) +
                            "\n\nУ дорозі:\n" + string.Join("\n", transit_postboxes) +
                            "\n\nДоставлені:\n" + string.Join("\n", delivered_postboxes) +
                            "\n\nОдержані:\n" + string.Join("\n", taken_postboxes);

            return result;
        }
        public string ShowUsers()
        {
            var usersInfo = UserList.users.Select(user => user.ShowFullInfoForAdmin());

            if (!usersInfo.Any())
                return "Користувачів не знайдено.";

            string result = string.Join("\n", usersInfo);
            return result;
        }
        public string ShowOperators()
        {
            var operatorsInfo = OperatorList.operators.Select(op => op.ShowFullInfoForAdmin());

            if (!operatorsInfo.Any())
                return "Операторів не знайдено.";

            string result = string.Join("\n", operatorsInfo);
            return result;
        }
    }
}
