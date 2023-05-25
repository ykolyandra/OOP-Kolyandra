using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OOP.Code
{
    public class Operator: IWorker, IPrintable
    {
        public List<PostBox> Packages { get; set; }

        private string name;
        private string password;

        public string Name { get { return name; } }
        public string Password { get { return password; } }

        public static int Counter { get; private set; }

        public Operator()
        {
        }

        public Operator(string name, string password)
        {
            this.name = name;
            this.password = password;
            Counter++;
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
            if (post.Status == Status.Доставлено && (newStatus == Status.Створено || newStatus == Status.У_дорозі))
            {
                throw new ArgumentException("Посилка вже доставлена.");
            }
            if (post.Status == Status.Одержано && (newStatus == Status.Створено || newStatus == Status.У_дорозі || newStatus == Status.Доставлено))
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
            if (post.PaymentStatus == PaymentStatus.Оплачено)
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
            if (post.Status == Status.Одержано)
                throw new ArgumentException("Посилку вже отримано.");

            post.LastDate = arrivalDate;
        }

        //вивід інформації на екран
        public string Print()
        {
            var delivered_postboxes = PostBoxList.packages
        .Where(package => package.Status == Status.Доставлено)
        .Select(package => package.ShowFullPropertiesForOperator());

            var transit_postboxes = PostBoxList.packages
                .Where(package => package.Status == Status.У_дорозі)
                .Select(package => package.ShowFullPropertiesForOperator());

            var created_postboxes = PostBoxList.packages
                .Where(package => package.Status == Status.Створено)
                .Select(package => package.ShowFullPropertiesForOperator());

            if (!delivered_postboxes.Any() && !transit_postboxes.Any() && !created_postboxes.Any())
                return "Посилок не знайдено.";

            string result = "Створені:\n" + string.Join("\n", created_postboxes) +
                            "\n\nУ дорозі:\n" + string.Join("\n", transit_postboxes) +
                            "\n\nДоставлені:\n" + string.Join("\n", delivered_postboxes);

            return result;
        }
        public string ShowFullInfoForAdmin()
        {
            return $"Оператор: {Name}; Пароль: {Password}.";
        }
    }
}
