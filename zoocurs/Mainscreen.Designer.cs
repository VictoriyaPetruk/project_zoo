namespace zoocurs
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.addtobasket = new System.Windows.Forms.Button();
            this.lbcreate = new System.Windows.Forms.Label();
            this.btnbasket = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menumain = new System.Windows.Forms.ToolStripMenuItem();
            this.животныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.накладнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.накладнаяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияПроПоставщиковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.персоналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПриложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbsex = new System.Windows.Forms.ComboBox();
            this.cbvid = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbanimals = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addtobasket
            // 
            this.addtobasket.BackColor = System.Drawing.Color.Gold;
            this.addtobasket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addtobasket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.addtobasket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.addtobasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addtobasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addtobasket.ForeColor = System.Drawing.Color.White;
            this.addtobasket.Location = new System.Drawing.Point(466, 230);
            this.addtobasket.Name = "addtobasket";
            this.addtobasket.Size = new System.Drawing.Size(101, 45);
            this.addtobasket.TabIndex = 2;
            this.addtobasket.Text = "добавить в корзину";
            this.addtobasket.UseVisualStyleBackColor = false;
            this.addtobasket.Click += new System.EventHandler(this.addtobasket_Click);
            // 
            // lbcreate
            // 
            this.lbcreate.AutoSize = true;
            this.lbcreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbcreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbcreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbcreate.Location = new System.Drawing.Point(258, 28);
            this.lbcreate.Name = "lbcreate";
            this.lbcreate.Size = new System.Drawing.Size(158, 25);
            this.lbcreate.TabIndex = 4;
            this.lbcreate.Text = "Создать заказ";
            // 
            // btnbasket
            // 
            this.btnbasket.BackColor = System.Drawing.Color.Gold;
            this.btnbasket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbasket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbasket.Enabled = false;
            this.btnbasket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnbasket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnbasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnbasket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbasket.Location = new System.Drawing.Point(277, 366);
            this.btnbasket.Name = "btnbasket";
            this.btnbasket.Size = new System.Drawing.Size(142, 55);
            this.btnbasket.TabIndex = 6;
            this.btnbasket.Text = "Перейти в корзину";
            this.btnbasket.UseVisualStyleBackColor = false;
            this.btnbasket.Click += new System.EventHandler(this.btnbasket_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.BackgroundImage = global::zoocurs.Properties.Resources.заяцъ;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(10, 10);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menumain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(644, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menumain
            // 
            this.menumain.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menumain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.животныеToolStripMenuItem,
            this.продажиToolStripMenuItem,
            this.накладнаяToolStripMenuItem,
            this.персоналToolStripMenuItem,
            this.проПриложениеToolStripMenuItem});
            this.menumain.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menumain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menumain.ImageTransparentColor = System.Drawing.Color.White;
            this.menumain.Name = "menumain";
            this.menumain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menumain.RightToLeftAutoMirrorImage = true;
            this.menumain.Size = new System.Drawing.Size(70, 24);
            this.menumain.Text = "Меню";
            this.menumain.Click += new System.EventHandler(this.menumain_Click);
            // 
            // животныеToolStripMenuItem
            // 
            this.животныеToolStripMenuItem.Name = "животныеToolStripMenuItem";
            this.животныеToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.животныеToolStripMenuItem.Text = "Животные";
            this.животныеToolStripMenuItem.Click += new System.EventHandler(this.животныеToolStripMenuItem_Click);
            // 
            // продажиToolStripMenuItem
            // 
            this.продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
            this.продажиToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.продажиToolStripMenuItem.Text = "Продажи";
            this.продажиToolStripMenuItem.Click += new System.EventHandler(this.продажиToolStripMenuItem_Click);
            // 
            // накладнаяToolStripMenuItem
            // 
            this.накладнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.накладнаяToolStripMenuItem1,
            this.информацияПроПоставщиковToolStripMenuItem});
            this.накладнаяToolStripMenuItem.Name = "накладнаяToolStripMenuItem";
            this.накладнаяToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.накладнаяToolStripMenuItem.Text = "Поставки";
            // 
            // накладнаяToolStripMenuItem1
            // 
            this.накладнаяToolStripMenuItem1.Name = "накладнаяToolStripMenuItem1";
            this.накладнаяToolStripMenuItem1.Size = new System.Drawing.Size(329, 26);
            this.накладнаяToolStripMenuItem1.Text = "Накладная";
            this.накладнаяToolStripMenuItem1.Click += new System.EventHandler(this.накладнаяToolStripMenuItem1_Click);
            // 
            // информацияПроПоставщиковToolStripMenuItem
            // 
            this.информацияПроПоставщиковToolStripMenuItem.Name = "информацияПроПоставщиковToolStripMenuItem";
            this.информацияПроПоставщиковToolStripMenuItem.Size = new System.Drawing.Size(329, 26);
            this.информацияПроПоставщиковToolStripMenuItem.Text = "Информация про поставщиков";
            this.информацияПроПоставщиковToolStripMenuItem.Click += new System.EventHandler(this.информацияПроПоставщиковToolStripMenuItem_Click);
            // 
            // персоналToolStripMenuItem
            // 
            this.персоналToolStripMenuItem.Name = "персоналToolStripMenuItem";
            this.персоналToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.персоналToolStripMenuItem.Text = "Персонал";
            this.персоналToolStripMenuItem.Click += new System.EventHandler(this.персоналToolStripMenuItem_Click);
            // 
            // проПриложениеToolStripMenuItem
            // 
            this.проПриложениеToolStripMenuItem.Name = "проПриложениеToolStripMenuItem";
            this.проПриложениеToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.проПриложениеToolStripMenuItem.Text = "Про приложение";
            this.проПриложениеToolStripMenuItem.Click += new System.EventHandler(this.проПриложениеToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::zoocurs.Properties.Resources.заяцъ;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.addtobasket);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbsex);
            this.groupBox1.Controls.Add(this.cbvid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbanimals);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 297);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(521, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 36);
            this.button1.TabIndex = 23;
            this.button1.Text = "Отменить заказ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(412, 183);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(77, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Сотрудник";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox5.Location = new System.Drawing.Point(303, 143);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(43, 21);
            this.comboBox5.TabIndex = 20;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(77, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Количество";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(334, 259);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(270, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Цена";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(268, 183);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 16;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(77, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пол";
            // 
            // cbsex
            // 
            this.cbsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsex.FormattingEnabled = true;
            this.cbsex.Items.AddRange(new object[] {
            "м",
            "ж"});
            this.cbsex.Location = new System.Drawing.Point(303, 109);
            this.cbsex.Name = "cbsex";
            this.cbsex.Size = new System.Drawing.Size(43, 21);
            this.cbsex.TabIndex = 2;
            // 
            // cbvid
            // 
            this.cbvid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbvid.FormattingEnabled = true;
            this.cbvid.Location = new System.Drawing.Point(294, 65);
            this.cbvid.Name = "cbvid";
            this.cbvid.Size = new System.Drawing.Size(159, 21);
            this.cbvid.TabIndex = 1;
            this.cbvid.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(77, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Вид";
            // 
            // cbanimals
            // 
            this.cbanimals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbanimals.Location = new System.Drawing.Point(294, 25);
            this.cbanimals.Name = "cbanimals";
            this.cbanimals.Size = new System.Drawing.Size(159, 21);
            this.cbanimals.TabIndex = 0;
            this.cbanimals.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(79, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выберите животное";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 401);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.Value = new System.DateTime(2020, 5, 5, 0, 0, 0, 0);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::zoocurs.Properties.Resources.заяцъ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 433);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnbasket);
            this.Controls.Add(this.lbcreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainform";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainscreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainform_FormClosed);
            this.Load += new System.EventHandler(this.mainform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addtobasket;
        private System.Windows.Forms.Label lbcreate;
        private System.Windows.Forms.Button btnbasket;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menumain;
        private System.Windows.Forms.ToolStripMenuItem животныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem накладнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem персоналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПриложениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem накладнаяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem информацияПроПоставщиковToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbsex;
        private System.Windows.Forms.ComboBox cbvid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbanimals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}