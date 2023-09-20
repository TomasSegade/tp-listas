
namespace TP4_Listas
{
    partial class Form5
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_agregarCola = new System.Windows.Forms.Button();
            this.btn_cobrar = new System.Windows.Forms.Button();
            this.lbl_list = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_importe = new System.Windows.Forms.TextBox();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_imp = new System.Windows.Forms.Label();
            this.lst_listaEnla = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_agregarCola
            // 
            this.btn_agregarCola.Location = new System.Drawing.Point(170, 407);
            this.btn_agregarCola.Name = "btn_agregarCola";
            this.btn_agregarCola.Size = new System.Drawing.Size(118, 61);
            this.btn_agregarCola.TabIndex = 4;
            this.btn_agregarCola.Text = "Agregar a la cola";
            this.btn_agregarCola.UseVisualStyleBackColor = true;
            this.btn_agregarCola.Click += new System.EventHandler(this.btn_agregarCola_Click);
            // 
            // btn_cobrar
            // 
            this.btn_cobrar.Location = new System.Drawing.Point(170, 474);
            this.btn_cobrar.Name = "btn_cobrar";
            this.btn_cobrar.Size = new System.Drawing.Size(118, 61);
            this.btn_cobrar.TabIndex = 5;
            this.btn_cobrar.Text = "Cobrar";
            this.btn_cobrar.UseVisualStyleBackColor = true;
            this.btn_cobrar.Click += new System.EventHandler(this.btn_cobrar_Click);
            // 
            // lbl_list
            // 
            this.lbl_list.AutoSize = true;
            this.lbl_list.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_list.Location = new System.Drawing.Point(166, 9);
            this.lbl_list.Name = "lbl_list";
            this.lbl_list.Size = new System.Drawing.Size(179, 22);
            this.lbl_list.TabIndex = 9;
            this.lbl_list.Text = "Caja Supermercado";
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nom.Location = new System.Drawing.Point(170, 328);
            this.txt_nom.MaxLength = 25;
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(118, 20);
            this.txt_nom.TabIndex = 0;
            this.txt_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nom_KeyPress);
            // 
            // txt_importe
            // 
            this.txt_importe.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_importe.Location = new System.Drawing.Point(170, 369);
            this.txt_importe.MaxLength = 10;
            this.txt_importe.Name = "txt_importe";
            this.txt_importe.Size = new System.Drawing.Size(118, 20);
            this.txt_importe.TabIndex = 1;
            this.txt_importe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_importe_KeyPress);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.Location = new System.Drawing.Point(96, 330);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(60, 15);
            this.lbl_nom.TabIndex = 10;
            this.lbl_nom.Text = "Nombre:";
            // 
            // lbl_imp
            // 
            this.lbl_imp.AutoSize = true;
            this.lbl_imp.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_imp.Location = new System.Drawing.Point(96, 371);
            this.lbl_imp.Name = "lbl_imp";
            this.lbl_imp.Size = new System.Drawing.Size(57, 15);
            this.lbl_imp.TabIndex = 11;
            this.lbl_imp.Text = "Importe";
            // 
            // lst_listaEnla
            // 
            this.lst_listaEnla.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lst_listaEnla.FormattingEnabled = true;
            this.lst_listaEnla.HorizontalScrollbar = true;
            this.lst_listaEnla.Location = new System.Drawing.Point(84, 58);
            this.lst_listaEnla.Name = "lst_listaEnla";
            this.lst_listaEnla.ScrollAlwaysVisible = true;
            this.lst_listaEnla.Size = new System.Drawing.Size(329, 212);
            this.lst_listaEnla.TabIndex = 8;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(506, 575);
            this.Controls.Add(this.lst_listaEnla);
            this.Controls.Add(this.lbl_imp);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.txt_importe);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.lbl_list);
            this.Controls.Add(this.btn_cobrar);
            this.Controls.Add(this.btn_agregarCola);
            this.Name = "Form5";
            this.Text = "Sistema de cobranza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregarCola;
        private System.Windows.Forms.Button btn_cobrar;
        private System.Windows.Forms.Label lbl_list;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_importe;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_imp;
        private System.Windows.Forms.ListBox lst_listaEnla;
    }
}

