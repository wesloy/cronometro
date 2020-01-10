namespace cronometro
{
    partial class frmCronometro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCronometro));
            this.lbCronometro = new System.Windows.Forms.Label();
            this.btIniciar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnZerar = new System.Windows.Forms.Button();
            this.rbProgressivo = new System.Windows.Forms.RadioButton();
            this.rbRegressivo = new System.Windows.Forms.RadioButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtAlerta = new System.Windows.Forms.MaskedTextBox();
            this.txtRegressivo = new System.Windows.Forms.MaskedTextBox();
            this.cbSilencioso = new System.Windows.Forms.CheckBox();
            this.cbAlertar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbCronometro
            // 
            this.lbCronometro.AutoSize = true;
            this.lbCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCronometro.ForeColor = System.Drawing.Color.White;
            this.lbCronometro.Location = new System.Drawing.Point(46, 9);
            this.lbCronometro.Name = "lbCronometro";
            this.lbCronometro.Size = new System.Drawing.Size(198, 51);
            this.lbCronometro.TabIndex = 0;
            this.lbCronometro.Text = "00:00:00";
            // 
            // btIniciar
            // 
            this.btIniciar.BackColor = System.Drawing.Color.YellowGreen;
            this.btIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIniciar.Location = new System.Drawing.Point(49, 178);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(64, 26);
            this.btIniciar.TabIndex = 1;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = false;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnPausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPausar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausar.Location = new System.Drawing.Point(113, 178);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(64, 26);
            this.btnPausar.TabIndex = 2;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = false;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnZerar
            // 
            this.btnZerar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnZerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZerar.Location = new System.Drawing.Point(177, 178);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(64, 26);
            this.btnZerar.TabIndex = 3;
            this.btnZerar.Text = "Zerar";
            this.btnZerar.UseVisualStyleBackColor = false;
            this.btnZerar.Click += new System.EventHandler(this.btnZerar_Click);
            // 
            // rbProgressivo
            // 
            this.rbProgressivo.AutoSize = true;
            this.rbProgressivo.ForeColor = System.Drawing.Color.White;
            this.rbProgressivo.Location = new System.Drawing.Point(57, 73);
            this.rbProgressivo.Name = "rbProgressivo";
            this.rbProgressivo.Size = new System.Drawing.Size(80, 17);
            this.rbProgressivo.TabIndex = 4;
            this.rbProgressivo.TabStop = true;
            this.rbProgressivo.Text = "Progressivo";
            this.rbProgressivo.UseVisualStyleBackColor = true;
            // 
            // rbRegressivo
            // 
            this.rbRegressivo.AutoSize = true;
            this.rbRegressivo.ForeColor = System.Drawing.Color.White;
            this.rbRegressivo.Location = new System.Drawing.Point(57, 96);
            this.rbRegressivo.Name = "rbRegressivo";
            this.rbRegressivo.Size = new System.Drawing.Size(81, 17);
            this.rbRegressivo.TabIndex = 5;
            this.rbRegressivo.TabStop = true;
            this.rbRegressivo.Text = "Regressivo:";
            this.rbRegressivo.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtAlerta
            // 
            this.txtAlerta.Location = new System.Drawing.Point(140, 118);
            this.txtAlerta.Mask = "00:00:00";
            this.txtAlerta.Name = "txtAlerta";
            this.txtAlerta.Size = new System.Drawing.Size(88, 20);
            this.txtAlerta.TabIndex = 9;
            this.txtAlerta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAlerta.ValidatingType = typeof(System.DateTime);
            // 
            // txtRegressivo
            // 
            this.txtRegressivo.Location = new System.Drawing.Point(140, 95);
            this.txtRegressivo.Mask = "00:00:00";
            this.txtRegressivo.Name = "txtRegressivo";
            this.txtRegressivo.Size = new System.Drawing.Size(88, 20);
            this.txtRegressivo.TabIndex = 10;
            this.txtRegressivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegressivo.ValidatingType = typeof(System.DateTime);
            // 
            // cbSilencioso
            // 
            this.cbSilencioso.AutoSize = true;
            this.cbSilencioso.ForeColor = System.Drawing.Color.White;
            this.cbSilencioso.Location = new System.Drawing.Point(58, 144);
            this.cbSilencioso.Name = "cbSilencioso";
            this.cbSilencioso.Size = new System.Drawing.Size(74, 17);
            this.cbSilencioso.TabIndex = 11;
            this.cbSilencioso.Text = "Silencioso";
            this.cbSilencioso.UseVisualStyleBackColor = true;
            // 
            // cbAlertar
            // 
            this.cbAlertar.AutoSize = true;
            this.cbAlertar.ForeColor = System.Drawing.Color.White;
            this.cbAlertar.Location = new System.Drawing.Point(58, 119);
            this.cbAlertar.Name = "cbAlertar";
            this.cbAlertar.Size = new System.Drawing.Size(59, 17);
            this.cbAlertar.TabIndex = 12;
            this.cbAlertar.Text = "Alertar:";
            this.cbAlertar.UseVisualStyleBackColor = true;
            // 
            // frmCronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(291, 216);
            this.Controls.Add(this.cbAlertar);
            this.Controls.Add(this.cbSilencioso);
            this.Controls.Add(this.txtRegressivo);
            this.Controls.Add(this.txtAlerta);
            this.Controls.Add(this.rbRegressivo);
            this.Controls.Add(this.rbProgressivo);
            this.Controls.Add(this.btnZerar);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.lbCronometro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCronometro";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Cronômetro :.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCronometro;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnZerar;
        private System.Windows.Forms.RadioButton rbProgressivo;
        private System.Windows.Forms.RadioButton rbRegressivo;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MaskedTextBox txtAlerta;
        private System.Windows.Forms.MaskedTextBox txtRegressivo;
        private System.Windows.Forms.CheckBox cbSilencioso;
        private System.Windows.Forms.CheckBox cbAlertar;
    }
}

