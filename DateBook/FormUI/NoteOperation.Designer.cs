namespace DateBook.FormUI
{
    partial class NoteOperation
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
            this.btnAddNote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStringMoney = new System.Windows.Forms.Label();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.grpNote = new System.Windows.Forms.GroupBox();
            this.txtTittle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFinishDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNoteList = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNote
            // 
            this.btnAddNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNote.Location = new System.Drawing.Point(20, 346);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(369, 63);
            this.btnAddNote.TabIndex = 0;
            this.btnAddNote.Text = "Kaydet";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bugün Tarih";
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToday.Location = new System.Drawing.Point(105, 9);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(0, 18);
            this.lblToday.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.Location = new System.Drawing.Point(17, 140);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(68, 18);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Açıklama";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(20, 161);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(346, 93);
            this.rtbDescription.TabIndex = 4;
            this.rtbDescription.Text = "";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(20, 279);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 18);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Fiyat";
            // 
            // lblStringMoney
            // 
            this.lblStringMoney.AutoSize = true;
            this.lblStringMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStringMoney.Location = new System.Drawing.Point(27, 315);
            this.lblStringMoney.Name = "lblStringMoney";
            this.lblStringMoney.Size = new System.Drawing.Size(0, 18);
            this.lblStringMoney.TabIndex = 8;
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(74, 280);
            this.txtPaymentAmount.MaxLength = 6;
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(121, 20);
            this.txtPaymentAmount.TabIndex = 6;
            this.txtPaymentAmount.TextChanged += new System.EventHandler(this.tbxPrice_TextChanged);
            // 
            // grpNote
            // 
            this.grpNote.Controls.Add(this.txtTittle);
            this.grpNote.Controls.Add(this.label2);
            this.grpNote.Controls.Add(this.dtpFinishDate);
            this.grpNote.Controls.Add(this.rtbDescription);
            this.grpNote.Controls.Add(this.txtPaymentAmount);
            this.grpNote.Controls.Add(this.btnAddNote);
            this.grpNote.Controls.Add(this.lblStringMoney);
            this.grpNote.Controls.Add(this.label3);
            this.grpNote.Controls.Add(this.lblDescription);
            this.grpNote.Controls.Add(this.lblPrice);
            this.grpNote.Location = new System.Drawing.Point(187, 71);
            this.grpNote.Name = "grpNote";
            this.grpNote.Size = new System.Drawing.Size(410, 424);
            this.grpNote.TabIndex = 9;
            this.grpNote.TabStop = false;
            this.grpNote.Text = "Not";
            // 
            // txtTittle
            // 
            this.txtTittle.Location = new System.Drawing.Point(113, 101);
            this.txtTittle.MaxLength = 6;
            this.txtTittle.Name = "txtTittle";
            this.txtTittle.Size = new System.Drawing.Size(164, 20);
            this.txtTittle.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // dtpFinishDate
            // 
            this.dtpFinishDate.Location = new System.Drawing.Point(20, 60);
            this.dtpFinishDate.Name = "dtpFinishDate";
            this.dtpFinishDate.Size = new System.Drawing.Size(155, 20);
            this.dtpFinishDate.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Konu Başlığı";
            // 
            // dgvNoteList
            // 
            this.dgvNoteList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNoteList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvNoteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoteList.Location = new System.Drawing.Point(699, 100);
            this.dgvNoteList.Name = "dgvNoteList";
            this.dgvNoteList.Size = new System.Drawing.Size(611, 380);
            this.dgvNoteList.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1168, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(142, 20);
            this.txtSearch.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1132, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ara";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(331, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NoteOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvNoteList);
            this.Controls.Add(this.grpNote);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.label1);
            this.Name = "NoteOperation";
            this.Text = "Note";
            this.Load += new System.EventHandler(this.Note_Load);
            this.grpNote.ResumeLayout(false);
            this.grpNote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStringMoney;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.GroupBox grpNote;
        private System.Windows.Forms.DateTimePicker dtpFinishDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTittle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvNoteList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}