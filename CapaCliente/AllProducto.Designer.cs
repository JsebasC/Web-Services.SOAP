
namespace CapaCliente
{
    partial class AllProducto
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.delete = new System.Windows.Forms.Button();
            this.labelid = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtVentaProd = new System.Windows.Forms.TextBox();
            this.txtDescripcionProd = new System.Windows.Forms.TextBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMinProd = new System.Windows.Forms.TextBox();
            this.txtMaxProd = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(615, 83);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(112, 38);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Producto";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete.Location = new System.Drawing.Point(828, 454);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(181, 58);
            this.delete.TabIndex = 24;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F);
            this.labelid.Location = new System.Drawing.Point(755, 77);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(41, 44);
            this.labelid.TabIndex = 23;
            this.labelid.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Location = new System.Drawing.Point(615, 454);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 58);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtVentaProd
            // 
            this.txtVentaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtVentaProd.Location = new System.Drawing.Point(729, 300);
            this.txtVentaProd.Name = "txtVentaProd";
            this.txtVentaProd.Size = new System.Drawing.Size(280, 34);
            this.txtVentaProd.TabIndex = 21;
            // 
            // txtDescripcionProd
            // 
            this.txtDescripcionProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtDescripcionProd.Location = new System.Drawing.Point(729, 251);
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.Size = new System.Drawing.Size(280, 34);
            this.txtDescripcionProd.TabIndex = 20;
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtNombreProd.Location = new System.Drawing.Point(729, 202);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(280, 34);
            this.txtNombreProd.TabIndex = 19;
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtCodigoProd.Location = new System.Drawing.Point(729, 150);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Size = new System.Drawing.Size(280, 34);
            this.txtCodigoProd.TabIndex = 18;
            this.txtCodigoProd.TextChanged += new System.EventHandler(this.txtCodigoProd_TextChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(592, 300);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(128, 28);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Precio Venta :";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(599, 251);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(121, 28);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Descripcion :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(630, 202);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 28);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Nombre :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(642, 150);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 28);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Codigo :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(651, 359);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 28);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "Stock :";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // txtMinProd
            // 
            this.txtMinProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtMinProd.Location = new System.Drawing.Point(729, 353);
            this.txtMinProd.Name = "txtMinProd";
            this.txtMinProd.Size = new System.Drawing.Size(136, 34);
            this.txtMinProd.TabIndex = 27;
            this.txtMinProd.TextChanged += new System.EventHandler(this.txtMinProd_TextChanged);
            // 
            // txtMaxProd
            // 
            this.txtMaxProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtMaxProd.Location = new System.Drawing.Point(877, 353);
            this.txtMaxProd.Name = "txtMaxProd";
            this.txtMaxProd.Size = new System.Drawing.Size(132, 34);
            this.txtMaxProd.TabIndex = 28;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(910, 395);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(78, 28);
            this.labelControl7.TabIndex = 29;
            this.labelControl7.Text = "Maximo ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(763, 393);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(72, 28);
            this.labelControl8.TabIndex = 30;
            this.labelControl8.Text = "Minimo ";
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(30, 49);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.RowTemplate.Height = 24;
            this.dataGridViewProductos.Size = new System.Drawing.Size(529, 463);
            this.dataGridViewProductos.TabIndex = 31;
            this.dataGridViewProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.llenarInputs);
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            // 
            // AllProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 537);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtMaxProd);
            this.Controls.Add(this.txtMinProd);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtVentaProd);
            this.Controls.Add(this.txtDescripcionProd);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.txtCodigoProd);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllProducto";
            this.Text = "AllProducto";
            this.Load += new System.EventHandler(this.AllProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtVentaProd;
        private System.Windows.Forms.TextBox txtDescripcionProd;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.TextBox txtCodigoProd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtMinProd;
        private System.Windows.Forms.TextBox txtMaxProd;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
    }
}