namespace Win.App.Server
{
    partial class AddGQuiz
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
            System.Windows.Forms.Label questionNumberLabel;
            System.Windows.Forms.Label questionsLabel;
            System.Windows.Forms.Label option1Label;
            System.Windows.Forms.Label option2Label;
            System.Windows.Forms.Label option3Label;
            System.Windows.Forms.Label option4Label;
            System.Windows.Forms.Label timeFrameLabel;
            System.Windows.Forms.Label answerKeyLabel;
            System.Windows.Forms.Label difficultyLevelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGQuiz));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.quizBeeDataSet = new Win.App.Server.QuizBeeDataSet();
            this.gQuizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gQuizTableAdapter = new Win.App.Server.QuizBeeDataSetTableAdapters.GQuizTableAdapter();
            this.tableAdapterManager = new Win.App.Server.QuizBeeDataSetTableAdapters.TableAdapterManager();
            this.gQuizBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gQuizBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            this.gQuizDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionNumberTextBox = new System.Windows.Forms.TextBox();
            this.questionsTextBox = new System.Windows.Forms.TextBox();
            this.option1TextBox = new System.Windows.Forms.TextBox();
            this.option2TextBox = new System.Windows.Forms.TextBox();
            this.option3TextBox = new System.Windows.Forms.TextBox();
            this.option4TextBox = new System.Windows.Forms.TextBox();
            this.timeFrameTextBox = new System.Windows.Forms.TextBox();
            this.answerKeyTextBox = new System.Windows.Forms.TextBox();
            this.difficultyLevelTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            questionNumberLabel = new System.Windows.Forms.Label();
            questionsLabel = new System.Windows.Forms.Label();
            option1Label = new System.Windows.Forms.Label();
            option2Label = new System.Windows.Forms.Label();
            option3Label = new System.Windows.Forms.Label();
            option4Label = new System.Windows.Forms.Label();
            timeFrameLabel = new System.Windows.Forms.Label();
            answerKeyLabel = new System.Windows.Forms.Label();
            difficultyLevelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quizBeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gQuizBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gQuizBindingNavigator)).BeginInit();
            this.gQuizBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gQuizDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Location = new System.Drawing.Point(6, 27);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new System.Drawing.Size(158, 18);
            questionNumberLabel.TabIndex = 2;
            questionNumberLabel.Text = "Question Number:";
            // 
            // questionsLabel
            // 
            questionsLabel.AutoSize = true;
            questionsLabel.Location = new System.Drawing.Point(91, 59);
            questionsLabel.Name = "questionsLabel";
            questionsLabel.Size = new System.Drawing.Size(98, 18);
            questionsLabel.TabIndex = 4;
            questionsLabel.Text = "Questions:";
            // 
            // option1Label
            // 
            option1Label.AutoSize = true;
            option1Label.Location = new System.Drawing.Point(162, 193);
            option1Label.Name = "option1Label";
            option1Label.Size = new System.Drawing.Size(80, 18);
            option1Label.TabIndex = 6;
            option1Label.Text = "Option1:";
            // 
            // option2Label
            // 
            option2Label.AutoSize = true;
            option2Label.Location = new System.Drawing.Point(162, 226);
            option2Label.Name = "option2Label";
            option2Label.Size = new System.Drawing.Size(80, 18);
            option2Label.TabIndex = 8;
            option2Label.Text = "Option2:";
            // 
            // option3Label
            // 
            option3Label.AutoSize = true;
            option3Label.Location = new System.Drawing.Point(162, 259);
            option3Label.Name = "option3Label";
            option3Label.Size = new System.Drawing.Size(80, 18);
            option3Label.TabIndex = 10;
            option3Label.Text = "Option3:";
            // 
            // option4Label
            // 
            option4Label.AutoSize = true;
            option4Label.Location = new System.Drawing.Point(162, 292);
            option4Label.Name = "option4Label";
            option4Label.Size = new System.Drawing.Size(80, 18);
            option4Label.TabIndex = 12;
            option4Label.Text = "Option4:";
            // 
            // timeFrameLabel
            // 
            timeFrameLabel.AutoSize = true;
            timeFrameLabel.Location = new System.Drawing.Point(37, 34);
            timeFrameLabel.Name = "timeFrameLabel";
            timeFrameLabel.Size = new System.Drawing.Size(111, 18);
            timeFrameLabel.TabIndex = 14;
            timeFrameLabel.Text = "Time Frame:";
            // 
            // answerKeyLabel
            // 
            answerKeyLabel.AutoSize = true;
            answerKeyLabel.Location = new System.Drawing.Point(162, 325);
            answerKeyLabel.Name = "answerKeyLabel";
            answerKeyLabel.Size = new System.Drawing.Size(110, 18);
            answerKeyLabel.TabIndex = 16;
            answerKeyLabel.Text = "Answer Key:";
            // 
            // difficultyLevelLabel
            // 
            difficultyLevelLabel.AutoSize = true;
            difficultyLevelLabel.Location = new System.Drawing.Point(37, 18);
            difficultyLevelLabel.Name = "difficultyLevelLabel";
            difficultyLevelLabel.Size = new System.Drawing.Size(137, 18);
            difficultyLevelLabel.TabIndex = 18;
            difficultyLevelLabel.Text = "Difficulty Level:";
            // 
            // quizBeeDataSet
            // 
            this.quizBeeDataSet.DataSetName = "QuizBeeDataSet";
            this.quizBeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gQuizBindingSource
            // 
            this.gQuizBindingSource.DataMember = "GQuiz";
            this.gQuizBindingSource.DataSource = this.quizBeeDataSet;
            // 
            // gQuizTableAdapter
            // 
            this.gQuizTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClincherTableAdapter = null;
            this.tableAdapterManager.ContestantScoreTableAdapter = null;
            this.tableAdapterManager.GContestantScoreTableAdapter = null;
            this.tableAdapterManager.GParticipantsTableAdapter = null;
            this.tableAdapterManager.GQuizTableAdapter = this.gQuizTableAdapter;
            this.tableAdapterManager.ParticipantsTableAdapter = null;
            this.tableAdapterManager.QuizL1TableAdapter = null;
            this.tableAdapterManager.QuizL2TableAdapter = null;
            this.tableAdapterManager.QuizL3TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Win.App.Server.QuizBeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gQuizBindingNavigator
            // 
            this.gQuizBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gQuizBindingNavigator.AutoSize = false;
            this.gQuizBindingNavigator.BackColor = System.Drawing.Color.White;
            this.gQuizBindingNavigator.BindingSource = this.gQuizBindingSource;
            this.gQuizBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gQuizBindingNavigator.DeleteItem = null;
            this.gQuizBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.gQuizBindingNavigator.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.gQuizBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator1,
            this.gQuizBindingNavigatorSaveItem,
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
            this.gQuizBindingNavigator.Location = new System.Drawing.Point(348, 14);
            this.gQuizBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gQuizBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gQuizBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gQuizBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gQuizBindingNavigator.Name = "gQuizBindingNavigator";
            this.gQuizBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gQuizBindingNavigator.Size = new System.Drawing.Size(562, 52);
            this.gQuizBindingNavigator.TabIndex = 0;
            this.gQuizBindingNavigator.Text = "bindingNavigator1";
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
            // gQuizBindingNavigatorSaveItem
            // 
            this.gQuizBindingNavigatorSaveItem.AutoSize = false;
            this.gQuizBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gQuizBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gQuizBindingNavigatorSaveItem.Image")));
            this.gQuizBindingNavigatorSaveItem.Name = "gQuizBindingNavigatorSaveItem";
            this.gQuizBindingNavigatorSaveItem.Size = new System.Drawing.Size(55, 46);
            this.gQuizBindingNavigatorSaveItem.Text = "Save Data";
            this.gQuizBindingNavigatorSaveItem.Click += new System.EventHandler(this.gQuizBindingNavigatorSaveItem_Click);
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
            this.bindingNavigatorMoveFirstItem.Image = global::Win.App.Server.Properties.Resources._1;
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
            this.bindingNavigatorMovePreviousItem.Image = global::Win.App.Server.Properties.Resources._13975127_glassy_aqua_blue_back_icon_button_arrow;
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
            // gQuizDataGridView
            // 
            this.gQuizDataGridView.AutoGenerateColumns = false;
            this.gQuizDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gQuizDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gQuizDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gQuizDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gQuizDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.gQuizDataGridView.DataSource = this.gQuizBindingSource;
            this.gQuizDataGridView.Location = new System.Drawing.Point(22, 457);
            this.gQuizDataGridView.Name = "gQuizDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gQuizDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gQuizDataGridView.Size = new System.Drawing.Size(1244, 219);
            this.gQuizDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "QuestionNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "QuestionNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 155;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Questions";
            this.dataGridViewTextBoxColumn2.HeaderText = "Questions";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 106;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Option1";
            this.dataGridViewTextBoxColumn3.HeaderText = "Option1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Option2";
            this.dataGridViewTextBoxColumn4.HeaderText = "Option2";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Option3";
            this.dataGridViewTextBoxColumn5.HeaderText = "Option3";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Option4";
            this.dataGridViewTextBoxColumn6.HeaderText = "Option4";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TimeFrame";
            this.dataGridViewTextBoxColumn7.HeaderText = "TimeFrame";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 115;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AnswerKey";
            this.dataGridViewTextBoxColumn8.HeaderText = "AnswerKey";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 114;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DifficultyLevel";
            this.dataGridViewTextBoxColumn9.HeaderText = "DifficultyLevel";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 136;
            // 
            // questionNumberTextBox
            // 
            this.questionNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gQuizBindingSource, "QuestionNumber", true));
            this.questionNumberTextBox.Location = new System.Drawing.Point(165, 23);
            this.questionNumberTextBox.Name = "questionNumberTextBox";
            this.questionNumberTextBox.Size = new System.Drawing.Size(47, 27);
            this.questionNumberTextBox.TabIndex = 3;
            // 
            // questionsTextBox
            // 
            this.questionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gQuizBindingSource, "Questions", true));
            this.questionsTextBox.Location = new System.Drawing.Point(95, 82);
            this.questionsTextBox.Multiline = true;
            this.questionsTextBox.Name = "questionsTextBox";
            this.questionsTextBox.Size = new System.Drawing.Size(752, 102);
            this.questionsTextBox.TabIndex = 5;
            // 
            // option1TextBox
            // 
            this.option1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gQuizBindingSource, "Option1", true));
            this.option1TextBox.Location = new System.Drawing.Point(285, 190);
            this.option1TextBox.Name = "option1TextBox";
            this.option1TextBox.Size = new System.Drawing.Size(441, 27);
            this.option1TextBox.TabIndex = 7;
            // 
            // option2TextBox
            // 
            this.option2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gQuizBindingSource, "Option2", true));
            this.option2TextBox.Location = new System.Drawing.Point(285, 223);
            this.option2TextBox.Name = "option2TextBox";
            this.option2TextBox.Size = new System.Drawing.Size(441, 27);
            this.option2TextBox.TabIndex = 9;
            // 
            // option3TextBox
            // 
            this.option3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gQuizBindingSource, "Option3", true));
            this.option3TextBox.Location = new System.Drawing.Point(285, 256);
            this.option3TextBox.Name = "option3TextBox";
            this.option3TextBox.Size = new System.Drawing.Size(441, 27);
            this.option3TextBox.TabIndex = 11;
            // 
            // option4TextBox
            // 
            this.option4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gQuizBindingSource, "Option4", true));
            this.option4TextBox.Location = new System.Drawing.Point(285, 289);
            this.option4TextBox.Name = "option4TextBox";
            this.option4TextBox.Size = new System.Drawing.Size(441, 27);
            this.option4TextBox.TabIndex = 13;
            // 
            // timeFrameTextBox
            // 
            this.timeFrameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gQuizBindingSource, "TimeFrame", true));
            this.timeFrameTextBox.Location = new System.Drawing.Point(154, 31);
            this.timeFrameTextBox.Name = "timeFrameTextBox";
            this.timeFrameTextBox.Size = new System.Drawing.Size(112, 27);
            this.timeFrameTextBox.TabIndex = 15;
            // 
            // answerKeyTextBox
            // 
            this.answerKeyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gQuizBindingSource, "AnswerKey", true));
            this.answerKeyTextBox.Location = new System.Drawing.Point(285, 322);
            this.answerKeyTextBox.Name = "answerKeyTextBox";
            this.answerKeyTextBox.Size = new System.Drawing.Size(441, 27);
            this.answerKeyTextBox.TabIndex = 17;
            // 
            // difficultyLevelTextBox
            // 
            this.difficultyLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gQuizBindingSource, "DifficultyLevel", true));
            this.difficultyLevelTextBox.Location = new System.Drawing.Point(64, 41);
            this.difficultyLevelTextBox.Name = "difficultyLevelTextBox";
            this.difficultyLevelTextBox.Size = new System.Drawing.Size(100, 27);
            this.difficultyLevelTextBox.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.questionNumberTextBox);
            this.groupBox1.Controls.Add(questionsLabel);
            this.groupBox1.Controls.Add(questionNumberLabel);
            this.groupBox1.Controls.Add(answerKeyLabel);
            this.groupBox1.Controls.Add(this.answerKeyTextBox);
            this.groupBox1.Controls.Add(this.questionsTextBox);
            this.groupBox1.Controls.Add(option1Label);
            this.groupBox1.Controls.Add(this.option4TextBox);
            this.groupBox1.Controls.Add(this.option1TextBox);
            this.groupBox1.Controls.Add(option4Label);
            this.groupBox1.Controls.Add(option2Label);
            this.groupBox1.Controls.Add(this.option3TextBox);
            this.groupBox1.Controls.Add(this.option2TextBox);
            this.groupBox1.Controls.Add(option3Label);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 373);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Questions / Choices";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(timeFrameLabel);
            this.groupBox2.Controls.Add(this.timeFrameTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(999, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 371);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time / Difficulty";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(difficultyLevelLabel);
            this.panel1.Controls.Add(this.difficultyLevelTextBox);
            this.panel1.Location = new System.Drawing.Point(41, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 230);
            this.panel1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 133);
            this.label2.TabIndex = 22;
            this.label2.Text = "Set the Difficulty using the number:\r\n\r\n       1 - Easy\r\n       2 - Average\r\n    " +
    "   3 - Difficult\r\n       4 - Clincher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "(SECONDS)";
            // 
            // AddGQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 684);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gQuizDataGridView);
            this.Controls.Add(this.gQuizBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddGQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGQuiz";
            this.Load += new System.EventHandler(this.AddGQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quizBeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gQuizBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gQuizBindingNavigator)).EndInit();
            this.gQuizBindingNavigator.ResumeLayout(false);
            this.gQuizBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gQuizDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private QuizBeeDataSet quizBeeDataSet;
        private System.Windows.Forms.BindingSource gQuizBindingSource;
        private QuizBeeDataSetTableAdapters.GQuizTableAdapter gQuizTableAdapter;
        private QuizBeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gQuizBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gQuizBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView gQuizDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox questionNumberTextBox;
        private System.Windows.Forms.TextBox questionsTextBox;
        private System.Windows.Forms.TextBox option1TextBox;
        private System.Windows.Forms.TextBox option2TextBox;
        private System.Windows.Forms.TextBox option3TextBox;
        private System.Windows.Forms.TextBox option4TextBox;
        private System.Windows.Forms.TextBox timeFrameTextBox;
        private System.Windows.Forms.TextBox answerKeyTextBox;
        private System.Windows.Forms.TextBox difficultyLevelTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}