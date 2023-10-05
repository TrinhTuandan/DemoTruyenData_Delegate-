namespace DemoTruyenData
{
    partial class fmCon
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
            this.btnsend = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(496, 106);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(202, 38);
            this.btnsend.TabIndex = 0;
            this.btnsend.Text = "Gửi cho cha ";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(81, 106);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(328, 38);
            this.txtData.TabIndex = 1;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // fmCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 253);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnsend);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "fmCon";
            this.Text = "fmCon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.TextBox txtData;
    }
}