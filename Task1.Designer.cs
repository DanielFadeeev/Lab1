namespace Lab1
{
    partial class Task1
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
            this.txtTriangleArea = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculateTriangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTriangleArea
            // 
            this.txtTriangleArea.Enabled = false;
            this.txtTriangleArea.ForeColor = System.Drawing.Color.Black;
            this.txtTriangleArea.Location = new System.Drawing.Point(476, 85);
            this.txtTriangleArea.Name = "txtTriangleArea";
            this.txtTriangleArea.Size = new System.Drawing.Size(142, 22);
            this.txtTriangleArea.TabIndex = 7;
            // 
            // txtC
            // 
            this.txtC.ForeColor = System.Drawing.Color.Black;
            this.txtC.Location = new System.Drawing.Point(333, 85);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 22);
            this.txtC.TabIndex = 6;
            // 
            // txtB
            // 
            this.txtB.ForeColor = System.Drawing.Color.Black;
            this.txtB.Location = new System.Drawing.Point(205, 85);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 5;
            // 
            // txtA
            // 
            this.txtA.ForeColor = System.Drawing.Color.Black;
            this.txtA.Location = new System.Drawing.Point(71, 85);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(518, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 33);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculateTriangle
            // 
            this.btnCalculateTriangle.Location = new System.Drawing.Point(292, 180);
            this.btnCalculateTriangle.Name = "btnCalculateTriangle";
            this.btnCalculateTriangle.Size = new System.Drawing.Size(141, 33);
            this.btnCalculateTriangle.TabIndex = 8;
            this.btnCalculateTriangle.Text = "Вычислить";
            this.btnCalculateTriangle.UseVisualStyleBackColor = true;
            this.btnCalculateTriangle.Click += new System.EventHandler(this.btnCalculateTriangle_Click);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 307);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateTriangle);
            this.Controls.Add(this.txtTriangleArea);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Task1";
            this.Text = "Task1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTriangleArea;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculateTriangle;
    }
}