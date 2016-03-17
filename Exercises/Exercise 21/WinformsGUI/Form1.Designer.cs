namespace WinformsGUI
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
            this._Name = new System.Windows.Forms.Label();
            this._txtBoxName = new System.Windows.Forms.TextBox();
            this._txtBoxYear = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.Label();
            this._txtBoxDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._btnBack = new System.Windows.Forms.Button();
            this._btnNext = new System.Windows.Forms.Button();
            this._txtBoxMin = new System.Windows.Forms.TextBox();
            this._txtBoxMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._btnSearch = new System.Windows.Forms.Button();
            this._btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this._Name.AutoSize = true;
            this._Name.Location = new System.Drawing.Point(12, 9);
            this._Name.Name = "Name";
            this._Name.Size = new System.Drawing.Size(35, 13);
            this._Name.TabIndex = 0;
            this._Name.Text = "Name";
            // 
            // _txtBoxName
            // 
            this._txtBoxName.Location = new System.Drawing.Point(13, 30);
            this._txtBoxName.Name = "_txtBoxName";
            this._txtBoxName.ReadOnly = true;
            this._txtBoxName.Size = new System.Drawing.Size(100, 20);
            this._txtBoxName.TabIndex = 1;
            // 
            // _txtBoxYear
            // 
            this._txtBoxYear.Location = new System.Drawing.Point(128, 30);
            this._txtBoxYear.Name = "_txtBoxYear";
            this._txtBoxYear.ReadOnly = true;
            this._txtBoxYear.Size = new System.Drawing.Size(100, 20);
            this._txtBoxYear.TabIndex = 2;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(125, 9);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 13);
            this.Year.TabIndex = 3;
            this.Year.Text = "Year";
            // 
            // _txtBoxDesc
            // 
            this._txtBoxDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._txtBoxDesc.Location = new System.Drawing.Point(13, 81);
            this._txtBoxDesc.Multiline = true;
            this._txtBoxDesc.Name = "_txtBoxDesc";
            this._txtBoxDesc.ReadOnly = true;
            this._txtBoxDesc.Size = new System.Drawing.Size(341, 142);
            this._txtBoxDesc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Description";
            // 
            // _btnBack
            // 
            this._btnBack.Location = new System.Drawing.Point(15, 229);
            this._btnBack.Name = "_btnBack";
            this._btnBack.Size = new System.Drawing.Size(75, 23);
            this._btnBack.TabIndex = 6;
            this._btnBack.Text = "Back";
            this._btnBack.UseVisualStyleBackColor = true;
            this._btnBack.Click += new System.EventHandler(this._btnBack_Click);
            // 
            // _btnNext
            // 
            this._btnNext.Location = new System.Drawing.Point(279, 229);
            this._btnNext.Name = "_btnNext";
            this._btnNext.Size = new System.Drawing.Size(75, 23);
            this._btnNext.TabIndex = 7;
            this._btnNext.Text = "Next";
            this._btnNext.UseVisualStyleBackColor = true;
            this._btnNext.Click += new System.EventHandler(this._btnNext_Click);
            // 
            // _txtBoxMin
            // 
            this._txtBoxMin.Location = new System.Drawing.Point(67, 263);
            this._txtBoxMin.Name = "_txtBoxMin";
            this._txtBoxMin.Size = new System.Drawing.Size(87, 20);
            this._txtBoxMin.TabIndex = 8;
            // 
            // _txtBoxMax
            // 
            this._txtBoxMax.Location = new System.Drawing.Point(186, 263);
            this._txtBoxMax.Name = "_txtBoxMax";
            this._txtBoxMax.Size = new System.Drawing.Size(87, 20);
            this._txtBoxMax.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "From year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "To";
            // 
            // _btnSearch
            // 
            this._btnSearch.Location = new System.Drawing.Point(280, 262);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(75, 23);
            this._btnSearch.TabIndex = 12;
            this._btnSearch.Text = "Search";
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
            // 
            // _btnReset
            // 
            this._btnReset.Location = new System.Drawing.Point(279, 28);
            this._btnReset.Name = "_btnReset";
            this._btnReset.Size = new System.Drawing.Size(75, 23);
            this._btnReset.TabIndex = 13;
            this._btnReset.Text = "Reset";
            this._btnReset.UseVisualStyleBackColor = true;
            this._btnReset.Click += new System.EventHandler(this._btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 316);
            this.Controls.Add(this._btnReset);
            this.Controls.Add(this._btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtBoxMax);
            this.Controls.Add(this._txtBoxMin);
            this.Controls.Add(this._btnNext);
            this.Controls.Add(this._btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtBoxDesc);
            this.Controls.Add(this.Year);
            this.Controls.Add(this._txtBoxYear);
            this.Controls.Add(this._txtBoxName);
            this.Controls.Add(this._Name);
            this.Name = "";
            this.Text = "Programming Languages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _Name;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtBoxDesc;
        private System.Windows.Forms.TextBox _txtBoxYear;
        private System.Windows.Forms.TextBox _txtBoxName;
        private System.Windows.Forms.Button _btnBack;
        private System.Windows.Forms.Button _btnNext;
        private System.Windows.Forms.TextBox _txtBoxMin;
        private System.Windows.Forms.TextBox _txtBoxMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _btnSearch;
        private System.Windows.Forms.Button _btnReset;
    }
}

