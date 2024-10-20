using System.Reflection.PortableExecutable;

namespace DnDProbabilityCalculator
{
    public partial class Form1 : Form
    {
        public int abilityModifier = 0;
        public int inspirationDice = 0;
        public int bonusModdifier = 0;
        public int difficultyClass = 10;

        public int successess = 0;
        public double percentage = 0;
        public double mean = 0;
        public double mode = 0;
        public List<int> checks = new List<int>();

        public double sampleSize;

        public bool advantage;
        public bool luck;
        public bool guidance;
        public bool bless;
        public bool disadvantage;

        public Form1()
        {
            InitializeComponent();
            modifierTrackBar.Value = abilityModifier;
            inspirationDiceTrackBar.Value = inspirationDice;
            bonusModifierTrackBar.Value = bonusModdifier;
            difficultyClassTrackBar.Value = difficultyClass;

            abilityModifierTextBox.Text = abilityModifier.ToString();
            inspirationDiceTextBox.Text = inspirationDice.ToString();
            bonusModifierTextBox.Text = bonusModdifier.ToString();
            difficultyClassTextBox.Text = difficultyClass.ToString();
        }

        private void modifierTrackBar_Scroll(object sender, EventArgs e)
        {
            abilityModifierTextBox.Text = modifierTrackBar.Value.ToString();
        }

        private void inspirationDiceTrackBar_Scroll(object sender, EventArgs e)
        {
            inspirationDiceTextBox.Text = "d" + inspirationDiceTrackBar.Value.ToString();
        }
        private void difficultyClassTrackBar_Scroll(object sender, EventArgs e)
        {
            difficultyClassTextBox.Text = difficultyClassTrackBar.Value.ToString();
        }
        private void bonusModifierTrackBar_Scroll(object sender, EventArgs e)
        {
            bonusModifierTextBox.Text = bonusModifierTrackBar.Value.ToString();
        }




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void advantageCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guidanceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (guidanceCheckBox.Checked)
            {
                blessCheckBox.Checked = false;
            }
        }

        private void blessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (blessCheckBox.Checked)
            {
                guidanceCheckBox.Checked = false;
            }

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            checks.Clear();
            Random rnd = new Random();
            successess = 0;
            
            abilityModifier = modifierTrackBar.Value;
            inspirationDice = inspirationDiceTrackBar.Value;
            bonusModdifier = bonusModifierTrackBar.Value;
            difficultyClass = difficultyClassTrackBar.Value;

            advantage = advantageCheckBox.Checked;
            disadvantage = disadvantageCheckBox.Checked;
            luck = luckCheckBox.Checked;

            bless = blessCheckBox.Checked;
            guidance = guidanceCheckBox.Checked;

            sampleSize = Math.Pow(10, sampleSizeTrackBar.Value);

            for (int i = 0; i < sampleSize; i++)
            {
                int roll = rnd.Next(1, 20);
                int luck_roll = rnd.Next(1, 20);
                int extra_roll = rnd.Next(1, 20);

                if (advantage && !disadvantage)
                {
                    roll = Math.Max(roll, extra_roll);
                }
                else if (disadvantage && !advantage)
                {
                    roll = Math.Min(roll, extra_roll);
                }

                if (luck) 
                {
                    roll = Math.Max(roll, luck_roll);
                        
                }

                if (inspirationDice > 0)
                {
                    roll += rnd.Next(1, inspirationDice);
                }

                if (guidance)
                {
                    roll += rnd.Next(1, 4);
                }
                else if (bless)
                {
                    roll += rnd.Next(1, 4);
                }
                roll += abilityModifier + bonusModdifier;
                if (roll >= difficultyClass)
                {
                    successess += 1;
                }

                checks.Add(roll);
            }

            float meanTotal = 0;
            for (int i = 0; i < checks.Count; i++)
            {
                meanTotal += checks[i];
            }

            mean = meanTotal / sampleSize;

            percentage = successess / sampleSize * 100;

            mode = (from item in checks
                    group item by item into g
                    orderby g.Count() descending
                    select g.Key).First();

            totalSuccessTextBox.Text = successess.ToString();
            percentageTextBox.Text = percentage.ToString() + "%";

            meanTextBox.Text = mean.ToString();
            modeTextBox.Text = mode.ToString();

            bestTextBox.Text = checks.Max().ToString();
            worstTextBox.Text = checks.Min().ToString();

        }

        private void abilityModifierTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sampleSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            sampleSize = Math.Pow(10, sampleSizeTrackBar.Value);
            sampleSizeTextBox.Text = Humanize(sampleSize);

        }


        private string Humanize(double number)
        {
            string[] suffix = { "f", "a", "p", "n", "μ", "m", string.Empty, "k", "M", "B", "T", "Q", "Qu" };

            var absnum = Math.Abs(number);

            int mag;
            if (absnum < 1)
            {
                mag = (int)Math.Floor(Math.Floor(Math.Log10(absnum)) / 3);
            }
            else
            {
                mag = (int)(Math.Floor(Math.Log10(absnum)) / 3);
            }

            var shortNumber = number / Math.Pow(10, mag * 3);

            return $"{shortNumber:0.###}{suffix[mag + 6]}";
        }
    }
}
