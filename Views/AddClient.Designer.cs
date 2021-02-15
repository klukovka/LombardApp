namespace LombardApp.Views
{
    partial class AddClient
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
            this.buttonAddGood = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.comboBoxGood = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerBD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NavPanel = new System.Windows.Forms.Panel();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonGoods = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.NavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddGood
            // 
            this.buttonAddGood.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonAddGood.Font = new System.Drawing.Font("Anime Ace v05", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGood.ForeColor = System.Drawing.Color.Lavender;
            this.buttonAddGood.Location = new System.Drawing.Point(8, 253);
            this.buttonAddGood.Name = "buttonAddGood";
            this.buttonAddGood.Size = new System.Drawing.Size(194, 58);
            this.buttonAddGood.TabIndex = 3;
            this.buttonAddGood.Text = "Додати";
            this.buttonAddGood.UseVisualStyleBackColor = false;
            this.buttonAddGood.Click += new System.EventHandler(this.buttonAddGood_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Lavender;
            this.MainPanel.Controls.Add(this.buttonContinue);
            this.MainPanel.Controls.Add(this.comboBoxGood);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.textBoxPassport);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.textBoxMail);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.textBoxPhone);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.radioButtonWoman);
            this.MainPanel.Controls.Add(this.radioButtonMan);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.dateTimePickerBD);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.textBoxName);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(210, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(711, 548);
            this.MainPanel.TabIndex = 7;
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonContinue.Font = new System.Drawing.Font("Anime Ace v05", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.ForeColor = System.Drawing.Color.Lavender;
            this.buttonContinue.Location = new System.Drawing.Point(42, 487);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(585, 58);
            this.buttonContinue.TabIndex = 4;
            this.buttonContinue.Text = "Далі";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // comboBoxGood
            // 
            this.comboBoxGood.FormattingEnabled = true;
            this.comboBoxGood.Items.AddRange(new object[] {
            "Приміщення",
            "Одяг",
            "Побутова техніка",
            "Ювелірні вироби",
            "Мобільні пристрої"});
            this.comboBoxGood.Location = new System.Drawing.Point(336, 437);
            this.comboBoxGood.Name = "comboBoxGood";
            this.comboBoxGood.Size = new System.Drawing.Size(291, 28);
            this.comboBoxGood.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(34, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 45);
            this.label7.TabIndex = 14;
            this.label7.Text = "Тип товару";
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassport.Location = new System.Drawing.Point(336, 377);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(291, 26);
            this.textBoxPassport.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(34, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 45);
            this.label6.TabIndex = 12;
            this.label6.Text = "Паспорт";
            // 
            // textBoxMail
            // 
            this.textBoxMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMail.Location = new System.Drawing.Point(336, 314);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(291, 26);
            this.textBoxMail.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(34, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 45);
            this.label5.TabIndex = 10;
            this.label5.Text = "Пошта";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhone.Location = new System.Drawing.Point(336, 253);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(291, 26);
            this.textBoxPhone.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(34, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 45);
            this.label4.TabIndex = 8;
            this.label4.Text = "Телефон";
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Location = new System.Drawing.Point(469, 190);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(76, 24);
            this.radioButtonWoman.TabIndex = 7;
            this.radioButtonWoman.Text = "Жінка";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Checked = true;
            this.radioButtonMan.Location = new System.Drawing.Point(336, 190);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(94, 24);
            this.radioButtonMan.TabIndex = 6;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "Чоловік";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(34, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Стать";
            // 
            // dateTimePickerBD
            // 
            this.dateTimePickerBD.Location = new System.Drawing.Point(336, 109);
            this.dateTimePickerBD.Name = "dateTimePickerBD";
            this.dateTimePickerBD.Size = new System.Drawing.Size(291, 26);
            this.dateTimePickerBD.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(34, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата народження";
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Location = new System.Drawing.Point(336, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(291, 26);
            this.textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "ПІБ клієнта";
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.Navy;
            this.NavPanel.Controls.Add(this.buttonAddGood);
            this.NavPanel.Controls.Add(this.buttonClients);
            this.NavPanel.Controls.Add(this.buttonGoods);
            this.NavPanel.Controls.Add(this.buttonInfo);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavPanel.Location = new System.Drawing.Point(0, 0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(210, 548);
            this.NavPanel.TabIndex = 6;
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonClients.Font = new System.Drawing.Font("Anime Ace v05", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClients.ForeColor = System.Drawing.Color.Lavender;
            this.buttonClients.Location = new System.Drawing.Point(8, 179);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(194, 58);
            this.buttonClients.TabIndex = 2;
            this.buttonClients.Text = "Клієнти";
            this.buttonClients.UseVisualStyleBackColor = false;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonGoods
            // 
            this.buttonGoods.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonGoods.Font = new System.Drawing.Font("Anime Ace v05", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoods.ForeColor = System.Drawing.Color.Lavender;
            this.buttonGoods.Location = new System.Drawing.Point(8, 102);
            this.buttonGoods.Name = "buttonGoods";
            this.buttonGoods.Size = new System.Drawing.Size(194, 58);
            this.buttonGoods.TabIndex = 1;
            this.buttonGoods.Text = "Товари";
            this.buttonGoods.UseVisualStyleBackColor = false;
            this.buttonGoods.Click += new System.EventHandler(this.buttonGoods_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonInfo.Font = new System.Drawing.Font("Anime Ace v05", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.ForeColor = System.Drawing.Color.Lavender;
            this.buttonInfo.Location = new System.Drawing.Point(8, 26);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(194, 58);
            this.buttonInfo.TabIndex = 0;
            this.buttonInfo.Text = "Інформація";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 548);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.NavPanel);
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.NavPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddGood;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonGoods;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePickerBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.ComboBox comboBoxGood;
        private System.Windows.Forms.Label label7;
    }
}