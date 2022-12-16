namespace SheetPlayForm
{
    partial class SheetPlayForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPlayTraceOne = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelStatic = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.btnPlayTraceTwo = new System.Windows.Forms.Button();
            this.txtTimeMultiplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDemonstrate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayTraceOne
            // 
            this.btnPlayTraceOne.Location = new System.Drawing.Point(12, 53);
            this.btnPlayTraceOne.Name = "btnPlayTraceOne";
            this.btnPlayTraceOne.Size = new System.Drawing.Size(210, 43);
            this.btnPlayTraceOne.TabIndex = 0;
            this.btnPlayTraceOne.Text = "Play trace1";
            this.btnPlayTraceOne.UseVisualStyleBackColor = true;
            this.btnPlayTraceOne.Click += new System.EventHandler(this.Trace1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // labelStatic
            // 
            this.labelStatic.AutoSize = true;
            this.labelStatic.Location = new System.Drawing.Point(12, 143);
            this.labelStatic.Name = "labelStatic";
            this.labelStatic.Size = new System.Drawing.Size(72, 15);
            this.labelStatic.TabIndex = 2;
            this.labelStatic.Text = "Current line:";
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Location = new System.Drawing.Point(86, 143);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(13, 15);
            this.labelLine.TabIndex = 3;
            this.labelLine.Text = "0";
            // 
            // btnPlayTraceTwo
            // 
            this.btnPlayTraceTwo.Location = new System.Drawing.Point(12, 102);
            this.btnPlayTraceTwo.Name = "btnPlayTraceTwo";
            this.btnPlayTraceTwo.Size = new System.Drawing.Size(210, 38);
            this.btnPlayTraceTwo.TabIndex = 4;
            this.btnPlayTraceTwo.Text = "Play trace2";
            this.btnPlayTraceTwo.UseVisualStyleBackColor = true;
            this.btnPlayTraceTwo.Click += new System.EventHandler(this.btnPlayTrace2_Click);
            // 
            // txtTimeMultiplier
            // 
            this.txtTimeMultiplier.Location = new System.Drawing.Point(12, 24);
            this.txtTimeMultiplier.Name = "txtTimeMultiplier";
            this.txtTimeMultiplier.Size = new System.Drawing.Size(210, 23);
            this.txtTimeMultiplier.TabIndex = 5;
            this.txtTimeMultiplier.Text = "1000";
            this.txtTimeMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time multiplier:";
            // 
            // btnDemonstrate
            // 
            this.btnDemonstrate.Location = new System.Drawing.Point(12, 166);
            this.btnDemonstrate.Name = "btnDemonstrate";
            this.btnDemonstrate.Size = new System.Drawing.Size(210, 38);
            this.btnDemonstrate.TabIndex = 7;
            this.btnDemonstrate.Text = "Demonstrate";
            this.btnDemonstrate.UseVisualStyleBackColor = true;
            this.btnDemonstrate.Click += new System.EventHandler(this.btnDemonstrate_Click);
            // 
            // SheetPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(234, 213);
            this.Controls.Add(this.btnDemonstrate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimeMultiplier);
            this.Controls.Add(this.btnPlayTraceTwo);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.labelStatic);
            this.Controls.Add(this.btnPlayTraceOne);
            this.Name = "SheetPlayForm";
            this.Text = "SheetPlay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPlayTraceOne;
        private System.ComponentModel.BackgroundWorker bkSheetPlay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label labelStatic;
        private Label labelLine;
        private Button btnPlayTraceTwo;
        private TextBox txtTimeMultiplier;
        private Label label1;
        private ToolTip toolTip1;
        private Button btnDemonstrate;
    }
}