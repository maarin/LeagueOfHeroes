namespace LeagueOfBattle
{
    partial class Battle
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
            this.GrBoxLeftBattle = new System.Windows.Forms.GroupBox();
            this.LblLeftArrmor = new System.Windows.Forms.Label();
            this.LblLeftHealth = new System.Windows.Forms.Label();
            this.LblLeftAttack = new System.Windows.Forms.Label();
            this.GrBoxRightBattle = new System.Windows.Forms.GroupBox();
            this.LblRightArrmor = new System.Windows.Forms.Label();
            this.LblRightHealth = new System.Windows.Forms.Label();
            this.LblRightAttack = new System.Windows.Forms.Label();
            this.BtnFight = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblLeftHeroTakeDamage = new System.Windows.Forms.Label();
            this.LblLeftHeroBlockDamage = new System.Windows.Forms.Label();
            this.LblRightHeroBlockDamage = new System.Windows.Forms.Label();
            this.LblRightHeroTakeDamage = new System.Windows.Forms.Label();
            this.BtnPlayAgain = new System.Windows.Forms.Button();
            this.PicBoxRightHeroBattle = new System.Windows.Forms.PictureBox();
            this.PicBoxLeftHeroBattle = new System.Windows.Forms.PictureBox();
            this.GrBoxLeftBattle.SuspendLayout();
            this.GrBoxRightBattle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxRightHeroBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLeftHeroBattle)).BeginInit();
            this.SuspendLayout();
            // 
            // GrBoxLeftBattle
            // 
            this.GrBoxLeftBattle.Controls.Add(this.LblLeftHeroBlockDamage);
            this.GrBoxLeftBattle.Controls.Add(this.LblLeftHeroTakeDamage);
            this.GrBoxLeftBattle.Controls.Add(this.LblLeftArrmor);
            this.GrBoxLeftBattle.Controls.Add(this.LblLeftHealth);
            this.GrBoxLeftBattle.Controls.Add(this.LblLeftAttack);
            this.GrBoxLeftBattle.Controls.Add(this.PicBoxLeftHeroBattle);
            this.GrBoxLeftBattle.Location = new System.Drawing.Point(12, 43);
            this.GrBoxLeftBattle.Name = "GrBoxLeftBattle";
            this.GrBoxLeftBattle.Size = new System.Drawing.Size(245, 279);
            this.GrBoxLeftBattle.TabIndex = 17;
            this.GrBoxLeftBattle.TabStop = false;
            // 
            // LblLeftArrmor
            // 
            this.LblLeftArrmor.AutoSize = true;
            this.LblLeftArrmor.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblLeftArrmor.Location = new System.Drawing.Point(7, 227);
            this.LblLeftArrmor.Name = "LblLeftArrmor";
            this.LblLeftArrmor.Size = new System.Drawing.Size(51, 19);
            this.LblLeftArrmor.TabIndex = 3;
            this.LblLeftArrmor.Text = "Arrmor";
            // 
            // LblLeftHealth
            // 
            this.LblLeftHealth.AutoSize = true;
            this.LblLeftHealth.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblLeftHealth.Location = new System.Drawing.Point(6, 171);
            this.LblLeftHealth.Name = "LblLeftHealth";
            this.LblLeftHealth.Size = new System.Drawing.Size(62, 23);
            this.LblLeftHealth.TabIndex = 2;
            this.LblLeftHealth.Text = "Health";
            // 
            // LblLeftAttack
            // 
            this.LblLeftAttack.AutoSize = true;
            this.LblLeftAttack.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblLeftAttack.Location = new System.Drawing.Point(7, 201);
            this.LblLeftAttack.Name = "LblLeftAttack";
            this.LblLeftAttack.Size = new System.Drawing.Size(48, 19);
            this.LblLeftAttack.TabIndex = 1;
            this.LblLeftAttack.Text = "Attack";
            // 
            // GrBoxRightBattle
            // 
            this.GrBoxRightBattle.Controls.Add(this.LblRightHeroBlockDamage);
            this.GrBoxRightBattle.Controls.Add(this.LblRightHeroTakeDamage);
            this.GrBoxRightBattle.Controls.Add(this.LblRightArrmor);
            this.GrBoxRightBattle.Controls.Add(this.LblRightHealth);
            this.GrBoxRightBattle.Controls.Add(this.LblRightAttack);
            this.GrBoxRightBattle.Controls.Add(this.PicBoxRightHeroBattle);
            this.GrBoxRightBattle.Location = new System.Drawing.Point(375, 43);
            this.GrBoxRightBattle.Name = "GrBoxRightBattle";
            this.GrBoxRightBattle.Size = new System.Drawing.Size(245, 279);
            this.GrBoxRightBattle.TabIndex = 18;
            this.GrBoxRightBattle.TabStop = false;
            // 
            // LblRightArrmor
            // 
            this.LblRightArrmor.AutoSize = true;
            this.LblRightArrmor.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblRightArrmor.Location = new System.Drawing.Point(6, 227);
            this.LblRightArrmor.Name = "LblRightArrmor";
            this.LblRightArrmor.Size = new System.Drawing.Size(51, 19);
            this.LblRightArrmor.TabIndex = 3;
            this.LblRightArrmor.Text = "Arrmor";
            // 
            // LblRightHealth
            // 
            this.LblRightHealth.AutoSize = true;
            this.LblRightHealth.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblRightHealth.Location = new System.Drawing.Point(6, 171);
            this.LblRightHealth.Name = "LblRightHealth";
            this.LblRightHealth.Size = new System.Drawing.Size(62, 23);
            this.LblRightHealth.TabIndex = 2;
            this.LblRightHealth.Text = "Health";
            // 
            // LblRightAttack
            // 
            this.LblRightAttack.AutoSize = true;
            this.LblRightAttack.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblRightAttack.Location = new System.Drawing.Point(6, 201);
            this.LblRightAttack.Name = "LblRightAttack";
            this.LblRightAttack.Size = new System.Drawing.Size(48, 19);
            this.LblRightAttack.TabIndex = 1;
            this.LblRightAttack.Text = "Attack";
            // 
            // BtnFight
            // 
            this.BtnFight.Location = new System.Drawing.Point(279, 111);
            this.BtnFight.Name = "BtnFight";
            this.BtnFight.Size = new System.Drawing.Size(75, 23);
            this.BtnFight.TabIndex = 20;
            this.BtnFight.Text = "Fight";
            this.BtnFight.UseVisualStyleBackColor = true;
            this.BtnFight.Click += new System.EventHandler(this.BtnFight_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblLeftHeroTakeDamage
            // 
            this.LblLeftHeroTakeDamage.AutoSize = true;
            this.LblLeftHeroTakeDamage.BackColor = System.Drawing.Color.Transparent;
            this.LblLeftHeroTakeDamage.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblLeftHeroTakeDamage.ForeColor = System.Drawing.Color.Red;
            this.LblLeftHeroTakeDamage.Location = new System.Drawing.Point(120, 229);
            this.LblLeftHeroTakeDamage.Name = "LblLeftHeroTakeDamage";
            this.LblLeftHeroTakeDamage.Size = new System.Drawing.Size(0, 17);
            this.LblLeftHeroTakeDamage.TabIndex = 4;
            // 
            // LblLeftHeroBlockDamage
            // 
            this.LblLeftHeroBlockDamage.AutoSize = true;
            this.LblLeftHeroBlockDamage.BackColor = System.Drawing.Color.Transparent;
            this.LblLeftHeroBlockDamage.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblLeftHeroBlockDamage.ForeColor = System.Drawing.Color.Gray;
            this.LblLeftHeroBlockDamage.Location = new System.Drawing.Point(153, 203);
            this.LblLeftHeroBlockDamage.Name = "LblLeftHeroBlockDamage";
            this.LblLeftHeroBlockDamage.Size = new System.Drawing.Size(0, 17);
            this.LblLeftHeroBlockDamage.TabIndex = 5;
            // 
            // LblRightHeroBlockDamage
            // 
            this.LblRightHeroBlockDamage.AutoSize = true;
            this.LblRightHeroBlockDamage.BackColor = System.Drawing.Color.Transparent;
            this.LblRightHeroBlockDamage.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblRightHeroBlockDamage.ForeColor = System.Drawing.Color.Gray;
            this.LblRightHeroBlockDamage.Location = new System.Drawing.Point(155, 203);
            this.LblRightHeroBlockDamage.Name = "LblRightHeroBlockDamage";
            this.LblRightHeroBlockDamage.Size = new System.Drawing.Size(0, 17);
            this.LblRightHeroBlockDamage.TabIndex = 7;
            // 
            // LblRightHeroTakeDamage
            // 
            this.LblRightHeroTakeDamage.AutoSize = true;
            this.LblRightHeroTakeDamage.BackColor = System.Drawing.Color.Transparent;
            this.LblRightHeroTakeDamage.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblRightHeroTakeDamage.ForeColor = System.Drawing.Color.Red;
            this.LblRightHeroTakeDamage.Location = new System.Drawing.Point(122, 229);
            this.LblRightHeroTakeDamage.Name = "LblRightHeroTakeDamage";
            this.LblRightHeroTakeDamage.Size = new System.Drawing.Size(0, 17);
            this.LblRightHeroTakeDamage.TabIndex = 6;
            // 
            // BtnPlayAgain
            // 
            this.BtnPlayAgain.Location = new System.Drawing.Point(279, 172);
            this.BtnPlayAgain.Name = "BtnPlayAgain";
            this.BtnPlayAgain.Size = new System.Drawing.Size(75, 23);
            this.BtnPlayAgain.TabIndex = 21;
            this.BtnPlayAgain.Text = "Main menu";
            this.BtnPlayAgain.UseVisualStyleBackColor = true;
            this.BtnPlayAgain.Click += new System.EventHandler(this.BtnPlayAgain_Click);
            // 
            // PicBoxRightHeroBattle
            // 
            this.PicBoxRightHeroBattle.Location = new System.Drawing.Point(6, 19);
            this.PicBoxRightHeroBattle.Name = "PicBoxRightHeroBattle";
            this.PicBoxRightHeroBattle.Size = new System.Drawing.Size(233, 149);
            this.PicBoxRightHeroBattle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxRightHeroBattle.TabIndex = 0;
            this.PicBoxRightHeroBattle.TabStop = false;
            // 
            // PicBoxLeftHeroBattle
            // 
            this.PicBoxLeftHeroBattle.Location = new System.Drawing.Point(6, 19);
            this.PicBoxLeftHeroBattle.Name = "PicBoxLeftHeroBattle";
            this.PicBoxLeftHeroBattle.Size = new System.Drawing.Size(233, 149);
            this.PicBoxLeftHeroBattle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxLeftHeroBattle.TabIndex = 0;
            this.PicBoxLeftHeroBattle.TabStop = false;
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(632, 348);
            this.Controls.Add(this.BtnPlayAgain);
            this.Controls.Add(this.BtnFight);
            this.Controls.Add(this.GrBoxRightBattle);
            this.Controls.Add(this.GrBoxLeftBattle);
            this.Name = "Battle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle";
            this.Load += new System.EventHandler(this.Battle_Load);
            this.GrBoxLeftBattle.ResumeLayout(false);
            this.GrBoxLeftBattle.PerformLayout();
            this.GrBoxRightBattle.ResumeLayout(false);
            this.GrBoxRightBattle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxRightHeroBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLeftHeroBattle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox GrBoxLeftBattle;
        private System.Windows.Forms.Label LblLeftArrmor;
        private System.Windows.Forms.Label LblLeftHealth;
        private System.Windows.Forms.Label LblLeftAttack;
        private System.Windows.Forms.PictureBox PicBoxLeftHeroBattle;
        public System.Windows.Forms.GroupBox GrBoxRightBattle;
        private System.Windows.Forms.Label LblRightArrmor;
        private System.Windows.Forms.Label LblRightHealth;
        private System.Windows.Forms.Label LblRightAttack;
        private System.Windows.Forms.PictureBox PicBoxRightHeroBattle;
        private System.Windows.Forms.Button BtnFight;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblLeftHeroBlockDamage;
        private System.Windows.Forms.Label LblLeftHeroTakeDamage;
        private System.Windows.Forms.Label LblRightHeroBlockDamage;
        private System.Windows.Forms.Label LblRightHeroTakeDamage;
        private System.Windows.Forms.Button BtnPlayAgain;
    }
}