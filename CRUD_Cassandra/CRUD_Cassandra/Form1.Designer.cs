namespace CRUD_Cassandra
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Criar = new Button();
            Inserir = new Button();
            Ler = new Button();
            Limpar = new Button();
            Deletar = new Button();
            dataGridView1 = new DataGridView();
            Atualizar = new Button();
            conectar = new Button();
            Desconectar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Criar
            // 
            Criar.Location = new Point(618, 12);
            Criar.Name = "Criar";
            Criar.Size = new Size(98, 43);
            Criar.TabIndex = 0;
            Criar.Text = "criar tabela";
            Criar.UseVisualStyleBackColor = true;
            Criar.Click += Criar_Click;
            // 
            // Inserir
            // 
            Inserir.Location = new Point(618, 76);
            Inserir.Name = "Inserir";
            Inserir.Size = new Size(98, 47);
            Inserir.TabIndex = 1;
            Inserir.Text = "inserir dados na tabela";
            Inserir.UseVisualStyleBackColor = true;
            Inserir.Click += Inserir_Click;
            // 
            // Ler
            // 
            Ler.Location = new Point(618, 148);
            Ler.Name = "Ler";
            Ler.Size = new Size(98, 44);
            Ler.TabIndex = 2;
            Ler.Text = "ler dados da tabela";
            Ler.UseVisualStyleBackColor = true;
            Ler.Click += Ler_Click;
            // 
            // Limpar
            // 
            Limpar.Location = new Point(618, 298);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(98, 39);
            Limpar.TabIndex = 3;
            Limpar.Text = "limpar tabela";
            Limpar.UseVisualStyleBackColor = true;
            Limpar.Click += Limpar_Click;
            // 
            // Deletar
            // 
            Deletar.Location = new Point(618, 372);
            Deletar.Name = "Deletar";
            Deletar.Size = new Size(98, 41);
            Deletar.TabIndex = 4;
            Deletar.Text = "deletar tabela";
            Deletar.UseVisualStyleBackColor = true;
            Deletar.Click += Deletar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(409, 302);
            dataGridView1.TabIndex = 5;
            // 
            // Atualizar
            // 
            Atualizar.Location = new Point(618, 220);
            Atualizar.Name = "Atualizar";
            Atualizar.Size = new Size(98, 44);
            Atualizar.TabIndex = 6;
            Atualizar.Text = "atualizar tabela";
            Atualizar.UseVisualStyleBackColor = true;
            Atualizar.Click += Atualizar_Click;
            // 
            // conectar
            // 
            conectar.Location = new Point(502, 20);
            conectar.Name = "conectar";
            conectar.Size = new Size(75, 23);
            conectar.TabIndex = 7;
            conectar.Text = "conectar";
            conectar.UseVisualStyleBackColor = true;
            conectar.Click += conectar_Click;
            // 
            // Desconectar
            // 
            Desconectar.Location = new Point(502, 390);
            Desconectar.Name = "Desconectar";
            Desconectar.Size = new Size(80, 23);
            Desconectar.TabIndex = 8;
            Desconectar.Text = "desconectar";
            Desconectar.UseVisualStyleBackColor = true;
            Desconectar.Click += Desconectar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Desconectar);
            Controls.Add(conectar);
            Controls.Add(Atualizar);
            Controls.Add(dataGridView1);
            Controls.Add(Deletar);
            Controls.Add(Limpar);
            Controls.Add(Ler);
            Controls.Add(Inserir);
            Controls.Add(Criar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Criar;
        private Button Inserir;
        private Button Ler;
        private Button Limpar;
        private Button Deletar;
        private DataGridView dataGridView1;
        private Button Atualizar;
        private Button conectar;
        private Button Desconectar;
    }
}