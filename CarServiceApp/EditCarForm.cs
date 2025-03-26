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
    public partial class EditCarForm : Form
    {
        private int _carId;
        public EditCarForm(int carId, string carBrand, string carModel, string engineType, string registerNum, DateTime releaseDate, decimal mileage)
        {
            InitializeComponent();
            _carId = carId;
            carBrand_TBX.Text = carBrand;
            carModel_TBX.Text = carModel;
            engineType_TBX.Text = engineType;
            registerNumber_TBX.Text = registerNum;
            releaseDate_DTP.Value = releaseDate;
            Mileage_NUD.Value = mileage;
        }

        //Кнопка "Отменить"
        private void closeBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопка "Применить"
        private void acceptBut_Click(object sender, EventArgs e)
        {
            if (carBrand_TBX.Text.Trim() == "")
            {
                MessageBox.Show("Поле \"Бренд\" имеет неверный формат ввода!", "Ошибка");
                return;
            }
            if (carModel_TBX.Text.Trim() == "")
            {
                MessageBox.Show("Поле \"Модель\" имеет неверный формат ввода!", "Ошибка");
                return;
            }
            if (engineType_TBX.Text.Trim() == "")
            {
                MessageBox.Show("Поле \"Тип двигателя\" имеет неверный формат ввода!", "Ошибка");
                return;
            }
            if (registerNumber_TBX.Text.Trim() == "")
            {
                MessageBox.Show("Поле \"Регистрационный номер\" имеет неверный формат ввода!", "Ошибка");
                return;
            }

            QueriesTableAdapter editQuery = new QueriesTableAdapter();
            editQuery.UpdateCar(_carId, carBrand_TBX.Text, carModel_TBX.Text, engineType_TBX.Text, registerNumber_TBX.Text, releaseDate_DTP.Value, Convert.ToInt32(Mileage_NUD.Value));

            MessageBox.Show("Запись успешно добавлена!");
            this.Raise_Event();
            this.Close();
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
