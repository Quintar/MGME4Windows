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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            labelFateQuestion = new Label();
            comboBoxFateQuestion = new ComboBox();
            questionListBindingSource = new BindingSource(components);
            fateModelBindingSource = new BindingSource(components);
            labelChaosFactor = new Label();
            listBoxChaosFactorList = new ComboBox();
            chaosFactorsBindingSource = new BindingSource(components);
            labelOdds = new Label();
            listBoxOddsList = new ComboBox();
            oddsListBindingSource = new BindingSource(components);
            buttonAskFateQuestion = new Button();
            richTextBoxFateAnswer = new RichTextBox();
            checkBoxAddAnswer = new CheckBox();
            buttonGenerateRandomEvent = new Button();
            comboBoxMeaningTablesFiles1 = new ComboBox();
            labelMeaningTables = new Label();
            comboBoxMeaningTablesFiles2 = new ComboBox();
            buttonGenerateMeaning = new Button();
            buttonClearAnswers = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveAnswersToolStripMenuItem = new ToolStripMenuItem();
            saveCharacterListToolStripMenuItem = new ToolStripMenuItem();
            saveThreadListToolStripMenuItem = new ToolStripMenuItem();
            loadAnswersToolStripMenuItem = new ToolStripMenuItem();
            loadCharacterListToolStripMenuItem = new ToolStripMenuItem();
            loadThreadListToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            quitToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialogAnswers = new SaveFileDialog();
            openFileDialogAnswers = new OpenFileDialog();
            buttonRollAgainstChaosFactor = new Button();
            buttonRollPercentile = new Button();
            labelCharacterList = new Label();
            labelThreadList = new Label();
            textBoxCharacter = new TextBox();
            listBoxCharacters = new ListBox();
            charactersBindingSource = new BindingSource(components);
            textBoxThread = new TextBox();
            listBoxThreadsList = new ListBox();
            threadsBindingSource = new BindingSource(components);
            saveFileDialogCharacters = new SaveFileDialog();
            saveFileDialogThreads = new SaveFileDialog();
            openFileDialogCharacters = new OpenFileDialog();
            openFileDialogThreads = new OpenFileDialog();
            buttonClearCharacters = new Button();
            buttonClearThreads = new Button();
            buttonRollCharacter = new Button();
            buttonRollThread = new Button();
            ((System.ComponentModel.ISupportInitialize)questionListBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fateModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chaosFactorsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oddsListBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)charactersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)threadsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // labelFateQuestion
            // 
            labelFateQuestion.AutoSize = true;
            labelFateQuestion.Location = new Point(5, 29);
            labelFateQuestion.Name = "labelFateQuestion";
            labelFateQuestion.Size = new Size(83, 15);
            labelFateQuestion.TabIndex = 0;
            labelFateQuestion.Text = "Fate Question:";
            // 
            // comboBoxFateQuestion
            // 
            comboBoxFateQuestion.DataSource = questionListBindingSource;
            comboBoxFateQuestion.FormattingEnabled = true;
            comboBoxFateQuestion.Location = new Point(5, 47);
            comboBoxFateQuestion.Name = "comboBoxFateQuestion";
            comboBoxFateQuestion.Size = new Size(697, 23);
            comboBoxFateQuestion.TabIndex = 1;
            // 
            // questionListBindingSource
            // 
            questionListBindingSource.AllowNew = true;
            questionListBindingSource.DataMember = "QuestionList";
            questionListBindingSource.DataSource = fateModelBindingSource;
            // 
            // fateModelBindingSource
            // 
            fateModelBindingSource.DataSource = typeof(FateModel);
            // 
            // labelChaosFactor
            // 
            labelChaosFactor.AutoSize = true;
            labelChaosFactor.Location = new Point(2, 73);
            labelChaosFactor.Name = "labelChaosFactor";
            labelChaosFactor.Size = new Size(79, 15);
            labelChaosFactor.TabIndex = 2;
            labelChaosFactor.Text = "Chaos Factor:";
            // 
            // listBoxChaosFactorList
            // 
            listBoxChaosFactorList.DataBindings.Add(new Binding("SelectedIndex", fateModelBindingSource, "ChaosFactor", true, DataSourceUpdateMode.OnPropertyChanged));
            listBoxChaosFactorList.DataSource = chaosFactorsBindingSource;
            listBoxChaosFactorList.DisplayMember = "chaosFactor";
            listBoxChaosFactorList.DropDownStyle = ComboBoxStyle.DropDownList;
            listBoxChaosFactorList.FormattingEnabled = true;
            listBoxChaosFactorList.ItemHeight = 15;
            listBoxChaosFactorList.Location = new Point(5, 91);
            listBoxChaosFactorList.Name = "listBoxChaosFactorList";
            listBoxChaosFactorList.Size = new Size(79, 23);
            listBoxChaosFactorList.TabIndex = 3;
            // 
            // chaosFactorsBindingSource
            // 
            chaosFactorsBindingSource.DataMember = "ChaosFactors";
            chaosFactorsBindingSource.DataSource = fateModelBindingSource;
            // 
            // labelOdds
            // 
            labelOdds.AutoSize = true;
            labelOdds.Location = new Point(215, 73);
            labelOdds.Name = "labelOdds";
            labelOdds.Size = new Size(38, 15);
            labelOdds.TabIndex = 4;
            labelOdds.Text = "Odds:";
            // 
            // listBoxOddsList
            // 
            listBoxOddsList.DataBindings.Add(new Binding("SelectedIndex", fateModelBindingSource, "Odds", true, DataSourceUpdateMode.OnPropertyChanged));
            listBoxOddsList.DataSource = oddsListBindingSource;
            listBoxOddsList.DisplayMember = "odds";
            listBoxOddsList.DropDownStyle = ComboBoxStyle.DropDownList;
            listBoxOddsList.FormattingEnabled = true;
            listBoxOddsList.ItemHeight = 15;
            listBoxOddsList.Location = new Point(215, 91);
            listBoxOddsList.Name = "listBoxOddsList";
            listBoxOddsList.Size = new Size(120, 23);
            listBoxOddsList.TabIndex = 5;
            // 
            // oddsListBindingSource
            // 
            oddsListBindingSource.DataMember = "OddsList";
            oddsListBindingSource.DataSource = fateModelBindingSource;
            // 
            // buttonAskFateQuestion
            // 
            buttonAskFateQuestion.Location = new Point(5, 116);
            buttonAskFateQuestion.Name = "buttonAskFateQuestion";
            buttonAskFateQuestion.Size = new Size(75, 23);
            buttonAskFateQuestion.TabIndex = 6;
            buttonAskFateQuestion.Text = "Ask";
            buttonAskFateQuestion.UseVisualStyleBackColor = true;
            buttonAskFateQuestion.Click += buttonDoAskFateQuestion_Click;
            // 
            // richTextBoxFateAnswer
            // 
            richTextBoxFateAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            richTextBoxFateAnswer.DataBindings.Add(new Binding("Text", fateModelBindingSource, "Answer", true));
            richTextBoxFateAnswer.Location = new Point(8, 145);
            richTextBoxFateAnswer.Name = "richTextBoxFateAnswer";
            richTextBoxFateAnswer.Size = new Size(694, 221);
            richTextBoxFateAnswer.TabIndex = 7;
            richTextBoxFateAnswer.Text = "";
            // 
            // checkBoxAddAnswer
            // 
            checkBoxAddAnswer.AutoSize = true;
            checkBoxAddAnswer.Checked = true;
            checkBoxAddAnswer.CheckState = CheckState.Checked;
            checkBoxAddAnswer.Location = new Point(86, 119);
            checkBoxAddAnswer.Name = "checkBoxAddAnswer";
            checkBoxAddAnswer.Size = new Size(90, 19);
            checkBoxAddAnswer.TabIndex = 8;
            checkBoxAddAnswer.Text = "Add Answer";
            checkBoxAddAnswer.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateRandomEvent
            // 
            buttonGenerateRandomEvent.Location = new Point(182, 116);
            buttonGenerateRandomEvent.Name = "buttonGenerateRandomEvent";
            buttonGenerateRandomEvent.Size = new Size(98, 23);
            buttonGenerateRandomEvent.TabIndex = 9;
            buttonGenerateRandomEvent.Text = "Random Event";
            buttonGenerateRandomEvent.UseVisualStyleBackColor = true;
            buttonGenerateRandomEvent.Click += buttonGenerateRandomEvent_Click;
            // 
            // comboBoxMeaningTablesFiles1
            // 
            comboBoxMeaningTablesFiles1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxMeaningTablesFiles1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMeaningTablesFiles1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMeaningTablesFiles1.FormattingEnabled = true;
            comboBoxMeaningTablesFiles1.Location = new Point(341, 91);
            comboBoxMeaningTablesFiles1.Name = "comboBoxMeaningTablesFiles1";
            comboBoxMeaningTablesFiles1.Size = new Size(116, 23);
            comboBoxMeaningTablesFiles1.Sorted = true;
            comboBoxMeaningTablesFiles1.TabIndex = 10;
            // 
            // labelMeaningTables
            // 
            labelMeaningTables.AutoSize = true;
            labelMeaningTables.Location = new Point(341, 73);
            labelMeaningTables.Name = "labelMeaningTables";
            labelMeaningTables.Size = new Size(92, 15);
            labelMeaningTables.TabIndex = 11;
            labelMeaningTables.Text = "Meaning Tables:";
            // 
            // comboBoxMeaningTablesFiles2
            // 
            comboBoxMeaningTablesFiles2.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxMeaningTablesFiles2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMeaningTablesFiles2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMeaningTablesFiles2.FormattingEnabled = true;
            comboBoxMeaningTablesFiles2.Location = new Point(463, 91);
            comboBoxMeaningTablesFiles2.Name = "comboBoxMeaningTablesFiles2";
            comboBoxMeaningTablesFiles2.Size = new Size(116, 23);
            comboBoxMeaningTablesFiles2.Sorted = true;
            comboBoxMeaningTablesFiles2.TabIndex = 12;
            // 
            // buttonGenerateMeaning
            // 
            buttonGenerateMeaning.Location = new Point(585, 90);
            buttonGenerateMeaning.Name = "buttonGenerateMeaning";
            buttonGenerateMeaning.Size = new Size(117, 23);
            buttonGenerateMeaning.TabIndex = 13;
            buttonGenerateMeaning.Text = "Generate Meaning";
            buttonGenerateMeaning.UseVisualStyleBackColor = true;
            buttonGenerateMeaning.Click += buttonGenerateMeaning_Click;
            // 
            // buttonClearAnswers
            // 
            buttonClearAnswers.Location = new Point(626, 119);
            buttonClearAnswers.Name = "buttonClearAnswers";
            buttonClearAnswers.Size = new Size(75, 23);
            buttonClearAnswers.TabIndex = 14;
            buttonClearAnswers.Text = "Clear";
            buttonClearAnswers.UseVisualStyleBackColor = true;
            buttonClearAnswers.Click += buttonClearAnswers_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(5, 5);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1020, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveAnswersToolStripMenuItem, saveCharacterListToolStripMenuItem, saveThreadListToolStripMenuItem, loadAnswersToolStripMenuItem, loadCharacterListToolStripMenuItem, loadThreadListToolStripMenuItem, toolStripMenuItem1, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // saveAnswersToolStripMenuItem
            // 
            saveAnswersToolStripMenuItem.Name = "saveAnswersToolStripMenuItem";
            saveAnswersToolStripMenuItem.Size = new Size(175, 22);
            saveAnswersToolStripMenuItem.Text = "&Save Answers";
            saveAnswersToolStripMenuItem.Click += saveAnswersToolStripMenuItem_Click;
            // 
            // saveCharacterListToolStripMenuItem
            // 
            saveCharacterListToolStripMenuItem.Name = "saveCharacterListToolStripMenuItem";
            saveCharacterListToolStripMenuItem.Size = new Size(175, 22);
            saveCharacterListToolStripMenuItem.Text = "Save Character List";
            saveCharacterListToolStripMenuItem.Click += saveCharacterListToolStripMenuItem_Click;
            // 
            // saveThreadListToolStripMenuItem
            // 
            saveThreadListToolStripMenuItem.Name = "saveThreadListToolStripMenuItem";
            saveThreadListToolStripMenuItem.Size = new Size(175, 22);
            saveThreadListToolStripMenuItem.Text = "Save Thread List";
            saveThreadListToolStripMenuItem.Click += saveThreadListToolStripMenuItem_Click;
            // 
            // loadAnswersToolStripMenuItem
            // 
            loadAnswersToolStripMenuItem.Name = "loadAnswersToolStripMenuItem";
            loadAnswersToolStripMenuItem.Size = new Size(175, 22);
            loadAnswersToolStripMenuItem.Text = "&Load Answers";
            loadAnswersToolStripMenuItem.Click += loadAnswersToolStripMenuItem_Click;
            // 
            // loadCharacterListToolStripMenuItem
            // 
            loadCharacterListToolStripMenuItem.Name = "loadCharacterListToolStripMenuItem";
            loadCharacterListToolStripMenuItem.Size = new Size(175, 22);
            loadCharacterListToolStripMenuItem.Text = "Load Character List";
            loadCharacterListToolStripMenuItem.Click += loadCharacterListToolStripMenuItem_Click;
            // 
            // loadThreadListToolStripMenuItem
            // 
            loadThreadListToolStripMenuItem.Name = "loadThreadListToolStripMenuItem";
            loadThreadListToolStripMenuItem.Size = new Size(175, 22);
            loadThreadListToolStripMenuItem.Text = "Load Thread List";
            loadThreadListToolStripMenuItem.Click += loadThreadListToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(172, 6);
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(175, 22);
            quitToolStripMenuItem.Text = "&Quit";
            // 
            // saveFileDialogAnswers
            // 
            saveFileDialogAnswers.DefaultExt = "txt";
            saveFileDialogAnswers.FileName = "Answers.txt";
            saveFileDialogAnswers.Filter = "Answer files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialogAnswers.Title = "Save answers to";
            // 
            // openFileDialogAnswers
            // 
            openFileDialogAnswers.DefaultExt = "txt";
            openFileDialogAnswers.FileName = "Answers.txt";
            openFileDialogAnswers.Filter = "Answer files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // buttonRollAgainstChaosFactor
            // 
            buttonRollAgainstChaosFactor.Location = new Point(90, 90);
            buttonRollAgainstChaosFactor.Name = "buttonRollAgainstChaosFactor";
            buttonRollAgainstChaosFactor.Size = new Size(75, 23);
            buttonRollAgainstChaosFactor.TabIndex = 16;
            buttonRollAgainstChaosFactor.Text = "Roll";
            buttonRollAgainstChaosFactor.UseVisualStyleBackColor = true;
            buttonRollAgainstChaosFactor.Click += buttonRollAgainstChaosFactor_Click;
            // 
            // buttonRollPercentile
            // 
            buttonRollPercentile.Location = new Point(286, 116);
            buttonRollPercentile.Name = "buttonRollPercentile";
            buttonRollPercentile.Size = new Size(95, 23);
            buttonRollPercentile.TabIndex = 17;
            buttonRollPercentile.Text = "Roll Percentile";
            buttonRollPercentile.UseVisualStyleBackColor = true;
            buttonRollPercentile.Click += buttonRollPercentile_Click;
            // 
            // labelCharacterList
            // 
            labelCharacterList.AutoSize = true;
            labelCharacterList.Location = new Point(721, 29);
            labelCharacterList.Name = "labelCharacterList";
            labelCharacterList.Size = new Size(82, 15);
            labelCharacterList.TabIndex = 18;
            labelCharacterList.Text = "Character List:";
            // 
            // labelThreadList
            // 
            labelThreadList.AutoSize = true;
            labelThreadList.Location = new Point(875, 29);
            labelThreadList.Name = "labelThreadList";
            labelThreadList.Size = new Size(67, 15);
            labelThreadList.TabIndex = 19;
            labelThreadList.Text = "Thread List:";
            // 
            // textBoxCharacter
            // 
            textBoxCharacter.Location = new Point(721, 47);
            textBoxCharacter.Name = "textBoxCharacter";
            textBoxCharacter.Size = new Size(150, 23);
            textBoxCharacter.TabIndex = 20;
            textBoxCharacter.KeyUp += textBoxCharacter_KeyUp;
            // 
            // listBoxCharacters
            // 
            listBoxCharacters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxCharacters.DataSource = charactersBindingSource;
            listBoxCharacters.FormattingEnabled = true;
            listBoxCharacters.ItemHeight = 15;
            listBoxCharacters.Location = new Point(720, 76);
            listBoxCharacters.Name = "listBoxCharacters";
            listBoxCharacters.Size = new Size(150, 259);
            listBoxCharacters.TabIndex = 21;
            listBoxCharacters.DoubleClick += listBoxCharacters_DoubleClick;
            // 
            // charactersBindingSource
            // 
            charactersBindingSource.DataMember = "Characters";
            charactersBindingSource.DataSource = fateModelBindingSource;
            // 
            // textBoxThread
            // 
            textBoxThread.Location = new Point(875, 47);
            textBoxThread.Name = "textBoxThread";
            textBoxThread.Size = new Size(150, 23);
            textBoxThread.TabIndex = 22;
            textBoxThread.KeyUp += textBoxThread_KeyUp;
            // 
            // listBoxThreadsList
            // 
            listBoxThreadsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxThreadsList.DataSource = threadsBindingSource;
            listBoxThreadsList.FormattingEnabled = true;
            listBoxThreadsList.ItemHeight = 15;
            listBoxThreadsList.Location = new Point(874, 76);
            listBoxThreadsList.Name = "listBoxThreadsList";
            listBoxThreadsList.Size = new Size(150, 259);
            listBoxThreadsList.TabIndex = 23;
            listBoxThreadsList.DoubleClick += listBoxThreadsList_DoubleClick;
            // 
            // threadsBindingSource
            // 
            threadsBindingSource.DataMember = "Threads";
            threadsBindingSource.DataSource = fateModelBindingSource;
            // 
            // saveFileDialogCharacters
            // 
            saveFileDialogCharacters.DefaultExt = "txt";
            saveFileDialogCharacters.FileName = "Characters.txt";
            saveFileDialogCharacters.Filter = "Characters files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialogCharacters.Title = "Save answers to";
            // 
            // saveFileDialogThreads
            // 
            saveFileDialogThreads.DefaultExt = "txt";
            saveFileDialogThreads.FileName = "Threads.txt";
            saveFileDialogThreads.Filter = "Threads files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialogThreads.Title = "Save answers to";
            // 
            // openFileDialogCharacters
            // 
            openFileDialogCharacters.DefaultExt = "txt";
            openFileDialogCharacters.FileName = "Characters.txt";
            openFileDialogCharacters.Filter = "Characters files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // openFileDialogThreads
            // 
            openFileDialogThreads.DefaultExt = "txt";
            openFileDialogThreads.FileName = "Threads.txt";
            openFileDialogThreads.Filter = "Threads files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // buttonClearCharacters
            // 
            buttonClearCharacters.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonClearCharacters.Location = new Point(720, 343);
            buttonClearCharacters.Name = "buttonClearCharacters";
            buttonClearCharacters.Size = new Size(75, 23);
            buttonClearCharacters.TabIndex = 24;
            buttonClearCharacters.Text = "Clear";
            buttonClearCharacters.UseVisualStyleBackColor = true;
            buttonClearCharacters.Click += buttonClearCharacters_Click;
            // 
            // buttonClearThreads
            // 
            buttonClearThreads.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonClearThreads.Location = new Point(875, 343);
            buttonClearThreads.Name = "buttonClearThreads";
            buttonClearThreads.Size = new Size(75, 23);
            buttonClearThreads.TabIndex = 25;
            buttonClearThreads.Text = "Clear";
            buttonClearThreads.UseVisualStyleBackColor = true;
            buttonClearThreads.Click += buttonClearThreads_Click;
            // 
            // buttonRollCharacter
            // 
            buttonRollCharacter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRollCharacter.Location = new Point(794, 343);
            buttonRollCharacter.Name = "buttonRollCharacter";
            buttonRollCharacter.Size = new Size(75, 23);
            buttonRollCharacter.TabIndex = 26;
            buttonRollCharacter.Text = "Roll";
            buttonRollCharacter.UseVisualStyleBackColor = true;
            buttonRollCharacter.Click += buttonRollCharacter_Click;
            // 
            // buttonRollThread
            // 
            buttonRollThread.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRollThread.Location = new Point(950, 343);
            buttonRollThread.Name = "buttonRollThread";
            buttonRollThread.Size = new Size(75, 23);
            buttonRollThread.TabIndex = 27;
            buttonRollThread.Text = "Roll";
            buttonRollThread.UseVisualStyleBackColor = true;
            buttonRollThread.Click += buttonRollThread_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 374);
            Controls.Add(buttonRollThread);
            Controls.Add(buttonRollCharacter);
            Controls.Add(buttonClearThreads);
            Controls.Add(buttonClearCharacters);
            Controls.Add(listBoxThreadsList);
            Controls.Add(textBoxThread);
            Controls.Add(listBoxCharacters);
            Controls.Add(textBoxCharacter);
            Controls.Add(labelThreadList);
            Controls.Add(labelCharacterList);
            Controls.Add(buttonRollPercentile);
            Controls.Add(buttonRollAgainstChaosFactor);
            Controls.Add(buttonClearAnswers);
            Controls.Add(buttonGenerateMeaning);
            Controls.Add(comboBoxMeaningTablesFiles2);
            Controls.Add(labelMeaningTables);
            Controls.Add(comboBoxMeaningTablesFiles1);
            Controls.Add(buttonGenerateRandomEvent);
            Controls.Add(checkBoxAddAnswer);
            Controls.Add(richTextBoxFateAnswer);
            Controls.Add(buttonAskFateQuestion);
            Controls.Add(listBoxOddsList);
            Controls.Add(labelOdds);
            Controls.Add(listBoxChaosFactorList);
            Controls.Add(labelChaosFactor);
            Controls.Add(comboBoxFateQuestion);
            Controls.Add(labelFateQuestion);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Padding = new Padding(5);
            Text = "Mythic Game Master Emulator";
            ((System.ComponentModel.ISupportInitialize)questionListBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)fateModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)chaosFactorsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)oddsListBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)charactersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)threadsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button buttonRollAgainstChaosFactor;
        private Button buttonRollPercentile;
        private Label labelCharacterList;
        private Label labelThreadList;
        private TextBox textBoxCharacter;
        private ListBox listBoxCharacters;
        private TextBox textBoxThread;
        private ListBox listBoxThreadsList;
        private BindingSource charactersBindingSource;
        private BindingSource threadsBindingSource;
        private ToolStripMenuItem saveCharacterListToolStripMenuItem;
        private ToolStripMenuItem saveThreadListToolStripMenuItem;
        private ToolStripMenuItem loadCharacterListToolStripMenuItem;
        private ToolStripMenuItem loadThreadListToolStripMenuItem;
        private SaveFileDialog saveFileDialogCharacters;
        private SaveFileDialog saveFileDialogThreads;
        private OpenFileDialog openFileDialogCharacters;
        private OpenFileDialog openFileDialogThreads;
        private Button buttonClearCharacters;
        private Button buttonClearThreads;
        private Button buttonRollCharacter;
        private Button buttonRollThread;
    }
}