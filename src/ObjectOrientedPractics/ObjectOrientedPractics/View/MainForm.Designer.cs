using ObjectOrientedPractics.View.Tabs;
using System.ComponentModel;

namespace ObjectOrientedPractics.View
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            itemsTab = new ItemsTab();
            tabPage2 = new TabPage();
            customersTab = new CustomersTab();
            CartTab = new TabPage();
            cartsTab1 = new CartsTab();
            tabPage3 = new TabPage();
            ordersTab1 = new OrdersTab();
            PriorityOrderTab = new TabPage();
            priorityOrdersTab1 = new PriorityOrdersTab();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            CartTab.SuspendLayout();
            tabPage3.SuspendLayout();
            PriorityOrderTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(CartTab);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(PriorityOrderTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1079, 579);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += SelectedTabChanged;
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
            // itemsTab
            // 
            itemsTab.Dock = DockStyle.Fill;
            itemsTab.Location = new Point(3, 3);
            itemsTab.Margin = new Padding(3, 2, 3, 2);
            itemsTab.Name = "itemsTab";
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
            // customersTab
            // 
            customersTab.Dock = DockStyle.Fill;
            customersTab.Location = new Point(3, 3);
            customersTab.Margin = new Padding(3, 2, 3, 2);
            customersTab.Name = "customersTab";
            customersTab.Size = new Size(1065, 540);
            customersTab.TabIndex = 0;
            // 
            // CartTab
            // 
            CartTab.Controls.Add(cartsTab1);
            CartTab.Location = new Point(4, 29);
            CartTab.Name = "CartTab";
            CartTab.Padding = new Padding(3);
            CartTab.Size = new Size(1071, 546);
            CartTab.TabIndex = 2;
            CartTab.Text = "Cart Tab";
            CartTab.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Customers = null;
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Items = null;
            cartsTab1.Location = new Point(3, 3);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(1065, 540);
            cartsTab1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(ordersTab1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1071, 546);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Order Tab";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.Customers = null;
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(3, 3);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(1065, 540);
            ordersTab1.TabIndex = 0;
            // 
            // PriorityOrderTab
            // 
            PriorityOrderTab.Controls.Add(priorityOrdersTab1);
            PriorityOrderTab.Location = new Point(4, 29);
            PriorityOrderTab.Name = "PriorityOrderTab";
            PriorityOrderTab.Padding = new Padding(3);
            PriorityOrderTab.Size = new Size(1071, 546);
            PriorityOrderTab.TabIndex = 4;
            PriorityOrderTab.Text = "Priority Order Tab";
            PriorityOrderTab.UseVisualStyleBackColor = true;
            // 
            // priorityOrdersTab1
            // 
            priorityOrdersTab1.Dock = DockStyle.Fill;
            priorityOrdersTab1.Location = new Point(3, 3);
            priorityOrdersTab1.Name = "priorityOrdersTab1";
            priorityOrdersTab1.Size = new Size(1065, 540);
            priorityOrdersTab1.TabIndex = 0;
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
            MinimumSize = new Size(1097, 626);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            CartTab.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            PriorityOrderTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ItemsTab itemsTab;
        private TabPage tabPage2;
        private CustomersTab customersTab;
        private TabPage CartTab;
        private CartsTab cartsTab1;
        private TabPage tabPage3;
        private OrdersTab ordersTab1;
        private TabPage PriorityOrderTab;
        private PriorityOrdersTab priorityOrdersTab1;
    }
}
