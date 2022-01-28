
namespace Infocurso.Forms
{
    partial class CadastroCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCurso));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblSucesso = new System.Windows.Forms.Label();
            this.lblErroNomeCurso = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lbxCategoria = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbxNivel = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblErroCategoria = new System.Windows.Forms.Label();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.lblErroNivel = new System.Windows.Forms.Label();
            this.lblErroProfessor = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitulo.Location = new System.Drawing.Point(320, 39);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(245, 45);
            this.lblTitulo.TabIndex = 60;
            this.lblTitulo.Text = "Cadastrar Curso";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitulo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 486);
            this.tableLayoutPanel1.TabIndex = 93;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 100);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(880, 383);
            this.tableLayoutPanel2.TabIndex = 61;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnCategoria);
            this.panel7.Controls.Add(this.btnSalvar);
            this.panel7.Controls.Add(this.lblSucesso);
            this.panel7.Controls.Add(this.lblErroNomeCurso);
            this.panel7.Controls.Add(this.lblNome);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.txtNomeCurso);
            this.panel7.Controls.Add(this.lblProfessor);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.lblCategoria);
            this.panel7.Controls.Add(this.lbxCategoria);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.lbxNivel);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.txtDescricao);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.lblNivel);
            this.panel7.Controls.Add(this.lblDescricao);
            this.panel7.Controls.Add(this.lblErroCategoria);
            this.panel7.Controls.Add(this.txtProfessor);
            this.panel7.Controls.Add(this.txtCategoria);
            this.panel7.Controls.Add(this.txtNivel);
            this.panel7.Controls.Add(this.lblErroNivel);
            this.panel7.Controls.Add(this.lblErroProfessor);
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Controls.Add(this.pictureBox7);
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(880, 383);
            this.panel7.TabIndex = 83;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCategoria.Location = new System.Drawing.Point(525, 313);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(166, 36);
            this.btnCategoria.TabIndex = 7;
            this.btnCategoria.Text = "Adicionar Categoria";
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Visible = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(697, 313);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 36);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblSucesso
            // 
            this.lblSucesso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSucesso.AutoSize = true;
            this.lblSucesso.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSucesso.Location = new System.Drawing.Point(644, 353);
            this.lblSucesso.Name = "lblSucesso";
            this.lblSucesso.Size = new System.Drawing.Size(0, 13);
            this.lblSucesso.TabIndex = 82;
            // 
            // lblErroNomeCurso
            // 
            this.lblErroNomeCurso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErroNomeCurso.AutoSize = true;
            this.lblErroNomeCurso.ForeColor = System.Drawing.Color.Red;
            this.lblErroNomeCurso.Location = new System.Drawing.Point(85, 70);
            this.lblErroNomeCurso.Margin = new System.Windows.Forms.Padding(3, 0, 3, 22);
            this.lblErroNomeCurso.Name = "lblErroNomeCurso";
            this.lblErroNomeCurso.Size = new System.Drawing.Size(0, 13);
            this.lblErroNomeCurso.TabIndex = 93;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNome.Location = new System.Drawing.Point(89, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(123, 21);
            this.lblNome.TabIndex = 46;
            this.lblNome.Text = "Nome do Curso:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(82, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "*";
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeCurso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNomeCurso.Location = new System.Drawing.Point(91, 39);
            this.txtNomeCurso.Margin = new System.Windows.Forms.Padding(3, 3, 3, 35);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(701, 22);
            this.txtNomeCurso.TabIndex = 1;
            this.txtNomeCurso.WordWrap = false;
            // 
            // lblProfessor
            // 
            this.lblProfessor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblProfessor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblProfessor.Location = new System.Drawing.Point(91, 91);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(76, 21);
            this.lblProfessor.TabIndex = 49;
            this.lblProfessor.Text = "Professor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(85, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(713, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCategoria.Location = new System.Drawing.Point(521, 91);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 21);
            this.lblCategoria.TabIndex = 84;
            this.lblCategoria.Text = "Categoria";
            // 
            // lbxCategoria
            // 
            this.lbxCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbxCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxCategoria.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lbxCategoria.FormattingEnabled = true;
            this.lbxCategoria.ItemHeight = 20;
            this.lbxCategoria.Location = new System.Drawing.Point(516, 136);
            this.lbxCategoria.Name = "lbxCategoria";
            this.lbxCategoria.Size = new System.Drawing.Size(135, 100);
            this.lbxCategoria.TabIndex = 2;
            this.lbxCategoria.Visible = false;
            this.lbxCategoria.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxCategoria_MouseClick);
            this.lbxCategoria.SelectedIndexChanged += new System.EventHandler(this.lbxCategoria_TabIndexChanged);
            this.lbxCategoria.TabIndexChanged += new System.EventHandler(this.lbxCategoria_TabIndexChanged);
            this.lbxCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxCategoria_KeyDown);
            this.lbxCategoria.Leave += new System.EventHandler(this.lbxCategoria_Leave);
            this.lbxCategoria.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lbxCategoria_PreviewKeyDown);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(514, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 86;
            this.label8.Text = "*";
            // 
            // lbxNivel
            // 
            this.lbxNivel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbxNivel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxNivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxNivel.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lbxNivel.FormattingEnabled = true;
            this.lbxNivel.ItemHeight = 20;
            this.lbxNivel.Items.AddRange(new object[] {
            "Básico",
            "Intermediário",
            "Avançado"});
            this.lbxNivel.Location = new System.Drawing.Point(663, 136);
            this.lbxNivel.Name = "lbxNivel";
            this.lbxNivel.Size = new System.Drawing.Size(135, 100);
            this.lbxNivel.TabIndex = 4;
            this.lbxNivel.Visible = false;
            this.lbxNivel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxNivel_MouseClick);
            this.lbxNivel.SelectedIndexChanged += new System.EventHandler(this.lbxNivel_TabIndexChanged);
            this.lbxNivel.TabIndexChanged += new System.EventHandler(this.lbxNivel_TabIndexChanged);
            this.lbxNivel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxNivel_KeyDown);
            this.lbxNivel.Leave += new System.EventHandler(this.lbxNivel_Leave);
            this.lbxNivel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lbxNivel_PreviewKeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(661, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "*";
            // 
            // txtDescricao
            // 
            this.txtDescricao.AcceptsReturn = true;
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(90, 194);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 3, 3, 35);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(702, 81);
            this.txtDescricao.TabIndex = 5;
            this.txtDescricao.WordWrap = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // lblNivel
            // 
            this.lblNivel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNivel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNivel.Location = new System.Drawing.Point(667, 91);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(46, 21);
            this.lblNivel.TabIndex = 52;
            this.lblNivel.Text = "Nível";
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDescricao.Location = new System.Drawing.Point(91, 165);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 21);
            this.lblDescricao.TabIndex = 89;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblErroCategoria
            // 
            this.lblErroCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErroCategoria.AutoSize = true;
            this.lblErroCategoria.ForeColor = System.Drawing.Color.Red;
            this.lblErroCategoria.Location = new System.Drawing.Point(513, 147);
            this.lblErroCategoria.Margin = new System.Windows.Forms.Padding(3, 0, 3, 22);
            this.lblErroCategoria.Name = "lblErroCategoria";
            this.lblErroCategoria.Size = new System.Drawing.Size(0, 13);
            this.lblErroCategoria.TabIndex = 85;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProfessor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProfessor.Enabled = false;
            this.txtProfessor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtProfessor.Location = new System.Drawing.Point(94, 117);
            this.txtProfessor.Margin = new System.Windows.Forms.Padding(3, 3, 3, 35);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(396, 22);
            this.txtProfessor.TabIndex = 2;
            this.txtProfessor.TabStop = false;
            this.txtProfessor.WordWrap = false;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCategoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCategoria.Location = new System.Drawing.Point(523, 117);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(3, 3, 3, 26);
            this.txtCategoria.MaxLength = 16;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(121, 22);
            this.txtCategoria.TabIndex = 3;
            this.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCategoria.WordWrap = false;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            this.txtCategoria.Enter += new System.EventHandler(this.txtCategoria_Enter);
            this.txtCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoria_KeyPress);
            // 
            // txtNivel
            // 
            this.txtNivel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNivel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNivel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNivel.Location = new System.Drawing.Point(670, 117);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 26);
            this.txtNivel.MaxLength = 16;
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNivel.Size = new System.Drawing.Size(121, 22);
            this.txtNivel.TabIndex = 4;
            this.txtNivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNivel.WordWrap = false;
            this.txtNivel.Enter += new System.EventHandler(this.txtNivel_Enter);
            this.txtNivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNivel_KeyPress);
            // 
            // lblErroNivel
            // 
            this.lblErroNivel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErroNivel.AutoSize = true;
            this.lblErroNivel.ForeColor = System.Drawing.Color.Red;
            this.lblErroNivel.Location = new System.Drawing.Point(667, 147);
            this.lblErroNivel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 22);
            this.lblErroNivel.Name = "lblErroNivel";
            this.lblErroNivel.Size = new System.Drawing.Size(0, 13);
            this.lblErroNivel.TabIndex = 64;
            // 
            // lblErroProfessor
            // 
            this.lblErroProfessor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErroProfessor.AutoSize = true;
            this.lblErroProfessor.ForeColor = System.Drawing.Color.Red;
            this.lblErroProfessor.Location = new System.Drawing.Point(84, 147);
            this.lblErroProfessor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 22);
            this.lblErroProfessor.Name = "lblErroProfessor";
            this.lblErroProfessor.Size = new System.Drawing.Size(0, 13);
            this.lblErroProfessor.TabIndex = 63;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(84, 114);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(416, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(516, 114);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(135, 29);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 87;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(663, 114);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(135, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 75;
            this.pictureBox4.TabStop = false;
            // 
            // CadastroCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(886, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CadastroCurso";
            this.Text = "CadastroCurso";
            this.Load += new System.EventHandler(this.CadastroCurso_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CadastroCurso_MouseClick);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblSucesso;
        private System.Windows.Forms.Label lblErroNomeCurso;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ListBox lbxCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbxNivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblErroCategoria;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label lblErroNivel;
        private System.Windows.Forms.Label lblErroProfessor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnCategoria;
    }
}