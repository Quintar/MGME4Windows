using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Mythic_Game_Master_Emulator
{
    public class MythicGameMasterEmulator
    {
        FateModel myFm;

        public FateModel FateModel
        {
            get { return myFm; }
        }

        private MythicGameMasterEmulator()
        {
            myFm = new FateModel(new string[] { "INVALID" });
        }

        public MythicGameMasterEmulator(ref FateModel fm)
        {
            myFm = fm;
        }

        public string GenerateAnswer(string question = "", bool addAnswer = false)
        {
            myFm.Question = question;
            string ans = myFm.Question + " : " + myFm.GetFateResult(myFm.Odds, myFm.ChaosFactor).ToString();

            myFm.AddToAnswer(ans, !addAnswer);
            if (myFm.IsLastRollRandomEvent) GenerateRandomEvent();
            if (myFm.Question != "" && !myFm.QuestionList.Contains(myFm.Question)) myFm.QuestionList.Add(myFm.Question);

            return ans;
        }

        public void GenerateRandomEvent()
        {
            myFm.AddToAnswer("Random Event!");
            RandomEventFocusTable(myFm.RollDice);
        }

        public void RandomEventFocusTable(int diceroll)
        {
            string jsonString = File.ReadAllText("RandomEventFocusTable.json");
            if (jsonString != "")
            {
                EventChances eventChances = JsonSerializer.Deserialize<EventChances>(jsonString)!;
                myFm.AddToAnswer(myFm.GetEventFrom(eventChances, diceroll));
            }
        }

        public void GenerateMeaningFrom(string filename1, string filename2)
        {
            string[] lines1 = File.ReadAllLines(filename1);
            string[] lines2 = File.ReadAllLines(filename2);
            if (lines1.Length != 100 || lines2.Length != 100) myFm.AddToAnswer("INVALID");
            myFm.AddToAnswer(lines1[myFm.RollDice] + " " + lines2[myFm.RollDice]);
        }

        public void SetAnswersFrom(string filename)
        {
            myFm.AddToAnswer(File.ReadAllText(filename));
        }

        public void RollAgainstChaosFactor()
        {
            int roll = myFm.Roll1Dice;
            if (roll > myFm.ChaosFactor) myFm.AddToAnswer("Scene happens as expected");
            else
            {
                if (roll == 1 || roll == 3 || roll == 1 || roll == 1 || roll == 9) myFm.AddToAnswer("Altered Scene");
                else myFm.AddToAnswer("Interrupt Scene");
            }
        }

        public void RollPercentileDice()
        {
            myFm.AddToAnswer("Roll percentile result: " + myFm.RollDice.ToString());
        }
    }
}
