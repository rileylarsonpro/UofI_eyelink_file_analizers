﻿namespace EyelinkFileAnalizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DragAndDropTB = new System.Windows.Forms.TextBox();
            this.Instructions = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.lnstructionBox = new System.Windows.Forms.Label();
            this.VelocityLable = new System.Windows.Forms.Label();
            this.TimeLable = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ChooseFileBT = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.resultsTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eyeToScreenTB = new System.Windows.Forms.TextBox();
            this.CreateReportBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DragAndDropTB
            // 
            this.DragAndDropTB.AllowDrop = true;
            this.DragAndDropTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DragAndDropTB.Location = new System.Drawing.Point(12, 151);
            this.DragAndDropTB.Multiline = true;
            this.DragAndDropTB.Name = "DragAndDropTB";
            this.DragAndDropTB.Size = new System.Drawing.Size(836, 118);
            this.DragAndDropTB.TabIndex = 0;
            this.DragAndDropTB.TextChanged += new System.EventHandler(this.DragAndDropTB_TextChanged);
            this.DragAndDropTB.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragAndDropTB_DragDrop);
            this.DragAndDropTB.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragAndDropTB_DragEnter);
            // 
            // Instructions
            // 
            this.Instructions.AutoSize = true;
            this.Instructions.Location = new System.Drawing.Point(12, 105);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(0, 25);
            this.Instructions.TabIndex = 1;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(374, 275);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(234, 39);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Calculate Misalignment";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // lnstructionBox
            // 
            this.lnstructionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnstructionBox.Location = new System.Drawing.Point(12, 9);
            this.lnstructionBox.Name = "lnstructionBox";
            this.lnstructionBox.Size = new System.Drawing.Size(827, 139);
            this.lnstructionBox.TabIndex = 3;
            this.lnstructionBox.Text = resources.GetString("lnstructionBox.Text");
            // 
            // VelocityLable
            // 
            this.VelocityLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VelocityLable.AutoSize = true;
            this.VelocityLable.Location = new System.Drawing.Point(-3, 603);
            this.VelocityLable.Name = "VelocityLable";
            this.VelocityLable.Size = new System.Drawing.Size(0, 25);
            this.VelocityLable.TabIndex = 6;
            // 
            // TimeLable
            // 
            this.TimeLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLable.AutoSize = true;
            this.TimeLable.Location = new System.Drawing.Point(402, 546);
            this.TimeLable.Name = "TimeLable";
            this.TimeLable.Size = new System.Drawing.Size(0, 25);
            this.TimeLable.TabIndex = 7;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(193, 276);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(175, 38);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ChooseFileBT
            // 
            this.ChooseFileBT.Location = new System.Drawing.Point(12, 275);
            this.ChooseFileBT.Name = "ChooseFileBT";
            this.ChooseFileBT.Size = new System.Drawing.Size(175, 39);
            this.ChooseFileBT.TabIndex = 20;
            this.ChooseFileBT.Text = "Choose File";
            this.ChooseFileBT.UseVisualStyleBackColor = true;
            this.ChooseFileBT.Click += new System.EventHandler(this.ChooseFileBT_Click);
            // 
            // resultsTB
            // 
            this.resultsTB.Location = new System.Drawing.Point(12, 361);
            this.resultsTB.Multiline = true;
            this.resultsTB.Name = "resultsTB";
            this.resultsTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsTB.Size = new System.Drawing.Size(836, 225);
            this.resultsTB.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Enter eye to screen distance in millimeters (default is 790mm): ";
            // 
            // eyeToScreenTB
            // 
            this.eyeToScreenTB.Location = new System.Drawing.Point(560, 320);
            this.eyeToScreenTB.Name = "eyeToScreenTB";
            this.eyeToScreenTB.Size = new System.Drawing.Size(110, 29);
            this.eyeToScreenTB.TabIndex = 23;
            this.eyeToScreenTB.Text = "790";
            // 
            // CreateReportBT
            // 
            this.CreateReportBT.Location = new System.Drawing.Point(615, 276);
            this.CreateReportBT.Name = "CreateReportBT";
            this.CreateReportBT.Size = new System.Drawing.Size(233, 38);
            this.CreateReportBT.TabIndex = 24;
            this.CreateReportBT.Text = "Create Report";
            this.CreateReportBT.UseVisualStyleBackColor = true;
            this.CreateReportBT.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 626);
            this.Controls.Add(this.CreateReportBT);
            this.Controls.Add(this.eyeToScreenTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultsTB);
            this.Controls.Add(this.ChooseFileBT);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TimeLable);
            this.Controls.Add(this.VelocityLable);
            this.Controls.Add(this.lnstructionBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.DragAndDropTB);
            this.MaximumSize = new System.Drawing.Size(894, 690);
            this.MinimumSize = new System.Drawing.Size(894, 690);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EyeLink Text File Analyzer: Misalignment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DragAndDropTB;
        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label lnstructionBox;
        private System.Windows.Forms.Label VelocityLable;
        private System.Windows.Forms.Label TimeLable;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ChooseFileBT;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox resultsTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eyeToScreenTB;
        private System.Windows.Forms.Button CreateReportBT;
    }
}

