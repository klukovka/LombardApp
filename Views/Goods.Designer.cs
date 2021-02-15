namespace LombardApp.Views
{
    partial class Goods
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.NavPanel = new System.Windows.Forms.Panel();
            this.buttonAddGood = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonGoods = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.NavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.Color.Lavender;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(210, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(699, 523);
            this.MainPanel.TabIndex = 3;
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
            this.NavPanel.Size = new System.Drawing.Size(210, 523);
            this.NavPanel.TabIndex = 2;
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
            this.buttonGoods.BackColor = System.Drawing.Color.MediumBlue;
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
            // Goods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 523);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.NavPanel);
            this.Name = "Goods";
            this.Text = "Goods";
            this.NavPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Button buttonAddGood;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonGoods;
        private System.Windows.Forms.Button buttonInfo;
    }
}