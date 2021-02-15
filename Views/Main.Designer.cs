namespace LombardApp.Views
{
    partial class Main
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
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NavPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
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
            this.NavPanel.Size = new System.Drawing.Size(210, 525);
            this.NavPanel.TabIndex = 0;
            // 
            // buttonAddGood
            // 
            this.buttonAddGood.BackColor = System.Drawing.Color.DarkBlue;
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
            this.buttonInfo.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonInfo.Font = new System.Drawing.Font("Anime Ace v05", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.ForeColor = System.Drawing.Color.Lavender;
            this.buttonInfo.Location = new System.Drawing.Point(8, 26);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(194, 58);
            this.buttonInfo.TabIndex = 0;
            this.buttonInfo.Text = "Інформація";
            this.buttonInfo.UseVisualStyleBackColor = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Lavender;
            this.MainPanel.Controls.Add(this.textBoxG);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.textBoxCl);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.textBoxPer);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.textBoxSum);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(210, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(746, 525);
            this.MainPanel.TabIndex = 1;
            // 
            // textBoxSum
            // 
            this.textBoxSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSum.Location = new System.Drawing.Point(389, 110);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(291, 26);
            this.textBoxSum.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(59, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 45);
            this.label6.TabIndex = 23;
            this.label6.Text = "Кошти";
            // 
            // textBoxPer
            // 
            this.textBoxPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPer.Location = new System.Drawing.Point(389, 181);
            this.textBoxPer.Name = "textBoxPer";
            this.textBoxPer.Size = new System.Drawing.Size(291, 26);
            this.textBoxPer.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(59, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 45);
            this.label1.TabIndex = 25;
            this.label1.Text = "Процентна ставка";
            // 
            // textBoxCl
            // 
            this.textBoxCl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCl.Location = new System.Drawing.Point(389, 253);
            this.textBoxCl.Name = "textBoxCl";
            this.textBoxCl.Size = new System.Drawing.Size(291, 26);
            this.textBoxCl.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(59, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 45);
            this.label2.TabIndex = 27;
            this.label2.Text = "Кількість клієнтів";
            // 
            // textBoxG
            // 
            this.textBoxG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxG.Location = new System.Drawing.Point(389, 321);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(291, 26);
            this.textBoxG.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(59, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 45);
            this.label3.TabIndex = 29;
            this.label3.Text = "Кількість товарів";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 525);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.NavPanel);
            this.Name = "Main";
            this.Text = "Main";
            this.NavPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button buttonAddGood;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonGoods;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPer;
        private System.Windows.Forms.Label label1;
    }
}