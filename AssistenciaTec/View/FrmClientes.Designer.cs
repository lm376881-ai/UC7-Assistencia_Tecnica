namespace AssistenciaTec.View
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            lblCadastroCliente = new Label();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            btnBuscar = new Button();
            listView1 = new ListView();
            txtBuscarCliente = new TextBox();
            label1 = new Label();
            groupBoxDadosCliente = new GroupBox();
            txtEndereço = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            lblIdCliente = new Label();
            lblEndereço = new Label();
            lblNome = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            pictureBox1 = new PictureBox();
            toolStrip1 = new ToolStrip();
            toolStripAdicionar = new ToolStripButton();
            toolStripEditar = new ToolStripButton();
            toolStripApagar = new ToolStripButton();
            toolStripCancelar = new ToolStripButton();
            toolStripSalvar = new ToolStripButton();
            panel2 = new Panel();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBoxDadosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblCadastroCliente
            // 
            lblCadastroCliente.AutoSize = true;
            lblCadastroCliente.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastroCliente.Location = new Point(130, 9);
            lblCadastroCliente.Name = "lblCadastroCliente";
            lblCadastroCliente.Size = new Size(255, 40);
            lblCadastroCliente.TabIndex = 0;
            lblCadastroCliente.Text = "Cadastro Clientes";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBoxDadosCliente);
            panel1.Location = new Point(0, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 520);
            panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(txtBuscarCliente);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(354, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(522, 441);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista Clientes Cadastrados:";
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(404, 59);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(47, 29);
            btnBuscar.TabIndex = 9;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 99);
            listView1.Name = "listView1";
            listView1.Size = new Size(512, 333);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(6, 59);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(392, 29);
            txtBuscarCliente.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(191, 21);
            label1.TabIndex = 1;
            label1.Text = "Buscar clientes por nome: ";
            // 
            // groupBoxDadosCliente
            // 
            groupBoxDadosCliente.Controls.Add(txtEndereço);
            groupBoxDadosCliente.Controls.Add(txtTelefone);
            groupBoxDadosCliente.Controls.Add(txtEmail);
            groupBoxDadosCliente.Controls.Add(txtNome);
            groupBoxDadosCliente.Controls.Add(lblIdCliente);
            groupBoxDadosCliente.Controls.Add(lblEndereço);
            groupBoxDadosCliente.Controls.Add(lblNome);
            groupBoxDadosCliente.Controls.Add(lblTelefone);
            groupBoxDadosCliente.Controls.Add(lblEmail);
            groupBoxDadosCliente.Location = new Point(12, 29);
            groupBoxDadosCliente.Name = "groupBoxDadosCliente";
            groupBoxDadosCliente.Size = new Size(317, 453);
            groupBoxDadosCliente.TabIndex = 5;
            groupBoxDadosCliente.TabStop = false;
            groupBoxDadosCliente.Text = "Dados do cliente:";
            // 
            // txtEndereço
            // 
            txtEndereço.Location = new Point(0, 272);
            txtEndereço.Multiline = true;
            txtEndereço.Name = "txtEndereço";
            txtEndereço.Size = new Size(317, 171);
            txtEndereço.TabIndex = 9;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 12F);
            txtTelefone.Location = new Point(0, 210);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(170, 29);
            txtTelefone.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(0, 148);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(281, 29);
            txtEmail.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(0, 92);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(281, 29);
            txtNome.TabIndex = 6;
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Font = new Font("Segoe UI", 12F);
            lblIdCliente.Location = new Point(6, 39);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(99, 21);
            lblIdCliente.TabIndex = 0;
            lblIdCliente.Text = "ID do cliente:";
            // 
            // lblEndereço
            // 
            lblEndereço.AutoSize = true;
            lblEndereço.Font = new Font("Segoe UI", 12F);
            lblEndereço.Location = new Point(0, 248);
            lblEndereço.Name = "lblEndereço";
            lblEndereço.Size = new Size(152, 21);
            lblEndereço.TabIndex = 4;
            lblEndereço.Text = "Endereço do cliente: ";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(0, 70);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(130, 21);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome do Cliente:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 12F);
            lblTelefone.Location = new Point(0, 186);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(145, 21);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone do cliente: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(0, 124);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(128, 21);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-mail do cliente:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.candidatos;
            pictureBox1.Location = new Point(18, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new Size(50, 50);
            toolStrip1.ImeMode = ImeMode.On;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripAdicionar, toolStripEditar, toolStripApagar, toolStripCancelar, toolStripSalvar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(887, 57);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripAdicionar
            // 
            toolStripAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripAdicionar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripAdicionar.Image = (Image)resources.GetObject("toolStripAdicionar.Image");
            toolStripAdicionar.ImageTransparentColor = Color.Magenta;
            toolStripAdicionar.Name = "toolStripAdicionar";
            toolStripAdicionar.Size = new Size(54, 54);
            toolStripAdicionar.Text = "toolStripButton1";
            toolStripAdicionar.Click += toolStripAdicionar_Click;
            // 
            // toolStripEditar
            // 
            toolStripEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripEditar.Image = (Image)resources.GetObject("toolStripEditar.Image");
            toolStripEditar.ImageTransparentColor = Color.Magenta;
            toolStripEditar.Name = "toolStripEditar";
            toolStripEditar.Size = new Size(54, 54);
            toolStripEditar.Text = "toolStripButton2";
            toolStripEditar.Click += toolStripEditar_Click;
            // 
            // toolStripApagar
            // 
            toolStripApagar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripApagar.Image = (Image)resources.GetObject("toolStripApagar.Image");
            toolStripApagar.ImageTransparentColor = Color.Magenta;
            toolStripApagar.Name = "toolStripApagar";
            toolStripApagar.Size = new Size(54, 54);
            toolStripApagar.Text = "toolStripButton3";
            toolStripApagar.Click += toolStripApagar_Click;
            // 
            // toolStripCancelar
            // 
            toolStripCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripCancelar.Image = (Image)resources.GetObject("toolStripCancelar.Image");
            toolStripCancelar.ImageTransparentColor = Color.Magenta;
            toolStripCancelar.Name = "toolStripCancelar";
            toolStripCancelar.Size = new Size(54, 54);
            toolStripCancelar.Text = "toolStripButton4";
            toolStripCancelar.Click += toolStripCancelar_Click;
            // 
            // toolStripSalvar
            // 
            toolStripSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSalvar.Image = (Image)resources.GetObject("toolStripSalvar.Image");
            toolStripSalvar.ImageTransparentColor = Color.Magenta;
            toolStripSalvar.Name = "toolStripSalvar";
            toolStripSalvar.Size = new Size(54, 54);
            toolStripSalvar.Text = "toolStripButton5";
            toolStripSalvar.Click += toolStripSalvar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(toolStrip1);
            panel2.Location = new Point(0, 603);
            panel2.Name = "panel2";
            panel2.Size = new Size(887, 66);
            panel2.TabIndex = 3;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 673);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(lblCadastroCliente);
            Name = "FrmClientes";
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxDadosCliente.ResumeLayout(false);
            groupBoxDadosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastroCliente;
        private Panel panel1;
        private Label lblEndereço;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblNome;
        private Label lblIdCliente;
        private GroupBox groupBoxDadosCliente;
        private TextBox txtEmail;
        private TextBox txtNome;
        private GroupBox groupBox2;
        private Button btnBuscar;
        private ListView listView1;
        private TextBox txtBuscarCliente;
        private Label label1;
        private TextBox txtEndereço;
        private TextBox txtTelefone;
        private PictureBox pictureBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripAdicionar;
        private ToolStripButton toolStripEditar;
        private ToolStripButton toolStripApagar;
        private ToolStripButton toolStripCancelar;
        private Panel panel2;
        private ToolStripButton toolStripSalvar;
    }
}