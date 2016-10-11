namespace LogIn_design
{
    partial class RegistroMeds
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
            this.buscarBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.DescripcionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreMedtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LaboratoriocomboBox = new System.Windows.Forms.ComboBox();
            this.PrecioventatextBox = new System.Windows.Forms.TextBox();
            this.PrecioCompratextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SiradioButton = new System.Windows.Forms.RadioButton();
            this.NoradioButton = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.PrecioDetalletextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(197, 40);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 0;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(15, 294);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 40);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Guardar";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(96, 294);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 40);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Actualizar";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(178, 294);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 40);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Borrar";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(12, 40);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(168, 20);
            this.IdtextBox.TabIndex = 4;
            // 
            // DescripcionrichTextBox
            // 
            this.DescripcionrichTextBox.Location = new System.Drawing.Point(12, 118);
            this.DescripcionrichTextBox.Name = "DescripcionrichTextBox";
            this.DescripcionrichTextBox.Size = new System.Drawing.Size(260, 62);
            this.DescripcionrichTextBox.TabIndex = 5;
            this.DescripcionrichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion";
            // 
            // NombreMedtextBox
            // 
            this.NombreMedtextBox.Location = new System.Drawing.Point(12, 79);
            this.NombreMedtextBox.Name = "NombreMedtextBox";
            this.NombreMedtextBox.Size = new System.Drawing.Size(168, 20);
            this.NombreMedtextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre de medicina";
            // 
            // LaboratoriocomboBox
            // 
            this.LaboratoriocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LaboratoriocomboBox.FormattingEnabled = true;
            this.LaboratoriocomboBox.Location = new System.Drawing.Point(12, 213);
            this.LaboratoriocomboBox.Name = "LaboratoriocomboBox";
            this.LaboratoriocomboBox.Size = new System.Drawing.Size(121, 21);
            this.LaboratoriocomboBox.TabIndex = 10;
            this.LaboratoriocomboBox.SelectedIndexChanged += new System.EventHandler(this.LaboratoriocomboBox_SelectedIndexChanged);
            // 
            // PrecioventatextBox
            // 
            this.PrecioventatextBox.Location = new System.Drawing.Point(143, 263);
            this.PrecioventatextBox.Name = "PrecioventatextBox";
            this.PrecioventatextBox.Size = new System.Drawing.Size(100, 20);
            this.PrecioventatextBox.TabIndex = 11;
            // 
            // PrecioCompratextBox
            // 
            this.PrecioCompratextBox.Location = new System.Drawing.Point(12, 263);
            this.PrecioCompratextBox.Name = "PrecioCompratextBox";
            this.PrecioCompratextBox.Size = new System.Drawing.Size(100, 20);
            this.PrecioCompratextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Laboratorio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Precio de venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Precio de compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha de vencimiento";
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(287, 118);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(100, 20);
            this.CantidadtextBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cantidad en existencia";
            // 
            // SiradioButton
            // 
            this.SiradioButton.AutoSize = true;
            this.SiradioButton.Location = new System.Drawing.Point(287, 175);
            this.SiradioButton.Name = "SiradioButton";
            this.SiradioButton.Size = new System.Drawing.Size(34, 17);
            this.SiradioButton.TabIndex = 20;
            this.SiradioButton.TabStop = true;
            this.SiradioButton.Text = "Si";
            this.SiradioButton.UseVisualStyleBackColor = true;
            this.SiradioButton.CheckedChanged += new System.EventHandler(this.SiradioButton_CheckedChanged);
            // 
            // NoradioButton
            // 
            this.NoradioButton.AutoSize = true;
            this.NoradioButton.Location = new System.Drawing.Point(327, 175);
            this.NoradioButton.Name = "NoradioButton";
            this.NoradioButton.Size = new System.Drawing.Size(39, 17);
            this.NoradioButton.TabIndex = 21;
            this.NoradioButton.TabStop = true;
            this.NoradioButton.Text = "No";
            this.NoradioButton.UseVisualStyleBackColor = true;
            this.NoradioButton.CheckedChanged += new System.EventHandler(this.NoradioButton_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Detalle";
            // 
            // PrecioDetalletextBox
            // 
            this.PrecioDetalletextBox.Location = new System.Drawing.Point(285, 263);
            this.PrecioDetalletextBox.Name = "PrecioDetalletextBox";
            this.PrecioDetalletextBox.Size = new System.Drawing.Size(100, 20);
            this.PrecioDetalletextBox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Precio detalle";
            // 
            // RegistroMeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 346);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PrecioDetalletextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NoradioButton);
            this.Controls.Add(this.SiradioButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrecioCompratextBox);
            this.Controls.Add(this.PrecioventatextBox);
            this.Controls.Add(this.LaboratoriocomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreMedtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescripcionrichTextBox);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.buscarBtn);
            this.Name = "RegistroMeds";
            this.Text = "RegistroMeds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.RichTextBox DescripcionrichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreMedtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LaboratoriocomboBox;
        private System.Windows.Forms.TextBox PrecioventatextBox;
        private System.Windows.Forms.TextBox PrecioCompratextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton SiradioButton;
        private System.Windows.Forms.RadioButton NoradioButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PrecioDetalletextBox;
        private System.Windows.Forms.Label label10;
    }
}