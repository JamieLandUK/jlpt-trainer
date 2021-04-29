
namespace JLPT_Trainer
{
    partial class windowMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windowMain));
            this.stripTop = new System.Windows.Forms.ToolStrip();
            this.tslTest = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.layoutMainHeader = new System.Windows.Forms.TableLayoutPanel();
            this.layoutMainButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnReviews = new System.Windows.Forms.Button();
            this.btnCards = new System.Windows.Forms.Button();
            this.btnSpeechEnable = new System.Windows.Forms.Button();
            this.lblReviews = new System.Windows.Forms.Label();
            this.lblCards = new System.Windows.Forms.Label();
            this.lblLearn = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblNameWelcome = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.stripTop.SuspendLayout();
            this.layoutMainHeader.SuspendLayout();
            this.layoutMainButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // stripTop
            // 
            this.stripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTest});
            this.stripTop.Location = new System.Drawing.Point(0, 0);
            this.stripTop.Name = "stripTop";
            this.stripTop.Size = new System.Drawing.Size(634, 25);
            this.stripTop.TabIndex = 1;
            this.stripTop.Text = "toolStrip1";
            // 
            // tslTest
            // 
            this.tslTest.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslTest.Image = ((System.Drawing.Image)(resources.GetObject("tslTest.Image")));
            this.tslTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslTest.Name = "tslTest";
            this.tslTest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tslTest.Size = new System.Drawing.Size(173, 22);
            this.tslTest.Tag = "";
            this.tslTest.Text = "Test Synthesis and Recognition";
            this.tslTest.ToolTipText = "Test the system\'s speech recognition and synthesis";
            this.tslTest.Click += new System.EventHandler(this.tslTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(421, 71);
            this.label1.TabIndex = 2;
            this.label1.Text = "JLPT Trainer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutMainHeader
            // 
            this.layoutMainHeader.ColumnCount = 3;
            this.layoutMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.layoutMainHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutMainHeader.Controls.Add(this.label1, 1, 0);
            this.layoutMainHeader.Location = new System.Drawing.Point(12, 28);
            this.layoutMainHeader.Name = "layoutMainHeader";
            this.layoutMainHeader.RowCount = 1;
            this.layoutMainHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMainHeader.Size = new System.Drawing.Size(610, 71);
            this.layoutMainHeader.TabIndex = 3;
            // 
            // layoutMainButtons
            // 
            this.layoutMainButtons.ColumnCount = 4;
            this.layoutMainButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layoutMainButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layoutMainButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutMainButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.layoutMainButtons.Controls.Add(this.btnLearn, 1, 0);
            this.layoutMainButtons.Controls.Add(this.btnReviews, 1, 1);
            this.layoutMainButtons.Controls.Add(this.btnCards, 1, 2);
            this.layoutMainButtons.Controls.Add(this.btnSpeechEnable, 1, 4);
            this.layoutMainButtons.Controls.Add(this.lblReviews, 2, 1);
            this.layoutMainButtons.Controls.Add(this.lblCards, 2, 2);
            this.layoutMainButtons.Controls.Add(this.lblLearn, 2, 0);
            this.layoutMainButtons.Controls.Add(this.btnSignIn, 0, 0);
            this.layoutMainButtons.Controls.Add(this.lblNameWelcome, 0, 1);
            this.layoutMainButtons.Controls.Add(this.btnRefresh, 0, 2);
            this.layoutMainButtons.Location = new System.Drawing.Point(12, 105);
            this.layoutMainButtons.Name = "layoutMainButtons";
            this.layoutMainButtons.RowCount = 5;
            this.layoutMainButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutMainButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutMainButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutMainButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutMainButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutMainButtons.Size = new System.Drawing.Size(610, 344);
            this.layoutMainButtons.TabIndex = 4;
            // 
            // btnLearn
            // 
            this.btnLearn.Enabled = false;
            this.btnLearn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearn.Location = new System.Drawing.Point(186, 3);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(238, 62);
            this.btnLearn.TabIndex = 0;
            this.btnLearn.Text = "Learn New Cards";
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnReviews
            // 
            this.btnReviews.Enabled = false;
            this.btnReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviews.Location = new System.Drawing.Point(186, 71);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(238, 62);
            this.btnReviews.TabIndex = 1;
            this.btnReviews.Text = "Begin Reviews";
            this.btnReviews.UseVisualStyleBackColor = true;
            this.btnReviews.Click += new System.EventHandler(this.btnReviews_Click);
            // 
            // btnCards
            // 
            this.btnCards.Enabled = false;
            this.btnCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCards.Location = new System.Drawing.Point(186, 139);
            this.btnCards.Name = "btnCards";
            this.btnCards.Size = new System.Drawing.Size(238, 62);
            this.btnCards.TabIndex = 2;
            this.btnCards.Text = "Check Your Cards";
            this.btnCards.UseVisualStyleBackColor = true;
            this.btnCards.Click += new System.EventHandler(this.btnCards_Click);
            // 
            // btnSpeechEnable
            // 
            this.btnSpeechEnable.Enabled = false;
            this.btnSpeechEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeechEnable.Location = new System.Drawing.Point(186, 293);
            this.btnSpeechEnable.Name = "btnSpeechEnable";
            this.btnSpeechEnable.Size = new System.Drawing.Size(238, 48);
            this.btnSpeechEnable.TabIndex = 3;
            this.btnSpeechEnable.Text = "Enable Microphone";
            this.btnSpeechEnable.UseVisualStyleBackColor = true;
            this.btnSpeechEnable.Click += new System.EventHandler(this.btnSpeechEnable_Click);
            // 
            // lblReviews
            // 
            this.lblReviews.AutoSize = true;
            this.lblReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviews.Location = new System.Drawing.Point(430, 68);
            this.lblReviews.Name = "lblReviews";
            this.lblReviews.Size = new System.Drawing.Size(117, 18);
            this.lblReviews.TabIndex = 5;
            this.lblReviews.Text = "Or say \"Review\"!";
            this.lblReviews.Visible = false;
            // 
            // lblCards
            // 
            this.lblCards.AutoSize = true;
            this.lblCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCards.Location = new System.Drawing.Point(430, 136);
            this.lblCards.Name = "lblCards";
            this.lblCards.Size = new System.Drawing.Size(109, 18);
            this.lblCards.TabIndex = 6;
            this.lblCards.Text = "Or say \"Cards\"!";
            this.lblCards.Visible = false;
            // 
            // lblLearn
            // 
            this.lblLearn.AutoSize = true;
            this.lblLearn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearn.Location = new System.Drawing.Point(430, 0);
            this.lblLearn.Name = "lblLearn";
            this.lblLearn.Size = new System.Drawing.Size(106, 18);
            this.lblLearn.TabIndex = 4;
            this.lblLearn.Text = "Or say \"Learn\"!";
            this.lblLearn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLearn.Visible = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(3, 33);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(3, 33, 3, 3);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(107, 32);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "Sign In!";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblNameWelcome
            // 
            this.lblNameWelcome.AutoSize = true;
            this.lblNameWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameWelcome.Location = new System.Drawing.Point(3, 68);
            this.lblNameWelcome.Name = "lblNameWelcome";
            this.lblNameWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.lblNameWelcome.Size = new System.Drawing.Size(119, 24);
            this.lblNameWelcome.TabIndex = 8;
            this.lblNameWelcome.Text = "Hello, {Name}";
            this.lblNameWelcome.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(3, 139);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 32);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh!";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // windowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.layoutMainButtons);
            this.Controls.Add(this.layoutMainHeader);
            this.Controls.Add(this.stripTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "windowMain";
            this.Text = "JLPT Trainer";
            this.stripTop.ResumeLayout(false);
            this.stripTop.PerformLayout();
            this.layoutMainHeader.ResumeLayout(false);
            this.layoutMainHeader.PerformLayout();
            this.layoutMainButtons.ResumeLayout(false);
            this.layoutMainButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip stripTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel layoutMainHeader;
        private System.Windows.Forms.TableLayoutPanel layoutMainButtons;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Button btnCards;
        private System.Windows.Forms.Button btnSpeechEnable;
        private System.Windows.Forms.Label lblReviews;
        private System.Windows.Forms.Label lblCards;
        private System.Windows.Forms.ToolStripButton tslTest;
        private System.Windows.Forms.Label lblLearn;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblNameWelcome;
        private System.Windows.Forms.Button btnRefresh;
    }
}

