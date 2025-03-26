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
    public partial class EditMasterForm : Form
    {
        private int _masterId;
        public EditMasterForm(int masterId, string masterName, string masterSurname, string masterPatronymic, string masterPosition, decimal masterExperience)
        {
            InitializeComponent();
            _masterId = masterId;

            name_TBX.Text = masterName;
            surname_TBX.Text = masterSurname;
            patronymic_TBX.Text = masterPatronymic;
            position_TBX.Text = masterPosition;
            experience_NUD.Value = masterExperience;
        }

        //Кнопка "Отмена"
        private void closeBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопка "Применить"
        private void acceptBut_Click(object sender, EventArgs e)
        {
            if (surname_TBX.Text.Trim() == "" || surname_TBX.Text.Any<char>(c => char.IsDigit(c)))
            {
                MessageBox.Show("Поле \"Фамилия\" имеет неверный формат ввода!", "Ошибка");
                return;
            }

            if (name_TBX.Text.Trim() == "" || name_TBX.Text.Any<char>(c => char.IsDigit(c)))
            {
                MessageBox.Show("Поле \"Имя\" имеет неверный формат ввода!", "Ошибка");
                return;
            }

            if (position_TBX.Text.Trim() == "" || position_TBX.Text.Any<char>(c => char.IsDigit(c)))
            {
                MessageBox.Show("Поле \"Должность\" имеет неверный формат ввода!", "Ошибка");
                return;
            }

            QueriesTableAdapter editQuery = new QueriesTableAdapter();
            string fullName = surname_TBX.Text + " " + name_TBX.Text + " " + patronymic_TBX.Text;
            editQuery.UpdateMaster(_masterId, fullName, position_TBX.Text, Convert.ToInt32(experience_NUD.Value));

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
