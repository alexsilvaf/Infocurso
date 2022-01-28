
namespace Infocurso
{
    partial class Usuarios
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
            this.dgvAlunoLista = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDtNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTelefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTelefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunoLista)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlunoLista
            // 
            this.dgvAlunoLista.AllowUserToAddRows = false;
            this.dgvAlunoLista.AllowUserToDeleteRows = false;
            this.dgvAlunoLista.AllowUserToResizeColumns = false;
            this.dgvAlunoLista.AllowUserToResizeRows = false;
            this.dgvAlunoLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlunoLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvAlunoLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlunoLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAlunoLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunoLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clNome,
            this.clEmail,
            this.clDtNasc,
            this.clTelefone1,
            this.clTelefone2,
            this.clRg,
            this.clCpf,
            this.clSexo});
            this.dgvAlunoLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlunoLista.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvAlunoLista.Location = new System.Drawing.Point(0, 0);
            this.dgvAlunoLista.Margin = new System.Windows.Forms.Padding(0);
            this.dgvAlunoLista.Name = "dgvAlunoLista";
            this.dgvAlunoLista.RowHeadersVisible = false;
            this.dgvAlunoLista.RowTemplate.Height = 25;
            this.dgvAlunoLista.Size = new System.Drawing.Size(880, 286);
            this.dgvAlunoLista.TabIndex = 3;
            // 
            // clId
            // 
            this.clId.FillWeight = 8F;
            this.clId.HeaderText = "Id";
            this.clId.Name = "clId";
            // 
            // clNome
            // 
            this.clNome.FillWeight = 70F;
            this.clNome.HeaderText = "Nome";
            this.clNome.Name = "clNome";
            // 
            // clEmail
            // 
            this.clEmail.FillWeight = 70F;
            this.clEmail.HeaderText = "Email";
            this.clEmail.Name = "clEmail";
            // 
            // clDtNasc
            // 
            this.clDtNasc.FillWeight = 21.9F;
            this.clDtNasc.HeaderText = "Data de Nascimento";
            this.clDtNasc.Name = "clDtNasc";
            // 
            // clTelefone1
            // 
            this.clTelefone1.FillWeight = 28F;
            this.clTelefone1.HeaderText = "Telefone 1";
            this.clTelefone1.MinimumWidth = 70;
            this.clTelefone1.Name = "clTelefone1";
            // 
            // clTelefone2
            // 
            this.clTelefone2.FillWeight = 28F;
            this.clTelefone2.HeaderText = "Telefone 2";
            this.clTelefone2.MinimumWidth = 70;
            this.clTelefone2.Name = "clTelefone2";
            // 
            // clRg
            // 
            this.clRg.FillWeight = 17F;
            this.clRg.HeaderText = "Rg";
            this.clRg.Name = "clRg";
            // 
            // clCpf
            // 
            this.clCpf.FillWeight = 25F;
            this.clCpf.HeaderText = "Cpf";
            this.clCpf.Name = "clCpf";
            // 
            // clSexo
            // 
            this.clSexo.FillWeight = 27.8616F;
            this.clSexo.HeaderText = "Sexo";
            this.clSexo.Name = "clSexo";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblInfo.Font = new System.Drawing.Font("Arial", 18F);
            this.lblInfo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblInfo.Location = new System.Drawing.Point(298, 130);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(285, 27);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Nenhum aluno registrado";
            this.lblInfo.Visible = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPesquisa.Location = new System.Drawing.Point(82, 74);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(437, 29);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisar.Location = new System.Drawing.Point(530, 74);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(86, 29);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitulo.Location = new System.Drawing.Point(195, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(226, 45);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Listar Usuários";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(135, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 108);
            this.panel1.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 486);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblInfo);
            this.panel2.Controls.Add(this.dgvAlunoLista);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 286);
            this.panel2.TabIndex = 16;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(886, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Usuarios";
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.Alunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunoLista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlunoLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDtNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTelefone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTelefone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSexo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}