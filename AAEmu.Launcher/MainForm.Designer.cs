﻿namespace AAEmu.Launcher
{
    partial class LauncherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
            this.eLogin = new System.Windows.Forms.TextBox();
            this.ePassword = new System.Windows.Forms.TextBox();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.timerGeneral = new System.Windows.Forms.Timer(this.components);
            this.pb2 = new System.Windows.Forms.ProgressBar();
            this.eServerIP = new System.Windows.Forms.TextBox();
            this.lPathToGameLabel = new System.Windows.Forms.Label();
            this.cbLoginList = new System.Windows.Forms.ComboBox();
            this.lAppVersion = new System.Windows.Forms.Label();
            this.lLogin = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.cmsAAEmuButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lSettingsBack = new System.Windows.Forms.Label();
            this.lIPAddress = new System.Windows.Forms.Label();
            this.lGamePath = new System.Windows.Forms.Label();
            this.lHideSplash = new System.Windows.Forms.Label();
            this.cbHideSplash = new System.Windows.Forms.Label();
            this.cbSkipIntro = new System.Windows.Forms.Label();
            this.lSkipIntro = new System.Windows.Forms.Label();
            this.cbSaveUser = new System.Windows.Forms.Label();
            this.lSaveUser = new System.Windows.Forms.Label();
            this.cbUseDebugMode = new System.Windows.Forms.CheckBox();
            this.lGameClientType = new System.Windows.Forms.Label();
            this.cbUpdateLocale = new System.Windows.Forms.Label();
            this.lUpdateLocale = new System.Windows.Forms.Label();
            this.cbLocaleSelect = new System.Windows.Forms.ComboBox();
            this.cbAllowUpdates = new System.Windows.Forms.Label();
            this.lAllowUpdates = new System.Windows.Forms.Label();
            this.cmsGitHub = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aAEmuServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aAEmuLauncherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lLoadedConfig = new System.Windows.Forms.Label();
            this.btnSystem = new System.Windows.Forms.PictureBox();
            this.btnWebsite = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Label();
            this.lNewsFeed = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Label();
            this.btnDiscord = new System.Windows.Forms.PictureBox();
            this.btnGithub = new System.Windows.Forms.PictureBox();
            this.btnLangChange = new System.Windows.Forms.PictureBox();
            this.imgBigNews = new System.Windows.Forms.PictureBox();
            this.cmsLanguage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAAEmuButton.SuspendLayout();
            this.cmsGitHub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDiscord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLangChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBigNews)).BeginInit();
            this.cmsLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // eLogin
            // 
            this.eLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.eLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eLogin.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eLogin.ForeColor = System.Drawing.Color.White;
            this.eLogin.Location = new System.Drawing.Point(58, 398);
            this.eLogin.Name = "eLogin";
            this.eLogin.Size = new System.Drawing.Size(210, 22);
            this.eLogin.TabIndex = 1;
            this.eLogin.Text = "test";
            this.eLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eLogin.Visible = false;
            this.eLogin.WordWrap = false;
            this.eLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLogin_KeyUp);
            // 
            // ePassword
            // 
            this.ePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.ePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ePassword.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ePassword.ForeColor = System.Drawing.Color.White;
            this.ePassword.Location = new System.Drawing.Point(303, 396);
            this.ePassword.Name = "ePassword";
            this.ePassword.PasswordChar = '●';
            this.ePassword.Size = new System.Drawing.Size(227, 22);
            this.ePassword.TabIndex = 2;
            this.ePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ePassword.UseSystemPasswordChar = true;
            this.ePassword.Visible = false;
            this.ePassword.WordWrap = false;
            this.ePassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(16, 29);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(277, 13);
            this.pb1.TabIndex = 3;
            this.pb1.Visible = false;
            // 
            // timerGeneral
            // 
            this.timerGeneral.Enabled = true;
            this.timerGeneral.Interval = 250;
            this.timerGeneral.Tick += new System.EventHandler(this.timerGeneral_Tick);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(16, 48);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(276, 9);
            this.pb2.TabIndex = 4;
            this.pb2.Visible = false;
            // 
            // eServerIP
            // 
            this.eServerIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.eServerIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eServerIP.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eServerIP.ForeColor = System.Drawing.Color.White;
            this.eServerIP.Location = new System.Drawing.Point(25, 172);
            this.eServerIP.Margin = new System.Windows.Forms.Padding(0);
            this.eServerIP.Name = "eServerIP";
            this.eServerIP.Size = new System.Drawing.Size(222, 24);
            this.eServerIP.TabIndex = 5;
            this.eServerIP.Text = "127.0.0.1";
            this.eServerIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lPathToGameLabel
            // 
            this.lPathToGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lPathToGameLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPathToGameLabel.ForeColor = System.Drawing.Color.White;
            this.lPathToGameLabel.Location = new System.Drawing.Point(22, 230);
            this.lPathToGameLabel.Name = "lPathToGameLabel";
            this.lPathToGameLabel.Size = new System.Drawing.Size(155, 20);
            this.lPathToGameLabel.TabIndex = 2;
            this.lPathToGameLabel.Text = "gamepath";
            this.lPathToGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbLoginList
            // 
            this.cbLoginList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.cbLoginList.DropDownHeight = 140;
            this.cbLoginList.DropDownWidth = 200;
            this.cbLoginList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLoginList.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoginList.ForeColor = System.Drawing.Color.White;
            this.cbLoginList.FormattingEnabled = true;
            this.cbLoginList.IntegralHeight = false;
            this.cbLoginList.Location = new System.Drawing.Point(39, 397);
            this.cbLoginList.Name = "cbLoginList";
            this.cbLoginList.Size = new System.Drawing.Size(18, 24);
            this.cbLoginList.TabIndex = 15;
            this.cbLoginList.Visible = false;
            this.cbLoginList.SelectedIndexChanged += new System.EventHandler(this.cbLoginList_SelectedIndexChanged);
            this.cbLoginList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLogin_KeyUp);
            // 
            // lAppVersion
            // 
            this.lAppVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lAppVersion.BackColor = System.Drawing.Color.Transparent;
            this.lAppVersion.ForeColor = System.Drawing.Color.White;
            this.lAppVersion.Location = new System.Drawing.Point(835, 480);
            this.lAppVersion.Name = "lAppVersion";
            this.lAppVersion.Size = new System.Drawing.Size(110, 21);
            this.lAppVersion.TabIndex = 17;
            this.lAppVersion.Text = "AAEmu 2019";
            this.lAppVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lLogin
            // 
            this.lLogin.BackColor = System.Drawing.Color.Transparent;
            this.lLogin.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLogin.ForeColor = System.Drawing.Color.White;
            this.lLogin.Location = new System.Drawing.Point(36, 360);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(110, 25);
            this.lLogin.TabIndex = 18;
            this.lLogin.Text = "Username";
            this.lLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lPassword
            // 
            this.lPassword.BackColor = System.Drawing.Color.Transparent;
            this.lPassword.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassword.ForeColor = System.Drawing.Color.White;
            this.lPassword.Location = new System.Drawing.Point(300, 360);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(110, 25);
            this.lPassword.TabIndex = 19;
            this.lPassword.Text = "Password";
            this.lPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmsAAEmuButton
            // 
            this.cmsAAEmuButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.cmsAAEmuButton.Name = "cmsAAEmuButton";
            this.cmsAAEmuButton.Size = new System.Drawing.Size(124, 48);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lSettingsBack
            // 
            this.lSettingsBack.BackColor = System.Drawing.Color.Transparent;
            this.lSettingsBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lSettingsBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lSettingsBack.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSettingsBack.ForeColor = System.Drawing.Color.White;
            this.lSettingsBack.Location = new System.Drawing.Point(12, 356);
            this.lSettingsBack.Name = "lSettingsBack";
            this.lSettingsBack.Size = new System.Drawing.Size(165, 36);
            this.lSettingsBack.TabIndex = 29;
            this.lSettingsBack.Text = "Back";
            this.lSettingsBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lSettingsBack.Click += new System.EventHandler(this.lSettingsBack_Click);
            // 
            // lIPAddress
            // 
            this.lIPAddress.BackColor = System.Drawing.Color.Transparent;
            this.lIPAddress.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIPAddress.ForeColor = System.Drawing.Color.White;
            this.lIPAddress.Location = new System.Drawing.Point(22, 138);
            this.lIPAddress.Name = "lIPAddress";
            this.lIPAddress.Size = new System.Drawing.Size(155, 24);
            this.lIPAddress.TabIndex = 0;
            this.lIPAddress.Text = "Server";
            this.lIPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lGamePath
            // 
            this.lGamePath.AutoEllipsis = true;
            this.lGamePath.BackColor = System.Drawing.Color.Transparent;
            this.lGamePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lGamePath.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGamePath.ForeColor = System.Drawing.Color.White;
            this.lGamePath.Location = new System.Drawing.Point(24, 265);
            this.lGamePath.Name = "lGamePath";
            this.lGamePath.Size = new System.Drawing.Size(223, 20);
            this.lGamePath.TabIndex = 30;
            this.lGamePath.Text = "C:\\ArcheAge\\Working\\Bin32\\archeage.exe";
            this.lGamePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lGamePath.UseMnemonic = false;
            this.lGamePath.Click += new System.EventHandler(this.lGamePath_Click);
            // 
            // lHideSplash
            // 
            this.lHideSplash.BackColor = System.Drawing.Color.Transparent;
            this.lHideSplash.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHideSplash.ForeColor = System.Drawing.Color.White;
            this.lHideSplash.Location = new System.Drawing.Point(300, 240);
            this.lHideSplash.Name = "lHideSplash";
            this.lHideSplash.Size = new System.Drawing.Size(145, 30);
            this.lHideSplash.TabIndex = 31;
            this.lHideSplash.Text = "Hide Splash";
            this.lHideSplash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lHideSplash.Click += new System.EventHandler(this.cbHideSplash_Click);
            // 
            // cbHideSplash
            // 
            this.cbHideSplash.BackColor = System.Drawing.Color.Transparent;
            this.cbHideSplash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbHideSplash.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHideSplash.ForeColor = System.Drawing.Color.White;
            this.cbHideSplash.Location = new System.Drawing.Point(450, 240);
            this.cbHideSplash.Name = "cbHideSplash";
            this.cbHideSplash.Size = new System.Drawing.Size(31, 24);
            this.cbHideSplash.TabIndex = 32;
            this.cbHideSplash.Text = "✓";
            this.cbHideSplash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbHideSplash.Click += new System.EventHandler(this.cbHideSplash_Click);
            // 
            // cbSkipIntro
            // 
            this.cbSkipIntro.BackColor = System.Drawing.Color.Transparent;
            this.cbSkipIntro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSkipIntro.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSkipIntro.ForeColor = System.Drawing.Color.White;
            this.cbSkipIntro.Location = new System.Drawing.Point(450, 290);
            this.cbSkipIntro.Name = "cbSkipIntro";
            this.cbSkipIntro.Size = new System.Drawing.Size(31, 24);
            this.cbSkipIntro.TabIndex = 34;
            this.cbSkipIntro.Text = "✓";
            this.cbSkipIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbSkipIntro.Click += new System.EventHandler(this.cbSkipIntro_Click);
            // 
            // lSkipIntro
            // 
            this.lSkipIntro.BackColor = System.Drawing.Color.Transparent;
            this.lSkipIntro.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSkipIntro.ForeColor = System.Drawing.Color.White;
            this.lSkipIntro.Location = new System.Drawing.Point(300, 290);
            this.lSkipIntro.Name = "lSkipIntro";
            this.lSkipIntro.Size = new System.Drawing.Size(145, 30);
            this.lSkipIntro.TabIndex = 33;
            this.lSkipIntro.Text = "Skip Intro";
            this.lSkipIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lSkipIntro.Click += new System.EventHandler(this.cbSkipIntro_Click);
            // 
            // cbSaveUser
            // 
            this.cbSaveUser.BackColor = System.Drawing.Color.Transparent;
            this.cbSaveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSaveUser.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSaveUser.ForeColor = System.Drawing.Color.White;
            this.cbSaveUser.Location = new System.Drawing.Point(450, 140);
            this.cbSaveUser.Name = "cbSaveUser";
            this.cbSaveUser.Size = new System.Drawing.Size(31, 24);
            this.cbSaveUser.TabIndex = 36;
            this.cbSaveUser.Text = "✓";
            this.cbSaveUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbSaveUser.Click += new System.EventHandler(this.cbSaveUser_Click);
            // 
            // lSaveUser
            // 
            this.lSaveUser.BackColor = System.Drawing.Color.Transparent;
            this.lSaveUser.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSaveUser.ForeColor = System.Drawing.Color.White;
            this.lSaveUser.Location = new System.Drawing.Point(300, 140);
            this.lSaveUser.Name = "lSaveUser";
            this.lSaveUser.Size = new System.Drawing.Size(145, 30);
            this.lSaveUser.TabIndex = 35;
            this.lSaveUser.Text = "Save credentials";
            this.lSaveUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lSaveUser.Click += new System.EventHandler(this.cbSaveUser_Click);
            // 
            // cbUseDebugMode
            // 
            this.cbUseDebugMode.AutoSize = true;
            this.cbUseDebugMode.BackColor = System.Drawing.Color.Transparent;
            this.cbUseDebugMode.ForeColor = System.Drawing.Color.Red;
            this.cbUseDebugMode.Location = new System.Drawing.Point(699, 7);
            this.cbUseDebugMode.Name = "cbUseDebugMode";
            this.cbUseDebugMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbUseDebugMode.Size = new System.Drawing.Size(130, 22);
            this.cbUseDebugMode.TabIndex = 37;
            this.cbUseDebugMode.Text = "\"Debug Mode\"";
            this.cbUseDebugMode.UseVisualStyleBackColor = false;
            // 
            // lGameClientType
            // 
            this.lGameClientType.AutoSize = true;
            this.lGameClientType.BackColor = System.Drawing.Color.Transparent;
            this.lGameClientType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lGameClientType.ForeColor = System.Drawing.Color.White;
            this.lGameClientType.Location = new System.Drawing.Point(24, 302);
            this.lGameClientType.Name = "lGameClientType";
            this.lGameClientType.Size = new System.Drawing.Size(104, 18);
            this.lGameClientType.TabIndex = 39;
            this.lGameClientType.Text = "-Client Type-";
            this.lGameClientType.Click += new System.EventHandler(this.lGameClientType_Click);
            // 
            // cbUpdateLocale
            // 
            this.cbUpdateLocale.BackColor = System.Drawing.Color.Transparent;
            this.cbUpdateLocale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbUpdateLocale.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdateLocale.ForeColor = System.Drawing.Color.White;
            this.cbUpdateLocale.Location = new System.Drawing.Point(450, 190);
            this.cbUpdateLocale.Name = "cbUpdateLocale";
            this.cbUpdateLocale.Size = new System.Drawing.Size(31, 24);
            this.cbUpdateLocale.TabIndex = 41;
            this.cbUpdateLocale.Text = "✓";
            this.cbUpdateLocale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbUpdateLocale.Click += new System.EventHandler(this.cbUpdateLocale_Click);
            // 
            // lUpdateLocale
            // 
            this.lUpdateLocale.BackColor = System.Drawing.Color.Transparent;
            this.lUpdateLocale.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUpdateLocale.ForeColor = System.Drawing.Color.White;
            this.lUpdateLocale.Location = new System.Drawing.Point(300, 190);
            this.lUpdateLocale.Name = "lUpdateLocale";
            this.lUpdateLocale.Size = new System.Drawing.Size(145, 30);
            this.lUpdateLocale.TabIndex = 40;
            this.lUpdateLocale.Text = "Update Locale";
            this.lUpdateLocale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lUpdateLocale.Click += new System.EventHandler(this.cbUpdateLocale_Click);
            // 
            // cbLocaleSelect
            // 
            this.cbLocaleSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbLocaleSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLocaleSelect.BackColor = System.Drawing.Color.White;
            this.cbLocaleSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocaleSelect.ForeColor = System.Drawing.Color.Black;
            this.cbLocaleSelect.FormattingEnabled = true;
            this.cbLocaleSelect.Items.AddRange(new object[] {
            "de",
            "en_us",
            "fr",
            "ja",
            "ko",
            "ru",
            "zh_cn",
            "zh_tw"});
            this.cbLocaleSelect.Location = new System.Drawing.Point(586, 7);
            this.cbLocaleSelect.Name = "cbLocaleSelect";
            this.cbLocaleSelect.Size = new System.Drawing.Size(107, 26);
            this.cbLocaleSelect.Sorted = true;
            this.cbLocaleSelect.TabIndex = 42;
            this.cbLocaleSelect.Visible = false;
            this.cbLocaleSelect.SelectedIndexChanged += new System.EventHandler(this.cbLocaleSelect_SelectedIndexChanged);
            // 
            // cbAllowUpdates
            // 
            this.cbAllowUpdates.BackColor = System.Drawing.Color.Transparent;
            this.cbAllowUpdates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAllowUpdates.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllowUpdates.ForeColor = System.Drawing.Color.Gray;
            this.cbAllowUpdates.Location = new System.Drawing.Point(450, 340);
            this.cbAllowUpdates.Name = "cbAllowUpdates";
            this.cbAllowUpdates.Size = new System.Drawing.Size(31, 24);
            this.cbAllowUpdates.TabIndex = 44;
            this.cbAllowUpdates.Text = "✓";
            this.cbAllowUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAllowUpdates.Visible = false;
            this.cbAllowUpdates.Click += new System.EventHandler(this.cbAllowUpdates_Click);
            // 
            // lAllowUpdates
            // 
            this.lAllowUpdates.BackColor = System.Drawing.Color.Transparent;
            this.lAllowUpdates.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAllowUpdates.ForeColor = System.Drawing.Color.Gray;
            this.lAllowUpdates.Location = new System.Drawing.Point(300, 340);
            this.lAllowUpdates.Name = "lAllowUpdates";
            this.lAllowUpdates.Size = new System.Drawing.Size(145, 30);
            this.lAllowUpdates.TabIndex = 43;
            this.lAllowUpdates.Text = "Allow Updates";
            this.lAllowUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lAllowUpdates.Visible = false;
            this.lAllowUpdates.Click += new System.EventHandler(this.cbAllowUpdates_Click);
            // 
            // cmsGitHub
            // 
            this.cmsGitHub.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aAEmuServerToolStripMenuItem,
            this.aAEmuLauncherToolStripMenuItem});
            this.cmsGitHub.Name = "cmsGitHub";
            this.cmsGitHub.Size = new System.Drawing.Size(167, 48);
            // 
            // aAEmuServerToolStripMenuItem
            // 
            this.aAEmuServerToolStripMenuItem.Name = "aAEmuServerToolStripMenuItem";
            this.aAEmuServerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aAEmuServerToolStripMenuItem.Text = "AAEmu Server";
            this.aAEmuServerToolStripMenuItem.Click += new System.EventHandler(this.aAEmuServerToolStripMenuItem_Click);
            // 
            // aAEmuLauncherToolStripMenuItem
            // 
            this.aAEmuLauncherToolStripMenuItem.Name = "aAEmuLauncherToolStripMenuItem";
            this.aAEmuLauncherToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aAEmuLauncherToolStripMenuItem.Text = "AAEmu Launcher";
            this.aAEmuLauncherToolStripMenuItem.Click += new System.EventHandler(this.aAEmuLauncherToolStripMenuItem_Click);
            // 
            // lLoadedConfig
            // 
            this.lLoadedConfig.AutoSize = true;
            this.lLoadedConfig.BackColor = System.Drawing.Color.Transparent;
            this.lLoadedConfig.Location = new System.Drawing.Point(14, 7);
            this.lLoadedConfig.Name = "lLoadedConfig";
            this.lLoadedConfig.Size = new System.Drawing.Size(190, 18);
            this.lLoadedConfig.TabIndex = 46;
            this.lLoadedConfig.Text = "Loaded Server Config File";
            // 
            // btnSystem
            // 
            this.btnSystem.BackColor = System.Drawing.Color.Transparent;
            this.btnSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSystem.ContextMenuStrip = this.cmsAAEmuButton;
            this.btnSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSystem.Image = global::AAEmu.Launcher.Properties.Resources.aaemu_logo ;
            this.btnSystem.Location = new System.Drawing.Point(898, 2);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(40, 40);
            this.btnSystem.TabIndex = 28;
            this.btnSystem.TabStop = false;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // btnWebsite
            // 
            this.btnWebsite.BackColor = System.Drawing.Color.Transparent;
            this.btnWebsite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWebsite.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWebsite.ForeColor = System.Drawing.Color.White;
            this.btnWebsite.Image = global::AAEmu.Launcher.Properties.Resources.btn_green_small;
            this.btnWebsite.Location = new System.Drawing.Point(796, 350);
            this.btnWebsite.Name = "btnWebsite";
            this.btnWebsite.Size = new System.Drawing.Size(94, 26);
            this.btnWebsite.TabIndex = 26;
            this.btnWebsite.Text = "Website";
            this.btnWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWebsite.Click += new System.EventHandler(this.btnWebsite_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::AAEmu.Launcher.Properties.Resources.btn_red_small;
            this.btnSettings.Location = new System.Drawing.Point(687, 350);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(88, 26);
            this.btnSettings.TabIndex = 25;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lNewsFeed
            // 
            this.lNewsFeed.BackColor = System.Drawing.Color.Transparent;
            this.lNewsFeed.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNewsFeed.ForeColor = System.Drawing.Color.White;
            this.lNewsFeed.Image = global::AAEmu.Launcher.Properties.Resources.bg_newsfeed;
            this.lNewsFeed.Location = new System.Drawing.Point(685, 85);
            this.lNewsFeed.Margin = new System.Windows.Forms.Padding(0);
            this.lNewsFeed.Name = "lNewsFeed";
            this.lNewsFeed.Size = new System.Drawing.Size(201, 263);
            this.lNewsFeed.TabIndex = 24;
            this.lNewsFeed.Text = "Launcher News\r\n\r\nNow able to launch the\r\ngame using -t\r\n\r\n\r\nHead 3\r\ntext 3\r\n\r\nHea" +
    "d 4\r\ntext 4\r\n\r\n";
            this.lNewsFeed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Image = global::AAEmu.Launcher.Properties.Resources.btn_green_d;
            this.btnPlay.Location = new System.Drawing.Point(679, 373);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(227, 67);
            this.btnPlay.TabIndex = 23;
            this.btnPlay.Text = "Play";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseEnter += new System.EventHandler(this.btnPlay_MouseEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            // 
            // btnDiscord
            // 
            this.btnDiscord.BackColor = System.Drawing.Color.Transparent;
            this.btnDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscord.Image = global::AAEmu.Launcher.Properties.Resources.Discord_Logo_Only;
            this.btnDiscord.Location = new System.Drawing.Point(789, 461);
            this.btnDiscord.Name = "btnDiscord";
            this.btnDiscord.Size = new System.Drawing.Size(40, 40);
            this.btnDiscord.TabIndex = 12;
            this.btnDiscord.TabStop = false;
            this.btnDiscord.Click += new System.EventHandler(this.PicButDiscord_Click);
            this.btnDiscord.MouseEnter += new System.EventHandler(this.PicButDiscord_MouseEnter);
            this.btnDiscord.MouseLeave += new System.EventHandler(this.PicButDiscord_MouseLeave);
            // 
            // btnGithub
            // 
            this.btnGithub.BackColor = System.Drawing.Color.Transparent;
            this.btnGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGithub.Image = ((System.Drawing.Image)(resources.GetObject("btnGithub.Image")));
            this.btnGithub.Location = new System.Drawing.Point(743, 461);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(40, 40);
            this.btnGithub.TabIndex = 11;
            this.btnGithub.TabStop = false;
            this.btnGithub.Click += new System.EventHandler(this.PicButGithub_Click);
            this.btnGithub.MouseEnter += new System.EventHandler(this.PicButGithub_MouseEnter);
            this.btnGithub.MouseLeave += new System.EventHandler(this.PicButGithub_MouseLeave);
            // 
            // btnLangChange
            // 
            this.btnLangChange.BackColor = System.Drawing.Color.Transparent;
            this.btnLangChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLangChange.Image = global::AAEmu.Launcher.Properties.Resources.flag_english;
            this.btnLangChange.Location = new System.Drawing.Point(850, 2);
            this.btnLangChange.Name = "btnLangChange";
            this.btnLangChange.Size = new System.Drawing.Size(40, 40);
            this.btnLangChange.TabIndex = 8;
            this.btnLangChange.TabStop = false;
            this.btnLangChange.Click += new System.EventHandler(this.btnLangChange_Click);
            // 
            // imgBigNews
            // 
            this.imgBigNews.BackColor = System.Drawing.Color.Transparent;
            this.imgBigNews.Image = ((System.Drawing.Image)(resources.GetObject("imgBigNews.Image")));
            this.imgBigNews.Location = new System.Drawing.Point(25, 85);
            this.imgBigNews.Name = "imgBigNews";
            this.imgBigNews.Size = new System.Drawing.Size(243, 24);
            this.imgBigNews.TabIndex = 27;
            this.imgBigNews.TabStop = false;
            this.imgBigNews.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LauncherForm_MouseDown);
            this.imgBigNews.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LauncherForm_MouseMove);
            this.imgBigNews.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LauncherForm_MouseUp);
            // 
            // cmsLanguage
            // 
            this.cmsLanguage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.russianToolStripMenuItem,
            this.germanToolStripMenuItem,
            this.frenchToolStripMenuItem});
            this.cmsLanguage.Name = "cmsLanguage";
            this.cmsLanguage.Size = new System.Drawing.Size(120, 92);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Image = global::AAEmu.Launcher.Properties.Resources.flag_english;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.englishToolStripMenuItem.Tag = "en_us";
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.swapLanguageToolStripMenuItem_Click);
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.Image = global::AAEmu.Launcher.Properties.Resources.flag_ru;
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            this.russianToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.russianToolStripMenuItem.Tag = "ru";
            this.russianToolStripMenuItem.Text = "Русский";
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.swapLanguageToolStripMenuItem_Click);
            // 
            // germanToolStripMenuItem
            // 
            this.germanToolStripMenuItem.Image = global::AAEmu.Launcher.Properties.Resources.flag_de;
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            this.germanToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.germanToolStripMenuItem.Tag = "de";
            this.germanToolStripMenuItem.Text = "Deutsch";
            this.germanToolStripMenuItem.Click += new System.EventHandler(this.swapLanguageToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Image = global::AAEmu.Launcher.Properties.Resources.flag_fr;
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.frenchToolStripMenuItem.Tag = "fr";
            this.frenchToolStripMenuItem.Text = "Français";
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.swapLanguageToolStripMenuItem_Click);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(950, 510);
            this.Controls.Add(this.lLoadedConfig);
            this.Controls.Add(this.cbAllowUpdates);
            this.Controls.Add(this.lAllowUpdates);
            this.Controls.Add(this.cbLocaleSelect);
            this.Controls.Add(this.cbUpdateLocale);
            this.Controls.Add(this.lUpdateLocale);
            this.Controls.Add(this.lGameClientType);
            this.Controls.Add(this.cbUseDebugMode);
            this.Controls.Add(this.cbLoginList);
            this.Controls.Add(this.eLogin);
            this.Controls.Add(this.cbSaveUser);
            this.Controls.Add(this.lSaveUser);
            this.Controls.Add(this.cbSkipIntro);
            this.Controls.Add(this.lSkipIntro);
            this.Controls.Add(this.cbHideSplash);
            this.Controls.Add(this.lHideSplash);
            this.Controls.Add(this.lGamePath);
            this.Controls.Add(this.lSettingsBack);
            this.Controls.Add(this.btnSystem);
            this.Controls.Add(this.lPathToGameLabel);
            this.Controls.Add(this.btnWebsite);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.eServerIP);
            this.Controls.Add(this.lIPAddress);
            this.Controls.Add(this.lNewsFeed);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.ePassword);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.lAppVersion);
            this.Controls.Add(this.btnDiscord);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.btnLangChange);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.imgBigNews);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AAEmu Launcher";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LauncherForm_FormClosed);
            this.Load += new System.EventHandler(this.LauncherForm_Load);
            this.BackgroundImageChanged += new System.EventHandler(this.LauncherForm_BackgroundImageChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LauncherForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LauncherForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LauncherForm_MouseUp);
            this.cmsAAEmuButton.ResumeLayout(false);
            this.cmsGitHub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDiscord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLangChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBigNews)).EndInit();
            this.cmsLanguage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox eLogin;
        private System.Windows.Forms.TextBox ePassword;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.Timer timerGeneral;
        private System.Windows.Forms.ProgressBar pb2;
        private System.Windows.Forms.PictureBox btnLangChange;
        private System.Windows.Forms.PictureBox btnGithub;
        private System.Windows.Forms.PictureBox btnDiscord;
        private System.Windows.Forms.TextBox eServerIP;
        private System.Windows.Forms.Label lPathToGameLabel;
        private System.Windows.Forms.Label lIPAddress;
        private System.Windows.Forms.ComboBox cbLoginList;
        private System.Windows.Forms.Label lAppVersion;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label btnPlay;
        private System.Windows.Forms.Label lNewsFeed;
        private System.Windows.Forms.Label btnSettings;
        private System.Windows.Forms.Label btnWebsite;
        private System.Windows.Forms.PictureBox imgBigNews;
        private System.Windows.Forms.PictureBox btnSystem;
        private System.Windows.Forms.ContextMenuStrip cmsAAEmuButton;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lSettingsBack;
        private System.Windows.Forms.Label lGamePath;
        private System.Windows.Forms.Label lHideSplash;
        private System.Windows.Forms.Label cbHideSplash;
        private System.Windows.Forms.Label cbSkipIntro;
        private System.Windows.Forms.Label lSkipIntro;
        private System.Windows.Forms.Label cbSaveUser;
        private System.Windows.Forms.Label lSaveUser;
        private System.Windows.Forms.CheckBox cbUseDebugMode;
        private System.Windows.Forms.Label lGameClientType;
        private System.Windows.Forms.Label cbUpdateLocale;
        private System.Windows.Forms.Label lUpdateLocale;
        private System.Windows.Forms.ComboBox cbLocaleSelect;
        private System.Windows.Forms.Label cbAllowUpdates;
        private System.Windows.Forms.Label lAllowUpdates;
        private System.Windows.Forms.ContextMenuStrip cmsGitHub;
        private System.Windows.Forms.ToolStripMenuItem aAEmuServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aAEmuLauncherToolStripMenuItem;
        private System.Windows.Forms.Label lLoadedConfig;
        private System.Windows.Forms.ContextMenuStrip cmsLanguage;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
    }
}

