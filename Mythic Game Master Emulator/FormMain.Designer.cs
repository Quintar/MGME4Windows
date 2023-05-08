namespace Mythic_Game_Master_Emulator
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelFateQuestion = new System.Windows.Forms.Label();
            this.comboBoxFateQuestion = new System.Windows.Forms.ComboBox();
            this.questionListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fateModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelChaosFactor = new System.Windows.Forms.Label();
            this.listBoxChaosFactorList = new System.Windows.Forms.ComboBox();
            this.chaosFactorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelOdds = new System.Windows.Forms.Label();
            this.listBoxOddsList = new System.Windows.Forms.ComboBox();
            this.oddsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAskFateQuestion = new System.Windows.Forms.Button();
            this.richTextBoxFateAnswer = new System.Windows.Forms.RichTextBox();
            this.checkBoxAddAnswer = new System.Windows.Forms.CheckBox();
            this.buttonGenerateRandomEvent = new System.Windows.Forms.Button();
            this.comboBoxMeaningTablesFiles1 = new System.Windows.Forms.ComboBox();
            this.labelMeaningTables = new System.Windows.Forms.Label();
            this.comboBoxMeaningTablesFiles2 = new System.Windows.Forms.ComboBox();
            this.buttonGenerateMeaning = new System.Windows.Forms.Button();
            this.buttonClearAnswers = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAnswersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAnswersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogAnswers = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogAnswers = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.questionListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fateModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaosFactorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oddsListBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFateQuestion
            // 
            this.labelFateQuestion.AutoSize = true;
            this.labelFateQuestion.Location = new System.Drawing.Point(5, 29);
            this.labelFateQuestion.Name = "labelFateQuestion";
            this.labelFateQuestion.Size = new System.Drawing.Size(83, 15);
            this.labelFateQuestion.TabIndex = 0;
            this.labelFateQuestion.Text = "Fate Question:";
            // 
            // comboBoxFateQuestion
            // 
            this.comboBoxFateQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFateQuestion.DataSource = this.questionListBindingSource;
            this.comboBoxFateQuestion.FormattingEnabled = true;
            this.comboBoxFateQuestion.Location = new System.Drawing.Point(5, 47);
            this.comboBoxFateQuestion.Name = "comboBoxFateQuestion";
            this.comboBoxFateQuestion.Size = new System.Drawing.Size(640, 23);
            this.comboBoxFateQuestion.TabIndex = 1;
            // 
            // questionListBindingSource
            // 
            this.questionListBindingSource.AllowNew = true;
            this.questionListBindingSource.DataMember = "QuestionList";
            this.questionListBindingSource.DataSource = this.fateModelBindingSource;
            // 
            // fateModelBindingSource
            // 
            this.fateModelBindingSource.DataSource = typeof(Mythic_Game_Master_Emulator.FateModel);
            // 
            // labelChaosFactor
            // 
            this.labelChaosFactor.AutoSize = true;
            this.labelChaosFactor.Location = new System.Drawing.Point(2, 73);
            this.labelChaosFactor.Name = "labelChaosFactor";
            this.labelChaosFactor.Size = new System.Drawing.Size(79, 15);
            this.labelChaosFactor.TabIndex = 2;
            this.labelChaosFactor.Text = "Chaos Factor:";
            // 
            // listBoxChaosFactorList
            // 
            this.listBoxChaosFactorList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.fateModelBindingSource, "ChaosFactor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listBoxChaosFactorList.DataSource = this.chaosFactorsBindingSource;
            this.listBoxChaosFactorList.DisplayMember = "chaosFactor";
            this.listBoxChaosFactorList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listBoxChaosFactorList.FormattingEnabled = true;
            this.listBoxChaosFactorList.ItemHeight = 15;
            this.listBoxChaosFactorList.Location = new System.Drawing.Point(5, 91);
            this.listBoxChaosFactorList.Name = "listBoxChaosFactorList";
            this.listBoxChaosFactorList.Size = new System.Drawing.Size(79, 23);
            this.listBoxChaosFactorList.TabIndex = 3;
            // 
            // chaosFactorsBindingSource
            // 
            this.chaosFactorsBindingSource.DataMember = "ChaosFactors";
            this.chaosFactorsBindingSource.DataSource = this.fateModelBindingSource;
            // 
            // labelOdds
            // 
            this.labelOdds.AutoSize = true;
            this.labelOdds.Location = new System.Drawing.Point(109, 73);
            this.labelOdds.Name = "labelOdds";
            this.labelOdds.Size = new System.Drawing.Size(38, 15);
            this.labelOdds.TabIndex = 4;
            this.labelOdds.Text = "Odds:";
            // 
            // listBoxOddsList
            // 
            this.listBoxOddsList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.fateModelBindingSource, "Odds", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listBoxOddsList.DataSource = this.oddsListBindingSource;
            this.listBoxOddsList.DisplayMember = "odds";
            this.listBoxOddsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listBoxOddsList.FormattingEnabled = true;
            this.listBoxOddsList.ItemHeight = 15;
            this.listBoxOddsList.Location = new System.Drawing.Point(109, 91);
            this.listBoxOddsList.Name = "listBoxOddsList";
            this.listBoxOddsList.Size = new System.Drawing.Size(120, 23);
            this.listBoxOddsList.TabIndex = 5;
            // 
            // oddsListBindingSource
            // 
            this.oddsListBindingSource.DataMember = "OddsList";
            this.oddsListBindingSource.DataSource = this.fateModelBindingSource;
            // 
            // buttonAskFateQuestion
            // 
            this.buttonAskFateQuestion.Location = new System.Drawing.Point(5, 116);
            this.buttonAskFateQuestion.Name = "buttonAskFateQuestion";
            this.buttonAskFateQuestion.Size = new System.Drawing.Size(75, 23);
            this.buttonAskFateQuestion.TabIndex = 6;
            this.buttonAskFateQuestion.Text = "Ask";
            this.buttonAskFateQuestion.UseVisualStyleBackColor = true;
            this.buttonAskFateQuestion.Click += new System.EventHandler(this.buttonDoAskFateQuestion_Click);
            // 
            // richTextBoxFateAnswer
            // 
            this.richTextBoxFateAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxFateAnswer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fateModelBindingSource, "Answer", true));
            this.richTextBoxFateAnswer.Location = new System.Drawing.Point(8, 145);
            this.richTextBoxFateAnswer.Name = "richTextBoxFateAnswer";
            this.richTextBoxFateAnswer.Size = new System.Drawing.Size(640, 157);
            this.richTextBoxFateAnswer.TabIndex = 7;
            this.richTextBoxFateAnswer.Text = "";
            // 
            // checkBoxAddAnswer
            // 
            this.checkBoxAddAnswer.AutoSize = true;
            this.checkBoxAddAnswer.Checked = true;
            this.checkBoxAddAnswer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAddAnswer.Location = new System.Drawing.Point(86, 119);
            this.checkBoxAddAnswer.Name = "checkBoxAddAnswer";
            this.checkBoxAddAnswer.Size = new System.Drawing.Size(90, 19);
            this.checkBoxAddAnswer.TabIndex = 8;
            this.checkBoxAddAnswer.Text = "Add Answer";
            this.checkBoxAddAnswer.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateRandomEvent
            // 
            this.buttonGenerateRandomEvent.Location = new System.Drawing.Point(182, 116);
            this.buttonGenerateRandomEvent.Name = "buttonGenerateRandomEvent";
            this.buttonGenerateRandomEvent.Size = new System.Drawing.Size(98, 23);
            this.buttonGenerateRandomEvent.TabIndex = 9;
            this.buttonGenerateRandomEvent.Text = "Random Event";
            this.buttonGenerateRandomEvent.UseVisualStyleBackColor = true;
            this.buttonGenerateRandomEvent.Click += new System.EventHandler(this.buttonGenerateRandomEvent_Click);
            // 
            // comboBoxMeaningTablesFiles1
            // 
            this.comboBoxMeaningTablesFiles1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxMeaningTablesFiles1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMeaningTablesFiles1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMeaningTablesFiles1.FormattingEnabled = true;
            this.comboBoxMeaningTablesFiles1.Location = new System.Drawing.Point(235, 91);
            this.comboBoxMeaningTablesFiles1.Name = "comboBoxMeaningTablesFiles1";
            this.comboBoxMeaningTablesFiles1.Size = new System.Drawing.Size(116, 23);
            this.comboBoxMeaningTablesFiles1.Sorted = true;
            this.comboBoxMeaningTablesFiles1.TabIndex = 10;
            // 
            // labelMeaningTables
            // 
            this.labelMeaningTables.AutoSize = true;
            this.labelMeaningTables.Location = new System.Drawing.Point(235, 73);
            this.labelMeaningTables.Name = "labelMeaningTables";
            this.labelMeaningTables.Size = new System.Drawing.Size(92, 15);
            this.labelMeaningTables.TabIndex = 11;
            this.labelMeaningTables.Text = "Meaning Tables:";
            // 
            // comboBoxMeaningTablesFiles2
            // 
            this.comboBoxMeaningTablesFiles2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxMeaningTablesFiles2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMeaningTablesFiles2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMeaningTablesFiles2.FormattingEnabled = true;
            this.comboBoxMeaningTablesFiles2.Location = new System.Drawing.Point(357, 91);
            this.comboBoxMeaningTablesFiles2.Name = "comboBoxMeaningTablesFiles2";
            this.comboBoxMeaningTablesFiles2.Size = new System.Drawing.Size(116, 23);
            this.comboBoxMeaningTablesFiles2.Sorted = true;
            this.comboBoxMeaningTablesFiles2.TabIndex = 12;
            // 
            // buttonGenerateMeaning
            // 
            this.buttonGenerateMeaning.Location = new System.Drawing.Point(479, 90);
            this.buttonGenerateMeaning.Name = "buttonGenerateMeaning";
            this.buttonGenerateMeaning.Size = new System.Drawing.Size(117, 23);
            this.buttonGenerateMeaning.TabIndex = 13;
            this.buttonGenerateMeaning.Text = "Generate Meaning";
            this.buttonGenerateMeaning.UseVisualStyleBackColor = true;
            this.buttonGenerateMeaning.Click += new System.EventHandler(this.buttonGenerateMeaning_Click);
            // 
            // buttonClearAnswers
            // 
            this.buttonClearAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearAnswers.Location = new System.Drawing.Point(570, 116);
            this.buttonClearAnswers.Name = "buttonClearAnswers";
            this.buttonClearAnswers.Size = new System.Drawing.Size(75, 23);
            this.buttonClearAnswers.TabIndex = 14;
            this.buttonClearAnswers.Text = "Clear";
            this.buttonClearAnswers.UseVisualStyleBackColor = true;
            this.buttonClearAnswers.Click += new System.EventHandler(this.buttonClearAnswers_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(5, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(646, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAnswersToolStripMenuItem,
            this.loadAnswersToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveAnswersToolStripMenuItem
            // 
            this.saveAnswersToolStripMenuItem.Name = "saveAnswersToolStripMenuItem";
            this.saveAnswersToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveAnswersToolStripMenuItem.Text = "&Save Answers";
            this.saveAnswersToolStripMenuItem.Click += new System.EventHandler(this.saveAnswersToolStripMenuItem_Click);
            // 
            // loadAnswersToolStripMenuItem
            // 
            this.loadAnswersToolStripMenuItem.Name = "loadAnswersToolStripMenuItem";
            this.loadAnswersToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.loadAnswersToolStripMenuItem.Text = "&Load Answers";
            this.loadAnswersToolStripMenuItem.Click += new System.EventHandler(this.loadAnswersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            // 
            // saveFileDialogAnswers
            // 
            this.saveFileDialogAnswers.DefaultExt = "txt";
            this.saveFileDialogAnswers.FileName = "Answers.txt";
            this.saveFileDialogAnswers.Filter = "Answer files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialogAnswers.Title = "Save answers to";
            // 
            // openFileDialogAnswers
            // 
            this.openFileDialogAnswers.DefaultExt = "txt";
            this.openFileDialogAnswers.FileName = "Answers.txt";
            this.openFileDialogAnswers.Filter = "Answer files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 310);
            this.Controls.Add(this.buttonClearAnswers);
            this.Controls.Add(this.buttonGenerateMeaning);
            this.Controls.Add(this.comboBoxMeaningTablesFiles2);
            this.Controls.Add(this.labelMeaningTables);
            this.Controls.Add(this.comboBoxMeaningTablesFiles1);
            this.Controls.Add(this.buttonGenerateRandomEvent);
            this.Controls.Add(this.checkBoxAddAnswer);
            this.Controls.Add(this.richTextBoxFateAnswer);
            this.Controls.Add(this.buttonAskFateQuestion);
            this.Controls.Add(this.listBoxOddsList);
            this.Controls.Add(this.labelOdds);
            this.Controls.Add(this.listBoxChaosFactorList);
            this.Controls.Add(this.labelChaosFactor);
            this.Controls.Add(this.comboBoxFateQuestion);
            this.Controls.Add(this.labelFateQuestion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Mythic Game Master Emulator";
            ((System.ComponentModel.ISupportInitialize)(this.questionListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fateModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaosFactorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oddsListBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFateQuestion;
        private ComboBox comboBoxFateQuestion;
        private Label labelChaosFactor;
        private ComboBox listBoxChaosFactorList;
        private Label labelOdds;
        private ComboBox listBoxOddsList;
        private Button buttonAskFateQuestion;
        private RichTextBox richTextBoxFateAnswer;
        private BindingSource chaosFactorsBindingSource;
        private BindingSource oddsListBindingSource;
        private BindingSource questionListBindingSource;
        public BindingSource fateModelBindingSource;
        private CheckBox checkBoxAddAnswer;
        private Button buttonGenerateRandomEvent;
        private ComboBox comboBoxMeaningTablesFiles1;
        private Label labelMeaningTables;
        private ComboBox comboBoxMeaningTablesFiles2;
        private Button buttonGenerateMeaning;
        private Button buttonClearAnswers;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveAnswersToolStripMenuItem;
        private ToolStripMenuItem loadAnswersToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private SaveFileDialog saveFileDialogAnswers;
        private OpenFileDialog openFileDialogAnswers;
    }
}