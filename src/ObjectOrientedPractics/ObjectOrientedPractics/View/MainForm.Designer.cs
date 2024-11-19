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
            Model.Address address1 = new Model.Address();
            Model.Cart cart1 = new Model.Cart();
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
            tabPage4 = new TabPage();
            equalCompareWindow1 = new ItemEqualClone();
            tabPage5 = new TabPage();
            cloneTab1 = new CloneTab();
            tabPage6 = new TabPage();
            equalTab1 = new EqualTab();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            CartTab.SuspendLayout();
            tabPage3.SuspendLayout();
            PriorityOrderTab.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(CartTab);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(PriorityOrderTab);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(5, 4, 5, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1439, 724);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += SelectedTabChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(itemsTab);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(5, 4, 5, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5, 4, 5, 4);
            tabPage1.Size = new Size(1431, 691);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Item Tab";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            itemsTab.Dock = DockStyle.Fill;
            itemsTab.Location = new Point(5, 4);
            itemsTab.Margin = new Padding(5, 2, 5, 2);
            itemsTab.Name = "itemsTab";
            itemsTab.Size = new Size(1421, 683);
            itemsTab.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(customersTab);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(5, 4, 5, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5, 4, 5, 4);
            tabPage2.Size = new Size(1431, 691);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customer Tab";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            customersTab.Dock = DockStyle.Fill;
            customersTab.Location = new Point(5, 4);
            customersTab.Margin = new Padding(5, 2, 5, 2);
            customersTab.Name = "customersTab";
            customersTab.Size = new Size(1421, 683);
            customersTab.TabIndex = 0;
            // 
            // CartTab
            // 
            CartTab.Controls.Add(cartsTab1);
            CartTab.Location = new Point(4, 29);
            CartTab.Margin = new Padding(5, 4, 5, 4);
            CartTab.Name = "CartTab";
            CartTab.Padding = new Padding(5, 4, 5, 4);
            CartTab.Size = new Size(1431, 691);
            CartTab.TabIndex = 2;
            CartTab.Text = "Cart Tab";
            CartTab.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Customers = null;
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Items = null;
            cartsTab1.Location = new Point(5, 4);
            cartsTab1.Margin = new Padding(5, 4, 5, 4);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(1421, 683);
            cartsTab1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(ordersTab1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(5, 4, 5, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(5, 4, 5, 4);
            tabPage3.Size = new Size(1431, 691);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Order Tab";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.Customers = null;
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(5, 4);
            ordersTab1.Margin = new Padding(5, 4, 5, 4);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(1421, 683);
            ordersTab1.TabIndex = 0;
            // 
            // PriorityOrderTab
            // 
            PriorityOrderTab.Controls.Add(priorityOrdersTab1);
            PriorityOrderTab.Location = new Point(4, 29);
            PriorityOrderTab.Margin = new Padding(5, 4, 5, 4);
            PriorityOrderTab.Name = "PriorityOrderTab";
            PriorityOrderTab.Padding = new Padding(5, 4, 5, 4);
            PriorityOrderTab.Size = new Size(1431, 691);
            PriorityOrderTab.TabIndex = 4;
            PriorityOrderTab.Text = "Priority Order Tab";
            PriorityOrderTab.UseVisualStyleBackColor = true;
            // 
            // priorityOrdersTab1
            // 
            priorityOrdersTab1.Dock = DockStyle.Fill;
            priorityOrdersTab1.Location = new Point(5, 4);
            priorityOrdersTab1.Margin = new Padding(5, 4, 5, 4);
            priorityOrdersTab1.Name = "priorityOrdersTab1";
            priorityOrdersTab1.Size = new Size(1421, 683);
            priorityOrdersTab1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(equalCompareWindow1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1431, 691);
            tabPage4.TabIndex = 5;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // equalCompareWindow1
            // 
            equalCompareWindow1.Dock = DockStyle.Fill;
            equalCompareWindow1.Location = new Point(3, 3);
            equalCompareWindow1.Name = "equalCompareWindow1";
            equalCompareWindow1.Size = new Size(1425, 685);
            equalCompareWindow1.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(cloneTab1);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1431, 691);
            tabPage5.TabIndex = 6;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // cloneTab1
            // 
            cloneTab1.Dock = DockStyle.Fill;
            address1.Apartment = "Suite 582";
            address1.Building = "77530";
            address1.City = "Port Hugh";
            address1.Country = "Netherlands Antilles";
            address1.Index = "394706";
            address1.Street = "Gladys Landing";
            cloneTab1.LeftAddress = address1;
            cloneTab1.LeftCart = cart1;
            cloneTab1.Location = new Point(3, 3);
            cloneTab1.Name = "cloneTab1";
            cloneTab1.Size = new Size(1425, 685);
            cloneTab1.TabIndex = 0;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(equalTab1);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1431, 691);
            tabPage6.TabIndex = 7;
            tabPage6.Text = "tabPage6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // equalTab1
            // 
            equalTab1.Customers = null;
            equalTab1.Dock = DockStyle.Fill;
            equalTab1.Location = new Point(3, 3);
            equalTab1.Name = "equalTab1";
            equalTab1.Size = new Size(1425, 685);
            equalTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 724);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 4, 2, 4);
            MinimumSize = new Size(1457, 771);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            CartTab.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            PriorityOrderTab.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
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
        private TabPage tabPage4;
        private ItemEqualClone equalCompareWindow1;
        private TabPage tabPage5;
        private CloneTab cloneTab1;
        private TabPage tabPage6;
        private EqualTab equalTab1;
    }
}
