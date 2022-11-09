namespace AppCine_Grupo10
{
    partial class FrmPanelCartelera
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.DGMenuPanel3 = new System.Windows.Forms.DataGridView();
            this.CboPeliculas = new System.Windows.Forms.ComboBox();
            this.CboIdioma = new System.Windows.Forms.ComboBox();
            this.CboTipo = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGMenuPanel3)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.LblTitulo.Location = new System.Drawing.Point(5, 5);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(252, 61);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Cartelera";
            // 
            // DGMenuPanel3
            // 
            this.DGMenuPanel3.AllowUserToAddRows = false;
            this.DGMenuPanel3.AllowUserToDeleteRows = false;
            this.DGMenuPanel3.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(142)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGMenuPanel3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGMenuPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGMenuPanel3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGMenuPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.DGMenuPanel3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGMenuPanel3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGMenuPanel3.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGMenuPanel3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGMenuPanel3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGMenuPanel3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMenuPanel3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(142)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGMenuPanel3.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGMenuPanel3.EnableHeadersVisualStyles = false;
            this.DGMenuPanel3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            this.DGMenuPanel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGMenuPanel3.Location = new System.Drawing.Point(0, 119);
            this.DGMenuPanel3.Name = "DGMenuPanel3";
            this.DGMenuPanel3.ReadOnly = true;
            this.DGMenuPanel3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle4.NullValue = "-";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(142)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGMenuPanel3.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGMenuPanel3.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(142)))), ((int)(((byte)(226)))));
            this.DGMenuPanel3.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGMenuPanel3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGMenuPanel3.Size = new System.Drawing.Size(745, 438);
            this.DGMenuPanel3.TabIndex = 8;
            // 
            // CboPeliculas
            // 
            this.CboPeliculas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboPeliculas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboPeliculas.BackColor = System.Drawing.SystemColors.Window;
            this.CboPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboPeliculas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.CboPeliculas.FormattingEnabled = true;
            this.CboPeliculas.Location = new System.Drawing.Point(12, 81);
            this.CboPeliculas.MaxDropDownItems = 10;
            this.CboPeliculas.Name = "CboPeliculas";
            this.CboPeliculas.Size = new System.Drawing.Size(282, 32);
            this.CboPeliculas.Sorted = true;
            this.CboPeliculas.TabIndex = 9;
            this.CboPeliculas.Text = "Peliculas";
            // 
            // CboIdioma
            // 
            this.CboIdioma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboIdioma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboIdioma.BackColor = System.Drawing.SystemColors.Window;
            this.CboIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.CboIdioma.FormattingEnabled = true;
            this.CboIdioma.Location = new System.Drawing.Point(300, 81);
            this.CboIdioma.MaxDropDownItems = 10;
            this.CboIdioma.Name = "CboIdioma";
            this.CboIdioma.Size = new System.Drawing.Size(215, 32);
            this.CboIdioma.Sorted = true;
            this.CboIdioma.TabIndex = 10;
            this.CboIdioma.Text = "Idioma";
            // 
            // CboTipo
            // 
            this.CboTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboTipo.BackColor = System.Drawing.SystemColors.Window;
            this.CboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.CboTipo.FormattingEnabled = true;
            this.CboTipo.Location = new System.Drawing.Point(521, 81);
            this.CboTipo.MaxDropDownItems = 10;
            this.CboTipo.Name = "CboTipo";
            this.CboTipo.Size = new System.Drawing.Size(215, 32);
            this.CboTipo.Sorted = true;
            this.CboTipo.TabIndex = 11;
            this.CboTipo.Text = "Tipo";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Clasificacion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Duracion";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sala";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "AsientosLibres";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // FrmPanelCartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(743, 557);
            this.Controls.Add(this.CboTipo);
            this.Controls.Add(this.CboIdioma);
            this.Controls.Add(this.CboPeliculas);
            this.Controls.Add(this.DGMenuPanel3);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPanelCartelera";
            this.Text = "FrmPanelCartelera";
            this.Load += new System.EventHandler(this.FrmPanelCartelera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGMenuPanel3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridView DGMenuPanel3;
        private System.Windows.Forms.ComboBox CboPeliculas;
        private System.Windows.Forms.ComboBox CboIdioma;
        private System.Windows.Forms.ComboBox CboTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}