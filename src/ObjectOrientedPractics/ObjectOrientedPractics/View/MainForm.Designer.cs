namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            itemsTab1 = new View.Tabs.ItemsTab();
            SuspendLayout();
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Font = new Font("Bahnschrift SemiCondensed", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            itemsTab1.Location = new Point(0, 0);
            itemsTab1.Margin = new Padding(1, 1, 1, 1);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(484, 496);
            itemsTab1.TabIndex = 0;
            itemsTab1.Load += itemsTab1_Load;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 496);
            Controls.Add(itemsTab1);
            Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 7, 5, 7);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private View.Tabs.ItemsTab itemsTab1;
    }
}
