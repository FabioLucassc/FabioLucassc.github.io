
namespace Aula_60
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.tb_NomeVeiculo = new System.Windows.Forms.TextBox();
            this.lb_Veiculo = new System.Windows.Forms.Label();
            this.tb_ListaVeiculos = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_NomeVeiculo
            // 
            this.tb_NomeVeiculo.Location = new System.Drawing.Point(12, 40);
            this.tb_NomeVeiculo.Name = "tb_NomeVeiculo";
            this.tb_NomeVeiculo.Size = new System.Drawing.Size(167, 20);
            this.tb_NomeVeiculo.TabIndex = 1;
            // 
            // lb_Veiculo
            // 
            this.lb_Veiculo.AutoSize = true;
            this.lb_Veiculo.Location = new System.Drawing.Point(9, 8);
            this.lb_Veiculo.Name = "lb_Veiculo";
            this.lb_Veiculo.Size = new System.Drawing.Size(89, 13);
            this.lb_Veiculo.TabIndex = 3;
            this.lb_Veiculo.Text = "Digite um Veiculo";
            // 
            // tb_ListaVeiculos
            // 
            this.tb_ListaVeiculos.Location = new System.Drawing.Point(12, 75);
            this.tb_ListaVeiculos.Multiline = true;
            this.tb_ListaVeiculos.Name = "tb_ListaVeiculos";
            this.tb_ListaVeiculos.Size = new System.Drawing.Size(266, 264);
            this.tb_ListaVeiculos.TabIndex = 4;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(185, 40);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(93, 20);
            this.btn_Adicionar.TabIndex = 5;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 352);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.tb_ListaVeiculos);
            this.Controls.Add(this.lb_Veiculo);
            this.Controls.Add(this.tb_NomeVeiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_NomeVeiculo;
        private System.Windows.Forms.Label lb_Veiculo;
        private System.Windows.Forms.TextBox tb_ListaVeiculos;
        private System.Windows.Forms.Button btn_Adicionar;
    }
}

