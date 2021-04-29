
namespace JLPT_Trainer
{
    partial class frmReview
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblReviews = new System.Windows.Forms.Label();
            this.btnMicEnable = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbReviews = new System.Windows.Forms.TextBox();
            this.tlpReviews = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.tbRemaining = new System.Windows.Forms.TextBox();
            this.lblLastItems = new System.Windows.Forms.Label();
            this.lbLastItems = new System.Windows.Forms.ListBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpReviews.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lblReviews, 0, 0);
            this.tlpMain.Controls.Add(this.btnMicEnable, 0, 2);
            this.tlpMain.Controls.Add(this.btnStart, 0, 3);
            this.tlpMain.Controls.Add(this.tbReviews, 0, 1);
            this.tlpMain.Location = new System.Drawing.Point(12, 12);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.Size = new System.Drawing.Size(244, 230);
            this.tlpMain.TabIndex = 0;
            // 
            // lblReviews
            // 
            this.lblReviews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReviews.AutoSize = true;
            this.lblReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviews.Location = new System.Drawing.Point(3, 5);
            this.lblReviews.Name = "lblReviews";
            this.lblReviews.Size = new System.Drawing.Size(76, 18);
            this.lblReviews.TabIndex = 0;
            this.lblReviews.Text = "Reviews:";
            // 
            // btnMicEnable
            // 
            this.btnMicEnable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMicEnable.Enabled = false;
            this.btnMicEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMicEnable.Location = new System.Drawing.Point(3, 79);
            this.btnMicEnable.Name = "btnMicEnable";
            this.btnMicEnable.Size = new System.Drawing.Size(238, 70);
            this.btnMicEnable.TabIndex = 1;
            this.btnMicEnable.Text = "Enable Microphone";
            this.btnMicEnable.UseVisualStyleBackColor = true;
            this.btnMicEnable.Click += new System.EventHandler(this.btnMicEnable_Click);
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(3, 155);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(238, 72);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Your Reviews";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbReviews
            // 
            this.tbReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReviews.Location = new System.Drawing.Point(3, 26);
            this.tbReviews.Multiline = true;
            this.tbReviews.Name = "tbReviews";
            this.tbReviews.ReadOnly = true;
            this.tbReviews.Size = new System.Drawing.Size(238, 35);
            this.tbReviews.TabIndex = 3;
            // 
            // tlpReviews
            // 
            this.tlpReviews.ColumnCount = 1;
            this.tlpReviews.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReviews.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpReviews.Controls.Add(this.lblLastItems, 0, 1);
            this.tlpReviews.Controls.Add(this.lbLastItems, 0, 2);
            this.tlpReviews.Controls.Add(this.btnEnd, 0, 3);
            this.tlpReviews.Location = new System.Drawing.Point(12, 12);
            this.tlpReviews.Name = "tlpReviews";
            this.tlpReviews.RowCount = 4;
            this.tlpReviews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpReviews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpReviews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpReviews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpReviews.Size = new System.Drawing.Size(244, 230);
            this.tlpReviews.TabIndex = 1;
            this.tlpReviews.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblRemaining, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbRemaining, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblRemaining
            // 
            this.lblRemaining.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.Location = new System.Drawing.Point(20, 2);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(96, 36);
            this.lblRemaining.TabIndex = 0;
            this.lblRemaining.Text = "Vocabulary Left:";
            this.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbRemaining
            // 
            this.tbRemaining.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemaining.Location = new System.Drawing.Point(122, 5);
            this.tbRemaining.Name = "tbRemaining";
            this.tbRemaining.ReadOnly = true;
            this.tbRemaining.Size = new System.Drawing.Size(113, 29);
            this.tbRemaining.TabIndex = 1;
            // 
            // lblLastItems
            // 
            this.lblLastItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLastItems.AutoSize = true;
            this.lblLastItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastItems.Location = new System.Drawing.Point(3, 62);
            this.lblLastItems.Name = "lblLastItems";
            this.lblLastItems.Size = new System.Drawing.Size(91, 18);
            this.lblLastItems.TabIndex = 1;
            this.lblLastItems.Text = "Last Items:";
            // 
            // lbLastItems
            // 
            this.lbLastItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLastItems.FormattingEnabled = true;
            this.lbLastItems.Location = new System.Drawing.Point(3, 83);
            this.lbLastItems.Name = "lbLastItems";
            this.lbLastItems.ScrollAlwaysVisible = true;
            this.lbLastItems.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbLastItems.Size = new System.Drawing.Size(238, 74);
            this.lbLastItems.TabIndex = 2;
            // 
            // btnEnd
            // 
            this.btnEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(3, 163);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(238, 64);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "End Reviews";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // frmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 255);
            this.Controls.Add(this.tlpReviews);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReview";
            this.Text = "JLPT Trainer - Reviews";
            this.Load += new System.EventHandler(this.frmReview_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpReviews.ResumeLayout(false);
            this.tlpReviews.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblReviews;
        private System.Windows.Forms.Button btnMicEnable;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbReviews;
        private System.Windows.Forms.TableLayoutPanel tlpReviews;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.TextBox tbRemaining;
        private System.Windows.Forms.Label lblLastItems;
        private System.Windows.Forms.ListBox lbLastItems;
        private System.Windows.Forms.Button btnEnd;
    }
}