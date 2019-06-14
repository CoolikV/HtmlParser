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
            this.namesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parsingResultGrid = new System.Windows.Forms.DataGridView();
            this.parseBtn = new System.Windows.Forms.Button();
            this.bibliographTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parsingResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // namesTextBox
            // 
            this.namesTextBox.Location = new System.Drawing.Point(12, 48);
            this.namesTextBox.Name = "namesTextBox";
            this.namesTextBox.Size = new System.Drawing.Size(776, 20);
            this.namesTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список фамилий";
            // 
            // parsingResultGrid
            // 
            this.parsingResultGrid.AllowUserToAddRows = false;
            this.parsingResultGrid.AllowUserToDeleteRows = false;
            this.parsingResultGrid.AllowUserToResizeColumns = false;
            this.parsingResultGrid.AllowUserToResizeRows = false;
            this.parsingResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parsingResultGrid.Location = new System.Drawing.Point(12, 94);
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
            this.parseBtn.Location = new System.Drawing.Point(502, 94);
            this.parseBtn.Name = "parseBtn";
            this.parseBtn.Size = new System.Drawing.Size(286, 94);
            this.parseBtn.TabIndex = 3;
            this.parseBtn.Text = "Parse";
            this.parseBtn.UseVisualStyleBackColor = true;
            this.parseBtn.Click += new System.EventHandler(this.parseBtn_Click);
            // 
            // bibliographTextBox
            // 
            this.bibliographTextBox.Location = new System.Drawing.Point(12, 436);
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
            this.label2.Location = new System.Drawing.Point(12, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ФИО для библиографии";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.ForeColor = System.Drawing.Color.Red;
            this.clearBtn.Location = new System.Drawing.Point(615, 247);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(173, 70);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bibliographTextBox);
            this.Controls.Add(this.parseBtn);
            this.Controls.Add(this.parsingResultGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namesTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.parsingResultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView parsingResultGrid;
        private System.Windows.Forms.Button parseBtn;
        private System.Windows.Forms.TextBox bibliographTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearBtn;
    }
}

