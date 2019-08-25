namespace ajoutxt
{
    partial class ConratInfosForm
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
            this.premiers_partenaires = new System.Windows.Forms.Label();
            this.intitule_projet = new System.Windows.Forms.Label();
            this.montant = new System.Windows.Forms.Label();
            this.objectifs = new System.Windows.Forms.Label();
            this.num_montant = new System.Windows.Forms.NumericUpDown();
            this.txt_intitule_projet = new System.Windows.Forms.TextBox();
            this.list_partenaires1 = new System.Windows.Forms.ListBox();
            this.bnApplyData = new System.Windows.Forms.Button();
            this.textobjectif = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_montant)).BeginInit();
            this.SuspendLayout();
            // 
            // premiers_partenaires
            // 
            this.premiers_partenaires.AutoSize = true;
            this.premiers_partenaires.Location = new System.Drawing.Point(290, 143);
            this.premiers_partenaires.Name = "premiers_partenaires";
            this.premiers_partenaires.Size = new System.Drawing.Size(84, 13);
            this.premiers_partenaires.TabIndex = 0;
            this.premiers_partenaires.Text = "الأطراف المشاركة";
            this.premiers_partenaires.Click += new System.EventHandler(this.Premiers_partenaires_Click);
            // 
            // intitule_projet
            // 
            this.intitule_projet.AutoSize = true;
            this.intitule_projet.Location = new System.Drawing.Point(309, 230);
            this.intitule_projet.Name = "intitule_projet";
            this.intitule_projet.Size = new System.Drawing.Size(65, 13);
            this.intitule_projet.TabIndex = 2;
            this.intitule_projet.Text = "اسم المشروع";
            // 
            // montant
            // 
            this.montant.AutoSize = true;
            this.montant.Location = new System.Drawing.Point(311, 286);
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(63, 13);
            this.montant.TabIndex = 3;
            this.montant.Text = "المبلغ المالي";
            // 
            // objectifs
            // 
            this.objectifs.AutoSize = true;
            this.objectifs.Location = new System.Drawing.Point(331, 327);
            this.objectifs.Name = "objectifs";
            this.objectifs.Size = new System.Drawing.Size(43, 13);
            this.objectifs.TabIndex = 4;
            this.objectifs.Text = "الأهداف ";
            // 
            // num_montant
            // 
            this.num_montant.Location = new System.Drawing.Point(32, 286);
            this.num_montant.Name = "num_montant";
            this.num_montant.Size = new System.Drawing.Size(219, 20);
            this.num_montant.TabIndex = 10;
            this.num_montant.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // txt_intitule_projet
            // 
            this.txt_intitule_projet.Location = new System.Drawing.Point(32, 230);
            this.txt_intitule_projet.Multiline = true;
            this.txt_intitule_projet.Name = "txt_intitule_projet";
            this.txt_intitule_projet.Size = new System.Drawing.Size(219, 20);
            this.txt_intitule_projet.TabIndex = 7;
            this.txt_intitule_projet.TextChanged += new System.EventHandler(this.Txt_intitule_projet_TextChanged);
            // 
            // list_partenaires1
            // 
            this.list_partenaires1.AccessibleName = "";
            this.list_partenaires1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.list_partenaires1.FormattingEnabled = true;
            this.list_partenaires1.Location = new System.Drawing.Point(32, 143);
            this.list_partenaires1.Name = "list_partenaires1";
            this.list_partenaires1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.list_partenaires1.Size = new System.Drawing.Size(219, 69);
            this.list_partenaires1.TabIndex = 12;
            this.list_partenaires1.SelectedIndexChanged += new System.EventHandler(this.Txt_premiers_partenaires_SelectedIndexChanged);
            // 
            // bnApplyData
            // 
            this.bnApplyData.Location = new System.Drawing.Point(124, 383);
            this.bnApplyData.Name = "bnApplyData";
            this.bnApplyData.Size = new System.Drawing.Size(75, 23);
            this.bnApplyData.TabIndex = 16;
            this.bnApplyData.Text = "حفظ";
            this.bnApplyData.UseVisualStyleBackColor = true;
            this.bnApplyData.Click += new System.EventHandler(this.BnApplyData_Click);
            // 
            // textobjectif
            // 
            this.textobjectif.Location = new System.Drawing.Point(32, 327);
            this.textobjectif.Multiline = true;
            this.textobjectif.Name = "textobjectif";
            this.textobjectif.Size = new System.Drawing.Size(219, 20);
            this.textobjectif.TabIndex = 17;
            this.textobjectif.TextChanged += new System.EventHandler(this.Textobjectif_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "نموذج الإتفاقية";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ConratInfosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 443);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textobjectif);
            this.Controls.Add(this.bnApplyData);
            this.Controls.Add(this.list_partenaires1);
            this.Controls.Add(this.num_montant);
            this.Controls.Add(this.txt_intitule_projet);
            this.Controls.Add(this.objectifs);
            this.Controls.Add(this.montant);
            this.Controls.Add(this.intitule_projet);
            this.Controls.Add(this.premiers_partenaires);
            this.Name = "ConratInfosForm";
            this.ShowIcon = false;
            this.Text = "المعلومات المتعلقة بالإتفاقية";
            this.Load += new System.EventHandler(this.ConratInfosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_montant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label premiers_partenaires;
        private System.Windows.Forms.Label intitule_projet;
        private System.Windows.Forms.Label montant;
        private System.Windows.Forms.Label objectifs;
        private System.Windows.Forms.NumericUpDown num_montant;
        private System.Windows.Forms.TextBox txt_intitule_projet;
        private System.Windows.Forms.ListBox list_partenaires1;
        private System.Windows.Forms.Button bnApplyData;
        private System.Windows.Forms.TextBox textobjectif;
        private System.Windows.Forms.Button button2;
    }
}