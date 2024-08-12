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
            components = new System.ComponentModel.Container();
            btnPlayTraceOne = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            labelStatic = new Label();
            labelLine = new Label();
            btnPlayTraceTwo = new Button();
            txtTimeMultiplier = new TextBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            btnDemonstrate = new Button();
            btnPlayTraceThree = new Button();
            SuspendLayout();
            // 
            // btnPlayTraceOne
            // 
            btnPlayTraceOne.Location = new Point(12, 53);
            btnPlayTraceOne.Name = "btnPlayTraceOne";
            btnPlayTraceOne.Size = new Size(210, 43);
            btnPlayTraceOne.TabIndex = 2;
            btnPlayTraceOne.Text = "Play trace1";
            btnPlayTraceOne.UseVisualStyleBackColor = true;
            btnPlayTraceOne.Click += Trace1_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // labelStatic
            // 
            labelStatic.AutoSize = true;
            labelStatic.Location = new Point(12, 187);
            labelStatic.Name = "labelStatic";
            labelStatic.Size = new Size(72, 15);
            labelStatic.TabIndex = 5;
            labelStatic.Text = "Current line:";
            // 
            // labelLine
            // 
            labelLine.AutoSize = true;
            labelLine.Location = new Point(89, 187);
            labelLine.Name = "labelLine";
            labelLine.Size = new Size(13, 15);
            labelLine.TabIndex = 6;
            labelLine.Text = "0";
            // 
            // btnPlayTraceTwo
            // 
            btnPlayTraceTwo.Location = new Point(12, 102);
            btnPlayTraceTwo.Name = "btnPlayTraceTwo";
            btnPlayTraceTwo.Size = new Size(210, 38);
            btnPlayTraceTwo.TabIndex = 3;
            btnPlayTraceTwo.Text = "Play trace2";
            btnPlayTraceTwo.UseVisualStyleBackColor = true;
            btnPlayTraceTwo.Click += btnPlayTrace2_Click;
            // 
            // txtTimeMultiplier
            // 
            txtTimeMultiplier.Location = new Point(12, 24);
            txtTimeMultiplier.Name = "txtTimeMultiplier";
            txtTimeMultiplier.Size = new Size(210, 23);
            txtTimeMultiplier.TabIndex = 1;
            txtTimeMultiplier.Text = "1000";
            txtTimeMultiplier.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Time multiplier:";
            // 
            // btnDemonstrate
            // 
            btnDemonstrate.Location = new Point(12, 205);
            btnDemonstrate.Name = "btnDemonstrate";
            btnDemonstrate.Size = new Size(210, 38);
            btnDemonstrate.TabIndex = 7;
            btnDemonstrate.Text = "Demonstrate";
            btnDemonstrate.UseVisualStyleBackColor = true;
            btnDemonstrate.Click += btnDemonstrate_Click;
            // 
            // btnPlayTraceThree
            // 
            btnPlayTraceThree.Location = new Point(12, 146);
            btnPlayTraceThree.Name = "btnPlayTraceThree";
            btnPlayTraceThree.Size = new Size(210, 38);
            btnPlayTraceThree.TabIndex = 4;
            btnPlayTraceThree.Text = "Play trace3";
            btnPlayTraceThree.UseVisualStyleBackColor = true;
            btnPlayTraceThree.Click += btnPlayTrace3_Click;
            // 
            // SheetPlayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(234, 255);
            Controls.Add(btnPlayTraceThree);
            Controls.Add(btnDemonstrate);
            Controls.Add(label1);
            Controls.Add(txtTimeMultiplier);
            Controls.Add(btnPlayTraceTwo);
            Controls.Add(labelLine);
            Controls.Add(labelStatic);
            Controls.Add(btnPlayTraceOne);
            Name = "SheetPlayForm";
            Text = "SheetPlay";
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnPlayTraceThree;
    }
}