namespace Escalera.Forms
{
    partial class Juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Tableros = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Score1 = new System.Windows.Forms.Label();
            this.Score2 = new System.Windows.Forms.Label();
            this.Score3 = new System.Windows.Forms.Label();
            this.Score4 = new System.Windows.Forms.Label();
            this.Mensaje = new System.Windows.Forms.Label();
            this.DadoL = new System.Windows.Forms.Label();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox4 = new Guna.UI.WinForms.GunaPictureBox();
            this.Dado = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dice_Pic = new Guna.UI.WinForms.GunaPictureBox();
            this.Tablero = new Guna.UI.WinForms.GunaPictureBox();
            this.boardLabel = new Guna.UI.WinForms.GunaLabel();
            this.boardComboBox = new Guna.UI.WinForms.GunaComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Tableros
            // 
            this.Tableros.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Tableros.ImageStream")));
            this.Tableros.TransparentColor = System.Drawing.Color.Transparent;
            this.Tableros.Images.SetKeyName(0, "tablero-1.jpg");
            this.Tableros.Images.SetKeyName(1, "tablero-2.jpg");
            this.Tableros.Images.SetKeyName(2, "tablero-3.jpg");
            this.Tableros.Images.SetKeyName(3, "tablero-4.jpg");
            this.Tableros.Images.SetKeyName(4, "tablero-5.jpg");
            this.Tableros.Images.SetKeyName(5, "tablero-6.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jugador 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(202, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jugador 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jugador 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(202, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jugador 4:";
            // 
            // Score1
            // 
            this.Score1.AutoSize = true;
            this.Score1.ForeColor = System.Drawing.Color.Green;
            this.Score1.Location = new System.Drawing.Point(97, 85);
            this.Score1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score1.Name = "Score1";
            this.Score1.Size = new System.Drawing.Size(16, 17);
            this.Score1.TabIndex = 5;
            this.Score1.Text = "0";
            // 
            // Score2
            // 
            this.Score2.AutoSize = true;
            this.Score2.ForeColor = System.Drawing.Color.Brown;
            this.Score2.Location = new System.Drawing.Point(277, 85);
            this.Score2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(16, 17);
            this.Score2.TabIndex = 6;
            this.Score2.Text = "0";
            // 
            // Score3
            // 
            this.Score3.AutoSize = true;
            this.Score3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Score3.Location = new System.Drawing.Point(97, 246);
            this.Score3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score3.Name = "Score3";
            this.Score3.Size = new System.Drawing.Size(16, 17);
            this.Score3.TabIndex = 7;
            this.Score3.Text = "0";
            // 
            // Score4
            // 
            this.Score4.AutoSize = true;
            this.Score4.ForeColor = System.Drawing.Color.Red;
            this.Score4.Location = new System.Drawing.Point(277, 246);
            this.Score4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score4.Name = "Score4";
            this.Score4.Size = new System.Drawing.Size(16, 17);
            this.Score4.TabIndex = 8;
            this.Score4.Text = "0";
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSize = true;
            this.Mensaje.BackColor = System.Drawing.Color.Transparent;
            this.Mensaje.ForeColor = System.Drawing.Color.Black;
            this.Mensaje.Location = new System.Drawing.Point(264, 456);
            this.Mensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(62, 17);
            this.Mensaje.TabIndex = 9;
            this.Mensaje.Text = "Tu turno";
            this.Mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mensaje.Visible = false;
            // 
            // DadoL
            // 
            this.DadoL.AutoSize = true;
            this.DadoL.BackColor = System.Drawing.Color.Transparent;
            this.DadoL.ForeColor = System.Drawing.Color.Black;
            this.DadoL.Location = new System.Drawing.Point(264, 473);
            this.DadoL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DadoL.Name = "DadoL";
            this.DadoL.Size = new System.Drawing.Size(16, 17);
            this.DadoL.TabIndex = 11;
            this.DadoL.Text = "0";
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1259, -1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 12;
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
            this.gunaControlBox2.Location = new System.Drawing.Point(1208, -1);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 13;
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
            this.gunaPictureBox1.Location = new System.Drawing.Point(27, 108);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(120, 120);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 14;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(206, 108);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(120, 120);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 15;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox3.Image")));
            this.gunaPictureBox3.Location = new System.Drawing.Point(27, 269);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(120, 120);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox3.TabIndex = 16;
            this.gunaPictureBox3.TabStop = false;
            // 
            // gunaPictureBox4
            // 
            this.gunaPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox4.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox4.Image")));
            this.gunaPictureBox4.Location = new System.Drawing.Point(206, 269);
            this.gunaPictureBox4.Name = "gunaPictureBox4";
            this.gunaPictureBox4.Size = new System.Drawing.Size(120, 120);
            this.gunaPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox4.TabIndex = 17;
            this.gunaPictureBox4.TabStop = false;
            // 
            // Dado
            // 
            this.Dado.AnimationHoverSpeed = 0.07F;
            this.Dado.AnimationSpeed = 0.03F;
            this.Dado.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.Dado.BorderColor = System.Drawing.Color.Black;
            this.Dado.CheckedBaseColor = System.Drawing.Color.Gray;
            this.Dado.CheckedBorderColor = System.Drawing.Color.Black;
            this.Dado.CheckedForeColor = System.Drawing.Color.White;
            this.Dado.CheckedImage = ((System.Drawing.Image)(resources.GetObject("Dado.CheckedImage")));
            this.Dado.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Dado.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Dado.Enabled = false;
            this.Dado.FocusedColor = System.Drawing.Color.Empty;
            this.Dado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Dado.ForeColor = System.Drawing.Color.White;
            this.Dado.Image = ((System.Drawing.Image)(resources.GetObject("Dado.Image")));
            this.Dado.ImageSize = new System.Drawing.Size(20, 20);
            this.Dado.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Dado.Location = new System.Drawing.Point(112, 548);
            this.Dado.Name = "Dado";
            this.Dado.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(131)))), ((int)(((byte)(135)))));
            this.Dado.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Dado.OnHoverForeColor = System.Drawing.Color.White;
            this.Dado.OnHoverImage = null;
            this.Dado.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Dado.OnPressedColor = System.Drawing.Color.Black;
            this.Dado.Size = new System.Drawing.Size(153, 42);
            this.Dado.TabIndex = 18;
            this.Dado.Text = "Lanzar Dado";
            this.Dado.Click += new System.EventHandler(this.Dado_Click_1);
            // 
            // dice_Pic
            // 
            this.dice_Pic.BackColor = System.Drawing.Color.Transparent;
            this.dice_Pic.BaseColor = System.Drawing.Color.White;
            this.dice_Pic.Image = ((System.Drawing.Image)(resources.GetObject("dice_Pic.Image")));
            this.dice_Pic.Location = new System.Drawing.Point(128, 409);
            this.dice_Pic.Name = "dice_Pic";
            this.dice_Pic.Size = new System.Drawing.Size(120, 120);
            this.dice_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice_Pic.TabIndex = 19;
            this.dice_Pic.TabStop = false;
            this.dice_Pic.Click += new System.EventHandler(this.dice_Pic_Click);
            // 
            // Tablero
            // 
            this.Tablero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tablero.BackgroundImage")));
            this.Tablero.BaseColor = System.Drawing.Color.White;
            this.Tablero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tablero.Location = new System.Drawing.Point(446, 53);
            this.Tablero.Name = "Tablero";
            this.Tablero.Size = new System.Drawing.Size(807, 572);
            this.Tablero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tablero.TabIndex = 20;
            this.Tablero.TabStop = false;
            // 
            // boardLabel
            // 
            this.boardLabel.AutoSize = true;
            this.boardLabel.BackColor = System.Drawing.Color.Transparent;
            this.boardLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boardLabel.Location = new System.Drawing.Point(27, 610);
            this.boardLabel.Name = "boardLabel";
            this.boardLabel.Size = new System.Drawing.Size(136, 20);
            this.boardLabel.TabIndex = 21;
            this.boardLabel.Text = "Seleccione Tablero:";
            this.boardLabel.Visible = false;
            // 
            // boardComboBox
            // 
            this.boardComboBox.BackColor = System.Drawing.Color.Transparent;
            this.boardComboBox.BaseColor = System.Drawing.Color.White;
            this.boardComboBox.BorderColor = System.Drawing.Color.Silver;
            this.boardComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.boardComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boardComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.boardComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.boardComboBox.ForeColor = System.Drawing.Color.Black;
            this.boardComboBox.FormattingEnabled = true;
            this.boardComboBox.Location = new System.Drawing.Point(169, 605);
            this.boardComboBox.Name = "boardComboBox";
            this.boardComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.boardComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.boardComboBox.Size = new System.Drawing.Size(157, 31);
            this.boardComboBox.TabIndex = 22;
            this.boardComboBox.Visible = false;
            this.boardComboBox.SelectedIndexChanged += new System.EventHandler(this.boardComboBox_SelectedIndexChanged);
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1303, 688);
            this.Controls.Add(this.boardComboBox);
            this.Controls.Add(this.boardLabel);
            this.Controls.Add(this.Tablero);
            this.Controls.Add(this.dice_Pic);
            this.Controls.Add(this.Dado);
            this.Controls.Add(this.gunaPictureBox4);
            this.Controls.Add(this.gunaPictureBox3);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.DadoL);
            this.Controls.Add(this.Mensaje);
            this.Controls.Add(this.Score4);
            this.Controls.Add(this.Score3);
            this.Controls.Add(this.Score2);
            this.Controls.Add(this.Score1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Juego";
            this.Text = "Snakes & Ladders";
            this.Load += new System.EventHandler(this.Juego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ImageList Tableros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Score1;
        private System.Windows.Forms.Label Score2;
        private System.Windows.Forms.Label Score3;
        private System.Windows.Forms.Label Score4;
        private System.Windows.Forms.Label Mensaje;
        private System.Windows.Forms.Label DadoL;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox4;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaAdvenceButton Dado;
        private Guna.UI.WinForms.GunaPictureBox dice_Pic;
        private Guna.UI.WinForms.GunaPictureBox Tablero;
        private Guna.UI.WinForms.GunaComboBox boardComboBox;
        private Guna.UI.WinForms.GunaLabel boardLabel;
    }
}