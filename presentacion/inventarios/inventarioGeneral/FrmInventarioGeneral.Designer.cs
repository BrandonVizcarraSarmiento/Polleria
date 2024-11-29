namespace Polleria.presentacion.inventarios.inventarioGeneral
{
    partial class FrmInventarioGeneral
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
            this.btnEditarInventarioGeneral = new FontAwesome.Sharp.IconButton();
            this.dtgvInventarioGeneral = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInventarioGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarInventarioGeneral
            // 
            this.btnEditarInventarioGeneral.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarInventarioGeneral.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarInventarioGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarInventarioGeneral.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarInventarioGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarInventarioGeneral.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarInventarioGeneral.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarInventarioGeneral.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarInventarioGeneral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarInventarioGeneral.IconSize = 21;
            this.btnEditarInventarioGeneral.Location = new System.Drawing.Point(185, 376);
            this.btnEditarInventarioGeneral.Name = "btnEditarInventarioGeneral";
            this.btnEditarInventarioGeneral.Size = new System.Drawing.Size(92, 33);
            this.btnEditarInventarioGeneral.TabIndex = 43;
            this.btnEditarInventarioGeneral.Text = "Editar";
            this.btnEditarInventarioGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarInventarioGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarInventarioGeneral.UseVisualStyleBackColor = false;
            // 
            // dtgvInventarioGeneral
            // 
            this.dtgvInventarioGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvInventarioGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvInventarioGeneral.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvInventarioGeneral.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgvInventarioGeneral.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvInventarioGeneral.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvInventarioGeneral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvInventarioGeneral.ColumnHeadersHeight = 30;
            this.dtgvInventarioGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvInventarioGeneral.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvInventarioGeneral.EnableHeadersVisualStyles = false;
            this.dtgvInventarioGeneral.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvInventarioGeneral.Location = new System.Drawing.Point(185, 155);
            this.dtgvInventarioGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvInventarioGeneral.Name = "dtgvInventarioGeneral";
            this.dtgvInventarioGeneral.ReadOnly = true;
            this.dtgvInventarioGeneral.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvInventarioGeneral.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvInventarioGeneral.RowHeadersWidth = 51;
            this.dtgvInventarioGeneral.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dtgvInventarioGeneral.RowTemplate.Height = 24;
            this.dtgvInventarioGeneral.Size = new System.Drawing.Size(434, 204);
            this.dtgvInventarioGeneral.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Inventario General:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(371, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Inventario General";
            // 
            // FrmInventarioGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditarInventarioGeneral);
            this.Controls.Add(this.dtgvInventarioGeneral);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventarioGeneral";
            this.Text = "FrmInventarioGeneral";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInventarioGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnEditarInventarioGeneral;
        private System.Windows.Forms.DataGridView dtgvInventarioGeneral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}