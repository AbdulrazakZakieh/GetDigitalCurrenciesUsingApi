namespace GettingCurrencies
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
            this.getCurrenciesButton = new System.Windows.Forms.Button();
            this.digitalCurrenciesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.digitalCurrenciesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // getCurrenciesButton
            // 
            this.getCurrenciesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.getCurrenciesButton.Location = new System.Drawing.Point(591, 403);
            this.getCurrenciesButton.Name = "getCurrenciesButton";
            this.getCurrenciesButton.Size = new System.Drawing.Size(203, 35);
            this.getCurrenciesButton.TabIndex = 0;
            this.getCurrenciesButton.Text = "Get Data";
            this.getCurrenciesButton.UseVisualStyleBackColor = true;
            this.getCurrenciesButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // digitalCurrenciesDataGridView
            // 
            this.digitalCurrenciesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digitalCurrenciesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.digitalCurrenciesDataGridView.Location = new System.Drawing.Point(5, 12);
            this.digitalCurrenciesDataGridView.Name = "digitalCurrenciesDataGridView";
            this.digitalCurrenciesDataGridView.RowTemplate.Height = 29;
            this.digitalCurrenciesDataGridView.Size = new System.Drawing.Size(789, 385);
            this.digitalCurrenciesDataGridView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.digitalCurrenciesDataGridView);
            this.Controls.Add(this.getCurrenciesButton);
            this.Name = "Form1";
            this.Text = "Digital Currencies";
            ((System.ComponentModel.ISupportInitialize)(this.digitalCurrenciesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getCurrenciesButton;
        private System.Windows.Forms.DataGridView digitalCurrenciesDataGridView;
    }
}

