
namespace Presentacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.datag = new System.Windows.Forms.DataGridView();
            this.barra = new System.Windows.Forms.TextBox();
            this.busca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nombrer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apellidor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.generor = new System.Windows.Forms.ComboBox();
            this.estador = new System.Windows.Forms.ComboBox();
            this.telr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.correor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.direccionr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fecharr = new System.Windows.Forms.DateTimePicker();
            this.agregar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.advn = new System.Windows.Forms.Label();
            this.adva = new System.Windows.Forms.Label();
            this.advt = new System.Windows.Forms.Label();
            this.advf = new System.Windows.Forms.Label();
            this.cecreto = new System.Windows.Forms.Label();
            this.Editar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(325, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Contactos";
            // 
            // datag
            // 
            this.datag.AllowUserToAddRows = false;
            this.datag.AllowUserToDeleteRows = false;
            this.datag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datag.Location = new System.Drawing.Point(5, 144);
            this.datag.Name = "datag";
            this.datag.ReadOnly = true;
            this.datag.RowHeadersWidth = 51;
            this.datag.RowTemplate.Height = 24;
            this.datag.Size = new System.Drawing.Size(802, 529);
            this.datag.TabIndex = 1;
            this.datag.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datag_CellClick);
            // 
            // barra
            // 
            this.barra.Location = new System.Drawing.Point(12, 107);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(178, 22);
            this.barra.TabIndex = 2;
            // 
            // busca
            // 
            this.busca.Location = new System.Drawing.Point(187, 105);
            this.busca.Name = "busca";
            this.busca.Size = new System.Drawing.Size(33, 26);
            this.busca.TabIndex = 3;
            this.busca.Text = "🔍";
            this.busca.UseVisualStyleBackColor = true;
            this.busca.Click += new System.EventHandler(this.busca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(860, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // nombrer
            // 
            this.nombrer.BackColor = System.Drawing.Color.White;
            this.nombrer.Location = new System.Drawing.Point(863, 186);
            this.nombrer.Name = "nombrer";
            this.nombrer.Size = new System.Drawing.Size(100, 22);
            this.nombrer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1014, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // apellidor
            // 
            this.apellidor.BackColor = System.Drawing.Color.White;
            this.apellidor.Location = new System.Drawing.Point(1017, 186);
            this.apellidor.Name = "apellidor";
            this.apellidor.Size = new System.Drawing.Size(100, 22);
            this.apellidor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1014, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estado Civil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(860, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Genero";
            // 
            // generor
            // 
            this.generor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generor.FormattingEnabled = true;
            this.generor.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "otros"});
            this.generor.Location = new System.Drawing.Point(863, 271);
            this.generor.Name = "generor";
            this.generor.Size = new System.Drawing.Size(100, 24);
            this.generor.TabIndex = 12;
            // 
            // estador
            // 
            this.estador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estador.FormattingEnabled = true;
            this.estador.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a"});
            this.estador.Location = new System.Drawing.Point(1017, 271);
            this.estador.Name = "estador";
            this.estador.Size = new System.Drawing.Size(100, 24);
            this.estador.TabIndex = 13;
            // 
            // telr
            // 
            this.telr.BackColor = System.Drawing.Color.White;
            this.telr.Location = new System.Drawing.Point(863, 348);
            this.telr.Name = "telr";
            this.telr.Size = new System.Drawing.Size(100, 22);
            this.telr.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(860, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefono";
            // 
            // correor
            // 
            this.correor.BackColor = System.Drawing.Color.White;
            this.correor.Location = new System.Drawing.Point(1017, 348);
            this.correor.Name = "correor";
            this.correor.Size = new System.Drawing.Size(100, 22);
            this.correor.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1014, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Correo";
            // 
            // direccionr
            // 
            this.direccionr.BackColor = System.Drawing.Color.White;
            this.direccionr.Location = new System.Drawing.Point(862, 511);
            this.direccionr.MaxLength = 100;
            this.direccionr.Multiline = true;
            this.direccionr.Name = "direccionr";
            this.direccionr.Size = new System.Drawing.Size(254, 39);
            this.direccionr.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(949, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Dirección";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(909, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fecha de nacimineto";
            // 
            // fecharr
            // 
            this.fecharr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecharr.Location = new System.Drawing.Point(931, 426);
            this.fecharr.Name = "fecharr";
            this.fecharr.Size = new System.Drawing.Size(97, 22);
            this.fecharr.TabIndex = 21;
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(213)))), ((int)(((byte)(191)))));
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.agregar.Location = new System.Drawing.Point(952, 582);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(76, 41);
            this.agregar.TabIndex = 22;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(213)))), ((int)(((byte)(191)))));
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.guardar.Location = new System.Drawing.Point(899, 582);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(76, 41);
            this.guardar.TabIndex = 23;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Visible = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(213)))), ((int)(((byte)(191)))));
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.cancelar.Location = new System.Drawing.Point(996, 582);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(76, 41);
            this.cancelar.TabIndex = 24;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Visible = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // advn
            // 
            this.advn.AutoSize = true;
            this.advn.ForeColor = System.Drawing.Color.Red;
            this.advn.Location = new System.Drawing.Point(860, 211);
            this.advn.Name = "advn";
            this.advn.Size = new System.Drawing.Size(0, 17);
            this.advn.TabIndex = 25;
            // 
            // adva
            // 
            this.adva.AutoSize = true;
            this.adva.ForeColor = System.Drawing.Color.Red;
            this.adva.Location = new System.Drawing.Point(1014, 211);
            this.adva.Name = "adva";
            this.adva.Size = new System.Drawing.Size(0, 17);
            this.adva.TabIndex = 26;
            // 
            // advt
            // 
            this.advt.AutoSize = true;
            this.advt.ForeColor = System.Drawing.Color.Red;
            this.advt.Location = new System.Drawing.Point(843, 374);
            this.advt.Name = "advt";
            this.advt.Size = new System.Drawing.Size(0, 17);
            this.advt.TabIndex = 29;
            // 
            // advf
            // 
            this.advf.AutoSize = true;
            this.advf.ForeColor = System.Drawing.Color.Red;
            this.advf.Location = new System.Drawing.Point(928, 451);
            this.advf.Name = "advf";
            this.advf.Size = new System.Drawing.Size(0, 17);
            this.advf.TabIndex = 30;
            // 
            // cecreto
            // 
            this.cecreto.AutoSize = true;
            this.cecreto.Location = new System.Drawing.Point(12, 9);
            this.cecreto.Name = "cecreto";
            this.cecreto.Size = new System.Drawing.Size(0, 17);
            this.cecreto.TabIndex = 31;
            this.cecreto.Visible = false;
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(213)))), ((int)(((byte)(191)))));
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.Location = new System.Drawing.Point(635, 679);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(91, 29);
            this.Editar.TabIndex = 32;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Visible = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(117)))), ((int)(((byte)(76)))));
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.Location = new System.Drawing.Point(732, 679);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 29);
            this.Eliminar.TabIndex = 33;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Visible = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(174)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1145, 720);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.cecreto);
            this.Controls.Add(this.advf);
            this.Controls.Add(this.advt);
            this.Controls.Add(this.adva);
            this.Controls.Add(this.advn);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.fecharr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.direccionr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.correor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.telr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.estador);
            this.Controls.Add(this.generor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.apellidor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombrer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.datag);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datag;
        private System.Windows.Forms.TextBox barra;
        private System.Windows.Forms.Button busca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombrer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellidor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox generor;
        private System.Windows.Forms.ComboBox estador;
        private System.Windows.Forms.TextBox telr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox correor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox direccionr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker fecharr;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label advn;
        private System.Windows.Forms.Label adva;
        private System.Windows.Forms.Label advt;
        private System.Windows.Forms.Label advf;
        private System.Windows.Forms.Label cecreto;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Eliminar;
    }
}

