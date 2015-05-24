namespace MudBase
{
    partial class SettingsForm
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(213, 286);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "XC";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox14);
            this.tabPage1.Controls.Add(this.checkBox11);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.comboBox5);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.numericUpDown2);
            this.tabPage1.Controls.Add(this.checkBox10);
            this.tabPage1.Controls.Add(this.checkBox9);
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(205, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "IC";
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Checked = global::MudBase.Properties.Settings.Default.UI_ALWAYS_ON_TOP;
            this.checkBox14.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MudBase.Properties.Settings.Default, "UI_ALWAYS_ON_TOP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox14.Location = new System.Drawing.Point(21, 51);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(95, 17);
            this.checkBox14.TabIndex = 19;
            this.checkBox14.Text = "Always On Top";
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.checkBox14_CheckedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Checked = global::MudBase.Properties.Settings.Default.AUTO_SPRINT;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MudBase.Properties.Settings.Default, "AUTO_SPRINT", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox11.Location = new System.Drawing.Point(21, 97);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(154, 17);
            this.checkBox11.TabIndex = 18;
            this.checkBox11.Text = "Auto Sprint (Out Of Combat)";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(46, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Of";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(70, 170);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(127, 21);
            this.comboBox5.TabIndex = 16;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(162, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Yalms";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::MudBase.Properties.Settings.Default, "AUTO_MOVE_TARGET_RANGE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown2.Location = new System.Drawing.Point(110, 144);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown2.TabIndex = 14;
            this.numericUpDown2.Value = global::MudBase.Properties.Settings.Default.AUTO_MOVE_TARGET_RANGE;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Checked = global::MudBase.Properties.Settings.Default.AUTO_MOVE_TO_TARGET;
            this.checkBox10.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MudBase.Properties.Settings.Default, "AUTO_MOVE_TO_TARGET", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox10.Location = new System.Drawing.Point(20, 144);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(83, 17);
            this.checkBox10.TabIndex = 13;
            this.checkBox10.Text = "Move Within";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox9.Location = new System.Drawing.Point(20, 120);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(106, 17);
            this.checkBox9.TabIndex = 12;
            this.checkBox9.Text = "Auto Face Target";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = global::MudBase.Properties.Settings.Default.COMBAT_ROUTINE_EXECUTE_WHILE_MOVING;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MudBase.Properties.Settings.Default, "COMBAT_ROUTINE_EXECUTE_WHILE_MOVING", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Location = new System.Drawing.Point(21, 74);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(130, 17);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Execute While Moving";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "General Settings:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::MudBase.Properties.Settings.Default.COMBAT_ROUTINE_PAUSED;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MudBase.Properties.Settings.Default, "COMBAT_ROUTINE_PAUSED", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(21, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Pause All Actions";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkBox8);
            this.tabPage4.Controls.Add(this.checkBox7);
            this.tabPage4.Controls.Add(this.checkBox6);
            this.tabPage4.Controls.Add(this.checkBox5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.checkBox2);
            this.tabPage4.Controls.Add(this.checkBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(205, 260);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Tag = "IC";
            this.tabPage4.Text = "Routine";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = global::MudBase.Properties.Settings.Default.COMBAT_ROUTINE_COMBAT;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MudBase.Properties.Settings.Default, "COMBAT_ROUTINE_COMBAT", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox8.Location = new System.Drawing.Point(24, 165);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(59, 17);
            this.checkBox8.TabIndex = 18;
            this.checkBox8.Text = "Combat";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = global::MudBase.Properties.Settings.Default.COMBAT_ROUTINE_COMBATBUFF;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MudBase.Properties.Settings.Default, "COMBAT_ROUTINE_COMBATBUFF", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox7.Location = new System.Drawing.Point(24, 142);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(81, 17);
            this.checkBox7.TabIndex = 17;
            this.checkBox7.Text = "Combat Buff";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = global::MudBase.Properties.Settings.Default.COMBAT_ROUTINE_HEAL;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MudBase.Properties.Settings.Default, "COMBAT_ROUTINE_HEAL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.Location = new System.Drawing.Point(24, 119);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(45, 17);
            this.checkBox6.TabIndex = 16;
            this.checkBox6.Text = "Heal";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = global::MudBase.Properties.Settings.Default.COMBAT_ROUTINE_PRECOMBATBUFF;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MudBase.Properties.Settings.Default, "COMBAT_ROUTINE_PRECOMBATBUFF", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Location = new System.Drawing.Point(24, 96);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(100, 17);
            this.checkBox5.TabIndex = 15;
            this.checkBox5.Text = "Pre-Combat Buff";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Combat Routine Actions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Out of Combat Actions:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::MudBase.Properties.Settings.Default.COMBAT_ROUTINE_ATTACK_OUT_OF_COMBAT;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MudBase.Properties.Settings.Default, "COMBAT_ROUTINE_ATTACK_OUT_OF_COMBAT", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(24, 52);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(144, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Attack Outside of Combat";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = global::MudBase.Properties.Settings.Default.COMBAT_ROUTINE_HEAL_OUT_OF_COMBAT;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MudBase.Properties.Settings.Default, "COMBAT_ROUTINE_HEAL_OUT_OF_COMBAT", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Location = new System.Drawing.Point(24, 29);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(135, 17);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Heal Outside of Combat";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(205, 260);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Tag = "IC";
            this.tabPage2.Text = "Targeting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(3, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Del Selection";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(199, 126);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdateTargetSettings);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.UpdateTargetSettings);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(110, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Add Target";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(167, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Yalms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(3, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Distance";
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(3, 75);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(98, 21);
            this.comboBox4.TabIndex = 11;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mode";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(83, 8);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(119, 21);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mobs Named:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::MudBase.Properties.Settings.Default, "MAX_TARGET_DISTANCE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown1.Location = new System.Drawing.Point(83, 35);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = global::MudBase.Properties.Settings.Default.MAX_TARGET_DISTANCE;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.comboBox8);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.comboBox6);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.checkBox13);
            this.tabPage3.Controls.Add(this.checkBox12);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(205, 260);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Tag = "IC";
            this.tabPage3.Text = "Hotkeys";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MudBase.Properties.Settings.Default, "HOTKEY_ADD_REM_TARGET_LIST", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox5.Location = new System.Drawing.Point(104, 149);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(98, 20);
            this.textBox5.TabIndex = 16;
            this.textBox5.Text = global::MudBase.Properties.Settings.Default.HOTKEY_ADD_REM_TARGET_LIST;
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(6, 148);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(88, 21);
            this.comboBox8.TabIndex = 15;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Add/Rem Target From Target List";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MudBase.Properties.Settings.Default, "HOTKEY_TOGGLE_MOVEMENT", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(104, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = global::MudBase.Properties.Settings.Default.HOTKEY_TOGGLE_MOVEMENT;
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(6, 108);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(88, 21);
            this.comboBox6.TabIndex = 9;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Toggle Movement";
            // 
            // checkBox13
            // 
            this.checkBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox13.AutoSize = true;
            this.checkBox13.Checked = global::MudBase.Properties.Settings.Default.UI_ACTIVATE_FFXIV;
            this.checkBox13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox13.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MudBase.Properties.Settings.Default, "UI_ACTIVATE_FFXIV", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox13.Location = new System.Drawing.Point(18, 237);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(163, 17);
            this.checkBox13.TabIndex = 7;
            this.checkBox13.Text = "Reactivate FFXIV After Flash";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox12.AutoSize = true;
            this.checkBox12.Checked = global::MudBase.Properties.Settings.Default.UI_FLASH_MESSAGES;
            this.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox12.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MudBase.Properties.Settings.Default, "UI_FLASH_MESSAGES", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox12.Location = new System.Drawing.Point(3, 214);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(193, 17);
            this.checkBox12.TabIndex = 6;
            this.checkBox12.Text = "Flash Hotkey Messages On Screen";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MudBase.Properties.Settings.Default, "HOTKEY_TARGET_MODE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox3.Location = new System.Drawing.Point(104, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(98, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = global::MudBase.Properties.Settings.Default.HOTKEY_TARGET_MODE;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(88, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Toggle Target Mode";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pause / Unpause Mud Assist";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MudBase.Properties.Settings.Default, "HOTKEY_PAUSE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(104, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = global::MudBase.Properties.Settings.Default.HOTKEY_PAUSE;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(118, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save and Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 339);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mud Assist v1.1.2 Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label12;
    }
}