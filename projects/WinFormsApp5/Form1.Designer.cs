namespace WinFormsApp5
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.joeGivesToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.joeGivesToBank = new System.Windows.Forms.Button();
            this.bobGivesToBank = new System.Windows.Forms.Button();
            this.hyperInflation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Location = new System.Drawing.Point(44, 41);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(66, 15);
            this.joesCashLabel.TabIndex = 2;
            this.joesCashLabel.Text = "Joe has $50";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Location = new System.Drawing.Point(44, 78);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(76, 15);
            this.bobsCashLabel.TabIndex = 3;
            this.bobsCashLabel.Text = "Bob has $100";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(44, 113);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(103, 15);
            this.bankCashLabel.TabIndex = 4;
            this.bankCashLabel.Text = "The Bank has $100";
            // 
            // joeGivesToBob
            // 
            this.joeGivesToBob.Location = new System.Drawing.Point(44, 215);
            this.joeGivesToBob.Name = "joeGivesToBob";
            this.joeGivesToBob.Size = new System.Drawing.Size(108, 51);
            this.joeGivesToBob.TabIndex = 5;
            this.joeGivesToBob.Text = "Joe gives $10 to Bob";
            this.joeGivesToBob.UseVisualStyleBackColor = true;
            this.joeGivesToBob.Click += new System.EventHandler(this.joeGivesToBob_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(158, 215);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(108, 51);
            this.bobGivesToJoe.TabIndex = 6;
            this.bobGivesToJoe.Text = "Bob gives $10 to Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // joeGivesToBank
            // 
            this.joeGivesToBank.Location = new System.Drawing.Point(44, 272);
            this.joeGivesToBank.Name = "joeGivesToBank";
            this.joeGivesToBank.Size = new System.Drawing.Size(108, 51);
            this.joeGivesToBank.TabIndex = 7;
            this.joeGivesToBank.Text = "Joe gives $10 to the Bank";
            this.joeGivesToBank.UseVisualStyleBackColor = true;
            this.joeGivesToBank.Click += new System.EventHandler(this.joeGivesToBank_Click);
            // 
            // bobGivesToBank
            // 
            this.bobGivesToBank.Location = new System.Drawing.Point(158, 272);
            this.bobGivesToBank.Name = "bobGivesToBank";
            this.bobGivesToBank.Size = new System.Drawing.Size(108, 51);
            this.bobGivesToBank.TabIndex = 8;
            this.bobGivesToBank.Text = "Bob gives $10 to the Bank";
            this.bobGivesToBank.UseVisualStyleBackColor = true;
            this.bobGivesToBank.Click += new System.EventHandler(this.bobGivesToBank_Click);
            // 
            // hyperInflation
            // 
            this.hyperInflation.Location = new System.Drawing.Point(44, 329);
            this.hyperInflation.Name = "hyperInflation";
            this.hyperInflation.Size = new System.Drawing.Size(222, 63);
            this.hyperInflation.TabIndex = 9;
            this.hyperInflation.Text = "The CDC causes Hype-Inflation";
            this.hyperInflation.UseVisualStyleBackColor = true;
            this.hyperInflation.Click += new System.EventHandler(this.hyperInflation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 425);
            this.Controls.Add(this.hyperInflation);
            this.Controls.Add(this.bobGivesToBank);
            this.Controls.Add(this.joeGivesToBank);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGivesToBob);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "The Monetary System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Label joesCashLabel;
        private Label bobsCashLabel;
        private Label bankCashLabel;
        private Button joeGivesToBob;
        private Button bobGivesToJoe;
        private Button joeGivesToBank;
        private Button bobGivesToBank;
        private Button hyperInflation;
    }
}