namespace MegaMasterMixCalculator
{
    partial class pcrMegaMixCalculator
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
            this.numericUpDownPCRreactions = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSingleReactionVolume = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrimer1inSingleReaction = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPraimer2inSingleReaction = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDNAinSingleReaction = new System.Windows.Forms.NumericUpDown();
            this.numberOfReactions = new System.Windows.Forms.Label();
            this.volumeOfSingleReaction = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.megaMixTotalVolume = new System.Windows.Forms.Label();
            this.masterMixTotalVolume = new System.Windows.Forms.Label();
            this.primer1TotalVolume = new System.Windows.Forms.Label();
            this.primer2TotalVolume = new System.Windows.Forms.Label();
            this.waterTotalVolume = new System.Windows.Forms.Label();
            this.BottomTextConclusion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPCRreactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSingleReactionVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrimer1inSingleReaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPraimer2inSingleReaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDNAinSingleReaction)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPCRreactions
            // 
            this.numericUpDownPCRreactions.Location = new System.Drawing.Point(13, 13);
            this.numericUpDownPCRreactions.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPCRreactions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPCRreactions.Name = "numericUpDownPCRreactions";
            this.numericUpDownPCRreactions.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPCRreactions.TabIndex = 0;
            this.numericUpDownPCRreactions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPCRreactions.ValueChanged += new System.EventHandler(this.numericUpDownPCRreactions_ValueChanged);
            // 
            // numericUpDownSingleReactionVolume
            // 
            this.numericUpDownSingleReactionVolume.Location = new System.Drawing.Point(13, 40);
            this.numericUpDownSingleReactionVolume.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownSingleReactionVolume.Name = "numericUpDownSingleReactionVolume";
            this.numericUpDownSingleReactionVolume.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSingleReactionVolume.TabIndex = 1;
            this.numericUpDownSingleReactionVolume.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownSingleReactionVolume.ValueChanged += new System.EventHandler(this.numericUpDownSingleReactionVolume_ValueChanged);
            // 
            // numericUpDownPrimer1inSingleReaction
            // 
            this.numericUpDownPrimer1inSingleReaction.Location = new System.Drawing.Point(13, 67);
            this.numericUpDownPrimer1inSingleReaction.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownPrimer1inSingleReaction.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPrimer1inSingleReaction.Name = "numericUpDownPrimer1inSingleReaction";
            this.numericUpDownPrimer1inSingleReaction.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPrimer1inSingleReaction.TabIndex = 2;
            this.numericUpDownPrimer1inSingleReaction.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPrimer1inSingleReaction.ValueChanged += new System.EventHandler(this.numericUpDownPrimer1inSingleReaction_ValueChanged);
            // 
            // numericUpDownPraimer2inSingleReaction
            // 
            this.numericUpDownPraimer2inSingleReaction.Location = new System.Drawing.Point(13, 94);
            this.numericUpDownPraimer2inSingleReaction.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownPraimer2inSingleReaction.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPraimer2inSingleReaction.Name = "numericUpDownPraimer2inSingleReaction";
            this.numericUpDownPraimer2inSingleReaction.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPraimer2inSingleReaction.TabIndex = 3;
            this.numericUpDownPraimer2inSingleReaction.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPraimer2inSingleReaction.ValueChanged += new System.EventHandler(this.numericUpDownPraimer2inSingleReaction_ValueChanged);
            // 
            // numericUpDownDNAinSingleReaction
            // 
            this.numericUpDownDNAinSingleReaction.Location = new System.Drawing.Point(13, 121);
            this.numericUpDownDNAinSingleReaction.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDNAinSingleReaction.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDNAinSingleReaction.Name = "numericUpDownDNAinSingleReaction";
            this.numericUpDownDNAinSingleReaction.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDNAinSingleReaction.TabIndex = 4;
            this.numericUpDownDNAinSingleReaction.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDNAinSingleReaction.ValueChanged += new System.EventHandler(this.numericUpDownDNAinSingleReaction_ValueChanged);
            // 
            // numberOfReactions
            // 
            this.numberOfReactions.AutoSize = true;
            this.numberOfReactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfReactions.Location = new System.Drawing.Point(142, 13);
            this.numberOfReactions.Name = "numberOfReactions";
            this.numberOfReactions.Size = new System.Drawing.Size(340, 16);
            this.numberOfReactions.TabIndex = 5;
            this.numberOfReactions.Text = "Общ брой PCR реакции (включително резервните)";
            // 
            // volumeOfSingleReaction
            // 
            this.volumeOfSingleReaction.AutoSize = true;
            this.volumeOfSingleReaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeOfSingleReaction.Location = new System.Drawing.Point(142, 40);
            this.volumeOfSingleReaction.Name = "volumeOfSingleReaction";
            this.volumeOfSingleReaction.Size = new System.Drawing.Size(186, 16);
            this.volumeOfSingleReaction.TabIndex = 6;
            this.volumeOfSingleReaction.Text = "Обем на единична реакция";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(142, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Обем на праймер 1 във всяка реакция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(142, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Обем на праймер 2 във всяка реакция";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(142, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Обем на добавената матрична ДНК във всяка реакция";
            // 
            // megaMixTotalVolume
            // 
            this.megaMixTotalVolume.AutoSize = true;
            this.megaMixTotalVolume.BackColor = System.Drawing.Color.Orange;
            this.megaMixTotalVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.megaMixTotalVolume.Location = new System.Drawing.Point(13, 215);
            this.megaMixTotalVolume.Name = "megaMixTotalVolume";
            this.megaMixTotalVolume.Size = new System.Drawing.Size(45, 16);
            this.megaMixTotalVolume.TabIndex = 10;
            this.megaMixTotalVolume.Text = "label4";
            // 
            // masterMixTotalVolume
            // 
            this.masterMixTotalVolume.AutoSize = true;
            this.masterMixTotalVolume.BackColor = System.Drawing.Color.Orange;
            this.masterMixTotalVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterMixTotalVolume.Location = new System.Drawing.Point(13, 245);
            this.masterMixTotalVolume.Name = "masterMixTotalVolume";
            this.masterMixTotalVolume.Size = new System.Drawing.Size(45, 16);
            this.masterMixTotalVolume.TabIndex = 11;
            this.masterMixTotalVolume.Text = "label5";
            // 
            // primer1TotalVolume
            // 
            this.primer1TotalVolume.AutoSize = true;
            this.primer1TotalVolume.BackColor = System.Drawing.Color.Orange;
            this.primer1TotalVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.primer1TotalVolume.Location = new System.Drawing.Point(13, 276);
            this.primer1TotalVolume.Name = "primer1TotalVolume";
            this.primer1TotalVolume.Size = new System.Drawing.Size(45, 16);
            this.primer1TotalVolume.TabIndex = 12;
            this.primer1TotalVolume.Text = "label6";
            // 
            // primer2TotalVolume
            // 
            this.primer2TotalVolume.AutoSize = true;
            this.primer2TotalVolume.BackColor = System.Drawing.Color.Orange;
            this.primer2TotalVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.primer2TotalVolume.Location = new System.Drawing.Point(13, 304);
            this.primer2TotalVolume.Name = "primer2TotalVolume";
            this.primer2TotalVolume.Size = new System.Drawing.Size(45, 16);
            this.primer2TotalVolume.TabIndex = 13;
            this.primer2TotalVolume.Text = "label7";
            // 
            // waterTotalVolume
            // 
            this.waterTotalVolume.AutoSize = true;
            this.waterTotalVolume.BackColor = System.Drawing.Color.Orange;
            this.waterTotalVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waterTotalVolume.Location = new System.Drawing.Point(13, 334);
            this.waterTotalVolume.Name = "waterTotalVolume";
            this.waterTotalVolume.Size = new System.Drawing.Size(45, 16);
            this.waterTotalVolume.TabIndex = 14;
            this.waterTotalVolume.Text = "label8";
            // 
            // BottomTextConclusion
            // 
            this.BottomTextConclusion.AutoSize = true;
            this.BottomTextConclusion.BackColor = System.Drawing.Color.Lavender;
            this.BottomTextConclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BottomTextConclusion.Location = new System.Drawing.Point(13, 375);
            this.BottomTextConclusion.Name = "BottomTextConclusion";
            this.BottomTextConclusion.Size = new System.Drawing.Size(45, 16);
            this.BottomTextConclusion.TabIndex = 15;
            this.BottomTextConclusion.Text = "label9";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(266, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Общ обем на мегамикса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(266, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "MasterMix за добавяне към мегамикса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(266, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Обем от праймер 1 за добавяне към мегамикса";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(266, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Обем от праймер 2 за добавяне към мегамикса";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(266, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Обем вода за добавяне към мегамикса";
            // 
            // pcrMegaMixCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 417);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BottomTextConclusion);
            this.Controls.Add(this.waterTotalVolume);
            this.Controls.Add(this.primer2TotalVolume);
            this.Controls.Add(this.primer1TotalVolume);
            this.Controls.Add(this.masterMixTotalVolume);
            this.Controls.Add(this.megaMixTotalVolume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volumeOfSingleReaction);
            this.Controls.Add(this.numberOfReactions);
            this.Controls.Add(this.numericUpDownDNAinSingleReaction);
            this.Controls.Add(this.numericUpDownPraimer2inSingleReaction);
            this.Controls.Add(this.numericUpDownPrimer1inSingleReaction);
            this.Controls.Add(this.numericUpDownSingleReactionVolume);
            this.Controls.Add(this.numericUpDownPCRreactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pcrMegaMixCalculator";
            this.Text = "MegaMix Calculator";
            this.Load += new System.EventHandler(this.pcrMegaMixCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPCRreactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSingleReactionVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrimer1inSingleReaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPraimer2inSingleReaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDNAinSingleReaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownPCRreactions;
        private System.Windows.Forms.NumericUpDown numericUpDownSingleReactionVolume;
        private System.Windows.Forms.NumericUpDown numericUpDownPrimer1inSingleReaction;
        private System.Windows.Forms.NumericUpDown numericUpDownPraimer2inSingleReaction;
        private System.Windows.Forms.NumericUpDown numericUpDownDNAinSingleReaction;
        private System.Windows.Forms.Label numberOfReactions;
        private System.Windows.Forms.Label volumeOfSingleReaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label megaMixTotalVolume;
        private System.Windows.Forms.Label masterMixTotalVolume;
        private System.Windows.Forms.Label primer1TotalVolume;
        private System.Windows.Forms.Label primer2TotalVolume;
        private System.Windows.Forms.Label waterTotalVolume;
        private System.Windows.Forms.Label BottomTextConclusion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

