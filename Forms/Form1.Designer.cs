namespace Escalera
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.bConnect = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ListaPorts = new Guna.UI.WinForms.GunaComboBox();
            this.bJugar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.bObservar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.bJugador1 = new Guna.UI.WinForms.GunaCircleButton();
            this.bJugador2 = new Guna.UI.WinForms.GunaCircleButton();
            this.bJugador3 = new Guna.UI.WinForms.GunaCircleButton();
            this.bJugador4 = new Guna.UI.WinForms.GunaCircleButton();
            this.DificultadList = new Guna.UI.WinForms.GunaComboBox();
            this.select_player_label = new Guna.UI.WinForms.GunaLabel();
            this.difficulty_label = new Guna.UI.WinForms.GunaLabel();
            this.quit_Game = new Guna.UI.WinForms.GunaImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1240, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 9;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(1189, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 10;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(97, 74);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(603, 122);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 11;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(219, 178);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(562, 572);
            this.gunaPictureBox2.TabIndex = 12;
            this.gunaPictureBox2.TabStop = false;
            // 
            // bConnect
            // 
            this.bConnect.AnimationHoverSpeed = 0.07F;
            this.bConnect.AnimationSpeed = 0.03F;
            this.bConnect.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.bConnect.BorderColor = System.Drawing.Color.Black;
            this.bConnect.CheckedBaseColor = System.Drawing.Color.Gray;
            this.bConnect.CheckedBorderColor = System.Drawing.Color.Black;
            this.bConnect.CheckedForeColor = System.Drawing.Color.White;
            this.bConnect.CheckedImage = ((System.Drawing.Image)(resources.GetObject("bConnect.CheckedImage")));
            this.bConnect.CheckedLineColor = System.Drawing.Color.DimGray;
            this.bConnect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bConnect.FocusedColor = System.Drawing.Color.Empty;
            this.bConnect.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.bConnect.ForeColor = System.Drawing.Color.White;
            this.bConnect.Image = ((System.Drawing.Image)(resources.GetObject("bConnect.Image")));
            this.bConnect.ImageSize = new System.Drawing.Size(20, 20);
            this.bConnect.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.bConnect.Location = new System.Drawing.Point(821, 94);
            this.bConnect.Name = "bConnect";
            this.bConnect.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(131)))), ((int)(((byte)(135)))));
            this.bConnect.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bConnect.OnHoverForeColor = System.Drawing.Color.White;
            this.bConnect.OnHoverImage = null;
            this.bConnect.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.bConnect.OnPressedColor = System.Drawing.Color.Black;
            this.bConnect.Size = new System.Drawing.Size(295, 70);
            this.bConnect.TabIndex = 13;
            this.bConnect.Text = "Buscar Puertos";
            this.bConnect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // ListaPorts
            // 
            this.ListaPorts.BackColor = System.Drawing.Color.Transparent;
            this.ListaPorts.BaseColor = System.Drawing.Color.White;
            this.ListaPorts.BorderColor = System.Drawing.Color.Silver;
            this.ListaPorts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ListaPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListaPorts.FocusedColor = System.Drawing.Color.Empty;
            this.ListaPorts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ListaPorts.ForeColor = System.Drawing.Color.Black;
            this.ListaPorts.FormattingEnabled = true;
            this.ListaPorts.Location = new System.Drawing.Point(821, 178);
            this.ListaPorts.Name = "ListaPorts";
            this.ListaPorts.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(131)))), ((int)(((byte)(135)))));
            this.ListaPorts.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ListaPorts.Size = new System.Drawing.Size(295, 31);
            this.ListaPorts.TabIndex = 14;
            this.ListaPorts.SelectedIndexChanged += new System.EventHandler(this.ListaPorts_SelectedIndexChanged);
            // 
            // bJugar
            // 
            this.bJugar.AnimationHoverSpeed = 0.07F;
            this.bJugar.AnimationSpeed = 0.03F;
            this.bJugar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.bJugar.BorderColor = System.Drawing.Color.Black;
            this.bJugar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.bJugar.CheckedBorderColor = System.Drawing.Color.Black;
            this.bJugar.CheckedForeColor = System.Drawing.Color.White;
            this.bJugar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("bJugar.CheckedImage")));
            this.bJugar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.bJugar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bJugar.Enabled = false;
            this.bJugar.FocusedColor = System.Drawing.Color.Empty;
            this.bJugar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bJugar.ForeColor = System.Drawing.Color.White;
            this.bJugar.Image = ((System.Drawing.Image)(resources.GetObject("bJugar.Image")));
            this.bJugar.ImageSize = new System.Drawing.Size(20, 20);
            this.bJugar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.bJugar.Location = new System.Drawing.Point(821, 234);
            this.bJugar.Name = "bJugar";
            this.bJugar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(131)))), ((int)(((byte)(135)))));
            this.bJugar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bJugar.OnHoverForeColor = System.Drawing.Color.White;
            this.bJugar.OnHoverImage = null;
            this.bJugar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.bJugar.OnPressedColor = System.Drawing.Color.Black;
            this.bJugar.Size = new System.Drawing.Size(295, 70);
            this.bJugar.TabIndex = 15;
            this.bJugar.Text = "Iniciar como Jugador";
            this.bJugar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bJugar.Click += new System.EventHandler(this.bJugar_Click_1);
            // 
            // bObservar
            // 
            this.bObservar.AnimationHoverSpeed = 0.07F;
            this.bObservar.AnimationSpeed = 0.03F;
            this.bObservar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.bObservar.BorderColor = System.Drawing.Color.Black;
            this.bObservar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.bObservar.CheckedBorderColor = System.Drawing.Color.Black;
            this.bObservar.CheckedForeColor = System.Drawing.Color.White;
            this.bObservar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("bObservar.CheckedImage")));
            this.bObservar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.bObservar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bObservar.Enabled = false;
            this.bObservar.FocusedColor = System.Drawing.Color.Empty;
            this.bObservar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bObservar.ForeColor = System.Drawing.Color.White;
            this.bObservar.Image = ((System.Drawing.Image)(resources.GetObject("bObservar.Image")));
            this.bObservar.ImageSize = new System.Drawing.Size(20, 20);
            this.bObservar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.bObservar.Location = new System.Drawing.Point(821, 323);
            this.bObservar.Name = "bObservar";
            this.bObservar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(131)))), ((int)(((byte)(135)))));
            this.bObservar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bObservar.OnHoverForeColor = System.Drawing.Color.White;
            this.bObservar.OnHoverImage = null;
            this.bObservar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.bObservar.OnPressedColor = System.Drawing.Color.Black;
            this.bObservar.Size = new System.Drawing.Size(295, 70);
            this.bObservar.TabIndex = 16;
            this.bObservar.Text = "Iniciar como Espectador";
            this.bObservar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bObservar.Click += new System.EventHandler(this.bObservar_Click_1);
            // 
            // bJugador1
            // 
            this.bJugador1.AnimationHoverSpeed = 0.07F;
            this.bJugador1.AnimationSpeed = 0.03F;
            this.bJugador1.BackColor = System.Drawing.Color.Transparent;
            this.bJugador1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.bJugador1.BorderColor = System.Drawing.Color.Black;
            this.bJugador1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bJugador1.FocusedColor = System.Drawing.Color.Empty;
            this.bJugador1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.bJugador1.ForeColor = System.Drawing.Color.White;
            this.bJugador1.Image = null;
            this.bJugador1.ImageSize = new System.Drawing.Size(52, 52);
            this.bJugador1.Location = new System.Drawing.Point(823, 430);
            this.bJugador1.Name = "bJugador1";
            this.bJugador1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(131)))), ((int)(((byte)(135)))));
            this.bJugador1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bJugador1.OnHoverForeColor = System.Drawing.Color.White;
            this.bJugador1.OnHoverImage = null;
            this.bJugador1.OnPressedColor = System.Drawing.Color.Black;
            this.bJugador1.Size = new System.Drawing.Size(65, 62);
            this.bJugador1.TabIndex = 17;
            this.bJugador1.Text = "1";
            this.bJugador1.Visible = false;
            this.bJugador1.Click += new System.EventHandler(this.bJugador1_Click_1);
            // 
            // bJugador2
            // 
            this.bJugador2.AnimationHoverSpeed = 0.07F;
            this.bJugador2.AnimationSpeed = 0.03F;
            this.bJugador2.BackColor = System.Drawing.Color.Transparent;
            this.bJugador2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.bJugador2.BorderColor = System.Drawing.Color.Black;
            this.bJugador2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bJugador2.FocusedColor = System.Drawing.Color.Empty;
            this.bJugador2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.bJugador2.ForeColor = System.Drawing.Color.White;
            this.bJugador2.Image = null;
            this.bJugador2.ImageSize = new System.Drawing.Size(52, 52);
            this.bJugador2.Location = new System.Drawing.Point(894, 430);
            this.bJugador2.Name = "bJugador2";
            this.bJugador2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(131)))), ((int)(((byte)(135)))));
            this.bJugador2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bJugador2.OnHoverForeColor = System.Drawing.Color.White;
            this.bJugador2.OnHoverImage = null;
            this.bJugador2.OnPressedColor = System.Drawing.Color.Black;
            this.bJugador2.Size = new System.Drawing.Size(65, 62);
            this.bJugador2.TabIndex = 18;
            this.bJugador2.Text = "2";
            this.bJugador2.Visible = false;
            this.bJugador2.Click += new System.EventHandler(this.bJugador2_Click_1);
            // 
            // bJugador3
            // 
            this.bJugador3.AnimationHoverSpeed = 0.07F;
            this.bJugador3.AnimationSpeed = 0.03F;
            this.bJugador3.BackColor = System.Drawing.Color.Transparent;
            this.bJugador3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.bJugador3.BorderColor = System.Drawing.Color.Black;
            this.bJugador3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bJugador3.FocusedColor = System.Drawing.Color.Empty;
            this.bJugador3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.bJugador3.ForeColor = System.Drawing.Color.White;
            this.bJugador3.Image = null;
            this.bJugador3.ImageSize = new System.Drawing.Size(52, 52);
            this.bJugador3.Location = new System.Drawing.Point(965, 430);
            this.bJugador3.Name = "bJugador3";
            this.bJugador3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(131)))), ((int)(((byte)(135)))));
            this.bJugador3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bJugador3.OnHoverForeColor = System.Drawing.Color.White;
            this.bJugador3.OnHoverImage = null;
            this.bJugador3.OnPressedColor = System.Drawing.Color.Black;
            this.bJugador3.Size = new System.Drawing.Size(65, 62);
            this.bJugador3.TabIndex = 19;
            this.bJugador3.Text = "3";
            this.bJugador3.Visible = false;
            this.bJugador3.Click += new System.EventHandler(this.bJugador3_Click_1);
            // 
            // bJugador4
            // 
            this.bJugador4.AnimationHoverSpeed = 0.07F;
            this.bJugador4.AnimationSpeed = 0.03F;
            this.bJugador4.BackColor = System.Drawing.Color.Transparent;
            this.bJugador4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.bJugador4.BorderColor = System.Drawing.Color.Black;
            this.bJugador4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bJugador4.FocusedColor = System.Drawing.Color.Empty;
            this.bJugador4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.bJugador4.ForeColor = System.Drawing.Color.White;
            this.bJugador4.Image = null;
            this.bJugador4.ImageSize = new System.Drawing.Size(52, 52);
            this.bJugador4.Location = new System.Drawing.Point(1036, 430);
            this.bJugador4.Name = "bJugador4";
            this.bJugador4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(131)))), ((int)(((byte)(135)))));
            this.bJugador4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bJugador4.OnHoverForeColor = System.Drawing.Color.White;
            this.bJugador4.OnHoverImage = null;
            this.bJugador4.OnPressedColor = System.Drawing.Color.Black;
            this.bJugador4.Size = new System.Drawing.Size(65, 62);
            this.bJugador4.TabIndex = 20;
            this.bJugador4.Text = "4";
            this.bJugador4.Visible = false;
            this.bJugador4.Click += new System.EventHandler(this.bJugador4_Click_1);
            // 
            // DificultadList
            // 
            this.DificultadList.BackColor = System.Drawing.Color.Transparent;
            this.DificultadList.BaseColor = System.Drawing.Color.White;
            this.DificultadList.BorderColor = System.Drawing.Color.Silver;
            this.DificultadList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DificultadList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DificultadList.FocusedColor = System.Drawing.Color.Empty;
            this.DificultadList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DificultadList.ForeColor = System.Drawing.Color.Black;
            this.DificultadList.FormattingEnabled = true;
            this.DificultadList.Location = new System.Drawing.Point(821, 518);
            this.DificultadList.Name = "DificultadList";
            this.DificultadList.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(131)))), ((int)(((byte)(135)))));
            this.DificultadList.OnHoverItemForeColor = System.Drawing.Color.White;
            this.DificultadList.Size = new System.Drawing.Size(295, 31);
            this.DificultadList.TabIndex = 21;
            this.DificultadList.Visible = false;
            this.DificultadList.SelectedIndexChanged += new System.EventHandler(this.DificultadList_SelectedIndexChanged_1);
            // 
            // select_player_label
            // 
            this.select_player_label.AutoSize = true;
            this.select_player_label.BackColor = System.Drawing.Color.Transparent;
            this.select_player_label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.select_player_label.Location = new System.Drawing.Point(817, 405);
            this.select_player_label.Name = "select_player_label";
            this.select_player_label.Size = new System.Drawing.Size(136, 20);
            this.select_player_label.TabIndex = 22;
            this.select_player_label.Text = "Seleccione jugador";
            this.select_player_label.Visible = false;
            // 
            // difficulty_label
            // 
            this.difficulty_label.AutoSize = true;
            this.difficulty_label.BackColor = System.Drawing.Color.Transparent;
            this.difficulty_label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.difficulty_label.Location = new System.Drawing.Point(819, 495);
            this.difficulty_label.Name = "difficulty_label";
            this.difficulty_label.Size = new System.Drawing.Size(147, 20);
            this.difficulty_label.TabIndex = 23;
            this.difficulty_label.Text = "Seleccione dificultad";
            this.difficulty_label.Visible = false;
            // 
            // quit_Game
            // 
            this.quit_Game.BackColor = System.Drawing.Color.Transparent;
            this.quit_Game.DialogResult = System.Windows.Forms.DialogResult.None;
            this.quit_Game.Image = ((System.Drawing.Image)(resources.GetObject("quit_Game.Image")));
            this.quit_Game.ImageSize = new System.Drawing.Size(64, 64);
            this.quit_Game.Location = new System.Drawing.Point(1185, 550);
            this.quit_Game.Name = "quit_Game";
            this.quit_Game.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("quit_Game.OnHoverImage")));
            this.quit_Game.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.quit_Game.Size = new System.Drawing.Size(88, 79);
            this.quit_Game.TabIndex = 25;
            this.quit_Game.Click += new System.EventHandler(this.quit_Game_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1285, 641);
            this.Controls.Add(this.quit_Game);
            this.Controls.Add(this.difficulty_label);
            this.Controls.Add(this.select_player_label);
            this.Controls.Add(this.DificultadList);
            this.Controls.Add(this.bJugador4);
            this.Controls.Add(this.bJugador3);
            this.Controls.Add(this.bJugador2);
            this.Controls.Add(this.bJugador1);
            this.Controls.Add(this.bObservar);
            this.Controls.Add(this.bJugar);
            this.Controls.Add(this.ListaPorts);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Snakes & Ladders";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaAdvenceButton bConnect;
        private Guna.UI.WinForms.GunaComboBox ListaPorts;
        private Guna.UI.WinForms.GunaAdvenceButton bJugar;
        private Guna.UI.WinForms.GunaAdvenceButton bObservar;
        private Guna.UI.WinForms.GunaCircleButton bJugador1;
        private Guna.UI.WinForms.GunaCircleButton bJugador2;
        private Guna.UI.WinForms.GunaCircleButton bJugador3;
        private Guna.UI.WinForms.GunaCircleButton bJugador4;
        private Guna.UI.WinForms.GunaComboBox DificultadList;
        private Guna.UI.WinForms.GunaLabel select_player_label;
        private Guna.UI.WinForms.GunaLabel difficulty_label;
        private Guna.UI.WinForms.GunaImageButton quit_Game;
    }
}

