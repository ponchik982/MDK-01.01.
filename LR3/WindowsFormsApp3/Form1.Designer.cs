namespace PharmacyOrderApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.Panel panelDrugs;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.TextBox textBoxResult;

        private void InitializeComponent()
        {
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.panelDrugs = new System.Windows.Forms.Panel();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(20, 20);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(200, 21);
            this.comboBoxGroups.TabIndex = 0;
            // 
            // panelDrugs
            // 
            this.panelDrugs.AutoScroll = true;
            this.panelDrugs.Location = new System.Drawing.Point(20, 60);
            this.panelDrugs.Name = "panelDrugs";
            this.panelDrugs.Size = new System.Drawing.Size(300, 150);
            this.panelDrugs.TabIndex = 1;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(20, 220);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(100, 30);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "Заказать";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(20, 260);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(300, 120);
            this.textBoxResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(605, 490);
            this.Controls.Add(this.comboBoxGroups);
            this.Controls.Add(this.panelDrugs);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.textBoxResult);
            this.Name = "Form1";
            this.Text = "Лекарственные заказы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
