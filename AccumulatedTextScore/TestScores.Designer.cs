namespace AccumulatedTextScore
{
    partial class TestScores
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
            this.txtScoreInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblscoreTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSortedScore = new System.Windows.Forms.Button();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.btnUnscoredGrades = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score: ";
            // 
            // txtScoreInput
            // 
            this.txtScoreInput.Location = new System.Drawing.Point(138, 32);
            this.txtScoreInput.Name = "txtScoreInput";
            this.txtScoreInput.Size = new System.Drawing.Size(70, 20);
            this.txtScoreInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Score Total:";
            // 
            // lblscoreTotal
            // 
            this.lblscoreTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblscoreTotal.Location = new System.Drawing.Point(139, 63);
            this.lblscoreTotal.Name = "lblscoreTotal";
            this.lblscoreTotal.Size = new System.Drawing.Size(69, 20);
            this.lblscoreTotal.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Score Count:";
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreCount.Location = new System.Drawing.Point(138, 97);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(70, 20);
            this.lblScoreCount.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "     Average:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Location = new System.Drawing.Point(138, 140);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(69, 20);
            this.lblAverage.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(240, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 26);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSortedScore
            // 
            this.btnSortedScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortedScore.Location = new System.Drawing.Point(26, 178);
            this.btnSortedScore.Name = "btnSortedScore";
            this.btnSortedScore.Size = new System.Drawing.Size(123, 28);
            this.btnSortedScore.TabIndex = 4;
            this.btnSortedScore.Text = "Sorted Grade";
            this.btnSortedScore.UseVisualStyleBackColor = true;
            this.btnSortedScore.Click += new System.EventHandler(this.sorrtedScores_Click);
            // 
            // btnClearScores
            // 
            this.btnClearScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearScores.Location = new System.Drawing.Point(26, 214);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(123, 28);
            this.btnClearScores.TabIndex = 5;
            this.btnClearScores.Text = "Clear Scores";
            this.btnClearScores.UseVisualStyleBackColor = true;
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(237, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaxValue.Location = new System.Drawing.Point(241, 83);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(82, 20);
            this.lblMaxValue.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Min Value";
            // 
            // lblMinValue
            // 
            this.lblMinValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMinValue.Location = new System.Drawing.Point(243, 139);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(80, 21);
            this.lblMinValue.TabIndex = 10;
            // 
            // btnUnscoredGrades
            // 
            this.btnUnscoredGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnscoredGrades.Location = new System.Drawing.Point(183, 178);
            this.btnUnscoredGrades.Name = "btnUnscoredGrades";
            this.btnUnscoredGrades.Size = new System.Drawing.Size(140, 29);
            this.btnUnscoredGrades.TabIndex = 11;
            this.btnUnscoredGrades.Text = "Unsorted Grades";
            this.btnUnscoredGrades.UseVisualStyleBackColor = true;
            this.btnUnscoredGrades.Click += new System.EventHandler(this.btnUnscoredGrades_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "Project 8-1 Momo Johnson";
            // 
            // TestScores
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(335, 254);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUnscoredGrades);
            this.Controls.Add(this.lblMinValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMaxValue);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.btnSortedScore);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblscoreTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtScoreInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TestScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScoreInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblscoreTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSortedScore;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMinValue;
        private System.Windows.Forms.Button btnUnscoredGrades;
        private System.Windows.Forms.Label label7;
    }
}

