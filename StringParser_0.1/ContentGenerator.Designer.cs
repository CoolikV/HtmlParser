namespace StringParser_0._1
{
    partial class ContentGenerator
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
            this.loadPageBtn = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.insertNewTBnt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.articlesCountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.topicComboBox = new System.Windows.Forms.ComboBox();
            this.articleTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadPageBtn
            // 
            this.loadPageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadPageBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loadPageBtn.Location = new System.Drawing.Point(12, 51);
            this.loadPageBtn.Name = "loadPageBtn";
            this.loadPageBtn.Size = new System.Drawing.Size(100, 33);
            this.loadPageBtn.TabIndex = 0;
            this.loadPageBtn.Text = "Load page";
            this.loadPageBtn.UseVisualStyleBackColor = true;
            this.loadPageBtn.Click += new System.EventHandler(this.loadPageBtn_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.urlTextBox.Location = new System.Drawing.Point(12, 19);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(265, 26);
            this.urlTextBox.TabIndex = 1;
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(12, 121);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(923, 540);
            this.contentTextBox.TabIndex = 2;
            // 
            // insertNewTBnt
            // 
            this.insertNewTBnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertNewTBnt.ForeColor = System.Drawing.Color.Green;
            this.insertNewTBnt.Location = new System.Drawing.Point(793, 13);
            this.insertNewTBnt.Name = "insertNewTBnt";
            this.insertNewTBnt.Size = new System.Drawing.Size(142, 33);
            this.insertNewTBnt.TabIndex = 3;
            this.insertNewTBnt.Text = "Insert new topic";
            this.insertNewTBnt.UseVisualStyleBackColor = true;
            this.insertNewTBnt.Click += new System.EventHandler(this.insertNewTBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(363, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select topic";
            // 
            // articlesCountTextBox
            // 
            this.articlesCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.articlesCountTextBox.Location = new System.Drawing.Point(723, 19);
            this.articlesCountTextBox.Name = "articlesCountTextBox";
            this.articlesCountTextBox.Size = new System.Drawing.Size(64, 26);
            this.articlesCountTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(639, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Art. count";
            // 
            // topicComboBox
            // 
            this.topicComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topicComboBox.FormattingEnabled = true;
            this.topicComboBox.Location = new System.Drawing.Point(461, 18);
            this.topicComboBox.Name = "topicComboBox";
            this.topicComboBox.Size = new System.Drawing.Size(159, 28);
            this.topicComboBox.TabIndex = 8;
            // 
            // articleTitle
            // 
            this.articleTitle.AutoSize = true;
            this.articleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.articleTitle.Location = new System.Drawing.Point(404, 86);
            this.articleTitle.Name = "articleTitle";
            this.articleTitle.Size = new System.Drawing.Size(51, 20);
            this.articleTitle.TabIndex = 9;
            this.articleTitle.Text = "Name";
            // 
            // ContentGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 673);
            this.Controls.Add(this.articleTitle);
            this.Controls.Add(this.topicComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.articlesCountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertNewTBnt);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.loadPageBtn);
            this.Name = "ContentGenerator";
            this.Text = "ContentGenerator";
            this.Load += new System.EventHandler(this.ContentGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadPageBtn;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Button insertNewTBnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox articlesCountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox topicComboBox;
        private System.Windows.Forms.Label articleTitle;
    }
}