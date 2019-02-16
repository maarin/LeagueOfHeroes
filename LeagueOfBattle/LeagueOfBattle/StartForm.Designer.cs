namespace LeagueOfBattle
{
    partial class StartForm
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
            this.LblLogo = new System.Windows.Forms.Label();
            this.BtnPLay = new System.Windows.Forms.Button();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblLogo
            // 
            this.LblLogo.AutoSize = true;
            this.LblLogo.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogo.Location = new System.Drawing.Point(36, 39);
            this.LblLogo.Name = "LblLogo";
            this.LblLogo.Size = new System.Drawing.Size(206, 36);
            this.LblLogo.TabIndex = 0;
            this.LblLogo.Text = "League of Battle";
            // 
            // BtnPLay
            // 
            this.BtnPLay.Location = new System.Drawing.Point(98, 116);
            this.BtnPLay.Name = "BtnPLay";
            this.BtnPLay.Size = new System.Drawing.Size(75, 23);
            this.BtnPLay.TabIndex = 1;
            this.BtnPLay.Text = "Play";
            this.BtnPLay.UseVisualStyleBackColor = true;
            this.BtnPLay.Click += new System.EventHandler(this.BtnPLay_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.Location = new System.Drawing.Point(98, 170);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(75, 23);
            this.BtnInfo.TabIndex = 2;
            this.BtnInfo.Text = "Game info";
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BtnInfo);
            this.Controls.Add(this.BtnPLay);
            this.Controls.Add(this.LblLogo);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "League Of Battle";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLogo;
        private System.Windows.Forms.Button BtnPLay;
        private System.Windows.Forms.Button BtnInfo;
    }
}

