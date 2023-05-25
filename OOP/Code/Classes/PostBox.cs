using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    public class PostBox
    {
        private Status status;
        private DateTime start_date;
        private DateTime last_date;
        private PaymentStatus payment_status;
        private double price;
        private int appraised_price;
        private string sender;
        private string sender_adress;
        private City sender_town;
        private string sender_phone;
        private string receiver;
        private string receiver_adress;
        private City receiver_town;
        private string receiver_phone;
        private string description;
        private string details;
        private string code;
        public string Code{get { return code; } set { code = value; } }
        private double weight;
        public double Weight{get { return weight; } set { weight = value; } }

        public Status Status{get { return status; } set { status = value; } }
        public DateTime StartDate { get { return start_date; } set { start_date = value; } }
        public DateTime LastDate { get { return last_date; } set { last_date = value; } }
        public PaymentStatus PaymentStatus{get { return payment_status; } set { payment_status = value; } }
        public double Price{get { return price; } set { price = value; } }
        public int AppraisedPrice { get { return appraised_price; } set { appraised_price = value; } }
        public string Sender { get { return sender; } set { sender = value; } }
        public string SenderAdress { get { return sender_adress; } set { sender_adress = value; } }
        public City SenderTown { get { return sender_town; } set { sender_town = value; } }
        public string SenderPhone { get { return sender_phone; } set { sender_phone = value; } }
        public string Receiver { get { return receiver; } set { receiver = value; } }
        public string ReceiverAdress { get { return receiver_adress; } set { receiver_adress = value; } }
        public City ReceiverTown { get { return receiver_town; } set { receiver_town = value; } }
        public string ReceiverPhone { get { return receiver_phone; } set { receiver_phone = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Details { get { return details; } set { details = value; } }

        public static int Counter { get; private set; }

        public PostBox()
        {
        }

        public PostBox(Status status, DateTime start_date,DateTime last_date,PaymentStatus payment_status,double price,
            int appraised_price,string sender,string sender_adress,City sender_town,string sender_phone,string receiver,
            string receiver_adress,City receiver_town,string receiver_phone,string description, string details, double weight,
            string code)
        {
            this.Status = status;
            this.StartDate = start_date;
            this.LastDate = last_date;
            this.PaymentStatus = payment_status;
            this.Price = price;
            this.AppraisedPrice = appraised_price;
            this.Sender = sender;
            this.SenderAdress = sender_adress;
            this.Receiver = receiver;
            this.ReceiverAdress = receiver_adress;
            this.SenderTown = sender_town;
            this.ReceiverTown = receiver_town;
            this.SenderPhone = sender_phone;
            this.ReceiverPhone = receiver_phone;
            this.Description = description;
            this.Details = details;
            this.Weight = weight;
            this.Code = code;
            Counter++;
        }

        //вивід інформації на екран
        public string ShowProperties()
        {
            return $"Посилка {Code}; Статус: {Status}; Ціна: {Price}; Статус оплати: {PaymentStatus}; Опис посилки: {Description}; Маршрут: {Details}.";
        }
        public string ShowFullPropertiesForAdmin()
        {
            return $"Посилка {Code}; Статус: {Status}; Ціна: {Price}; Статус оплати: {PaymentStatus}; Відправник: {Sender}; Місто та адреса відправки: м. {SenderTown}, {SenderAdress}; Номер телефону відправника: {SenderPhone}; Отримувач: {Receiver}; Місто та адреса отримувача: {ReceiverTown+ReceiverAdress}; Номер телефону отримувача: {ReceiverPhone}; Опис посилки: {Description}; Маршрут: {Details}; Дата створення:{StartDate}; Дата доставки:{LastDate}.";
        }
        public string ShowFullPropertiesForOperator()
        {
            return $"Посилка {Code}; Статус: {Status}; Ціна: {Price}; Статус оплати: {PaymentStatus}; Відправник: {Sender}; Місто відправки: {SenderTown}; Отримувач: {Receiver}; Місто отримувача: {ReceiverTown}; Опис посилки: {Description}; Маршрут: {Details}.";
        }


    }
}
