namespace Krysa_game
{
    partial class Hra
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hra));
            this.Krysa = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.gameArea = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Krysa)).BeginInit();
            this.gameArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // Krysa
            // 
            this.Krysa.Image = ((System.Drawing.Image)(resources.GetObject("Krysa.Image")));
            this.Krysa.Location = new System.Drawing.Point(327, 433);
            this.Krysa.Name = "Krysa";
            this.Krysa.Size = new System.Drawing.Size(50, 64);
            this.Krysa.TabIndex = 0;
            this.Krysa.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // gameArea
            // 
            this.gameArea.Controls.Add(this.Krysa);
            this.gameArea.Location = new System.Drawing.Point(12, 12);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(960, 537);
            this.gameArea.TabIndex = 1;
            // 
            // Hra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.gameArea);
            this.Name = "Hra";
            this.Text = "Krysa Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Krysa)).EndInit();
            this.gameArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Krysa;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel gameArea;
    }
}

