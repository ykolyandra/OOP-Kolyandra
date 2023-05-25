using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Text.Json;

namespace OOP.Code
{
    public class PostBoxList
    {
        public static List<PostBox> packages = new List<PostBox>();

        public void Add(PostBox postbox)
        {
            packages.Add(postbox);
        }

        public int Count()
        {
            return packages.Count;
        }

       /* public void SavePackagesData()
        {
            string filePath = @"C:\Users\Админ\Desktop\XAI\2 курс\2 семестр\ООП (КП)\OOP\packages.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (PostBox package in packages)
                {
                    string line = $"{package.Code};{package.Sender};{package.SenderPhone};{package.SenderTown};{package.SenderAdress};{package.Receiver};{package.ReceiverPhone};{package.ReceiverTown};{package.ReceiverAdress};{package.StartDate};{package.LastDate};{package.PaymentStatus};{package.Status};{package.Price};{package.AppraisedPrice};{package.Description};{package.Details};{package.Weight}"; // Формат запису даних про користувача
                    writer.WriteLine(line);
                }
            }

            MessageBox.Show("Оновлені дані про посилки збережені!");
        }*/

        /*public void LoadPackagesData()
        {
            packages.Clear(); // Очистити поточий список перед завантаженням даних

            string filePath = @"C:\Users\Админ\Desktop\XAI\2 курс\2 семестр\ООП (КП)\OOP\packages.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] fields = line.Split(';');

                        if (fields.Length == 18) // Перевірка на наявність всіх полів
                        {
                            string code = fields[0];
                            string sender_fullname = fields[1];
                            string sender_phone = fields[2];
                            string sender_town_line = fields[3];
                            City sender_town = (City)Enum.Parse(typeof(City), sender_town_line);
                            string sender_adress = fields[4];
                            string receiver_fullname = fields[5];
                            string receiver_phone = fields[6];
                            string receiver_town_line = fields[7];
                            City receiver_town = (City)Enum.Parse(typeof(City), receiver_town_line);
                            string receiver_adress = fields[8];
                            string start_date_line = fields[9];
                            DateTime start_date=DateTime.Parse(start_date_line);
                            string last_date_line = fields[10];
                            DateTime last_date = DateTime.Parse(last_date_line);
                            string payment_status_line = fields[11];
                            PaymentStatus payment_status=(PaymentStatus)Enum.Parse(typeof(PaymentStatus), payment_status_line);
                            string status_line = fields[12];
                            Status status = (Status)Enum.Parse(typeof(Status), status_line);
                            double price = Convert.ToDouble(fields[13]);
                            int appraised_price = Convert.ToInt32(fields[14]);
                            string description = fields[15];
                            string details = fields[16];
                            double weight = Convert.ToDouble(fields[17]);

                            PostBox package= new PostBox(status, start_date, last_date, payment_status, price,
                            appraised_price, sender_fullname, sender_adress, sender_town, sender_phone, receiver_fullname,
                            receiver_adress, receiver_town, receiver_phone, description, details, weight, code); // Створення об'єкта PostBox з отриманими даними
                            packages.Add(package);
                        }
                    }
                }
            }
        }*/

        public void SavePackagesData()
        {
            string filePath = @"C:\Users\Админ\Desktop\XAI\2 курс\2 семестр\ООП (КП)\OOP\packages.json";

            string jsonString = JsonSerializer.Serialize(packages, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(filePath, jsonString);

            MessageBox.Show("Оновлені дані про посилки збережені!");
        }

        public void LoadPackagesData()
        {
            packages.Clear();

            string filePath = @"C:\Users\Админ\Desktop\XAI\2 курс\2 семестр\ООП (КП)\OOP\packages.json";

            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);

                packages = JsonSerializer.Deserialize<List<PostBox>>(jsonString);
            }
        }
    }
}
