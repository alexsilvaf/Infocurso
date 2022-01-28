namespace Infocurso.Forms.VIdeos
{
    partial class EditAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAula));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFileVideo = new System.Windows.Forms.TextBox();
            this.ptbVoltarR = new System.Windows.Forms.PictureBox();
            this.ptbVoltar = new System.Windows.Forms.PictureBox();
            this.lblSucesso = new System.Windows.Forms.Label();
            this.txtNomeAula = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNomeAula = new System.Windows.Forms.Label();
            this.lblVideo = new System.Windows.Forms.Label();
            this.btnVideo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVoltarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 486);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtFileVideo);
            this.panel1.Controls.Add(this.ptbVoltarR);
            this.panel1.Controls.Add(this.ptbVoltar);
            this.panel1.Controls.Add(this.lblSucesso);
            this.panel1.Controls.Add(this.txtNomeAula);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.lblNomeAula);
            this.panel1.Controls.Add(this.lblVideo);
            this.panel1.Controls.Add(this.btnVideo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(133, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 405);
            this.panel1.TabIndex = 14;
            // 
            // txtFileVideo
            // 
            this.txtFileVideo.Enabled = false;
            this.txtFileVideo.Location = new System.Drawing.Point(163, 237);
            this.txtFileVideo.Name = "txtFileVideo";
            this.txtFileVideo.Size = new System.Drawing.Size(334, 20);
            this.txtFileVideo.TabIndex = 18;
            // 
            // ptbVoltarR
            // 
            this.ptbVoltarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbVoltarR.Image = ((System.Drawing.Image)(resources.GetObject("ptbVoltarR.Image")));
            this.ptbVoltarR.Location = new System.Drawing.Point(4, 4);
            this.ptbVoltarR.Name = "ptbVoltarR";
            this.ptbVoltarR.Size = new System.Drawing.Size(32, 32);
            this.ptbVoltarR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbVoltarR.TabIndex = 17;
            this.ptbVoltarR.TabStop = false;
            this.ptbVoltarR.Visible = false;
            this.ptbVoltarR.Click += new System.EventHandler(this.ptbVoltarR_Click);
            this.ptbVoltarR.MouseLeave += new System.EventHandler(this.ptbVoltar_MouseLeave);
            // 
            // ptbVoltar
            // 
            this.ptbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("ptbVoltar.Image")));
            this.ptbVoltar.Location = new System.Drawing.Point(4, 4);
            this.ptbVoltar.Name = "ptbVoltar";
            this.ptbVoltar.Size = new System.Drawing.Size(32, 32);
            this.ptbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbVoltar.TabIndex = 16;
            this.ptbVoltar.TabStop = false;
            this.ptbVoltar.MouseEnter += new System.EventHandler(this.ptbVoltar_MouseEnter);
            // 
            // lblSucesso
            // 
            this.lblSucesso.AutoSize = true;
            this.lblSucesso.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSucesso.Location = new System.Drawing.Point(37, 287);
            this.lblSucesso.Name = "lblSucesso";
            this.lblSucesso.Size = new System.Drawing.Size(0, 13);
            this.lblSucesso.TabIndex = 15;
            // 
            // txtNomeAula
            // 
            this.txtNomeAula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeAula.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNomeAula.Location = new System.Drawing.Point(171, 162);
            this.txtNomeAula.Margin = new System.Windows.Forms.Padding(3, 3, 3, 35);
            this.txtNomeAula.MaxLength = 50;
            this.txtNomeAula.Name = "txtNomeAula";
            this.txtNomeAula.Size = new System.Drawing.Size(399, 22);
            this.txtNomeAula.TabIndex = 10;
            this.txtNomeAula.WordWrap = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(40, 31);
            this.lblTitulo.MaximumSize = new System.Drawing.Size(463, 56);
            this.lblTitulo.MinimumSize = new System.Drawing.Size(537, 56);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(537, 56);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.UseMnemonic = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(249, 322);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(118, 33);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblNomeAula
            // 
            this.lblNomeAula.AutoSize = true;
            this.lblNomeAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomeAula.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomeAula.Location = new System.Drawing.Point(36, 163);
            this.lblNomeAula.Name = "lblNomeAula";
            this.lblNomeAula.Size = new System.Drawing.Size(113, 20);
            this.lblNomeAula.TabIndex = 7;
            this.lblNomeAula.Text = "Nome da Aula:";
            this.lblNomeAula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNomeAula.UseMnemonic = false;
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVideo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVideo.Location = new System.Drawing.Point(36, 237);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(54, 20);
            this.lblVideo.TabIndex = 12;
            this.lblVideo.Text = "Video:";
            this.lblVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVideo.UseMnemonic = false;
            // 
            // btnVideo
            // 
            this.btnVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnVideo.FlatAppearance.BorderSize = 0;
            this.btnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVideo.Location = new System.Drawing.Point(503, 237);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(76, 20);
            this.btnVideo.TabIndex = 11;
            this.btnVideo.Text = "Adicionar";
            this.btnVideo.UseVisualStyleBackColor = false;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // EditAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(886, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditAula";
            this.Text = "EditAula";
            this.Load += new System.EventHandler(this.EditAula_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVoltarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFileVideo;
        private System.Windows.Forms.PictureBox ptbVoltarR;
        private System.Windows.Forms.PictureBox ptbVoltar;
        private System.Windows.Forms.Label lblSucesso;
        private System.Windows.Forms.TextBox txtNomeAula;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNomeAula;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalvar;
    }
}