using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Code
{
    public class UserList
    {
        public static List<User> users = new List<User>();

        /*public void SaveUserData()
        {
            string filePath = @"C:\Users\Админ\Desktop\XAI\2 курс\2 семестр\ООП (КП)\OOP\users.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (User user in users)
                {
                    string line = $"{user.Surname};{user.Name};{user.SecondName};{user.Phone};{user.Email};{user.Adress};{user.Password};{user.Discount};{user.PhotoFilePath}"; // Формат запису даних про користувача
                    writer.WriteLine(line);
                }
            }

            MessageBox.Show("Дані користувачів збережені!");
        }*/

        /*public void LoadUserData()
        {
            users.Clear(); // Очистити поточий список перед завантаженням даних

            string filePath = @"C:\Users\Админ\Desktop\XAI\2 курс\2 семестр\ООП (КП)\OOP\users.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] fields = line.Split(';');

                        if (fields.Length == 9) // Перевірка на наявність всіх полів
                        {
                            string surname = fields[0];
                            string name = fields[1];
                            string secondname = fields[2];
                            string phone = fields[3];
                            string email = fields[4];
                            string addres = fields[5];
                            string password = fields[6];
                            int discount = Convert.ToInt32(fields[7]);
                            string photoFilePath = fields[8];

                            User user = new User(surname, name, secondname, phone, addres, email, password); // Створення об'єкта User з отриманими даними
                            user.PhotoFilePath = photoFilePath;
                            user.Discount = discount;
                            users.Add(user);
                        }
                    }
                }
            }
        }*/

        public void SaveUserData()
        {
            string filePath = @"C:\Users\Админ\Desktop\XAI\2 курс\2 семестр\ООП (КП)\OOP\users.json";

            string jsonString = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(filePath, jsonString);

            MessageBox.Show("Дані користувачів збережені!");
        }

        public void LoadUserData()
        {
            users.Clear();

            string filePath = @"C:\Users\Админ\Desktop\XAI\2 курс\2 семестр\ООП (КП)\OOP\users.json";

            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);

                users = JsonSerializer.Deserialize<List<User>>(jsonString);
            }
        }
    }
}
