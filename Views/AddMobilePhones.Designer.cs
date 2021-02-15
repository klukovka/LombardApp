namespace LombardApp.Views
{
    partial class AddMobilePhones
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
            this.NavPanel = new System.Windows.Forms.Panel();
            this.buttonAddGood = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonGoods = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.numericUpDownImei = new System.Windows.Forms.NumericUpDown();
            this.textBoxProducer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownTerm = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownCost = new System.Windows.Forms.NumericUpDown();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerDateGet = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameGood = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NavPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).BeginInit();
            this.SuspendLayout();
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
            this.NavPanel.Size = new System.Drawing.Size(210, 625);
            this.NavPanel.TabIndex = 12;
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
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.Color.Lavender;
            this.MainPanel.Controls.Add(this.textBoxSerialNumber);
            this.MainPanel.Controls.Add(this.label9);
            this.MainPanel.Controls.Add(this.textBoxModel);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.numericUpDownImei);
            this.MainPanel.Controls.Add(this.textBoxProducer);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.numericUpDownTerm);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.numericUpDownCost);
            this.MainPanel.Controls.Add(this.buttonContinue);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.dateTimePickerDateGet);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.textBoxNameGood);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(210, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(707, 625);
            this.MainPanel.TabIndex = 13;
            // 
            // numericUpDownImei
            // 
            this.numericUpDownImei.Location = new System.Drawing.Point(364, 413);
            this.numericUpDownImei.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownImei.Name = "numericUpDownImei";
            this.numericUpDownImei.Size = new System.Drawing.Size(291, 26);
            this.numericUpDownImei.TabIndex = 25;
            // 
            // textBoxProducer
            // 
            this.textBoxProducer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProducer.Location = new System.Drawing.Point(364, 270);
            this.textBoxProducer.Name = "textBoxProducer";
            this.textBoxProducer.Size = new System.Drawing.Size(291, 26);
            this.textBoxProducer.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(34, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 45);
            this.label6.TabIndex = 21;
            this.label6.Text = "Марка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(34, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 45);
            this.label5.TabIndex = 19;
            this.label5.Text = "Imei";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(34, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 45);
            this.label4.TabIndex = 18;
            this.label4.Text = "Термін";
            // 
            // numericUpDownTerm
            // 
            this.numericUpDownTerm.Location = new System.Drawing.Point(364, 216);
            this.numericUpDownTerm.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownTerm.Name = "numericUpDownTerm";
            this.numericUpDownTerm.Size = new System.Drawing.Size(291, 26);
            this.numericUpDownTerm.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(34, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 45);
            this.label3.TabIndex = 16;
            this.label3.Text = "Оціночна вартість";
            // 
            // numericUpDownCost
            // 
            this.numericUpDownCost.Location = new System.Drawing.Point(364, 112);
            this.numericUpDownCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownCost.Name = "numericUpDownCost";
            this.numericUpDownCost.Size = new System.Drawing.Size(291, 26);
            this.numericUpDownCost.TabIndex = 15;
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonContinue.Font = new System.Drawing.Font("Anime Ace v05", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.ForeColor = System.Drawing.Color.Lavender;
            this.buttonContinue.Location = new System.Drawing.Point(42, 540);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(585, 58);
            this.buttonContinue.TabIndex = 4;
            this.buttonContinue.Text = "Далі";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(34, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(509, 45);
            this.label7.TabIndex = 14;
            this.label7.Text = "Тип товару: мобільні пристрої";
            // 
            // dateTimePickerDateGet
            // 
            this.dateTimePickerDateGet.Location = new System.Drawing.Point(364, 163);
            this.dateTimePickerDateGet.Name = "dateTimePickerDateGet";
            this.dateTimePickerDateGet.Size = new System.Drawing.Size(291, 26);
            this.dateTimePickerDateGet.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(34, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата здачі";
            // 
            // textBoxNameGood
            // 
            this.textBoxNameGood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNameGood.Location = new System.Drawing.Point(364, 65);
            this.textBoxNameGood.Name = "textBoxNameGood";
            this.textBoxNameGood.Size = new System.Drawing.Size(291, 26);
            this.textBoxNameGood.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Назва товару";
            // 
            // textBoxModel
            // 
            this.textBoxModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxModel.Location = new System.Drawing.Point(364, 315);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(291, 26);
            this.textBoxModel.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(34, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 45);
            this.label8.TabIndex = 26;
            this.label8.Text = "Модель";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSerialNumber.Location = new System.Drawing.Point(364, 360);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(291, 26);
            this.textBoxSerialNumber.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(34, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(272, 45);
            this.label9.TabIndex = 28;
            this.label9.Text = "Серійний номер";
            // 
            // AddMobilePhones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 625);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.NavPanel);
            this.Name = "AddMobilePhones";
            this.Text = "AddMobilePhones";
            this.NavPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Button buttonAddGood;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonGoods;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.NumericUpDown numericUpDownImei;
        private System.Windows.Forms.TextBox textBoxProducer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCost;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateGet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameGood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label8;
    }
}