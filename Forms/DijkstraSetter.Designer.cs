using System.ComponentModel;

namespace DijkstraAlgorithmOnGraph
{
    partial class DijkstraSetter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.startLabel = new System.Windows.Forms.Label();
            this.startNumeric = new System.Windows.Forms.NumericUpDown();
            this.endLabel = new System.Windows.Forms.Label();
            this.endNumeric = new System.Windows.Forms.NumericUpDown();
            this.submitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // startLabel
            // 
            this.startLabel.Location = new System.Drawing.Point(40, 34);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(63, 27);
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "Start";
            // 
            // startNumeric
            // 
            this.startNumeric.Location = new System.Drawing.Point(40, 64);
            this.startNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.startNumeric.Name = "startNumeric";
            this.startNumeric.Size = new System.Drawing.Size(54, 22);
            this.startNumeric.TabIndex = 1;
            this.startNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // endLabel
            // 
            this.endLabel.Location = new System.Drawing.Point(109, 34);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(63, 27);
            this.endLabel.TabIndex = 2;
            this.endLabel.Text = "End";
            // 
            // endNumeric
            // 
            this.endNumeric.Location = new System.Drawing.Point(109, 64);
            this.endNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.endNumeric.Name = "endNumeric";
            this.endNumeric.Size = new System.Drawing.Size(54, 22);
            this.endNumeric.TabIndex = 3;
            this.endNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(40, 117);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(123, 33);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // DijkstraSetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 188);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.endNumeric);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startNumeric);
            this.Controls.Add(this.startLabel);
            this.Name = "DijkstraSetter";
            this.Text = "DijkstraSetter";
            ((System.ComponentModel.ISupportInitialize)(this.startNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumeric)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button submitBtn;

        private System.Windows.Forms.NumericUpDown endNumeric;

        private System.Windows.Forms.Label endLabel;

        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.NumericUpDown startNumeric;

        #endregion
    }
}