namespace ObjectOrientedPractics.View
{
    partial class ItemEqualClone
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
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            EqualButton = new Button();
            button2 = new Button();
            RedItemListBox = new ListBox();
            splitContainer1 = new SplitContainer();
            LeftItemListBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
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
            splitContainer2.Panel2.Controls.Add(RedItemListBox);
            splitContainer2.Size = new Size(360, 230);
            splitContainer2.SplitterDistance = 115;
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
            splitContainer3.Panel1.Controls.Add(EqualButton);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(button2);
            splitContainer3.Size = new Size(115, 230);
            splitContainer3.SplitterDistance = 115;
            splitContainer3.TabIndex = 0;
            // 
            // EqualButton
            // 
            EqualButton.Dock = DockStyle.Fill;
            EqualButton.Location = new Point(0, 0);
            EqualButton.Name = "EqualButton";
            EqualButton.Size = new Size(115, 115);
            EqualButton.TabIndex = 0;
            EqualButton.Text = "Equal?";
            EqualButton.UseVisualStyleBackColor = true;
            EqualButton.Click += EqualButton_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(115, 111);
            button2.TabIndex = 0;
            button2.Text = "Clone";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // RedItemListBox
            // 
            RedItemListBox.Dock = DockStyle.Fill;
            RedItemListBox.FormattingEnabled = true;
            RedItemListBox.Location = new Point(0, 0);
            RedItemListBox.Name = "RedItemListBox";
            RedItemListBox.Size = new Size(241, 230);
            RedItemListBox.TabIndex = 0;
            RedItemListBox.SelectedIndexChanged += RedItemListBox_SelectedIndexChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(LeftItemListBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(611, 230);
            splitContainer1.SplitterDistance = 247;
            splitContainer1.TabIndex = 0;
            // 
            // LeftItemListBox
            // 
            LeftItemListBox.Dock = DockStyle.Fill;
            LeftItemListBox.FormattingEnabled = true;
            LeftItemListBox.Location = new Point(0, 0);
            LeftItemListBox.Name = "LeftItemListBox";
            LeftItemListBox.Size = new Size(247, 230);
            LeftItemListBox.TabIndex = 0;
            LeftItemListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // EqualCompareWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "EqualCompareWindow";
            Size = new Size(611, 230);
            Load += EqualCompareWindow_Load;
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private Button EqualButton;
        private Button button2;
        private ListBox RedItemListBox;
        private SplitContainer splitContainer1;
        private ListBox LeftItemListBox;
    }
}
