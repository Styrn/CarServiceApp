using CarServiceApp.ServiceDB_DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceApp
{
    public partial class EditOrderForm : Form
    {
        private Dictionary<int, string> _cars, _clients, _services, _masters;
        private int _repairId;
        public EditOrderForm(Dictionary<int, string> cars, Dictionary<int, string> clients, Dictionary<int, string> services, Dictionary<int, string> masters, int repairId)
        {
            InitializeComponent();
            _cars = cars;
            _clients = clients;
            _services = services;
            _masters = masters;
            this.Initialize();
            _repairId = repairId;
        }

        //Кнопка "Отменить"
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопка "Применить"
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (cars_CMBX.Text == "")
            {
                MessageBox.Show("Поле \"Автомобиль\" имеет неверный формат ввода!", "Ошибка");
                return;
            }

            if (clients_CMBX.Text == "")
            {
                MessageBox.Show("Поле \"Клиент\" имеет неверный формат ввода!", "Ошибка");
                return;
            }

            if (services_CMBX.Text == "")
            {
                MessageBox.Show("Поле \"Услуга\" имеет неверный формат ввода!", "Ошибка");
                return;
            }

            if (masters_CMBX.Text == "")
            {
                MessageBox.Show("Поле \"Мастер\" имеет неверный формат ввода!", "Ошибка");
                return;
            }

            int carId = -1,
                clientId = -1,
                serviceId = -1,
                masterId = -1;
            foreach (int key in _cars.Keys)
            {
                if (_cars[key] == cars_CMBX.Text)
                {
                    carId = key;
                }
            }

            foreach (int key in _clients.Keys)
            {
                if (_clients[key] == clients_CMBX.Text)
                {
                    clientId = key;
                }
            }

            foreach (int key in _services.Keys)
            {
                if (_services[key] == services_CMBX.Text)
                {
                    serviceId = key;
                }
            }

            foreach (int key in _masters.Keys)
            {
                if (_masters[key] == masters_CMBX.Text)
                {
                    masterId = key;
                }
            }

            try
            { 
                QueriesTableAdapter editQuery = new QueriesTableAdapter();
                editQuery.UpdateRepair(_repairId, carId, clientId, serviceId, masterId, Convert.ToInt32(count_NUD.Value), cost_NUD.Value);

                MessageBox.Show("Запись успешно добавлена!");
                this.Raise_Event();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выполнения запроса! Возможно, вы хотите добавить не существующий автомобиль, клиента, услугу или мастера.\nТекст ошибки:\n" + ex.Message, "Ошибка!");
            }
}

        private void Initialize()
        {
            foreach (string val in _cars.Values)
            {
                cars_CMBX.Items.Add(val);
            }

            foreach (string car in _clients.Values)
            {
                clients_CMBX.Items.Add(car);
            }

            foreach (string car in _services.Values)
            {
                services_CMBX.Items.Add(car);
            }

            foreach (string car in _masters.Values)
            {
                masters_CMBX.Items.Add(car);
            }
        }

        //Ивент для индикации изменения таблицы
        public delegate void DataChangedEvent(object sender, EventArgs e);

        public event DataChangedEvent dataChanged;

        protected virtual void Raise_Event()
        {
            if (dataChanged != null)
            {
                dataChanged(this, EventArgs.Empty);
            }
        }
    }
}
