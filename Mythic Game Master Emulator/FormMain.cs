using System.Windows.Forms;

namespace Mythic_Game_Master_Emulator
{
    public partial class FormMain : Form
    {
        private MythicGameMasterEmulator gme;
        public FormMain()
        {
            InitializeComponent();

            loadMeaningTables();

            FateModel fm = new FateModel(loadOddsTable());
            fateModelBindingSource.DataSource = fm;
            gme = new MythicGameMasterEmulator(ref fm);
            fateModelBindingSource.ResetCurrentItem();
        }

        private string[] loadOddsTable()
        {
            return File.ReadAllLines("odds.txt");
        }

        private void loadMeaningTables()
        {
            string[] MeaningTables = Directory.GetFiles(".", "MeaningTable*.txt");
            for (int i = 0; i < MeaningTables.Length; i++)
            {
                MeaningTables[i] = MeaningTables[i].Replace(".\\", "");
                MeaningTables[i] = MeaningTables[i].Replace(".txt", "");
                MeaningTables[i] = MeaningTables[i].Replace("MeaningTable", "");
            }
            comboBoxMeaningTablesFiles1.Items.AddRange(MeaningTables);
            comboBoxMeaningTablesFiles2.Items.AddRange(MeaningTables);
            comboBoxMeaningTablesFiles1.SelectedIndex = 0;
            comboBoxMeaningTablesFiles2.SelectedIndex = 0;
        }

        private void buttonDoAskFateQuestion_Click(object sender, EventArgs e)
        {
            gme.GenerateAnswer(comboBoxFateQuestion.Text, checkBoxAddAnswer.Checked);
            resetModelAndScroll();
        }

        private void buttonGenerateRandomEvent_Click(object sender, EventArgs e)
        {
            gme.GenerateRandomEvent();
            resetModelAndScroll();
        }

        private void buttonGenerateMeaning_Click(object sender, EventArgs e)
        {
            gme.GenerateMeaningFrom(getFilename1, getFilename2);
            resetModelAndScroll();
        }

        private void resetModelAndScroll()
        {
            fateModelBindingSource.ResetCurrentItem();
            richTextBoxFateAnswer.SelectionStart = richTextBoxFateAnswer.Text.Length;
            richTextBoxFateAnswer.ScrollToCaret();
        }

        private string getFilename1 { get { return "MeaningTable" + comboBoxMeaningTablesFiles1.Text + ".txt"; } }
        private string getFilename2 { get { return "MeaningTable" + comboBoxMeaningTablesFiles2.Text + ".txt"; } }

        private void buttonClearAnswers_Click(object sender, EventArgs e)
        {
            gme.FateModel.ClearAnswers();
            resetModelAndScroll();
        }

        private void saveAnswersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogAnswers.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialogAnswers.FileName, gme.FateModel.Answer);
            }

        }

        private void loadAnswersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogAnswers.ShowDialog() == DialogResult.OK)
            {
                gme.SetAnswersFrom(openFileDialogAnswers.FileName);
                resetModelAndScroll();
            }
        }

        private void buttonRollAgainstChaosFactor_Click(object sender, EventArgs e)
        {
            gme.RollAgainstChaosFactor();
            resetModelAndScroll();
        }

        private void buttonRollPercentile_Click(object sender, EventArgs e)
        {
            gme.RollPercentileDice();
            resetModelAndScroll();
        }

        private void textBoxCharacter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gme.AddCharacter(textBoxCharacter.Text);
                resetModelAndScroll();
            }
        }

        private void textBoxThread_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gme.AddThread(textBoxThread.Text);
                resetModelAndScroll();
            }
        }

        private void listBoxCharacters_DoubleClick(object sender, EventArgs e)
        {
            gme.RemoveCharacter(listBoxCharacters.Text);
            resetModelAndScroll();
        }

        private void listBoxThreadsList_DoubleClick(object sender, EventArgs e)
        {
            gme.RemoveThread(listBoxThreadsList.Text);
            resetModelAndScroll();
        }

        private void saveCharacterListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogCharacters.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialogCharacters.FileName, gme.FateModel.Characters.GetRange(0, gme.FateModel.Characters.Count));
            }
        }

        private void saveThreadListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogThreads.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialogThreads.FileName, gme.FateModel.Threads.GetRange(0, gme.FateModel.Threads.Count));
            }
        }

        private void loadCharacterListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogCharacters.ShowDialog() == DialogResult.OK)
            {
                gme.SetCharactersFrom(openFileDialogCharacters.FileName);
                resetModelAndScroll();
            }
        }

        private void loadThreadListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogThreads.ShowDialog() == DialogResult.OK)
            {
                gme.SetThreadsFrom(openFileDialogThreads.FileName);
                resetModelAndScroll();
            }
        }

        private void buttonClearCharacters_Click(object sender, EventArgs e)
        {
            gme.FateModel.Characters.Clear();
            resetModelAndScroll();
        }

        private void buttonClearThreads_Click(object sender, EventArgs e)
        {
            gme.FateModel.Threads.Clear();
            resetModelAndScroll();
        }
    }
}