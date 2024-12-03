namespace ProjetoPOO2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLer = new System.Windows.Forms.Button();
            this.btnLerFornecedor = new System.Windows.Forms.Button();
            this.btnExcluirFornecedor = new System.Windows.Forms.Button();
            this.btnAtualizarFornecedor = new System.Windows.Forms.Button();
            this.btnAdicionarFornecedor = new System.Windows.Forms.Button();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.txtTelefoneFornecedor = new System.Windows.Forms.TextBox();
            this.lblTelefoneFornecedor = new System.Windows.Forms.Label();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPesquisarPedido = new System.Windows.Forms.Button();
            this.btnExlcuirPedido = new System.Windows.Forms.Button();
            this.btnAtualizarPedido = new System.Windows.Forms.Button();
            this.btnAdicionarPedido = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.txtQuantidadePedido = new System.Windows.Forms.TextBox();
            this.lblQuantidadePedido = new System.Windows.Forms.Label();
            this.DataPedido = new System.Windows.Forms.DateTimePicker();
            this.txtIdFornecedorFK = new System.Windows.Forms.TextBox();
            this.lblIdFornecedorFK = new System.Windows.Forms.Label();
            this.txtIdProdutoFK = new System.Windows.Forms.TextBox();
            this.lblIdProdutoFK = new System.Windows.Forms.Label();
            this.chkFiltroData = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(80, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(276, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 54);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(80, 47);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(276, 20);
            this.txtQuantidade.TabIndex = 3;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(12, 89);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 4;
            this.lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(80, 82);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(135, 20);
            this.txtPreco.TabIndex = 5;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(15, 120);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowTemplate.Height = 25;
            this.dgvProdutos.Size = new System.Drawing.Size(488, 129);
            this.dgvProdutos.TabIndex = 6;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(221, 82);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(135, 20);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar Produto";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(367, 47);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(136, 20);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar Produto";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(367, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(136, 20);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir produto";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(366, 82);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(135, 20);
            this.btnLer.TabIndex = 10;
            this.btnLer.Text = "Pesquisar Produto";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnLerFornecedor
            // 
            this.btnLerFornecedor.Location = new System.Drawing.Point(798, 85);
            this.btnLerFornecedor.Name = "btnLerFornecedor";
            this.btnLerFornecedor.Size = new System.Drawing.Size(153, 20);
            this.btnLerFornecedor.TabIndex = 21;
            this.btnLerFornecedor.Text = "Pesquisar Fornecedor";
            this.btnLerFornecedor.UseVisualStyleBackColor = true;
            this.btnLerFornecedor.Click += new System.EventHandler(this.btnLerFornecedor_Click);
            // 
            // btnExcluirFornecedor
            // 
            this.btnExcluirFornecedor.Location = new System.Drawing.Point(798, 12);
            this.btnExcluirFornecedor.Name = "btnExcluirFornecedor";
            this.btnExcluirFornecedor.Size = new System.Drawing.Size(153, 20);
            this.btnExcluirFornecedor.TabIndex = 20;
            this.btnExcluirFornecedor.Text = "Excluir Fornecedor";
            this.btnExcluirFornecedor.UseVisualStyleBackColor = true;
            this.btnExcluirFornecedor.Click += new System.EventHandler(this.btnExcluirFornecedor_Click);
            // 
            // btnAtualizarFornecedor
            // 
            this.btnAtualizarFornecedor.Location = new System.Drawing.Point(798, 47);
            this.btnAtualizarFornecedor.Name = "btnAtualizarFornecedor";
            this.btnAtualizarFornecedor.Size = new System.Drawing.Size(153, 20);
            this.btnAtualizarFornecedor.TabIndex = 19;
            this.btnAtualizarFornecedor.Text = "Atualizar Fornecedor";
            this.btnAtualizarFornecedor.UseVisualStyleBackColor = true;
            this.btnAtualizarFornecedor.Click += new System.EventHandler(this.btnAtualizarFornecedor_Click);
            // 
            // btnAdicionarFornecedor
            // 
            this.btnAdicionarFornecedor.Location = new System.Drawing.Point(528, 85);
            this.btnAdicionarFornecedor.Name = "btnAdicionarFornecedor";
            this.btnAdicionarFornecedor.Size = new System.Drawing.Size(264, 20);
            this.btnAdicionarFornecedor.TabIndex = 18;
            this.btnAdicionarFornecedor.Text = "Adicionar Fornecedor";
            this.btnAdicionarFornecedor.UseVisualStyleBackColor = true;
            this.btnAdicionarFornecedor.Click += new System.EventHandler(this.btnAdicionarFornecedor_Click);
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Location = new System.Drawing.Point(527, 120);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.RowTemplate.Height = 25;
            this.dgvFornecedores.Size = new System.Drawing.Size(424, 129);
            this.dgvFornecedores.TabIndex = 17;
            // 
            // txtTelefoneFornecedor
            // 
            this.txtTelefoneFornecedor.Location = new System.Drawing.Point(586, 47);
            this.txtTelefoneFornecedor.Name = "txtTelefoneFornecedor";
            this.txtTelefoneFornecedor.Size = new System.Drawing.Size(206, 20);
            this.txtTelefoneFornecedor.TabIndex = 14;
            // 
            // lblTelefoneFornecedor
            // 
            this.lblTelefoneFornecedor.AutoSize = true;
            this.lblTelefoneFornecedor.Location = new System.Drawing.Point(525, 51);
            this.lblTelefoneFornecedor.Name = "lblTelefoneFornecedor";
            this.lblTelefoneFornecedor.Size = new System.Drawing.Size(52, 13);
            this.lblTelefoneFornecedor.TabIndex = 13;
            this.lblTelefoneFornecedor.Text = "Telefone:";
            this.lblTelefoneFornecedor.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(586, 12);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(206, 20);
            this.txtNomeFornecedor.TabIndex = 12;
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Location = new System.Drawing.Point(525, 15);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(38, 13);
            this.lblNomeFornecedor.TabIndex = 11;
            this.lblNomeFornecedor.Text = "Nome:";
            this.lblNomeFornecedor.Click += new System.EventHandler(this.lblNomeFornecedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(510, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 237);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(15, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(938, 10);
            this.panel3.TabIndex = 24;
            // 
            // btnPesquisarPedido
            // 
            this.btnPesquisarPedido.Location = new System.Drawing.Point(244, 416);
            this.btnPesquisarPedido.Name = "btnPesquisarPedido";
            this.btnPesquisarPedido.Size = new System.Drawing.Size(131, 65);
            this.btnPesquisarPedido.TabIndex = 33;
            this.btnPesquisarPedido.Text = "Pesquisar Pedido";
            this.btnPesquisarPedido.UseVisualStyleBackColor = true;
            this.btnPesquisarPedido.Click += new System.EventHandler(this.btnPesquisarPedido_Click);
            // 
            // btnExlcuirPedido
            // 
            this.btnExlcuirPedido.Location = new System.Drawing.Point(246, 280);
            this.btnExlcuirPedido.Name = "btnExlcuirPedido";
            this.btnExlcuirPedido.Size = new System.Drawing.Size(129, 54);
            this.btnExlcuirPedido.TabIndex = 32;
            this.btnExlcuirPedido.Text = "Excluir Pedido";
            this.btnExlcuirPedido.UseVisualStyleBackColor = true;
            this.btnExlcuirPedido.Click += new System.EventHandler(this.btnExcluirPedido_Click);
            // 
            // btnAtualizarPedido
            // 
            this.btnAtualizarPedido.Location = new System.Drawing.Point(246, 347);
            this.btnAtualizarPedido.Name = "btnAtualizarPedido";
            this.btnAtualizarPedido.Size = new System.Drawing.Size(129, 54);
            this.btnAtualizarPedido.TabIndex = 31;
            this.btnAtualizarPedido.Text = "Atualizar Pedido";
            this.btnAtualizarPedido.UseVisualStyleBackColor = true;
            this.btnAtualizarPedido.Click += new System.EventHandler(this.btnAtualizarPedido_Click);
            // 
            // btnAdicionarPedido
            // 
            this.btnAdicionarPedido.Location = new System.Drawing.Point(12, 416);
            this.btnAdicionarPedido.Name = "btnAdicionarPedido";
            this.btnAdicionarPedido.Size = new System.Drawing.Size(228, 65);
            this.btnAdicionarPedido.TabIndex = 30;
            this.btnAdicionarPedido.Text = "Adicionar Pedido";
            this.btnAdicionarPedido.UseVisualStyleBackColor = true;
            this.btnAdicionarPedido.Click += new System.EventHandler(this.btnAdicionarPedido_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(381, 281);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowTemplate.Height = 25;
            this.dgvPedidos.Size = new System.Drawing.Size(571, 200);
            this.dgvPedidos.TabIndex = 29;
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.Location = new System.Drawing.Point(12, 388);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(83, 13);
            this.lblDataPedido.TabIndex = 40;
            this.lblDataPedido.Text = "Data do pedido:";
            // 
            // txtQuantidadePedido
            // 
            this.txtQuantidadePedido.Location = new System.Drawing.Point(108, 347);
            this.txtQuantidadePedido.Name = "txtQuantidadePedido";
            this.txtQuantidadePedido.Size = new System.Drawing.Size(132, 20);
            this.txtQuantidadePedido.TabIndex = 39;
            // 
            // lblQuantidadePedido
            // 
            this.lblQuantidadePedido.AutoSize = true;
            this.lblQuantidadePedido.Location = new System.Drawing.Point(12, 354);
            this.lblQuantidadePedido.Name = "lblQuantidadePedido";
            this.lblQuantidadePedido.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidadePedido.TabIndex = 38;
            this.lblQuantidadePedido.Text = "Quantidade:";
            // 
            // DataPedido
            // 
            this.DataPedido.Location = new System.Drawing.Point(108, 380);
            this.DataPedido.Name = "DataPedido";
            this.DataPedido.Size = new System.Drawing.Size(132, 20);
            this.DataPedido.TabIndex = 42;
            // 
            // txtIdFornecedorFK
            // 
            this.txtIdFornecedorFK.Location = new System.Drawing.Point(108, 314);
            this.txtIdFornecedorFK.Name = "txtIdFornecedorFK";
            this.txtIdFornecedorFK.Size = new System.Drawing.Size(132, 20);
            this.txtIdFornecedorFK.TabIndex = 46;
            // 
            // lblIdFornecedorFK
            // 
            this.lblIdFornecedorFK.AutoSize = true;
            this.lblIdFornecedorFK.Location = new System.Drawing.Point(12, 321);
            this.lblIdFornecedorFK.Name = "lblIdFornecedorFK";
            this.lblIdFornecedorFK.Size = new System.Drawing.Size(91, 13);
            this.lblIdFornecedorFK.TabIndex = 45;
            this.lblIdFornecedorFK.Text = "Id do Fornecedor:";
            // 
            // txtIdProdutoFK
            // 
            this.txtIdProdutoFK.Location = new System.Drawing.Point(108, 281);
            this.txtIdProdutoFK.Name = "txtIdProdutoFK";
            this.txtIdProdutoFK.Size = new System.Drawing.Size(132, 20);
            this.txtIdProdutoFK.TabIndex = 44;
            // 
            // lblIdProdutoFK
            // 
            this.lblIdProdutoFK.AutoSize = true;
            this.lblIdProdutoFK.Location = new System.Drawing.Point(12, 287);
            this.lblIdProdutoFK.Name = "lblIdProdutoFK";
            this.lblIdProdutoFK.Size = new System.Drawing.Size(74, 13);
            this.lblIdProdutoFK.TabIndex = 43;
            this.lblIdProdutoFK.Text = "Id do Produto:";
            // 
            // chkFiltroData
            // 
            this.chkFiltroData.AutoSize = true;
            this.chkFiltroData.Location = new System.Drawing.Point(93, 387);
            this.chkFiltroData.Name = "chkFiltroData";
            this.chkFiltroData.Size = new System.Drawing.Size(15, 14);
            this.chkFiltroData.TabIndex = 47;
            this.chkFiltroData.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(965, 496);
            this.Controls.Add(this.chkFiltroData);
            this.Controls.Add(this.txtIdFornecedorFK);
            this.Controls.Add(this.lblIdFornecedorFK);
            this.Controls.Add(this.txtIdProdutoFK);
            this.Controls.Add(this.lblIdProdutoFK);
            this.Controls.Add(this.DataPedido);
            this.Controls.Add(this.lblDataPedido);
            this.Controls.Add(this.txtQuantidadePedido);
            this.Controls.Add(this.lblQuantidadePedido);
            this.Controls.Add(this.btnPesquisarPedido);
            this.Controls.Add(this.btnExlcuirPedido);
            this.Controls.Add(this.btnAtualizarPedido);
            this.Controls.Add(this.btnAdicionarPedido);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLerFornecedor);
            this.Controls.Add(this.btnExcluirFornecedor);
            this.Controls.Add(this.btnAtualizarFornecedor);
            this.Controls.Add(this.btnAdicionarFornecedor);
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefoneFornecedor);
            this.Controls.Add(this.lblTelefoneFornecedor);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.lblNomeFornecedor);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Gerenciar Produtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnLerFornecedor;
        private System.Windows.Forms.Button btnExcluirFornecedor;
        private System.Windows.Forms.Button btnAtualizarFornecedor;
        private System.Windows.Forms.Button btnAdicionarFornecedor;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.TextBox txtTelefoneFornecedor;
        private System.Windows.Forms.Label lblTelefoneFornecedor;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label lblNomeFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPesquisarPedido;
        private System.Windows.Forms.Button btnExlcuirPedido;
        private System.Windows.Forms.Button btnAtualizarPedido;
        private System.Windows.Forms.Button btnAdicionarPedido;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.TextBox txtQuantidadePedido;
        private System.Windows.Forms.Label lblQuantidadePedido;
        private System.Windows.Forms.DateTimePicker DataPedido;
        private System.Windows.Forms.TextBox txtIdFornecedorFK;
        private System.Windows.Forms.Label lblIdFornecedorFK;
        private System.Windows.Forms.TextBox txtIdProdutoFK;
        private System.Windows.Forms.Label lblIdProdutoFK;
        private System.Windows.Forms.CheckBox chkFiltroData;
    }
}

