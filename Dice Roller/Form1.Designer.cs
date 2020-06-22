namespace Dice_Roller
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRoll = new System.Windows.Forms.Button();
            this.cmbCheck = new System.Windows.Forms.ComboBox();
            this.results = new System.Windows.Forms.Label();
            this.dice = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.strengthNum = new System.Windows.Forms.TextBox();
            this.dexterityNum = new System.Windows.Forms.TextBox();
            this.constitutionNum = new System.Windows.Forms.TextBox();
            this.intelligenceNum = new System.Windows.Forms.TextBox();
            this.wisdomNum = new System.Windows.Forms.TextBox();
            this.charismaNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.proficiency = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.proficientCheck = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.Color.White;
            this.btnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(305, 338);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(216, 39);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // cmbCheck
            // 
            this.cmbCheck.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCheck.FormattingEnabled = true;
            this.cmbCheck.Items.AddRange(new object[] {
            "Strength",
            "Athletics",
            "Dexterity",
            "Acrobatics",
            "Sleight of Hand",
            "Stealth",
            "Intelligence",
            "Arcana",
            "History",
            "Investigation",
            "Nature",
            "Religion",
            "Wisdom",
            "Animal Handling",
            "Insight",
            "Medicine",
            "Perception",
            "Survival",
            "Charisma",
            "Deception",
            "Intimidation",
            "Performance",
            "Persuasion",
            "Constitution"});
            this.cmbCheck.Location = new System.Drawing.Point(271, 27);
            this.cmbCheck.Name = "cmbCheck";
            this.cmbCheck.Size = new System.Drawing.Size(276, 28);
            this.cmbCheck.TabIndex = 1;
            // 
            // results
            // 
            this.results.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(363, 284);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(104, 33);
            this.results.TabIndex = 2;
            this.results.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dice
            // 
            this.dice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dice.Image = ((System.Drawing.Image)(resources.GetObject("dice.Image")));
            this.dice.Location = new System.Drawing.Point(345, 106);
            this.dice.Name = "dice";
            this.dice.Size = new System.Drawing.Size(133, 159);
            this.dice.TabIndex = 3;
            this.dice.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(243, 416);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // strengthNum
            // 
            this.strengthNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthNum.Location = new System.Drawing.Point(169, 28);
            this.strengthNum.Name = "strengthNum";
            this.strengthNum.Size = new System.Drawing.Size(49, 26);
            this.strengthNum.TabIndex = 5;
            // 
            // dexterityNum
            // 
            this.dexterityNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexterityNum.Location = new System.Drawing.Point(169, 84);
            this.dexterityNum.Name = "dexterityNum";
            this.dexterityNum.Size = new System.Drawing.Size(49, 26);
            this.dexterityNum.TabIndex = 6;
            // 
            // constitutionNum
            // 
            this.constitutionNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.constitutionNum.Location = new System.Drawing.Point(169, 140);
            this.constitutionNum.Name = "constitutionNum";
            this.constitutionNum.Size = new System.Drawing.Size(49, 26);
            this.constitutionNum.TabIndex = 7;
            // 
            // intelligenceNum
            // 
            this.intelligenceNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intelligenceNum.Location = new System.Drawing.Point(169, 196);
            this.intelligenceNum.Name = "intelligenceNum";
            this.intelligenceNum.Size = new System.Drawing.Size(49, 26);
            this.intelligenceNum.TabIndex = 8;
            // 
            // wisdomNum
            // 
            this.wisdomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wisdomNum.Location = new System.Drawing.Point(169, 252);
            this.wisdomNum.Name = "wisdomNum";
            this.wisdomNum.Size = new System.Drawing.Size(49, 26);
            this.wisdomNum.TabIndex = 9;
            // 
            // charismaNum
            // 
            this.charismaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charismaNum.Location = new System.Drawing.Point(169, 308);
            this.charismaNum.Name = "charismaNum";
            this.charismaNum.Size = new System.Drawing.Size(49, 26);
            this.charismaNum.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Strength";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dexterity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Charisma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Wisdom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Intelligence";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Constitution";
            // 
            // proficiency
            // 
            this.proficiency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proficiency.Location = new System.Drawing.Point(169, 364);
            this.proficiency.Name = "proficiency";
            this.proficiency.Size = new System.Drawing.Size(49, 26);
            this.proficiency.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(12, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "Proficiency Bonus";
            // 
            // proficientCheck
            // 
            this.proficientCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.proficientCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proficientCheck.Location = new System.Drawing.Point(269, 61);
            this.proficientCheck.Name = "proficientCheck";
            this.proficientCheck.Size = new System.Drawing.Size(25, 27);
            this.proficientCheck.TabIndex = 19;
            this.proficientCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.proficientCheck.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(294, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Proficient";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(573, 416);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.proficientCheck);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.proficiency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.charismaNum);
            this.Controls.Add(this.wisdomNum);
            this.Controls.Add(this.intelligenceNum);
            this.Controls.Add(this.constitutionNum);
            this.Controls.Add(this.dexterityNum);
            this.Controls.Add(this.strengthNum);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dice);
            this.Controls.Add(this.results);
            this.Controls.Add(this.cmbCheck);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "Saving Throws";
            ((System.ComponentModel.ISupportInitialize)(this.dice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.ComboBox cmbCheck;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.PictureBox dice;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox strengthNum;
        private System.Windows.Forms.TextBox dexterityNum;
        private System.Windows.Forms.TextBox constitutionNum;
        private System.Windows.Forms.TextBox intelligenceNum;
        private System.Windows.Forms.TextBox wisdomNum;
        private System.Windows.Forms.TextBox charismaNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox proficiency;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox proficientCheck;
        private System.Windows.Forms.Label label8;
    }
}

