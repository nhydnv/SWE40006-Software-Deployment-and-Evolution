namespace subtask_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button1 = null;

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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.button1.Size = new System.Drawing.Size(160, 60);
            this.button1.Location = new System.Drawing.Point(
                (this.ClientSize.Width - this.button1.Width) / 2,
                (this.ClientSize.Height - this.button1.Height) / 2);
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None; // stays centered if form is resized... sort of
            this.button1.TabIndex = 0;
            this.button1.Text = "button";
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.Controls.Add(this.button1);
        }
    }
}
