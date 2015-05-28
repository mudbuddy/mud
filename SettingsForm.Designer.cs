namespace Mud
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabRoutine = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cmbCombatRoutines = new System.Windows.Forms.ComboBox();
            this.lblCombatRoutineName = new System.Windows.Forms.Label();
            this.gbxOutOfCombat = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbxOutOfCombatRest = new System.Windows.Forms.CheckBox();
            this.cbxOutOfCombatHeal = new System.Windows.Forms.CheckBox();
            this.cbxOutOfCombatBuff = new System.Windows.Forms.CheckBox();
            this.gbxCombatActions = new System.Windows.Forms.GroupBox();
            this.cbxCombat = new System.Windows.Forms.CheckBox();
            this.cbxCombatHeal = new System.Windows.Forms.CheckBox();
            this.cbxCombatBuff = new System.Windows.Forms.CheckBox();
            this.cbxOutOfCombatAttack = new System.Windows.Forms.CheckBox();
            this.tabMovement = new System.Windows.Forms.TabPage();
            this.gbxMoveInRange = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numAutoMoveTargetRange = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxAutoMoveTarget = new System.Windows.Forms.CheckBox();
            this.numMaxMoveDistanceTank = new System.Windows.Forms.NumericUpDown();
            this.lblYalms3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMovementMode = new System.Windows.Forms.ComboBox();
            this.lblYalms2 = new System.Windows.Forms.Label();
            this.lblOf = new System.Windows.Forms.Label();
            this.lblWhen = new System.Windows.Forms.Label();
            this.numMinMoveDistanceTank = new System.Windows.Forms.NumericUpDown();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cmbNavigationProvider = new System.Windows.Forms.ComboBox();
            this.lblNavigationProvider = new System.Windows.Forms.Label();
            this.cbxAutoFace = new System.Windows.Forms.CheckBox();
            this.tabTargeting = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cmbTargetingMode = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmbTargetListType = new System.Windows.Forms.ComboBox();
            this.btnDelSelectedTargets = new System.Windows.Forms.Button();
            this.dgvTargetList = new System.Windows.Forms.DataGridView();
            this.btnAddCurrentTarget = new System.Windows.Forms.Button();
            this.lblYalms = new System.Windows.Forms.Label();
            this.lblTargetingDistance = new System.Windows.Forms.Label();
            this.lblTargetingMode = new System.Windows.Forms.Label();
            this.lblTargetListType = new System.Windows.Forms.Label();
            this.numTargetingDistance = new System.Windows.Forms.NumericUpDown();
            this.tabHotkeys = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cmbHotkeyModifierToggleMoveMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbHotkeyModifierPause = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbHotkeyModifierTargetMode = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbHotkeyModifierMovement = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbHotkeyModifierAddRemTargetList = new System.Windows.Forms.ComboBox();
            this.lblHotkeyAddRemTargetList = new System.Windows.Forms.Label();
            this.lblHotkeyMovement = new System.Windows.Forms.Label();
            this.lblHotkeyTargetMode = new System.Windows.Forms.Label();
            this.lblHotkeyPause = new System.Windows.Forms.Label();
            this.tbxHotkeyToggleMoveMode = new System.Windows.Forms.TextBox();
            this.tbxHotkeyAddRemTargetList = new System.Windows.Forms.TextBox();
            this.tbxHotkeyMovement = new System.Windows.Forms.TextBox();
            this.tbxHotkeyTargetMode = new System.Windows.Forms.TextBox();
            this.tbxHotkeyPause = new System.Windows.Forms.TextBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.gbxMiscellaneous = new System.Windows.Forms.GroupBox();
            this.cbxPaused = new System.Windows.Forms.CheckBox();
            this.cbxExecuteMoving = new System.Windows.Forms.CheckBox();
            this.cbxAutoSprint = new System.Windows.Forms.CheckBox();
            this.cbxAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.gbxHotkeyMessages = new System.Windows.Forms.GroupBox();
            this.cbxFlashMessages = new System.Windows.Forms.CheckBox();
            this.cbxActivateFFXIV = new System.Windows.Forms.CheckBox();
            this.gbxQuesting = new System.Windows.Forms.GroupBox();
            this.cbxAutoTalkToNPCs = new System.Windows.Forms.CheckBox();
            this.cbxAutoAcceptQuests = new System.Windows.Forms.CheckBox();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tspPauseStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspMovementStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspFollowModeStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspTargetModeStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMain.SuspendLayout();
            this.tabRoutine.SuspendLayout();
            this.panel9.SuspendLayout();
            this.gbxOutOfCombat.SuspendLayout();
            this.gbxCombatActions.SuspendLayout();
            this.tabMovement.SuspendLayout();
            this.gbxMoveInRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoMoveTargetRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMoveDistanceTank)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinMoveDistanceTank)).BeginInit();
            this.panel8.SuspendLayout();
            this.tabTargeting.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTargetList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetingDistance)).BeginInit();
            this.tabHotkeys.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.gbxMiscellaneous.SuspendLayout();
            this.gbxHotkeyMessages.SuspendLayout();
            this.gbxQuesting.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabRoutine);
            this.tabControlMain.Controls.Add(this.tabMovement);
            this.tabControlMain.Controls.Add(this.tabTargeting);
            this.tabControlMain.Controls.Add(this.tabHotkeys);
            this.tabControlMain.Controls.Add(this.tabSettings);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(317, 287);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.Tag = "XC";
            // 
            // tabRoutine
            // 
            this.tabRoutine.Controls.Add(this.label1);
            this.tabRoutine.Controls.Add(this.panel9);
            this.tabRoutine.Controls.Add(this.lblCombatRoutineName);
            this.tabRoutine.Controls.Add(this.gbxOutOfCombat);
            this.tabRoutine.Controls.Add(this.gbxCombatActions);
            this.tabRoutine.Location = new System.Drawing.Point(4, 22);
            this.tabRoutine.Name = "tabRoutine";
            this.tabRoutine.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoutine.Size = new System.Drawing.Size(309, 261);
            this.tabRoutine.TabIndex = 2;
            this.tabRoutine.Tag = "XC";
            this.tabRoutine.Text = "Routine";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "*Must Stop/Start BotBase After Changing Combat Routine";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.cmbCombatRoutines);
            this.panel9.Location = new System.Drawing.Point(158, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(145, 23);
            this.panel9.TabIndex = 22;
            // 
            // cmbCombatRoutines
            // 
            this.cmbCombatRoutines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCombatRoutines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCombatRoutines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCombatRoutines.FormattingEnabled = true;
            this.cmbCombatRoutines.Location = new System.Drawing.Point(0, 0);
            this.cmbCombatRoutines.Name = "cmbCombatRoutines";
            this.cmbCombatRoutines.Size = new System.Drawing.Size(143, 21);
            this.cmbCombatRoutines.TabIndex = 9;
            this.cmbCombatRoutines.Tag = "XC";
            this.cmbCombatRoutines.SelectedIndexChanged += new System.EventHandler(this.OnSelectedCombatRoutine);
            // 
            // lblCombatRoutineName
            // 
            this.lblCombatRoutineName.AutoSize = true;
            this.lblCombatRoutineName.Location = new System.Drawing.Point(6, 10);
            this.lblCombatRoutineName.Name = "lblCombatRoutineName";
            this.lblCombatRoutineName.Size = new System.Drawing.Size(126, 13);
            this.lblCombatRoutineName.TabIndex = 21;
            this.lblCombatRoutineName.Text = "Loaded Combat Routine*";
            // 
            // gbxOutOfCombat
            // 
            this.gbxOutOfCombat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOutOfCombat.Controls.Add(this.checkBox1);
            this.gbxOutOfCombat.Controls.Add(this.cbxOutOfCombatRest);
            this.gbxOutOfCombat.Controls.Add(this.cbxOutOfCombatHeal);
            this.gbxOutOfCombat.Controls.Add(this.cbxOutOfCombatBuff);
            this.gbxOutOfCombat.Location = new System.Drawing.Point(3, 34);
            this.gbxOutOfCombat.Name = "gbxOutOfCombat";
            this.gbxOutOfCombat.Size = new System.Drawing.Size(146, 208);
            this.gbxOutOfCombat.TabIndex = 20;
            this.gbxOutOfCombat.TabStop = false;
            this.gbxOutOfCombat.Text = "Non-Combat Actions";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::Mud.Properties.Settings.Default.COMBAT_ROUTINE_PULL_BUFF;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Mud.Properties.Settings.Default, "COMBAT_ROUTINE_PULL_BUFF", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(6, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Tag = "XC";
            this.checkBox1.Text = "Pull Buff";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbxOutOfCombatRest
            // 
            this.cbxOutOfCombatRest.AutoSize = true;
            this.cbxOutOfCombatRest.Checked = global::Mud.Properties.Settings.Default.COMBAT_ROUTINE_REST;
            this.cbxOutOfCombatRest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxOutOfCombatRest.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Mud.Properties.Settings.Default, "COMBAT_ROUTINE_REST", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxOutOfCombatRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxOutOfCombatRest.Location = new System.Drawing.Point(6, 19);
            this.cbxOutOfCombatRest.Name = "cbxOutOfCombatRest";
            this.cbxOutOfCombatRest.Size = new System.Drawing.Size(45, 17);
            this.cbxOutOfCombatRest.TabIndex = 16;
            this.cbxOutOfCombatRest.Tag = "XC";
            this.cbxOutOfCombatRest.Text = "Rest";
            this.cbxOutOfCombatRest.UseVisualStyleBackColor = true;
            // 
            // cbxOutOfCombatHeal
            // 
            this.cbxOutOfCombatHeal.AutoSize = true;
            this.cbxOutOfCombatHeal.Checked = global::Mud.Properties.Settings.Default.COMBAT_ROUTINE_HEAL_OUT_OF_COMBAT;
            this.cbxOutOfCombatHeal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxOutOfCombatHeal.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Mud.Properties.Settings.Default, "COMBAT_ROUTINE_HEAL_OUT_OF_COMBAT", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxOutOfCombatHeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxOutOfCombatHeal.Location = new System.Drawing.Point(6, 42);
            this.cbxOutOfCombatHeal.Name = "cbxOutOfCombatHeal";
            this.cbxOutOfCombatHeal.Size = new System.Drawing.Size(45, 17);
            this.cbxOutOfCombatHeal.TabIndex = 12;
            this.cbxOutOfCombatHeal.Tag = "XC";
            this.cbxOutOfCombatHeal.Text = "Heal";
            this.cbxOutOfCombatHeal.UseVisualStyleBackColor = true;
            // 
            // cbxOutOfCombatBuff
            // 
            this.cbxOutOfCombatBuff.AutoSize = true;
            this.cbxOutOfCombatBuff.Checked = global::Mud.Properties.Settings.Default.COMBAT_ROUTINE_PRECOMBATBUFF;
            this.cbxOutOfCombatBuff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxOutOfCombatBuff.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Mud.Properties.Settings.Default, "COMBAT_ROUTINE_PRECOMBATBUFF", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxOutOfCombatBuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxOutOfCombatBuff.Location = new System.Drawing.Point(6, 65);
            this.cbxOutOfCombatBuff.Name = "cbxOutOfCombatBuff";
            this.cbxOutOfCombatBuff.Size = new System.Drawing.Size(100, 17);
            this.cbxOutOfCombatBuff.TabIndex = 15;
            this.cbxOutOfCombatBuff.Tag = "XC";
            this.cbxOutOfCombatBuff.Text = "Pre-Combat Buff";
            this.cbxOutOfCombatBuff.UseVisualStyleBackColor = true;
            // 
            // gbxCombatActions
            // 
            this.gbxCombatActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCombatActions.Controls.Add(this.cbxCombat);
            this.gbxCombatActions.Controls.Add(this.cbxCombatHeal);
            this.gbxCombatActions.Controls.Add(this.cbxCombatBuff);
            this.gbxCombatActions.Controls.Add(this.cbxOutOfCombatAttack);
            this.gbxCombatActions.Location = new System.Drawing.Point(148, 34);
            this.gbxCombatActions.Name = "gbxCombatActions";
            this.gbxCombatActions.Size = new System.Drawing.Size(155, 208);
            this.gbxCombatActions.TabIndex = 19;
            this.gbxCombatActions.TabStop = false;
            this.gbxCombatActions.Text = "In Combat Actions";
            // 
            // cbxCombat
            // 
            this.cbxCombat.AutoSize = true;
            this.cbxCombat.Checked = global::Mud.Properties.Settings.Default.COMBAT_ROUTINE_COMBAT;
            this.cbxCombat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxCombat.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Mud.Properties.Settings.Default, "COMBAT_ROUTINE_COMBAT", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxCombat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCombat.Location = new System.Drawing.Point(6, 88);
            this.cbxCombat.Name = "cbxCombat";
            this.cbxCombat.Size = new System.Drawing.Size(59, 17);
            this.cbxCombat.TabIndex = 18;
            this.cbxCombat.Tag = "XC";
            this.cbxCombat.Text = "Combat";
            this.cbxCombat.UseVisualStyleBackColor = true;
            // 
            // cbxCombatHeal
            // 
            this.cbxCombatHeal.AutoSize = true;
            this.cbxCombatHeal.Checked = global::Mud.Properties.Settings.Default.COMBAT_ROUTINE_HEAL;
            this.cbxCombatHeal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxCombatHeal.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Mud.Properties.Settings.Default, "COMBAT_ROUTINE_HEAL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxCombatHeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCombatHeal.Location = new System.Drawing.Point(6, 42);
            this.cbxCombatHeal.Name = "cbxCombatHeal";
            this.cbxCombatHeal.Size = new System.Drawing.Size(45, 17);
            this.cbxCombatHeal.TabIndex = 16;
            this.cbxCombatHeal.Tag = "XC";
            this.cbxCombatHeal.Text = "Heal";
            this.cbxCombatHeal.UseVisualStyleBackColor = true;
            // 
            // cbxCombatBuff
            // 
            this.cbxCombatBuff.AutoSize = true;
            this.cbxCombatBuff.Checked = global::Mud.Properties.Settings.Default.COMBAT_ROUTINE_COMBATBUFF;
            this.cbxCombatBuff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxCombatBuff.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Mud.Properties.Settings.Default, "COMBAT_ROUTINE_COMBATBUFF", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxCombatBuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCombatBuff.Location = new System.Drawing.Point(6, 65);
            this.cbxCombatBuff.Name = "cbxCombatBuff";
            this.cbxCombatBuff.Size = new System.Drawing.Size(81, 17);
            this.cbxCombatBuff.TabIndex = 17;
            this.cbxCombatBuff.Tag = "XC";
            this.cbxCombatBuff.Text = "Combat Buff";
            this.cbxCombatBuff.UseVisualStyleBackColor = true;
            // 
            // cbxOutOfCombatAttack
            // 
            this.cbxOutOfCombatAttack.AutoSize = true;
            this.cbxOutOfCombatAttack.Checked = global::Mud.Properties.Settings.Default.COMBAT_ROUTINE_PULL;
            this.cbxOutOfCombatAttack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxOutOfCombatAttack.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Mud.Properties.Settings.Default, "COMBAT_ROUTINE_PULL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxOutOfCombatAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxOutOfCombatAttack.Location = new System.Drawing.Point(6, 19);
            this.cbxOutOfCombatAttack.Name = "cbxOutOfCombatAttack";
            this.cbxOutOfCombatAttack.Size = new System.Drawing.Size(40, 17);
            this.cbxOutOfCombatAttack.TabIndex = 11;
            this.cbxOutOfCombatAttack.Tag = "XC";
            this.cbxOutOfCombatAttack.Text = "Pull";
            this.cbxOutOfCombatAttack.UseVisualStyleBackColor = true;
            // 
            // tabMovement
            // 
            this.tabMovement.Controls.Add(this.gbxMoveInRange);
            this.tabMovement.Controls.Add(this.panel8);
            this.tabMovement.Controls.Add(this.lblNavigationProvider);
            this.tabMovement.Controls.Add(this.cbxAutoFace);
            this.tabMovement.Location = new System.Drawing.Point(4, 22);
            this.tabMovement.Name = "tabMovement";
            this.tabMovement.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovement.Size = new System.Drawing.Size(309, 261);
            this.tabMovement.TabIndex = 3;
            this.tabMovement.Tag = "XC";
            this.tabMovement.Text = "Movement";
            this.tabMovement.UseVisualStyleBackColor = true;
            // 
            // gbxMoveInRange
            // 
            this.gbxMoveInRange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxMoveInRange.Controls.Add(this.label3);
            this.gbxMoveInRange.Controls.Add(this.label5);
            this.gbxMoveInRange.Controls.Add(this.numAutoMoveTargetRange);
            this.gbxMoveInRange.Controls.Add(this.label2);
            this.gbxMoveInRange.Controls.Add(this.cbxAutoMoveTarget);
            this.gbxMoveInRange.Controls.Add(this.numMaxMoveDistanceTank);
            this.gbxMoveInRange.Controls.Add(this.lblYalms3);
            this.gbxMoveInRange.Controls.Add(this.panel1);
            this.gbxMoveInRange.Controls.Add(this.lblYalms2);
            this.gbxMoveInRange.Controls.Add(this.lblOf);
            this.gbxMoveInRange.Controls.Add(this.lblWhen);
            this.gbxMoveInRange.Controls.Add(this.numMinMoveDistanceTank);
            this.gbxMoveInRange.Location = new System.Drawing.Point(3, 59);
            this.gbxMoveInRange.Name = "gbxMoveInRange";
            this.gbxMoveInRange.Size = new System.Drawing.Size(300, 196);
            this.gbxMoveInRange.TabIndex = 38;
            this.gbxMoveInRange.TabStop = false;
            this.gbxMoveInRange.Text = "Move In Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(25, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 42;
            this.label3.Tag = "XC";
            this.label3.Text = "- Move Within";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(176, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 38;
            this.label5.Tag = "XC";
            this.label5.Text = "Yalms Of Combat Target";
            // 
            // numAutoMoveTargetRange
            // 
            this.numAutoMoveTargetRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAutoMoveTargetRange.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Mud.Properties.Settings.Default, "AUTO_MOVE_TARGET_RANGE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numAutoMoveTargetRange.DecimalPlaces = 1;
            this.numAutoMoveTargetRange.Location = new System.Drawing.Point(108, 94);
            this.numAutoMoveTargetRange.Name = "numAutoMoveTargetRange";
            this.numAutoMoveTargetRange.Size = new System.Drawing.Size(60, 20);
            this.numAutoMoveTargetRange.TabIndex = 37;
            this.numAutoMoveTargetRange.Tag = "XC";
            this.numAutoMoveTargetRange.Value = global::Mud.Properties.Settings.Default.AUTO_MOVE_TARGET_RANGE;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(25, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 36;
            this.label2.Tag = "XC";
            this.label2.Text = "- Move Within";
            // 
            // cbxAutoMoveTarget
            // 
            this.cbxAutoMoveTarget.AutoSize = true;
            this.cbxAutoMoveTarget.Checked = global::Mud.Properties.Settings.Default.AUTO_MOVE;
            this.cbxAutoMoveTarget.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoMoveTarget.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Mud.Properties.Settings.Default, "AUTO_MOVE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxAutoMoveTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAutoMoveTarget.Location = new System.Drawing.Point(6, 19);
            this.cbxAutoMoveTarget.Name = "cbxAutoMoveTarget";
            this.cbxAutoMoveTarget.Size = new System.Drawing.Size(125, 17);
            this.cbxAutoMoveTarget.TabIndex = 28;
            this.cbxAutoMoveTarget.Tag = "XC";
            this.cbxAutoMoveTarget.Text = "Auto Move To Target";
            this.cbxAutoMoveTarget.UseVisualStyleBackColor = true;
            // 
            // numMaxMoveDistanceTank
            // 
            this.numMaxMoveDistanceTank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMaxMoveDistanceTank.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Mud.Properties.Settings.Default, "AUTO_MOVE_FOLLOW_RANGE_MAX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numMaxMoveDistanceTank.DecimalPlaces = 1;
            this.numMaxMoveDistanceTank.Location = new System.Drawing.Point(108, 68);
            this.numMaxMoveDistanceTank.Name = "numMaxMoveDistanceTank";
            this.numMaxMoveDistanceTank.Size = new System.Drawing.Size(60, 20);
            this.numMaxMoveDistanceTank.TabIndex = 32;
            this.numMaxMoveDistanceTank.Tag = "XC";
            this.numMaxMoveDistanceTank.Value = global::Mud.Properties.Settings.Default.AUTO_MOVE_FOLLOW_RANGE_MAX;
            // 
            // lblYalms3
            // 
            this.lblYalms3.AutoSize = true;
            this.lblYalms3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblYalms3.Location = new System.Drawing.Point(174, 70);
            this.lblYalms3.Name = "lblYalms3";
            this.lblYalms3.Size = new System.Drawing.Size(35, 13);
            this.lblYalms3.TabIndex = 33;
            this.lblYalms3.Tag = "XC";
            this.lblYalms3.Text = "Yalms";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbMovementMode);
            this.panel1.Location = new System.Drawing.Point(136, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 23);
            this.panel1.TabIndex = 35;
            // 
            // cmbMovementMode
            // 
            this.cmbMovementMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMovementMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovementMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMovementMode.FormattingEnabled = true;
            this.cmbMovementMode.Location = new System.Drawing.Point(0, 0);
            this.cmbMovementMode.Name = "cmbMovementMode";
            this.cmbMovementMode.Size = new System.Drawing.Size(156, 21);
            this.cmbMovementMode.TabIndex = 16;
            this.cmbMovementMode.Tag = "XC";
            this.cmbMovementMode.SelectedIndexChanged += new System.EventHandler(this.OnSelectedMoveTarget);
            // 
            // lblYalms2
            // 
            this.lblYalms2.AutoSize = true;
            this.lblYalms2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblYalms2.Location = new System.Drawing.Point(176, 44);
            this.lblYalms2.Name = "lblYalms2";
            this.lblYalms2.Size = new System.Drawing.Size(116, 13);
            this.lblYalms2.TabIndex = 30;
            this.lblYalms2.Tag = "XC";
            this.lblYalms2.Text = "Yalms Of Follow Target";
            // 
            // lblOf
            // 
            this.lblOf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOf.AutoSize = true;
            this.lblOf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOf.Location = new System.Drawing.Point(6, 171);
            this.lblOf.Name = "lblOf";
            this.lblOf.Size = new System.Drawing.Size(87, 13);
            this.lblOf.TabIndex = 31;
            this.lblOf.Tag = "XC";
            this.lblOf.Text = "Movement Mode";
            // 
            // lblWhen
            // 
            this.lblWhen.AutoSize = true;
            this.lblWhen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWhen.Location = new System.Drawing.Point(53, 70);
            this.lblWhen.Name = "lblWhen";
            this.lblWhen.Size = new System.Drawing.Size(45, 13);
            this.lblWhen.TabIndex = 34;
            this.lblWhen.Tag = "XC";
            this.lblWhen.Text = "When >";
            // 
            // numMinMoveDistanceTank
            // 
            this.numMinMoveDistanceTank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMinMoveDistanceTank.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Mud.Properties.Settings.Default, "AUTO_MOVE_FOLLOW_RANGE_MIN", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numMinMoveDistanceTank.DecimalPlaces = 1;
            this.numMinMoveDistanceTank.Location = new System.Drawing.Point(108, 42);
            this.numMinMoveDistanceTank.Name = "numMinMoveDistanceTank";
            this.numMinMoveDistanceTank.Size = new System.Drawing.Size(60, 20);
            this.numMinMoveDistanceTank.TabIndex = 29;
            this.numMinMoveDistanceTank.Tag = "XC";
            this.numMinMoveDistanceTank.Value = global::Mud.Properties.Settings.Default.AUTO_MOVE_FOLLOW_RANGE_MIN;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.cmbNavigationProvider);
            this.panel8.Location = new System.Drawing.Point(145, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(158, 23);
            this.panel8.TabIndex = 37;
            // 
            // cmbNavigationProvider
            // 
            this.cmbNavigationProvider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbNavigationProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNavigationProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNavigationProvider.FormattingEnabled = true;
            this.cmbNavigationProvider.Location = new System.Drawing.Point(0, 0);
            this.cmbNavigationProvider.Name = "cmbNavigationProvider";
            this.cmbNavigationProvider.Size = new System.Drawing.Size(156, 21);
            this.cmbNavigationProvider.TabIndex = 24;
            this.cmbNavigationProvider.SelectedIndexChanged += new System.EventHandler(this.OnSelectedNavigationProvider);
            // 
            // lblNavigationProvider
            // 
            this.lblNavigationProvider.AutoSize = true;
            this.lblNavigationProvider.Location = new System.Drawing.Point(6, 10);
            this.lblNavigationProvider.Name = "lblNavigationProvider";
            this.lblNavigationProvider.Size = new System.Drawing.Size(100, 13);
            this.lblNavigationProvider.TabIndex = 36;
            this.lblNavigationProvider.Text = "Navigation Provider";
            // 
            // cbxAutoFace
            // 
            this.cbxAutoFace.AutoSize = true;
            this.cbxAutoFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAutoFace.Location = new System.Drawing.Point(9, 36);
            this.cbxAutoFace.Name = "cbxAutoFace";
            this.cbxAutoFace.Size = new System.Drawing.Size(106, 17);
            this.cbxAutoFace.TabIndex = 27;
            this.cbxAutoFace.Tag = "XC";
            this.cbxAutoFace.Text = "Auto Face Target";
            this.cbxAutoFace.UseVisualStyleBackColor = true;
            // 
            // tabTargeting
            // 
            this.tabTargeting.Controls.Add(this.panel7);
            this.tabTargeting.Controls.Add(this.panel6);
            this.tabTargeting.Controls.Add(this.btnDelSelectedTargets);
            this.tabTargeting.Controls.Add(this.dgvTargetList);
            this.tabTargeting.Controls.Add(this.btnAddCurrentTarget);
            this.tabTargeting.Controls.Add(this.lblYalms);
            this.tabTargeting.Controls.Add(this.lblTargetingDistance);
            this.tabTargeting.Controls.Add(this.lblTargetingMode);
            this.tabTargeting.Controls.Add(this.lblTargetListType);
            this.tabTargeting.Controls.Add(this.numTargetingDistance);
            this.tabTargeting.Location = new System.Drawing.Point(4, 22);
            this.tabTargeting.Name = "tabTargeting";
            this.tabTargeting.Size = new System.Drawing.Size(309, 261);
            this.tabTargeting.TabIndex = 0;
            this.tabTargeting.Tag = "XC";
            this.tabTargeting.Text = "Targeting";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.cmbTargetingMode);
            this.panel7.Location = new System.Drawing.Point(157, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(149, 23);
            this.panel7.TabIndex = 19;
            // 
            // cmbTargetingMode
            // 
            this.cmbTargetingMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTargetingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetingMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTargetingMode.FormattingEnabled = true;
            this.cmbTargetingMode.Location = new System.Drawing.Point(0, 0);
            this.cmbTargetingMode.Name = "cmbTargetingMode";
            this.cmbTargetingMode.Size = new System.Drawing.Size(147, 21);
            this.cmbTargetingMode.TabIndex = 9;
            this.cmbTargetingMode.Tag = "XC";
            this.cmbTargetingMode.SelectedIndexChanged += new System.EventHandler(this.OnSelectedTargetingMode);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cmbTargetListType);
            this.panel6.Location = new System.Drawing.Point(3, 66);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 23);
            this.panel6.TabIndex = 18;
            // 
            // cmbTargetListType
            // 
            this.cmbTargetListType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTargetListType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetListType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTargetListType.FormattingEnabled = true;
            this.cmbTargetListType.Location = new System.Drawing.Point(0, 0);
            this.cmbTargetListType.Name = "cmbTargetListType";
            this.cmbTargetListType.Size = new System.Drawing.Size(221, 21);
            this.cmbTargetListType.TabIndex = 11;
            this.cmbTargetListType.Tag = "XC";
            this.cmbTargetListType.SelectedIndexChanged += new System.EventHandler(this.OnSelectedTargetListType);
            // 
            // btnDelSelectedTargets
            // 
            this.btnDelSelectedTargets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelSelectedTargets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelSelectedTargets.Location = new System.Drawing.Point(3, 235);
            this.btnDelSelectedTargets.Name = "btnDelSelectedTargets";
            this.btnDelSelectedTargets.Size = new System.Drawing.Size(138, 23);
            this.btnDelSelectedTargets.TabIndex = 17;
            this.btnDelSelectedTargets.Tag = "XC";
            this.btnDelSelectedTargets.Text = "Delete Selected Targets";
            this.btnDelSelectedTargets.UseVisualStyleBackColor = false;
            this.btnDelSelectedTargets.Click += new System.EventHandler(this.OnClickRemoveTargetList);
            // 
            // dgvTargetList
            // 
            this.dgvTargetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTargetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTargetList.Location = new System.Drawing.Point(3, 95);
            this.dgvTargetList.Name = "dgvTargetList";
            this.dgvTargetList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTargetList.Size = new System.Drawing.Size(302, 134);
            this.dgvTargetList.TabIndex = 16;
            this.dgvTargetList.Tag = "XC";
            this.dgvTargetList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdateTargetSettings);
            this.dgvTargetList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.UpdateTargetSettings);
            // 
            // btnAddCurrentTarget
            // 
            this.btnAddCurrentTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCurrentTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCurrentTarget.Location = new System.Drawing.Point(147, 235);
            this.btnAddCurrentTarget.Name = "btnAddCurrentTarget";
            this.btnAddCurrentTarget.Size = new System.Drawing.Size(159, 23);
            this.btnAddCurrentTarget.TabIndex = 15;
            this.btnAddCurrentTarget.Tag = "XC";
            this.btnAddCurrentTarget.Text = "Add Current Target";
            this.btnAddCurrentTarget.UseVisualStyleBackColor = false;
            this.btnAddCurrentTarget.Click += new System.EventHandler(this.OnClickAddTargetList);
            // 
            // lblYalms
            // 
            this.lblYalms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYalms.AutoSize = true;
            this.lblYalms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblYalms.Location = new System.Drawing.Point(270, 34);
            this.lblYalms.Name = "lblYalms";
            this.lblYalms.Size = new System.Drawing.Size(35, 13);
            this.lblYalms.TabIndex = 14;
            this.lblYalms.Tag = "XC";
            this.lblYalms.Text = "Yalms";
            // 
            // lblTargetingDistance
            // 
            this.lblTargetingDistance.AutoSize = true;
            this.lblTargetingDistance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTargetingDistance.Location = new System.Drawing.Point(3, 34);
            this.lblTargetingDistance.Name = "lblTargetingDistance";
            this.lblTargetingDistance.Size = new System.Drawing.Size(97, 13);
            this.lblTargetingDistance.TabIndex = 12;
            this.lblTargetingDistance.Tag = "XC";
            this.lblTargetingDistance.Text = "Targeting Distance";
            // 
            // lblTargetingMode
            // 
            this.lblTargetingMode.AutoSize = true;
            this.lblTargetingMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTargetingMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetingMode.Location = new System.Drawing.Point(4, 7);
            this.lblTargetingMode.Name = "lblTargetingMode";
            this.lblTargetingMode.Size = new System.Drawing.Size(82, 13);
            this.lblTargetingMode.TabIndex = 10;
            this.lblTargetingMode.Tag = "XC";
            this.lblTargetingMode.Text = "Targeting Mode";
            // 
            // lblTargetListType
            // 
            this.lblTargetListType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTargetListType.AutoSize = true;
            this.lblTargetListType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTargetListType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetListType.Location = new System.Drawing.Point(232, 76);
            this.lblTargetListType.Name = "lblTargetListType";
            this.lblTargetListType.Size = new System.Drawing.Size(73, 13);
            this.lblTargetListType.TabIndex = 5;
            this.lblTargetListType.Tag = "XC";
            this.lblTargetListType.Text = "Mobs Named:";
            // 
            // numTargetingDistance
            // 
            this.numTargetingDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numTargetingDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTargetingDistance.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Mud.Properties.Settings.Default, "MAX_TARGET_DISTANCE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numTargetingDistance.Location = new System.Drawing.Point(157, 32);
            this.numTargetingDistance.Name = "numTargetingDistance";
            this.numTargetingDistance.Size = new System.Drawing.Size(108, 20);
            this.numTargetingDistance.TabIndex = 13;
            this.numTargetingDistance.Tag = "XC";
            this.numTargetingDistance.Value = global::Mud.Properties.Settings.Default.MAX_TARGET_DISTANCE;
            // 
            // tabHotkeys
            // 
            this.tabHotkeys.Controls.Add(this.panel10);
            this.tabHotkeys.Controls.Add(this.label4);
            this.tabHotkeys.Controls.Add(this.panel5);
            this.tabHotkeys.Controls.Add(this.panel4);
            this.tabHotkeys.Controls.Add(this.panel3);
            this.tabHotkeys.Controls.Add(this.panel2);
            this.tabHotkeys.Controls.Add(this.lblHotkeyAddRemTargetList);
            this.tabHotkeys.Controls.Add(this.lblHotkeyMovement);
            this.tabHotkeys.Controls.Add(this.lblHotkeyTargetMode);
            this.tabHotkeys.Controls.Add(this.lblHotkeyPause);
            this.tabHotkeys.Controls.Add(this.tbxHotkeyToggleMoveMode);
            this.tabHotkeys.Controls.Add(this.tbxHotkeyAddRemTargetList);
            this.tabHotkeys.Controls.Add(this.tbxHotkeyMovement);
            this.tabHotkeys.Controls.Add(this.tbxHotkeyTargetMode);
            this.tabHotkeys.Controls.Add(this.tbxHotkeyPause);
            this.tabHotkeys.Location = new System.Drawing.Point(4, 22);
            this.tabHotkeys.Name = "tabHotkeys";
            this.tabHotkeys.Padding = new System.Windows.Forms.Padding(3);
            this.tabHotkeys.Size = new System.Drawing.Size(309, 261);
            this.tabHotkeys.TabIndex = 1;
            this.tabHotkeys.Tag = "XC";
            this.tabHotkeys.Text = "Hotkeys";
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.cmbHotkeyModifierToggleMoveMode);
            this.panel10.Location = new System.Drawing.Point(6, 146);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(130, 23);
            this.panel10.TabIndex = 23;
            // 
            // cmbHotkeyModifierToggleMoveMode
            // 
            this.cmbHotkeyModifierToggleMoveMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbHotkeyModifierToggleMoveMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotkeyModifierToggleMoveMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHotkeyModifierToggleMoveMode.FormattingEnabled = true;
            this.cmbHotkeyModifierToggleMoveMode.Location = new System.Drawing.Point(0, 0);
            this.cmbHotkeyModifierToggleMoveMode.Name = "cmbHotkeyModifierToggleMoveMode";
            this.cmbHotkeyModifierToggleMoveMode.Size = new System.Drawing.Size(128, 21);
            this.cmbHotkeyModifierToggleMoveMode.TabIndex = 15;
            this.cmbHotkeyModifierToggleMoveMode.Tag = "XC";
            this.cmbHotkeyModifierToggleMoveMode.SelectedIndexChanged += new System.EventHandler(this.OnSelectedHotkeyModifierMovementMode);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 21;
            this.label4.Tag = "XC";
            this.label4.Text = "Toggle Movement Mode";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cmbHotkeyModifierPause);
            this.panel5.Location = new System.Drawing.Point(6, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(130, 23);
            this.panel5.TabIndex = 20;
            // 
            // cmbHotkeyModifierPause
            // 
            this.cmbHotkeyModifierPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbHotkeyModifierPause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotkeyModifierPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHotkeyModifierPause.FormattingEnabled = true;
            this.cmbHotkeyModifierPause.Location = new System.Drawing.Point(0, 0);
            this.cmbHotkeyModifierPause.Name = "cmbHotkeyModifierPause";
            this.cmbHotkeyModifierPause.Size = new System.Drawing.Size(128, 21);
            this.cmbHotkeyModifierPause.TabIndex = 1;
            this.cmbHotkeyModifierPause.Tag = "XC";
            this.cmbHotkeyModifierPause.SelectedIndexChanged += new System.EventHandler(this.OnSelectedHotkeyModifierPause);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbHotkeyModifierTargetMode);
            this.panel4.Location = new System.Drawing.Point(7, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 23);
            this.panel4.TabIndex = 19;
            // 
            // cmbHotkeyModifierTargetMode
            // 
            this.cmbHotkeyModifierTargetMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbHotkeyModifierTargetMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotkeyModifierTargetMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHotkeyModifierTargetMode.FormattingEnabled = true;
            this.cmbHotkeyModifierTargetMode.Location = new System.Drawing.Point(0, 0);
            this.cmbHotkeyModifierTargetMode.Name = "cmbHotkeyModifierTargetMode";
            this.cmbHotkeyModifierTargetMode.Size = new System.Drawing.Size(128, 21);
            this.cmbHotkeyModifierTargetMode.TabIndex = 4;
            this.cmbHotkeyModifierTargetMode.Tag = "XC";
            this.cmbHotkeyModifierTargetMode.SelectedIndexChanged += new System.EventHandler(this.OnSelectedHotkeyModifierTargetMode);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbHotkeyModifierMovement);
            this.panel3.Location = new System.Drawing.Point(6, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 23);
            this.panel3.TabIndex = 18;
            // 
            // cmbHotkeyModifierMovement
            // 
            this.cmbHotkeyModifierMovement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbHotkeyModifierMovement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotkeyModifierMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHotkeyModifierMovement.FormattingEnabled = true;
            this.cmbHotkeyModifierMovement.Location = new System.Drawing.Point(0, 0);
            this.cmbHotkeyModifierMovement.Name = "cmbHotkeyModifierMovement";
            this.cmbHotkeyModifierMovement.Size = new System.Drawing.Size(128, 21);
            this.cmbHotkeyModifierMovement.TabIndex = 9;
            this.cmbHotkeyModifierMovement.Tag = "XC";
            this.cmbHotkeyModifierMovement.SelectedIndexChanged += new System.EventHandler(this.OnSelectedHotkeyModifierMovement);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmbHotkeyModifierAddRemTargetList);
            this.panel2.Location = new System.Drawing.Point(6, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 23);
            this.panel2.TabIndex = 17;
            // 
            // cmbHotkeyModifierAddRemTargetList
            // 
            this.cmbHotkeyModifierAddRemTargetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbHotkeyModifierAddRemTargetList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotkeyModifierAddRemTargetList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHotkeyModifierAddRemTargetList.FormattingEnabled = true;
            this.cmbHotkeyModifierAddRemTargetList.Location = new System.Drawing.Point(0, 0);
            this.cmbHotkeyModifierAddRemTargetList.Name = "cmbHotkeyModifierAddRemTargetList";
            this.cmbHotkeyModifierAddRemTargetList.Size = new System.Drawing.Size(128, 21);
            this.cmbHotkeyModifierAddRemTargetList.TabIndex = 15;
            this.cmbHotkeyModifierAddRemTargetList.Tag = "XC";
            this.cmbHotkeyModifierAddRemTargetList.SelectedIndexChanged += new System.EventHandler(this.OnSelectedHotkeyModifierRemoveTargetList);
            // 
            // lblHotkeyAddRemTargetList
            // 
            this.lblHotkeyAddRemTargetList.AutoSize = true;
            this.lblHotkeyAddRemTargetList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHotkeyAddRemTargetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotkeyAddRemTargetList.Location = new System.Drawing.Point(6, 172);
            this.lblHotkeyAddRemTargetList.Name = "lblHotkeyAddRemTargetList";
            this.lblHotkeyAddRemTargetList.Size = new System.Drawing.Size(166, 13);
            this.lblHotkeyAddRemTargetList.TabIndex = 14;
            this.lblHotkeyAddRemTargetList.Tag = "XC";
            this.lblHotkeyAddRemTargetList.Text = "Add/Rem Target From Target List";
            // 
            // lblHotkeyMovement
            // 
            this.lblHotkeyMovement.AutoSize = true;
            this.lblHotkeyMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHotkeyMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotkeyMovement.Location = new System.Drawing.Point(6, 92);
            this.lblHotkeyMovement.Name = "lblHotkeyMovement";
            this.lblHotkeyMovement.Size = new System.Drawing.Size(93, 13);
            this.lblHotkeyMovement.TabIndex = 8;
            this.lblHotkeyMovement.Tag = "XC";
            this.lblHotkeyMovement.Text = "Toggle Movement";
            // 
            // lblHotkeyTargetMode
            // 
            this.lblHotkeyTargetMode.AutoSize = true;
            this.lblHotkeyTargetMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHotkeyTargetMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotkeyTargetMode.Location = new System.Drawing.Point(6, 52);
            this.lblHotkeyTargetMode.Name = "lblHotkeyTargetMode";
            this.lblHotkeyTargetMode.Size = new System.Drawing.Size(104, 13);
            this.lblHotkeyTargetMode.TabIndex = 3;
            this.lblHotkeyTargetMode.Tag = "XC";
            this.lblHotkeyTargetMode.Text = "Toggle Target Mode";
            // 
            // lblHotkeyPause
            // 
            this.lblHotkeyPause.AutoSize = true;
            this.lblHotkeyPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHotkeyPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotkeyPause.Location = new System.Drawing.Point(6, 12);
            this.lblHotkeyPause.Name = "lblHotkeyPause";
            this.lblHotkeyPause.Size = new System.Drawing.Size(145, 13);
            this.lblHotkeyPause.TabIndex = 0;
            this.lblHotkeyPause.Tag = "XC";
            this.lblHotkeyPause.Text = "Pause / Unpause Mud Assist";
            // 
            // tbxHotkeyToggleMoveMode
            // 
            this.tbxHotkeyToggleMoveMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHotkeyToggleMoveMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHotkeyToggleMoveMode.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Mud.Properties.Settings.Default, "HOTKEY_MOVEMENT_MODE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxHotkeyToggleMoveMode.Location = new System.Drawing.Point(178, 149);
            this.tbxHotkeyToggleMoveMode.Name = "tbxHotkeyToggleMoveMode";
            this.tbxHotkeyToggleMoveMode.Size = new System.Drawing.Size(125, 20);
            this.tbxHotkeyToggleMoveMode.TabIndex = 22;
            this.tbxHotkeyToggleMoveMode.Tag = "XC";
            this.tbxHotkeyToggleMoveMode.Text = global::Mud.Properties.Settings.Default.HOTKEY_MOVEMENT_MODE;
            // 
            // tbxHotkeyAddRemTargetList
            // 
            this.tbxHotkeyAddRemTargetList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHotkeyAddRemTargetList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHotkeyAddRemTargetList.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Mud.Properties.Settings.Default, "HOTKEY_ADD_REM_TARGET_LIST", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxHotkeyAddRemTargetList.Location = new System.Drawing.Point(178, 189);
            this.tbxHotkeyAddRemTargetList.Name = "tbxHotkeyAddRemTargetList";
            this.tbxHotkeyAddRemTargetList.Size = new System.Drawing.Size(125, 20);
            this.tbxHotkeyAddRemTargetList.TabIndex = 16;
            this.tbxHotkeyAddRemTargetList.Tag = "XC";
            this.tbxHotkeyAddRemTargetList.Text = global::Mud.Properties.Settings.Default.HOTKEY_ADD_REM_TARGET_LIST;
            // 
            // tbxHotkeyMovement
            // 
            this.tbxHotkeyMovement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHotkeyMovement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHotkeyMovement.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Mud.Properties.Settings.Default, "HOTKEY_TOGGLE_MOVEMENT", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxHotkeyMovement.Location = new System.Drawing.Point(178, 109);
            this.tbxHotkeyMovement.Name = "tbxHotkeyMovement";
            this.tbxHotkeyMovement.Size = new System.Drawing.Size(125, 20);
            this.tbxHotkeyMovement.TabIndex = 10;
            this.tbxHotkeyMovement.Tag = "XC";
            this.tbxHotkeyMovement.Text = global::Mud.Properties.Settings.Default.HOTKEY_TOGGLE_MOVEMENT;
            // 
            // tbxHotkeyTargetMode
            // 
            this.tbxHotkeyTargetMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHotkeyTargetMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHotkeyTargetMode.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Mud.Properties.Settings.Default, "HOTKEY_TARGET_MODE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxHotkeyTargetMode.Location = new System.Drawing.Point(178, 69);
            this.tbxHotkeyTargetMode.Name = "tbxHotkeyTargetMode";
            this.tbxHotkeyTargetMode.Size = new System.Drawing.Size(125, 20);
            this.tbxHotkeyTargetMode.TabIndex = 5;
            this.tbxHotkeyTargetMode.Tag = "XC";
            this.tbxHotkeyTargetMode.Text = global::Mud.Properties.Settings.Default.HOTKEY_TARGET_MODE;
            // 
            // tbxHotkeyPause
            // 
            this.tbxHotkeyPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHotkeyPause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHotkeyPause.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Mud.Properties.Settings.Default, "HOTKEY_PAUSE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxHotkeyPause.Location = new System.Drawing.Point(178, 29);
            this.tbxHotkeyPause.Name = "tbxHotkeyPause";
            this.tbxHotkeyPause.Size = new System.Drawing.Size(125, 20);
            this.tbxHotkeyPause.TabIndex = 2;
            this.tbxHotkeyPause.Tag = "XC";
            this.tbxHotkeyPause.Text = global::Mud.Properties.Settings.Default.HOTKEY_PAUSE;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.gbxMiscellaneous);
            this.tabSettings.Controls.Add(this.gbxHotkeyMessages);
            this.tabSettings.Controls.Add(this.gbxQuesting);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(309, 261);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Tag = "XC";
            this.tabSettings.Text = "Settings";
            // 
            // gbxMiscellaneous
            // 
            this.gbxMiscellaneous.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxMiscellaneous.Controls.Add(this.cbxPaused);
            this.gbxMiscellaneous.Controls.Add(this.cbxExecuteMoving);
            this.gbxMiscellaneous.Controls.Add(this.cbxAutoSprint);
            this.gbxMiscellaneous.Controls.Add(this.cbxAlwaysOnTop);
            this.gbxMiscellaneous.Location = new System.Drawing.Point(3, 3);
            this.gbxMiscellaneous.Name = "gbxMiscellaneous";
            this.gbxMiscellaneous.Size = new System.Drawing.Size(303, 72);
            this.gbxMiscellaneous.TabIndex = 26;
            this.gbxMiscellaneous.TabStop = false;
            this.gbxMiscellaneous.Text = "General Settings";
            // 
            // cbxPaused
            // 
            this.cbxPaused.AutoSize = true;
            this.cbxPaused.Checked = global::Mud.Properties.Settings.Default.COMBAT_ROUTINE_PAUSED;
            this.cbxPaused.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Mud.Properties.Settings.Default, "COMBAT_ROUTINE_PAUSED", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxPaused.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPaused.Location = new System.Drawing.Point(6, 19);
            this.cbxPaused.Name = "cbxPaused";
            this.cbxPaused.Size = new System.Drawing.Size(105, 17);
            this.cbxPaused.TabIndex = 0;
            this.cbxPaused.Tag = "XC";
            this.cbxPaused.Text = "Pause All Actions";
            this.cbxPaused.UseVisualStyleBackColor = true;
            // 
            // cbxExecuteMoving
            // 
            this.cbxExecuteMoving.AutoSize = true;
            this.cbxExecuteMoving.Checked = global::Mud.Properties.Settings.Default.COMBAT_ROUTINE_EXECUTE_WHILE_MOVING;
            this.cbxExecuteMoving.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxExecuteMoving.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Mud.Properties.Settings.Default, "COMBAT_ROUTINE_EXECUTE_WHILE_MOVING", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxExecuteMoving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxExecuteMoving.Location = new System.Drawing.Point(6, 42);
            this.cbxExecuteMoving.Name = "cbxExecuteMoving";
            this.cbxExecuteMoving.Size = new System.Drawing.Size(130, 17);
            this.cbxExecuteMoving.TabIndex = 11;
            this.cbxExecuteMoving.Tag = "XC";
            this.cbxExecuteMoving.Text = "Execute While Moving";
            this.cbxExecuteMoving.UseVisualStyleBackColor = true;
            // 
            // cbxAutoSprint
            // 
            this.cbxAutoSprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAutoSprint.AutoSize = true;
            this.cbxAutoSprint.Checked = global::Mud.Properties.Settings.Default.AUTO_SPRINT;
            this.cbxAutoSprint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoSprint.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Mud.Properties.Settings.Default, "AUTO_SPRINT", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxAutoSprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAutoSprint.Location = new System.Drawing.Point(166, 42);
            this.cbxAutoSprint.Name = "cbxAutoSprint";
            this.cbxAutoSprint.Size = new System.Drawing.Size(123, 17);
            this.cbxAutoSprint.TabIndex = 18;
            this.cbxAutoSprint.Tag = "XC";
            this.cbxAutoSprint.Text = "Sprint Out Of Combat";
            this.cbxAutoSprint.UseVisualStyleBackColor = true;
            // 
            // cbxAlwaysOnTop
            // 
            this.cbxAlwaysOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAlwaysOnTop.AutoSize = true;
            this.cbxAlwaysOnTop.Checked = global::Mud.Properties.Settings.Default.UI_ALWAYS_ON_TOP;
            this.cbxAlwaysOnTop.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Mud.Properties.Settings.Default, "UI_ALWAYS_ON_TOP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxAlwaysOnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAlwaysOnTop.Location = new System.Drawing.Point(166, 19);
            this.cbxAlwaysOnTop.Name = "cbxAlwaysOnTop";
            this.cbxAlwaysOnTop.Size = new System.Drawing.Size(95, 17);
            this.cbxAlwaysOnTop.TabIndex = 19;
            this.cbxAlwaysOnTop.Tag = "XC";
            this.cbxAlwaysOnTop.Text = "Always On Top";
            this.cbxAlwaysOnTop.UseVisualStyleBackColor = true;
            this.cbxAlwaysOnTop.CheckedChanged += new System.EventHandler(this.OnCheckedAlwaysOnTop);
            // 
            // gbxHotkeyMessages
            // 
            this.gbxHotkeyMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxHotkeyMessages.Controls.Add(this.cbxFlashMessages);
            this.gbxHotkeyMessages.Controls.Add(this.cbxActivateFFXIV);
            this.gbxHotkeyMessages.Location = new System.Drawing.Point(3, 81);
            this.gbxHotkeyMessages.Name = "gbxHotkeyMessages";
            this.gbxHotkeyMessages.Size = new System.Drawing.Size(303, 47);
            this.gbxHotkeyMessages.TabIndex = 25;
            this.gbxHotkeyMessages.TabStop = false;
            this.gbxHotkeyMessages.Text = "Messages";
            // 
            // cbxFlashMessages
            // 
            this.cbxFlashMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFlashMessages.AutoSize = true;
            this.cbxFlashMessages.Checked = global::Mud.Properties.Settings.Default.UI_FLASH_MESSAGES;
            this.cbxFlashMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxFlashMessages.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Mud.Properties.Settings.Default, "UI_FLASH_MESSAGES", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxFlashMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxFlashMessages.Location = new System.Drawing.Point(6, 19);
            this.cbxFlashMessages.Name = "cbxFlashMessages";
            this.cbxFlashMessages.Size = new System.Drawing.Size(136, 17);
            this.cbxFlashMessages.TabIndex = 23;
            this.cbxFlashMessages.Tag = "XC";
            this.cbxFlashMessages.Text = "Flash Screen Messages";
            this.cbxFlashMessages.UseVisualStyleBackColor = true;
            // 
            // cbxActivateFFXIV
            // 
            this.cbxActivateFFXIV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxActivateFFXIV.AutoSize = true;
            this.cbxActivateFFXIV.Checked = global::Mud.Properties.Settings.Default.UI_ACTIVATE_FFXIV;
            this.cbxActivateFFXIV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActivateFFXIV.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Mud.Properties.Settings.Default, "UI_ACTIVATE_FFXIV", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxActivateFFXIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxActivateFFXIV.Location = new System.Drawing.Point(166, 19);
            this.cbxActivateFFXIV.Name = "cbxActivateFFXIV";
            this.cbxActivateFFXIV.Size = new System.Drawing.Size(128, 17);
            this.cbxActivateFFXIV.TabIndex = 24;
            this.cbxActivateFFXIV.Tag = "XC";
            this.cbxActivateFFXIV.Text = "Reactivate After Flash";
            this.cbxActivateFFXIV.UseVisualStyleBackColor = true;
            // 
            // gbxQuesting
            // 
            this.gbxQuesting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxQuesting.Controls.Add(this.cbxAutoTalkToNPCs);
            this.gbxQuesting.Controls.Add(this.cbxAutoAcceptQuests);
            this.gbxQuesting.Location = new System.Drawing.Point(3, 134);
            this.gbxQuesting.Name = "gbxQuesting";
            this.gbxQuesting.Size = new System.Drawing.Size(303, 124);
            this.gbxQuesting.TabIndex = 22;
            this.gbxQuesting.TabStop = false;
            this.gbxQuesting.Text = "Questing";
            // 
            // cbxAutoTalkToNPCs
            // 
            this.cbxAutoTalkToNPCs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAutoTalkToNPCs.AutoSize = true;
            this.cbxAutoTalkToNPCs.Checked = global::Mud.Properties.Settings.Default.AUTO_TALK_NPCS;
            this.cbxAutoTalkToNPCs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoTalkToNPCs.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Mud.Properties.Settings.Default, "AUTO_TALK_NPCS", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxAutoTalkToNPCs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAutoTalkToNPCs.Location = new System.Drawing.Point(6, 19);
            this.cbxAutoTalkToNPCs.Name = "cbxAutoTalkToNPCs";
            this.cbxAutoTalkToNPCs.Size = new System.Drawing.Size(115, 17);
            this.cbxAutoTalkToNPCs.TabIndex = 20;
            this.cbxAutoTalkToNPCs.Tag = "XC";
            this.cbxAutoTalkToNPCs.Text = "Auto Talk To NPCs";
            this.cbxAutoTalkToNPCs.UseVisualStyleBackColor = true;
            // 
            // cbxAutoAcceptQuests
            // 
            this.cbxAutoAcceptQuests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAutoAcceptQuests.AutoSize = true;
            this.cbxAutoAcceptQuests.Checked = global::Mud.Properties.Settings.Default.AUTO_ACCEPT_QUESTS;
            this.cbxAutoAcceptQuests.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoAcceptQuests.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Mud.Properties.Settings.Default, "AUTO_ACCEPT_QUESTS", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbxAutoAcceptQuests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAutoAcceptQuests.Location = new System.Drawing.Point(166, 19);
            this.cbxAutoAcceptQuests.Name = "cbxAutoAcceptQuests";
            this.cbxAutoAcceptQuests.Size = new System.Drawing.Size(118, 17);
            this.cbxAutoAcceptQuests.TabIndex = 21;
            this.cbxAutoAcceptQuests.Tag = "XC";
            this.cbxAutoAcceptQuests.Text = "Auto Accept Quests";
            this.cbxAutoAcceptQuests.UseVisualStyleBackColor = true;
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAndClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndClose.Location = new System.Drawing.Point(198, 305);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(131, 23);
            this.btnSaveAndClose.TabIndex = 1;
            this.btnSaveAndClose.Tag = "XC";
            this.btnSaveAndClose.Text = "Save and Close";
            this.btnSaveAndClose.UseVisualStyleBackColor = false;
            this.btnSaveAndClose.Click += new System.EventHandler(this.OnClickSaveAndClose);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(12, 305);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Tag = "XC";
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.OnClickReset);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(121, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 3;
            this.button1.Tag = "XC";
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.OnClickSave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspPauseStatus,
            this.tspMovementStatus,
            this.tspFollowModeStatus,
            this.tspTargetModeStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 336);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(341, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tspPauseStatus
            // 
            this.tspPauseStatus.Name = "tspPauseStatus";
            this.tspPauseStatus.Size = new System.Drawing.Size(98, 17);
            this.tspPauseStatus.Spring = true;
            // 
            // tspMovementStatus
            // 
            this.tspMovementStatus.Name = "tspMovementStatus";
            this.tspMovementStatus.Size = new System.Drawing.Size(98, 17);
            this.tspMovementStatus.Spring = true;
            // 
            // tspFollowModeStatus
            // 
            this.tspFollowModeStatus.Name = "tspFollowModeStatus";
            this.tspFollowModeStatus.Size = new System.Drawing.Size(98, 17);
            this.tspFollowModeStatus.Spring = true;
            // 
            // tspTargetModeStatus
            // 
            this.tspTargetModeStatus.Name = "tspTargetModeStatus";
            this.tspTargetModeStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 358);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Tag = "XC";
            this.Text = "Mud Assist Settings";
            this.tabControlMain.ResumeLayout(false);
            this.tabRoutine.ResumeLayout(false);
            this.tabRoutine.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.gbxOutOfCombat.ResumeLayout(false);
            this.gbxOutOfCombat.PerformLayout();
            this.gbxCombatActions.ResumeLayout(false);
            this.gbxCombatActions.PerformLayout();
            this.tabMovement.ResumeLayout(false);
            this.tabMovement.PerformLayout();
            this.gbxMoveInRange.ResumeLayout(false);
            this.gbxMoveInRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoMoveTargetRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMoveDistanceTank)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMinMoveDistanceTank)).EndInit();
            this.panel8.ResumeLayout(false);
            this.tabTargeting.ResumeLayout(false);
            this.tabTargeting.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTargetList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetingDistance)).EndInit();
            this.tabHotkeys.ResumeLayout(false);
            this.tabHotkeys.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.gbxMiscellaneous.ResumeLayout(false);
            this.gbxMiscellaneous.PerformLayout();
            this.gbxHotkeyMessages.ResumeLayout(false);
            this.gbxHotkeyMessages.PerformLayout();
            this.gbxQuesting.ResumeLayout(false);
            this.gbxQuesting.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxPaused;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabTargeting;
        private System.Windows.Forms.Label lblTargetListType;
        private System.Windows.Forms.Button btnSaveAndClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TabPage tabHotkeys;
        private System.Windows.Forms.TextBox tbxHotkeyPause;
        private System.Windows.Forms.ComboBox cmbHotkeyModifierPause;
        private System.Windows.Forms.Label lblHotkeyPause;
        private System.Windows.Forms.TextBox tbxHotkeyTargetMode;
        private System.Windows.Forms.ComboBox cmbHotkeyModifierTargetMode;
        private System.Windows.Forms.Label lblHotkeyTargetMode;
        private System.Windows.Forms.Label lblTargetingMode;
        private System.Windows.Forms.ComboBox cmbTargetingMode;
        private System.Windows.Forms.ComboBox cmbTargetListType;
        private System.Windows.Forms.CheckBox cbxExecuteMoving;
        private System.Windows.Forms.Label lblYalms;
        private System.Windows.Forms.NumericUpDown numTargetingDistance;
        private System.Windows.Forms.Label lblTargetingDistance;
        private System.Windows.Forms.TabPage tabRoutine;
        private System.Windows.Forms.CheckBox cbxCombat;
        private System.Windows.Forms.CheckBox cbxCombatBuff;
        private System.Windows.Forms.CheckBox cbxCombatHeal;
        private System.Windows.Forms.CheckBox cbxOutOfCombatBuff;
        private System.Windows.Forms.CheckBox cbxOutOfCombatAttack;
        private System.Windows.Forms.CheckBox cbxOutOfCombatHeal;
        private System.Windows.Forms.CheckBox cbxAutoSprint;
        private System.Windows.Forms.Button btnAddCurrentTarget;
        private System.Windows.Forms.DataGridView dgvTargetList;
        private System.Windows.Forms.CheckBox cbxAlwaysOnTop;
        private System.Windows.Forms.Button btnDelSelectedTargets;
        private System.Windows.Forms.TextBox tbxHotkeyAddRemTargetList;
        private System.Windows.Forms.ComboBox cmbHotkeyModifierAddRemTargetList;
        private System.Windows.Forms.Label lblHotkeyAddRemTargetList;
        private System.Windows.Forms.TextBox tbxHotkeyMovement;
        private System.Windows.Forms.ComboBox cmbHotkeyModifierMovement;
        private System.Windows.Forms.Label lblHotkeyMovement;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TabPage tabMovement;
        private System.Windows.Forms.GroupBox gbxOutOfCombat;
        private System.Windows.Forms.GroupBox gbxCombatActions;
        private System.Windows.Forms.CheckBox cbxOutOfCombatRest;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cmbCombatRoutines;
        private System.Windows.Forms.Label lblCombatRoutineName;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxQuesting;
        private System.Windows.Forms.CheckBox cbxAutoTalkToNPCs;
        private System.Windows.Forms.CheckBox cbxAutoAcceptQuests;
        private System.Windows.Forms.CheckBox cbxActivateFFXIV;
        private System.Windows.Forms.CheckBox cbxFlashMessages;
        private System.Windows.Forms.GroupBox gbxHotkeyMessages;
        private System.Windows.Forms.GroupBox gbxMiscellaneous;
        private System.Windows.Forms.GroupBox gbxMoveInRange;
        private System.Windows.Forms.CheckBox cbxAutoMoveTarget;
        private System.Windows.Forms.NumericUpDown numMaxMoveDistanceTank;
        private System.Windows.Forms.Label lblYalms3;
        private System.Windows.Forms.Label lblYalms2;
        private System.Windows.Forms.Label lblWhen;
        private System.Windows.Forms.NumericUpDown numMinMoveDistanceTank;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cmbNavigationProvider;
        private System.Windows.Forms.Label lblNavigationProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbMovementMode;
        private System.Windows.Forms.CheckBox cbxAutoFace;
        private System.Windows.Forms.Label lblOf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numAutoMoveTargetRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cmbHotkeyModifierToggleMoveMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxHotkeyToggleMoveMode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tspPauseStatus;
        private System.Windows.Forms.ToolStripStatusLabel tspMovementStatus;
        private System.Windows.Forms.ToolStripStatusLabel tspFollowModeStatus;
        private System.Windows.Forms.ToolStripStatusLabel tspTargetModeStatus;
    }
}