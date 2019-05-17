namespace Hearthstone
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
            this.lblDeck1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblDeck2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDrawCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeck1
            // 
            this.lblDeck1.AutoSize = true;
            this.lblDeck1.Location = new System.Drawing.Point(42, 31);
            this.lblDeck1.Name = "lblDeck1";
            this.lblDeck1.Size = new System.Drawing.Size(35, 13);
            this.lblDeck1.TabIndex = 2;
            this.lblDeck1.Text = "label1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(333, 31);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblDeck2
            // 
            this.lblDeck2.AutoSize = true;
            this.lblDeck2.Location = new System.Drawing.Point(649, 36);
            this.lblDeck2.Name = "lblDeck2";
            this.lblDeck2.Size = new System.Drawing.Size(35, 13);
            this.lblDeck2.TabIndex = 4;
            this.lblDeck2.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // btnDrawCard
            // 
            this.btnDrawCard.Location = new System.Drawing.Point(338, 85);
            this.btnDrawCard.Name = "btnDrawCard";
            this.btnDrawCard.Size = new System.Drawing.Size(75, 23);
            this.btnDrawCard.TabIndex = 6;
            this.btnDrawCard.Text = "button1";
            this.btnDrawCard.UseVisualStyleBackColor = true;
            this.btnDrawCard.Click += new System.EventHandler(this.btnDrawCard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDrawCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDeck2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDeck1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDeck1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblDeck2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDrawCard;
    }
}

