namespace DownStairs
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.playerImageList = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.brick1 = new System.Windows.Forms.PictureBox();
            this.brick2 = new System.Windows.Forms.PictureBox();
            this.brick6 = new System.Windows.Forms.PictureBox();
            this.brick4 = new System.Windows.Forms.PictureBox();
            this.brick3 = new System.Windows.Forms.PictureBox();
            this.brick5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick5)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(456, 49);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(44, 48);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // playerImageList
            // 
            this.playerImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("playerImageList.ImageStream")));
            this.playerImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.playerImageList.Images.SetKeyName(0, "alienBlue_front.png");
            this.playerImageList.Images.SetKeyName(1, "alienBlue_jump.png");
            this.playerImageList.Images.SetKeyName(2, "alienBlue_duck.png");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // brick1
            // 
            this.brick1.BackColor = System.Drawing.Color.Lime;
            this.brick1.Location = new System.Drawing.Point(428, 221);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(100, 20);
            this.brick1.TabIndex = 1;
            this.brick1.TabStop = false;
            // 
            // brick2
            // 
            this.brick2.BackColor = System.Drawing.Color.Lime;
            this.brick2.Location = new System.Drawing.Point(688, 310);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(100, 20);
            this.brick2.TabIndex = 2;
            this.brick2.TabStop = false;
            // 
            // brick6
            // 
            this.brick6.BackColor = System.Drawing.Color.Lime;
            this.brick6.Location = new System.Drawing.Point(237, 623);
            this.brick6.Name = "brick6";
            this.brick6.Size = new System.Drawing.Size(100, 20);
            this.brick6.TabIndex = 3;
            this.brick6.TabStop = false;
            // 
            // brick4
            // 
            this.brick4.BackColor = System.Drawing.Color.Lime;
            this.brick4.Location = new System.Drawing.Point(561, 397);
            this.brick4.Name = "brick4";
            this.brick4.Size = new System.Drawing.Size(100, 20);
            this.brick4.TabIndex = 4;
            this.brick4.TabStop = false;
            // 
            // brick3
            // 
            this.brick3.BackColor = System.Drawing.Color.Lime;
            this.brick3.Location = new System.Drawing.Point(38, 348);
            this.brick3.Name = "brick3";
            this.brick3.Size = new System.Drawing.Size(100, 20);
            this.brick3.TabIndex = 5;
            this.brick3.TabStop = false;
            // 
            // brick5
            // 
            this.brick5.BackColor = System.Drawing.Color.Lime;
            this.brick5.Location = new System.Drawing.Point(901, 495);
            this.brick5.Name = "brick5";
            this.brick5.Size = new System.Drawing.Size(100, 20);
            this.brick5.TabIndex = 6;
            this.brick5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(396, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "GAME OVER";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(839, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Health :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1002, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brick5);
            this.Controls.Add(this.brick3);
            this.Controls.Add(this.brick4);
            this.Controls.Add(this.brick6);
            this.Controls.Add(this.brick2);
            this.Controls.Add(this.brick1);
            this.Controls.Add(this.player);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Down Stairs";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.ImageList playerImageList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox brick1;
        private System.Windows.Forms.PictureBox brick2;
        private System.Windows.Forms.PictureBox brick6;
        private System.Windows.Forms.PictureBox brick4;
        private System.Windows.Forms.PictureBox brick3;
        private System.Windows.Forms.PictureBox brick5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

