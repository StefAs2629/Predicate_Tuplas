namespace predicate_tuplas
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
            BtnTuplas = new Button();
            btnPredicate = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            lblNumero = new Label();
            txtNumeros = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnTuplas
            // 
            BtnTuplas.BackColor = Color.Yellow;
            BtnTuplas.Location = new Point(105, 66);
            BtnTuplas.Name = "BtnTuplas";
            BtnTuplas.Size = new Size(75, 23);
            BtnTuplas.TabIndex = 0;
            BtnTuplas.Text = "Tuplas";
            BtnTuplas.UseVisualStyleBackColor = false;
            BtnTuplas.Click += BtnTuplas_Click;
            // 
            // btnPredicate
            // 
            btnPredicate.BackColor = Color.Yellow;
            btnPredicate.Location = new Point(102, 117);
            btnPredicate.Name = "btnPredicate";
            btnPredicate.Size = new Size(100, 49);
            btnPredicate.TabIndex = 1;
            btnPredicate.Text = "Predicate";
            btnPredicate.UseVisualStyleBackColor = false;
            btnPredicate.Click += btnPredicate_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(105, 183);
            button3.Name = "button3";
            button3.Size = new Size(172, 49);
            button3.TabIndex = 2;
            button3.Text = "Tupla y Predicate";
            button3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNumeros);
            groupBox1.Controls.Add(lblNumero);
            groupBox1.Controls.Add(btnPredicate);
            groupBox1.Location = new Point(380, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 185);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(102, 34);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(90, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Ingresa numero";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(102, 62);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(100, 23);
            txtNumeros.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(BtnTuplas);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnTuplas;
        private Button btnPredicate;
        private Button button3;
        private GroupBox groupBox1;
        private TextBox txtNumeros;
        private Label lblNumero;
    }
}