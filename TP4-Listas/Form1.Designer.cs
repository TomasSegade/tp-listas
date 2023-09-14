
namespace TP4_Listas
{
    partial class Form1
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
            this.btn_regi = new System.Windows.Forms.Button();
            this.btn_elim = new System.Windows.Forms.Button();
            this.lbl_list = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_ape = new System.Windows.Forms.TextBox();
            this.txt_dir = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_ape = new System.Windows.Forms.Label();
            this.lbl_dir = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.btn_act = new System.Windows.Forms.Button();
            this.btn_agr_sig = new System.Windows.Forms.Button();
            this.lst_listaEnla = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_regi
            // 
            this.btn_regi.Location = new System.Drawing.Point(581, 336);
            this.btn_regi.Name = "btn_regi";
            this.btn_regi.Size = new System.Drawing.Size(195, 61);
            this.btn_regi.TabIndex = 4;
            this.btn_regi.Text = "Registrar";
            this.btn_regi.UseVisualStyleBackColor = true;
            this.btn_regi.Click += new System.EventHandler(this.btn_regi_Click);
            // 
            // btn_elim
            // 
            this.btn_elim.Location = new System.Drawing.Point(820, 336);
            this.btn_elim.Name = "btn_elim";
            this.btn_elim.Size = new System.Drawing.Size(195, 61);
            this.btn_elim.TabIndex = 5;
            this.btn_elim.Text = "Eliminar";
            this.btn_elim.UseVisualStyleBackColor = true;
            this.btn_elim.Click += new System.EventHandler(this.btn_elim_Click);
            // 
            // lbl_list
            // 
            this.lbl_list.AutoSize = true;
            this.lbl_list.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_list.Location = new System.Drawing.Point(12, 7);
            this.lbl_list.Name = "lbl_list";
            this.lbl_list.Size = new System.Drawing.Size(164, 22);
            this.lbl_list.TabIndex = 9;
            this.lbl_list.Text = "Lista de pacientes";
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nom.Location = new System.Drawing.Point(109, 336);
            this.txt_nom.MaxLength = 25;
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(251, 20);
            this.txt_nom.TabIndex = 0;
            // 
            // txt_ape
            // 
            this.txt_ape.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_ape.Location = new System.Drawing.Point(109, 377);
            this.txt_ape.MaxLength = 20;
            this.txt_ape.Name = "txt_ape";
            this.txt_ape.Size = new System.Drawing.Size(251, 20);
            this.txt_ape.TabIndex = 1;
            // 
            // txt_dir
            // 
            this.txt_dir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_dir.Location = new System.Drawing.Point(109, 420);
            this.txt_dir.MaxLength = 50;
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.Size = new System.Drawing.Size(251, 20);
            this.txt_dir.TabIndex = 2;
            // 
            // txt_tel
            // 
            this.txt_tel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_tel.Location = new System.Drawing.Point(109, 464);
            this.txt_tel.MaxLength = 10;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(251, 20);
            this.txt_tel.TabIndex = 3;
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.Location = new System.Drawing.Point(35, 338);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(60, 15);
            this.lbl_nom.TabIndex = 10;
            this.lbl_nom.Text = "Nombre:";
            // 
            // lbl_ape
            // 
            this.lbl_ape.AutoSize = true;
            this.lbl_ape.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ape.Location = new System.Drawing.Point(35, 379);
            this.lbl_ape.Name = "lbl_ape";
            this.lbl_ape.Size = new System.Drawing.Size(57, 15);
            this.lbl_ape.TabIndex = 11;
            this.lbl_ape.Text = "Apellido";
            // 
            // lbl_dir
            // 
            this.lbl_dir.AutoSize = true;
            this.lbl_dir.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dir.Location = new System.Drawing.Point(35, 422);
            this.lbl_dir.Name = "lbl_dir";
            this.lbl_dir.Size = new System.Drawing.Size(68, 15);
            this.lbl_dir.TabIndex = 12;
            this.lbl_dir.Text = "Direccion:";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tel.Location = new System.Drawing.Point(35, 466);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(62, 15);
            this.lbl_tel.TabIndex = 13;
            this.lbl_tel.Text = "Telefono:";
            // 
            // btn_act
            // 
            this.btn_act.Location = new System.Drawing.Point(581, 420);
            this.btn_act.Name = "btn_act";
            this.btn_act.Size = new System.Drawing.Size(195, 64);
            this.btn_act.TabIndex = 6;
            this.btn_act.Text = "Actualizar datos";
            this.btn_act.UseVisualStyleBackColor = true;
            this.btn_act.Click += new System.EventHandler(this.btn_act_Click);
            // 
            // btn_agr_sig
            // 
            this.btn_agr_sig.Location = new System.Drawing.Point(820, 420);
            this.btn_agr_sig.Name = "btn_agr_sig";
            this.btn_agr_sig.Size = new System.Drawing.Size(195, 64);
            this.btn_agr_sig.TabIndex = 7;
            this.btn_agr_sig.Text = "Agregar siguiente";
            this.btn_agr_sig.UseVisualStyleBackColor = true;
            this.btn_agr_sig.Click += new System.EventHandler(this.btn_agr_sig_Click);
            // 
            // lst_listaEnla
            // 
            this.lst_listaEnla.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lst_listaEnla.FormattingEnabled = true;
            this.lst_listaEnla.HorizontalScrollbar = true;
            this.lst_listaEnla.Location = new System.Drawing.Point(12, 32);
            this.lst_listaEnla.Name = "lst_listaEnla";
            this.lst_listaEnla.ScrollAlwaysVisible = true;
            this.lst_listaEnla.Size = new System.Drawing.Size(1003, 212);
            this.lst_listaEnla.TabIndex = 8;
            this.lst_listaEnla.SelectedIndexChanged += new System.EventHandler(this.lst_ListaEnla_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1053, 630);
            this.Controls.Add(this.lst_listaEnla);
            this.Controls.Add(this.btn_agr_sig);
            this.Controls.Add(this.btn_act);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.lbl_dir);
            this.Controls.Add(this.lbl_ape);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_dir);
            this.Controls.Add(this.txt_ape);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.lbl_list);
            this.Controls.Add(this.btn_elim);
            this.Controls.Add(this.btn_regi);
            this.Name = "Form1";
            this.Text = "Pacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regi;
        private System.Windows.Forms.Button btn_elim;
        private System.Windows.Forms.Label lbl_list;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_ape;
        private System.Windows.Forms.TextBox txt_dir;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_ape;
        private System.Windows.Forms.Label lbl_dir;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Button btn_act;
        private System.Windows.Forms.Button btn_agr_sig;
        private System.Windows.Forms.ListBox lst_listaEnla;
    }
}

