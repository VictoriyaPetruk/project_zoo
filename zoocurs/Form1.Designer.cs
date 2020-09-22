namespace zoocurs
{
    partial class Autorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            this.lblog = new System.Windows.Forms.Label();
            this.lbpas = new System.Windows.Forms.Label();
            this.pbuser = new System.Windows.Forms.PictureBox();
            this.pBlock = new System.Windows.Forms.PictureBox();
            this.tblog = new System.Windows.Forms.TextBox();
            this.tbpas = new System.Windows.Forms.TextBox();
            this.btsign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblog
            // 
            this.lblog.AutoSize = true;
            this.lblog.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblog.ForeColor = System.Drawing.Color.White;
            this.lblog.Location = new System.Drawing.Point(395, 87);
            this.lblog.Name = "lblog";
            this.lblog.Size = new System.Drawing.Size(64, 38);
            this.lblog.TabIndex = 0;
            this.lblog.Text = "Login";
            // 
            // lbpas
            // 
            this.lbpas.AutoSize = true;
            this.lbpas.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpas.ForeColor = System.Drawing.Color.White;
            this.lbpas.Location = new System.Drawing.Point(379, 193);
            this.lbpas.Name = "lbpas";
            this.lbpas.Size = new System.Drawing.Size(92, 38);
            this.lbpas.TabIndex = 1;
            this.lbpas.Text = "Password";
            // 
            // pbuser
            // 
            this.pbuser.Image = ((System.Drawing.Image)(resources.GetObject("pbuser.Image")));
            this.pbuser.Location = new System.Drawing.Point(272, 119);
            this.pbuser.Name = "pbuser";
            this.pbuser.Size = new System.Drawing.Size(44, 42);
            this.pbuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbuser.TabIndex = 3;
            this.pbuser.TabStop = false;
            // 
            // pBlock
            // 
            this.pBlock.Image = ((System.Drawing.Image)(resources.GetObject("pBlock.Image")));
            this.pBlock.Location = new System.Drawing.Point(272, 223);
            this.pBlock.Name = "pBlock";
            this.pBlock.Size = new System.Drawing.Size(44, 43);
            this.pBlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBlock.TabIndex = 4;
            this.pBlock.TabStop = false;
            // 
            // tblog
            // 
            this.tblog.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblog.Location = new System.Drawing.Point(340, 128);
            this.tblog.Multiline = true;
            this.tblog.Name = "tblog";
            this.tblog.Size = new System.Drawing.Size(178, 33);
            this.tblog.TabIndex = 5;
            // 
            // tbpas
            // 
            this.tbpas.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpas.Location = new System.Drawing.Point(340, 234);
            this.tbpas.Name = "tbpas";
            this.tbpas.Size = new System.Drawing.Size(178, 32);
            this.tbpas.TabIndex = 6;
            this.tbpas.UseSystemPasswordChar = true;
            // 
            // btsign
            // 
            this.btsign.BackColor = System.Drawing.Color.Gold;
            this.btsign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsign.FlatAppearance.BorderSize = 0;
            this.btsign.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btsign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btsign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsign.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsign.ForeColor = System.Drawing.Color.White;
            this.btsign.Location = new System.Drawing.Point(369, 291);
            this.btsign.Name = "btsign";
            this.btsign.Size = new System.Drawing.Size(120, 43);
            this.btsign.TabIndex = 7;
            this.btsign.Text = "log in";
            this.btsign.UseVisualStyleBackColor = false;
            this.btsign.Click += new System.EventHandler(this.btsign_Click);
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::zoocurs.Properties.Resources.заяцъ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 387);
            this.Controls.Add(this.btsign);
            this.Controls.Add(this.tbpas);
            this.Controls.Add(this.tblog);
            this.Controls.Add(this.pBlock);
            this.Controls.Add(this.pbuser);
            this.Controls.Add(this.lbpas);
            this.Controls.Add(this.lblog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Autorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorization";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Autorization_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblog;
        private System.Windows.Forms.Label lbpas;
        private System.Windows.Forms.PictureBox pbuser;
        private System.Windows.Forms.PictureBox pBlock;
        private System.Windows.Forms.TextBox tblog;
        private System.Windows.Forms.TextBox tbpas;
        private System.Windows.Forms.Button btsign;
    }
}

