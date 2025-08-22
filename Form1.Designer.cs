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
            LlisatNumeros = new ListBox();
            label1 = new Label();
            tBDesde = new TextBox();
            tBAsta = new TextBox();
            lDesde = new Label();
            Hasta = new Label();
            BGenerarFuncion = new Button();
            SuspendLayout();
            // 
            // LlisatNumeros
            // 
            LlisatNumeros.FormattingEnabled = true;
            LlisatNumeros.ItemHeight = 15;
            LlisatNumeros.Location = new Point(348, 88);
            LlisatNumeros.Name = "LlisatNumeros";
            LlisatNumeros.Size = new Size(163, 229);
            LlisatNumeros.TabIndex = 0;
            LlisatNumeros.SelectedIndexChanged += LlisatNumeros_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 49);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista de Numeros";
            // 
            // tBDesde
            // 
            tBDesde.Location = new Point(91, 91);
            tBDesde.Name = "tBDesde";
            tBDesde.Size = new Size(97, 23);
            tBDesde.TabIndex = 2;
            // 
            // tBAsta
            // 
            tBAsta.Location = new Point(91, 131);
            tBAsta.Name = "tBAsta";
            tBAsta.Size = new Size(98, 23);
            tBAsta.TabIndex = 3;
            // 
            // lDesde
            // 
            lDesde.AutoSize = true;
            lDesde.Location = new Point(37, 91);
            lDesde.Name = "lDesde";
            lDesde.Size = new Size(39, 15);
            lDesde.TabIndex = 4;
            lDesde.Text = "Desde";
            // 
            // Hasta
            // 
            Hasta.AutoSize = true;
            Hasta.Location = new Point(39, 134);
            Hasta.Name = "Hasta";
            Hasta.Size = new Size(37, 15);
            Hasta.TabIndex = 5;
            Hasta.Text = "Hasta";
            // 
            // BGenerarFuncion
            // 
            BGenerarFuncion.BackColor = SystemColors.ActiveCaption;
            BGenerarFuncion.Location = new Point(210, 91);
            BGenerarFuncion.Name = "BGenerarFuncion";
            BGenerarFuncion.Size = new Size(122, 26);
            BGenerarFuncion.TabIndex = 6;
            BGenerarFuncion.Text = "Generar Funcion";
            BGenerarFuncion.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BGenerarFuncion);
            Controls.Add(Hasta);
            Controls.Add(lDesde);
            Controls.Add(tBAsta);
            Controls.Add(tBDesde);
            Controls.Add(label1);
            Controls.Add(LlisatNumeros);
            Name = "Form1";
            Text = "Formulario4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LlisatNumeros;
        private Label label1;
        private TextBox tBDesde;
        private TextBox tBAsta;
        private Label lDesde;
        private Label Hasta;
        private Button BGenerarFuncion;
    }
}
