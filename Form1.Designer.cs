namespace WindowsFormsApp1
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
            this.championsBlade = new System.Windows.Forms.RadioButton();
            this.ceremonialBlade = new System.Windows.Forms.RadioButton();
            this.normalBlade = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pidLabel = new System.Windows.Forms.Label();
            this.connectionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // championsBlade
            // 
            this.championsBlade.AutoSize = true;
            this.championsBlade.BackColor = System.Drawing.Color.White;
            this.championsBlade.ForeColor = System.Drawing.Color.Black;
            this.championsBlade.Location = new System.Drawing.Point(274, 158);
            this.championsBlade.Name = "championsBlade";
            this.championsBlade.Size = new System.Drawing.Size(107, 17);
            this.championsBlade.TabIndex = 0;
            this.championsBlade.TabStop = true;
            this.championsBlade.Text = "Champions Blade";
            this.championsBlade.UseVisualStyleBackColor = false;
            this.championsBlade.CheckedChanged += new System.EventHandler(this.ChampionsBlade_CheckedChanged);
            // 
            // ceremonialBlade
            // 
            this.ceremonialBlade.AutoSize = true;
            this.ceremonialBlade.BackColor = System.Drawing.Color.White;
            this.ceremonialBlade.ForeColor = System.Drawing.Color.Black;
            this.ceremonialBlade.Location = new System.Drawing.Point(134, 158);
            this.ceremonialBlade.Name = "ceremonialBlade";
            this.ceremonialBlade.Size = new System.Drawing.Size(107, 17);
            this.ceremonialBlade.TabIndex = 1;
            this.ceremonialBlade.TabStop = true;
            this.ceremonialBlade.Text = "Ceremonial Blade";
            this.ceremonialBlade.UseVisualStyleBackColor = false;
            this.ceremonialBlade.CheckedChanged += new System.EventHandler(this.CeremonialBlade_CheckedChanged);
            // 
            // normalBlade
            // 
            this.normalBlade.AutoSize = true;
            this.normalBlade.BackColor = System.Drawing.Color.White;
            this.normalBlade.ForeColor = System.Drawing.Color.Black;
            this.normalBlade.Location = new System.Drawing.Point(12, 158);
            this.normalBlade.Name = "normalBlade";
            this.normalBlade.Size = new System.Drawing.Size(88, 17);
            this.normalBlade.TabIndex = 2;
            this.normalBlade.TabStop = true;
            this.normalBlade.Text = "Normal Blade";
            this.normalBlade.UseVisualStyleBackColor = false;
            this.normalBlade.CheckedChanged += new System.EventHandler(this.NormalBlade_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.download;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 138);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pidLabel);
            this.groupBox1.Controls.Add(this.connectionLabel);
            this.groupBox1.Location = new System.Drawing.Point(94, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 43);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // pidLabel
            // 
            this.pidLabel.AutoSize = true;
            this.pidLabel.ForeColor = System.Drawing.Color.Black;
            this.pidLabel.Location = new System.Drawing.Point(133, 16);
            this.pidLabel.Name = "pidLabel";
            this.pidLabel.Size = new System.Drawing.Size(14, 13);
            this.pidLabel.TabIndex = 1;
            this.pidLabel.Text = "#";
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.ForeColor = System.Drawing.Color.Black;
            this.connectionLabel.Location = new System.Drawing.Point(25, 16);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(14, 13);
            this.connectionLabel.TabIndex = 0;
            this.connectionLabel.Text = "#";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(393, 230);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.normalBlade);
            this.Controls.Add(this.ceremonialBlade);
            this.Controls.Add(this.championsBlade);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Warhawk Blade Tool RPCS3 - By Despair";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton championsBlade;
        private System.Windows.Forms.RadioButton ceremonialBlade;
        private System.Windows.Forms.RadioButton normalBlade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label pidLabel;
        private System.Windows.Forms.Label connectionLabel;
    }
}

