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

//Форма для вывода баз данных
namespace TourManager
{
    public partial class Form3 : Form
    {
        //Переменная отвечает за работу с базами данных
        TourManagerEntities entities;
        //Переменная отвечает за проверку - с какой базой сейчас работает менеджер
        public string check;

        public Form3()
        {
            InitializeComponent();
            entities = new TourManagerEntities();
            check = "";
        }

        //Метод инициаоизирует базу клиентов в форме (таблице)
        public void InitializeClientBase()
        {
            dataGridView.DataSource = entities.Clients.ToList();
        }

        //Метод инициаоизирует базу стран в форме (таблице)
        public void InitializeCountriesBase()
        {
            dataGridView.DataSource = entities.Countries.ToList();
        }

        //Метод инициаоизирует базу туров в форме (таблице)
        public void InitializeTourBase()
        {
            dataGridView.DataSource = entities.Tours.ToList();
        }

        //Метод инициаоизирует базу доп. услуг в форме (таблице)
        public void InitializeAddServiceBase()
        {
            dataGridView.DataSource = entities.AdditionalServices.ToList();
        }

        //Метод инициаоизирует базу отчетов в форме (таблице)
        public void InitializeRequestsBase()
        {
            dataGridView.DataSource = entities.Requests.ToList();
        }

        //Обработчик события. Кнопка сохранения изменений в БД
        private void buttonSaveDB_Click(object sender, EventArgs e)
        {
            try
            {
                entities.SaveChanges();
                MessageBox.Show("Базу збережено!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Обработчик события. Кнопка выводит базу в Excel файл
        private void buttonDBToExl_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            for (int i = 1; i<=dataGridView.ColumnCount; i++)
            {
                ws.Cells[1, i] = dataGridView.Columns[i-1].Name;
            }

            for (int j = 2; j <= dataGridView.Rows.Count; j++)
            {
                for (int i = 1; i<= dataGridView.ColumnCount; i++)
                {
                    ws.Cells[j, i] = dataGridView.Rows[j - 2].Cells[i - 1].Value;
                }
            }
        }

        //Обработчик события. Кнопка добавляет запись в базу
        private void buttonAddToDB_Click(object sender, EventArgs e)
        {

            try
            {
                if (check == "Клієнти") { entities.Clients.Add(new Clients()); entities.SaveChanges(); InitializeClientBase(); }
                if (check == "Країни") { entities.Countries.Add(new Countries()); entities.SaveChanges(); InitializeCountriesBase(); }
                if (check == "Тури") { entities.Tours.Add(new Tours()); entities.SaveChanges(); InitializeTourBase(); }
                if (check == "Додаткові послуги") { entities.AdditionalServices.Add(new AdditionalServices()); entities.SaveChanges(); InitializeAddServiceBase(); }
                if (check == "Звіти") { MessageBox.Show("Для даної таблиці додавання заборонено!"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
