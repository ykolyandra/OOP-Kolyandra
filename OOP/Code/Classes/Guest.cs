using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OOP.Code
{
    public class Guest: User_Abstract
    {
        public List<User> user { get; set; }
        public void Registration(string surname, string name, string secondname, string phone, string address, string email, string password, string same_password)
        {
            if (surname == null || name == null || secondname == null || phone == null || address == null || email == null || password == null || same_password == null)
                throw new Exception("При створенні нового користувача не має бути пустих полів!");
            if (surname.Length < 3)
                throw new Exception("У прізвищі має бути хоча б 3 букви.");
            if (name.Length < 3)
                throw new Exception("У імені має бути хоча б 3 букви.");
            if (secondname.Length < 3)
                throw new Exception("У по батькові має бути хоча б 3 букви.");
            bool containsOnlyUkrainianLetters = true;
            if (!(containsOnlyUkrainianLetters = Regex.IsMatch(surname, "^[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ']+$")))
                throw new Exception("Прізвище має містити лише українські літери.");
            if (!(containsOnlyUkrainianLetters = Regex.IsMatch(name, "^[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ']+$")))
                throw new Exception("Ім'я має містити лише українські літери.");
            if (!(containsOnlyUkrainianLetters = Regex.IsMatch(secondname, "^[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ']+$")))
                throw new Exception("По батькові має містити лише українські літери.");
            bool containsPlusOrDigits = Regex.IsMatch(phone, "[+0-9]");
            if (!phone.Contains("+380")||phone.Length!=13||phone.Any(c => Char.IsLetter(c)))
                throw new Exception("Неправильно вказаний номер телефону.");
            if(!email.Contains("@gmail.com"))
                throw new Exception("Неправильно вказана електронна адреса.");
            if(password.Length<8)
                throw new Exception("Пароль має містити хоча б 8 символів.");
            if(password!=same_password)
                throw new Exception("Неправильно вказаний пароль.");

            User user = UserList.users.FirstOrDefault(u => u.Password == password && u.Phone == phone);
            if (user != null)
            {
                throw new ArgumentException("Введіть інший номер телефону.");
            }

            User newUser = new User(surname, name, secondname, phone, address, email, password);
            newUser.PhotoFilePath = @"C:\Users\Админ\Desktop\XAI\2 курс\2 семестр\ООП (КП)\icons\user.png";
            UserList.users.Add(newUser);
            

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
                return post_box.ShowProperties();
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
            shippingCost *= distanceRate / 2;
            return shippingCost;
        }
    }
}
