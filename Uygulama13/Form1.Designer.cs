namespace Uygulama13
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.lbNesne = new System.Windows.Forms.ListBox();
            this.btnNesneEkle = new System.Windows.Forms.Button();
            this.radioButtonBay = new System.Windows.Forms.RadioButton();
            this.radioButtonBayan = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyeti";
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(533, 50);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(100, 20);
            this.txtOgrenciNo.TabIndex = 5;
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(533, 87);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtAdiSoyadi.TabIndex = 6;
            // 
            // lbNesne
            // 
            this.lbNesne.FormattingEnabled = true;
            this.lbNesne.Location = new System.Drawing.Point(533, 197);
            this.lbNesne.Name = "lbNesne";
            this.lbNesne.Size = new System.Drawing.Size(195, 199);
            this.lbNesne.TabIndex = 7;
            // 
            // btnNesneEkle
            // 
            this.btnNesneEkle.Location = new System.Drawing.Point(547, 158);
            this.btnNesneEkle.Name = "btnNesneEkle";
            this.btnNesneEkle.Size = new System.Drawing.Size(75, 23);
            this.btnNesneEkle.TabIndex = 8;
            this.btnNesneEkle.Text = "Nesne Ekle";
            this.btnNesneEkle.UseVisualStyleBackColor = true;
            this.btnNesneEkle.Click += new System.EventHandler(this.btnNesneEkle_Click);
            // 
            // radioButtonBay
            // 
            this.radioButtonBay.AutoSize = true;
            this.radioButtonBay.Location = new System.Drawing.Point(533, 123);
            this.radioButtonBay.Name = "radioButtonBay";
            this.radioButtonBay.Size = new System.Drawing.Size(43, 17);
            this.radioButtonBay.TabIndex = 9;
            this.radioButtonBay.TabStop = true;
            this.radioButtonBay.Text = "Bay";
            this.radioButtonBay.UseVisualStyleBackColor = true;
            // 
            // radioButtonBayan
            // 
            this.radioButtonBayan.AutoSize = true;
            this.radioButtonBayan.Location = new System.Drawing.Point(596, 123);
            this.radioButtonBayan.Name = "radioButtonBayan";
            this.radioButtonBayan.Size = new System.Drawing.Size(55, 17);
            this.radioButtonBayan.TabIndex = 10;
            this.radioButtonBayan.TabStop = true;
            this.radioButtonBayan.Text = "Bayan";
            this.radioButtonBayan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.radioButtonBayan);
            this.Controls.Add(this.radioButtonBay);
            this.Controls.Add(this.btnNesneEkle);
            this.Controls.Add(this.lbNesne);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.txtOgrenciNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.ListBox lbNesne;
        private System.Windows.Forms.Button btnNesneEkle;
        private System.Windows.Forms.RadioButton radioButtonBay;
        private System.Windows.Forms.RadioButton radioButtonBayan;
    }
}

