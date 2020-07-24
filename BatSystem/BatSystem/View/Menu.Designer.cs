namespace BatSystem
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHero = new System.Windows.Forms.Label();
            this.btnHero = new System.Windows.Forms.Button();
            this.btnAddHero = new System.Windows.Forms.Button();
            this.lblVillan = new System.Windows.Forms.Label();
            this.btnVillan = new System.Windows.Forms.Button();
            this.btnAddVilan = new System.Windows.Forms.Button();
            this.lblAtttack = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblEquip = new System.Windows.Forms.Label();
            this.btnEquip = new System.Windows.Forms.Button();
            this.batlogoCenter = new System.Windows.Forms.PictureBox();
            this.picBoxExit = new System.Windows.Forms.PictureBox();
            this.btnVillainConsul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.batlogoCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(1, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(135, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Bat Sistema";
            // 
            // lblHero
            // 
            this.lblHero.AutoSize = true;
            this.lblHero.Font = new System.Drawing.Font("Roboto Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHero.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHero.Location = new System.Drawing.Point(188, 269);
            this.lblHero.Name = "lblHero";
            this.lblHero.Size = new System.Drawing.Size(110, 38);
            this.lblHero.TabIndex = 3;
            this.lblHero.Text = "Heróis";
            // 
            // btnHero
            // 
            this.btnHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(177)))), ((int)(((byte)(12)))));
            this.btnHero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHero.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHero.ForeColor = System.Drawing.Color.Transparent;
            this.btnHero.Location = new System.Drawing.Point(34, 460);
            this.btnHero.Name = "btnHero";
            this.btnHero.Size = new System.Drawing.Size(188, 46);
            this.btnHero.TabIndex = 4;
            this.btnHero.Text = "Consultar";
            this.btnHero.UseVisualStyleBackColor = false;
            this.btnHero.Click += new System.EventHandler(this.btnHero_Click);
            // 
            // btnAddHero
            // 
            this.btnAddHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(177)))), ((int)(((byte)(12)))));
            this.btnAddHero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddHero.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHero.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddHero.Location = new System.Drawing.Point(258, 460);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(188, 46);
            this.btnAddHero.TabIndex = 5;
            this.btnAddHero.Text = "Adicionar";
            this.btnAddHero.UseVisualStyleBackColor = false;
            this.btnAddHero.Click += new System.EventHandler(this.btnAddHero_Click);
            // 
            // lblVillan
            // 
            this.lblVillan.AutoSize = true;
            this.lblVillan.Font = new System.Drawing.Font("Roboto Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVillan.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVillan.Location = new System.Drawing.Point(990, 269);
            this.lblVillan.Name = "lblVillan";
            this.lblVillan.Size = new System.Drawing.Size(107, 38);
            this.lblVillan.TabIndex = 6;
            this.lblVillan.Text = "Vilões";
            // 
            // btnVillan
            // 
            this.btnVillan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.btnVillan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVillan.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVillan.ForeColor = System.Drawing.Color.Transparent;
            this.btnVillan.Location = new System.Drawing.Point(830, 460);
            this.btnVillan.Name = "btnVillan";
            this.btnVillan.Size = new System.Drawing.Size(188, 46);
            this.btnVillan.TabIndex = 7;
            this.btnVillan.Text = "Consultar";
            this.btnVillan.UseVisualStyleBackColor = false;
            this.btnVillan.Click += new System.EventHandler(this.btnVillan_Click);
            // 
            // btnAddVilan
            // 
            this.btnAddVilan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.btnAddVilan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddVilan.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVilan.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddVilan.Location = new System.Drawing.Point(1064, 460);
            this.btnAddVilan.Name = "btnAddVilan";
            this.btnAddVilan.Size = new System.Drawing.Size(188, 46);
            this.btnAddVilan.TabIndex = 8;
            this.btnAddVilan.Text = "Adicionar";
            this.btnAddVilan.UseVisualStyleBackColor = false;
            this.btnAddVilan.Click += new System.EventHandler(this.btnAddVilan_Click);
            // 
            // lblAtttack
            // 
            this.lblAtttack.AutoSize = true;
            this.lblAtttack.Font = new System.Drawing.Font("Roboto Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtttack.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAtttack.Location = new System.Drawing.Point(579, 12);
            this.lblAtttack.Name = "lblAtttack";
            this.lblAtttack.Size = new System.Drawing.Size(136, 38);
            this.lblAtttack.TabIndex = 9;
            this.lblAtttack.Text = "Ataques";
            this.lblAtttack.Click += new System.EventHandler(this.lblAtttack_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(13)))));
            this.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAttack.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.ForeColor = System.Drawing.Color.Transparent;
            this.btnAttack.Location = new System.Drawing.Point(656, 118);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(151, 46);
            this.btnAttack.TabIndex = 10;
            this.btnAttack.Text = "Marcar";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblEquip
            // 
            this.lblEquip.AutoSize = true;
            this.lblEquip.Font = new System.Drawing.Font("Roboto Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquip.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEquip.Location = new System.Drawing.Point(526, 442);
            this.lblEquip.Name = "lblEquip";
            this.lblEquip.Size = new System.Drawing.Size(223, 38);
            this.lblEquip.TabIndex = 11;
            this.lblEquip.Text = "Equipamentos";
            // 
            // btnEquip
            // 
            this.btnEquip.BackColor = System.Drawing.Color.Silver;
            this.btnEquip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEquip.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquip.ForeColor = System.Drawing.Color.Transparent;
            this.btnEquip.Location = new System.Drawing.Point(549, 533);
            this.btnEquip.Name = "btnEquip";
            this.btnEquip.Size = new System.Drawing.Size(188, 46);
            this.btnEquip.TabIndex = 12;
            this.btnEquip.Text = "Adicionar";
            this.btnEquip.UseVisualStyleBackColor = false;
            this.btnEquip.Click += new System.EventHandler(this.btnEquip_Click);
            // 
            // batlogoCenter
            // 
            this.batlogoCenter.Image = ((System.Drawing.Image)(resources.GetObject("batlogoCenter.Image")));
            this.batlogoCenter.Location = new System.Drawing.Point(469, 242);
            this.batlogoCenter.Name = "batlogoCenter";
            this.batlogoCenter.Size = new System.Drawing.Size(338, 197);
            this.batlogoCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.batlogoCenter.TabIndex = 0;
            this.batlogoCenter.TabStop = false;
            this.batlogoCenter.Click += new System.EventHandler(this.batlogoCenter_Click);
            // 
            // picBoxExit
            // 
            this.picBoxExit.Image = global::BatSystem.Properties.Resources.a;
            this.picBoxExit.Location = new System.Drawing.Point(1262, 12);
            this.picBoxExit.Name = "picBoxExit";
            this.picBoxExit.Size = new System.Drawing.Size(26, 16);
            this.picBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxExit.TabIndex = 1;
            this.picBoxExit.TabStop = false;
            this.picBoxExit.Click += new System.EventHandler(this.picBoxExit_Click);
            // 
            // btnVillainConsul
            // 
            this.btnVillainConsul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(13)))));
            this.btnVillainConsul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVillainConsul.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVillainConsul.ForeColor = System.Drawing.Color.Transparent;
            this.btnVillainConsul.Location = new System.Drawing.Point(469, 118);
            this.btnVillainConsul.Name = "btnVillainConsul";
            this.btnVillainConsul.Size = new System.Drawing.Size(151, 46);
            this.btnVillainConsul.TabIndex = 13;
            this.btnVillainConsul.Text = "Consultar";
            this.btnVillainConsul.UseVisualStyleBackColor = false;
            this.btnVillainConsul.Click += new System.EventHandler(this.btnVillainConsul_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1300, 643);
            this.Controls.Add(this.btnVillainConsul);
            this.Controls.Add(this.btnEquip);
            this.Controls.Add(this.lblEquip);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblAtttack);
            this.Controls.Add(this.btnAddVilan);
            this.Controls.Add(this.btnVillan);
            this.Controls.Add(this.lblVillan);
            this.Controls.Add(this.btnAddHero);
            this.Controls.Add(this.btnHero);
            this.Controls.Add(this.lblHero);
            this.Controls.Add(this.batlogoCenter);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picBoxExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.batlogoCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox batlogoCenter;
        private System.Windows.Forms.PictureBox picBoxExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHero;
        private System.Windows.Forms.Button btnHero;
        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.Label lblVillan;
        private System.Windows.Forms.Button btnVillan;
        private System.Windows.Forms.Button btnAddVilan;
        private System.Windows.Forms.Label lblAtttack;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblEquip;
        private System.Windows.Forms.Button btnEquip;
        private System.Windows.Forms.Button btnVillainConsul;
    }
}