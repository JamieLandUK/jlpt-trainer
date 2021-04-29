
namespace JLPT_Trainer
{
    partial class frmLearn
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
            this.tlpKanjiReading = new System.Windows.Forms.TableLayoutPanel();
            this.tbPronunciation = new System.Windows.Forms.TextBox();
            this.lblKanji = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKanji = new System.Windows.Forms.TextBox();
            this.tlpMeanings = new System.Windows.Forms.TableLayoutPanel();
            this.tbMeanings = new System.Windows.Forms.TextBox();
            this.lblMeanings = new System.Windows.Forms.Label();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAloud = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tlpKanjiReading.SuspendLayout();
            this.tlpMeanings.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpKanjiReading
            // 
            this.tlpKanjiReading.ColumnCount = 2;
            this.tlpKanjiReading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKanjiReading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKanjiReading.Controls.Add(this.tbPronunciation, 0, 1);
            this.tlpKanjiReading.Controls.Add(this.lblKanji, 0, 0);
            this.tlpKanjiReading.Controls.Add(this.label1, 1, 0);
            this.tlpKanjiReading.Controls.Add(this.tbKanji, 0, 1);
            this.tlpKanjiReading.Location = new System.Drawing.Point(13, 13);
            this.tlpKanjiReading.Name = "tlpKanjiReading";
            this.tlpKanjiReading.RowCount = 2;
            this.tlpKanjiReading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.16901F));
            this.tlpKanjiReading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.83099F));
            this.tlpKanjiReading.Size = new System.Drawing.Size(382, 71);
            this.tlpKanjiReading.TabIndex = 0;
            // 
            // tbPronunciation
            // 
            this.tbPronunciation.Font = new System.Drawing.Font("Meiryo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPronunciation.Location = new System.Drawing.Point(194, 22);
            this.tbPronunciation.Multiline = true;
            this.tbPronunciation.Name = "tbPronunciation";
            this.tbPronunciation.ReadOnly = true;
            this.tbPronunciation.Size = new System.Drawing.Size(185, 40);
            this.tbPronunciation.TabIndex = 6;
            this.tbPronunciation.Text = "てんき";
            // 
            // lblKanji
            // 
            this.lblKanji.AutoSize = true;
            this.lblKanji.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKanji.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKanji.Location = new System.Drawing.Point(3, 1);
            this.lblKanji.Name = "lblKanji";
            this.lblKanji.Size = new System.Drawing.Size(185, 18);
            this.lblKanji.TabIndex = 3;
            this.lblKanji.Text = "Kanji:";
            this.lblKanji.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pronunciation:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbKanji
            // 
            this.tbKanji.Font = new System.Drawing.Font("Meiryo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKanji.Location = new System.Drawing.Point(3, 22);
            this.tbKanji.Multiline = true;
            this.tbKanji.Name = "tbKanji";
            this.tbKanji.ReadOnly = true;
            this.tbKanji.Size = new System.Drawing.Size(185, 40);
            this.tbKanji.TabIndex = 5;
            this.tbKanji.Text = "天気";
            // 
            // tlpMeanings
            // 
            this.tlpMeanings.ColumnCount = 1;
            this.tlpMeanings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMeanings.Controls.Add(this.tbMeanings, 0, 1);
            this.tlpMeanings.Controls.Add(this.lblMeanings, 0, 0);
            this.tlpMeanings.Location = new System.Drawing.Point(13, 90);
            this.tlpMeanings.Name = "tlpMeanings";
            this.tlpMeanings.RowCount = 2;
            this.tlpMeanings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tlpMeanings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.35294F));
            this.tlpMeanings.Size = new System.Drawing.Size(382, 119);
            this.tlpMeanings.TabIndex = 1;
            // 
            // tbMeanings
            // 
            this.tbMeanings.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMeanings.Location = new System.Drawing.Point(3, 23);
            this.tbMeanings.Multiline = true;
            this.tbMeanings.Name = "tbMeanings";
            this.tbMeanings.ReadOnly = true;
            this.tbMeanings.Size = new System.Drawing.Size(376, 93);
            this.tbMeanings.TabIndex = 7;
            this.tbMeanings.Text = "the weather, weather, fine weather, fair weather";
            // 
            // lblMeanings
            // 
            this.lblMeanings.AutoSize = true;
            this.lblMeanings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMeanings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeanings.Location = new System.Drawing.Point(3, 2);
            this.lblMeanings.Name = "lblMeanings";
            this.lblMeanings.Size = new System.Drawing.Size(376, 18);
            this.lblMeanings.TabIndex = 4;
            this.lblMeanings.Text = "Meanings:";
            this.lblMeanings.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 1;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Controls.Add(this.btnAloud, 0, 0);
            this.tlpButtons.Controls.Add(this.btnNext, 0, 1);
            this.tlpButtons.Controls.Add(this.btnStop, 0, 2);
            this.tlpButtons.Location = new System.Drawing.Point(402, 13);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 3;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtons.Size = new System.Drawing.Size(68, 196);
            this.tlpButtons.TabIndex = 2;
            // 
            // btnAloud
            // 
            this.btnAloud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAloud.Location = new System.Drawing.Point(3, 3);
            this.btnAloud.Name = "btnAloud";
            this.btnAloud.Size = new System.Drawing.Size(62, 59);
            this.btnAloud.TabIndex = 0;
            this.btnAloud.Text = "Read Aloud";
            this.btnAloud.UseVisualStyleBackColor = true;
            this.btnAloud.Click += new System.EventHandler(this.btnAloud_Click);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(3, 68);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(62, 59);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(3, 133);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(62, 60);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // frmLearn
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnStop;
            this.ClientSize = new System.Drawing.Size(482, 218);
            this.Controls.Add(this.tlpButtons);
            this.Controls.Add(this.tlpMeanings);
            this.Controls.Add(this.tlpKanjiReading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLearn";
            this.Text = "JLPT Trainer - Learn New Cards";
            this.tlpKanjiReading.ResumeLayout(false);
            this.tlpKanjiReading.PerformLayout();
            this.tlpMeanings.ResumeLayout(false);
            this.tlpMeanings.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpKanjiReading;
        private System.Windows.Forms.Label lblKanji;
        private System.Windows.Forms.TableLayoutPanel tlpMeanings;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKanji;
        private System.Windows.Forms.TextBox tbPronunciation;
        private System.Windows.Forms.TextBox tbMeanings;
        private System.Windows.Forms.Label lblMeanings;
        private System.Windows.Forms.Button btnAloud;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnStop;
    }
}