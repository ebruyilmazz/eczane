
namespace EczaneOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastalarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastalarıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güvenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güvenceEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.MaskedTextBox();
            this.txtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastalarToolStripMenuItem,
            this.ilaçlarToolStripMenuItem,
            this.güvenceToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastalarToolStripMenuItem
            // 
            this.hastalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKaydıToolStripMenuItem,
            this.hastalarıListeleToolStripMenuItem,
            this.hastalarıSilToolStripMenuItem});
            this.hastalarToolStripMenuItem.Name = "hastalarToolStripMenuItem";
            this.hastalarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.hastalarToolStripMenuItem.Text = "Hastalar";
            // 
            // hastaKaydıToolStripMenuItem
            // 
            this.hastaKaydıToolStripMenuItem.Name = "hastaKaydıToolStripMenuItem";
            this.hastaKaydıToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.hastaKaydıToolStripMenuItem.Text = "Hasta Kaydı";
            this.hastaKaydıToolStripMenuItem.Click += new System.EventHandler(this.hastaKaydıToolStripMenuItem_Click);
            // 
            // hastalarıListeleToolStripMenuItem
            // 
            this.hastalarıListeleToolStripMenuItem.Name = "hastalarıListeleToolStripMenuItem";
            this.hastalarıListeleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.hastalarıListeleToolStripMenuItem.Text = "Hastaları Listele";
            this.hastalarıListeleToolStripMenuItem.Click += new System.EventHandler(this.hastalarıListeleToolStripMenuItem_Click);
            // 
            // hastalarıSilToolStripMenuItem
            // 
            this.hastalarıSilToolStripMenuItem.Name = "hastalarıSilToolStripMenuItem";
            this.hastalarıSilToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.hastalarıSilToolStripMenuItem.Text = "Hasta Sil";
            this.hastalarıSilToolStripMenuItem.Click += new System.EventHandler(this.hastalarıSilToolStripMenuItem_Click);
            // 
            // ilaçlarToolStripMenuItem
            // 
            this.ilaçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilaçKaydıToolStripMenuItem,
            this.ilaçListeleToolStripMenuItem,
            this.ilaçSilToolStripMenuItem});
            this.ilaçlarToolStripMenuItem.Name = "ilaçlarToolStripMenuItem";
            this.ilaçlarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ilaçlarToolStripMenuItem.Text = "İlaçlar";
            // 
            // ilaçKaydıToolStripMenuItem
            // 
            this.ilaçKaydıToolStripMenuItem.Name = "ilaçKaydıToolStripMenuItem";
            this.ilaçKaydıToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ilaçKaydıToolStripMenuItem.Text = "İlaç Kaydı";
            this.ilaçKaydıToolStripMenuItem.Click += new System.EventHandler(this.ilaçKaydıToolStripMenuItem_Click);
            // 
            // ilaçListeleToolStripMenuItem
            // 
            this.ilaçListeleToolStripMenuItem.Name = "ilaçListeleToolStripMenuItem";
            this.ilaçListeleToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ilaçListeleToolStripMenuItem.Text = "İlaç Listele";
            this.ilaçListeleToolStripMenuItem.Click += new System.EventHandler(this.ilaçListeleToolStripMenuItem_Click);
            // 
            // ilaçSilToolStripMenuItem
            // 
            this.ilaçSilToolStripMenuItem.Name = "ilaçSilToolStripMenuItem";
            this.ilaçSilToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ilaçSilToolStripMenuItem.Text = "İlaç Sil";
            this.ilaçSilToolStripMenuItem.Click += new System.EventHandler(this.ilaçSilToolStripMenuItem_Click);
            // 
            // güvenceToolStripMenuItem
            // 
            this.güvenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güvenceEkleToolStripMenuItem});
            this.güvenceToolStripMenuItem.Name = "güvenceToolStripMenuItem";
            this.güvenceToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.güvenceToolStripMenuItem.Text = "Güvence ";
            // 
            // güvenceEkleToolStripMenuItem
            // 
            this.güvenceEkleToolStripMenuItem.Name = "güvenceEkleToolStripMenuItem";
            this.güvenceEkleToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.güvenceEkleToolStripMenuItem.Text = "Güvence Ekle";
            this.güvenceEkleToolStripMenuItem.Click += new System.EventHandler(this.güvenceEkleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 253);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Barkod No";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(299, 43);
            this.txtBarkodNo.Mask = "00000";
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 20);
            this.txtBarkodNo.TabIndex = 5;
            this.txtBarkodNo.ValidatingType = typeof(int);
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(81, 39);
            this.txtTcNo.Mask = "00000000000";
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(100, 20);
            this.txtTcNo.TabIndex = 6;
            // 
            // numAdet
            // 
            this.numAdet.Location = new System.Drawing.Point(489, 44);
            this.numAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(83, 20);
            this.numAdet.TabIndex = 7;
            this.numAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adet";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(631, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Satış Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numAdet);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECZANE OTOMASYONU ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastalarıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastalarıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güvenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güvenceEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtBarkodNo;
        private System.Windows.Forms.MaskedTextBox txtTcNo;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

