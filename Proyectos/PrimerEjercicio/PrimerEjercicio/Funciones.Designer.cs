namespace PrimerEjercicio
{
    partial class Funciones
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
            this.numero1Label = new System.Windows.Forms.Label();
            this.numero2Label = new System.Windows.Forms.Label();
            this.numero1TextBox = new System.Windows.Forms.TextBox();
            this.numero2TextBox = new System.Windows.Forms.TextBox();
            this.resultadoTextBox = new System.Windows.Forms.TextBox();
            this.sumarButton = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.mostrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numero1Label
            // 
            this.numero1Label.AutoSize = true;
            this.numero1Label.Location = new System.Drawing.Point(110, 99);
            this.numero1Label.Name = "numero1Label";
            this.numero1Label.Size = new System.Drawing.Size(63, 15);
            this.numero1Label.TabIndex = 0;
            this.numero1Label.Text = "Número 1:";
            // 
            // numero2Label
            // 
            this.numero2Label.AutoSize = true;
            this.numero2Label.Location = new System.Drawing.Point(110, 170);
            this.numero2Label.Name = "numero2Label";
            this.numero2Label.Size = new System.Drawing.Size(63, 15);
            this.numero2Label.TabIndex = 1;
            this.numero2Label.Text = "Número 2:";
            // 
            // numero1TextBox
            // 
            this.numero1TextBox.Location = new System.Drawing.Point(223, 99);
            this.numero1TextBox.Name = "numero1TextBox";
            this.numero1TextBox.Size = new System.Drawing.Size(100, 23);
            this.numero1TextBox.TabIndex = 2;
            // 
            // numero2TextBox
            // 
            this.numero2TextBox.Location = new System.Drawing.Point(223, 167);
            this.numero2TextBox.Name = "numero2TextBox";
            this.numero2TextBox.Size = new System.Drawing.Size(100, 23);
            this.numero2TextBox.TabIndex = 3;
            // 
            // resultadoTextBox
            // 
            this.resultadoTextBox.Location = new System.Drawing.Point(343, 298);
            this.resultadoTextBox.Name = "resultadoTextBox";
            this.resultadoTextBox.Size = new System.Drawing.Size(100, 23);
            this.resultadoTextBox.TabIndex = 4;
            // 
            // sumarButton
            // 
            this.sumarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sumarButton.Location = new System.Drawing.Point(528, 141);
            this.sumarButton.Name = "sumarButton";
            this.sumarButton.Size = new System.Drawing.Size(75, 23);
            this.sumarButton.TabIndex = 5;
            this.sumarButton.Text = "SUMAR";
            this.sumarButton.UseVisualStyleBackColor = false;
            this.sumarButton.Click += new System.EventHandler(this.sumarButton_Click);
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Location = new System.Drawing.Point(243, 301);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(62, 15);
            this.resultadoLabel.TabIndex = 6;
            this.resultadoLabel.Text = "Resultado:";
            // 
            // mostrarButton
            // 
            this.mostrarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mostrarButton.Location = new System.Drawing.Point(528, 249);
            this.mostrarButton.Name = "mostrarButton";
            this.mostrarButton.Size = new System.Drawing.Size(75, 23);
            this.mostrarButton.TabIndex = 7;
            this.mostrarButton.Text = "Mostrar";
            this.mostrarButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mostrarButton);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.sumarButton);
            this.Controls.Add(this.resultadoTextBox);
            this.Controls.Add(this.numero2TextBox);
            this.Controls.Add(this.numero1TextBox);
            this.Controls.Add(this.numero2Label);
            this.Controls.Add(this.numero1Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label numero1Label;
        private Label numero2Label;
        private TextBox numero1TextBox;
        private TextBox numero2TextBox;
        private TextBox resultadoTextBox;
        private Button sumarButton;
        //private Button mostrarButton;//
        private Label resultadoLabel;
        private Button mostrarButton;
    }
}