namespace DnDProbabilityCalculator
{
    partial class Form1
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
            modifierTrackBar = new TrackBar();
            label1 = new Label();
            abilityModifierTextBox = new TextBox();
            label2 = new Label();
            inspirationDiceTrackBar = new TrackBar();
            inspirationDiceTextBox = new TextBox();
            advantageCheckBox = new CheckBox();
            guidanceCheckBox = new CheckBox();
            disadvantageCheckBox = new CheckBox();
            luckCheckBox = new CheckBox();
            bonusModifierTrackBar = new TrackBar();
            label3 = new Label();
            blessCheckBox = new CheckBox();
            bonusModifierTextBox = new TextBox();
            label4 = new Label();
            difficultyClassTrackBar = new TrackBar();
            difficultyClassTextBox = new TextBox();
            calculateButton = new Button();
            label6 = new Label();
            sampleSizeTrackBar = new TrackBar();
            sampleSizeTextBox = new TextBox();
            totalSuccessTextBox = new TextBox();
            label5 = new Label();
            label7 = new Label();
            meanTextBox = new TextBox();
            label8 = new Label();
            bestTextBox = new TextBox();
            label9 = new Label();
            modeTextBox = new TextBox();
            label10 = new Label();
            worstTextBox = new TextBox();
            label11 = new Label();
            percentageTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)modifierTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inspirationDiceTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bonusModifierTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difficultyClassTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sampleSizeTrackBar).BeginInit();
            SuspendLayout();
            // 
            // modifierTrackBar
            // 
            modifierTrackBar.Location = new Point(12, 37);
            modifierTrackBar.Minimum = -10;
            modifierTrackBar.Name = "modifierTrackBar";
            modifierTrackBar.Size = new Size(500, 69);
            modifierTrackBar.TabIndex = 0;
            modifierTrackBar.Scroll += modifierTrackBar_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 1;
            label1.Text = "Set your abillity modifier:";
            // 
            // abilityModifierTextBox
            // 
            abilityModifierTextBox.Location = new Point(518, 37);
            abilityModifierTextBox.Name = "abilityModifierTextBox";
            abilityModifierTextBox.ReadOnly = true;
            abilityModifierTextBox.Size = new Size(66, 31);
            abilityModifierTextBox.TabIndex = 2;
            abilityModifierTextBox.TextChanged += abilityModifierTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 119);
            label2.Name = "label2";
            label2.Size = new Size(207, 25);
            label2.TabIndex = 3;
            label2.Text = "Set your inspiration dice:";
            // 
            // inspirationDiceTrackBar
            // 
            inspirationDiceTrackBar.Location = new Point(12, 147);
            inspirationDiceTrackBar.Maximum = 12;
            inspirationDiceTrackBar.Name = "inspirationDiceTrackBar";
            inspirationDiceTrackBar.Size = new Size(500, 69);
            inspirationDiceTrackBar.TabIndex = 4;
            inspirationDiceTrackBar.Scroll += inspirationDiceTrackBar_Scroll;
            // 
            // inspirationDiceTextBox
            // 
            inspirationDiceTextBox.Location = new Point(518, 147);
            inspirationDiceTextBox.Name = "inspirationDiceTextBox";
            inspirationDiceTextBox.ReadOnly = true;
            inspirationDiceTextBox.Size = new Size(66, 31);
            inspirationDiceTextBox.TabIndex = 5;
            // 
            // advantageCheckBox
            // 
            advantageCheckBox.AutoSize = true;
            advantageCheckBox.Location = new Point(18, 322);
            advantageCheckBox.Name = "advantageCheckBox";
            advantageCheckBox.Size = new Size(124, 29);
            advantageCheckBox.TabIndex = 6;
            advantageCheckBox.Text = "Advantage";
            advantageCheckBox.UseVisualStyleBackColor = true;
            advantageCheckBox.CheckedChanged += advantageCheckBox_CheckedChanged;
            // 
            // guidanceCheckBox
            // 
            guidanceCheckBox.AutoSize = true;
            guidanceCheckBox.Location = new Point(18, 357);
            guidanceCheckBox.Name = "guidanceCheckBox";
            guidanceCheckBox.Size = new Size(111, 29);
            guidanceCheckBox.TabIndex = 7;
            guidanceCheckBox.Text = "Guidance";
            guidanceCheckBox.UseVisualStyleBackColor = true;
            guidanceCheckBox.CheckedChanged += guidanceCheckBox_CheckedChanged;
            // 
            // disadvantageCheckBox
            // 
            disadvantageCheckBox.AutoSize = true;
            disadvantageCheckBox.Location = new Point(148, 322);
            disadvantageCheckBox.Name = "disadvantageCheckBox";
            disadvantageCheckBox.Size = new Size(146, 29);
            disadvantageCheckBox.TabIndex = 8;
            disadvantageCheckBox.Text = "Disadvantage";
            disadvantageCheckBox.UseVisualStyleBackColor = true;
            // 
            // luckCheckBox
            // 
            luckCheckBox.AutoSize = true;
            luckCheckBox.Location = new Point(300, 322);
            luckCheckBox.Name = "luckCheckBox";
            luckCheckBox.Size = new Size(73, 29);
            luckCheckBox.TabIndex = 9;
            luckCheckBox.Text = "Luck";
            luckCheckBox.UseVisualStyleBackColor = true;
            // 
            // bonusModifierTrackBar
            // 
            bonusModifierTrackBar.Location = new Point(12, 247);
            bonusModifierTrackBar.Minimum = -10;
            bonusModifierTrackBar.Name = "bonusModifierTrackBar";
            bonusModifierTrackBar.Size = new Size(500, 69);
            bonusModifierTrackBar.TabIndex = 10;
            bonusModifierTrackBar.Scroll += bonusModifierTrackBar_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 219);
            label3.Name = "label3";
            label3.Size = new Size(238, 25);
            label3.TabIndex = 11;
            label3.Text = "Set any additional modifiers:";
            label3.Click += label3_Click;
            // 
            // blessCheckBox
            // 
            blessCheckBox.AutoSize = true;
            blessCheckBox.Location = new Point(148, 357);
            blessCheckBox.Name = "blessCheckBox";
            blessCheckBox.Size = new Size(77, 29);
            blessCheckBox.TabIndex = 12;
            blessCheckBox.Text = "Bless";
            blessCheckBox.UseVisualStyleBackColor = true;
            blessCheckBox.CheckedChanged += blessCheckBox_CheckedChanged;
            // 
            // bonusModifierTextBox
            // 
            bonusModifierTextBox.Location = new Point(518, 247);
            bonusModifierTextBox.Name = "bonusModifierTextBox";
            bonusModifierTextBox.ReadOnly = true;
            bonusModifierTextBox.Size = new Size(66, 31);
            bonusModifierTextBox.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 389);
            label4.Name = "label4";
            label4.Size = new Size(287, 25);
            label4.TabIndex = 14;
            label4.Text = "Set the difficulty class of the check:";
            // 
            // difficultyClassTrackBar
            // 
            difficultyClassTrackBar.Location = new Point(18, 417);
            difficultyClassTrackBar.Maximum = 35;
            difficultyClassTrackBar.Minimum = 10;
            difficultyClassTrackBar.Name = "difficultyClassTrackBar";
            difficultyClassTrackBar.Size = new Size(500, 69);
            difficultyClassTrackBar.TabIndex = 15;
            difficultyClassTrackBar.Value = 10;
            difficultyClassTrackBar.Scroll += difficultyClassTrackBar_Scroll;
            // 
            // difficultyClassTextBox
            // 
            difficultyClassTextBox.Location = new Point(518, 417);
            difficultyClassTextBox.Name = "difficultyClassTextBox";
            difficultyClassTextBox.ReadOnly = true;
            difficultyClassTextBox.Size = new Size(66, 31);
            difficultyClassTextBox.TabIndex = 16;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(18, 592);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(566, 34);
            calculateButton.TabIndex = 17;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 489);
            label6.Name = "label6";
            label6.Size = new Size(199, 25);
            label6.TabIndex = 19;
            label6.Text = "Select your sample size:";
            // 
            // sampleSizeTrackBar
            // 
            sampleSizeTrackBar.Location = new Point(18, 517);
            sampleSizeTrackBar.Maximum = 8;
            sampleSizeTrackBar.Name = "sampleSizeTrackBar";
            sampleSizeTrackBar.Size = new Size(494, 69);
            sampleSizeTrackBar.TabIndex = 20;
            sampleSizeTrackBar.Scroll += sampleSizeTrackBar_Scroll;
            // 
            // sampleSizeTextBox
            // 
            sampleSizeTextBox.Location = new Point(518, 517);
            sampleSizeTextBox.Name = "sampleSizeTextBox";
            sampleSizeTextBox.ReadOnly = true;
            sampleSizeTextBox.Size = new Size(66, 31);
            sampleSizeTextBox.TabIndex = 21;
            // 
            // totalSuccessTextBox
            // 
            totalSuccessTextBox.Location = new Point(18, 666);
            totalSuccessTextBox.Name = "totalSuccessTextBox";
            totalSuccessTextBox.ReadOnly = true;
            totalSuccessTextBox.Size = new Size(276, 31);
            totalSuccessTextBox.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 638);
            label5.Name = "label5";
            label5.Size = new Size(144, 25);
            label5.TabIndex = 23;
            label5.Text = "Total Successess:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 701);
            label7.Name = "label7";
            label7.Size = new Size(90, 25);
            label7.TabIndex = 25;
            label7.Text = "Mean roll:";
            // 
            // meanTextBox
            // 
            meanTextBox.Location = new Point(18, 729);
            meanTextBox.Name = "meanTextBox";
            meanTextBox.ReadOnly = true;
            meanTextBox.Size = new Size(276, 31);
            meanTextBox.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 763);
            label8.Name = "label8";
            label8.Size = new Size(83, 25);
            label8.TabIndex = 27;
            label8.Text = "Best Roll:";
            // 
            // bestTextBox
            // 
            bestTextBox.Location = new Point(18, 791);
            bestTextBox.Name = "bestTextBox";
            bestTextBox.ReadOnly = true;
            bestTextBox.Size = new Size(276, 31);
            bestTextBox.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(308, 701);
            label9.Name = "label9";
            label9.Size = new Size(97, 25);
            label9.TabIndex = 29;
            label9.Text = "Mode Roll:";
            // 
            // modeTextBox
            // 
            modeTextBox.Location = new Point(308, 729);
            modeTextBox.Name = "modeTextBox";
            modeTextBox.ReadOnly = true;
            modeTextBox.Size = new Size(276, 31);
            modeTextBox.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(308, 763);
            label10.Name = "label10";
            label10.Size = new Size(97, 25);
            label10.TabIndex = 31;
            label10.Text = "Worst Roll:";
            // 
            // worstTextBox
            // 
            worstTextBox.Location = new Point(308, 791);
            worstTextBox.Name = "worstTextBox";
            worstTextBox.ReadOnly = true;
            worstTextBox.Size = new Size(276, 31);
            worstTextBox.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(308, 638);
            label11.Name = "label11";
            label11.Size = new Size(159, 25);
            label11.TabIndex = 33;
            label11.Text = "Chance of success:";
            // 
            // percentageTextBox
            // 
            percentageTextBox.Location = new Point(308, 666);
            percentageTextBox.Name = "percentageTextBox";
            percentageTextBox.ReadOnly = true;
            percentageTextBox.Size = new Size(276, 31);
            percentageTextBox.TabIndex = 32;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 834);
            Controls.Add(label11);
            Controls.Add(percentageTextBox);
            Controls.Add(label10);
            Controls.Add(worstTextBox);
            Controls.Add(label9);
            Controls.Add(modeTextBox);
            Controls.Add(label8);
            Controls.Add(bestTextBox);
            Controls.Add(label7);
            Controls.Add(meanTextBox);
            Controls.Add(label5);
            Controls.Add(totalSuccessTextBox);
            Controls.Add(sampleSizeTextBox);
            Controls.Add(sampleSizeTrackBar);
            Controls.Add(label6);
            Controls.Add(calculateButton);
            Controls.Add(difficultyClassTextBox);
            Controls.Add(difficultyClassTrackBar);
            Controls.Add(label4);
            Controls.Add(bonusModifierTextBox);
            Controls.Add(blessCheckBox);
            Controls.Add(label3);
            Controls.Add(bonusModifierTrackBar);
            Controls.Add(luckCheckBox);
            Controls.Add(disadvantageCheckBox);
            Controls.Add(guidanceCheckBox);
            Controls.Add(advantageCheckBox);
            Controls.Add(inspirationDiceTextBox);
            Controls.Add(inspirationDiceTrackBar);
            Controls.Add(label2);
            Controls.Add(abilityModifierTextBox);
            Controls.Add(label1);
            Controls.Add(modifierTrackBar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "D&D Probability";
            ((System.ComponentModel.ISupportInitialize)modifierTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)inspirationDiceTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)bonusModifierTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)difficultyClassTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)sampleSizeTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar modifierTrackBar;
        private Label label1;
        private TextBox abilityModifierTextBox;
        private Label label2;
        private TrackBar inspirationDiceTrackBar;
        private TextBox inspirationDiceTextBox;
        private CheckBox advantageCheckBox;
        private CheckBox guidanceCheckBox;
        private CheckBox disadvantageCheckBox;
        private CheckBox luckCheckBox;
        private TrackBar bonusModifierTrackBar;
        private Label label3;
        private CheckBox blessCheckBox;
        private TextBox bonusModifierTextBox;
        private Label label4;
        private TrackBar difficultyClassTrackBar;
        private TextBox difficultyClassTextBox;
        private Button calculateButton;
        private Label label6;
        private TrackBar sampleSizeTrackBar;
        private TextBox sampleSizeTextBox;
        private TextBox totalSuccessTextBox;
        private Label label5;
        private Label label7;
        private TextBox meanTextBox;
        private Label label8;
        private TextBox bestTextBox;
        private Label label9;
        private TextBox modeTextBox;
        private Label label10;
        private TextBox worstTextBox;
        private Label label11;
        private TextBox percentageTextBox;
    }
}
