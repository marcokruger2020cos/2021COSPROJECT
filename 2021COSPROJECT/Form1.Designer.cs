﻿
namespace _2021COSPROJECT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrCharacter = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrShoot = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tmrStop = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.Reactor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.explosive1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.TXTname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTScore = new System.Windows.Forms.TextBox();
            this.lbliscore = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosive1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrCharacter
            // 
            this.tmrCharacter.Enabled = true;
            this.tmrCharacter.Interval = 1;
            this.tmrCharacter.Tick += new System.EventHandler(this.tmrCharacter_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.playToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.newToolStripMenuItem,
            this.highScoresToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // highScoresToolStripMenuItem
            // 
            this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
            this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.highScoresToolStripMenuItem.Text = "High Scores";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // tmrShoot
            // 
            this.tmrShoot.Enabled = true;
            this.tmrShoot.Interval = 1;
            this.tmrShoot.Tick += new System.EventHandler(this.tmrShoot_Tick);
            // 
            // tmrStop
            // 
            this.tmrStop.Enabled = true;
            this.tmrStop.Interval = 1;
            this.tmrStop.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblScore.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(299, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(65, 23);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score: 0";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHealth.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.Location = new System.Drawing.Point(360, 0);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(107, 23);
            this.lblHealth.TabIndex = 4;
            this.lblHealth.Text = "Health:10000";
            this.lblHealth.Click += new System.EventHandler(this.lbHealth_Click);
            // 
            // Reactor
            // 
            this.Reactor.BackColor = System.Drawing.Color.Red;
            this.Reactor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Reactor.BackgroundImage")));
            this.Reactor.Location = new System.Drawing.Point(164, 539);
            this.Reactor.Name = "Reactor";
            this.Reactor.Size = new System.Drawing.Size(40, 22);
            this.Reactor.TabIndex = 5;
            this.Reactor.TabStop = false;
            this.Reactor.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(449, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 26);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // explosive1
            // 
            this.explosive1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.explosive1.Location = new System.Drawing.Point(0, 26);
            this.explosive1.Name = "explosive1";
            this.explosive1.Size = new System.Drawing.Size(17, 26);
            this.explosive1.TabIndex = 1;
            this.explosive1.TabStop = false;
            this.explosive1.Click += new System.EventHandler(this.explosive1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Protect the reactor! That\'s a order private!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Please enter name";
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.Color.Transparent;
            this.btncheck.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncheck.Location = new System.Drawing.Point(270, 52);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(75, 23);
            this.btncheck.TabIndex = 9;
            this.btncheck.Text = "Enter";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblOutput.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(228, 4);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 19);
            this.lblOutput.TabIndex = 10;
            // 
            // TXTname
            // 
            this.TXTname.Location = new System.Drawing.Point(164, 55);
            this.TXTname.Name = "TXTname";
            this.TXTname.Size = new System.Drawing.Size(100, 20);
            this.TXTname.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(11, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hint:Game only starts when first bullet is fired.";
            // 
            // TXTScore
            // 
            this.TXTScore.Location = new System.Drawing.Point(164, 82);
            this.TXTScore.Name = "TXTScore";
            this.TXTScore.Size = new System.Drawing.Size(100, 20);
            this.TXTScore.TabIndex = 13;
            // 
            // lbliscore
            // 
            this.lbliscore.AutoSize = true;
            this.lbliscore.BackColor = System.Drawing.Color.Transparent;
            this.lbliscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliscore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbliscore.Location = new System.Drawing.Point(20, 82);
            this.lbliscore.Name = "lbliscore";
            this.lbliscore.Size = new System.Drawing.Size(91, 20);
            this.lbliscore.TabIndex = 14;
            this.lbliscore.Text = "Enter score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(466, 564);
            this.Controls.Add(this.lbliscore);
            this.Controls.Add(this.TXTScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTname);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reactor);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.explosive1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosive1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrCharacter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.Timer tmrShoot;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer tmrStop;
        private System.Windows.Forms.PictureBox explosive1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.PictureBox Reactor;
        private System.Windows.Forms.Label label1;
       // private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox TXTname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem highScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox TXTScore;
        private System.Windows.Forms.Label lbliscore;
    }
}

