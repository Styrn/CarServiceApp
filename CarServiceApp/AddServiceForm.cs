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
    public partial class AddServiceForm : Form
    {
        public AddServiceForm()
        {
            InitializeComponent();
        }

        //Кнопка "Отмена"
        private void closeBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопка "Добавить"
        private void acceptBut_Click(object sender, EventArgs e)
        {
            if (workType_TBX.Text.Trim() == "")
            {
                MessageBox.Show("Поле \"Вид работы\" имеет неверный формат ввода!", "Ошибка");
                return;
            }

            QueriesTableAdapter addQuery = new QueriesTableAdapter();
            addQuery.AddService(workType_TBX.Text.Trim(), cost_NUD.Value, Convert.ToInt32(warranty_NUD.Value));

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
