namespace CarServiceApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ordersPage = new System.Windows.Forms.TabPage();
            this.ordersDeleteBut = new System.Windows.Forms.Button();
            this.ordersEditBut = new System.Windows.Forms.Button();
            this.ordersAddBut = new System.Windows.Forms.Button();
            this.ordersUpdateBut = new System.Windows.Forms.Button();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.repairIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsReplacedCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwRepairsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceDB_DataSet = new CarServiceApp.ServiceDB_DataSet();
            this.carsPage = new System.Windows.Forms.TabPage();
            this.carsDeleteBut = new System.Windows.Forms.Button();
            this.carsEditBut = new System.Windows.Forms.Button();
            this.carsAddBut = new System.Windows.Forms.Button();
            this.carsUpdateBut = new System.Windows.Forms.Button();
            this.carsGridView = new System.Windows.Forms.DataGridView();
            this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwCarsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsPage = new System.Windows.Forms.TabPage();
            this.clientsDeleteBut = new System.Windows.Forms.Button();
            this.clientsEditBut = new System.Windows.Forms.Button();
            this.clientsAddBut = new System.Windows.Forms.Button();
            this.clientsUpdateBut = new System.Windows.Forms.Button();
            this.clientsGridView = new System.Windows.Forms.DataGridView();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwClientsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesPage = new System.Windows.Forms.TabPage();
            this.servicesDeleteBut = new System.Windows.Forms.Button();
            this.servicesEditBut = new System.Windows.Forms.Button();
            this.servicesAddBut = new System.Windows.Forms.Button();
            this.servicesUpdateBut = new System.Windows.Forms.Button();
            this.servicesGridView = new System.Windows.Forms.DataGridView();
            this.serviceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warrantyPeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwServicesInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mastersPage = new System.Windows.Forms.TabPage();
            this.mastersDeleteBut = new System.Windows.Forms.Button();
            this.mastersEditBut = new System.Windows.Forms.Button();
            this.mastersAddBut = new System.Windows.Forms.Button();
            this.mastersUpdateBut = new System.Windows.Forms.Button();
            this.mastersGridView = new System.Windows.Forms.DataGridView();
            this.masterIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceYearsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwMastersInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_RepairsInfoTableAdapter = new CarServiceApp.ServiceDB_DataSetTableAdapters.vw_RepairsInfoTableAdapter();
            this.vw_CarsInfoTableAdapter = new CarServiceApp.ServiceDB_DataSetTableAdapters.vw_CarsInfoTableAdapter();
            this.vw_ClientsInfoTableAdapter = new CarServiceApp.ServiceDB_DataSetTableAdapters.vw_ClientsInfoTableAdapter();
            this.vw_ServicesInfoTableAdapter = new CarServiceApp.ServiceDB_DataSetTableAdapters.vw_ServicesInfoTableAdapter();
            this.vw_MastersInfoTableAdapter = new CarServiceApp.ServiceDB_DataSetTableAdapters.vw_MastersInfoTableAdapter();
            this.tabControl.SuspendLayout();
            this.ordersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRepairsInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDB_DataSet)).BeginInit();
            this.carsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCarsInfoBindingSource)).BeginInit();
            this.clientsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwClientsInfoBindingSource)).BeginInit();
            this.servicesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwServicesInfoBindingSource)).BeginInit();
            this.mastersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mastersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMastersInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.ordersPage);
            this.tabControl.Controls.Add(this.carsPage);
            this.tabControl.Controls.Add(this.clientsPage);
            this.tabControl.Controls.Add(this.servicesPage);
            this.tabControl.Controls.Add(this.mastersPage);
            this.tabControl.Location = new System.Drawing.Point(2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(796, 444);
            this.tabControl.TabIndex = 0;
            // 
            // ordersPage
            // 
            this.ordersPage.Controls.Add(this.ordersDeleteBut);
            this.ordersPage.Controls.Add(this.ordersEditBut);
            this.ordersPage.Controls.Add(this.ordersAddBut);
            this.ordersPage.Controls.Add(this.ordersUpdateBut);
            this.ordersPage.Controls.Add(this.ordersGridView);
            this.ordersPage.Location = new System.Drawing.Point(4, 25);
            this.ordersPage.Name = "ordersPage";
            this.ordersPage.Padding = new System.Windows.Forms.Padding(3);
            this.ordersPage.Size = new System.Drawing.Size(788, 415);
            this.ordersPage.TabIndex = 0;
            this.ordersPage.Text = "Текущие заказы";
            this.ordersPage.UseVisualStyleBackColor = true;
            // 
            // ordersDeleteBut
            // 
            this.ordersDeleteBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ordersDeleteBut.BackColor = System.Drawing.Color.LightCoral;
            this.ordersDeleteBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersDeleteBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersDeleteBut.Location = new System.Drawing.Point(591, 382);
            this.ordersDeleteBut.Name = "ordersDeleteBut";
            this.ordersDeleteBut.Size = new System.Drawing.Size(189, 30);
            this.ordersDeleteBut.TabIndex = 1;
            this.ordersDeleteBut.Text = "Удалить";
            this.ordersDeleteBut.UseVisualStyleBackColor = false;
            this.ordersDeleteBut.Click += new System.EventHandler(this.ordersDeleteBut_Click);
            // 
            // ordersEditBut
            // 
            this.ordersEditBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ordersEditBut.BackColor = System.Drawing.Color.Gold;
            this.ordersEditBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersEditBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersEditBut.Location = new System.Drawing.Point(396, 382);
            this.ordersEditBut.Name = "ordersEditBut";
            this.ordersEditBut.Size = new System.Drawing.Size(189, 30);
            this.ordersEditBut.TabIndex = 1;
            this.ordersEditBut.Text = "Изменить";
            this.ordersEditBut.UseVisualStyleBackColor = false;
            this.ordersEditBut.Click += new System.EventHandler(this.ordersEditBut_Click);
            // 
            // ordersAddBut
            // 
            this.ordersAddBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ordersAddBut.BackColor = System.Drawing.Color.SpringGreen;
            this.ordersAddBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersAddBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersAddBut.Location = new System.Drawing.Point(201, 382);
            this.ordersAddBut.Name = "ordersAddBut";
            this.ordersAddBut.Size = new System.Drawing.Size(189, 30);
            this.ordersAddBut.TabIndex = 1;
            this.ordersAddBut.Text = "Добавить";
            this.ordersAddBut.UseVisualStyleBackColor = false;
            this.ordersAddBut.Click += new System.EventHandler(this.ordersAddBut_Click);
            // 
            // ordersUpdateBut
            // 
            this.ordersUpdateBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ordersUpdateBut.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ordersUpdateBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersUpdateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersUpdateBut.Location = new System.Drawing.Point(6, 382);
            this.ordersUpdateBut.Name = "ordersUpdateBut";
            this.ordersUpdateBut.Size = new System.Drawing.Size(189, 30);
            this.ordersUpdateBut.TabIndex = 1;
            this.ordersUpdateBut.Text = "Обновить";
            this.ordersUpdateBut.UseVisualStyleBackColor = false;
            this.ordersUpdateBut.Click += new System.EventHandler(this.ordersUpdateBut_Click);
            // 
            // ordersGridView
            // 
            this.ordersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersGridView.AutoGenerateColumns = false;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repairIdDataGridViewTextBoxColumn,
            this.clientLastNameDataGridViewTextBoxColumn,
            this.clientFirstNameDataGridViewTextBoxColumn,
            this.clientMiddleNameDataGridViewTextBoxColumn,
            this.serviceTypeDataGridViewTextBoxColumn,
            this.masterFullNameDataGridViewTextBoxColumn,
            this.partsReplacedCountDataGridViewTextBoxColumn,
            this.workCostDataGridViewTextBoxColumn});
            this.ordersGridView.DataSource = this.vwRepairsInfoBindingSource;
            this.ordersGridView.Location = new System.Drawing.Point(6, 6);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.RowHeadersWidth = 51;
            this.ordersGridView.RowTemplate.Height = 24;
            this.ordersGridView.Size = new System.Drawing.Size(774, 370);
            this.ordersGridView.TabIndex = 0;
            // 
            // repairIdDataGridViewTextBoxColumn
            // 
            this.repairIdDataGridViewTextBoxColumn.DataPropertyName = "RepairId";
            this.repairIdDataGridViewTextBoxColumn.HeaderText = "RepairId";
            this.repairIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.repairIdDataGridViewTextBoxColumn.Name = "repairIdDataGridViewTextBoxColumn";
            this.repairIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientLastNameDataGridViewTextBoxColumn
            // 
            this.clientLastNameDataGridViewTextBoxColumn.DataPropertyName = "ClientLastName";
            this.clientLastNameDataGridViewTextBoxColumn.HeaderText = "ClientLastName";
            this.clientLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientLastNameDataGridViewTextBoxColumn.Name = "clientLastNameDataGridViewTextBoxColumn";
            this.clientLastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientFirstNameDataGridViewTextBoxColumn
            // 
            this.clientFirstNameDataGridViewTextBoxColumn.DataPropertyName = "ClientFirstName";
            this.clientFirstNameDataGridViewTextBoxColumn.HeaderText = "ClientFirstName";
            this.clientFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientFirstNameDataGridViewTextBoxColumn.Name = "clientFirstNameDataGridViewTextBoxColumn";
            this.clientFirstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientMiddleNameDataGridViewTextBoxColumn
            // 
            this.clientMiddleNameDataGridViewTextBoxColumn.DataPropertyName = "ClientMiddleName";
            this.clientMiddleNameDataGridViewTextBoxColumn.HeaderText = "ClientMiddleName";
            this.clientMiddleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientMiddleNameDataGridViewTextBoxColumn.Name = "clientMiddleNameDataGridViewTextBoxColumn";
            this.clientMiddleNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceTypeDataGridViewTextBoxColumn
            // 
            this.serviceTypeDataGridViewTextBoxColumn.DataPropertyName = "ServiceType";
            this.serviceTypeDataGridViewTextBoxColumn.HeaderText = "ServiceType";
            this.serviceTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceTypeDataGridViewTextBoxColumn.Name = "serviceTypeDataGridViewTextBoxColumn";
            this.serviceTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // masterFullNameDataGridViewTextBoxColumn
            // 
            this.masterFullNameDataGridViewTextBoxColumn.DataPropertyName = "MasterFullName";
            this.masterFullNameDataGridViewTextBoxColumn.HeaderText = "MasterFullName";
            this.masterFullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masterFullNameDataGridViewTextBoxColumn.Name = "masterFullNameDataGridViewTextBoxColumn";
            this.masterFullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // partsReplacedCountDataGridViewTextBoxColumn
            // 
            this.partsReplacedCountDataGridViewTextBoxColumn.DataPropertyName = "PartsReplacedCount";
            this.partsReplacedCountDataGridViewTextBoxColumn.HeaderText = "PartsReplacedCount";
            this.partsReplacedCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partsReplacedCountDataGridViewTextBoxColumn.Name = "partsReplacedCountDataGridViewTextBoxColumn";
            this.partsReplacedCountDataGridViewTextBoxColumn.Width = 125;
            // 
            // workCostDataGridViewTextBoxColumn
            // 
            this.workCostDataGridViewTextBoxColumn.DataPropertyName = "WorkCost";
            this.workCostDataGridViewTextBoxColumn.HeaderText = "WorkCost";
            this.workCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workCostDataGridViewTextBoxColumn.Name = "workCostDataGridViewTextBoxColumn";
            this.workCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // vwRepairsInfoBindingSource
            // 
            this.vwRepairsInfoBindingSource.DataMember = "vw_RepairsInfo";
            this.vwRepairsInfoBindingSource.DataSource = this.serviceDB_DataSet;
            // 
            // serviceDB_DataSet
            // 
            this.serviceDB_DataSet.DataSetName = "ServiceDB_DataSet";
            this.serviceDB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsPage
            // 
            this.carsPage.Controls.Add(this.carsDeleteBut);
            this.carsPage.Controls.Add(this.carsEditBut);
            this.carsPage.Controls.Add(this.carsAddBut);
            this.carsPage.Controls.Add(this.carsUpdateBut);
            this.carsPage.Controls.Add(this.carsGridView);
            this.carsPage.Location = new System.Drawing.Point(4, 25);
            this.carsPage.Name = "carsPage";
            this.carsPage.Padding = new System.Windows.Forms.Padding(3);
            this.carsPage.Size = new System.Drawing.Size(788, 415);
            this.carsPage.TabIndex = 1;
            this.carsPage.Text = "Машины";
            this.carsPage.UseVisualStyleBackColor = true;
            // 
            // carsDeleteBut
            // 
            this.carsDeleteBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.carsDeleteBut.BackColor = System.Drawing.Color.LightCoral;
            this.carsDeleteBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carsDeleteBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carsDeleteBut.Location = new System.Drawing.Point(592, 380);
            this.carsDeleteBut.Name = "carsDeleteBut";
            this.carsDeleteBut.Size = new System.Drawing.Size(189, 30);
            this.carsDeleteBut.TabIndex = 3;
            this.carsDeleteBut.Text = "Удалить";
            this.carsDeleteBut.UseVisualStyleBackColor = false;
            this.carsDeleteBut.Click += new System.EventHandler(this.carsDeleteBut_Click);
            // 
            // carsEditBut
            // 
            this.carsEditBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.carsEditBut.BackColor = System.Drawing.Color.Gold;
            this.carsEditBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carsEditBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carsEditBut.Location = new System.Drawing.Point(397, 380);
            this.carsEditBut.Name = "carsEditBut";
            this.carsEditBut.Size = new System.Drawing.Size(189, 30);
            this.carsEditBut.TabIndex = 4;
            this.carsEditBut.Text = "Изменить";
            this.carsEditBut.UseVisualStyleBackColor = false;
            this.carsEditBut.Click += new System.EventHandler(this.carsEditBut_Click);
            // 
            // carsAddBut
            // 
            this.carsAddBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.carsAddBut.BackColor = System.Drawing.Color.SpringGreen;
            this.carsAddBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carsAddBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carsAddBut.Location = new System.Drawing.Point(202, 380);
            this.carsAddBut.Name = "carsAddBut";
            this.carsAddBut.Size = new System.Drawing.Size(189, 30);
            this.carsAddBut.TabIndex = 5;
            this.carsAddBut.Text = "Добавить";
            this.carsAddBut.UseVisualStyleBackColor = false;
            this.carsAddBut.Click += new System.EventHandler(this.carsAddBut_Click);
            // 
            // carsUpdateBut
            // 
            this.carsUpdateBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.carsUpdateBut.BackColor = System.Drawing.Color.LightSkyBlue;
            this.carsUpdateBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carsUpdateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carsUpdateBut.Location = new System.Drawing.Point(7, 380);
            this.carsUpdateBut.Name = "carsUpdateBut";
            this.carsUpdateBut.Size = new System.Drawing.Size(189, 30);
            this.carsUpdateBut.TabIndex = 6;
            this.carsUpdateBut.Text = "Обновить";
            this.carsUpdateBut.UseVisualStyleBackColor = false;
            this.carsUpdateBut.Click += new System.EventHandler(this.carsUpdateBut_Click);
            // 
            // carsGridView
            // 
            this.carsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carsGridView.AutoGenerateColumns = false;
            this.carsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIdDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.engineTypeDataGridViewTextBoxColumn,
            this.registrationNumberDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.mileageDataGridViewTextBoxColumn});
            this.carsGridView.DataSource = this.vwCarsInfoBindingSource;
            this.carsGridView.Location = new System.Drawing.Point(7, 4);
            this.carsGridView.Name = "carsGridView";
            this.carsGridView.RowHeadersWidth = 51;
            this.carsGridView.RowTemplate.Height = 24;
            this.carsGridView.Size = new System.Drawing.Size(774, 370);
            this.carsGridView.TabIndex = 2;
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            this.carIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            this.carIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.carIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // engineTypeDataGridViewTextBoxColumn
            // 
            this.engineTypeDataGridViewTextBoxColumn.DataPropertyName = "EngineType";
            this.engineTypeDataGridViewTextBoxColumn.HeaderText = "EngineType";
            this.engineTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.engineTypeDataGridViewTextBoxColumn.Name = "engineTypeDataGridViewTextBoxColumn";
            this.engineTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            this.registrationNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            this.releaseDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // mileageDataGridViewTextBoxColumn
            // 
            this.mileageDataGridViewTextBoxColumn.DataPropertyName = "Mileage";
            this.mileageDataGridViewTextBoxColumn.HeaderText = "Mileage";
            this.mileageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mileageDataGridViewTextBoxColumn.Name = "mileageDataGridViewTextBoxColumn";
            this.mileageDataGridViewTextBoxColumn.Width = 125;
            // 
            // vwCarsInfoBindingSource
            // 
            this.vwCarsInfoBindingSource.DataMember = "vw_CarsInfo";
            this.vwCarsInfoBindingSource.DataSource = this.serviceDB_DataSet;
            // 
            // clientsPage
            // 
            this.clientsPage.Controls.Add(this.clientsDeleteBut);
            this.clientsPage.Controls.Add(this.clientsEditBut);
            this.clientsPage.Controls.Add(this.clientsAddBut);
            this.clientsPage.Controls.Add(this.clientsUpdateBut);
            this.clientsPage.Controls.Add(this.clientsGridView);
            this.clientsPage.Location = new System.Drawing.Point(4, 25);
            this.clientsPage.Name = "clientsPage";
            this.clientsPage.Size = new System.Drawing.Size(788, 415);
            this.clientsPage.TabIndex = 2;
            this.clientsPage.Text = "Клиенты";
            this.clientsPage.UseVisualStyleBackColor = true;
            // 
            // clientsDeleteBut
            // 
            this.clientsDeleteBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clientsDeleteBut.BackColor = System.Drawing.Color.LightCoral;
            this.clientsDeleteBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsDeleteBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsDeleteBut.Location = new System.Drawing.Point(592, 380);
            this.clientsDeleteBut.Name = "clientsDeleteBut";
            this.clientsDeleteBut.Size = new System.Drawing.Size(189, 30);
            this.clientsDeleteBut.TabIndex = 3;
            this.clientsDeleteBut.Text = "Удалить";
            this.clientsDeleteBut.UseVisualStyleBackColor = false;
            this.clientsDeleteBut.Click += new System.EventHandler(this.clientsDeleteBut_Click);
            // 
            // clientsEditBut
            // 
            this.clientsEditBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clientsEditBut.BackColor = System.Drawing.Color.Gold;
            this.clientsEditBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsEditBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsEditBut.Location = new System.Drawing.Point(397, 380);
            this.clientsEditBut.Name = "clientsEditBut";
            this.clientsEditBut.Size = new System.Drawing.Size(189, 30);
            this.clientsEditBut.TabIndex = 4;
            this.clientsEditBut.Text = "Изменить";
            this.clientsEditBut.UseVisualStyleBackColor = false;
            this.clientsEditBut.Click += new System.EventHandler(this.clientsEditBut_Click);
            // 
            // clientsAddBut
            // 
            this.clientsAddBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clientsAddBut.BackColor = System.Drawing.Color.SpringGreen;
            this.clientsAddBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsAddBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsAddBut.Location = new System.Drawing.Point(202, 380);
            this.clientsAddBut.Name = "clientsAddBut";
            this.clientsAddBut.Size = new System.Drawing.Size(189, 30);
            this.clientsAddBut.TabIndex = 5;
            this.clientsAddBut.Text = "Добавить";
            this.clientsAddBut.UseVisualStyleBackColor = false;
            this.clientsAddBut.Click += new System.EventHandler(this.clientsAddBut_Click);
            // 
            // clientsUpdateBut
            // 
            this.clientsUpdateBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clientsUpdateBut.BackColor = System.Drawing.Color.LightSkyBlue;
            this.clientsUpdateBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsUpdateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsUpdateBut.Location = new System.Drawing.Point(7, 380);
            this.clientsUpdateBut.Name = "clientsUpdateBut";
            this.clientsUpdateBut.Size = new System.Drawing.Size(189, 30);
            this.clientsUpdateBut.TabIndex = 6;
            this.clientsUpdateBut.Text = "Обновить";
            this.clientsUpdateBut.UseVisualStyleBackColor = false;
            this.clientsUpdateBut.Click += new System.EventHandler(this.clientsUpdateBut_Click);
            // 
            // clientsGridView
            // 
            this.clientsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientsGridView.AutoGenerateColumns = false;
            this.clientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIdDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.clientsGridView.DataSource = this.vwClientsInfoBindingSource;
            this.clientsGridView.Location = new System.Drawing.Point(7, 4);
            this.clientsGridView.Name = "clientsGridView";
            this.clientsGridView.RowHeadersWidth = 51;
            this.clientsGridView.RowTemplate.Height = 24;
            this.clientsGridView.Size = new System.Drawing.Size(774, 370);
            this.clientsGridView.TabIndex = 2;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // vwClientsInfoBindingSource
            // 
            this.vwClientsInfoBindingSource.DataMember = "vw_ClientsInfo";
            this.vwClientsInfoBindingSource.DataSource = this.serviceDB_DataSet;
            // 
            // servicesPage
            // 
            this.servicesPage.Controls.Add(this.servicesDeleteBut);
            this.servicesPage.Controls.Add(this.servicesEditBut);
            this.servicesPage.Controls.Add(this.servicesAddBut);
            this.servicesPage.Controls.Add(this.servicesUpdateBut);
            this.servicesPage.Controls.Add(this.servicesGridView);
            this.servicesPage.Location = new System.Drawing.Point(4, 25);
            this.servicesPage.Name = "servicesPage";
            this.servicesPage.Size = new System.Drawing.Size(788, 415);
            this.servicesPage.TabIndex = 3;
            this.servicesPage.Text = "Услуги";
            this.servicesPage.UseVisualStyleBackColor = true;
            // 
            // servicesDeleteBut
            // 
            this.servicesDeleteBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.servicesDeleteBut.BackColor = System.Drawing.Color.LightCoral;
            this.servicesDeleteBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicesDeleteBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servicesDeleteBut.Location = new System.Drawing.Point(592, 380);
            this.servicesDeleteBut.Name = "servicesDeleteBut";
            this.servicesDeleteBut.Size = new System.Drawing.Size(189, 30);
            this.servicesDeleteBut.TabIndex = 3;
            this.servicesDeleteBut.Text = "Удалить";
            this.servicesDeleteBut.UseVisualStyleBackColor = false;
            this.servicesDeleteBut.Click += new System.EventHandler(this.servicesDeleteBut_Click);
            // 
            // servicesEditBut
            // 
            this.servicesEditBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.servicesEditBut.BackColor = System.Drawing.Color.Gold;
            this.servicesEditBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicesEditBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servicesEditBut.Location = new System.Drawing.Point(397, 380);
            this.servicesEditBut.Name = "servicesEditBut";
            this.servicesEditBut.Size = new System.Drawing.Size(189, 30);
            this.servicesEditBut.TabIndex = 4;
            this.servicesEditBut.Text = "Изменить";
            this.servicesEditBut.UseVisualStyleBackColor = false;
            this.servicesEditBut.Click += new System.EventHandler(this.servicesEditBut_Click);
            // 
            // servicesAddBut
            // 
            this.servicesAddBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.servicesAddBut.BackColor = System.Drawing.Color.SpringGreen;
            this.servicesAddBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicesAddBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servicesAddBut.Location = new System.Drawing.Point(202, 380);
            this.servicesAddBut.Name = "servicesAddBut";
            this.servicesAddBut.Size = new System.Drawing.Size(189, 30);
            this.servicesAddBut.TabIndex = 5;
            this.servicesAddBut.Text = "Добавить";
            this.servicesAddBut.UseVisualStyleBackColor = false;
            this.servicesAddBut.Click += new System.EventHandler(this.servicesAddBut_Click);
            // 
            // servicesUpdateBut
            // 
            this.servicesUpdateBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.servicesUpdateBut.BackColor = System.Drawing.Color.LightSkyBlue;
            this.servicesUpdateBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicesUpdateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servicesUpdateBut.Location = new System.Drawing.Point(7, 380);
            this.servicesUpdateBut.Name = "servicesUpdateBut";
            this.servicesUpdateBut.Size = new System.Drawing.Size(189, 30);
            this.servicesUpdateBut.TabIndex = 6;
            this.servicesUpdateBut.Text = "Обновить";
            this.servicesUpdateBut.UseVisualStyleBackColor = false;
            this.servicesUpdateBut.Click += new System.EventHandler(this.servicesUpdateBut_Click);
            // 
            // servicesGridView
            // 
            this.servicesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesGridView.AutoGenerateColumns = false;
            this.servicesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIdDataGridViewTextBoxColumn,
            this.workTypeDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.warrantyPeriodDataGridViewTextBoxColumn});
            this.servicesGridView.DataSource = this.vwServicesInfoBindingSource;
            this.servicesGridView.Location = new System.Drawing.Point(7, 4);
            this.servicesGridView.Name = "servicesGridView";
            this.servicesGridView.RowHeadersWidth = 51;
            this.servicesGridView.RowTemplate.Height = 24;
            this.servicesGridView.Size = new System.Drawing.Size(774, 370);
            this.servicesGridView.TabIndex = 2;
            // 
            // serviceIdDataGridViewTextBoxColumn
            // 
            this.serviceIdDataGridViewTextBoxColumn.DataPropertyName = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.HeaderText = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceIdDataGridViewTextBoxColumn.Name = "serviceIdDataGridViewTextBoxColumn";
            this.serviceIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // workTypeDataGridViewTextBoxColumn
            // 
            this.workTypeDataGridViewTextBoxColumn.DataPropertyName = "WorkType";
            this.workTypeDataGridViewTextBoxColumn.HeaderText = "WorkType";
            this.workTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workTypeDataGridViewTextBoxColumn.Name = "workTypeDataGridViewTextBoxColumn";
            this.workTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // warrantyPeriodDataGridViewTextBoxColumn
            // 
            this.warrantyPeriodDataGridViewTextBoxColumn.DataPropertyName = "WarrantyPeriod";
            this.warrantyPeriodDataGridViewTextBoxColumn.HeaderText = "WarrantyPeriod";
            this.warrantyPeriodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.warrantyPeriodDataGridViewTextBoxColumn.Name = "warrantyPeriodDataGridViewTextBoxColumn";
            this.warrantyPeriodDataGridViewTextBoxColumn.Width = 125;
            // 
            // vwServicesInfoBindingSource
            // 
            this.vwServicesInfoBindingSource.DataMember = "vw_ServicesInfo";
            this.vwServicesInfoBindingSource.DataSource = this.serviceDB_DataSet;
            // 
            // mastersPage
            // 
            this.mastersPage.Controls.Add(this.mastersDeleteBut);
            this.mastersPage.Controls.Add(this.mastersEditBut);
            this.mastersPage.Controls.Add(this.mastersAddBut);
            this.mastersPage.Controls.Add(this.mastersUpdateBut);
            this.mastersPage.Controls.Add(this.mastersGridView);
            this.mastersPage.Location = new System.Drawing.Point(4, 25);
            this.mastersPage.Name = "mastersPage";
            this.mastersPage.Size = new System.Drawing.Size(788, 415);
            this.mastersPage.TabIndex = 4;
            this.mastersPage.Text = "Мастера";
            this.mastersPage.UseVisualStyleBackColor = true;
            // 
            // mastersDeleteBut
            // 
            this.mastersDeleteBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mastersDeleteBut.BackColor = System.Drawing.Color.LightCoral;
            this.mastersDeleteBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mastersDeleteBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mastersDeleteBut.Location = new System.Drawing.Point(592, 380);
            this.mastersDeleteBut.Name = "mastersDeleteBut";
            this.mastersDeleteBut.Size = new System.Drawing.Size(189, 30);
            this.mastersDeleteBut.TabIndex = 3;
            this.mastersDeleteBut.Text = "Удалить";
            this.mastersDeleteBut.UseVisualStyleBackColor = false;
            this.mastersDeleteBut.Click += new System.EventHandler(this.mastersDeleteBut_Click);
            // 
            // mastersEditBut
            // 
            this.mastersEditBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mastersEditBut.BackColor = System.Drawing.Color.Gold;
            this.mastersEditBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mastersEditBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mastersEditBut.Location = new System.Drawing.Point(397, 380);
            this.mastersEditBut.Name = "mastersEditBut";
            this.mastersEditBut.Size = new System.Drawing.Size(189, 30);
            this.mastersEditBut.TabIndex = 4;
            this.mastersEditBut.Text = "Изменить";
            this.mastersEditBut.UseVisualStyleBackColor = false;
            this.mastersEditBut.Click += new System.EventHandler(this.mastersEditBut_Click);
            // 
            // mastersAddBut
            // 
            this.mastersAddBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mastersAddBut.BackColor = System.Drawing.Color.SpringGreen;
            this.mastersAddBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mastersAddBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mastersAddBut.Location = new System.Drawing.Point(202, 380);
            this.mastersAddBut.Name = "mastersAddBut";
            this.mastersAddBut.Size = new System.Drawing.Size(189, 30);
            this.mastersAddBut.TabIndex = 5;
            this.mastersAddBut.Text = "Добавить";
            this.mastersAddBut.UseVisualStyleBackColor = false;
            this.mastersAddBut.Click += new System.EventHandler(this.mastersAddBut_Click);
            // 
            // mastersUpdateBut
            // 
            this.mastersUpdateBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mastersUpdateBut.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mastersUpdateBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mastersUpdateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mastersUpdateBut.Location = new System.Drawing.Point(7, 380);
            this.mastersUpdateBut.Name = "mastersUpdateBut";
            this.mastersUpdateBut.Size = new System.Drawing.Size(189, 30);
            this.mastersUpdateBut.TabIndex = 6;
            this.mastersUpdateBut.Text = "Обновить";
            this.mastersUpdateBut.UseVisualStyleBackColor = false;
            this.mastersUpdateBut.Click += new System.EventHandler(this.mastersUpdateBut_Click);
            // 
            // mastersGridView
            // 
            this.mastersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mastersGridView.AutoGenerateColumns = false;
            this.mastersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mastersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masterIdDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.experienceYearsDataGridViewTextBoxColumn});
            this.mastersGridView.DataSource = this.vwMastersInfoBindingSource;
            this.mastersGridView.Location = new System.Drawing.Point(7, 4);
            this.mastersGridView.Name = "mastersGridView";
            this.mastersGridView.RowHeadersWidth = 51;
            this.mastersGridView.RowTemplate.Height = 24;
            this.mastersGridView.Size = new System.Drawing.Size(774, 370);
            this.mastersGridView.TabIndex = 2;
            // 
            // masterIdDataGridViewTextBoxColumn
            // 
            this.masterIdDataGridViewTextBoxColumn.DataPropertyName = "MasterId";
            this.masterIdDataGridViewTextBoxColumn.HeaderText = "MasterId";
            this.masterIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masterIdDataGridViewTextBoxColumn.Name = "masterIdDataGridViewTextBoxColumn";
            this.masterIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.masterIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 125;
            // 
            // experienceYearsDataGridViewTextBoxColumn
            // 
            this.experienceYearsDataGridViewTextBoxColumn.DataPropertyName = "ExperienceYears";
            this.experienceYearsDataGridViewTextBoxColumn.HeaderText = "ExperienceYears";
            this.experienceYearsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.experienceYearsDataGridViewTextBoxColumn.Name = "experienceYearsDataGridViewTextBoxColumn";
            this.experienceYearsDataGridViewTextBoxColumn.Width = 125;
            // 
            // vwMastersInfoBindingSource
            // 
            this.vwMastersInfoBindingSource.DataMember = "vw_MastersInfo";
            this.vwMastersInfoBindingSource.DataSource = this.serviceDB_DataSet;
            // 
            // vw_RepairsInfoTableAdapter
            // 
            this.vw_RepairsInfoTableAdapter.ClearBeforeFill = true;
            // 
            // vw_CarsInfoTableAdapter
            // 
            this.vw_CarsInfoTableAdapter.ClearBeforeFill = true;
            // 
            // vw_ClientsInfoTableAdapter
            // 
            this.vw_ClientsInfoTableAdapter.ClearBeforeFill = true;
            // 
            // vw_ServicesInfoTableAdapter
            // 
            this.vw_ServicesInfoTableAdapter.ClearBeforeFill = true;
            // 
            // vw_MastersInfoTableAdapter
            // 
            this.vw_MastersInfoTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Ремонт автомобилей";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.ordersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRepairsInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDB_DataSet)).EndInit();
            this.carsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCarsInfoBindingSource)).EndInit();
            this.clientsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwClientsInfoBindingSource)).EndInit();
            this.servicesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servicesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwServicesInfoBindingSource)).EndInit();
            this.mastersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mastersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMastersInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ordersPage;
        private System.Windows.Forms.TabPage carsPage;
        private System.Windows.Forms.TabPage clientsPage;
        private System.Windows.Forms.TabPage servicesPage;
        private System.Windows.Forms.TabPage mastersPage;
        private System.Windows.Forms.Button ordersDeleteBut;
        private System.Windows.Forms.Button ordersEditBut;
        private System.Windows.Forms.Button ordersAddBut;
        private System.Windows.Forms.Button ordersUpdateBut;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.Button carsDeleteBut;
        private System.Windows.Forms.Button carsEditBut;
        private System.Windows.Forms.Button carsAddBut;
        private System.Windows.Forms.Button carsUpdateBut;
        private System.Windows.Forms.DataGridView carsGridView;
        private System.Windows.Forms.Button clientsDeleteBut;
        private System.Windows.Forms.Button clientsEditBut;
        private System.Windows.Forms.Button clientsAddBut;
        private System.Windows.Forms.Button clientsUpdateBut;
        private System.Windows.Forms.DataGridView clientsGridView;
        private System.Windows.Forms.Button servicesDeleteBut;
        private System.Windows.Forms.Button servicesEditBut;
        private System.Windows.Forms.Button servicesAddBut;
        private System.Windows.Forms.Button servicesUpdateBut;
        private System.Windows.Forms.DataGridView servicesGridView;
        private System.Windows.Forms.Button mastersDeleteBut;
        private System.Windows.Forms.Button mastersEditBut;
        private System.Windows.Forms.Button mastersAddBut;
        private System.Windows.Forms.Button mastersUpdateBut;
        private System.Windows.Forms.DataGridView mastersGridView;
        private ServiceDB_DataSet serviceDB_DataSet;
        private System.Windows.Forms.BindingSource vwRepairsInfoBindingSource;
        private ServiceDB_DataSetTableAdapters.vw_RepairsInfoTableAdapter vw_RepairsInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partsReplacedCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwCarsInfoBindingSource;
        private ServiceDB_DataSetTableAdapters.vw_CarsInfoTableAdapter vw_CarsInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwClientsInfoBindingSource;
        private ServiceDB_DataSetTableAdapters.vw_ClientsInfoTableAdapter vw_ClientsInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwServicesInfoBindingSource;
        private ServiceDB_DataSetTableAdapters.vw_ServicesInfoTableAdapter vw_ServicesInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrantyPeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwMastersInfoBindingSource;
        private ServiceDB_DataSetTableAdapters.vw_MastersInfoTableAdapter vw_MastersInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceYearsDataGridViewTextBoxColumn;
    }
}

