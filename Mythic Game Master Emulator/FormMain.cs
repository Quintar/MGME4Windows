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
    }
}