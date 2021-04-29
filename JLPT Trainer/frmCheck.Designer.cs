
namespace JLPT_Trainer
{
    partial class frmCheck
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
            this.tlpCardTypes = new System.Windows.Forms.TableLayoutPanel();
            this.btnUserCards = new System.Windows.Forms.Button();
            this.btnAllCards = new System.Windows.Forms.Button();
            this.tlpMainContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblWhich = new System.Windows.Forms.Label();
            this.lblMeanings = new System.Windows.Forms.Label();
            this.lblReading = new System.Windows.Forms.Label();
            this.lblVocab = new System.Windows.Forms.Label();
            this.tbVocabItem = new System.Windows.Forms.TextBox();
            this.tbReading = new System.Windows.Forms.TextBox();
            this.tbMeanings = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbN4 = new System.Windows.Forms.CheckBox();
            this.cbN5 = new System.Windows.Forms.CheckBox();
            this.lblAnyCards = new System.Windows.Forms.Label();
            this.lbCards = new System.Windows.Forms.ListBox();
            this.tlpCardTypes.SuspendLayout();
            this.tlpMainContent.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCardTypes
            // 
            this.tlpCardTypes.ColumnCount = 2;
            this.tlpCardTypes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCardTypes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCardTypes.Controls.Add(this.btnUserCards, 0, 0);
            this.tlpCardTypes.Controls.Add(this.btnAllCards, 1, 0);
            this.tlpCardTypes.Location = new System.Drawing.Point(12, 12);
            this.tlpCardTypes.Name = "tlpCardTypes";
            this.tlpCardTypes.RowCount = 1;
            this.tlpCardTypes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCardTypes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpCardTypes.Size = new System.Drawing.Size(611, 38);
            this.tlpCardTypes.TabIndex = 0;
            // 
            // btnUserCards
            // 
            this.btnUserCards.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUserCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserCards.Location = new System.Drawing.Point(194, 3);
            this.btnUserCards.Name = "btnUserCards";
            this.btnUserCards.Size = new System.Drawing.Size(108, 32);
            this.btnUserCards.TabIndex = 0;
            this.btnUserCards.Text = "User Cards";
            this.btnUserCards.UseVisualStyleBackColor = true;
            this.btnUserCards.Click += new System.EventHandler(this.btnUserCards_Click);
            // 
            // btnAllCards
            // 
            this.btnAllCards.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAllCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllCards.Location = new System.Drawing.Point(308, 3);
            this.btnAllCards.Name = "btnAllCards";
            this.btnAllCards.Size = new System.Drawing.Size(108, 32);
            this.btnAllCards.TabIndex = 1;
            this.btnAllCards.Text = "All Cards";
            this.btnAllCards.UseVisualStyleBackColor = true;
            this.btnAllCards.Click += new System.EventHandler(this.btnAllCards_Click);
            // 
            // tlpMainContent
            // 
            this.tlpMainContent.ColumnCount = 2;
            this.tlpMainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.53333F));
            this.tlpMainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.46667F));
            this.tlpMainContent.Controls.Add(this.lblWhich, 0, 0);
            this.tlpMainContent.Controls.Add(this.lblMeanings, 0, 4);
            this.tlpMainContent.Controls.Add(this.lblReading, 0, 2);
            this.tlpMainContent.Controls.Add(this.lblVocab, 0, 0);
            this.tlpMainContent.Controls.Add(this.tbVocabItem, 0, 1);
            this.tlpMainContent.Controls.Add(this.tbReading, 0, 3);
            this.tlpMainContent.Controls.Add(this.tbMeanings, 0, 5);
            this.tlpMainContent.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tlpMainContent.Controls.Add(this.lblAnyCards, 1, 3);
            this.tlpMainContent.Location = new System.Drawing.Point(13, 57);
            this.tlpMainContent.Name = "tlpMainContent";
            this.tlpMainContent.RowCount = 6;
            this.tlpMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.88889F));
            this.tlpMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.11111F));
            this.tlpMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.80582F));
            this.tlpMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tlpMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tlpMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainContent.Size = new System.Drawing.Size(375, 381);
            this.tlpMainContent.TabIndex = 1;
            // 
            // lblWhich
            // 
            this.lblWhich.AutoSize = true;
            this.lblWhich.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblWhich.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhich.Location = new System.Drawing.Point(229, 21);
            this.lblWhich.Name = "lblWhich";
            this.lblWhich.Size = new System.Drawing.Size(143, 18);
            this.lblWhich.TabIndex = 7;
            this.lblWhich.Text = "Which level?";
            // 
            // lblMeanings
            // 
            this.lblMeanings.AutoSize = true;
            this.lblMeanings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMeanings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeanings.Location = new System.Drawing.Point(3, 213);
            this.lblMeanings.Name = "lblMeanings";
            this.lblMeanings.Size = new System.Drawing.Size(220, 18);
            this.lblMeanings.TabIndex = 2;
            this.lblMeanings.Text = "Meanings:";
            // 
            // lblReading
            // 
            this.lblReading.AutoSize = true;
            this.lblReading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReading.Location = new System.Drawing.Point(3, 117);
            this.lblReading.Name = "lblReading";
            this.lblReading.Size = new System.Drawing.Size(220, 18);
            this.lblReading.TabIndex = 1;
            this.lblReading.Text = "Reading:";
            // 
            // lblVocab
            // 
            this.lblVocab.AutoSize = true;
            this.lblVocab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblVocab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVocab.Location = new System.Drawing.Point(3, 21);
            this.lblVocab.Name = "lblVocab";
            this.lblVocab.Size = new System.Drawing.Size(220, 18);
            this.lblVocab.TabIndex = 0;
            this.lblVocab.Text = "Vocabulary Item:";
            // 
            // tbVocabItem
            // 
            this.tbVocabItem.Font = new System.Drawing.Font("Meiryo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVocabItem.Location = new System.Drawing.Point(3, 42);
            this.tbVocabItem.Multiline = true;
            this.tbVocabItem.Name = "tbVocabItem";
            this.tbVocabItem.ReadOnly = true;
            this.tbVocabItem.Size = new System.Drawing.Size(220, 31);
            this.tbVocabItem.TabIndex = 4;
            this.tbVocabItem.Text = "天気";
            // 
            // tbReading
            // 
            this.tbReading.Font = new System.Drawing.Font("Meiryo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReading.Location = new System.Drawing.Point(3, 138);
            this.tbReading.Multiline = true;
            this.tbReading.Name = "tbReading";
            this.tbReading.ReadOnly = true;
            this.tbReading.Size = new System.Drawing.Size(220, 31);
            this.tbReading.TabIndex = 5;
            this.tbReading.Text = "てんき";
            // 
            // tbMeanings
            // 
            this.tbMeanings.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMeanings.Location = new System.Drawing.Point(3, 234);
            this.tbMeanings.Multiline = true;
            this.tbMeanings.Name = "tbMeanings";
            this.tbMeanings.ReadOnly = true;
            this.tbMeanings.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbMeanings.Size = new System.Drawing.Size(220, 125);
            this.tbMeanings.TabIndex = 6;
            this.tbMeanings.Text = "weather, the elements, fine weather, fair weather";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbN4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbN5, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(229, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(143, 36);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // cbN4
            // 
            this.cbN4.AutoCheck = false;
            this.cbN4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbN4.Location = new System.Drawing.Point(74, 3);
            this.cbN4.Name = "cbN4";
            this.cbN4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cbN4.Size = new System.Drawing.Size(66, 30);
            this.cbN4.TabIndex = 1;
            this.cbN4.Text = "N4";
            this.cbN4.UseVisualStyleBackColor = true;
            // 
            // cbN5
            // 
            this.cbN5.AutoCheck = false;
            this.cbN5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbN5.Location = new System.Drawing.Point(3, 3);
            this.cbN5.Name = "cbN5";
            this.cbN5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cbN5.Size = new System.Drawing.Size(65, 30);
            this.cbN5.TabIndex = 0;
            this.cbN5.Text = "N5";
            this.cbN5.UseVisualStyleBackColor = true;
            // 
            // lblAnyCards
            // 
            this.lblAnyCards.AutoSize = true;
            this.lblAnyCards.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAnyCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnyCards.Location = new System.Drawing.Point(229, 138);
            this.lblAnyCards.Name = "lblAnyCards";
            this.lblAnyCards.Size = new System.Drawing.Size(143, 60);
            this.lblAnyCards.TabIndex = 9;
            this.lblAnyCards.Text = "You haven\'t learned any cards yet!";
            this.lblAnyCards.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblAnyCards.Visible = false;
            // 
            // lbCards
            // 
            this.lbCards.Font = new System.Drawing.Font("Meiryo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCards.FormattingEnabled = true;
            this.lbCards.ItemHeight = 28;
            this.lbCards.Items.AddRange(new object[] {
            "天気"});
            this.lbCards.Location = new System.Drawing.Point(391, 63);
            this.lbCards.Name = "lbCards";
            this.lbCards.ScrollAlwaysVisible = true;
            this.lbCards.Size = new System.Drawing.Size(229, 368);
            this.lbCards.TabIndex = 2;
            this.lbCards.SelectedIndexChanged += new System.EventHandler(this.lbCards_SelectedIndexChanged);
            // 
            // frmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.lbCards);
            this.Controls.Add(this.tlpMainContent);
            this.Controls.Add(this.tlpCardTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCheck";
            this.Text = "JLPT Trainer - Check Your Cards";
            this.tlpCardTypes.ResumeLayout(false);
            this.tlpMainContent.ResumeLayout(false);
            this.tlpMainContent.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCardTypes;
        private System.Windows.Forms.Button btnUserCards;
        private System.Windows.Forms.Button btnAllCards;
        private System.Windows.Forms.TableLayoutPanel tlpMainContent;
        private System.Windows.Forms.ListBox lbCards;
        private System.Windows.Forms.Label lblVocab;
        private System.Windows.Forms.Label lblMeanings;
        private System.Windows.Forms.Label lblReading;
        private System.Windows.Forms.TextBox tbVocabItem;
        private System.Windows.Forms.TextBox tbReading;
        private System.Windows.Forms.TextBox tbMeanings;
        private System.Windows.Forms.Label lblWhich;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox cbN4;
        private System.Windows.Forms.CheckBox cbN5;
        private System.Windows.Forms.Label lblAnyCards;
    }
}