using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OOP.Code
{
    public class User: User_Abstract, IPrintable
    {
        private string surname;
        private string name;
        private string secondname;
        private string phone;
        private string adress;
        private string email;
        private string password;
        private int discount;
        private string photo_filepath;
        public string Surname { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Discount { get { return discount; } set { discount = value; } }
        public string PhotoFilePath { get { return photo_filepath; } set { photo_filepath = value; } }

        public static int Counter { get; private set; }

        public User()
        {
        }

        public User(string surname, string name, string secondname, string phone, string address, string email, string password)
        {
            this.Surname = surname;
            this.Name = name;
            this.SecondName = secondname;
            this.Phone = phone;
            this.Adress = address;
            this.Email = email;
            this.Password = password;
            Counter++;
        }
  
        public bool NewPostBox(int appraised_price, string sender, string sender_adress, City sender_town, string sender_phone, string receiver, 
            string receiver_adress, City receiver_town, string receiver_phone, string description, double weight, PostBoxList postboxes)
        {
            if (sender == null || sender_adress == null || sender_town == null || sender_phone == null || receiver == "" || receiver_adress == "" || receiver_town == null || receiver_phone == null || weight == null)
                throw new ArgumentException("Введіть всі обов'язкові поля!");
            string[] sender_lines = sender.Split(' ');
            string[] receiver_lines = receiver.Split(' ');
            if(sender_lines.Length != 3|| receiver_lines.Length!=3)
                throw new Exception("Неправильно вказано ПІБ.");
            if (appraised_price < 100&&appraised_price!=null)
                throw new Exception("Неправильно вказано ціну.");
          //  bool containsPlusOrDigitsSender = Regex.IsMatch(sender_phone, "[+0-9]");
          //  bool containsPlusOrDigitsReceiver = Regex.IsMatch(sender_phone, "[+0-9]");
            if (!sender_phone.Contains("+380") || sender_phone.Length != 13 || sender_phone.Any(c => Char.IsLetter(c))|| !receiver_phone.Contains("+380") || receiver_phone.Length != 13 || receiver_phone.Any(c => Char.IsLetter(c)))
                throw new Exception("Неправильно вказаний номер телефону.");
            if(weight<0.1||weight>1100)
                throw new Exception("Неправильно вказана вага.");

            //створення коду
            string code="";
            if (PostBoxList.packages == null)
                code = "POST-001";
            else if (PostBoxList.packages.Count < 9) 
                code = "POST-00" + (PostBoxList.packages.Count+1);
            else if(PostBoxList.packages.Count >= 9&& PostBoxList.packages.Count<99)
                code = "POST-0" + (PostBoxList.packages.Count + 1);
            else if(PostBoxList.packages.Count>=99)
                code = "POST-" + (PostBoxList.packages.Count + 1);

            decimal p = CalculatePay(sender_town,receiver_town,weight);
            double price=Convert.ToDouble(p);
            PostBox new_post = new PostBox(Status.Створено, DateTime.Now, DateTime.Now.AddDays(5), PaymentStatus.Неоплачено, price,
    appraised_price, sender, sender_adress, sender_town, sender_phone, receiver, receiver_adress, receiver_town,
    receiver_phone, description, " ", weight, code);
            postboxes.Add(new_post);
            return true;
        }
        public void ChangePostBoxInfo(string code, string new_description)
        {
            /* if (code == null)
                 throw new Exception("Введть код посилки!");*/
            // Пошук посилки за кодом
            PostBox post = PostBoxList.packages.FirstOrDefault(p => p.Code == code);
            // Якщо посилку не знайдено, викинути виключення
            if (post == null)
            {
                throw new ArgumentException("Неправильно вказаний код посилки.");
            }
            if (post.Status == Status.Одержано || post.Status == Status.Доставлено|| post.SenderPhone != Phone)
                throw new Exception("Ви не можете змінити опис цієї посилки.");
            post.Description=new_description;
        }
        public void ChangeOwnInfo(string new_surname, string new_name, string new_secondname, string phone, string new_address, string new_email, string password)
        {
            if (phone != "")
            {
                if (!phone.Contains("+380") || phone.Length != 13 || phone.Any(c => Char.IsLetter(c)))
                    throw new Exception("Неправильно вказаний номер телефону.");
            }
            // Пошук користувача за паролем
            User user = UserList.users.FirstOrDefault(u => u.Password == password);
            // Якщо користувача не знайдено, викинути виключення
            if (user == null)
            {
                throw new ArgumentException("Неправильно вказаний пароль.");
            }
            //якщо користувач існує з таким самим паролем та новим телефоном
            User same_user = UserList.users.FirstOrDefault(u => u.Password == password && u.Phone == phone);

            if (same_user != null)
                throw new Exception("Введіть інший номер телефону");
            if (new_surname.Length < 3 && new_surname != "")
                throw new Exception("У прізвищі має бути хоча б 3 букви.");
            if (new_name.Length < 3 && new_name != "")
                throw new Exception("У імені має бути хоча б 3 букви.");
            if (new_secondname.Length < 3 && new_secondname != "")
                throw new Exception("У по батькові має бути хоча б 3 букви.");
            bool containsOnlyUkrainianLetters = true;
            if (!(containsOnlyUkrainianLetters = Regex.IsMatch(new_surname, "^[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ']+$")) && new_surname != "")
                throw new Exception("Прізвище має містити лише українські літери.");
            if (!(containsOnlyUkrainianLetters = Regex.IsMatch(new_name, "^[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ']+$")) && new_name != "")
                throw new Exception("Ім'я має містити лише українські літери.");
            if (!(containsOnlyUkrainianLetters = Regex.IsMatch(new_secondname, "^[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ']+$")) && new_secondname != "")
                throw new Exception("По батькові має містити лише українські літери.");
            if (new_email.Contains("@gmail.com")&&new_email.Length<=13&&new_email!="")
                throw new Exception("Неправильно вказана електронна адреса.");

            if (new_surname != "")
                this.Surname = new_surname;
            if (new_name != "")
                this.Name = new_name;
            if (new_secondname != "")
                this.SecondName = new_secondname;
            if (phone != "")
                this.Phone = phone;
            if (new_address != "")
                this.Adress = new_address;
            if (new_email != "")
                this.Email = new_email;
        }
        public void Pay(string code, string card_number, string mm_yy, string svv, string user_phone)
        {
            if (code == null || card_number == null || mm_yy == null || svv == null)
                throw new Exception("Один з рядків пустий!");
            // Пошук посилки за паролем
            PostBox post = PostBoxList.packages.FirstOrDefault(u => u.Code == code && u.ReceiverPhone == user_phone);
            // Якщо посилку не знайдено, викинути виключення
            if (post == null)
            {
                throw new ArgumentException("Неправильно вказаний код посилки.");
            }
            if (card_number.Length != 12)
                throw new Exception("Неправильний номер картки.");
            if (mm_yy.Length != 5 || !mm_yy.Contains('/'))
                throw new Exception("Неправильно введені рік та місяць.");
            if (svv.Length != 3)
                throw new Exception("Неправильно введений код картки.");
            if (card_number.Any(char.IsLetter) || mm_yy.Any(char.IsLetter) || svv.Any(char.IsLetter))
                throw new Exception("Неправильно введені дані!");
            post.PaymentStatus = PaymentStatus.Оплачено;
        }

        //наслідують клас User_Abstract
        public string CheckPostBox(string code)
        {
            PostBox post_box = PostBoxList.packages.FirstOrDefault(p => p.Code == code);
            // Якщо посилку не знайдено, викинути виключення
            if (post_box == null)
            {
                return "Посилку не знайдено.";
            }

            if (post_box.Status != Status.Одержано)
            {
                return $"Код посилки: {post_box.Code}\nСтатус: {post_box.Status}\nДата відправки: {post_box.StartDate}\n" +
            $"Дата отримання: {post_box.LastDate}\nСтатус оплати: {post_box.PaymentStatus}\nЦіна: {post_box.Price}\nЦіна відшкодування: {post_box.AppraisedPrice}\n" +
            $"Відправник: {post_box.Sender}\nАдреса відправника: {post_box.SenderAdress}\nМісто відправника: {post_box.SenderTown}\nТелефон відправника: {post_box.SenderPhone}\n" +
            $"Одержувач: {post_box.Receiver}\nАдреса одержувача: {post_box.ReceiverAdress}\nМісто одержувача: {post_box.ReceiverTown}\nТелефон одержувача: {post_box.ReceiverPhone}\n" +
            $"Опис: {post_box.Description}\nДеталі: {post_box.Details}\nВага: {post_box.Weight}\n";
            }
           
            return "Посилку не знайдено.";
        }
        public override decimal CalculatePay(City sender_town, City receiver_town, double weight)
        {
            // Перевірка наявності відомостей про міста та вагу посилки
            if (weight < 0.1)
            {
                throw new ArgumentException("Некоректні вхідні дані");
            }
            decimal shippingCost = 1;
            if (weight > 0.1 && weight <= 1)
                shippingCost = 2;
            else if (weight > 1 && weight <= 3)
                shippingCost = 3;
            else if (weight > 3 && weight <= 10)
                shippingCost = 5;
            else if (weight > 10)
                shippingCost = 6;
            else if (weight < 0.1 || weight > 1100)
                throw new Exception("Неправильно вказана вага.");
            decimal distanceRate = Tarriffs.ShippingRates[sender_town][receiver_town];
            decimal sale = 0;
            shippingCost *= distanceRate/2;
            if (Discount != 0)
            {
                sale = shippingCost * Discount / 100;
            }
            return shippingCost - sale;
        }

        //вивід інформації на екран
        public string Print()
        {
            var result_i_sent = PostBoxList.packages
        .Where(package => package.Status != Status.Одержано && package.Status != Status.Доставлено && package.SenderPhone == Phone)
        .Select(package => package.ShowProperties());

            var result_go_to_me = PostBoxList.packages
                .Where(package => package.Status != Status.Одержано && package.Status != Status.Доставлено && package.ReceiverPhone == Phone)
                .Select(package => package.ShowProperties());

            var result_i_sent_delivered = PostBoxList.packages
                .Where(package => package.Status != Status.Одержано && package.Status == Status.Доставлено && package.SenderPhone == Phone)
                .Select(package => package.ShowProperties());

            var result_go_to_me_delivered = PostBoxList.packages
                .Where(package => package.Status != Status.Одержано && package.Status == Status.Доставлено && package.ReceiverPhone == Phone)
                .Select(package => package.ShowProperties());

            if (!result_i_sent.Any() && !result_go_to_me.Any() && !result_i_sent_delivered.Any() && !result_go_to_me_delivered.Any())
                return "Посилок не знайдено.";

            var result = new StringBuilder();
            result.AppendLine("Ви відправили:");
            result.AppendLine(string.Join("\n", result_i_sent));
            result.AppendLine("\nЗ них вже прибули у відділення:");
            result.AppendLine(string.Join("\n", result_i_sent_delivered));
            result.AppendLine("\nДо вас прямують:");
            result.AppendLine(string.Join("\n", result_go_to_me));
            result.AppendLine("\nЗ них вже прибули у відділення:");
            result.AppendLine(string.Join("\n", result_go_to_me_delivered));

            return result.ToString();
        }

        public string ShowFullInfoForAdmin()
        {
            return $"Прізвище: {Surname}; Ім'я: {Name}; По батькові: {SecondName}; Телефон: {Phone}; Адреса: {Adress}; E-mail: {Email}; Доступний промокод: {Discount}; Пароль: {Password}.";
        }
    }
}
