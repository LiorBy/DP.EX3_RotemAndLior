namespace C18_Ex1_Rotem_204360002_Lior_305346660
{
    partial class BirthdatForm 
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
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AllowDrop = true;
            this.birthdayLabel.AutoEllipsis = true;
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabel.Location = new System.Drawing.Point(99, 66);
            this.birthdayLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(610, 66);
            this.birthdayLabel.TabIndex = 0;
            this.birthdayLabel.Text = "WHO HAS A BIRTHDAY?";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 88;
            this.listBox1.Location = new System.Drawing.Point(152, 191);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(497, 532);
            this.listBox1.TabIndex = 1;
            // 
            // BirthdatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(45F, 88F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 1753);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.birthdayLabel);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "BirthdatForm";
            this.Text = "BirthdatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.ListBox listBox1;
    }
}