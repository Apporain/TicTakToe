namespace TicTackToeGui
{
    partial class TickTackToeForm
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
            this.btnGame00 = new System.Windows.Forms.Button();
            this.btnGame01 = new System.Windows.Forms.Button();
            this.btnGame02 = new System.Windows.Forms.Button();
            this.btnGame10 = new System.Windows.Forms.Button();
            this.btnGame11 = new System.Windows.Forms.Button();
            this.btnGame12 = new System.Windows.Forms.Button();
            this.btnGame22 = new System.Windows.Forms.Button();
            this.btnGame21 = new System.Windows.Forms.Button();
            this.btnGame20 = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTicTacToe = new System.Windows.Forms.Label();
            this.lblAnnoucement = new System.Windows.Forms.Label();
            this.lblAnnouncement = new System.Windows.Forms.Label();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGame00
            // 
            this.btnGame00.Location = new System.Drawing.Point(134, 114);
            this.btnGame00.Name = "btnGame00";
            this.btnGame00.Size = new System.Drawing.Size(90, 90);
            this.btnGame00.TabIndex = 0;
            this.btnGame00.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGame00.UseVisualStyleBackColor = true;
            this.btnGame00.Click += new System.EventHandler(this.btnGame1_Click);
            // 
            // btnGame01
            // 
            this.btnGame01.Location = new System.Drawing.Point(230, 114);
            this.btnGame01.Name = "btnGame01";
            this.btnGame01.Size = new System.Drawing.Size(90, 90);
            this.btnGame01.TabIndex = 1;
            this.btnGame01.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGame01.UseVisualStyleBackColor = true;
            this.btnGame01.Click += new System.EventHandler(this.btnGame2_Click);
            // 
            // btnGame02
            // 
            this.btnGame02.Location = new System.Drawing.Point(326, 114);
            this.btnGame02.Name = "btnGame02";
            this.btnGame02.Size = new System.Drawing.Size(90, 90);
            this.btnGame02.TabIndex = 2;
            this.btnGame02.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGame02.UseVisualStyleBackColor = true;
            this.btnGame02.Click += new System.EventHandler(this.btnGame3_Click);
            // 
            // btnGame10
            // 
            this.btnGame10.Location = new System.Drawing.Point(134, 210);
            this.btnGame10.Name = "btnGame10";
            this.btnGame10.Size = new System.Drawing.Size(90, 90);
            this.btnGame10.TabIndex = 3;
            this.btnGame10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGame10.UseVisualStyleBackColor = true;
            this.btnGame10.Click += new System.EventHandler(this.btnGame4_Click);
            // 
            // btnGame11
            // 
            this.btnGame11.Location = new System.Drawing.Point(230, 210);
            this.btnGame11.Name = "btnGame11";
            this.btnGame11.Size = new System.Drawing.Size(90, 90);
            this.btnGame11.TabIndex = 4;
            this.btnGame11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGame11.UseVisualStyleBackColor = true;
            this.btnGame11.Click += new System.EventHandler(this.btnGame5_Click);
            // 
            // btnGame12
            // 
            this.btnGame12.Location = new System.Drawing.Point(326, 210);
            this.btnGame12.Name = "btnGame12";
            this.btnGame12.Size = new System.Drawing.Size(90, 90);
            this.btnGame12.TabIndex = 5;
            this.btnGame12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGame12.UseVisualStyleBackColor = true;
            this.btnGame12.Click += new System.EventHandler(this.btnGame6_Click);
            // 
            // btnGame22
            // 
            this.btnGame22.Location = new System.Drawing.Point(326, 306);
            this.btnGame22.Name = "btnGame22";
            this.btnGame22.Size = new System.Drawing.Size(90, 90);
            this.btnGame22.TabIndex = 8;
            this.btnGame22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGame22.UseVisualStyleBackColor = true;
            this.btnGame22.Click += new System.EventHandler(this.btnGame9_Click);
            // 
            // btnGame21
            // 
            this.btnGame21.Location = new System.Drawing.Point(230, 306);
            this.btnGame21.Name = "btnGame21";
            this.btnGame21.Size = new System.Drawing.Size(90, 90);
            this.btnGame21.TabIndex = 7;
            this.btnGame21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGame21.UseVisualStyleBackColor = true;
            this.btnGame21.Click += new System.EventHandler(this.btnGame8_Click);
            // 
            // btnGame20
            // 
            this.btnGame20.Location = new System.Drawing.Point(134, 306);
            this.btnGame20.Name = "btnGame20";
            this.btnGame20.Size = new System.Drawing.Size(90, 90);
            this.btnGame20.TabIndex = 6;
            this.btnGame20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGame20.UseVisualStyleBackColor = true;
            this.btnGame20.Click += new System.EventHandler(this.btnGame7_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(130, 428);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(94, 29);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(326, 428);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTicTacToe
            // 
            this.lblTicTacToe.AutoSize = true;
            this.lblTicTacToe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTicTacToe.Location = new System.Drawing.Point(220, 9);
            this.lblTicTacToe.Name = "lblTicTacToe";
            this.lblTicTacToe.Size = new System.Drawing.Size(134, 35);
            this.lblTicTacToe.TabIndex = 11;
            this.lblTicTacToe.Text = "Tic Tac Toe";
            // 
            // lblAnnoucement
            // 
            this.lblAnnoucement.AutoSize = true;
            this.lblAnnoucement.Location = new System.Drawing.Point(222, 64);
            this.lblAnnoucement.Name = "lblAnnoucement";
            this.lblAnnoucement.Size = new System.Drawing.Size(0, 20);
            this.lblAnnoucement.TabIndex = 12;
            // 
            // lblAnnouncement
            // 
            this.lblAnnouncement.AutoSize = true;
            this.lblAnnouncement.Location = new System.Drawing.Point(212, 64);
            this.lblAnnouncement.Name = "lblAnnouncement";
            this.lblAnnouncement.Size = new System.Drawing.Size(108, 20);
            this.lblAnnouncement.TabIndex = 13;
            this.lblAnnouncement.Text = "Current Player: ";
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(326, 64);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(18, 20);
            this.lblCurrentPlayer.TabIndex = 14;
            this.lblCurrentPlayer.Text = "X";
            // 
            // TickTackToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 483);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.lblAnnouncement);
            this.Controls.Add(this.lblAnnoucement);
            this.Controls.Add(this.lblTicTacToe);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnGame22);
            this.Controls.Add(this.btnGame21);
            this.Controls.Add(this.btnGame20);
            this.Controls.Add(this.btnGame12);
            this.Controls.Add(this.btnGame11);
            this.Controls.Add(this.btnGame10);
            this.Controls.Add(this.btnGame02);
            this.Controls.Add(this.btnGame01);
            this.Controls.Add(this.btnGame00);
            this.Name = "TickTackToeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGame00;
        private Button btnGame01;
        private Button btnGame02;
        private Button btnGame10;
        private Button btnGame11;
        private Button btnGame12;
        private Button btnGame22;
        private Button btnGame21;
        private Button btnGame20;
        private Button btnRestart;
        private Button btnClose;
        private Label lblTicTacToe;
        private Label lblAnnoucement;
        private Label lblAnnouncement;
        private Label lblCurrentPlayer;
    }
}