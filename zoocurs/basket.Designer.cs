namespace zoocurs
{
    partial class basketfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(basketfrm));
            this.lbhead = new System.Windows.Forms.Label();
            this.dvgOrder = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnback = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lbhead
            // 
            this.lbhead.AutoSize = true;
            this.lbhead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbhead.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbhead.Location = new System.Drawing.Point(251, 12);
            this.lbhead.Name = "lbhead";
            this.lbhead.Size = new System.Drawing.Size(144, 29);
            this.lbhead.TabIndex = 0;
            this.lbhead.Text = "Ваш заказ :";
            // 
            // dvgOrder
            // 
            this.dvgOrder.AllowUserToAddRows = false;
            this.dvgOrder.AllowUserToDeleteRows = false;
            this.dvgOrder.AllowUserToOrderColumns = true;
            this.dvgOrder.AllowUserToResizeColumns = false;
            this.dvgOrder.AllowUserToResizeRows = false;
            this.dvgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column1,
            this.Column6,
            this.Column3});
            this.dvgOrder.Location = new System.Drawing.Point(75, 68);
            this.dvgOrder.Name = "dvgOrder";
            this.dvgOrder.ReadOnly = true;
            this.dvgOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvgOrder.Size = new System.Drawing.Size(475, 194);
            this.dvgOrder.TabIndex = 12;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Животное";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Вид";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Пол";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Колличество";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Цена";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Id";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = global::zoocurs.Properties.Resources.iconfinder_f_left_256_282467;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Location = new System.Drawing.Point(12, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(55, 50);
            this.btnback.TabIndex = 13;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnclean
            // 
            this.btnclean.BackgroundImage = global::zoocurs.Properties.Resources._326606_64;
            this.btnclean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclean.FlatAppearance.BorderSize = 0;
            this.btnclean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnclean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnclean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclean.Location = new System.Drawing.Point(564, 28);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(28, 34);
            this.btnclean.TabIndex = 14;
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // btnorder
            // 
            this.btnorder.BackColor = System.Drawing.Color.Gold;
            this.btnorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnorder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btnorder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnorder.ForeColor = System.Drawing.Color.White;
            this.btnorder.Location = new System.Drawing.Point(450, 328);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(142, 48);
            this.btnorder.TabIndex = 27;
            this.btnorder.Text = "оформить заказ";
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.addtobasket_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(450, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(320, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Сумма заказа";
            // 
            // basketfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::zoocurs.Properties.Resources.thumb_l_shtory_27969;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dvgOrder);
            this.Controls.Add(this.lbhead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "basketfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "basket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.basketfrm_FormClosed);
            this.Load += new System.EventHandler(this.basketfrm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbhead;
        private System.Windows.Forms.DataGridView dvgOrder;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}