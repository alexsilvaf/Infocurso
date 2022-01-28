
namespace Infocurso.Forms
{
    partial class Videos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Videos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.wb1 = new System.Windows.Forms.WebBrowser();
            this.lblTituloAula = new System.Windows.Forms.Label();
            this.pnlVideo = new System.Windows.Forms.Panel();
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.ptbAdicionar = new System.Windows.Forms.PictureBox();
            this.ptbEditar = new System.Windows.Forms.PictureBox();
            this.ptbExcluir = new System.Windows.Forms.PictureBox();
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlVoltar = new System.Windows.Forms.Panel();
            this.ptbVoltarR = new System.Windows.Forms.PictureBox();
            this.ptbVoltar = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tlpVideo = new System.Windows.Forms.TableLayoutPanel();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbExcluirR = new System.Windows.Forms.PictureBox();
            this.ptbEditarR = new System.Windows.Forms.PictureBox();
            this.ptbAdicionarR = new System.Windows.Forms.PictureBox();
            this.ptbAulasB = new System.Windows.Forms.PictureBox();
            this.ptbAulas = new System.Windows.Forms.PictureBox();
            this.pnlMenuAulas = new System.Windows.Forms.Panel();
            this.pnlAulas = new System.Windows.Forms.Panel();
            this.dgvAulas = new System.Windows.Forms.DataGridView();
            this.clNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAulas = new System.Windows.Forms.Label();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.pnlVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExcluir)).BeginInit();
            this.tlpForm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlVoltar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVoltarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVoltar)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.tlpVideo.SuspendLayout();
            this.tlpControls.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExcluirR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEditarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdicionarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAulasB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAulas)).BeginInit();
            this.pnlMenuAulas.SuspendLayout();
            this.pnlAulas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).BeginInit();
            this.tlpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // wb1
            // 
            this.wb1.Location = new System.Drawing.Point(247, 112);
            this.wb1.Name = "wb1";
            this.wb1.Size = new System.Drawing.Size(540, 285);
            this.wb1.TabIndex = 10;
            // 
            // lblTituloAula
            // 
            this.lblTituloAula.AutoSize = true;
            this.lblTituloAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblTituloAula.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTituloAula.Location = new System.Drawing.Point(168, 10);
            this.lblTituloAula.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTituloAula.MaximumSize = new System.Drawing.Size(388, 0);
            this.lblTituloAula.Name = "lblTituloAula";
            this.lblTituloAula.Size = new System.Drawing.Size(65, 25);
            this.lblTituloAula.TabIndex = 4;
            this.lblTituloAula.Text = "Titulo";
            this.lblTituloAula.UseMnemonic = false;
            // 
            // pnlVideo
            // 
            this.pnlVideo.Controls.Add(this.wmpVideo);
            this.pnlVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVideo.Location = new System.Drawing.Point(168, 3);
            this.pnlVideo.Name = "pnlVideo";
            this.pnlVideo.Size = new System.Drawing.Size(325, 285);
            this.pnlVideo.TabIndex = 0;
            // 
            // wmpVideo
            // 
            this.wmpVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(0, 0);
            this.wmpVideo.Margin = new System.Windows.Forms.Padding(0);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(325, 285);
            this.wmpVideo.TabIndex = 0;
            // 
            // ptbAdicionar
            // 
            this.ptbAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ptbAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("ptbAdicionar.Image")));
            this.ptbAdicionar.Location = new System.Drawing.Point(3, 55);
            this.ptbAdicionar.Margin = new System.Windows.Forms.Padding(3, 3, 5, 1);
            this.ptbAdicionar.Name = "ptbAdicionar";
            this.ptbAdicionar.Size = new System.Drawing.Size(40, 40);
            this.ptbAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbAdicionar.TabIndex = 12;
            this.ptbAdicionar.TabStop = false;
            this.ptbAdicionar.Visible = false;
            this.ptbAdicionar.MouseEnter += new System.EventHandler(this.ptbAdicionar_MouseEnter);
            // 
            // ptbEditar
            // 
            this.ptbEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ptbEditar.Image = ((System.Drawing.Image)(resources.GetObject("ptbEditar.Image")));
            this.ptbEditar.Location = new System.Drawing.Point(53, 55);
            this.ptbEditar.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.ptbEditar.Name = "ptbEditar";
            this.ptbEditar.Size = new System.Drawing.Size(40, 40);
            this.ptbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbEditar.TabIndex = 11;
            this.ptbEditar.TabStop = false;
            this.ptbEditar.Visible = false;
            this.ptbEditar.MouseEnter += new System.EventHandler(this.ptbEditar_MouseEnter);
            // 
            // ptbExcluir
            // 
            this.ptbExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ptbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("ptbExcluir.Image")));
            this.ptbExcluir.Location = new System.Drawing.Point(103, 55);
            this.ptbExcluir.Margin = new System.Windows.Forms.Padding(5, 1, 3, 1);
            this.ptbExcluir.Name = "ptbExcluir";
            this.ptbExcluir.Size = new System.Drawing.Size(40, 40);
            this.ptbExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbExcluir.TabIndex = 13;
            this.ptbExcluir.TabStop = false;
            this.ptbExcluir.Visible = false;
            this.ptbExcluir.MouseEnter += new System.EventHandler(this.ptbExcluir_MouseEnter);
            // 
            // tlpForm
            // 
            this.tlpForm.ColumnCount = 1;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpForm.Controls.Add(this.tlpVideo, 0, 1);
            this.tlpForm.Controls.Add(this.tlpControls, 0, 2);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 3;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpForm.Size = new System.Drawing.Size(663, 486);
            this.tlpForm.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Controls.Add(this.pnlVoltar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlTitulo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(663, 97);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // pnlVoltar
            // 
            this.pnlVoltar.Controls.Add(this.ptbVoltarR);
            this.pnlVoltar.Controls.Add(this.ptbVoltar);
            this.pnlVoltar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVoltar.Location = new System.Drawing.Point(0, 0);
            this.pnlVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlVoltar.Name = "pnlVoltar";
            this.pnlVoltar.Size = new System.Drawing.Size(66, 97);
            this.pnlVoltar.TabIndex = 5;
            // 
            // ptbVoltarR
            // 
            this.ptbVoltarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbVoltarR.Image = ((System.Drawing.Image)(resources.GetObject("ptbVoltarR.Image")));
            this.ptbVoltarR.Location = new System.Drawing.Point(10, 10);
            this.ptbVoltarR.Margin = new System.Windows.Forms.Padding(0);
            this.ptbVoltarR.Name = "ptbVoltarR";
            this.ptbVoltarR.Size = new System.Drawing.Size(32, 32);
            this.ptbVoltarR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbVoltarR.TabIndex = 1;
            this.ptbVoltarR.TabStop = false;
            this.ptbVoltarR.Visible = false;
            this.ptbVoltarR.Click += new System.EventHandler(this.ptbVoltarR_Click);
            this.ptbVoltarR.MouseLeave += new System.EventHandler(this.ptbVoltarR_MouseLeave);
            // 
            // ptbVoltar
            // 
            this.ptbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("ptbVoltar.Image")));
            this.ptbVoltar.Location = new System.Drawing.Point(10, 10);
            this.ptbVoltar.Name = "ptbVoltar";
            this.ptbVoltar.Size = new System.Drawing.Size(32, 32);
            this.ptbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbVoltar.TabIndex = 0;
            this.ptbVoltar.TabStop = false;
            this.ptbVoltar.MouseEnter += new System.EventHandler(this.ptbVoltar_MouseEnter);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitulo.Location = new System.Drawing.Point(66, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(597, 97);
            this.pnlTitulo.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(14, 9);
            this.lblTitulo.MaximumSize = new System.Drawing.Size(510, 80);
            this.lblTitulo.MinimumSize = new System.Drawing.Size(510, 80);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(510, 80);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.UseMnemonic = false;
            // 
            // tlpVideo
            // 
            this.tlpVideo.ColumnCount = 3;
            this.tlpVideo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVideo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVideo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVideo.Controls.Add(this.pnlVideo, 1, 0);
            this.tlpVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVideo.Location = new System.Drawing.Point(0, 97);
            this.tlpVideo.Margin = new System.Windows.Forms.Padding(0);
            this.tlpVideo.Name = "tlpVideo";
            this.tlpVideo.RowCount = 1;
            this.tlpVideo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVideo.Size = new System.Drawing.Size(663, 291);
            this.tlpVideo.TabIndex = 6;
            // 
            // tlpControls
            // 
            this.tlpControls.ColumnCount = 3;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpControls.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tlpControls.Controls.Add(this.lblTituloAula, 1, 0);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(0, 388);
            this.tlpControls.Margin = new System.Windows.Forms.Padding(0);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 1;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.Size = new System.Drawing.Size(663, 98);
            this.tlpControls.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(165, 98);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbExcluirR);
            this.panel1.Controls.Add(this.ptbEditarR);
            this.panel1.Controls.Add(this.ptbAdicionarR);
            this.panel1.Controls.Add(this.ptbExcluir);
            this.panel1.Controls.Add(this.ptbAdicionar);
            this.panel1.Controls.Add(this.ptbEditar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 98);
            this.panel1.TabIndex = 6;
            // 
            // ptbExcluirR
            // 
            this.ptbExcluirR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ptbExcluirR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExcluirR.Image = ((System.Drawing.Image)(resources.GetObject("ptbExcluirR.Image")));
            this.ptbExcluirR.Location = new System.Drawing.Point(103, 55);
            this.ptbExcluirR.Margin = new System.Windows.Forms.Padding(5, 1, 3, 1);
            this.ptbExcluirR.Name = "ptbExcluirR";
            this.ptbExcluirR.Size = new System.Drawing.Size(40, 40);
            this.ptbExcluirR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbExcluirR.TabIndex = 15;
            this.ptbExcluirR.TabStop = false;
            this.ptbExcluirR.Visible = false;
            this.ptbExcluirR.Click += new System.EventHandler(this.ptbExcluirR_Click);
            this.ptbExcluirR.MouseLeave += new System.EventHandler(this.ptbExcluirR_MouseLeave);
            // 
            // ptbEditarR
            // 
            this.ptbEditarR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ptbEditarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbEditarR.Image = ((System.Drawing.Image)(resources.GetObject("ptbEditarR.Image")));
            this.ptbEditarR.Location = new System.Drawing.Point(53, 55);
            this.ptbEditarR.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.ptbEditarR.Name = "ptbEditarR";
            this.ptbEditarR.Size = new System.Drawing.Size(40, 40);
            this.ptbEditarR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbEditarR.TabIndex = 16;
            this.ptbEditarR.TabStop = false;
            this.ptbEditarR.Visible = false;
            this.ptbEditarR.Click += new System.EventHandler(this.ptbEditarR_Click);
            this.ptbEditarR.MouseLeave += new System.EventHandler(this.ptbEditarR_MouseLeave);
            // 
            // ptbAdicionarR
            // 
            this.ptbAdicionarR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ptbAdicionarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAdicionarR.Image = ((System.Drawing.Image)(resources.GetObject("ptbAdicionarR.Image")));
            this.ptbAdicionarR.Location = new System.Drawing.Point(3, 55);
            this.ptbAdicionarR.Margin = new System.Windows.Forms.Padding(3, 3, 5, 1);
            this.ptbAdicionarR.Name = "ptbAdicionarR";
            this.ptbAdicionarR.Size = new System.Drawing.Size(40, 40);
            this.ptbAdicionarR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbAdicionarR.TabIndex = 14;
            this.ptbAdicionarR.TabStop = false;
            this.ptbAdicionarR.Visible = false;
            this.ptbAdicionarR.Click += new System.EventHandler(this.ptbAdicionarR_Click);
            this.ptbAdicionarR.MouseLeave += new System.EventHandler(this.ptbAdicionarR_MouseLeave);
            // 
            // ptbAulasB
            // 
            this.ptbAulasB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAulasB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbAulasB.Image = ((System.Drawing.Image)(resources.GetObject("ptbAulasB.Image")));
            this.ptbAulasB.Location = new System.Drawing.Point(0, 0);
            this.ptbAulasB.Margin = new System.Windows.Forms.Padding(0);
            this.ptbAulasB.Name = "ptbAulasB";
            this.ptbAulasB.Size = new System.Drawing.Size(32, 32);
            this.ptbAulasB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbAulasB.TabIndex = 2;
            this.ptbAulasB.TabStop = false;
            this.ptbAulasB.Visible = false;
            this.ptbAulasB.Click += new System.EventHandler(this.ptbAulasB_Click);
            this.ptbAulasB.MouseLeave += new System.EventHandler(this.ptbAulasB_MouseLeave);
            // 
            // ptbAulas
            // 
            this.ptbAulas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbAulas.Image = ((System.Drawing.Image)(resources.GetObject("ptbAulas.Image")));
            this.ptbAulas.Location = new System.Drawing.Point(0, 0);
            this.ptbAulas.Margin = new System.Windows.Forms.Padding(0);
            this.ptbAulas.Name = "ptbAulas";
            this.ptbAulas.Size = new System.Drawing.Size(32, 32);
            this.ptbAulas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbAulas.TabIndex = 3;
            this.ptbAulas.TabStop = false;
            this.ptbAulas.MouseEnter += new System.EventHandler(this.ptbAulas_MouseEnter);
            // 
            // pnlMenuAulas
            // 
            this.pnlMenuAulas.Controls.Add(this.ptbAulasB);
            this.pnlMenuAulas.Controls.Add(this.ptbAulas);
            this.pnlMenuAulas.Location = new System.Drawing.Point(631, 336);
            this.pnlMenuAulas.Name = "pnlMenuAulas";
            this.pnlMenuAulas.Size = new System.Drawing.Size(32, 32);
            this.pnlMenuAulas.TabIndex = 5;
            // 
            // pnlAulas
            // 
            this.pnlAulas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.pnlAulas.Controls.Add(this.dgvAulas);
            this.pnlAulas.Controls.Add(this.lblAulas);
            this.pnlAulas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAulas.Location = new System.Drawing.Point(0, 0);
            this.pnlAulas.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAulas.MaximumSize = new System.Drawing.Size(231, 0);
            this.pnlAulas.MinimumSize = new System.Drawing.Size(231, 0);
            this.pnlAulas.Name = "pnlAulas";
            this.pnlAulas.Size = new System.Drawing.Size(231, 486);
            this.pnlAulas.TabIndex = 6;
            // 
            // dgvAulas
            // 
            this.dgvAulas.AllowUserToAddRows = false;
            this.dgvAulas.AllowUserToDeleteRows = false;
            this.dgvAulas.AllowUserToResizeColumns = false;
            this.dgvAulas.AllowUserToResizeRows = false;
            this.dgvAulas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAulas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.dgvAulas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAulas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulas.ColumnHeadersVisible = false;
            this.dgvAulas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNome});
            this.dgvAulas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAulas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAulas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.dgvAulas.Location = new System.Drawing.Point(3, 88);
            this.dgvAulas.Margin = new System.Windows.Forms.Padding(0);
            this.dgvAulas.MultiSelect = false;
            this.dgvAulas.Name = "dgvAulas";
            this.dgvAulas.ReadOnly = true;
            this.dgvAulas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAulas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAulas.RowHeadersVisible = false;
            this.dgvAulas.RowTemplate.Height = 45;
            this.dgvAulas.Size = new System.Drawing.Size(226, 355);
            this.dgvAulas.TabIndex = 0;
            this.dgvAulas.Click += new System.EventHandler(this.dgvAulas_Click);
            // 
            // clNome
            // 
            this.clNome.HeaderText = "";
            this.clNome.Name = "clNome";
            this.clNome.ReadOnly = true;
            this.clNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lblAulas
            // 
            this.lblAulas.AutoSize = true;
            this.lblAulas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.lblAulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblAulas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAulas.Location = new System.Drawing.Point(71, 21);
            this.lblAulas.Name = "lblAulas";
            this.lblAulas.Size = new System.Drawing.Size(98, 37);
            this.lblAulas.TabIndex = 5;
            this.lblAulas.Text = "Aulas";
            // 
            // tlpMenu
            // 
            this.tlpMenu.ColumnCount = 1;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenu.Controls.Add(this.pnlAulas, 0, 0);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlpMenu.Location = new System.Drawing.Point(663, 0);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenu.Size = new System.Drawing.Size(223, 486);
            this.tlpMenu.TabIndex = 4;
            this.tlpMenu.Visible = false;
            // 
            // Videos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(886, 486);
            this.Controls.Add(this.pnlMenuAulas);
            this.Controls.Add(this.tlpForm);
            this.Controls.Add(this.tlpMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Videos";
            this.Text = "Videos";
            this.Load += new System.EventHandler(this.Videos_Load);
            this.SizeChanged += new System.EventHandler(this.Videos_SizeChanged);
            this.pnlVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExcluir)).EndInit();
            this.tlpForm.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlVoltar.ResumeLayout(false);
            this.pnlVoltar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVoltarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVoltar)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.tlpVideo.ResumeLayout(false);
            this.tlpControls.ResumeLayout(false);
            this.tlpControls.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExcluirR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEditarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdicionarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAulasB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAulas)).EndInit();
            this.pnlMenuAulas.ResumeLayout(false);
            this.pnlMenuAulas.PerformLayout();
            this.pnlAulas.ResumeLayout(false);
            this.pnlAulas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).EndInit();
            this.tlpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTituloAula;
        private System.Windows.Forms.WebBrowser wb1;
        private System.Windows.Forms.Panel pnlVideo;
        private System.Windows.Forms.PictureBox ptbEditar;
        private System.Windows.Forms.PictureBox ptbAdicionar;
        private System.Windows.Forms.PictureBox ptbExcluir;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.PictureBox ptbAulasB;
        private System.Windows.Forms.PictureBox ptbAulas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlMenuAulas;
        private System.Windows.Forms.Panel pnlAulas;
        private System.Windows.Forms.DataGridView dgvAulas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNome;
        private System.Windows.Forms.Label lblAulas;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.TableLayoutPanel tlpVideo;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbEditarR;
        private System.Windows.Forms.PictureBox ptbExcluirR;
        private System.Windows.Forms.PictureBox ptbAdicionarR;
        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private System.Windows.Forms.Panel pnlVoltar;
        private System.Windows.Forms.PictureBox ptbVoltarR;
        private System.Windows.Forms.PictureBox ptbVoltar;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}