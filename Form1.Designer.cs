namespace practico4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LlistaNumeros = new ListBox();
            label1 = new Label();
            tBDesde = new TextBox();
            tBHasta = new TextBox();
            lDesde = new Label();
            Hasta = new Label();
            BGenerarFuncion = new Button();
            BNumerosPares = new Button();
            BNumerosImpares = new Button();
            Numeros = new Button();
            SuspendLayout();
            // 
            // LlistaNumeros
            // 
            LlistaNumeros.FormattingEnabled = true;
            LlistaNumeros.ItemHeight = 15;
            LlistaNumeros.Location = new Point(288, 40);
            LlistaNumeros.Name = "LlistaNumeros";
            LlistaNumeros.Size = new Size(163, 229);
            LlistaNumeros.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista de Numeros";
            // 
            // tBDesde
            // 
            tBDesde.Location = new Point(89, 60);
            tBDesde.Name = "tBDesde";
            tBDesde.Size = new Size(97, 23);
            tBDesde.TabIndex = 2;
            tBDesde.KeyPress += tBDesde_KeyPress;
            // 
            // tBHasta
            // 
            tBHasta.Location = new Point(89, 91);
            tBHasta.Name = "tBHasta";
            tBHasta.Size = new Size(98, 23);
            tBHasta.TabIndex = 3;
            tBHasta.KeyPress += tBHasta_KeyPress;
            // 
            // lDesde
            // 
            lDesde.AutoSize = true;
            lDesde.Location = new Point(32, 60);
            lDesde.Name = "lDesde";
            lDesde.Size = new Size(39, 15);
            lDesde.TabIndex = 4;
            lDesde.Text = "Desde";
            // 
            // Hasta
            // 
            Hasta.AutoSize = true;
            Hasta.Location = new Point(34, 94);
            Hasta.Name = "Hasta";
            Hasta.Size = new Size(37, 15);
            Hasta.TabIndex = 5;
            Hasta.Text = "Hasta";
            // 
            // BGenerarFuncion
            // 
            BGenerarFuncion.ForeColor = SystemColors.HotTrack;
            BGenerarFuncion.Location = new Point(89, 146);
            BGenerarFuncion.Name = "BGenerarFuncion";
            BGenerarFuncion.Size = new Size(111, 25);
            BGenerarFuncion.TabIndex = 6;
            BGenerarFuncion.Text = "Generar Funcion";
            BGenerarFuncion.UseVisualStyleBackColor = true;
            BGenerarFuncion.Click += BGenerarFuncion_Click;
            // 
            // BNumerosPares
            // 
            BNumerosPares.Location = new Point(91, 183);
            BNumerosPares.Name = "BNumerosPares";
            BNumerosPares.Size = new Size(109, 22);
            BNumerosPares.TabIndex = 7;
            BNumerosPares.Text = "Numeros Pares";
            BNumerosPares.UseVisualStyleBackColor = true;
            BNumerosPares.Click += BNumerosPares_Click;
            // 
            // BNumerosImpares
            // 
            BNumerosImpares.Location = new Point(91, 218);
            BNumerosImpares.Name = "BNumerosImpares";
            BNumerosImpares.Size = new Size(109, 23);
            BNumerosImpares.TabIndex = 8;
            BNumerosImpares.Text = "Numeros Impares";
            BNumerosImpares.UseVisualStyleBackColor = true;
            BNumerosImpares.Click += BNumerosImpares_Click;
            // 
            // Numeros
            // 
            Numeros.Location = new Point(95, 254);
            Numeros.Name = "Numeros";
            Numeros.Size = new Size(108, 22);
            Numeros.TabIndex = 9;
            Numeros.Text = "Numeros Primos";
            Numeros.UseVisualStyleBackColor = true;
            Numeros.Click += Numeros_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 366);
            Controls.Add(Numeros);
            Controls.Add(BNumerosImpares);
            Controls.Add(BNumerosPares);
            Controls.Add(BGenerarFuncion);
            Controls.Add(Hasta);
            Controls.Add(lDesde);
            Controls.Add(tBHasta);
            Controls.Add(tBDesde);
            Controls.Add(label1);
            Controls.Add(LlistaNumeros);
            Name = "Form1";
            Text = "Formulario4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LlistaNumeros;
        private Label label1;
        private TextBox tBDesde;
        private TextBox tBHasta;
        private Label lDesde;
        private Label Hasta;
        private Button BGenerarFuncion;
        private Button BNumerosPares;
        private Button BNumerosImpares;
        private Button Numeros;
    }
}
