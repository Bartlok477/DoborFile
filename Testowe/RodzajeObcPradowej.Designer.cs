namespace Testowe
{
    partial class RodzajeObcPradowej
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RodzajeObcPradowej));
            this.d_grid_1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.p_typ_izolacji = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.p_typ_zyl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p_struktura_fazowa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.d_grid_1)).BeginInit();
            this.SuspendLayout();
            // 
            // d_grid_1
            // 
            this.d_grid_1.AllowUserToAddRows = false;
            this.d_grid_1.AllowUserToDeleteRows = false;
            this.d_grid_1.AllowUserToResizeColumns = false;
            this.d_grid_1.AllowUserToResizeRows = false;
            this.d_grid_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.d_grid_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.d_grid_1.Location = new System.Drawing.Point(1, 126);
            this.d_grid_1.Margin = new System.Windows.Forms.Padding(0);
            this.d_grid_1.MultiSelect = false;
            this.d_grid_1.Name = "d_grid_1";
            this.d_grid_1.ReadOnly = true;
            this.d_grid_1.RowHeadersWidth = 25;
            this.d_grid_1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.d_grid_1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.d_grid_1.ShowCellErrors = false;
            this.d_grid_1.ShowCellToolTips = false;
            this.d_grid_1.ShowEditingIcon = false;
            this.d_grid_1.ShowRowErrors = false;
            this.d_grid_1.Size = new System.Drawing.Size(460, 371);
            this.d_grid_1.TabIndex = 0;
            this.d_grid_1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.d_grid_1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rodzaj izolacji:";
            // 
            // p_typ_izolacji
            // 
            this.p_typ_izolacji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p_typ_izolacji.FormattingEnabled = true;
            this.p_typ_izolacji.Items.AddRange(new object[] {
            "PVC",
            "XPLE"});
            this.p_typ_izolacji.Location = new System.Drawing.Point(285, 25);
            this.p_typ_izolacji.Name = "p_typ_izolacji";
            this.p_typ_izolacji.Size = new System.Drawing.Size(121, 21);
            this.p_typ_izolacji.TabIndex = 10;
            this.p_typ_izolacji.SelectedIndexChanged += new System.EventHandler(this.p_typ_izolacji_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Typ żył:";
            // 
            // p_typ_zyl
            // 
            this.p_typ_zyl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p_typ_zyl.FormattingEnabled = true;
            this.p_typ_zyl.Items.AddRange(new object[] {
            "Aluminium",
            "Miedź"});
            this.p_typ_zyl.Location = new System.Drawing.Point(148, 25);
            this.p_typ_zyl.Name = "p_typ_zyl";
            this.p_typ_zyl.Size = new System.Drawing.Size(121, 21);
            this.p_typ_zyl.TabIndex = 8;
            this.p_typ_zyl.SelectedIndexChanged += new System.EventHandler(this.p_typ_zyl_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Liczba faz:";
            // 
            // p_struktura_fazowa
            // 
            this.p_struktura_fazowa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p_struktura_fazowa.FormattingEnabled = true;
            this.p_struktura_fazowa.Items.AddRange(new object[] {
            "1-faz",
            "3-faz"});
            this.p_struktura_fazowa.Location = new System.Drawing.Point(12, 25);
            this.p_struktura_fazowa.Name = "p_struktura_fazowa";
            this.p_struktura_fazowa.Size = new System.Drawing.Size(121, 21);
            this.p_struktura_fazowa.TabIndex = 6;
            this.p_struktura_fazowa.SelectedIndexChanged += new System.EventHandler(this.p_struktura_fazowa_SelectedIndexChanged);
            // 
            // RodzajeObcPradowej
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(463, 502);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.p_typ_izolacji);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p_typ_zyl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p_struktura_fazowa);
            this.Controls.Add(this.d_grid_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(500, 500);
            this.Name = "RodzajeObcPradowej";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obciążalność przewodów-Norma";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.d_grid_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView d_grid_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox p_typ_izolacji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox p_typ_zyl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox p_struktura_fazowa;
    }
}