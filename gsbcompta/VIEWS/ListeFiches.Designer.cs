
namespace gsbcompta
{
    partial class ListeFiches
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
            this.dataGridViewBills = new System.Windows.Forms.DataGridView();
            this.groupBoxFixedFees = new System.Windows.Forms.GroupBox();
            this.buttonFixedFeesUpdate = new System.Windows.Forms.Button();
            this.labelFixedFeesREP = new System.Windows.Forms.Label();
            this.labelFixedFeesNUI = new System.Windows.Forms.Label();
            this.labelFixedFeesKM = new System.Windows.Forms.Label();
            this.textBoxFixedFeesREP = new System.Windows.Forms.TextBox();
            this.textBoxFixedFeesNUI = new System.Windows.Forms.TextBox();
            this.textBoxFixedFeesKM = new System.Windows.Forms.TextBox();
            this.groupBoxOffPrice = new System.Windows.Forms.GroupBox();
            this.dataGridViewOffPrice = new System.Windows.Forms.DataGridView();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.cbxEtat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxEtat = new System.Windows.Forms.TextBox();
            this.btnUpdateEtat = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).BeginInit();
            this.groupBoxFixedFees.SuspendLayout();
            this.groupBoxOffPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBills
            // 
            this.dataGridViewBills.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBills.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewBills.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBills.MultiSelect = false;
            this.dataGridViewBills.Name = "dataGridViewBills";
            this.dataGridViewBills.RowHeadersWidth = 51;
            this.dataGridViewBills.RowTemplate.Height = 24;
            this.dataGridViewBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBills.Size = new System.Drawing.Size(829, 376);
            this.dataGridViewBills.TabIndex = 0;
            this.dataGridViewBills.SelectionChanged += new System.EventHandler(this.dataGridViewBills_SelectionChanged);
            // 
            // groupBoxFixedFees
            // 
            this.groupBoxFixedFees.Controls.Add(this.buttonFixedFeesUpdate);
            this.groupBoxFixedFees.Controls.Add(this.labelFixedFeesREP);
            this.groupBoxFixedFees.Controls.Add(this.labelFixedFeesNUI);
            this.groupBoxFixedFees.Controls.Add(this.labelFixedFeesKM);
            this.groupBoxFixedFees.Controls.Add(this.textBoxFixedFeesREP);
            this.groupBoxFixedFees.Controls.Add(this.textBoxFixedFeesNUI);
            this.groupBoxFixedFees.Controls.Add(this.textBoxFixedFeesKM);
            this.groupBoxFixedFees.Location = new System.Drawing.Point(847, 42);
            this.groupBoxFixedFees.Name = "groupBoxFixedFees";
            this.groupBoxFixedFees.Size = new System.Drawing.Size(444, 132);
            this.groupBoxFixedFees.TabIndex = 1;
            this.groupBoxFixedFees.TabStop = false;
            this.groupBoxFixedFees.Text = "Frais Forfait";
            // 
            // buttonFixedFeesUpdate
            // 
            this.buttonFixedFeesUpdate.Location = new System.Drawing.Point(302, 83);
            this.buttonFixedFeesUpdate.Name = "buttonFixedFeesUpdate";
            this.buttonFixedFeesUpdate.Size = new System.Drawing.Size(90, 23);
            this.buttonFixedFeesUpdate.TabIndex = 5;
            this.buttonFixedFeesUpdate.Text = "Modifier";
            this.buttonFixedFeesUpdate.UseVisualStyleBackColor = true;
            this.buttonFixedFeesUpdate.Click += new System.EventHandler(this.buttonFixedFeesUpdate_Click);
            // 
            // labelFixedFeesREP
            // 
            this.labelFixedFeesREP.AutoSize = true;
            this.labelFixedFeesREP.Location = new System.Drawing.Point(31, 83);
            this.labelFixedFeesREP.Name = "labelFixedFeesREP";
            this.labelFixedFeesREP.Size = new System.Drawing.Size(49, 17);
            this.labelFixedFeesREP.TabIndex = 5;
            this.labelFixedFeesREP.Text = "Repas";
            // 
            // labelFixedFeesNUI
            // 
            this.labelFixedFeesNUI.AutoSize = true;
            this.labelFixedFeesNUI.Location = new System.Drawing.Point(250, 40);
            this.labelFixedFeesNUI.Name = "labelFixedFeesNUI";
            this.labelFixedFeesNUI.Size = new System.Drawing.Size(33, 17);
            this.labelFixedFeesNUI.TabIndex = 4;
            this.labelFixedFeesNUI.Text = "Nuit";
            // 
            // labelFixedFeesKM
            // 
            this.labelFixedFeesKM.AutoSize = true;
            this.labelFixedFeesKM.Location = new System.Drawing.Point(13, 38);
            this.labelFixedFeesKM.Name = "labelFixedFeesKM";
            this.labelFixedFeesKM.Size = new System.Drawing.Size(74, 17);
            this.labelFixedFeesKM.TabIndex = 3;
            this.labelFixedFeesKM.Text = "Kilomètres";
            // 
            // textBoxFixedFeesREP
            // 
            this.textBoxFixedFeesREP.Location = new System.Drawing.Point(93, 78);
            this.textBoxFixedFeesREP.Name = "textBoxFixedFeesREP";
            this.textBoxFixedFeesREP.Size = new System.Drawing.Size(100, 22);
            this.textBoxFixedFeesREP.TabIndex = 3;
            // 
            // textBoxFixedFeesNUI
            // 
            this.textBoxFixedFeesNUI.Location = new System.Drawing.Point(302, 35);
            this.textBoxFixedFeesNUI.Name = "textBoxFixedFeesNUI";
            this.textBoxFixedFeesNUI.Size = new System.Drawing.Size(100, 22);
            this.textBoxFixedFeesNUI.TabIndex = 4;
            // 
            // textBoxFixedFeesKM
            // 
            this.textBoxFixedFeesKM.Location = new System.Drawing.Point(93, 35);
            this.textBoxFixedFeesKM.Name = "textBoxFixedFeesKM";
            this.textBoxFixedFeesKM.Size = new System.Drawing.Size(100, 22);
            this.textBoxFixedFeesKM.TabIndex = 2;
            // 
            // groupBoxOffPrice
            // 
            this.groupBoxOffPrice.Controls.Add(this.dataGridViewOffPrice);
            this.groupBoxOffPrice.Location = new System.Drawing.Point(847, 180);
            this.groupBoxOffPrice.Name = "groupBoxOffPrice";
            this.groupBoxOffPrice.Size = new System.Drawing.Size(444, 208);
            this.groupBoxOffPrice.TabIndex = 2;
            this.groupBoxOffPrice.TabStop = false;
            this.groupBoxOffPrice.Text = "Frais Hors Forfait";
            // 
            // dataGridViewOffPrice
            // 
            this.dataGridViewOffPrice.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewOffPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffPrice.Location = new System.Drawing.Point(16, 21);
            this.dataGridViewOffPrice.Name = "dataGridViewOffPrice";
            this.dataGridViewOffPrice.RowHeadersWidth = 51;
            this.dataGridViewOffPrice.RowTemplate.Height = 24;
            this.dataGridViewOffPrice.Size = new System.Drawing.Size(424, 187);
            this.dataGridViewOffPrice.TabIndex = 6;
            this.dataGridViewOffPrice.SelectionChanged += new System.EventHandler(this.dataGridViewOffPrice_SelectionChanged);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAddUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddUser.Location = new System.Drawing.Point(863, 433);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(424, 58);
            this.buttonAddUser.TabIndex = 7;
            this.buttonAddUser.Text = "AJOUTER UTILISATEUR";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // cbxEtat
            // 
            this.cbxEtat.FormattingEnabled = true;
            this.cbxEtat.Items.AddRange(new object[] {
            "CR",
            "CL",
            "VA",
            "RB"});
            this.cbxEtat.Location = new System.Drawing.Point(200, 483);
            this.cbxEtat.Name = "cbxEtat";
            this.cbxEtat.Size = new System.Drawing.Size(417, 24);
            this.cbxEtat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Etat de la fiche de frais :";
            // 
            // txtBoxEtat
            // 
            this.txtBoxEtat.Enabled = false;
            this.txtBoxEtat.Location = new System.Drawing.Point(200, 435);
            this.txtBoxEtat.Name = "txtBoxEtat";
            this.txtBoxEtat.Size = new System.Drawing.Size(417, 22);
            this.txtBoxEtat.TabIndex = 6;
            // 
            // btnUpdateEtat
            // 
            this.btnUpdateEtat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateEtat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEtat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateEtat.Location = new System.Drawing.Point(200, 548);
            this.btnUpdateEtat.Name = "btnUpdateEtat";
            this.btnUpdateEtat.Size = new System.Drawing.Size(417, 58);
            this.btnUpdateEtat.TabIndex = 8;
            this.btnUpdateEtat.Text = "MODIFIER L\'ETAT DE LA FICHE";
            this.btnUpdateEtat.UseVisualStyleBackColor = false;
            this.btnUpdateEtat.Click += new System.EventHandler(this.btnUpdateEtat_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDisconnect.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDisconnect.Location = new System.Drawing.Point(863, 548);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(424, 58);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "DECONNEXION";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // ListeFiches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 636);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnUpdateEtat);
            this.Controls.Add(this.txtBoxEtat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEtat);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.groupBoxOffPrice);
            this.Controls.Add(this.groupBoxFixedFees);
            this.Controls.Add(this.dataGridViewBills);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListeFiches";
            this.Text = "ListeFiches";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).EndInit();
            this.groupBoxFixedFees.ResumeLayout(false);
            this.groupBoxFixedFees.PerformLayout();
            this.groupBoxOffPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBills;
        private System.Windows.Forms.GroupBox groupBoxFixedFees;
        private System.Windows.Forms.TextBox textBoxFixedFeesKM;
        private System.Windows.Forms.GroupBox groupBoxOffPrice;
        private System.Windows.Forms.TextBox textBoxFixedFeesREP;
        private System.Windows.Forms.TextBox textBoxFixedFeesNUI;
        private System.Windows.Forms.Label labelFixedFeesREP;
        private System.Windows.Forms.Label labelFixedFeesNUI;
        private System.Windows.Forms.Label labelFixedFeesKM;
        private System.Windows.Forms.DataGridView dataGridViewOffPrice;
        private System.Windows.Forms.Button buttonFixedFeesUpdate;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.ComboBox cbxEtat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxEtat;
        private System.Windows.Forms.Button btnUpdateEtat;
        private System.Windows.Forms.Button btnDisconnect;
    }
}