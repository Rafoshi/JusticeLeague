namespace BatSystem.View
{
    partial class AttackAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttackAdd));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxLocal = new System.Windows.Forms.TextBox();
            this.lblFinalidade = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVillain = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtTime = new System.Windows.Forms.MaskedTextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(177)))), ((int)(((byte)(12)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(879, 500);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(262, 68);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxLocal
            // 
            this.txtBoxLocal.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLocal.Location = new System.Drawing.Point(87, 103);
            this.txtBoxLocal.Name = "txtBoxLocal";
            this.txtBoxLocal.Size = new System.Drawing.Size(491, 30);
            this.txtBoxLocal.TabIndex = 39;
            // 
            // lblFinalidade
            // 
            this.lblFinalidade.AutoSize = true;
            this.lblFinalidade.Font = new System.Drawing.Font("Roboto Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalidade.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFinalidade.Location = new System.Drawing.Point(80, 247);
            this.lblFinalidade.Name = "lblFinalidade";
            this.lblFinalidade.Size = new System.Drawing.Size(112, 38);
            this.lblFinalidade.TabIndex = 38;
            this.lblFinalidade.Text = "Hora  :";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Roboto Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDesc.Location = new System.Drawing.Point(80, 157);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(101, 38);
            this.lblDesc.TabIndex = 37;
            this.lblDesc.Text = "Data :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Roboto Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(80, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 38);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "Local :";
            // 
            // lblVillain
            // 
            this.lblVillain.AutoSize = true;
            this.lblVillain.Font = new System.Drawing.Font("Roboto Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVillain.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVillain.Location = new System.Drawing.Point(80, 340);
            this.lblVillain.Name = "lblVillain";
            this.lblVillain.Size = new System.Drawing.Size(258, 38);
            this.lblVillain.TabIndex = 42;
            this.lblVillain.Text = "Vilão envolvido :";
            // 
            // txtData
            // 
            this.txtData.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.txtData.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(87, 209);
            this.txtData.Mask = "0000/00/00";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(136, 30);
            this.txtData.TabIndex = 44;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtTime
            // 
            this.txtTime.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.txtTime.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(87, 288);
            this.txtTime.Mask = "00:00:00";
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(136, 30);
            this.txtTime.TabIndex = 45;
            this.txtTime.ValidatingType = typeof(System.DateTime);
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(87, 395);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(251, 31);
            this.comboBox.TabIndex = 46;
            // 
            // AttackAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1300, 643);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblVillain);
            this.Controls.Add(this.txtBoxLocal);
            this.Controls.Add(this.lblFinalidade);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AttackAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttackAdd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxLocal;
        private System.Windows.Forms.Label lblFinalidade;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVillain;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.MaskedTextBox txtTime;
        private System.Windows.Forms.ComboBox comboBox;
    }
}