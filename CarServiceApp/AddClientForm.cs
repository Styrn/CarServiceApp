﻿using CarServiceApp.ServiceDB_DataSetTableAdapters;
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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        //Кнопка "Отмена"
        private void closeBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Кнопка "Добавить"
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

            if (address_TBX.Text.Trim() == "")
            {
                MessageBox.Show("Поле \"Адрес\" имеет неверный формат ввода!", "Ошибка");
                return;
            }

            if (phone_TBX.Text.Length != 11 || phone_TBX.Text.Any(c => char.IsLetter(c)) || !phone_TBX.Text.StartsWith("8"))
            {
                MessageBox.Show("Поле \"Телефон\" имеет неверный формат ввода!", "Ошибка");
                return;
            }

            QueriesTableAdapter addQuery = new QueriesTableAdapter();
            addQuery.AddClient(surname_TBX.Text, name_TBX.Text, patronymic_TBX.Text, address_TBX.Text, phone_TBX.Text);

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
