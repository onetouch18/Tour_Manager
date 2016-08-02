using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

//Форма заказа
namespace TourManager
{
    public partial class Form2 : Form
    {
        //Пременная для работы с базой
        TourManagerEntities entities;
        //Переменные цен
        int price, priceTour, priceAddService;

        public Form2()
        {
            InitializeComponent();
            entities = new TourManagerEntities();
            price = 0;
            priceTour = 0;
            priceAddService = 0;
            InitializeComboClient();
            InitializeComboCountry();
        }

        //Инициализация списка клиентов
        private void InitializeComboClient()
        {
            var listClientsName = entities.Clients.ToList();

            foreach (var item in listClientsName)
            {
                comboClient.Items.Add(item.ПІБ);
            }
        }

        //Инициализация списка стран
        private void InitializeComboCountry()
        {
            var listCountries = entities.Countries.ToList();

            foreach (var item in listCountries)
            {
                comboCountry.Items.Add(item.Назва_країни);
            }
        }

        //Инициализация списка туров
        private void InitializeComboTours()
        {
            comboTour.Items.Clear();
            comboTour.Text = null;
            var listTours = entities.Tours.ToList();

            foreach (var item in listTours)
            {
                if (item.Країна.Equals(comboCountry.Text))
                {
                    comboTour.Items.Add(item.Назва_туру);
                }
            }
        }

        //Инициализация списка доп. услуг
        private void InitializeComboAddServices()
        {
            comboAddServices.Items.Clear();
            comboAddServices.Text = null;
            var listAddServices = entities.AdditionalServices.ToList();

            foreach (var item in listAddServices)
            {
                if (item.Країна.Equals(comboCountry.Text)&& item.Назва_туру.Equals(comboTour.Text))
                {
                    comboAddServices.Items.Add(item.Послуга);
                }
            }
        }

        //Метод изменения цены в зависимости от выбраного тура и доп. услуг
        private void ChangePrice()
        {
            var listTours = entities.Tours.ToList();
            priceTour = 0;
            priceAddService = 0;

            foreach (var item in listTours)
            {
                if (item.Назва_туру.Equals(comboTour.Text))
                {
                    priceTour = (int)item.Ціна;
                }
            }

            var listAddServices = entities.AdditionalServices.ToList();

            foreach (var item in listAddServices)
            {
                if (item.Назва_туру.Equals(comboTour.Text) && item.Послуга.Equals(comboAddServices.Text))
                {
                    priceAddService = (int)item.Ціна;
                }
            }
            price = priceTour + priceAddService;
            labelPrice.Text = price.ToString();
        }

        //Метод добавления отчета в базу ответов
        private void AddRequestToDB()
        {
            try
            {
                entities.Requests.Add(new Requests { ПІБ_Клієнта = comboClient.Text, Країна = comboCountry.Text, Додаткові_послуги = comboAddServices.Text, Ціна = price, Дата_виїзду = dateTimeFrom.Text, Дата_повернення = dateTimeTo.Text, Тур = comboTour.Text });
                entities.SaveChanges();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Метод вывода чека в Excеl
        private void DbToDocument()
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            ws.Cells[1, 1] = "Ім'я клієнта: ";
            ws.Cells[1, 2] = comboClient.Text;

            ws.Cells[3, 1] = "Країна подорожі: ";
            ws.Cells[3, 2] = comboCountry.Text;

            ws.Cells[5, 1] = "Дата виїзду: ";
            ws.Cells[5, 2] = dateTimeFrom.Text;
            ws.Cells[6, 1] = "Дата повернення: ";
            ws.Cells[6, 2] = dateTimeTo.Text;

            ws.Cells[8, 1] = "Тур: ";
            ws.Cells[8, 2] = comboTour.Text;
            ws.Cells[8, 3] = priceTour;

            ws.Cells[10, 1] = "Додат. послуги: ";
            ws.Cells[10, 2] = comboAddServices.Text;
            ws.Cells[10, 3] = priceAddService;

            ws.Cells[12, 2] = "Ціна: ";
            ws.Cells[12, 3] = price;
        }

        //Обработчик события. Следит, если менедженр выбрал страну из списка
        private void comboCountry_TextChanged(object sender, EventArgs e)
        {
            InitializeComboTours();
            InitializeComboAddServices();
        }

        //Обработчик события. Следит, если менедженр выбрал тур из списка
        private void comboTour_TextChanged(object sender, EventArgs e)
        {
            InitializeComboAddServices();
            ChangePrice();
        }

        //Обработчик события. Следит, если менедженр выбрал доп. услугу из списка
        private void comboAddServices_TextChanged(object sender, EventArgs e)
        {
            ChangePrice();
        }

        //Обработчик события. Нажатие клавиши отмена
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Обработчик события. Нажатие клавиши ОК
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            AddRequestToDB();
            DbToDocument();
        }
    }
}
