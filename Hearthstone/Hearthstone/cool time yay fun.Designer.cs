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
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radAdventure = new System.Windows.Forms.RadioButton();
            this.radTwoPlayer = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(142, 209);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radAdventure);
            this.groupBox1.Controls.Add(this.radTwoPlayer);
            this.groupBox1.Location = new System.Drawing.Point(86, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick A Game Mode";
            // 
            // radAdventure
            // 
            this.radAdventure.AutoSize = true;
            this.radAdventure.Location = new System.Drawing.Point(25, 68);
            this.radAdventure.Name = "radAdventure";
            this.radAdventure.Size = new System.Drawing.Size(104, 17);
            this.radAdventure.TabIndex = 1;
            this.radAdventure.TabStop = true;
            this.radAdventure.Text = "Adventure Mode";
            this.radAdventure.UseVisualStyleBackColor = true;
            // 
            // radTwoPlayer
            // 
            this.radTwoPlayer.AutoSize = true;
            this.radTwoPlayer.Location = new System.Drawing.Point(25, 29);
            this.radTwoPlayer.Name = "radTwoPlayer";
            this.radTwoPlayer.Size = new System.Drawing.Size(108, 17);
            this.radTwoPlayer.TabIndex = 0;
            this.radTwoPlayer.TabStop = true;
            this.radTwoPlayer.Text = "Two Player Mode";
            this.radTwoPlayer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radAdventure;
        private System.Windows.Forms.RadioButton radTwoPlayer;
    }
}

