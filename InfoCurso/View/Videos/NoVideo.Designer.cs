
namespace Infocurso
{
    partial class NoVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoVideo));
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTituloAula = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlVoltar = new System.Windows.Forms.Panel();
            this.ptbVoltarR = new System.Windows.Forms.PictureBox();
            this.ptbVoltar = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlVoltar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVoltarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVoltar)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionar.Location = new System.Drawing.Point(320, 286);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAdicionar.Size = new System.Drawing.Size(245, 43);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Clique aqui para adicionar uma aula";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Visible = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnAdicionar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTituloAula, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 486);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // lblTituloAula
            // 
            this.lblTituloAula.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTituloAula.AutoSize = true;
            this.lblTituloAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAula.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTituloAula.Location = new System.Drawing.Point(188, 217);
            this.lblTituloAula.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblTituloAula.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblTituloAula.Name = "lblTituloAula";
            this.lblTituloAula.Size = new System.Drawing.Size(510, 29);
            this.lblTituloAula.TabIndex = 9;
            this.lblTituloAula.Text = "Este curso ainda não possui nenhuma aula";
            this.lblTituloAula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTituloAula.UseMnemonic = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Controls.Add(this.pnlVoltar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlTitulo, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(880, 115);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // pnlVoltar
            // 
            this.pnlVoltar.Controls.Add(this.ptbVoltarR);
            this.pnlVoltar.Controls.Add(this.ptbVoltar);
            this.pnlVoltar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVoltar.Location = new System.Drawing.Point(0, 0);
            this.pnlVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlVoltar.Name = "pnlVoltar";
            this.pnlVoltar.Size = new System.Drawing.Size(88, 115);
            this.pnlVoltar.TabIndex = 8;
            // 
            // ptbVoltarR
            // 
            this.ptbVoltarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbVoltarR.Image = ((System.Drawing.Image)(resources.GetObject("ptbVoltarR.Image")));
            this.ptbVoltarR.Location = new System.Drawing.Point(28, 41);
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
            this.ptbVoltar.Location = new System.Drawing.Point(28, 41);
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
            this.pnlTitulo.Location = new System.Drawing.Point(88, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(792, 115);
            this.pnlTitulo.TabIndex = 9;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(95, 24);
            this.lblTitulo.MaximumSize = new System.Drawing.Size(510, 80);
            this.lblTitulo.MinimumSize = new System.Drawing.Size(510, 80);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(510, 80);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.UseMnemonic = false;
            // 
            // NoVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(886, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NoVideo";
            this.Text = "NoVideo";
            this.Load += new System.EventHandler(this.NoVideo_Load);
            this.SizeChanged += new System.EventHandler(this.NoVideo_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlVoltar.ResumeLayout(false);
            this.pnlVoltar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVoltarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVoltar)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTituloAula;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnlVoltar;
        private System.Windows.Forms.PictureBox ptbVoltarR;
        private System.Windows.Forms.PictureBox ptbVoltar;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}