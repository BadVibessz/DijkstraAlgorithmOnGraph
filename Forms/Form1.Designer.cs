namespace DijkstraAlgorithmOnGraph
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dijkstraBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 707);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dijkstraBtn
            // 
            this.dijkstraBtn.Location = new System.Drawing.Point(27, 12);
            this.dijkstraBtn.Name = "dijkstraBtn";
            this.dijkstraBtn.Size = new System.Drawing.Size(72, 28);
            this.dijkstraBtn.TabIndex = 1;
            this.dijkstraBtn.Text = "Dijkstra";
            this.dijkstraBtn.UseVisualStyleBackColor = true;
            this.dijkstraBtn.Click += new System.EventHandler(this.dijkstraBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.dijkstraBtn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button dijkstraBtn;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}