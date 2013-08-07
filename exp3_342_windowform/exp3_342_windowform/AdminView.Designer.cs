namespace exp3_342_windowform
{
    partial class AdminView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            _db.Commit();
            _form.Show();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.loginStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.adminTabs = new System.Windows.Forms.TabControl();
            this.personalInfoTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.editInfo = new System.Windows.Forms.TabPage();
            this.editInfoSave = new System.Windows.Forms.Button();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.birthDayBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginInfo = new System.Windows.Forms.TabPage();
            this.loginInfoSave = new System.Windows.Forms.Button();
            this.passwordAgain = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.projectsTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.viewProjectsTab = new System.Windows.Forms.TabPage();
            this.projectList = new System.Windows.Forms.DataGridView();
            this.createNewProjectTab = new System.Windows.Forms.TabPage();
            this.newProjectCancelButton = new System.Windows.Forms.Button();
            this.newProjectSaveButton = new System.Windows.Forms.Button();
            this.newProjectDescBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.newProjectNameBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.employeeTab = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.registeredEmployee = new System.Windows.Forms.TabPage();
            this.employees = new System.Windows.Forms.DataGridView();
            this.createNewEmployee = new System.Windows.Forms.TabPage();
            this.createNewSaveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.createNewEmail = new System.Windows.Forms.TextBox();
            this.createNewUserNameBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.createNewPassAgain = new System.Windows.Forms.TextBox();
            this.createPasswordBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.removeEmployee = new System.Windows.Forms.TabPage();
            this.removeEmployeeButton = new System.Windows.Forms.Button();
            this.employeeList = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.notificationsTab = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.showNotificationsTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.yearsComboBox = new System.Windows.Forms.ComboBox();
            this.monthsComboBox = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.employeesComboBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.notificationsView = new System.Windows.Forms.DataGridView();
            this.totalHourView = new System.Windows.Forms.DataGridView();
            this.tasksTab = new System.Windows.Forms.TabPage();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.assignTaskTab = new System.Windows.Forms.TabPage();
            this.newTaskSaveButton = new System.Windows.Forms.Button();
            this.newTaskDescBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.newTaskAssignCal = new System.Windows.Forms.MonthCalendar();
            this.label23 = new System.Windows.Forms.Label();
            this.newTaskAssignEmp = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.newTaskAssignProj = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.showTasksTab = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.showTaskEmployeesList = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.showTasksProjectList = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.showTasksView = new System.Windows.Forms.DataGridView();
            this.assignManagersTab = new System.Windows.Forms.TabPage();
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.systemManagersTab = new System.Windows.Forms.TabPage();
            this.demoteButton = new System.Windows.Forms.Button();
            this.makeManagerButton = new System.Windows.Forms.Button();
            this.adminsList = new System.Windows.Forms.ListBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.normalUsersList = new System.Windows.Forms.ListBox();
            this.filterUsers = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.analyzeTab = new System.Windows.Forms.TabPage();
            this.analyzeView = new System.Windows.Forms.DataGridView();
            this.projectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWorkedHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.adminTabs.SuspendLayout();
            this.personalInfoTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.editInfo.SuspendLayout();
            this.loginInfo.SuspendLayout();
            this.projectsTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.viewProjectsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectList)).BeginInit();
            this.createNewProjectTab.SuspendLayout();
            this.employeeTab.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.registeredEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employees)).BeginInit();
            this.createNewEmployee.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.removeEmployee.SuspendLayout();
            this.notificationsTab.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.showNotificationsTab.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notificationsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalHourView)).BeginInit();
            this.tasksTab.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.assignTaskTab.SuspendLayout();
            this.showTasksTab.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showTasksView)).BeginInit();
            this.assignManagersTab.SuspendLayout();
            this.tabControl6.SuspendLayout();
            this.systemManagersTab.SuspendLayout();
            this.analyzeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.analyzeView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.loginStatus);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.logo);
            this.splitContainer1.Panel1.Controls.Add(this.logoutButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.adminTabs);
            this.splitContainer1.Size = new System.Drawing.Size(880, 506);
            this.splitContainer1.SplitterDistance = 119;
            this.splitContainer1.TabIndex = 0;
            // 
            // loginStatus
            // 
            this.loginStatus.AutoSize = true;
            this.loginStatus.Location = new System.Drawing.Point(790, 47);
            this.loginStatus.Name = "loginStatus";
            this.loginStatus.Size = new System.Drawing.Size(0, 13);
            this.loginStatus.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(123, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Project Team Tracing System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(122, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "BiL342";
            // 
            // logo
            // 
            this.logo.Image = global::exp3_342_windowform.Properties.Resources.welcome;
            this.logo.Location = new System.Drawing.Point(12, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(105, 104);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 13;
            this.logo.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Location = new System.Drawing.Point(793, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButtonClick);
            this.logoutButton.MouseLeave += new System.EventHandler(this.LogoutButtonMouseLeave);
            this.logoutButton.MouseHover += new System.EventHandler(this.LogoutButtonMouseHover);
            // 
            // adminTabs
            // 
            this.adminTabs.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.adminTabs.Controls.Add(this.personalInfoTab);
            this.adminTabs.Controls.Add(this.projectsTab);
            this.adminTabs.Controls.Add(this.employeeTab);
            this.adminTabs.Controls.Add(this.notificationsTab);
            this.adminTabs.Controls.Add(this.tasksTab);
            this.adminTabs.Controls.Add(this.assignManagersTab);
            this.adminTabs.Controls.Add(this.analyzeTab);
            this.adminTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.adminTabs.ItemSize = new System.Drawing.Size(30, 150);
            this.adminTabs.Location = new System.Drawing.Point(0, 0);
            this.adminTabs.Multiline = true;
            this.adminTabs.Name = "adminTabs";
            this.adminTabs.SelectedIndex = 0;
            this.adminTabs.Size = new System.Drawing.Size(880, 383);
            this.adminTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.adminTabs.TabIndex = 0;
            // 
            // personalInfoTab
            // 
            this.personalInfoTab.BackColor = System.Drawing.Color.White;
            this.personalInfoTab.Controls.Add(this.tabControl1);
            this.personalInfoTab.Location = new System.Drawing.Point(154, 4);
            this.personalInfoTab.Name = "personalInfoTab";
            this.personalInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.personalInfoTab.Size = new System.Drawing.Size(722, 375);
            this.personalInfoTab.TabIndex = 0;
            this.personalInfoTab.Text = "Personal Information";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.editInfo);
            this.tabControl1.Controls.Add(this.loginInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // editInfo
            // 
            this.editInfo.BackColor = System.Drawing.Color.White;
            this.editInfo.Controls.Add(this.editInfoSave);
            this.editInfo.Controls.Add(this.addressBox);
            this.editInfo.Controls.Add(this.cityComboBox);
            this.editInfo.Controls.Add(this.label6);
            this.editInfo.Controls.Add(this.nameBox);
            this.editInfo.Controls.Add(this.phoneBox);
            this.editInfo.Controls.Add(this.femaleButton);
            this.editInfo.Controls.Add(this.label7);
            this.editInfo.Controls.Add(this.label1);
            this.editInfo.Controls.Add(this.label5);
            this.editInfo.Controls.Add(this.maleButton);
            this.editInfo.Controls.Add(this.birthDayBox);
            this.editInfo.Controls.Add(this.surnameBox);
            this.editInfo.Controls.Add(this.label8);
            this.editInfo.Controls.Add(this.label9);
            this.editInfo.Controls.Add(this.label2);
            this.editInfo.Location = new System.Drawing.Point(4, 22);
            this.editInfo.Name = "editInfo";
            this.editInfo.Padding = new System.Windows.Forms.Padding(3);
            this.editInfo.Size = new System.Drawing.Size(708, 343);
            this.editInfo.TabIndex = 0;
            this.editInfo.Text = "Edit Info";
            // 
            // editInfoSave
            // 
            this.editInfoSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editInfoSave.Location = new System.Drawing.Point(627, 314);
            this.editInfoSave.Name = "editInfoSave";
            this.editInfoSave.Size = new System.Drawing.Size(75, 23);
            this.editInfoSave.TabIndex = 17;
            this.editInfoSave.Text = "Save";
            this.editInfoSave.UseVisualStyleBackColor = true;
            this.editInfoSave.Click += new System.EventHandler(this.EditInfoSaveClick);
            // 
            // addressBox
            // 
            this.addressBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressBox.Location = new System.Drawing.Point(285, 203);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(219, 47);
            this.addressBox.TabIndex = 10;
            // 
            // cityComboBox
            // 
            this.cityComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şanlı urfa",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cityComboBox.Location = new System.Drawing.Point(285, 172);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(219, 21);
            this.cityComboBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone                  :";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameBox.Location = new System.Drawing.Point(285, 53);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(219, 20);
            this.nameBox.TabIndex = 0;
            // 
            // phoneBox
            // 
            this.phoneBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneBox.Location = new System.Drawing.Point(285, 143);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(219, 20);
            this.phoneBox.TabIndex = 6;
            // 
            // femaleButton
            // 
            this.femaleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.femaleButton.AutoSize = true;
            this.femaleButton.Location = new System.Drawing.Point(401, 267);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(59, 17);
            this.femaleButton.TabIndex = 15;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "City                       :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name                   :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Surname              :";
            // 
            // maleButton
            // 
            this.maleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maleButton.AutoSize = true;
            this.maleButton.Location = new System.Drawing.Point(331, 267);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(48, 17);
            this.maleButton.TabIndex = 14;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            // 
            // birthDayBox
            // 
            this.birthDayBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthDayBox.Location = new System.Drawing.Point(285, 114);
            this.birthDayBox.Name = "birthDayBox";
            this.birthDayBox.Size = new System.Drawing.Size(219, 20);
            this.birthDayBox.TabIndex = 4;
            // 
            // surnameBox
            // 
            this.surnameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.surnameBox.Location = new System.Drawing.Point(285, 84);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(219, 20);
            this.surnameBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Address                :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Gender                 :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Birth Day              :";
            // 
            // loginInfo
            // 
            this.loginInfo.BackColor = System.Drawing.Color.White;
            this.loginInfo.Controls.Add(this.loginInfoSave);
            this.loginInfo.Controls.Add(this.passwordAgain);
            this.loginInfo.Controls.Add(this.label11);
            this.loginInfo.Controls.Add(this.passwordBox);
            this.loginInfo.Controls.Add(this.label10);
            this.loginInfo.Location = new System.Drawing.Point(4, 22);
            this.loginInfo.Name = "loginInfo";
            this.loginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.loginInfo.Size = new System.Drawing.Size(708, 343);
            this.loginInfo.TabIndex = 1;
            this.loginInfo.Text = "Login Info";
            // 
            // loginInfoSave
            // 
            this.loginInfoSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loginInfoSave.Location = new System.Drawing.Point(627, 314);
            this.loginInfoSave.Name = "loginInfoSave";
            this.loginInfoSave.Size = new System.Drawing.Size(75, 23);
            this.loginInfoSave.TabIndex = 4;
            this.loginInfoSave.Text = "Save";
            this.loginInfoSave.UseVisualStyleBackColor = true;
            this.loginInfoSave.Click += new System.EventHandler(this.LoginInfoSaveClick);
            // 
            // passwordAgain
            // 
            this.passwordAgain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordAgain.Location = new System.Drawing.Point(325, 168);
            this.passwordAgain.Name = "passwordAgain";
            this.passwordAgain.PasswordChar = '*';
            this.passwordAgain.Size = new System.Drawing.Size(167, 20);
            this.passwordAgain.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(217, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Password Again  :";
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.Location = new System.Drawing.Point(325, 131);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(167, 20);
            this.passwordBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(217, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Password            :";
            // 
            // projectsTab
            // 
            this.projectsTab.BackColor = System.Drawing.Color.White;
            this.projectsTab.Controls.Add(this.tabControl2);
            this.projectsTab.Location = new System.Drawing.Point(154, 4);
            this.projectsTab.Name = "projectsTab";
            this.projectsTab.Padding = new System.Windows.Forms.Padding(3);
            this.projectsTab.Size = new System.Drawing.Size(722, 375);
            this.projectsTab.TabIndex = 1;
            this.projectsTab.Text = "Projects";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.viewProjectsTab);
            this.tabControl2.Controls.Add(this.createNewProjectTab);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(716, 369);
            this.tabControl2.TabIndex = 0;
            // 
            // viewProjectsTab
            // 
            this.viewProjectsTab.BackColor = System.Drawing.Color.White;
            this.viewProjectsTab.Controls.Add(this.projectList);
            this.viewProjectsTab.Location = new System.Drawing.Point(4, 22);
            this.viewProjectsTab.Name = "viewProjectsTab";
            this.viewProjectsTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewProjectsTab.Size = new System.Drawing.Size(708, 343);
            this.viewProjectsTab.TabIndex = 0;
            this.viewProjectsTab.Text = "View Projects";
            // 
            // projectList
            // 
            this.projectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectList.BackgroundColor = System.Drawing.Color.White;
            this.projectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectList.GridColor = System.Drawing.Color.Black;
            this.projectList.Location = new System.Drawing.Point(3, 3);
            this.projectList.Name = "projectList";
            this.projectList.Size = new System.Drawing.Size(702, 337);
            this.projectList.TabIndex = 0;
            // 
            // createNewProjectTab
            // 
            this.createNewProjectTab.BackColor = System.Drawing.Color.White;
            this.createNewProjectTab.Controls.Add(this.newProjectCancelButton);
            this.createNewProjectTab.Controls.Add(this.newProjectSaveButton);
            this.createNewProjectTab.Controls.Add(this.newProjectDescBox);
            this.createNewProjectTab.Controls.Add(this.label18);
            this.createNewProjectTab.Controls.Add(this.newProjectNameBox);
            this.createNewProjectTab.Controls.Add(this.label17);
            this.createNewProjectTab.Location = new System.Drawing.Point(4, 22);
            this.createNewProjectTab.Name = "createNewProjectTab";
            this.createNewProjectTab.Padding = new System.Windows.Forms.Padding(3);
            this.createNewProjectTab.Size = new System.Drawing.Size(708, 343);
            this.createNewProjectTab.TabIndex = 1;
            this.createNewProjectTab.Text = "Create New Project";
            // 
            // newProjectCancelButton
            // 
            this.newProjectCancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newProjectCancelButton.Location = new System.Drawing.Point(404, 216);
            this.newProjectCancelButton.Name = "newProjectCancelButton";
            this.newProjectCancelButton.Size = new System.Drawing.Size(75, 23);
            this.newProjectCancelButton.TabIndex = 5;
            this.newProjectCancelButton.Text = "Cancel";
            this.newProjectCancelButton.UseVisualStyleBackColor = true;
            this.newProjectCancelButton.Click += new System.EventHandler(this.NewProjectCancelButtonClick);
            // 
            // newProjectSaveButton
            // 
            this.newProjectSaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newProjectSaveButton.Location = new System.Drawing.Point(323, 216);
            this.newProjectSaveButton.Name = "newProjectSaveButton";
            this.newProjectSaveButton.Size = new System.Drawing.Size(75, 23);
            this.newProjectSaveButton.TabIndex = 4;
            this.newProjectSaveButton.Text = "Save";
            this.newProjectSaveButton.UseVisualStyleBackColor = true;
            this.newProjectSaveButton.Click += new System.EventHandler(this.NewProjectSaveButtonClick);
            // 
            // newProjectDescBox
            // 
            this.newProjectDescBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newProjectDescBox.Location = new System.Drawing.Point(267, 135);
            this.newProjectDescBox.Multiline = true;
            this.newProjectDescBox.Name = "newProjectDescBox";
            this.newProjectDescBox.Size = new System.Drawing.Size(212, 60);
            this.newProjectDescBox.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(153, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Project Description   :";
            // 
            // newProjectNameBox
            // 
            this.newProjectNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newProjectNameBox.Location = new System.Drawing.Point(267, 106);
            this.newProjectNameBox.Name = "newProjectNameBox";
            this.newProjectNameBox.Size = new System.Drawing.Size(212, 20);
            this.newProjectNameBox.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(153, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Project Name           :";
            // 
            // employeeTab
            // 
            this.employeeTab.BackColor = System.Drawing.Color.White;
            this.employeeTab.Controls.Add(this.tabControl3);
            this.employeeTab.Location = new System.Drawing.Point(154, 4);
            this.employeeTab.Name = "employeeTab";
            this.employeeTab.Size = new System.Drawing.Size(722, 375);
            this.employeeTab.TabIndex = 2;
            this.employeeTab.Text = "Employee";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.registeredEmployee);
            this.tabControl3.Controls.Add(this.createNewEmployee);
            this.tabControl3.Controls.Add(this.removeEmployee);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(722, 375);
            this.tabControl3.TabIndex = 0;
            // 
            // registeredEmployee
            // 
            this.registeredEmployee.BackColor = System.Drawing.Color.White;
            this.registeredEmployee.Controls.Add(this.employees);
            this.registeredEmployee.Location = new System.Drawing.Point(4, 22);
            this.registeredEmployee.Name = "registeredEmployee";
            this.registeredEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.registeredEmployee.Size = new System.Drawing.Size(714, 349);
            this.registeredEmployee.TabIndex = 0;
            this.registeredEmployee.Text = "Registered Employee";
            // 
            // employees
            // 
            this.employees.AllowUserToAddRows = false;
            this.employees.AllowUserToDeleteRows = false;
            this.employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employees.BackgroundColor = System.Drawing.Color.White;
            this.employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employees.GridColor = System.Drawing.Color.Black;
            this.employees.Location = new System.Drawing.Point(3, 3);
            this.employees.Name = "employees";
            this.employees.ReadOnly = true;
            this.employees.Size = new System.Drawing.Size(708, 343);
            this.employees.TabIndex = 0;
            // 
            // createNewEmployee
            // 
            this.createNewEmployee.BackColor = System.Drawing.Color.White;
            this.createNewEmployee.Controls.Add(this.createNewSaveButton);
            this.createNewEmployee.Controls.Add(this.groupBox1);
            this.createNewEmployee.Location = new System.Drawing.Point(4, 22);
            this.createNewEmployee.Name = "createNewEmployee";
            this.createNewEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.createNewEmployee.Size = new System.Drawing.Size(714, 349);
            this.createNewEmployee.TabIndex = 1;
            this.createNewEmployee.Text = "Create New Employee";
            // 
            // createNewSaveButton
            // 
            this.createNewSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createNewSaveButton.Location = new System.Drawing.Point(633, 320);
            this.createNewSaveButton.Name = "createNewSaveButton";
            this.createNewSaveButton.Size = new System.Drawing.Size(75, 23);
            this.createNewSaveButton.TabIndex = 9;
            this.createNewSaveButton.Text = "Save";
            this.createNewSaveButton.UseVisualStyleBackColor = true;
            this.createNewSaveButton.Click += new System.EventHandler(this.CreateNewSaveButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.createNewEmail);
            this.groupBox1.Controls.Add(this.createNewUserNameBox);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.createNewPassAgain);
            this.groupBox1.Controls.Add(this.createPasswordBox);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(196, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 251);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Employee";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "User Name          :";
            // 
            // createNewEmail
            // 
            this.createNewEmail.Location = new System.Drawing.Point(154, 156);
            this.createNewEmail.Name = "createNewEmail";
            this.createNewEmail.Size = new System.Drawing.Size(132, 20);
            this.createNewEmail.TabIndex = 7;
            // 
            // createNewUserNameBox
            // 
            this.createNewUserNameBox.Location = new System.Drawing.Point(154, 65);
            this.createNewUserNameBox.Name = "createNewUserNameBox";
            this.createNewUserNameBox.Size = new System.Drawing.Size(132, 20);
            this.createNewUserNameBox.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "E-mail                   :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Password Again   :";
            // 
            // createNewPassAgain
            // 
            this.createNewPassAgain.Location = new System.Drawing.Point(154, 125);
            this.createNewPassAgain.Name = "createNewPassAgain";
            this.createNewPassAgain.PasswordChar = '*';
            this.createNewPassAgain.Size = new System.Drawing.Size(132, 20);
            this.createNewPassAgain.TabIndex = 5;
            // 
            // createPasswordBox
            // 
            this.createPasswordBox.Location = new System.Drawing.Point(154, 96);
            this.createPasswordBox.Name = "createPasswordBox";
            this.createPasswordBox.PasswordChar = '*';
            this.createPasswordBox.Size = new System.Drawing.Size(132, 20);
            this.createPasswordBox.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Password             :";
            // 
            // removeEmployee
            // 
            this.removeEmployee.BackColor = System.Drawing.Color.White;
            this.removeEmployee.Controls.Add(this.removeEmployeeButton);
            this.removeEmployee.Controls.Add(this.employeeList);
            this.removeEmployee.Controls.Add(this.label16);
            this.removeEmployee.Location = new System.Drawing.Point(4, 22);
            this.removeEmployee.Name = "removeEmployee";
            this.removeEmployee.Size = new System.Drawing.Size(714, 349);
            this.removeEmployee.TabIndex = 2;
            this.removeEmployee.Text = "Remove Employee";
            // 
            // removeEmployeeButton
            // 
            this.removeEmployeeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeEmployeeButton.Location = new System.Drawing.Point(306, 156);
            this.removeEmployeeButton.Name = "removeEmployeeButton";
            this.removeEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.removeEmployeeButton.TabIndex = 2;
            this.removeEmployeeButton.Text = "Remove";
            this.removeEmployeeButton.UseVisualStyleBackColor = true;
            this.removeEmployeeButton.Click += new System.EventHandler(this.RemoveEmployeeButtonClick);
            // 
            // employeeList
            // 
            this.employeeList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeList.FormattingEnabled = true;
            this.employeeList.Location = new System.Drawing.Point(306, 129);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(148, 21);
            this.employeeList.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(241, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Employee :";
            // 
            // notificationsTab
            // 
            this.notificationsTab.BackColor = System.Drawing.Color.White;
            this.notificationsTab.Controls.Add(this.tabControl4);
            this.notificationsTab.Location = new System.Drawing.Point(154, 4);
            this.notificationsTab.Name = "notificationsTab";
            this.notificationsTab.Size = new System.Drawing.Size(722, 375);
            this.notificationsTab.TabIndex = 3;
            this.notificationsTab.Text = "Notifications";
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.showNotificationsTab);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Location = new System.Drawing.Point(0, 0);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(722, 375);
            this.tabControl4.TabIndex = 0;
            // 
            // showNotificationsTab
            // 
            this.showNotificationsTab.BackColor = System.Drawing.Color.White;
            this.showNotificationsTab.Controls.Add(this.splitContainer2);
            this.showNotificationsTab.Location = new System.Drawing.Point(4, 22);
            this.showNotificationsTab.Name = "showNotificationsTab";
            this.showNotificationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.showNotificationsTab.Size = new System.Drawing.Size(714, 349);
            this.showNotificationsTab.TabIndex = 0;
            this.showNotificationsTab.Text = "Show Notifications";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.yearsComboBox);
            this.splitContainer2.Panel1.Controls.Add(this.monthsComboBox);
            this.splitContainer2.Panel1.Controls.Add(this.label20);
            this.splitContainer2.Panel1.Controls.Add(this.employeesComboBox);
            this.splitContainer2.Panel1.Controls.Add(this.label19);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(708, 343);
            this.splitContainer2.SplitterDistance = 46;
            this.splitContainer2.TabIndex = 0;
            // 
            // yearsComboBox
            // 
            this.yearsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearsComboBox.FormattingEnabled = true;
            this.yearsComboBox.Location = new System.Drawing.Point(407, 13);
            this.yearsComboBox.Name = "yearsComboBox";
            this.yearsComboBox.Size = new System.Drawing.Size(58, 21);
            this.yearsComboBox.TabIndex = 4;
            this.yearsComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectedIndexChanged);
            // 
            // monthsComboBox
            // 
            this.monthsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthsComboBox.FormattingEnabled = true;
            this.monthsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.monthsComboBox.Location = new System.Drawing.Point(362, 13);
            this.monthsComboBox.Name = "monthsComboBox";
            this.monthsComboBox.Size = new System.Drawing.Size(39, 21);
            this.monthsComboBox.TabIndex = 3;
            this.monthsComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(279, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Month - Year  :";
            // 
            // employeesComboBox
            // 
            this.employeesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeesComboBox.FormattingEnabled = true;
            this.employeesComboBox.Location = new System.Drawing.Point(85, 13);
            this.employeesComboBox.Name = "employeesComboBox";
            this.employeesComboBox.Size = new System.Drawing.Size(144, 21);
            this.employeesComboBox.TabIndex = 1;
            this.employeesComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Employee  :";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.notificationsView);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.totalHourView);
            this.splitContainer3.Size = new System.Drawing.Size(708, 293);
            this.splitContainer3.SplitterDistance = 264;
            this.splitContainer3.TabIndex = 1;
            // 
            // notificationsView
            // 
            this.notificationsView.AllowUserToAddRows = false;
            this.notificationsView.AllowUserToDeleteRows = false;
            this.notificationsView.AllowUserToResizeColumns = false;
            this.notificationsView.AllowUserToResizeRows = false;
            this.notificationsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notificationsView.BackgroundColor = System.Drawing.Color.White;
            this.notificationsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notificationsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationsView.GridColor = System.Drawing.Color.Black;
            this.notificationsView.Location = new System.Drawing.Point(0, 0);
            this.notificationsView.Name = "notificationsView";
            this.notificationsView.ReadOnly = true;
            this.notificationsView.RowHeadersVisible = false;
            this.notificationsView.Size = new System.Drawing.Size(708, 264);
            this.notificationsView.TabIndex = 0;
            this.notificationsView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NotificationViewCellClick);
            // 
            // totalHourView
            // 
            this.totalHourView.AllowUserToAddRows = false;
            this.totalHourView.AllowUserToDeleteRows = false;
            this.totalHourView.AllowUserToResizeColumns = false;
            this.totalHourView.AllowUserToResizeRows = false;
            this.totalHourView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.totalHourView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.totalHourView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.totalHourView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalHourView.ColumnHeadersVisible = false;
            this.totalHourView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalHourView.Enabled = false;
            this.totalHourView.GridColor = System.Drawing.Color.White;
            this.totalHourView.Location = new System.Drawing.Point(0, 0);
            this.totalHourView.MultiSelect = false;
            this.totalHourView.Name = "totalHourView";
            this.totalHourView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.totalHourView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.totalHourView.RowHeadersVisible = false;
            this.totalHourView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            this.totalHourView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.totalHourView.Size = new System.Drawing.Size(708, 25);
            this.totalHourView.TabIndex = 0;
            // 
            // tasksTab
            // 
            this.tasksTab.BackColor = System.Drawing.Color.White;
            this.tasksTab.Controls.Add(this.tabControl5);
            this.tasksTab.Location = new System.Drawing.Point(154, 4);
            this.tasksTab.Name = "tasksTab";
            this.tasksTab.Size = new System.Drawing.Size(722, 375);
            this.tasksTab.TabIndex = 4;
            this.tasksTab.Text = "Tasks";
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.assignTaskTab);
            this.tabControl5.Controls.Add(this.showTasksTab);
            this.tabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl5.Location = new System.Drawing.Point(0, 0);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(722, 375);
            this.tabControl5.TabIndex = 0;
            // 
            // assignTaskTab
            // 
            this.assignTaskTab.BackColor = System.Drawing.Color.White;
            this.assignTaskTab.Controls.Add(this.newTaskSaveButton);
            this.assignTaskTab.Controls.Add(this.newTaskDescBox);
            this.assignTaskTab.Controls.Add(this.label24);
            this.assignTaskTab.Controls.Add(this.newTaskAssignCal);
            this.assignTaskTab.Controls.Add(this.label23);
            this.assignTaskTab.Controls.Add(this.newTaskAssignEmp);
            this.assignTaskTab.Controls.Add(this.label22);
            this.assignTaskTab.Controls.Add(this.newTaskAssignProj);
            this.assignTaskTab.Controls.Add(this.label21);
            this.assignTaskTab.Location = new System.Drawing.Point(4, 22);
            this.assignTaskTab.Name = "assignTaskTab";
            this.assignTaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.assignTaskTab.Size = new System.Drawing.Size(714, 349);
            this.assignTaskTab.TabIndex = 0;
            this.assignTaskTab.Text = "Assign a Task";
            // 
            // newTaskSaveButton
            // 
            this.newTaskSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newTaskSaveButton.Location = new System.Drawing.Point(633, 320);
            this.newTaskSaveButton.Name = "newTaskSaveButton";
            this.newTaskSaveButton.Size = new System.Drawing.Size(75, 23);
            this.newTaskSaveButton.TabIndex = 8;
            this.newTaskSaveButton.Text = "Save";
            this.newTaskSaveButton.UseVisualStyleBackColor = true;
            this.newTaskSaveButton.Click += new System.EventHandler(this.NewTaskSaveButtonClick);
            // 
            // newTaskDescBox
            // 
            this.newTaskDescBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newTaskDescBox.Location = new System.Drawing.Point(273, 250);
            this.newTaskDescBox.Multiline = true;
            this.newTaskDescBox.Name = "newTaskDescBox";
            this.newTaskDescBox.Size = new System.Drawing.Size(232, 68);
            this.newTaskDescBox.TabIndex = 7;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(154, 253);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(114, 13);
            this.label24.TabIndex = 6;
            this.label24.Text = "Description                 :";
            // 
            // newTaskAssignCal
            // 
            this.newTaskAssignCal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newTaskAssignCal.Location = new System.Drawing.Point(271, 84);
            this.newTaskAssignCal.MaxSelectionCount = 1;
            this.newTaskAssignCal.Name = "newTaskAssignCal";
            this.newTaskAssignCal.ShowToday = false;
            this.newTaskAssignCal.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(150, 89);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(118, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "Assign Date                 :";
            // 
            // newTaskAssignEmp
            // 
            this.newTaskAssignEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newTaskAssignEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newTaskAssignEmp.FormattingEnabled = true;
            this.newTaskAssignEmp.Location = new System.Drawing.Point(273, 56);
            this.newTaskAssignEmp.Name = "newTaskAssignEmp";
            this.newTaskAssignEmp.Size = new System.Drawing.Size(232, 21);
            this.newTaskAssignEmp.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(150, 59);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(117, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Employee to Assign     :";
            // 
            // newTaskAssignProj
            // 
            this.newTaskAssignProj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newTaskAssignProj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newTaskAssignProj.FormattingEnabled = true;
            this.newTaskAssignProj.Location = new System.Drawing.Point(273, 27);
            this.newTaskAssignProj.Name = "newTaskAssignProj";
            this.newTaskAssignProj.Size = new System.Drawing.Size(232, 21);
            this.newTaskAssignProj.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(150, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(115, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Project                        :";
            // 
            // showTasksTab
            // 
            this.showTasksTab.BackColor = System.Drawing.Color.White;
            this.showTasksTab.Controls.Add(this.splitContainer4);
            this.showTasksTab.Location = new System.Drawing.Point(4, 22);
            this.showTasksTab.Name = "showTasksTab";
            this.showTasksTab.Padding = new System.Windows.Forms.Padding(3);
            this.showTasksTab.Size = new System.Drawing.Size(714, 349);
            this.showTasksTab.TabIndex = 1;
            this.showTasksTab.Text = "Show Assigned Tasks";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.showTaskEmployeesList);
            this.splitContainer4.Panel1.Controls.Add(this.label26);
            this.splitContainer4.Panel1.Controls.Add(this.showTasksProjectList);
            this.splitContainer4.Panel1.Controls.Add(this.label25);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.showTasksView);
            this.splitContainer4.Size = new System.Drawing.Size(708, 343);
            this.splitContainer4.SplitterDistance = 39;
            this.splitContainer4.TabIndex = 0;
            // 
            // showTaskEmployeesList
            // 
            this.showTaskEmployeesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showTaskEmployeesList.FormattingEnabled = true;
            this.showTaskEmployeesList.Location = new System.Drawing.Point(309, 8);
            this.showTaskEmployeesList.Name = "showTaskEmployeesList";
            this.showTaskEmployeesList.Size = new System.Drawing.Size(121, 21);
            this.showTaskEmployeesList.TabIndex = 3;
            this.showTaskEmployeesList.SelectedIndexChanged += new System.EventHandler(this.ShowTasksComboBoxSelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(241, 11);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(62, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Employee  :";
            // 
            // showTasksProjectList
            // 
            this.showTasksProjectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showTasksProjectList.FormattingEnabled = true;
            this.showTasksProjectList.Location = new System.Drawing.Point(85, 8);
            this.showTasksProjectList.Name = "showTasksProjectList";
            this.showTasksProjectList.Size = new System.Drawing.Size(121, 21);
            this.showTasksProjectList.TabIndex = 1;
            this.showTasksProjectList.SelectedIndexChanged += new System.EventHandler(this.ShowTasksComboBoxSelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(30, 11);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Project  :";
            // 
            // showTasksView
            // 
            this.showTasksView.AllowUserToAddRows = false;
            this.showTasksView.AllowUserToDeleteRows = false;
            this.showTasksView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showTasksView.BackgroundColor = System.Drawing.Color.White;
            this.showTasksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showTasksView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showTasksView.GridColor = System.Drawing.Color.Black;
            this.showTasksView.Location = new System.Drawing.Point(0, 0);
            this.showTasksView.Name = "showTasksView";
            this.showTasksView.ReadOnly = true;
            this.showTasksView.Size = new System.Drawing.Size(708, 300);
            this.showTasksView.TabIndex = 1;
            this.showTasksView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowTasksViewCellClick);
            // 
            // assignManagersTab
            // 
            this.assignManagersTab.BackColor = System.Drawing.Color.White;
            this.assignManagersTab.Controls.Add(this.tabControl6);
            this.assignManagersTab.Location = new System.Drawing.Point(154, 4);
            this.assignManagersTab.Name = "assignManagersTab";
            this.assignManagersTab.Size = new System.Drawing.Size(722, 375);
            this.assignManagersTab.TabIndex = 5;
            this.assignManagersTab.Text = "Assign Managers";
            // 
            // tabControl6
            // 
            this.tabControl6.Controls.Add(this.systemManagersTab);
            this.tabControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl6.Location = new System.Drawing.Point(0, 0);
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            this.tabControl6.Size = new System.Drawing.Size(722, 375);
            this.tabControl6.TabIndex = 0;
            // 
            // systemManagersTab
            // 
            this.systemManagersTab.BackColor = System.Drawing.Color.White;
            this.systemManagersTab.Controls.Add(this.demoteButton);
            this.systemManagersTab.Controls.Add(this.makeManagerButton);
            this.systemManagersTab.Controls.Add(this.adminsList);
            this.systemManagersTab.Controls.Add(this.label29);
            this.systemManagersTab.Controls.Add(this.label28);
            this.systemManagersTab.Controls.Add(this.normalUsersList);
            this.systemManagersTab.Controls.Add(this.filterUsers);
            this.systemManagersTab.Controls.Add(this.label27);
            this.systemManagersTab.Location = new System.Drawing.Point(4, 22);
            this.systemManagersTab.Name = "systemManagersTab";
            this.systemManagersTab.Padding = new System.Windows.Forms.Padding(3);
            this.systemManagersTab.Size = new System.Drawing.Size(714, 349);
            this.systemManagersTab.TabIndex = 1;
            this.systemManagersTab.Text = "System Managers";
            // 
            // demoteButton
            // 
            this.demoteButton.Location = new System.Drawing.Point(341, 198);
            this.demoteButton.Name = "demoteButton";
            this.demoteButton.Size = new System.Drawing.Size(38, 23);
            this.demoteButton.TabIndex = 7;
            this.demoteButton.Text = "<<<";
            this.demoteButton.UseVisualStyleBackColor = true;
            this.demoteButton.Click += new System.EventHandler(this.DemoteButtonClick);
            // 
            // makeManagerButton
            // 
            this.makeManagerButton.Location = new System.Drawing.Point(341, 169);
            this.makeManagerButton.Name = "makeManagerButton";
            this.makeManagerButton.Size = new System.Drawing.Size(38, 23);
            this.makeManagerButton.TabIndex = 6;
            this.makeManagerButton.Text = ">>>";
            this.makeManagerButton.UseVisualStyleBackColor = true;
            this.makeManagerButton.Click += new System.EventHandler(this.MakeManagerButtonClick);
            // 
            // adminsList
            // 
            this.adminsList.FormattingEnabled = true;
            this.adminsList.Location = new System.Drawing.Point(415, 108);
            this.adminsList.Name = "adminsList";
            this.adminsList.Size = new System.Drawing.Size(123, 173);
            this.adminsList.TabIndex = 5;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(361, 72);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(177, 13);
            this.label29.TabIndex = 4;
            this.label29.Text = "Users with administrator clearance  :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(127, 42);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(85, 13);
            this.label28.TabIndex = 3;
            this.label28.Text = "Users in System:";
            // 
            // normalUsersList
            // 
            this.normalUsersList.FormattingEnabled = true;
            this.normalUsersList.Location = new System.Drawing.Point(180, 108);
            this.normalUsersList.Name = "normalUsersList";
            this.normalUsersList.Size = new System.Drawing.Size(123, 173);
            this.normalUsersList.TabIndex = 2;
            // 
            // filterUsers
            // 
            this.filterUsers.Location = new System.Drawing.Point(180, 69);
            this.filterUsers.Name = "filterUsers";
            this.filterUsers.Size = new System.Drawing.Size(123, 20);
            this.filterUsers.TabIndex = 1;
            this.filterUsers.TextChanged += new System.EventHandler(this.FilterBoxTextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(127, 72);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "Filter     :";
            // 
            // analyzeTab
            // 
            this.analyzeTab.BackColor = System.Drawing.Color.White;
            this.analyzeTab.Controls.Add(this.analyzeView);
            this.analyzeTab.Location = new System.Drawing.Point(154, 4);
            this.analyzeTab.Name = "analyzeTab";
            this.analyzeTab.Padding = new System.Windows.Forms.Padding(3);
            this.analyzeTab.Size = new System.Drawing.Size(722, 375);
            this.analyzeTab.TabIndex = 6;
            this.analyzeTab.Text = "Analyze";
            // 
            // analyzeView
            // 
            this.analyzeView.AllowUserToAddRows = false;
            this.analyzeView.AllowUserToDeleteRows = false;
            this.analyzeView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.analyzeView.BackgroundColor = System.Drawing.Color.White;
            this.analyzeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.analyzeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectName,
            this.totalWorkedHour});
            this.analyzeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analyzeView.GridColor = System.Drawing.Color.Black;
            this.analyzeView.Location = new System.Drawing.Point(3, 3);
            this.analyzeView.Name = "analyzeView";
            this.analyzeView.ReadOnly = true;
            this.analyzeView.Size = new System.Drawing.Size(716, 369);
            this.analyzeView.TabIndex = 2;
            // 
            // projectName
            // 
            this.projectName.HeaderText = "Project Name";
            this.projectName.Name = "projectName";
            this.projectName.ReadOnly = true;
            // 
            // totalWorkedHour
            // 
            this.totalWorkedHour.HeaderText = "Total Worked Hour";
            this.totalWorkedHour.Name = "totalWorkedHour";
            this.totalWorkedHour.ReadOnly = true;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 506);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(896, 544);
            this.Name = "AdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.adminTabs.ResumeLayout(false);
            this.personalInfoTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.editInfo.ResumeLayout(false);
            this.editInfo.PerformLayout();
            this.loginInfo.ResumeLayout(false);
            this.loginInfo.PerformLayout();
            this.projectsTab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.viewProjectsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectList)).EndInit();
            this.createNewProjectTab.ResumeLayout(false);
            this.createNewProjectTab.PerformLayout();
            this.employeeTab.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.registeredEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employees)).EndInit();
            this.createNewEmployee.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.removeEmployee.ResumeLayout(false);
            this.removeEmployee.PerformLayout();
            this.notificationsTab.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.showNotificationsTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notificationsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalHourView)).EndInit();
            this.tasksTab.ResumeLayout(false);
            this.tabControl5.ResumeLayout(false);
            this.assignTaskTab.ResumeLayout(false);
            this.assignTaskTab.PerformLayout();
            this.showTasksTab.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showTasksView)).EndInit();
            this.assignManagersTab.ResumeLayout(false);
            this.tabControl6.ResumeLayout(false);
            this.systemManagersTab.ResumeLayout(false);
            this.systemManagersTab.PerformLayout();
            this.analyzeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.analyzeView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TabControl adminTabs;
        private System.Windows.Forms.TabPage personalInfoTab;
        private System.Windows.Forms.TabPage projectsTab;
        private System.Windows.Forms.TabPage employeeTab;
        private System.Windows.Forms.TabPage notificationsTab;
        private System.Windows.Forms.TabPage assignManagersTab;
        private System.Windows.Forms.Label loginStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage editInfo;
        private System.Windows.Forms.TabPage loginInfo;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox birthDayBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button editInfoSave;
        private System.Windows.Forms.TextBox passwordAgain;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button loginInfoSave;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage viewProjectsTab;
        private System.Windows.Forms.TabPage createNewProjectTab;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage registeredEmployee;
        private System.Windows.Forms.TabPage createNewEmployee;
        private System.Windows.Forms.TabPage removeEmployee;
        private System.Windows.Forms.DataGridView employees;
        private System.Windows.Forms.TextBox createNewUserNameBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox createNewEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox createNewPassAgain;
        private System.Windows.Forms.TextBox createPasswordBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button createNewSaveButton;
        private System.Windows.Forms.Button removeEmployeeButton;
        private System.Windows.Forms.ComboBox employeeList;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button newProjectCancelButton;
        private System.Windows.Forms.Button newProjectSaveButton;
        private System.Windows.Forms.TextBox newProjectDescBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox newProjectNameBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView projectList;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage showNotificationsTab;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox employeesComboBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView notificationsView;
        private System.Windows.Forms.ComboBox yearsComboBox;
        private System.Windows.Forms.ComboBox monthsComboBox;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView totalHourView;
        private System.Windows.Forms.TabPage tasksTab;
        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabPage assignTaskTab;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox newTaskAssignEmp;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox newTaskAssignProj;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage showTasksTab;
        private System.Windows.Forms.TextBox newTaskDescBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.MonthCalendar newTaskAssignCal;
        private System.Windows.Forms.Button newTaskSaveButton;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ComboBox showTaskEmployeesList;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox showTasksProjectList;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView showTasksView;
        private System.Windows.Forms.TabControl tabControl6;
        private System.Windows.Forms.TabPage systemManagersTab;
        private System.Windows.Forms.Button demoteButton;
        private System.Windows.Forms.Button makeManagerButton;
        private System.Windows.Forms.ListBox adminsList;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ListBox normalUsersList;
        private System.Windows.Forms.TextBox filterUsers;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage analyzeTab;
        private System.Windows.Forms.DataGridView analyzeView;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWorkedHour;
    }
}