namespace SisPadoca
{
    partial class FrmProdutos
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
            components = new System.ComponentModel.Container();
            LblNomeProduto = new Label();
            TxbNomeProduto = new TextBox();
            DtpEntrega = new DateTimePicker();
            pictureBox1 = new PictureBox();
            MtbCodProduto = new MaskedTextBox();
            LblCodProduto = new Label();
            LblFornecedor = new Label();
            TxbFornecedor = new TextBox();
            LblFabricante = new Label();
            TxbFabricante = new TextBox();
            LblDataEntrega = new Label();
            LblQuantidade = new Label();
            NudQuantidade = new NumericUpDown();
            LblLote = new Label();
            TxbLote = new TextBox();
            imageList1 = new ImageList(components);
            LblDescricao = new Label();
            TxbDescricao = new TextBox();
            BtnNovoProduto = new Button();
            BtnEditarProduto = new Button();
            BtnExcluirProduto = new Button();
            BtnFechar = new Button();
            BtnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudQuantidade).BeginInit();
            SuspendLayout();
            // 
            // LblNomeProduto
            // 
            LblNomeProduto.AutoSize = true;
            LblNomeProduto.Location = new Point(226, 13);
            LblNomeProduto.Name = "LblNomeProduto";
            LblNomeProduto.Size = new Size(132, 20);
            LblNomeProduto.TabIndex = 0;
            LblNomeProduto.Text = "Nome do Produto:";
            // 
            // TxbNomeProduto
            // 
            TxbNomeProduto.BackColor = SystemColors.ScrollBar;
            TxbNomeProduto.Location = new Point(365, 11);
            TxbNomeProduto.Name = "TxbNomeProduto";
            TxbNomeProduto.Size = new Size(251, 27);
            TxbNomeProduto.TabIndex = 1;
            // 
            // DtpEntrega
            // 
            DtpEntrega.CalendarMonthBackground = SystemColors.ScrollBar;
            DtpEntrega.Location = new Point(352, 155);
            DtpEntrega.Name = "DtpEntrega";
            DtpEntrega.Size = new Size(107, 27);
            DtpEntrega.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.osmar;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // MtbCodProduto
            // 
            MtbCodProduto.BackColor = SystemColors.ScrollBar;
            MtbCodProduto.Location = new Point(371, 45);
            MtbCodProduto.Mask = "0000000000000";
            MtbCodProduto.Name = "MtbCodProduto";
            MtbCodProduto.Size = new Size(88, 27);
            MtbCodProduto.TabIndex = 4;
            // 
            // LblCodProduto
            // 
            LblCodProduto.AutoSize = true;
            LblCodProduto.Location = new Point(224, 48);
            LblCodProduto.Name = "LblCodProduto";
            LblCodProduto.Size = new Size(140, 20);
            LblCodProduto.TabIndex = 5;
            LblCodProduto.Text = "Código do Produto:";
            // 
            // LblFornecedor
            // 
            LblFornecedor.AutoSize = true;
            LblFornecedor.Location = new Point(226, 85);
            LblFornecedor.Name = "LblFornecedor";
            LblFornecedor.Size = new Size(166, 20);
            LblFornecedor.TabIndex = 6;
            LblFornecedor.Text = "Fornecedor do Produto:";
            // 
            // TxbFornecedor
            // 
            TxbFornecedor.BackColor = SystemColors.ScrollBar;
            TxbFornecedor.Location = new Point(399, 82);
            TxbFornecedor.Name = "TxbFornecedor";
            TxbFornecedor.Size = new Size(218, 27);
            TxbFornecedor.TabIndex = 7;
            // 
            // LblFabricante
            // 
            LblFabricante.AutoSize = true;
            LblFabricante.Location = new Point(226, 123);
            LblFabricante.Name = "LblFabricante";
            LblFabricante.Size = new Size(159, 20);
            LblFabricante.TabIndex = 8;
            LblFabricante.Text = "Fabricante do Produto:";
            // 
            // TxbFabricante
            // 
            TxbFabricante.BackColor = SystemColors.ScrollBar;
            TxbFabricante.Location = new Point(391, 120);
            TxbFabricante.Name = "TxbFabricante";
            TxbFabricante.Size = new Size(218, 27);
            TxbFabricante.TabIndex = 9;
            // 
            // LblDataEntrega
            // 
            LblDataEntrega.AutoSize = true;
            LblDataEntrega.Location = new Point(226, 160);
            LblDataEntrega.Name = "LblDataEntrega";
            LblDataEntrega.Size = new Size(120, 20);
            LblDataEntrega.TabIndex = 10;
            LblDataEntrega.Text = "Data de Entrega:";
            // 
            // LblQuantidade
            // 
            LblQuantidade.AutoSize = true;
            LblQuantidade.Location = new Point(226, 197);
            LblQuantidade.Name = "LblQuantidade";
            LblQuantidade.Size = new Size(90, 20);
            LblQuantidade.TabIndex = 11;
            LblQuantidade.Text = "Quantidade:";
            // 
            // NudQuantidade
            // 
            NudQuantidade.BackColor = SystemColors.ScrollBar;
            NudQuantidade.Location = new Point(327, 193);
            NudQuantidade.Name = "NudQuantidade";
            NudQuantidade.Size = new Size(46, 27);
            NudQuantidade.TabIndex = 12;
            // 
            // LblLote
            // 
            LblLote.AutoSize = true;
            LblLote.Location = new Point(16, 238);
            LblLote.Name = "LblLote";
            LblLote.Size = new Size(41, 20);
            LblLote.TabIndex = 13;
            LblLote.Text = "Lote:";
            // 
            // TxbLote
            // 
            TxbLote.BackColor = SystemColors.ScrollBar;
            TxbLote.Location = new Point(66, 235);
            TxbLote.Name = "TxbLote";
            TxbLote.Size = new Size(133, 27);
            TxbLote.TabIndex = 14;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(16, 278);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(77, 20);
            LblDescricao.TabIndex = 15;
            LblDescricao.Text = "Descrição:";
            // 
            // TxbDescricao
            // 
            TxbDescricao.BackColor = SystemColors.ScrollBar;
            TxbDescricao.Location = new Point(101, 275);
            TxbDescricao.Name = "TxbDescricao";
            TxbDescricao.Size = new Size(133, 27);
            TxbDescricao.TabIndex = 16;
            // 
            // BtnNovoProduto
            // 
            BtnNovoProduto.BackColor = SystemColors.ActiveBorder;
            BtnNovoProduto.Location = new Point(14, 437);
            BtnNovoProduto.Name = "BtnNovoProduto";
            BtnNovoProduto.Size = new Size(107, 64);
            BtnNovoProduto.TabIndex = 17;
            BtnNovoProduto.Text = "Novo Produto";
            BtnNovoProduto.UseVisualStyleBackColor = false;
            // 
            // BtnEditarProduto
            // 
            BtnEditarProduto.BackColor = SystemColors.ActiveBorder;
            BtnEditarProduto.Location = new Point(136, 437);
            BtnEditarProduto.Name = "BtnEditarProduto";
            BtnEditarProduto.Size = new Size(107, 64);
            BtnEditarProduto.TabIndex = 18;
            BtnEditarProduto.Text = "Editar Produto";
            BtnEditarProduto.UseVisualStyleBackColor = false;
            // 
            // BtnExcluirProduto
            // 
            BtnExcluirProduto.BackColor = SystemColors.ActiveBorder;
            BtnExcluirProduto.Location = new Point(259, 437);
            BtnExcluirProduto.Name = "BtnExcluirProduto";
            BtnExcluirProduto.Size = new Size(107, 64);
            BtnExcluirProduto.TabIndex = 19;
            BtnExcluirProduto.Text = "Excluir Produto";
            BtnExcluirProduto.UseVisualStyleBackColor = false;
            BtnExcluirProduto.Click += BtnExcluirProduto_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.BackColor = SystemColors.ActiveBorder;
            BtnFechar.Location = new Point(740, 437);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(107, 64);
            BtnFechar.TabIndex = 20;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = SystemColors.ActiveBorder;
            BtnCancelar.Location = new Point(618, 437);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(107, 64);
            BtnCancelar.TabIndex = 21;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources.boxman;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(869, 513);
            ControlBox = false;
            Controls.Add(BtnCancelar);
            Controls.Add(BtnFechar);
            Controls.Add(BtnExcluirProduto);
            Controls.Add(BtnEditarProduto);
            Controls.Add(BtnNovoProduto);
            Controls.Add(TxbDescricao);
            Controls.Add(LblDescricao);
            Controls.Add(TxbLote);
            Controls.Add(LblLote);
            Controls.Add(NudQuantidade);
            Controls.Add(LblQuantidade);
            Controls.Add(LblDataEntrega);
            Controls.Add(TxbFabricante);
            Controls.Add(LblFabricante);
            Controls.Add(TxbFornecedor);
            Controls.Add(LblFornecedor);
            Controls.Add(LblCodProduto);
            Controls.Add(MtbCodProduto);
            Controls.Add(pictureBox1);
            Controls.Add(DtpEntrega);
            Controls.Add(TxbNomeProduto);
            Controls.Add(LblNomeProduto);
            Name = "FrmProdutos";
            Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNomeProduto;
        private TextBox TxbNomeProduto;
        private DateTimePicker DtpEntrega;
        private PictureBox pictureBox1;
        private MaskedTextBox MtbCodProduto;
        private Label LblCodProduto;
        private Label LblFornecedor;
        private TextBox TxbFornecedor;
        private Label LblFabricante;
        private TextBox TxbFabricante;
        private Label LblDataEntrega;
        private Label LblQuantidade;
        private NumericUpDown NudQuantidade;
        private Label LblLote;
        private TextBox TxbLote;
        private ImageList imageList1;
        private Label LblDescricao;
        private TextBox TxbDescricao;
        private Button BtnNovoProduto;
        private Button BtnEditarProduto;
        private Button BtnExcluirProduto;
        private Button BtnFechar;
        private Button BtnCancelar;
    }
}