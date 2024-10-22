using System.ComponentModel;

namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            itemsTab = new ItemsTab();
            tabPage2 = new TabPage();
            customersTab = new CustomersTab();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1079, 579);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(itemsTab);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1071, 550);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Item Tab";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab.Dock = DockStyle.Fill;
            itemsTab.Location = new Point(3, 3);
            itemsTab.Margin = new Padding(3, 2, 3, 2);
            itemsTab.Name = "itemsTab1";
            itemsTab.Size = new Size(1065, 544);
            itemsTab.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(customersTab);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1071, 546);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customer Tab";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab.Dock = DockStyle.Fill;
            customersTab.Location = new Point(3, 3);
            customersTab.Margin = new Padding(3, 2, 3, 2);
            customersTab.Name = "customersTab1";
            customersTab.Size = new Size(1065, 540);
            customersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 579);
            Controls.Add(tabControl1);
            Font = new Font("Bahnschrift SemiCondensed", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(700, 533);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ItemsTab itemsTab;
        private TabPage tabPage2;
        private CustomersTab customersTab;
    }
}
