namespace MatrixPattern
{
    partial class MatrixPatternForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrixPatternForm));
            helpProvider1 = new HelpProvider();
            toolStrip1 = new ToolStrip();
            startButton = new ToolStripButton();
            resumeButton = new ToolStripButton();
            stopButton = new ToolStripButton();
            gridDropDown = new ToolStripDropDownButton();
            x2ToolStripMenuItem = new ToolStripMenuItem();
            x3ToolStripMenuItem = new ToolStripMenuItem();
            x4ToolStripMenuItem = new ToolStripMenuItem();
            x5ToolStripMenuItem = new ToolStripMenuItem();
            x6ToolStripMenuItem = new ToolStripMenuItem();
            x7ToolStripMenuItem = new ToolStripMenuItem();
            x8ToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { startButton, resumeButton, stopButton, gridDropDown });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1049, 34);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // startButton
            // 
            startButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            startButton.Image = (Image)resources.GetObject("startButton.Image");
            startButton.ImageTransparentColor = Color.Magenta;
            startButton.Name = "startButton";
            startButton.Size = new Size(34, 29);
            startButton.Text = "start";
            startButton.Click += startButton_Click;
            // 
            // resumeButton
            // 
            resumeButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resumeButton.Image = (Image)resources.GetObject("resumeButton.Image");
            resumeButton.ImageTransparentColor = Color.Magenta;
            resumeButton.Name = "resumeButton";
            resumeButton.Size = new Size(34, 29);
            resumeButton.Text = "resume";
            resumeButton.Click += resumeButton_Click;
            // 
            // stopButton
            // 
            stopButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            stopButton.Image = (Image)resources.GetObject("stopButton.Image");
            stopButton.ImageTransparentColor = Color.Magenta;
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(34, 29);
            stopButton.Text = "stop";
            stopButton.Click += stopButton_Click;
            // 
            // gridDropDown
            // 
            gridDropDown.DropDownItems.AddRange(new ToolStripItem[] { x2ToolStripMenuItem, x3ToolStripMenuItem, x4ToolStripMenuItem, x5ToolStripMenuItem, x6ToolStripMenuItem, x7ToolStripMenuItem, x8ToolStripMenuItem });
            gridDropDown.Image = (Image)resources.GetObject("gridDropDown.Image");
            gridDropDown.ImageTransparentColor = Color.Magenta;
            gridDropDown.Name = "gridDropDown";
            gridDropDown.Size = new Size(87, 29);
            gridDropDown.Text = "Grid";
            gridDropDown.Click += gridDropDown_Click;
            // 
            // x2ToolStripMenuItem
            // 
            x2ToolStripMenuItem.Name = "x2ToolStripMenuItem";
            x2ToolStripMenuItem.Size = new Size(142, 34);
            x2ToolStripMenuItem.Text = "2x2";
            x2ToolStripMenuItem.Click += x2ToolStripMenuItem_Click;
            // 
            // x3ToolStripMenuItem
            // 
            x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            x3ToolStripMenuItem.Size = new Size(142, 34);
            x3ToolStripMenuItem.Text = "3x3";
            x3ToolStripMenuItem.Click += x3ToolStripMenuItem_Click;
            // 
            // x4ToolStripMenuItem
            // 
            x4ToolStripMenuItem.Name = "x4ToolStripMenuItem";
            x4ToolStripMenuItem.Size = new Size(142, 34);
            x4ToolStripMenuItem.Text = "4x4";
            x4ToolStripMenuItem.Click += x4ToolStripMenuItem_Click;
            // 
            // x5ToolStripMenuItem
            // 
            x5ToolStripMenuItem.Name = "x5ToolStripMenuItem";
            x5ToolStripMenuItem.Size = new Size(142, 34);
            x5ToolStripMenuItem.Text = "5x5";
            x5ToolStripMenuItem.Click += x5ToolStripMenuItem_Click;
            // 
            // x6ToolStripMenuItem
            // 
            x6ToolStripMenuItem.Name = "x6ToolStripMenuItem";
            x6ToolStripMenuItem.Size = new Size(142, 34);
            x6ToolStripMenuItem.Text = "6x6";
            x6ToolStripMenuItem.Click += x6ToolStripMenuItem_Click;
            // 
            // x7ToolStripMenuItem
            // 
            x7ToolStripMenuItem.Name = "x7ToolStripMenuItem";
            x7ToolStripMenuItem.Size = new Size(142, 34);
            x7ToolStripMenuItem.Text = "7x7";
            x7ToolStripMenuItem.Click += x7ToolStripMenuItem_Click;
            // 
            // x8ToolStripMenuItem
            // 
            x8ToolStripMenuItem.Name = "x8ToolStripMenuItem";
            x8ToolStripMenuItem.Size = new Size(142, 34);
            x8ToolStripMenuItem.Text = "8x8";
            x8ToolStripMenuItem.Click += x8ToolStripMenuItem_Click;
            // 
            // MatrixPatternForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 644);
            Controls.Add(toolStrip1);
            Name = "MatrixPatternForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Matrix Printer";
            Paint += onPaint;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private HelpProvider helpProvider1;
        private ToolStrip toolStrip1;
        private ToolStripButton startButton;
        private ToolStripButton resumeButton;
        private ToolStripButton stopButton;
        private ToolStripDropDownButton gridDropDown;
        private ToolStripMenuItem x2ToolStripMenuItem;
        private ToolStripMenuItem x3ToolStripMenuItem;
        private ToolStripMenuItem x4ToolStripMenuItem;
        private ToolStripMenuItem x5ToolStripMenuItem;
        private ToolStripMenuItem x6ToolStripMenuItem;
        private ToolStripMenuItem x7ToolStripMenuItem;
        private ToolStripMenuItem x8ToolStripMenuItem;
    }
}
