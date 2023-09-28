namespace MiCalculadora
{
    partial class FrmCalculadora
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
            cmbOperacion = new ComboBox();
            rdbDecimal = new RadioButton();
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            lblResultado = new Label();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            txtPrimerOperador = new TextBox();
            txtSegundoOperador = new TextBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // cmbOperacion
            // 
            cmbOperacion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "+", "-", "/", "*" });
            cmbOperacion.Location = new Point(335, 311);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(144, 34);
            cmbOperacion.TabIndex = 8;
            cmbOperacion.SelectedIndexChanged += cmbOperacion_SelectedIndexChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Checked = true;
            rdbDecimal.Location = new Point(33, 42);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(85, 27);
            rdbDecimal.TabIndex = 1;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpSistema.Location = new Point(290, 146);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(234, 88);
            grpSistema.TabIndex = 2;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(121, 42);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(80, 27);
            rdbBinario.TabIndex = 2;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(45, 90);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 26);
            lblResultado.TabIndex = 3;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(45, 260);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(229, 38);
            lblPrimerOperador.TabIndex = 4;
            lblPrimerOperador.Text = "Primer operador:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacion.Location = new Point(335, 260);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(144, 38);
            lblOperacion.TabIndex = 5;
            lblOperacion.Text = "Operacion";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(529, 260);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(260, 38);
            lblSegundoOperador.TabIndex = 6;
            lblSegundoOperador.Text = "Segundo Operador:";
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperador.Location = new Point(78, 313);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(140, 30);
            txtPrimerOperador.TabIndex = 7;
            txtPrimerOperador.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperador.Location = new Point(576, 313);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(140, 30);
            txtSegundoOperador.TabIndex = 9;
            txtSegundoOperador.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // btnOperar
            // 
            btnOperar.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(45, 364);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(208, 68);
            btnOperar.TabIndex = 10;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(302, 364);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(208, 68);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(558, 364);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(208, 68);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 45);
            label1.Name = "label1";
            label1.Size = new Size(109, 26);
            label1.TabIndex = 13;
            label1.Text = "Resultado: ";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 461);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(txtSegundoOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(lblResultado);
            Controls.Add(grpSistema);
            Controls.Add(cmbOperacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Uriel Marles";
            FormClosing += FrmCalculadora_FormClosing;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOperacion;
        private RadioButton rdbDecimal;
        private GroupBox grpSistema;
        private RadioButton rdbBinario;
        private Label lblResultado;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private TextBox txtPrimerOperador;
        private TextBox txtSegundoOperador;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private Label label1;
    }
}