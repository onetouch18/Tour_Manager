using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Начальная форма
namespace TourManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Обработчик события. Кнопка открывает форму заказа
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Form2 orderForm = new Form2();
            orderForm.Show();
        }

        //Обработчик события. Кнопка открывает форму с базой клиентов
        private void buttonClients_Click(object sender, EventArgs e)
        {
            Form3 clientsForm = new Form3();
            clientsForm.Text = "Клієнти";
            clientsForm.check = clientsForm.Text;
            clientsForm.InitializeClientBase();
            clientsForm.Show();
        }

        //Обработчик события. Кнопка открывает форму с базой Стран
        private void buttonCountries_Click(object sender, EventArgs e)
        {
            Form3 countriesForm = new Form3();
            countriesForm.Text = "Країни";
            countriesForm.check = countriesForm.Text;
            countriesForm.InitializeCountriesBase();
            countriesForm.Show();
        }

        //Обработчик события. Кнопка открывает форму с базой Туров
        private void buttonTours_Click(object sender, EventArgs e)
        {
            Form3 toursForm = new Form3();
            toursForm.Text = "Тури";
            toursForm.check = toursForm.Text;
            toursForm.InitializeTourBase();
            toursForm.Show();
        }

        //Обработчик события. Кнопка открывает форму с базой доп. услуг
        private void buttonAddService_Click(object sender, EventArgs e)
        {
            Form3 addServiceForm = new Form3();
            addServiceForm.Text = "Додаткові послуги";
            addServiceForm.check = addServiceForm.Text;
            addServiceForm.InitializeAddServiceBase();
            addServiceForm.Show();
        }

        //Обработчик события. Кнопка открывает форму с базой отчетов
        private void buttonRequests_Click(object sender, EventArgs e)
        {
            Form3 requestsForm = new Form3();
            requestsForm.Text = "Звіти";
            requestsForm.check = requestsForm.Text;
            requestsForm.InitializeRequestsBase();
            requestsForm.Show();
        }
    }
}
