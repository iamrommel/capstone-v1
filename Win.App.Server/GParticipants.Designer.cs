namespace Win.App.Server
{
    partial class GParticipants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GParticipants));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.quizBeeDataSet = new Win.App.Server.QuizBeeDataSet();
            this.gParticipantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gParticipantsTableAdapter = new Win.App.Server.QuizBeeDataSetTableAdapters.GParticipantsTableAdapter();
            this.tableAdapterManager = new Win.App.Server.QuizBeeDataSetTableAdapters.TableAdapterManager();
            this.gParticipantsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gParticipantsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            this.gParticipantsDataGridView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.gParticipantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gParticipantsBindingNavigator)).BeginInit();
            this.gParticipantsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gParticipantsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(373, 86);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(32, 18);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            teamNameLabel.Location = new System.Drawing.Point(292, 117);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new System.Drawing.Size(113, 18);
            teamNameLabel.TabIndex = 4;
            teamNameLabel.Text = "Team Name:";
            // 
            // participant1Label
            // 
            participant1Label.AutoSize = true;
            participant1Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            participant1Label.Location = new System.Drawing.Point(292, 146);
            participant1Label.Name = "participant1Label";
            participant1Label.Size = new System.Drawing.Size(113, 18);
            participant1Label.TabIndex = 6;
            participant1Label.Text = "Participant1:";
            // 
            // participant2Label
            // 
            participant2Label.AutoSize = true;
            participant2Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            participant2Label.Location = new System.Drawing.Point(292, 179);
            participant2Label.Name = "participant2Label";
            participant2Label.Size = new System.Drawing.Size(113, 18);
            participant2Label.TabIndex = 8;
            participant2Label.Text = "Participant2:";
            // 
            // participant3Label
            // 
            participant3Label.AutoSize = true;
            participant3Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            participant3Label.Location = new System.Drawing.Point(292, 216);
            participant3Label.Name = "participant3Label";
            participant3Label.Size = new System.Drawing.Size(113, 18);
            participant3Label.TabIndex = 10;
            participant3Label.Text = "Participant3:";
            // 
            // participant4Label
            // 
            participant4Label.AutoSize = true;
            participant4Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            participant4Label.Location = new System.Drawing.Point(292, 248);
            participant4Label.Name = "participant4Label";
            participant4Label.Size = new System.Drawing.Size(113, 18);
            participant4Label.TabIndex = 12;
            participant4Label.Text = "Participant4:";
            // 
            // participant5Label
            // 
            participant5Label.AutoSize = true;
            participant5Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            participant5Label.Location = new System.Drawing.Point(292, 279);
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
            // gParticipantsBindingSource
            // 
            this.gParticipantsBindingSource.DataMember = "GParticipants";
            this.gParticipantsBindingSource.DataSource = this.quizBeeDataSet;
            // 
            // gParticipantsTableAdapter
            // 
            this.gParticipantsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClincherTableAdapter = null;
            this.tableAdapterManager.ContestantScoreTableAdapter = null;
            this.tableAdapterManager.GContestantScoreTableAdapter = null;
            this.tableAdapterManager.GParticipantsTableAdapter = this.gParticipantsTableAdapter;
            this.tableAdapterManager.GQuizTableAdapter = null;
            this.tableAdapterManager.ParticipantsTableAdapter = null;
            this.tableAdapterManager.QuizL1TableAdapter = null;
            this.tableAdapterManager.QuizL2TableAdapter = null;
            this.tableAdapterManager.QuizL3TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Win.App.Server.QuizBeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gParticipantsBindingNavigator
            // 
            this.gParticipantsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gParticipantsBindingNavigator.AutoSize = false;
            this.gParticipantsBindingNavigator.BindingSource = this.gParticipantsBindingSource;
            this.gParticipantsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gParticipantsBindingNavigator.DeleteItem = null;
            this.gParticipantsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.gParticipantsBindingNavigator.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.gParticipantsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator1,
            this.gParticipantsBindingNavigatorSaveItem,
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
            this.gParticipantsBindingNavigator.Location = new System.Drawing.Point(367, 13);
            this.gParticipantsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gParticipantsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gParticipantsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gParticipantsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gParticipantsBindingNavigator.Name = "gParticipantsBindingNavigator";
            this.gParticipantsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gParticipantsBindingNavigator.Size = new System.Drawing.Size(562, 52);
            this.gParticipantsBindingNavigator.TabIndex = 0;
            this.gParticipantsBindingNavigator.Text = "bindingNavigator1";
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
            // gParticipantsBindingNavigatorSaveItem
            // 
            this.gParticipantsBindingNavigatorSaveItem.AutoSize = false;
            this.gParticipantsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gParticipantsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gParticipantsBindingNavigatorSaveItem.Image")));
            this.gParticipantsBindingNavigatorSaveItem.Name = "gParticipantsBindingNavigatorSaveItem";
            this.gParticipantsBindingNavigatorSaveItem.Size = new System.Drawing.Size(55, 46);
            this.gParticipantsBindingNavigatorSaveItem.Text = "Save Data";
            this.gParticipantsBindingNavigatorSaveItem.Click += new System.EventHandler(this.gParticipantsBindingNavigatorSaveItem_Click);
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
            // gParticipantsDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gParticipantsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gParticipantsDataGridView.AutoGenerateColumns = false;
            this.gParticipantsDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gParticipantsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gParticipantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gParticipantsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.gParticipantsDataGridView.DataSource = this.gParticipantsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gParticipantsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.gParticipantsDataGridView.Location = new System.Drawing.Point(89, 324);
            this.gParticipantsDataGridView.Name = "gParticipantsDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gParticipantsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gParticipantsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gParticipantsDataGridView.Size = new System.Drawing.Size(1183, 344);
            this.gParticipantsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TeamName";
            this.dataGridViewTextBoxColumn2.HeaderText = "TeamName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Participant1";
            this.dataGridViewTextBoxColumn3.HeaderText = "Participant1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Participant2";
            this.dataGridViewTextBoxColumn4.HeaderText = "Participant2";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Participant3";
            this.dataGridViewTextBoxColumn5.HeaderText = "Participant3";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Participant4";
            this.dataGridViewTextBoxColumn6.HeaderText = "Participant4";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Participant5";
            this.dataGridViewTextBoxColumn7.HeaderText = "Participant5";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gParticipantsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(422, 81);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(53, 30);
            this.idTextBox.TabIndex = 3;
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gParticipantsBindingSource, "TeamName", true));
            this.teamNameTextBox.Location = new System.Drawing.Point(422, 114);
            this.teamNameTextBox.Multiline = true;
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(578, 30);
            this.teamNameTextBox.TabIndex = 5;
            // 
            // participant1TextBox
            // 
            this.participant1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gParticipantsBindingSource, "Participant1", true));
            this.participant1TextBox.Location = new System.Drawing.Point(422, 146);
            this.participant1TextBox.Multiline = true;
            this.participant1TextBox.Name = "participant1TextBox";
            this.participant1TextBox.Size = new System.Drawing.Size(578, 30);
            this.participant1TextBox.TabIndex = 7;
            // 
            // participant2TextBox
            // 
            this.participant2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gParticipantsBindingSource, "Participant2", true));
            this.participant2TextBox.Location = new System.Drawing.Point(422, 179);
            this.participant2TextBox.Multiline = true;
            this.participant2TextBox.Name = "participant2TextBox";
            this.participant2TextBox.Size = new System.Drawing.Size(578, 30);
            this.participant2TextBox.TabIndex = 9;
            // 
            // participant3TextBox
            // 
            this.participant3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gParticipantsBindingSource, "Participant3", true));
            this.participant3TextBox.Location = new System.Drawing.Point(422, 211);
            this.participant3TextBox.Multiline = true;
            this.participant3TextBox.Name = "participant3TextBox";
            this.participant3TextBox.Size = new System.Drawing.Size(578, 30);
            this.participant3TextBox.TabIndex = 11;
            // 
            // participant4TextBox
            // 
            this.participant4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gParticipantsBindingSource, "Participant4", true));
            this.participant4TextBox.Location = new System.Drawing.Point(422, 242);
            this.participant4TextBox.Multiline = true;
            this.participant4TextBox.Name = "participant4TextBox";
            this.participant4TextBox.Size = new System.Drawing.Size(578, 30);
            this.participant4TextBox.TabIndex = 13;
            // 
            // participant5TextBox
            // 
            this.participant5TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gParticipantsBindingSource, "Participant5", true));
            this.participant5TextBox.Location = new System.Drawing.Point(422, 274);
            this.participant5TextBox.Multiline = true;
            this.participant5TextBox.Name = "participant5TextBox";
            this.participant5TextBox.Size = new System.Drawing.Size(578, 30);
            this.participant5TextBox.TabIndex = 15;
            // 
            // GParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 680);
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
            this.Controls.Add(this.gParticipantsDataGridView);
            this.Controls.Add(this.gParticipantsBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GParticipants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GParticipants";
            this.Load += new System.EventHandler(this.GParticipants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quizBeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gParticipantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gParticipantsBindingNavigator)).EndInit();
            this.gParticipantsBindingNavigator.ResumeLayout(false);
            this.gParticipantsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gParticipantsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuizBeeDataSet quizBeeDataSet;
        private System.Windows.Forms.BindingSource gParticipantsBindingSource;
        private QuizBeeDataSetTableAdapters.GParticipantsTableAdapter gParticipantsTableAdapter;
        private QuizBeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gParticipantsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gParticipantsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView gParticipantsDataGridView;
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