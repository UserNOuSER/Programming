namespace ObjectOrientedPractics.View
{
    partial class CloneTab
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
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            addressControl1 = new Tabs.Controls.AddressControl();
            LeftListBox = new ListBox();
            splitContainer4 = new SplitContainer();
            addressControl2 = new Tabs.Controls.AddressControl();
            RightListBox = new ListBox();
            CloneButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(CloneButton);
            splitContainer1.Size = new Size(990, 472);
            splitContainer1.SplitterDistance = 393;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer4);
            splitContainer2.Size = new Size(990, 393);
            splitContainer2.SplitterDistance = 493;
            splitContainer2.TabIndex = 0;
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
            splitContainer3.Panel2.Controls.Add(LeftListBox);
            splitContainer3.Size = new Size(493, 393);
            splitContainer3.SplitterDistance = 199;
            splitContainer3.TabIndex = 0;
            // 
            // addressControl1
            // 
            addressControl1.Dock = DockStyle.Fill;
            addressControl1.Location = new Point(0, 0);
            addressControl1.Margin = new Padding(3, 4, 3, 4);
            addressControl1.MinimumSize = new Size(0, 160);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(493, 199);
            addressControl1.TabIndex = 0;
            // 
            // LeftListBox
            // 
            LeftListBox.Dock = DockStyle.Fill;
            LeftListBox.FormattingEnabled = true;
            LeftListBox.Location = new Point(0, 0);
            LeftListBox.Name = "LeftListBox";
            LeftListBox.Size = new Size(493, 190);
            LeftListBox.TabIndex = 0;
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
            splitContainer4.Panel2.Controls.Add(RightListBox);
            splitContainer4.Size = new Size(493, 393);
            splitContainer4.SplitterDistance = 198;
            splitContainer4.TabIndex = 0;
            // 
            // addressControl2
            // 
            addressControl2.Dock = DockStyle.Fill;
            addressControl2.Location = new Point(0, 0);
            addressControl2.Margin = new Padding(3, 4, 3, 4);
            addressControl2.MinimumSize = new Size(0, 160);
            addressControl2.Name = "addressControl2";
            addressControl2.Size = new Size(493, 198);
            addressControl2.TabIndex = 0;
            // 
            // RightListBox
            // 
            RightListBox.Dock = DockStyle.Fill;
            RightListBox.FormattingEnabled = true;
            RightListBox.Location = new Point(0, 0);
            RightListBox.Name = "RightListBox";
            RightListBox.Size = new Size(493, 191);
            RightListBox.TabIndex = 0;
            // 
            // CloneButton
            // 
            CloneButton.Dock = DockStyle.Fill;
            CloneButton.Location = new Point(0, 0);
            CloneButton.Name = "CloneButton";
            CloneButton.Size = new Size(990, 75);
            CloneButton.TabIndex = 0;
            CloneButton.Text = "LETS CLONE TOGETHER";
            CloneButton.UseVisualStyleBackColor = true;
            CloneButton.Click += CloneButton_Click;
            // 
            // CloneTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CloneTab";
            Size = new Size(990, 472);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private Tabs.Controls.AddressControl addressControl1;
        private ListBox LeftListBox;
        private SplitContainer splitContainer4;
        private Tabs.Controls.AddressControl addressControl2;
        private ListBox RightListBox;
        private Button CloneButton;
    }
}
