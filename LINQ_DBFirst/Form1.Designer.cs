namespace LINQ_DBFirst
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
            this.dgwCustomer = new System.Windows.Forms.DataGridView();
            this.grpbxSearch = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).BeginInit();
            this.grpbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCustomer
            // 
            this.dgwCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomer.Location = new System.Drawing.Point(12, 209);
            this.dgwCustomer.Name = "dgwCustomer";
            this.dgwCustomer.Size = new System.Drawing.Size(1184, 290);
            this.dgwCustomer.TabIndex = 0;
            // 
            // grpbxSearch
            // 
            this.grpbxSearch.Controls.Add(this.lblName);
            this.grpbxSearch.Controls.Add(this.btnAra);
            this.grpbxSearch.Controls.Add(this.txtName);
            this.grpbxSearch.Location = new System.Drawing.Point(12, 12);
            this.grpbxSearch.Name = "grpbxSearch";
            this.grpbxSearch.Size = new System.Drawing.Size(1184, 191);
            this.grpbxSearch.TabIndex = 1;
            this.grpbxSearch.TabStop = false;
            this.grpbxSearch.Text = "Ara";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(103, 71);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 32);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(28, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "İsim:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 502);
            this.Controls.Add(this.grpbxSearch);
            this.Controls.Add(this.dgwCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).EndInit();
            this.grpbxSearch.ResumeLayout(false);
            this.grpbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCustomer;
        private System.Windows.Forms.GroupBox grpbxSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtName;
    }
}

