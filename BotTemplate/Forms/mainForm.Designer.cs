﻿namespace BotTemplate.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAttach = new System.Windows.Forms.Button();
            this.bDeattach = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.rGrindbot = new System.Windows.Forms.RadioButton();
            this.bSettings = new System.Windows.Forms.Button();
            this.bStopBot = new System.Windows.Forms.Button();
            this.bHide = new System.Windows.Forms.Button();
            this.bShow = new System.Windows.Forms.Button();
            this.lPid = new System.Windows.Forms.Label();
            this.lRunning = new System.Windows.Forms.Label();
            this.lState = new System.Windows.Forms.Label();
            this.lProfile = new System.Windows.Forms.Label();
            this.lFsmTick = new System.Windows.Forms.Label();
            this.lObjTick = new System.Windows.Forms.Label();
            this.bLog = new System.Windows.Forms.Button();
            this.rExplorer = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbFishbot = new System.Windows.Forms.RadioButton();
            this.rbAssist = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mtbItem = new System.Windows.Forms.MaskedTextBox();
            this.bGetCount = new System.Windows.Forms.Button();
            this.bAddUp = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.bFromFile = new System.Windows.Forms.Button();
            this.bToFile = new System.Windows.Forms.Button();
            this.bViewObjects = new System.Windows.Forms.Button();
            this.bstopFall = new System.Windows.Forms.Button();
            this.bPort = new System.Windows.Forms.Button();
            this.bGetCurrentCoords = new System.Windows.Forms.Button();
            this.mtbZ = new System.Windows.Forms.MaskedTextBox();
            this.mtbY = new System.Windows.Forms.MaskedTextBox();
            this.mtbX = new System.Windows.Forms.MaskedTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.rtb_MainLog = new System.Windows.Forms.RichTextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.baseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_TheTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAttach
            // 
            this.bAttach.Location = new System.Drawing.Point(18, 97);
            this.bAttach.Name = "bAttach";
            this.bAttach.Size = new System.Drawing.Size(79, 33);
            this.bAttach.TabIndex = 0;
            this.bAttach.Text = "Attach";
            this.bAttach.UseVisualStyleBackColor = false;
            this.bAttach.Click += new System.EventHandler(this.bAttach_Click);
            // 
            // bDeattach
            // 
            this.bDeattach.Location = new System.Drawing.Point(103, 97);
            this.bDeattach.Name = "bDeattach";
            this.bDeattach.Size = new System.Drawing.Size(79, 33);
            this.bDeattach.TabIndex = 1;
            this.bDeattach.Text = "Deattach";
            this.bDeattach.UseVisualStyleBackColor = false;
            this.bDeattach.Click += new System.EventHandler(this.bDeattach_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(18, 136);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(79, 33);
            this.bStart.TabIndex = 5;
            this.bStart.Text = "Start Bot";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // rGrindbot
            // 
            this.rGrindbot.AutoSize = true;
            this.rGrindbot.Location = new System.Drawing.Point(202, 174);
            this.rGrindbot.Name = "rGrindbot";
            this.rGrindbot.Size = new System.Drawing.Size(65, 17);
            this.rGrindbot.TabIndex = 7;
            this.rGrindbot.TabStop = true;
            this.rGrindbot.Text = "Grindbot";
            this.rGrindbot.UseVisualStyleBackColor = true;
            // 
            // bSettings
            // 
            this.bSettings.Location = new System.Drawing.Point(188, 97);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(79, 33);
            this.bSettings.TabIndex = 9;
            this.bSettings.Text = "Settings";
            this.bSettings.UseVisualStyleBackColor = false;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // bStopBot
            // 
            this.bStopBot.Location = new System.Drawing.Point(103, 135);
            this.bStopBot.Name = "bStopBot";
            this.bStopBot.Size = new System.Drawing.Size(79, 33);
            this.bStopBot.TabIndex = 12;
            this.bStopBot.Text = "Stop Bot";
            this.bStopBot.UseVisualStyleBackColor = false;
            this.bStopBot.Click += new System.EventHandler(this.bStopBot_Click);
            // 
            // bHide
            // 
            this.bHide.Location = new System.Drawing.Point(18, 175);
            this.bHide.Name = "bHide";
            this.bHide.Size = new System.Drawing.Size(79, 33);
            this.bHide.TabIndex = 13;
            this.bHide.Text = "Hide";
            this.bHide.UseVisualStyleBackColor = false;
            this.bHide.Click += new System.EventHandler(this.bHide_Click);
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(103, 174);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(79, 33);
            this.bShow.TabIndex = 14;
            this.bShow.Text = "Show";
            this.bShow.UseVisualStyleBackColor = false;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // lPid
            // 
            this.lPid.AutoSize = true;
            this.lPid.Location = new System.Drawing.Point(15, 17);
            this.lPid.Name = "lPid";
            this.lPid.Size = new System.Drawing.Size(65, 13);
            this.lPid.TabIndex = 16;
            this.lPid.Text = "Attached to:";
            // 
            // lRunning
            // 
            this.lRunning.AutoSize = true;
            this.lRunning.Location = new System.Drawing.Point(132, 17);
            this.lRunning.Name = "lRunning";
            this.lRunning.Size = new System.Drawing.Size(50, 13);
            this.lRunning.TabIndex = 17;
            this.lRunning.Text = "Running:";
            // 
            // lState
            // 
            this.lState.AutoSize = true;
            this.lState.Location = new System.Drawing.Point(132, 35);
            this.lState.Name = "lState";
            this.lState.Size = new System.Drawing.Size(35, 13);
            this.lState.TabIndex = 18;
            this.lState.Text = "State:";
            // 
            // lProfile
            // 
            this.lProfile.AutoSize = true;
            this.lProfile.Location = new System.Drawing.Point(15, 71);
            this.lProfile.Name = "lProfile";
            this.lProfile.Size = new System.Drawing.Size(39, 13);
            this.lProfile.TabIndex = 19;
            this.lProfile.Text = "Profile:";
            // 
            // lFsmTick
            // 
            this.lFsmTick.AutoSize = true;
            this.lFsmTick.Location = new System.Drawing.Point(15, 53);
            this.lFsmTick.Name = "lFsmTick";
            this.lFsmTick.Size = new System.Drawing.Size(52, 13);
            this.lFsmTick.TabIndex = 21;
            this.lFsmTick.Text = "FSM tick:";
            // 
            // lObjTick
            // 
            this.lObjTick.AutoSize = true;
            this.lObjTick.Location = new System.Drawing.Point(15, 35);
            this.lObjTick.Name = "lObjTick";
            this.lObjTick.Size = new System.Drawing.Size(72, 13);
            this.lObjTick.TabIndex = 20;
            this.lObjTick.Text = "Manager tick:";
            // 
            // bLog
            // 
            this.bLog.Location = new System.Drawing.Point(18, 216);
            this.bLog.Name = "bLog";
            this.bLog.Size = new System.Drawing.Size(79, 33);
            this.bLog.TabIndex = 27;
            this.bLog.Text = "Log";
            this.bLog.UseVisualStyleBackColor = false;
            this.bLog.Click += new System.EventHandler(this.bLog_Click);
            // 
            // rExplorer
            // 
            this.rExplorer.AutoSize = true;
            this.rExplorer.Location = new System.Drawing.Point(202, 197);
            this.rExplorer.Name = "rExplorer";
            this.rExplorer.Size = new System.Drawing.Size(63, 17);
            this.rExplorer.TabIndex = 28;
            this.rExplorer.TabStop = true;
            this.rExplorer.Text = "Explorer";
            this.rExplorer.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 255);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 17);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Beep on chat activity";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(387, 311);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rbFishbot);
            this.tabPage1.Controls.Add(this.rbAssist);
            this.tabPage1.Controls.Add(this.lPid);
            this.tabPage1.Controls.Add(this.bAttach);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.bDeattach);
            this.tabPage1.Controls.Add(this.bStart);
            this.tabPage1.Controls.Add(this.rExplorer);
            this.tabPage1.Controls.Add(this.bLog);
            this.tabPage1.Controls.Add(this.rGrindbot);
            this.tabPage1.Controls.Add(this.bSettings);
            this.tabPage1.Controls.Add(this.bStopBot);
            this.tabPage1.Controls.Add(this.lRunning);
            this.tabPage1.Controls.Add(this.bHide);
            this.tabPage1.Controls.Add(this.lState);
            this.tabPage1.Controls.Add(this.bShow);
            this.tabPage1.Controls.Add(this.lProfile);
            this.tabPage1.Controls.Add(this.lObjTick);
            this.tabPage1.Controls.Add(this.lFsmTick);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(379, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbFishbot
            // 
            this.rbFishbot.AutoSize = true;
            this.rbFishbot.Location = new System.Drawing.Point(202, 151);
            this.rbFishbot.Name = "rbFishbot";
            this.rbFishbot.Size = new System.Drawing.Size(59, 17);
            this.rbFishbot.TabIndex = 35;
            this.rbFishbot.TabStop = true;
            this.rbFishbot.Text = "Fishbot";
            this.rbFishbot.UseVisualStyleBackColor = true;
            // 
            // rbAssist
            // 
            this.rbAssist.AutoSize = true;
            this.rbAssist.Location = new System.Drawing.Point(202, 220);
            this.rbAssist.Name = "rbAssist";
            this.rbAssist.Size = new System.Drawing.Size(84, 17);
            this.rbAssist.TabIndex = 33;
            this.rbAssist.TabStop = true;
            this.rbAssist.Text = "Group Mode";
            this.rbAssist.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.mtbItem);
            this.tabPage2.Controls.Add(this.bGetCount);
            this.tabPage2.Controls.Add(this.bAddUp);
            this.tabPage2.Controls.Add(this.bLogin);
            this.tabPage2.Controls.Add(this.bFromFile);
            this.tabPage2.Controls.Add(this.bToFile);
            this.tabPage2.Controls.Add(this.bViewObjects);
            this.tabPage2.Controls.Add(this.bstopFall);
            this.tabPage2.Controls.Add(this.bPort);
            this.tabPage2.Controls.Add(this.bGetCurrentCoords);
            this.tabPage2.Controls.Add(this.mtbZ);
            this.tabPage2.Controls.Add(this.mtbY);
            this.tabPage2.Controls.Add(this.mtbX);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(379, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dev";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(251, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 41);
            this.button3.TabIndex = 17;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 48);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Get Distance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // mtbItem
            // 
            this.mtbItem.Location = new System.Drawing.Point(59, 149);
            this.mtbItem.Name = "mtbItem";
            this.mtbItem.Size = new System.Drawing.Size(131, 20);
            this.mtbItem.TabIndex = 14;
            // 
            // bGetCount
            // 
            this.bGetCount.Location = new System.Drawing.Point(196, 142);
            this.bGetCount.Name = "bGetCount";
            this.bGetCount.Size = new System.Drawing.Size(86, 33);
            this.bGetCount.TabIndex = 13;
            this.bGetCount.Text = "Get Count";
            this.bGetCount.UseVisualStyleBackColor = true;
            this.bGetCount.Click += new System.EventHandler(this.bGetCount_Click);
            // 
            // bAddUp
            // 
            this.bAddUp.Location = new System.Drawing.Point(277, 251);
            this.bAddUp.Name = "bAddUp";
            this.bAddUp.Size = new System.Drawing.Size(77, 20);
            this.bAddUp.TabIndex = 12;
            this.bAddUp.Text = "+1";
            this.bAddUp.UseVisualStyleBackColor = true;
            this.bAddUp.Click += new System.EventHandler(this.bAddUp_Click);
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(101, 18);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(77, 30);
            this.bLogin.TabIndex = 9;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // bFromFile
            // 
            this.bFromFile.Location = new System.Drawing.Point(89, 195);
            this.bFromFile.Name = "bFromFile";
            this.bFromFile.Size = new System.Drawing.Size(77, 22);
            this.bFromFile.TabIndex = 8;
            this.bFromFile.Text = "From File";
            this.bFromFile.UseVisualStyleBackColor = true;
            this.bFromFile.Click += new System.EventHandler(this.bFromFile_Click);
            // 
            // bToFile
            // 
            this.bToFile.Location = new System.Drawing.Point(6, 195);
            this.bToFile.Name = "bToFile";
            this.bToFile.Size = new System.Drawing.Size(77, 22);
            this.bToFile.TabIndex = 7;
            this.bToFile.Text = "To File";
            this.bToFile.UseVisualStyleBackColor = true;
            this.bToFile.Click += new System.EventHandler(this.bToFile_Click);
            // 
            // bViewObjects
            // 
            this.bViewObjects.Location = new System.Drawing.Point(18, 18);
            this.bViewObjects.Name = "bViewObjects";
            this.bViewObjects.Size = new System.Drawing.Size(77, 30);
            this.bViewObjects.TabIndex = 6;
            this.bViewObjects.Text = "View Objects";
            this.bViewObjects.UseVisualStyleBackColor = true;
            this.bViewObjects.Click += new System.EventHandler(this.bViewObjects_Click);
            // 
            // bstopFall
            // 
            this.bstopFall.Location = new System.Drawing.Point(172, 249);
            this.bstopFall.Name = "bstopFall";
            this.bstopFall.Size = new System.Drawing.Size(77, 22);
            this.bstopFall.TabIndex = 5;
            this.bstopFall.Text = "Stop fall";
            this.bstopFall.UseVisualStyleBackColor = true;
            this.bstopFall.Click += new System.EventHandler(this.bstopFall_Click);
            // 
            // bPort
            // 
            this.bPort.Location = new System.Drawing.Point(89, 249);
            this.bPort.Name = "bPort";
            this.bPort.Size = new System.Drawing.Size(77, 22);
            this.bPort.TabIndex = 4;
            this.bPort.Text = "Port";
            this.bPort.UseVisualStyleBackColor = true;
            this.bPort.Click += new System.EventHandler(this.bPort_Click);
            // 
            // bGetCurrentCoords
            // 
            this.bGetCurrentCoords.Location = new System.Drawing.Point(6, 249);
            this.bGetCurrentCoords.Name = "bGetCurrentCoords";
            this.bGetCurrentCoords.Size = new System.Drawing.Size(77, 22);
            this.bGetCurrentCoords.TabIndex = 3;
            this.bGetCurrentCoords.Text = "Get Current";
            this.bGetCurrentCoords.UseVisualStyleBackColor = true;
            this.bGetCurrentCoords.Click += new System.EventHandler(this.bGetCurrentCoords_Click);
            // 
            // mtbZ
            // 
            this.mtbZ.Location = new System.Drawing.Point(172, 223);
            this.mtbZ.Name = "mtbZ";
            this.mtbZ.Size = new System.Drawing.Size(77, 20);
            this.mtbZ.TabIndex = 2;
            // 
            // mtbY
            // 
            this.mtbY.Location = new System.Drawing.Point(89, 223);
            this.mtbY.Name = "mtbY";
            this.mtbY.Size = new System.Drawing.Size(77, 20);
            this.mtbY.TabIndex = 1;
            // 
            // mtbX
            // 
            this.mtbX.Location = new System.Drawing.Point(6, 223);
            this.mtbX.Name = "mtbX";
            this.mtbX.Size = new System.Drawing.Size(77, 20);
            this.mtbX.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(379, 285);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Misc";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 675);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 340);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(387, 311);
            this.tabControl2.TabIndex = 34;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.rtb_MainLog);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(379, 285);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "base";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // rtb_MainLog
            // 
            this.rtb_MainLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_MainLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_MainLog.Location = new System.Drawing.Point(3, 3);
            this.rtb_MainLog.Name = "rtb_MainLog";
            this.rtb_MainLog.ReadOnly = true;
            this.rtb_MainLog.Size = new System.Drawing.Size(373, 279);
            this.rtb_MainLog.TabIndex = 1;
            this.rtb_MainLog.Text = "";
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(379, 253);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "exception";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(393, 20);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baseToolStripMenuItem
            // 
            this.baseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.baseToolStripMenuItem.Name = "baseToolStripMenuItem";
            this.baseToolStripMenuItem.Size = new System.Drawing.Size(43, 16);
            this.baseToolStripMenuItem.Text = "Base";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItemExit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 16);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItemAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_TheTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 654);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(393, 21);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_TheTime
            // 
            this.toolStripStatusLabel_TheTime.Name = "toolStripStatusLabel_TheTime";
            this.toolStripStatusLabel_TheTime.Size = new System.Drawing.Size(49, 16);
            this.toolStripStatusLabel_TheTime.Text = "00:00:00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 675);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "NoVanillaBot";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAttach;
        private System.Windows.Forms.Button bDeattach;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.RadioButton rGrindbot;
        private System.Windows.Forms.Button bSettings;
        private System.Windows.Forms.Button bStopBot;
        private System.Windows.Forms.Button bHide;
        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.Label lPid;
        private System.Windows.Forms.Label lRunning;
        private System.Windows.Forms.Label lState;
        private System.Windows.Forms.Label lProfile;
        private System.Windows.Forms.Label lFsmTick;
        private System.Windows.Forms.Label lObjTick;
        private System.Windows.Forms.Button bLog;
        private System.Windows.Forms.RadioButton rExplorer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bGetCurrentCoords;
        private System.Windows.Forms.MaskedTextBox mtbZ;
        private System.Windows.Forms.MaskedTextBox mtbY;
        private System.Windows.Forms.MaskedTextBox mtbX;
        private System.Windows.Forms.Button bPort;
        private System.Windows.Forms.Button bstopFall;
        private System.Windows.Forms.Button bViewObjects;
        private System.Windows.Forms.RadioButton rbAssist;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rbFishbot;
        private System.Windows.Forms.Button bFromFile;
        private System.Windows.Forms.Button bToFile;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bAddUp;
        private System.Windows.Forms.MaskedTextBox mtbItem;
        private System.Windows.Forms.Button bGetCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.RichTextBox rtb_MainLog;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem baseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_TheTime;
    }
}

