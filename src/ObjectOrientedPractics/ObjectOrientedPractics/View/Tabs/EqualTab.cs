using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class EqualTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;
        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders = [];
        /// <summary>
        /// Возвращает и задаёт список всех покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }
        public EqualTab()
        {
            InitializeComponent();
        }
        private void EqualButton_Click(object sender, EventArgs e)
        {
            Order leftOrder = _orders[LeftDataGridView.CurrentRow.Index];
            Order rightOrder = _orders[RightDataGridView.CurrentRow.Index];
            if (leftOrder.Equals(rightOrder))
            {
                MessageBox.Show("Заказы равны",
                    "Результат",
                    MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Заказы различны",
                    "Результат",
                    MessageBoxButtons.OK);
            }
            if (rightOrder.Address.Equals(leftOrder.Address))
            {
                MessageBox.Show("Адреса равны",
                    "Результат",
                    MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Адреса различны",
                   "Результат",
                   MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// В целом то же самое что и во вкладке с заказами но в два датасурса
        /// </summary>
        public void RefreshData()
        {
            _orders = [];
            DataTable leftDataTable = new();
            DataTable rightDataTable = new();
            leftDataTable.Columns.Add("ID", typeof(int));
            leftDataTable.Columns.Add("Address", typeof(string));
            leftDataTable.Columns.Add("Status", typeof(OrderStatus));
            leftDataTable.Columns.Add("Date", typeof(DateTime));
            leftDataTable.Columns.Add("Amount", typeof(double));
            leftDataTable.Columns.Add("CustomerName", typeof(string));
            leftDataTable.Columns.Add("Total", typeof(double));

            rightDataTable.Columns.Add("ID", typeof(int));
            rightDataTable.Columns.Add("Address", typeof(string));
            rightDataTable.Columns.Add("Status", typeof(OrderStatus));
            rightDataTable.Columns.Add("Date", typeof(DateTime));
            rightDataTable.Columns.Add("Amount", typeof(double));
            rightDataTable.Columns.Add("CustomerName", typeof(string));
            rightDataTable.Columns.Add("Total", typeof(double));

            foreach (var customer in _customers)
            {
                foreach (var order in customer.Orders)
                {
                    _orders.Add(order);
                    var lrow = leftDataTable.NewRow();
                    lrow["ID"] = order.Id;
                    lrow["Address"] = customer.Address.ToString();
                    lrow["Status"] = order.OrderStatus;
                    lrow["Date"] = order.DateTime;
                    lrow["Amount"] = order.Amount;
                    lrow["CustomerName"] = customer.Fullname;
                    lrow["Total"] = order.Total;
                    leftDataTable.Rows.Add(lrow);

                    var rrow = rightDataTable.NewRow();
                    rrow["ID"] = order.Id;
                    rrow["Address"] = customer.Address.ToString();
                    rrow["Status"] = order.OrderStatus;
                    rrow["Date"] = order.DateTime;
                    rrow["Amount"] = order.Amount;
                    rrow["CustomerName"] = customer.Fullname;
                    rrow["Total"] = order.Total;
                    rightDataTable.Rows.Add(rrow);

                }
            }

            LeftDataGridView.DataSource = null;
            LeftDataGridView.DataSource = leftDataTable;
            RightDataGridView.DataSource = null;
            RightDataGridView.DataSource = rightDataTable;
        }

        private void RightDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (RightDataGridView.CurrentCell == null)
            {
                addressControl2.Address = new Address();

            }
            else
            {
                Address address = _orders[RightDataGridView.CurrentRow.Index].Address;
                addressControl2.Address = address;
            }
        }

        private void LeftDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (LeftDataGridView.CurrentCell == null)
            {
                addressControl1.Address = new Address();
            }
            else
            {
                Address address = _orders[LeftDataGridView.CurrentRow.Index].Address;
                addressControl1.Address = address;
            }
        }

    }
}
