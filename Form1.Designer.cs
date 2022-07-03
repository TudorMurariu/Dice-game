namespace Barbut
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
            this.ROLL = new System.Windows.Forms.Button();
            this.Dice1 = new System.Windows.Forms.PictureBox();
            this.Dice2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).BeginInit();
            this.SuspendLayout();
            // 
            // ROLL
            // 
            this.ROLL.BackColor = System.Drawing.Color.Black;
            this.ROLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ROLL.ForeColor = System.Drawing.Color.Fuchsia;
            this.ROLL.Location = new System.Drawing.Point(330, 355);
            this.ROLL.Name = "ROLL";
            this.ROLL.Size = new System.Drawing.Size(180, 60);
            this.ROLL.TabIndex = 0;
            this.ROLL.Text = "ROLL";
            this.ROLL.UseVisualStyleBackColor = false;
            this.ROLL.Click += new System.EventHandler(this.ROLL_Click);
            // 
            // Dice1
            // 
            this.Dice1.Image = global::Barbut.Properties.Resources.Dice1;
            this.Dice1.Location = new System.Drawing.Point(138, 98);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(171, 164);
            this.Dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice1.TabIndex = 1;
            this.Dice1.TabStop = false;
            // 
            // Dice2
            // 
            this.Dice2.Image = global::Barbut.Properties.Resources.Dice1;
            this.Dice2.Location = new System.Drawing.Point(531, 98);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(171, 164);
            this.Dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice2.TabIndex = 2;
            this.Dice2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(828, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(856, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dice2);
            this.Controls.Add(this.Dice1);
            this.Controls.Add(this.ROLL);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "`";
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ROLL;
        private System.Windows.Forms.PictureBox Dice1;
        private System.Windows.Forms.PictureBox Dice2;
        private System.Windows.Forms.Button button1;
    }
}

