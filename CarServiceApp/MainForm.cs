using CarServiceApp.ServiceDB_DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDB_DataSet.vw_MastersInfo". При необходимости она может быть перемещена или удалена.
            this.vw_MastersInfoTableAdapter.Fill(this.serviceDB_DataSet.vw_MastersInfo);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDB_DataSet.vw_ServicesInfo". При необходимости она может быть перемещена или удалена.
            this.vw_ServicesInfoTableAdapter.Fill(this.serviceDB_DataSet.vw_ServicesInfo);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDB_DataSet.vw_ClientsInfo". При необходимости она может быть перемещена или удалена.
            this.vw_ClientsInfoTableAdapter.Fill(this.serviceDB_DataSet.vw_ClientsInfo);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDB_DataSet.vw_CarsInfo". При необходимости она может быть перемещена или удалена.
            this.vw_CarsInfoTableAdapter.Fill(this.serviceDB_DataSet.vw_CarsInfo);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDB_DataSet.vw_RepairsInfo". При необходимости она может быть перемещена или удалена.
            this.vw_RepairsInfoTableAdapter.Fill(this.serviceDB_DataSet.vw_RepairsInfo);
        }


        //Кнопки и функционал раздела "Текущие заказы"
        //Обновить
        private void ordersUpdateBut_Click(object sender, EventArgs e)
        {
            LoadOrdersData();
        }

        //Добавить
        private void ordersAddBut_Click(object sender, EventArgs e)
        {
            //Сбор данных от других таблиц
            Dictionary<int, string> cars = new Dictionary<int, string>();
            Dictionary<int, string> clients = new Dictionary<int, string>();
            Dictionary<int, string> services = new Dictionary<int, string>();
            Dictionary<int, string> masters = new Dictionary<int, string>();

            for (int i = 0; i < carsGridView.Rows.Count - 1; i++)
            {
                Debug.WriteLine(i);
                cars.Add(Convert.ToInt32(carsGridView.Rows[i].Cells[0].Value), carsGridView.Rows[i].Cells[1].Value.ToString() + " " + carsGridView.Rows[i].Cells[2].Value.ToString() + " " + carsGridView.Rows[i].Cells[4].Value.ToString());
            }

            for (int i = 0; i < clientsGridView.Rows.Count - 1; i++)
            {
                clients.Add(Convert.ToInt32(clientsGridView.Rows[i].Cells[0].Value), clientsGridView.Rows[i].Cells[1].Value.ToString() + " " + clientsGridView.Rows[i].Cells[2].Value.ToString() + " " + clientsGridView.Rows[i].Cells[3].Value.ToString() + " " + clientsGridView.Rows[i].Cells[5].Value.ToString());
            }

            for (int i = 0; i < servicesGridView.Rows.Count - 1; i++)
            {
                services.Add(Convert.ToInt32(servicesGridView.Rows[i].Cells[0].Value), servicesGridView.Rows[i].Cells[1].Value.ToString());
            }

            for (int i = 0; i < mastersGridView.Rows.Count - 1; i++)
            {
                masters.Add(Convert.ToInt32(mastersGridView.Rows[i].Cells[0].Value), mastersGridView.Rows[i].Cells[1].Value.ToString() + " " + mastersGridView.Rows[i].Cells[2].Value.ToString());
            }

            //Создание формы
            AddOrderForm form = new AddOrderForm(cars, clients, services, masters);
            form.dataChanged += (s, ev) =>
            {
                this.LoadOrdersData();
            };
            form.Show();
        }

        //Изменить
        private void ordersEditBut_Click(object sender, EventArgs e)
        {
            if (ordersGridView.SelectedRows.Count == 1)
            {   //Сбор данных от других таблиц
                Dictionary<int, string> cars = new Dictionary<int, string>();
                Dictionary<int, string> clients = new Dictionary<int, string>();
                Dictionary<int, string> services = new Dictionary<int, string>();
                Dictionary<int, string> masters = new Dictionary<int, string>();

                for (int i = 0; i < carsGridView.Rows.Count - 1; i++)
                {
                    Debug.WriteLine(i);
                    cars.Add(Convert.ToInt32(carsGridView.Rows[i].Cells[0].Value), carsGridView.Rows[i].Cells[1].Value.ToString() + " " + carsGridView.Rows[i].Cells[2].Value.ToString() + " " + carsGridView.Rows[i].Cells[4].Value.ToString());
                }

                for (int i = 0; i < clientsGridView.Rows.Count - 1; i++)
                {
                    clients.Add(Convert.ToInt32(clientsGridView.Rows[i].Cells[0].Value), clientsGridView.Rows[i].Cells[1].Value.ToString() + " " + clientsGridView.Rows[i].Cells[2].Value.ToString() + " " + clientsGridView.Rows[i].Cells[3].Value.ToString() + " " + clientsGridView.Rows[i].Cells[5].Value.ToString());
                }

                for (int i = 0; i < servicesGridView.Rows.Count - 1; i++)
                {
                    services.Add(Convert.ToInt32(servicesGridView.Rows[i].Cells[0].Value), servicesGridView.Rows[i].Cells[1].Value.ToString());
                }

                for (int i = 0; i < mastersGridView.Rows.Count - 1; i++)
                {
                    masters.Add(Convert.ToInt32(mastersGridView.Rows[i].Cells[0].Value), mastersGridView.Rows[i].Cells[1].Value.ToString() + " " + mastersGridView.Rows[i].Cells[2].Value.ToString());
                }

                //Создание формы
                EditOrderForm form = new EditOrderForm(cars, clients, services, masters, Convert.ToInt32(ordersGridView.SelectedRows[0].Cells[0].Value));
                form.dataChanged += (s, ev) =>
                {
                    this.LoadOrdersData();
                };
                form.Show();
            }
            else if (ordersGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одну запись!");
            }
            else
            {
                MessageBox.Show("Выберите запись!");
            }
        }

        //Удалить
        private void ordersDeleteBut_Click(object sender, EventArgs e)
        {
            if (ordersGridView.SelectedRows.Count == 1)
            {
                QueriesTableAdapter deleteQuery = new QueriesTableAdapter();
                int Selected_Numb = Convert.ToInt32(ordersGridView.SelectedRows[0].Cells[0].Value);
                deleteQuery.DeleteCar(Selected_Numb);
                MessageBox.Show("Запись успешно удалена!");
                LoadOrdersData();
            }
            else if (ordersGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одну запись!");
            }
            else
            {
                MessageBox.Show("Выберите запись!");
            }
        }

        //Выгрузка данных из VIEW
        private void LoadOrdersData()
        {
            ServiceDB_DataSet.vw_RepairsInfoDataTable dt = new ServiceDB_DataSet.vw_RepairsInfoDataTable();
            this.vw_RepairsInfoTableAdapter.Fill(dt);
            this.ordersGridView.DataSource = dt;
        }


        //Кнопки и функционал раздела "Машины"
        //Обновить
        private void carsUpdateBut_Click(object sender, EventArgs e)
        {
            LoadCarsData();
        }

        //Добавить
        private void carsAddBut_Click(object sender, EventArgs e)
        {
            AddCarForm form = new AddCarForm();
            form.dataChanged += (s, ev) =>
            {
                this.LoadCarsData();
            };
            form.Show();
        }

        //Изменить
        private void carsEditBut_Click(object sender, EventArgs e)
        {
            if (carsGridView.SelectedRows.Count == 1)
            {
                int car_id = Convert.ToInt32(carsGridView.SelectedRows[0].Cells[0].Value);
                string brand = carsGridView.SelectedRows[0].Cells[1].Value.ToString();
                string model = carsGridView.SelectedRows[0].Cells[2].Value.ToString();
                string engineType = carsGridView.SelectedRows[0].Cells[3].Value.ToString();
                string registrationNumber = carsGridView.SelectedRows[0].Cells[4].Value.ToString();
                DateTime releaseDate = Convert.ToDateTime(carsGridView.SelectedRows[0].Cells[5].Value);
                decimal mileage = Convert.ToDecimal(carsGridView.SelectedRows[0].Cells[6].Value);
                EditCarForm form = new EditCarForm(car_id, brand, model, engineType, registrationNumber, releaseDate, mileage);
                form.dataChanged += (s, ev) =>
                {
                    this.LoadClientsData();
                };
                form.Show();
            }
            else if (carsGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одну запись!");
            }
            else
            {
                MessageBox.Show("Выберите запись!");
            }
        }

        //Удалить
        private void carsDeleteBut_Click(object sender, EventArgs e)
        {
            if (carsGridView.SelectedRows.Count == 1)
            {
                QueriesTableAdapter deleteQuery = new QueriesTableAdapter();
                int Selected_Numb = Convert.ToInt32(carsGridView.SelectedRows[0].Cells[0].Value);
                deleteQuery.DeleteCar(Selected_Numb);
                MessageBox.Show("Запись успешно удалена!");
                LoadCarsData();
            }
            else if (carsGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одну запись!");
            }
            else if (carsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись!");
            }
            else
            {
                MessageBox.Show("Ошибка удаление записи!");
            }
        }

        //Выгрузка данных из VIEW
        private void LoadCarsData()
        {
            ServiceDB_DataSet.vw_CarsInfoDataTable dt = new ServiceDB_DataSet.vw_CarsInfoDataTable();
            this.vw_CarsInfoTableAdapter.Fill(dt);
            this.carsGridView.DataSource = dt;
        }


        //Кнопки и функционал раздела "Клиенты"
        //Обновить
        private void clientsUpdateBut_Click(object sender, EventArgs e)
        {
            LoadClientsData();
        }

        //Добавить
        private void clientsAddBut_Click(object sender, EventArgs e)
        {
            AddClientForm form = new AddClientForm();
            form.dataChanged += (s, ev) =>
            {
                this.LoadClientsData();
            };
            form.Show();
        }

        //Изменить
        private void clientsEditBut_Click(object sender, EventArgs e)
        {
            if (clientsGridView.SelectedRows.Count == 1)
            {
                int client_id = Convert.ToInt32(clientsGridView.SelectedRows[0].Cells[0].Value);
                string name = clientsGridView.SelectedRows[0].Cells[1].Value.ToString();
                string surname = clientsGridView.SelectedRows[0].Cells[2].Value.ToString();
                string patronymic = clientsGridView.SelectedRows[0].Cells[3].Value.ToString();
                string address = clientsGridView.SelectedRows[0].Cells[4].Value.ToString();
                string phone = clientsGridView.SelectedRows[0].Cells[5].Value.ToString();
                EditClientForm form = new EditClientForm(client_id, name, surname, patronymic, address, phone);
                form.dataChanged += (s, ev) =>
                {
                    this.LoadClientsData();
                };
                form.Show();
            }
            else if (clientsGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одну запись!");
            }
            else
            {
                MessageBox.Show("Выберите запись!");
            }
        }

        //Удалить
        private void clientsDeleteBut_Click(object sender, EventArgs e)
        {
            if (clientsGridView.SelectedRows.Count == 1)
            {
                QueriesTableAdapter deleteQuery = new QueriesTableAdapter();
                int Selected_Numb = Convert.ToInt32(clientsGridView.SelectedRows[0].Cells[0].Value);
                deleteQuery.DeleteClient(Selected_Numb);
                MessageBox.Show("Запись успешно удалена!");
                LoadClientsData();
            }
            else if (clientsGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одну запись!");
            }
            else
            {
                MessageBox.Show("Выберите запись!");
            }
        }

        //Выгрузка данных из VIEW
        private void LoadClientsData()
        {
            ServiceDB_DataSet.vw_ClientsInfoDataTable dt = new ServiceDB_DataSet.vw_ClientsInfoDataTable();
            this.vw_ClientsInfoTableAdapter.Fill(dt);
            this.clientsGridView.DataSource = dt;
        }


        //Кнопки и функционал раздела "Услуги"
        //Обновить
        private void servicesUpdateBut_Click(object sender, EventArgs e)
        {
            LoadServicesData();
        }

        //Добавить
        private void servicesAddBut_Click(object sender, EventArgs e)
        {
            AddServiceForm form = new AddServiceForm();
            form.dataChanged += (s, ev) =>
            {
                this.LoadServicesData();
            };
            form.Show();
        }

        //Изменить
        private void servicesEditBut_Click(object sender, EventArgs e)
        {
            if (servicesGridView.SelectedRows.Count == 1)
            {
                int service_id = Convert.ToInt32(servicesGridView.SelectedRows[0].Cells[0].Value);
                string workType = servicesGridView.SelectedRows[0].Cells[1].Value.ToString();
                decimal cost = Convert.ToDecimal(servicesGridView.SelectedRows[0].Cells[2].Value);
                decimal warranty = Convert.ToDecimal(servicesGridView.SelectedRows[0].Cells[3].Value);
                EditServiceForm form = new EditServiceForm(service_id, workType, cost, warranty);
                form.dataChanged += (s, ev) =>
                {
                    this.LoadServicesData();
                };
                form.Show();
            }
            else if (servicesGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одну запись!");
            }
            else
            {
                MessageBox.Show("Выберите запись!");
            }
        }

        //Удалить
        private void servicesDeleteBut_Click(object sender, EventArgs e)
        {
            if (servicesGridView.SelectedRows.Count == 1)
            {
                QueriesTableAdapter deleteQuery = new QueriesTableAdapter();
                int Selected_Numb = Convert.ToInt32(servicesGridView.SelectedRows[0].Cells[0].Value);
                deleteQuery.DeleteService(Selected_Numb);
                MessageBox.Show("Запись успешно удалена!");
                LoadServicesData();
            }
            else if (servicesGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одну запись!");
            }
            else if (servicesGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись!");
            }
        }

        //Выгрузка данных из VIEW
        private void LoadServicesData()
        {
            ServiceDB_DataSet.vw_ServicesInfoDataTable dt = new ServiceDB_DataSet.vw_ServicesInfoDataTable();
            this.vw_ServicesInfoTableAdapter.Fill(dt);
            this.servicesGridView.DataSource = dt;
        }


        //Кнопки и функционал раздела "Мастера"
        //Обновить
        private void mastersUpdateBut_Click(object sender, EventArgs e)
        {
            LoadMastersData();
        }

        //Добавить
        private void mastersAddBut_Click(object sender, EventArgs e)
        {
            AddMasterForm form = new AddMasterForm();
            form.dataChanged += (s, ev) =>
            {
                this.LoadMastersData();
            };
            form.Show();
        }

        //Изменить
        private void mastersEditBut_Click(object sender, EventArgs e)
        {
            if (mastersGridView.SelectedRows.Count == 1)
            {
                int master_id = Convert.ToInt32(mastersGridView.SelectedRows[0].Cells[0].Value);
                string[] fullName = mastersGridView.SelectedRows[0].Cells[1].Value.ToString().Split(' ');
                string name = fullName[1];
                string surname = fullName[0];
                string patronymic = fullName[2];
                string position = mastersGridView.SelectedRows[0].Cells[2].Value.ToString();
                decimal experience = Convert.ToDecimal(mastersGridView.SelectedRows[0].Cells[3].Value);
                EditMasterForm form = new EditMasterForm(master_id, name, surname, patronymic, position, experience);
                form.dataChanged += (s, ev) =>
                {
                    this.LoadMastersData();
                };
                form.Show();
                }
            else if (mastersGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одну запись!");
            }
            else
            {
                MessageBox.Show("Выберите запись!");
            }
        }

        //Удалить
        private void mastersDeleteBut_Click(object sender, EventArgs e)
        {
            if (mastersGridView.SelectedRows.Count == 1)
            {
                QueriesTableAdapter deleteQuery = new QueriesTableAdapter();
                int Selected_Numb = Convert.ToInt32(mastersGridView.SelectedRows[0].Cells[0].Value);
                deleteQuery.DeleteMaster(Selected_Numb);
                MessageBox.Show("Запись успешно удалена!");
                LoadMastersData();
            }
            else if (mastersGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одну запись!");
            }
            else
            {
                MessageBox.Show("Выберите запись!");
            }
        }

        //Выгрузка данных из VIEW
        private void LoadMastersData()
        {
            ServiceDB_DataSet.vw_MastersInfoDataTable dt = new ServiceDB_DataSet.vw_MastersInfoDataTable();
            this.vw_MastersInfoTableAdapter.Fill(dt);
            this.mastersGridView.DataSource = dt;
        }
    }
}
