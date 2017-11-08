namespace Proyecto_Pozo_Verde_V1.Visual_Forms
{
    partial class Ven_Facturacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ven_Facturacion));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.txtDescuentos = new System.Windows.Forms.TextBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btBuscar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_NomClient = new System.Windows.Forms.Label();
            this.txtCed = new System.Windows.Forms.TextBox();
            this.lb_Ident = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvProdFact = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDescripcion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodInv = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdFact)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 395);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btSalir);
            this.panel4.Controls.Add(this.btDel);
            this.panel4.Controls.Add(this.btEdit);
            this.panel4.Controls.Add(this.btAdd);
            this.panel4.Location = new System.Drawing.Point(16, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(720, 169);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtTotal);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtSubTotal);
            this.panel5.Controls.Add(this.txtIV);
            this.panel5.Controls.Add(this.txtDescuentos);
            this.panel5.Location = new System.Drawing.Point(7, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(528, 92);
            this.panel5.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sub-Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descuento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Impuesto:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(467, 63);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(62, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(467, 3);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(62, 20);
            this.txtSubTotal.TabIndex = 4;
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(467, 43);
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(62, 20);
            this.txtIV.TabIndex = 6;
            // 
            // txtDescuentos
            // 
            this.txtDescuentos.Location = new System.Drawing.Point(467, 23);
            this.txtDescuentos.Name = "txtDescuentos";
            this.txtDescuentos.Size = new System.Drawing.Size(62, 20);
            this.txtDescuentos.TabIndex = 5;
            // 
            // btSalir
            // 
            this.btSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.Image = ((System.Drawing.Image)(resources.GetObject("btSalir.Image")));
            this.btSalir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalir.Location = new System.Drawing.Point(650, 100);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(64, 35);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "Salir";
            this.btSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btDel
            // 
            this.btDel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.Image = ((System.Drawing.Image)(resources.GetObject("btDel.Image")));
            this.btDel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDel.Location = new System.Drawing.Point(149, 100);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(57, 35);
            this.btDel.TabIndex = 2;
            this.btDel.Text = "Eliminar";
            this.btDel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btEdit
            // 
            this.btEdit.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEdit.Location = new System.Drawing.Point(74, 100);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(57, 35);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Modificar";
            this.btEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdd.Location = new System.Drawing.Point(3, 100);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(57, 35);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Agregar";
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.btBuscar);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.lb_NomClient);
            this.panel3.Controls.Add(this.txtCed);
            this.panel3.Controls.Add(this.lb_Ident);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.dgvProdFact);
            this.panel3.Location = new System.Drawing.Point(17, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(719, 167);
            this.panel3.TabIndex = 4;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(672, 23);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Turista";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(603, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Jurídico";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(543, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Físico";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btBuscar
            // 
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btBuscar.Image")));
            this.btBuscar.Location = new System.Drawing.Point(686, 52);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(32, 16);
            this.btBuscar.TabIndex = 6;
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "0";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Armando José Hernandez Gacía",
            "Diego Murillo Barrantes",
            "Henry Morales Gaitán",
            "Willian Blender Watson"});
            this.comboBox1.Location = new System.Drawing.Point(607, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // lb_NomClient
            // 
            this.lb_NomClient.AutoSize = true;
            this.lb_NomClient.Location = new System.Drawing.Point(540, 81);
            this.lb_NomClient.Name = "lb_NomClient";
            this.lb_NomClient.Size = new System.Drawing.Size(47, 13);
            this.lb_NomClient.TabIndex = 4;
            this.lb_NomClient.Text = "Nombre:";
            // 
            // txtCed
            // 
            this.txtCed.Location = new System.Drawing.Point(607, 52);
            this.txtCed.Name = "txtCed";
            this.txtCed.Size = new System.Drawing.Size(75, 20);
            this.txtCed.TabIndex = 3;
            // 
            // lb_Ident
            // 
            this.lb_Ident.AutoSize = true;
            this.lb_Ident.Location = new System.Drawing.Point(540, 55);
            this.lb_Ident.Name = "lb_Ident";
            this.lb_Ident.Size = new System.Drawing.Size(43, 13);
            this.lb_Ident.TabIndex = 2;
            this.lb_Ident.Text = "Cédula:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Datos Cliente";
            // 
            // dgvProdFact
            // 
            this.dgvProdFact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProdFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdFact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7});
            this.dgvProdFact.Location = new System.Drawing.Point(6, 3);
            this.dgvProdFact.Name = "dgvProdFact";
            this.dgvProdFact.Size = new System.Drawing.Size(528, 161);
            this.dgvProdFact.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Descripción";
            this.Column1.Name = "Column1";
            this.Column1.Width = 88;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Precio Unitario";
            this.Column3.Name = "Column3";
            this.Column3.Width = 101;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Impuesto";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Precio Total";
            this.Column6.Name = "Column6";
            this.Column6.Width = 89;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Código";
            this.Column7.Name = "Column7";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbDescripcion);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtCodInv);
            this.panel2.Location = new System.Drawing.Point(17, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 34);
            this.panel2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fecha Facturación:";
            // 
            // cbDescripcion
            // 
            this.cbDescripcion.FormattingEnabled = true;
            this.cbDescripcion.ItemHeight = 13;
            this.cbDescripcion.Items.AddRange(new object[] {
            "Cabina 1",
            "Cabina 2",
            "Cabina 3"});
            this.cbDescripcion.Location = new System.Drawing.Point(276, 7);
            this.cbDescripcion.Name = "cbDescripcion";
            this.cbDescripcion.Size = new System.Drawing.Size(138, 21);
            this.cbDescripcion.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Descripción:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(525, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código a Facturar:";
            // 
            // txtCodInv
            // 
            this.txtCodInv.Location = new System.Drawing.Point(103, 7);
            this.txtCodInv.Name = "txtCodInv";
            this.txtCodInv.Size = new System.Drawing.Size(98, 20);
            this.txtCodInv.TabIndex = 0;
            this.txtCodInv.Enter += new System.EventHandler(this.txtCodInv_Enter);
            this.txtCodInv.Leave += new System.EventHandler(this.txtCodInv_Leave);
            // 
            // Ven_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 395);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ven_Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ven_Facturacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdFact)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodInv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvProdFact;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.TextBox txtDescuentos;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lb_NomClient;
        private System.Windows.Forms.TextBox txtCed;
        private System.Windows.Forms.Label lb_Ident;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}