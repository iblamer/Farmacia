namespace LogIn_design.Consultas
{
    partial class ConsultaUsuario
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
            this.DatadataGridView = new System.Windows.Forms.DataGridView();
            this.filtrarLbl = new System.Windows.Forms.Label();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.DatacomboBox = new System.Windows.Forms.ComboBox();
            this.buscarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DatadataGridView
            // 
            this.DatadataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatadataGridView.Location = new System.Drawing.Point(12, 56);
            this.DatadataGridView.Name = "DatadataGridView";
            this.DatadataGridView.Size = new System.Drawing.Size(523, 292);
            this.DatadataGridView.TabIndex = 0;
            // 
            // filtrarLbl
            // 
            this.filtrarLbl.AutoSize = true;
            this.filtrarLbl.Location = new System.Drawing.Point(12, 19);
            this.filtrarLbl.Name = "filtrarLbl";
            this.filtrarLbl.Size = new System.Drawing.Size(32, 13);
            this.filtrarLbl.TabIndex = 1;
            this.filtrarLbl.Text = "Filtrar";
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Location = new System.Drawing.Point(15, 354);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(75, 41);
            this.ImprimirButton.TabIndex = 2;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(187, 16);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(243, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // DatacomboBox
            // 
            this.DatacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DatacomboBox.FormattingEnabled = true;
            this.DatacomboBox.Items.AddRange(new object[] {
            "ID",
            "Nombre"});
            this.DatacomboBox.Location = new System.Drawing.Point(60, 15);
            this.DatacomboBox.Name = "DatacomboBox";
            this.DatacomboBox.Size = new System.Drawing.Size(121, 21);
            this.DatacomboBox.TabIndex = 4;
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(448, 15);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(87, 23);
            this.buscarBtn.TabIndex = 5;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 407);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.DatacomboBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.filtrarLbl);
            this.Controls.Add(this.DatadataGridView);
            this.Name = "ConsultaUsuario";
            this.Text = "ConsultaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.DatadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatadataGridView;
        private System.Windows.Forms.Label filtrarLbl;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox DatacomboBox;
        private System.Windows.Forms.Button buscarBtn;
    }
}