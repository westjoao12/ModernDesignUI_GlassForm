namespace ModernDesignUI_GlassForm.Forms_Auxiliares
{
    partial class FormUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscarImg = new Guna.UI2.WinForms.Guna2Button();
            this.btnSair = new Guna.UI2.WinForms.Guna2Button();
            this.panelCad = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_percent = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cmb_categoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErroCategoria = new System.Windows.Forms.Label();
            this.picture_img = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.cmb_funcionario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFuncErro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.cmb_nivel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_confir_senha = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblConfirmSenhaErro = new System.Windows.Forms.Label();
            this.txt_senha = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblsenhaErro = new System.Windows.Forms.Label();
            this.txt_nome = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNomeErro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNivelErro = new System.Windows.Forms.Label();
            this.panelCad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_img)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnBuscarImg
            // 
            this.btnBuscarImg.BorderRadius = 22;
            this.btnBuscarImg.CheckedState.Parent = this.btnBuscarImg;
            this.btnBuscarImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarImg.CustomImages.Parent = this.btnBuscarImg;
            this.btnBuscarImg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnBuscarImg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarImg.ForeColor = System.Drawing.Color.White;
            this.btnBuscarImg.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(129)))), ((int)(((byte)(204)))));
            this.btnBuscarImg.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnBuscarImg.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarImg.HoverState.Image")));
            this.btnBuscarImg.HoverState.Parent = this.btnBuscarImg;
            this.btnBuscarImg.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarImg.Image")));
            this.btnBuscarImg.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBuscarImg.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnBuscarImg.Location = new System.Drawing.Point(344, 191);
            this.btnBuscarImg.Name = "btnBuscarImg";
            this.btnBuscarImg.ShadowDecoration.Parent = this.btnBuscarImg;
            this.btnBuscarImg.Size = new System.Drawing.Size(50, 45);
            this.btnBuscarImg.TabIndex = 224;
            this.btnBuscarImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBuscarImg.TextOffset = new System.Drawing.Point(16, 0);
            this.toolTip1.SetToolTip(this.btnBuscarImg, "Buscar\r\nImagem");
            this.btnBuscarImg.Click += new System.EventHandler(this.btnBuscarImg_Click);
            // 
            // btnSair
            // 
            this.btnSair.BorderRadius = 22;
            this.btnSair.CheckedState.Parent = this.btnSair;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.CustomImages.Parent = this.btnSair;
            this.btnSair.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(240)))));
            this.btnSair.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnSair.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.HoverState.Image")));
            this.btnSair.HoverState.Parent = this.btnSair;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSair.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnSair.Location = new System.Drawing.Point(373, 17);
            this.btnSair.Name = "btnSair";
            this.btnSair.ShadowDecoration.Parent = this.btnSair;
            this.btnSair.Size = new System.Drawing.Size(50, 45);
            this.btnSair.TabIndex = 170;
            this.btnSair.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSair.TextOffset = new System.Drawing.Point(16, 0);
            this.toolTip1.SetToolTip(this.btnSair, "Sair?");
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panelCad
            // 
            this.panelCad.Controls.Add(this.label4);
            this.panelCad.Controls.Add(this.txt_percent);
            this.panelCad.Controls.Add(this.cmb_categoria);
            this.panelCad.Controls.Add(this.label3);
            this.panelCad.Controls.Add(this.lblErroCategoria);
            this.panelCad.Controls.Add(this.btnBuscarImg);
            this.panelCad.Controls.Add(this.picture_img);
            this.panelCad.Controls.Add(this.cmb_funcionario);
            this.panelCad.Controls.Add(this.label2);
            this.panelCad.Controls.Add(this.lblFuncErro);
            this.panelCad.Controls.Add(this.label5);
            this.panelCad.Controls.Add(this.btnGuardar);
            this.panelCad.Controls.Add(this.cmb_nivel);
            this.panelCad.Controls.Add(this.txt_confir_senha);
            this.panelCad.Controls.Add(this.lblConfirmSenhaErro);
            this.panelCad.Controls.Add(this.txt_senha);
            this.panelCad.Controls.Add(this.lblsenhaErro);
            this.panelCad.Controls.Add(this.txt_nome);
            this.panelCad.Controls.Add(this.btnSair);
            this.panelCad.Controls.Add(this.lblTitulo);
            this.panelCad.Controls.Add(this.lblNomeErro);
            this.panelCad.Controls.Add(this.label7);
            this.panelCad.Controls.Add(this.lblNivelErro);
            this.panelCad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCad.Location = new System.Drawing.Point(0, 0);
            this.panelCad.Name = "panelCad";
            this.panelCad.Size = new System.Drawing.Size(435, 519);
            this.panelCad.TabIndex = 172;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(256, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 231;
            this.label4.Text = "Percentagem";
            // 
            // txt_percent
            // 
            this.txt_percent.BackColor = System.Drawing.Color.Transparent;
            this.txt_percent.BorderRadius = 10;
            this.txt_percent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_percent.DecimalPlaces = 2;
            this.txt_percent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_percent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_percent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_percent.DisabledState.Parent = this.txt_percent;
            this.txt_percent.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txt_percent.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.txt_percent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_percent.FocusedState.Parent = this.txt_percent;
            this.txt_percent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_percent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_percent.Location = new System.Drawing.Point(249, 391);
            this.txt_percent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_percent.Name = "txt_percent";
            this.txt_percent.ShadowDecoration.Parent = this.txt_percent;
            this.txt_percent.Size = new System.Drawing.Size(125, 36);
            this.txt_percent.TabIndex = 230;
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.BackColor = System.Drawing.Color.Transparent;
            this.cmb_categoria.BorderRadius = 10;
            this.cmb_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_categoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_categoria.FocusedState.Parent = this.cmb_categoria;
            this.cmb_categoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.HoverState.Parent = this.cmb_categoria;
            this.cmb_categoria.ItemHeight = 30;
            this.cmb_categoria.Items.AddRange(new object[] {
            "",
            "Funcionário",
            "Sócio"});
            this.cmb_categoria.ItemsAppearance.Parent = this.cmb_categoria;
            this.cmb_categoria.Location = new System.Drawing.Point(38, 391);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.ShadowDecoration.Parent = this.cmb_categoria;
            this.cmb_categoria.Size = new System.Drawing.Size(174, 36);
            this.cmb_categoria.TabIndex = 225;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(88, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 226;
            this.label3.Text = "Categoria";
            // 
            // lblErroCategoria
            // 
            this.lblErroCategoria.AutoSize = true;
            this.lblErroCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblErroCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroCategoria.ForeColor = System.Drawing.Color.Red;
            this.lblErroCategoria.Location = new System.Drawing.Point(40, 425);
            this.lblErroCategoria.Name = "lblErroCategoria";
            this.lblErroCategoria.Size = new System.Drawing.Size(0, 17);
            this.lblErroCategoria.TabIndex = 227;
            // 
            // picture_img
            // 
            this.picture_img.Image = ((System.Drawing.Image)(resources.GetObject("picture_img.Image")));
            this.picture_img.Location = new System.Drawing.Point(224, 56);
            this.picture_img.Name = "picture_img";
            this.picture_img.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picture_img.ShadowDecoration.Parent = this.picture_img;
            this.picture_img.Size = new System.Drawing.Size(150, 150);
            this.picture_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_img.TabIndex = 223;
            this.picture_img.TabStop = false;
            // 
            // cmb_funcionario
            // 
            this.cmb_funcionario.BackColor = System.Drawing.Color.Transparent;
            this.cmb_funcionario.BorderRadius = 10;
            this.cmb_funcionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_funcionario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_funcionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_funcionario.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_funcionario.FocusedState.Parent = this.cmb_funcionario;
            this.cmb_funcionario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_funcionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_funcionario.FormattingEnabled = true;
            this.cmb_funcionario.HoverState.Parent = this.cmb_funcionario;
            this.cmb_funcionario.ItemHeight = 30;
            this.cmb_funcionario.Items.AddRange(new object[] {
            "",
            "West João"});
            this.cmb_funcionario.ItemsAppearance.Parent = this.cmb_funcionario;
            this.cmb_funcionario.Location = new System.Drawing.Point(38, 89);
            this.cmb_funcionario.Name = "cmb_funcionario";
            this.cmb_funcionario.ShadowDecoration.Parent = this.cmb_funcionario;
            this.cmb_funcionario.Size = new System.Drawing.Size(174, 36);
            this.cmb_funcionario.TabIndex = 220;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(45, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 221;
            this.label2.Text = "Funcionário";
            // 
            // lblFuncErro
            // 
            this.lblFuncErro.AutoSize = true;
            this.lblFuncErro.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncErro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncErro.ForeColor = System.Drawing.Color.Red;
            this.lblFuncErro.Location = new System.Drawing.Point(40, 122);
            this.lblFuncErro.Name = "lblFuncErro";
            this.lblFuncErro.Size = new System.Drawing.Size(0, 17);
            this.lblFuncErro.TabIndex = 222;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(35, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 17);
            this.label5.TabIndex = 219;
            this.label5.Text = "Tecla [Esc]: Para sair do formulário";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BorderRadius = 8;
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(129)))), ((int)(((byte)(204)))));
            this.btnGuardar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.HoverState.Image")));
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGuardar.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnGuardar.Location = new System.Drawing.Point(129, 455);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(176, 44);
            this.btnGuardar.TabIndex = 188;
            this.btnGuardar.Text = "Guardar...";
            // 
            // cmb_nivel
            // 
            this.cmb_nivel.BackColor = System.Drawing.Color.Transparent;
            this.cmb_nivel.BorderRadius = 10;
            this.cmb_nivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_nivel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_nivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nivel.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_nivel.FocusedState.Parent = this.cmb_nivel;
            this.cmb_nivel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_nivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_nivel.FormattingEnabled = true;
            this.cmb_nivel.HoverState.Parent = this.cmb_nivel;
            this.cmb_nivel.ItemHeight = 30;
            this.cmb_nivel.Items.AddRange(new object[] {
            "",
            "SystemAdmin",
            "Operador Avançado",
            "Operador",
            "UserOnly"});
            this.cmb_nivel.ItemsAppearance.Parent = this.cmb_nivel;
            this.cmb_nivel.Location = new System.Drawing.Point(38, 160);
            this.cmb_nivel.Name = "cmb_nivel";
            this.cmb_nivel.ShadowDecoration.Parent = this.cmb_nivel;
            this.cmb_nivel.Size = new System.Drawing.Size(174, 36);
            this.cmb_nivel.TabIndex = 182;
            // 
            // txt_confir_senha
            // 
            this.txt_confir_senha.BorderRadius = 10;
            this.txt_confir_senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_confir_senha.DefaultText = "";
            this.txt_confir_senha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_confir_senha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_confir_senha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confir_senha.DisabledState.Parent = this.txt_confir_senha;
            this.txt_confir_senha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confir_senha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(240)))));
            this.txt_confir_senha.FocusedState.Parent = this.txt_confir_senha;
            this.txt_confir_senha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confir_senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_confir_senha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.txt_confir_senha.HoverState.Parent = this.txt_confir_senha;
            this.txt_confir_senha.Location = new System.Drawing.Point(215, 312);
            this.txt_confir_senha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_confir_senha.Name = "txt_confir_senha";
            this.txt_confir_senha.PasswordChar = '*';
            this.txt_confir_senha.PlaceholderText = "Confirme senha";
            this.txt_confir_senha.SelectedText = "";
            this.txt_confir_senha.ShadowDecoration.Parent = this.txt_confir_senha;
            this.txt_confir_senha.Size = new System.Drawing.Size(174, 36);
            this.txt_confir_senha.TabIndex = 175;
            this.txt_confir_senha.UseSystemPasswordChar = true;
            // 
            // lblConfirmSenhaErro
            // 
            this.lblConfirmSenhaErro.AutoSize = true;
            this.lblConfirmSenhaErro.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmSenhaErro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmSenhaErro.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmSenhaErro.Location = new System.Drawing.Point(217, 346);
            this.lblConfirmSenhaErro.Name = "lblConfirmSenhaErro";
            this.lblConfirmSenhaErro.Size = new System.Drawing.Size(0, 17);
            this.lblConfirmSenhaErro.TabIndex = 176;
            // 
            // txt_senha
            // 
            this.txt_senha.BorderRadius = 10;
            this.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_senha.DefaultText = "";
            this.txt_senha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_senha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_senha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_senha.DisabledState.Parent = this.txt_senha;
            this.txt_senha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_senha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(240)))));
            this.txt_senha.FocusedState.Parent = this.txt_senha;
            this.txt_senha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_senha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.txt_senha.HoverState.Parent = this.txt_senha;
            this.txt_senha.Location = new System.Drawing.Point(38, 312);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.PlaceholderText = "Senha";
            this.txt_senha.SelectedText = "";
            this.txt_senha.ShadowDecoration.Parent = this.txt_senha;
            this.txt_senha.Size = new System.Drawing.Size(174, 36);
            this.txt_senha.TabIndex = 173;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // lblsenhaErro
            // 
            this.lblsenhaErro.AutoSize = true;
            this.lblsenhaErro.BackColor = System.Drawing.Color.Transparent;
            this.lblsenhaErro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenhaErro.ForeColor = System.Drawing.Color.Red;
            this.lblsenhaErro.Location = new System.Drawing.Point(40, 346);
            this.lblsenhaErro.Name = "lblsenhaErro";
            this.lblsenhaErro.Size = new System.Drawing.Size(0, 17);
            this.lblsenhaErro.TabIndex = 174;
            // 
            // txt_nome
            // 
            this.txt_nome.BorderRadius = 10;
            this.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nome.DefaultText = "";
            this.txt_nome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nome.DisabledState.Parent = this.txt_nome;
            this.txt_nome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(240)))));
            this.txt_nome.FocusedState.Parent = this.txt_nome;
            this.txt_nome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.txt_nome.HoverState.Parent = this.txt_nome;
            this.txt_nome.Location = new System.Drawing.Point(38, 244);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PasswordChar = '\0';
            this.txt_nome.PlaceholderText = "Nome de perfíl";
            this.txt_nome.SelectedText = "";
            this.txt_nome.ShadowDecoration.Parent = this.txt_nome;
            this.txt_nome.Size = new System.Drawing.Size(351, 36);
            this.txt_nome.TabIndex = 171;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblTitulo.Location = new System.Drawing.Point(33, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(208, 30);
            this.lblTitulo.TabIndex = 169;
            this.lblTitulo.Text = "Cadastro de usuário";
            // 
            // lblNomeErro
            // 
            this.lblNomeErro.AutoSize = true;
            this.lblNomeErro.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeErro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeErro.ForeColor = System.Drawing.Color.Red;
            this.lblNomeErro.Location = new System.Drawing.Point(40, 278);
            this.lblNomeErro.Name = "lblNomeErro";
            this.lblNomeErro.Size = new System.Drawing.Size(0, 17);
            this.lblNomeErro.TabIndex = 172;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label7.Location = new System.Drawing.Point(45, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 16);
            this.label7.TabIndex = 183;
            this.label7.Text = "Nível de autenticação";
            // 
            // lblNivelErro
            // 
            this.lblNivelErro.AutoSize = true;
            this.lblNivelErro.BackColor = System.Drawing.Color.Transparent;
            this.lblNivelErro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelErro.ForeColor = System.Drawing.Color.Red;
            this.lblNivelErro.Location = new System.Drawing.Point(40, 194);
            this.lblNivelErro.Name = "lblNivelErro";
            this.lblNivelErro.Size = new System.Drawing.Size(0, 17);
            this.lblNivelErro.TabIndex = 184;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 519);
            this.Controls.Add(this.panelCad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.TopMost = true;
            this.panelCad.ResumeLayout(false);
            this.panelCad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelCad;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2NumericUpDown txt_percent;
        public Guna.UI2.WinForms.Guna2ComboBox cmb_categoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErroCategoria;
        private Guna.UI2.WinForms.Guna2Button btnBuscarImg;
        public Guna.UI2.WinForms.Guna2CirclePictureBox picture_img;
        public Guna.UI2.WinForms.Guna2ComboBox cmb_funcionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFuncErro;
        public System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        public Guna.UI2.WinForms.Guna2ComboBox cmb_nivel;
        public Guna.UI2.WinForms.Guna2TextBox txt_confir_senha;
        private System.Windows.Forms.Label lblConfirmSenhaErro;
        public Guna.UI2.WinForms.Guna2TextBox txt_senha;
        private System.Windows.Forms.Label lblsenhaErro;
        public Guna.UI2.WinForms.Guna2TextBox txt_nome;
        private Guna.UI2.WinForms.Guna2Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNomeErro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNivelErro;
    }
}