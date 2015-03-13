namespace Win.App.Server
{
    partial class Participants
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label teamNameLabel;
            System.Windows.Forms.Label participant1Label;
            System.Windows.Forms.Label participant2Label;
            System.Windows.Forms.Label participant3Label;
            System.Windows.Forms.Label participant4Label;
            System.Windows.Forms.Label participant5Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Participants));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.quizBeeDataSet = new Win.App.Server.QuizBeeDataSet();
            this.participantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participantsTableAdapter = new Win.App.Server.QuizBeeDataSetTableAdapters.ParticipantsTableAdapter();
            this.tableAdapterManager = new Win.App.Server.QuizBeeDataSetTableAdapters.TableAdapterManager();
            this.participantsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.participantsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.participantsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.participant1TextBox = new System.Windows.Forms.TextBox();
            this.participant2TextBox = new System.Windows.Forms.TextBox();
            this.participant3TextBox = new System.Windows.Forms.TextBox();
            this.participant4TextBox = new System.Windows.Forms.TextBox();
            this.participant5TextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            teamNameLabel = new System.Windows.Forms.Label();
            participant1Label = new System.Windows.Forms.Label();
            participant2Label = new System.Windows.Forms.Label();
            participant3Label = new System.Windows.Forms.Label();
            participant4Label = new System.Windows.Forms.Label();
            participant5Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quizBeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingNavigator)).BeginInit();
            this.participantsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(397, 89);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(32, 18);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            teamNameLabel.Location = new System.Drawing.Point(317, 121);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new System.Drawing.Size(113, 18);
            teamNameLabel.TabIndex = 4;
            teamNameLabel.Text = "Team Name:";
            // 
            // participant1Label
            // 
            participant1Label.AutoSize = true;
            participant1Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            participant1Label.Location = new System.Drawing.Point(317, 150);
            participant1Label.Name = "participant1Label";
            participant1Label.Size = new System.Drawing.Size(113, 18);
            participant1Label.TabIndex = 6;
            participant1Label.Text = "Participant1:";
            // 
            // participant2Label
            // 
            participant2Label.AutoSize = true;
            participant2Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            participant2Label.Location = new System.Drawing.Point(317, 183);
            participant2Label.Name = "participant2Label";
            participant2Label.Size = new System.Drawing.Size(113, 18);
            participant2Label.TabIndex = 8;
            participant2Label.Text = "Participant2:";
            // 
            // participant3Label
            // 
            participant3Label.AutoSize = true;
            participant3Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            participant3Label.Location = new System.Drawing.Point(317, 219);
            participant3Label.Name = "participant3Label";
            participant3Label.Size = new System.Drawing.Size(113, 18);
            participant3Label.TabIndex = 10;
            participant3Label.Text = "Participant3:";
            // 
            // participant4Label
            // 
            participant4Label.AutoSize = true;
            participant4Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            participant4Label.Location = new System.Drawing.Point(317, 249);
            participant4Label.Name = "participant4Label";
            participant4Label.Size = new System.Drawing.Size(113, 18);
            participant4Label.TabIndex = 12;
            participant4Label.Text = "Participant4:";
            // 
            // participant5Label
            // 
            participant5Label.AutoSize = true;
            participant5Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            participant5Label.Location = new System.Drawing.Point(317, 282);
            participant5Label.Name = "participant5Label";
            participant5Label.Size = new System.Drawing.Size(113, 18);
            participant5Label.TabIndex = 14;
            participant5Label.Text = "Participant5:";
            // 
            // quizBeeDataSet
            // 
            this.quizBeeDataSet.DataSetName = "QuizBeeDataSet";
            this.quizBeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // participantsBindingSource
            // 
            this.participantsBindingSource.DataMember = "Participants";
            this.participantsBindingSource.DataSource = this.quizBeeDataSet;
            // 
            // participantsTableAdapter
            // 
            this.participantsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClincherTableAdapter = null;
            this.tableAdapterManager.ContestantScoreTableAdapter = null;
            this.tableAdapterManager.GContestantScoreTableAdapter = null;
            this.tableAdapterManager.GParticipantsTableAdapter = null;
            this.tableAdapterManager.GQuizTableAdapter = null;
            this.tableAdapterManager.ParticipantsTableAdapter = this.participantsTableAdapter;
            this.tableAdapterManager.QuizL1TableAdapter = null;
            this.tableAdapterManager.QuizL2TableAdapter = null;
            this.tableAdapterManager.QuizL3TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Win.App.Server.QuizBeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // participantsBindingNavigator
            // 
            this.participantsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.participantsBindingNavigator.AutoSize = false;
            this.participantsBindingNavigator.BackColor = System.Drawing.Color.White;
            this.participantsBindingNavigator.BindingSource = this.participantsBindingSource;
            this.participantsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.participantsBindingNavigator.DeleteItem = null;
            this.participantsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.participantsBindingNavigator.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.participantsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator1,
            this.participantsBindingNavigatorSaveItem,
            this.toolStripSeparator2,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator3,
            this.bindingNavigatorMoveFirstItem,
            this.toolStripSeparator4,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorMoveLastItem});
            this.participantsBindingNavigator.Location = new System.Drawing.Point(367, 13);
            this.participantsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.participantsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.participantsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.participantsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.participantsBindingNavigator.Name = "participantsBindingNavigator";
            this.participantsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.participantsBindingNavigator.Size = new System.Drawing.Size(562, 52);
            this.participantsBindingNavigator.TabIndex = 0;
            this.participantsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.AutoSize = false;
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(55, 46);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.AutoSize = false;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(56, 63);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // participantsBindingNavigatorSaveItem
            // 
            this.participantsBindingNavigatorSaveItem.AutoSize = false;
            this.participantsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.participantsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("participantsBindingNavigatorSaveItem.Image")));
            this.participantsBindingNavigatorSaveItem.Name = "participantsBindingNavigatorSaveItem";
            this.participantsBindingNavigatorSaveItem.Size = new System.Drawing.Size(55, 46);
            this.participantsBindingNavigatorSaveItem.Text = "Save Data";
            this.participantsBindingNavigatorSaveItem.Click += new System.EventHandler(this.participantsBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.AutoSize = false;
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(55, 46);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.AutoSize = false;
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(55, 46);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.AutoSize = false;
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(55, 46);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 33);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.AutoSize = false;
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(55, 46);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.AutoSize = false;
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(55, 46);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // participantsDataGridView
            // 
            this.participantsDataGridView.AutoGenerateColumns = false;
            this.participantsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.participantsDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.participantsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.participantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participantsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.participantsDataGridView.DataSource = this.participantsBindingSource;
            this.participantsDataGridView.Location = new System.Drawing.Point(64, 328);
            this.participantsDataGridView.Name = "participantsDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.participantsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.participantsDataGridView.Size = new System.Drawing.Size(1183, 344);
            this.participantsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 48;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TeamName";
            this.dataGridViewTextBoxColumn2.HeaderText = "TeamName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 115;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Participant1";
            this.dataGridViewTextBoxColumn3.HeaderText = "Participant1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 121;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Participant2";
            this.dataGridViewTextBoxColumn4.HeaderText = "Participant2";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 121;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Participant3";
            this.dataGridViewTextBoxColumn5.HeaderText = "Participant3";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 121;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Participant4";
            this.dataGridViewTextBoxColumn6.HeaderText = "Participant4";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 121;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Participant5";
            this.dataGridViewTextBoxColumn7.HeaderText = "Participant5";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 121;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.participantsBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(441, 84);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(55, 30);
            this.idTextBox.TabIndex = 3;
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.participantsBindingSource, "TeamName", true));
            this.teamNameTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameTextBox.Location = new System.Drawing.Point(441, 117);
            this.teamNameTextBox.Multiline = true;
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(578, 30);
            this.teamNameTextBox.TabIndex = 5;
            // 
            // participant1TextBox
            // 
            this.participant1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.participantsBindingSource, "Participant1", true));
            this.participant1TextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participant1TextBox.Location = new System.Drawing.Point(441, 149);
            this.participant1TextBox.Multiline = true;
            this.participant1TextBox.Name = "participant1TextBox";
            this.participant1TextBox.Size = new System.Drawing.Size(578, 30);
            this.participant1TextBox.TabIndex = 7;
            // 
            // participant2TextBox
            // 
            this.participant2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.participantsBindingSource, "Participant2", true));
            this.participant2TextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participant2TextBox.Location = new System.Drawing.Point(441, 183);
            this.participant2TextBox.Name = "participant2TextBox";
            this.participant2TextBox.Size = new System.Drawing.Size(578, 23);
            this.participant2TextBox.TabIndex = 9;
            // 
            // participant3TextBox
            // 
            this.participant3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.participantsBindingSource, "Participant3", true));
            this.participant3TextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participant3TextBox.Location = new System.Drawing.Point(441, 211);
            this.participant3TextBox.Multiline = true;
            this.participant3TextBox.Name = "participant3TextBox";
            this.participant3TextBox.Size = new System.Drawing.Size(578, 30);
            this.participant3TextBox.TabIndex = 11;
            // 
            // participant4TextBox
            // 
            this.participant4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.participantsBindingSource, "Participant4", true));
            this.participant4TextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participant4TextBox.Location = new System.Drawing.Point(441, 245);
            this.participant4TextBox.Name = "participant4TextBox";
            this.participant4TextBox.Size = new System.Drawing.Size(578, 23);
            this.participant4TextBox.TabIndex = 13;
            // 
            // participant5TextBox
            // 
            this.participant5TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.participantsBindingSource, "Participant5", true));
            this.participant5TextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participant5TextBox.Location = new System.Drawing.Point(441, 273);
            this.participant5TextBox.Multiline = true;
            this.participant5TextBox.Name = "participant5TextBox";
            this.participant5TextBox.Size = new System.Drawing.Size(578, 30);
            this.participant5TextBox.TabIndex = 15;
            // 
            // Participants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 684);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(teamNameLabel);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(participant1Label);
            this.Controls.Add(this.participant1TextBox);
            this.Controls.Add(participant2Label);
            this.Controls.Add(this.participant2TextBox);
            this.Controls.Add(participant3Label);
            this.Controls.Add(this.participant3TextBox);
            this.Controls.Add(participant4Label);
            this.Controls.Add(this.participant4TextBox);
            this.Controls.Add(participant5Label);
            this.Controls.Add(this.participant5TextBox);
            this.Controls.Add(this.participantsDataGridView);
            this.Controls.Add(this.participantsBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Participants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Participants";
            this.Load += new System.EventHandler(this.Participants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quizBeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingNavigator)).EndInit();
            this.participantsBindingNavigator.ResumeLayout(false);
            this.participantsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuizBeeDataSet quizBeeDataSet;
        private System.Windows.Forms.BindingSource participantsBindingSource;
        private QuizBeeDataSetTableAdapters.ParticipantsTableAdapter participantsTableAdapter;
        private QuizBeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator participantsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton participantsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView participantsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.TextBox participant1TextBox;
        private System.Windows.Forms.TextBox participant2TextBox;
        private System.Windows.Forms.TextBox participant3TextBox;
        private System.Windows.Forms.TextBox participant4TextBox;
        private System.Windows.Forms.TextBox participant5TextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}