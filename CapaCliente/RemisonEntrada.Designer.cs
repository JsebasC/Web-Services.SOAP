
namespace CapaCliente
{
    partial class RemisonEntrada
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dataGridViewRemisionEntrada = new System.Windows.Forms.DataGridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.idProveedor = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtAlmacen = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.grupoEstado = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelid = new DevExpress.XtraEditors.LabelControl();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemisionEntrada)).BeginInit();
            this.grupoEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtCodigo.Location = new System.Drawing.Point(776, 132);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(199, 32);
            this.txtCodigo.TabIndex = 2;
            // 
            // dataGridViewRemisionEntrada
            // 
            this.dataGridViewRemisionEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRemisionEntrada.Location = new System.Drawing.Point(12, 35);
            this.dataGridViewRemisionEntrada.Name = "dataGridViewRemisionEntrada";
            this.dataGridViewRemisionEntrada.RowHeadersWidth = 51;
            this.dataGridViewRemisionEntrada.RowTemplate.Height = 24;
            this.dataGridViewRemisionEntrada.Size = new System.Drawing.Size(587, 435);
            this.dataGridViewRemisionEntrada.TabIndex = 7;
            this.dataGridViewRemisionEntrada.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.remisionDetalleId);
            this.dataGridViewRemisionEntrada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(677, 132);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 30);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Codigo :";
            // 
            // idProveedor
            // 
            this.idProveedor.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProveedor.Appearance.Options.UseFont = true;
            this.idProveedor.Location = new System.Drawing.Point(617, 192);
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.Size = new System.Drawing.Size(143, 30);
            this.idProveedor.TabIndex = 9;
            this.idProveedor.Text = "id Proveedor :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(634, 242);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(125, 30);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "id Almacen :";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtProveedor.Location = new System.Drawing.Point(777, 190);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(199, 32);
            this.txtProveedor.TabIndex = 11;
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtAlmacen.Location = new System.Drawing.Point(776, 243);
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.Size = new System.Drawing.Size(199, 32);
            this.txtAlmacen.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Location = new System.Drawing.Point(665, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 58);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(836, 452);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 58);
            this.button3.TabIndex = 16;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(12, 495);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 60);
            this.button4.TabIndex = 17;
            this.button4.Text = "Remision Detalle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // grupoEstado
            // 
            this.grupoEstado.Controls.Add(this.radioButton3);
            this.grupoEstado.Controls.Add(this.radioButton2);
            this.grupoEstado.Controls.Add(this.radioButton1);
            this.grupoEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.grupoEstado.Location = new System.Drawing.Point(638, 296);
            this.grupoEstado.Name = "grupoEstado";
            this.grupoEstado.Size = new System.Drawing.Size(348, 144);
            this.grupoEstado.TabIndex = 21;
            this.grupoEstado.TabStop = false;
            this.grupoEstado.Text = "Estado";
            this.grupoEstado.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(27, 88);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(113, 30);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Anulada";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(191, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(146, 30);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Confirmada";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(138, 30);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Registrado";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(665, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(136, 30);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Id Remision :";
            // 
            // labelid
            // 
            this.labelid.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Appearance.Options.UseFont = true;
            this.labelid.Location = new System.Drawing.Point(817, 73);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(13, 30);
            this.labelid.TabIndex = 23;
            this.labelid.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(208, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 60);
            this.button1.TabIndex = 24;
            this.button1.Text = "Reporte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemisonEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1021, 596);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.grupoEstado);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAlmacen);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.idProveedor);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dataGridViewRemisionEntrada);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemisonEntrada";
            this.Text = "RemisonEntrada";
            this.Load += new System.EventHandler(this.RemisonEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemisionEntrada)).EndInit();
            this.grupoEstado.ResumeLayout(false);
            this.grupoEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dataGridViewRemisionEntrada;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl idProveedor;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtAlmacen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox grupoEstado;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelid;
        private System.Windows.Forms.Button button1;
    }
}