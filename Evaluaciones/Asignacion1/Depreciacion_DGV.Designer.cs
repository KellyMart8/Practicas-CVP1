namespace Asignacion1
{
    partial class Depreciacion_DGV
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtDepre = new System.Windows.Forms.TextBox();
            this.mtValorBien = new System.Windows.Forms.MaskedTextBox();
            this.chlbxTipoBien = new System.Windows.Forms.CheckedListBox();
            this.lbxTipoD = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Valor del bien";
            // 
            // txtDepre
            // 
            this.txtDepre.Enabled = false;
            this.txtDepre.Location = new System.Drawing.Point(141, 287);
            this.txtDepre.Name = "txtDepre";
            this.txtDepre.Size = new System.Drawing.Size(100, 23);
            this.txtDepre.TabIndex = 19;
            // 
            // mtValorBien
            // 
            this.mtValorBien.Location = new System.Drawing.Point(141, 219);
            this.mtValorBien.Mask = "99999999999999999";
            this.mtValorBien.Name = "mtValorBien";
            this.mtValorBien.Size = new System.Drawing.Size(100, 23);
            this.mtValorBien.TabIndex = 18;
            this.mtValorBien.ValidatingType = typeof(int);
            // 
            // chlbxTipoBien
            // 
            this.chlbxTipoBien.FormattingEnabled = true;
            this.chlbxTipoBien.Items.AddRange(new object[] {
            "Vehiculo",
            "Edificio",
            "Equipo de oficina"});
            this.chlbxTipoBien.Location = new System.Drawing.Point(141, 122);
            this.chlbxTipoBien.Name = "chlbxTipoBien";
            this.chlbxTipoBien.Size = new System.Drawing.Size(179, 58);
            this.chlbxTipoBien.TabIndex = 17;
            // 
            // lbxTipoD
            // 
            this.lbxTipoD.FormattingEnabled = true;
            this.lbxTipoD.ItemHeight = 15;
            this.lbxTipoD.Items.AddRange(new object[] {
            "Linea recta",
            "Suma de digitos"});
            this.lbxTipoD.Location = new System.Drawing.Point(141, 53);
            this.lbxTipoD.Name = "lbxTipoD";
            this.lbxTipoD.Size = new System.Drawing.Size(179, 34);
            this.lbxTipoD.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Depreciacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tipo de bien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tipo de depreciacion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(422, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(341, 189);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(404, 286);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 22;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Depreciacion_DGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDepre);
            this.Controls.Add(this.mtValorBien);
            this.Controls.Add(this.chlbxTipoBien);
            this.Controls.Add(this.lbxTipoD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Depreciacion_DGV";
            this.Text = "Depreciacion_DGV";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private TextBox txtDepre;
        private MaskedTextBox mtValorBien;
        private CheckedListBox chlbxTipoBien;
        private ListBox lbxTipoD;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnCalc;
    }
}