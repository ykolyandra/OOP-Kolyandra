using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace OOP.Code
{
    public class OperatorList
    {
        public static List<Operator> operators = new List<Operator>();

        public int Count()
        {
            return operators.Count;
        }

        public void SaveOperatorData()
        {
            string filePath = @"C:\Users\Админ\Desktop\XAI\2 курс\2 семестр\ООП (КП)\OOP\operators.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Operator current_operator in operators)
                {
                    string line = $"{current_operator.Name};{current_operator.Password}";
                    writer.WriteLine(line);
                }
            }

            MessageBox.Show("Дані операторів збережені!");
        }

        public void LoadOperatorData()
        {
            operators.Clear(); // Очистити поточий список перед завантаженням даних

            string filePath = @"C:\Users\Админ\Desktop\XAI\2 курс\2 семестр\ООП (КП)\OOP\operators.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] fields = line.Split(';');

                        if (fields.Length == 2) // Перевірка на наявність всіх полів
                        {
                            string name = fields[0];
                            string password = fields[1];

                            Operator user_operator = new Operator(name, password);
                            operators.Add(user_operator);
                        }
                    }
                }
            }
        }

       /* public void SaveOperatorData()
        {
            string filePath = @"C:\Users\Админ\Desktop\XAI\2 курс\2 семестр\ООП (КП)\OOP\operators.json";

            string jsonString = JsonSerializer.Serialize(operators);

            File.WriteAllText(filePath, jsonString);

            MessageBox.Show("Дані операторів збережені!");
        }
       */
       /* public void LoadOperatorData()
        {
            operators.Clear(); // Очистити поточний список перед завантаженням даних

            string filePath = @"C:\Users\Админ\Desktop\XAI\2 курс\2 семестр\ООП (КП)\OOP\operators.json";

            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                jsonString = jsonString.Replace("#", @"\#");

                operators = JsonSerializer.Deserialize<List<Operator>>(jsonString);
            }
        }*/
    }
}

