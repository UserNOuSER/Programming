namespace ObjectOrientedPractics.View.Tabs
{
    partial class EqualTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            addressControl1 = new Controls.AddressControl();
            LeftDataGridView = new DataGridView();
            splitContainer2 = new SplitContainer();
            EqualButton = new Button();
            splitContainer4 = new SplitContainer();
            addressControl2 = new Controls.AddressControl();
            RightDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LeftDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RightDataGridView).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1034, 590);
            splitContainer1.SplitterDistance = 376;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(addressControl1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(LeftDataGridView);
            splitContainer3.Size = new Size(376, 590);
            splitContainer3.SplitterDistance = 163;
            splitContainer3.TabIndex = 0;
            // 
            // addressControl1
            // 
            addressControl1.Dock = DockStyle.Fill;
            addressControl1.Location = new Point(0, 0);
            addressControl1.Margin = new Padding(3, 4, 3, 4);
            addressControl1.MinimumSize = new Size(0, 160);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(376, 163);
            addressControl1.TabIndex = 0;
            // 
            // LeftDataGridView
            // 
            LeftDataGridView.AllowUserToAddRows = false;
            LeftDataGridView.AllowUserToDeleteRows = false;
            LeftDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LeftDataGridView.Dock = DockStyle.Fill;
            LeftDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            LeftDataGridView.Location = new Point(0, 0);
            LeftDataGridView.MultiSelect = false;
            LeftDataGridView.Name = "LeftDataGridView";
            LeftDataGridView.ReadOnly = true;
            LeftDataGridView.RowHeadersWidth = 51;
            LeftDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            LeftDataGridView.Size = new Size(376, 423);
            LeftDataGridView.TabIndex = 0;
            LeftDataGridView.MouseUp += LeftDataGridView_SelectionChanged;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(EqualButton);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer4);
            splitContainer2.Size = new Size(654, 590);
            splitContainer2.SplitterDistance = 222;
            splitContainer2.TabIndex = 0;
            // 
            // EqualButton
            // 
            EqualButton.Dock = DockStyle.Fill;
            EqualButton.Location = new Point(0, 0);
            EqualButton.Name = "EqualButton";
            EqualButton.Size = new Size(222, 590);
            EqualButton.TabIndex = 0;
            EqualButton.Text = "EQQQL?";
            EqualButton.UseVisualStyleBackColor = true;
            EqualButton.Click += EqualButton_Click;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(addressControl2);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(RightDataGridView);
            splitContainer4.Size = new Size(428, 590);
            splitContainer4.SplitterDistance = 165;
            splitContainer4.TabIndex = 0;
            // 
            // addressControl2
            // 
            addressControl2.Dock = DockStyle.Fill;
            addressControl2.Location = new Point(0, 0);
            addressControl2.Margin = new Padding(3, 4, 3, 4);
            addressControl2.MinimumSize = new Size(0, 160);
            addressControl2.Name = "addressControl2";
            addressControl2.Size = new Size(428, 165);
            addressControl2.TabIndex = 0;
            // 
            // RightDataGridView
            // 
            RightDataGridView.AllowUserToAddRows = false;
            RightDataGridView.AllowUserToDeleteRows = false;
            RightDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RightDataGridView.Dock = DockStyle.Fill;
            RightDataGridView.Location = new Point(0, 0);
            RightDataGridView.MultiSelect = false;
            RightDataGridView.Name = "RightDataGridView";
            RightDataGridView.ReadOnly = true;
            RightDataGridView.RowHeadersWidth = 51;
            RightDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            RightDataGridView.Size = new Size(428, 421);
            RightDataGridView.TabIndex = 0;
            RightDataGridView.MouseUp += RightDataGridView_SelectionChanged;
            // 
            // EqualTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "EqualTab";
            Size = new Size(1034, 590);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LeftDataGridView).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RightDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer4;
        private Button EqualButton;
        private Controls.AddressControl addressControl1;
        private DataGridView RightDataGridView;
        private Controls.AddressControl addressControl2;
        private DataGridView LeftDataGridView;
    }
}
