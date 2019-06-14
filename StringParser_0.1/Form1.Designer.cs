namespace StringParser_0._1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.parsingResultGrid = new System.Windows.Forms.DataGridView();
            this.parseBtn = new System.Windows.Forms.Button();
            this.bibliographTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.doiTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pageRangeTextBox = new System.Windows.Forms.TextBox();
            this.engTitleBtn = new System.Windows.Forms.Button();
            this.rusTitleBtn = new System.Windows.Forms.Button();
            this.ukrTitleBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.engAnnotBtn = new System.Windows.Forms.Button();
            this.ukrAnnotBtn = new System.Windows.Forms.Button();
            this.rusAnnotBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.refsCountTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parsingResultGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // parsingResultGrid
            // 
            this.parsingResultGrid.AllowUserToAddRows = false;
            this.parsingResultGrid.AllowUserToDeleteRows = false;
            this.parsingResultGrid.AllowUserToResizeColumns = false;
            this.parsingResultGrid.AllowUserToResizeRows = false;
            this.parsingResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parsingResultGrid.Location = new System.Drawing.Point(12, 58);
            this.parsingResultGrid.MultiSelect = false;
            this.parsingResultGrid.Name = "parsingResultGrid";
            this.parsingResultGrid.Size = new System.Drawing.Size(261, 316);
            this.parsingResultGrid.TabIndex = 2;
            this.parsingResultGrid.SelectionChanged += new System.EventHandler(this.parsingResultGrid_SelectionChanged);
            // 
            // parseBtn
            // 
            this.parseBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.parseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parseBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.parseBtn.Location = new System.Drawing.Point(279, 12);
            this.parseBtn.Name = "parseBtn";
            this.parseBtn.Size = new System.Drawing.Size(187, 40);
            this.parseBtn.TabIndex = 3;
            this.parseBtn.Text = "Parse";
            this.parseBtn.UseVisualStyleBackColor = true;
            this.parseBtn.Click += new System.EventHandler(this.parseBtn_Click);
            // 
            // bibliographTextBox
            // 
            this.bibliographTextBox.Location = new System.Drawing.Point(12, 460);
            this.bibliographTextBox.Name = "bibliographTextBox";
            this.bibliographTextBox.Size = new System.Drawing.Size(776, 20);
            this.bibliographTextBox.TabIndex = 4;
            this.bibliographTextBox.TextChanged += new System.EventHandler(this.bibliographTextBox_TextChanged);
            this.bibliographTextBox.Enter += new System.EventHandler(this.bibliographTextBox_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ФИО для библиографии";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.ForeColor = System.Drawing.Color.Red;
            this.clearBtn.Location = new System.Drawing.Point(509, 12);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(122, 40);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(12, 32);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(261, 20);
            this.urlTextBox.TabIndex = 0;
            // 
            // doiTextBox
            // 
            this.doiTextBox.Location = new System.Drawing.Point(323, 64);
            this.doiTextBox.Name = "doiTextBox";
            this.doiTextBox.Size = new System.Drawing.Size(176, 20);
            this.doiTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(279, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "DOI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(505, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "PageRange";
            // 
            // pageRangeTextBox
            // 
            this.pageRangeTextBox.Location = new System.Drawing.Point(612, 66);
            this.pageRangeTextBox.Name = "pageRangeTextBox";
            this.pageRangeTextBox.Size = new System.Drawing.Size(68, 20);
            this.pageRangeTextBox.TabIndex = 10;
            // 
            // engTitleBtn
            // 
            this.engTitleBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.engTitleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engTitleBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.engTitleBtn.Location = new System.Drawing.Point(6, 34);
            this.engTitleBtn.Name = "engTitleBtn";
            this.engTitleBtn.Size = new System.Drawing.Size(187, 40);
            this.engTitleBtn.TabIndex = 11;
            this.engTitleBtn.Text = "ENGLISH";
            this.engTitleBtn.UseVisualStyleBackColor = true;
            this.engTitleBtn.Click += new System.EventHandler(this.engTitleBtn_Click);
            // 
            // rusTitleBtn
            // 
            this.rusTitleBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.rusTitleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rusTitleBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rusTitleBtn.Location = new System.Drawing.Point(6, 157);
            this.rusTitleBtn.Name = "rusTitleBtn";
            this.rusTitleBtn.Size = new System.Drawing.Size(187, 40);
            this.rusTitleBtn.TabIndex = 12;
            this.rusTitleBtn.Text = "RUSSIAN";
            this.rusTitleBtn.UseVisualStyleBackColor = true;
            this.rusTitleBtn.Click += new System.EventHandler(this.rusTitleBtn_Click);
            // 
            // ukrTitleBtn
            // 
            this.ukrTitleBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ukrTitleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ukrTitleBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ukrTitleBtn.Location = new System.Drawing.Point(6, 98);
            this.ukrTitleBtn.Name = "ukrTitleBtn";
            this.ukrTitleBtn.Size = new System.Drawing.Size(187, 40);
            this.ukrTitleBtn.TabIndex = 13;
            this.ukrTitleBtn.Text = "UKRAINE";
            this.ukrTitleBtn.UseVisualStyleBackColor = true;
            this.ukrTitleBtn.Click += new System.EventHandler(this.ukrTitleBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.engTitleBtn);
            this.groupBox1.Controls.Add(this.ukrTitleBtn);
            this.groupBox1.Controls.Add(this.rusTitleBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(289, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 219);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Title Language";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.engAnnotBtn);
            this.groupBox2.Controls.Add(this.ukrAnnotBtn);
            this.groupBox2.Controls.Add(this.rusAnnotBtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(585, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 219);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Annotation Language";
            // 
            // engAnnotBtn
            // 
            this.engAnnotBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.engAnnotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engAnnotBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.engAnnotBtn.Location = new System.Drawing.Point(6, 34);
            this.engAnnotBtn.Name = "engAnnotBtn";
            this.engAnnotBtn.Size = new System.Drawing.Size(187, 40);
            this.engAnnotBtn.TabIndex = 11;
            this.engAnnotBtn.Text = "ENGLISH";
            this.engAnnotBtn.UseVisualStyleBackColor = true;
            // 
            // ukrAnnotBtn
            // 
            this.ukrAnnotBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ukrAnnotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ukrAnnotBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ukrAnnotBtn.Location = new System.Drawing.Point(6, 98);
            this.ukrAnnotBtn.Name = "ukrAnnotBtn";
            this.ukrAnnotBtn.Size = new System.Drawing.Size(187, 40);
            this.ukrAnnotBtn.TabIndex = 13;
            this.ukrAnnotBtn.Text = "UKRAINE";
            this.ukrAnnotBtn.UseVisualStyleBackColor = true;
            // 
            // rusAnnotBtn
            // 
            this.rusAnnotBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.rusAnnotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rusAnnotBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rusAnnotBtn.Location = new System.Drawing.Point(6, 157);
            this.rusAnnotBtn.Name = "rusAnnotBtn";
            this.rusAnnotBtn.Size = new System.Drawing.Size(187, 40);
            this.rusAnnotBtn.TabIndex = 12;
            this.rusAnnotBtn.Text = "RUSSIAN";
            this.rusAnnotBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(686, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Refs";
            // 
            // refsCountTextBox
            // 
            this.refsCountTextBox.Location = new System.Drawing.Point(735, 68);
            this.refsCountTextBox.Name = "refsCountTextBox";
            this.refsCountTextBox.Size = new System.Drawing.Size(49, 20);
            this.refsCountTextBox.TabIndex = 17;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.Location = new System.Drawing.Point(289, 129);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(495, 26);
            this.titleTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(505, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.refsCountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pageRangeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doiTextBox);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bibliographTextBox);
            this.Controls.Add(this.parseBtn);
            this.Controls.Add(this.parsingResultGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlTextBox);
            this.Name = "Form1";
            this.Text = "Url Parser";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.parsingResultGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView parsingResultGrid;
        private System.Windows.Forms.Button parseBtn;
        private System.Windows.Forms.TextBox bibliographTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox doiTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pageRangeTextBox;
        private System.Windows.Forms.Button engTitleBtn;
        private System.Windows.Forms.Button rusTitleBtn;
        private System.Windows.Forms.Button ukrTitleBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button engAnnotBtn;
        private System.Windows.Forms.Button ukrAnnotBtn;
        private System.Windows.Forms.Button rusAnnotBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox refsCountTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label6;
    }
}

