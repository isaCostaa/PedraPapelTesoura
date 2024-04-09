namespace PedraPapelTesoura
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
            this.BtPedra = new System.Windows.Forms.Button();
            this.BtPapel = new System.Windows.Forms.Button();
            this.BtTesoura = new System.Windows.Forms.Button();
            this.PicJogador = new System.Windows.Forms.PictureBox();
            this.PicCPU = new System.Windows.Forms.PictureBox();
            this.LbDescricaoJogador = new System.Windows.Forms.Label();
            this.LbDescricaoCPU = new System.Windows.Forms.Label();
            this.LbPtJogador = new System.Windows.Forms.Label();
            this.LbPtCPU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // BtPedra
            // 
            this.BtPedra.BackColor = System.Drawing.Color.White;
            this.BtPedra.BackgroundImage = global::PedraPapelTesoura.Properties.Resources.PedraJ;
            this.BtPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtPedra.Location = new System.Drawing.Point(11, 250);
            this.BtPedra.Name = "BtPedra";
            this.BtPedra.Size = new System.Drawing.Size(127, 118);
            this.BtPedra.TabIndex = 0;
            this.BtPedra.Tag = "0";
            this.BtPedra.UseVisualStyleBackColor = false;
            this.BtPedra.Click += new System.EventHandler(this.ClickJogada);
            // 
            // BtPapel
            // 
            this.BtPapel.BackColor = System.Drawing.Color.White;
            this.BtPapel.BackgroundImage = global::PedraPapelTesoura.Properties.Resources.PapelJ;
            this.BtPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtPapel.Location = new System.Drawing.Point(169, 250);
            this.BtPapel.Name = "BtPapel";
            this.BtPapel.Size = new System.Drawing.Size(127, 118);
            this.BtPapel.TabIndex = 1;
            this.BtPapel.Tag = "1";
            this.BtPapel.UseVisualStyleBackColor = false;
            this.BtPapel.Click += new System.EventHandler(this.ClickJogada);
            // 
            // BtTesoura
            // 
            this.BtTesoura.BackColor = System.Drawing.Color.White;
            this.BtTesoura.BackgroundImage = global::PedraPapelTesoura.Properties.Resources.TesouraJ;
            this.BtTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtTesoura.Location = new System.Drawing.Point(327, 250);
            this.BtTesoura.Name = "BtTesoura";
            this.BtTesoura.Size = new System.Drawing.Size(127, 118);
            this.BtTesoura.TabIndex = 2;
            this.BtTesoura.Tag = "2";
            this.BtTesoura.UseVisualStyleBackColor = false;
            this.BtTesoura.Click += new System.EventHandler(this.ClickJogada);
            // 
            // PicJogador
            // 
            this.PicJogador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicJogador.Location = new System.Drawing.Point(11, 22);
            this.PicJogador.Name = "PicJogador";
            this.PicJogador.Size = new System.Drawing.Size(150, 150);
            this.PicJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicJogador.TabIndex = 3;
            this.PicJogador.TabStop = false;
            // 
            // PicCPU
            // 
            this.PicCPU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicCPU.Location = new System.Drawing.Point(304, 22);
            this.PicCPU.Name = "PicCPU";
            this.PicCPU.Size = new System.Drawing.Size(150, 150);
            this.PicCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCPU.TabIndex = 4;
            this.PicCPU.TabStop = false;
            // 
            // LbDescricaoJogador
            // 
            this.LbDescricaoJogador.AutoSize = true;
            this.LbDescricaoJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDescricaoJogador.Location = new System.Drawing.Point(167, 70);
            this.LbDescricaoJogador.Name = "LbDescricaoJogador";
            this.LbDescricaoJogador.Size = new System.Drawing.Size(63, 18);
            this.LbDescricaoJogador.TabIndex = 5;
            this.LbDescricaoJogador.Text = "Jogador";
            this.LbDescricaoJogador.Click += new System.EventHandler(this.label1_Click);
            // 
            // LbDescricaoCPU
            // 
            this.LbDescricaoCPU.AutoSize = true;
            this.LbDescricaoCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDescricaoCPU.Location = new System.Drawing.Point(256, 70);
            this.LbDescricaoCPU.Name = "LbDescricaoCPU";
            this.LbDescricaoCPU.Size = new System.Drawing.Size(40, 18);
            this.LbDescricaoCPU.TabIndex = 6;
            this.LbDescricaoCPU.Text = "CPU";
            this.LbDescricaoCPU.Click += new System.EventHandler(this.LbDescricaoCPU_Click);
            // 
            // LbPtJogador
            // 
            this.LbPtJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPtJogador.Location = new System.Drawing.Point(176, 102);
            this.LbPtJogador.Name = "LbPtJogador";
            this.LbPtJogador.Size = new System.Drawing.Size(40, 20);
            this.LbPtJogador.TabIndex = 7;
            this.LbPtJogador.Text = "0";
            this.LbPtJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbPtCPU
            // 
            this.LbPtCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPtCPU.Location = new System.Drawing.Point(258, 102);
            this.LbPtCPU.Name = "LbPtCPU";
            this.LbPtCPU.Size = new System.Drawing.Size(40, 20);
            this.LbPtCPU.TabIndex = 8;
            this.LbPtCPU.Text = "0";
            this.LbPtCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 382);
            this.Controls.Add(this.LbPtCPU);
            this.Controls.Add(this.LbPtJogador);
            this.Controls.Add(this.LbDescricaoCPU);
            this.Controls.Add(this.LbDescricaoJogador);
            this.Controls.Add(this.PicCPU);
            this.Controls.Add(this.PicJogador);
            this.Controls.Add(this.BtTesoura);
            this.Controls.Add(this.BtPapel);
            this.Controls.Add(this.BtPedra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra Papel Tesoura";
            ((System.ComponentModel.ISupportInitialize)(this.PicJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtPedra;
        private System.Windows.Forms.Button BtPapel;
        private System.Windows.Forms.Button BtTesoura;
        private System.Windows.Forms.PictureBox PicJogador;
        private System.Windows.Forms.PictureBox PicCPU;
        private System.Windows.Forms.Label LbDescricaoJogador;
        private System.Windows.Forms.Label LbDescricaoCPU;
        private System.Windows.Forms.Label LbPtJogador;
        private System.Windows.Forms.Label LbPtCPU;
    }
}

