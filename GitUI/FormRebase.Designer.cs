﻿namespace GitUI
{
    partial class FormRebase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRebase));
            this.label1 = new System.Windows.Forms.Label();
            this.Currentbranch = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.Branches = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddFiles = new System.Windows.Forms.Button();
            this.Resolved = new System.Windows.Forms.Button();
            this.Abort = new System.Windows.Forms.Button();
            this.Skip = new System.Windows.Forms.Button();
            this.Mergetool = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.patchGrid1 = new GitUI.PatchGrid();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rebase current branch on top of another branch";
            // 
            // Currentbranch
            // 
            this.Currentbranch.AutoSize = true;
            this.Currentbranch.Location = new System.Drawing.Point(4, 26);
            this.Currentbranch.Name = "Currentbranch";
            this.Currentbranch.Size = new System.Drawing.Size(41, 13);
            this.Currentbranch.TabIndex = 2;
            this.Currentbranch.Text = "Current";
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(3, 47);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(102, 23);
            this.Ok.TabIndex = 7;
            this.Ok.Text = "Rebase";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Branches
            // 
            this.Branches.FormattingEnabled = true;
            this.Branches.Location = new System.Drawing.Point(88, 47);
            this.Branches.Name = "Branches";
            this.Branches.Size = new System.Drawing.Size(327, 21);
            this.Branches.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rebase on";
            // 
            // AddFiles
            // 
            this.AddFiles.Location = new System.Drawing.Point(2, 130);
            this.AddFiles.Name = "AddFiles";
            this.AddFiles.Size = new System.Drawing.Size(102, 23);
            this.AddFiles.TabIndex = 14;
            this.AddFiles.Text = "Add files";
            this.AddFiles.UseVisualStyleBackColor = true;
            this.AddFiles.Click += new System.EventHandler(this.AddFiles_Click);
            // 
            // Resolved
            // 
            this.Resolved.Location = new System.Drawing.Point(2, 179);
            this.Resolved.Name = "Resolved";
            this.Resolved.Size = new System.Drawing.Size(102, 23);
            this.Resolved.TabIndex = 13;
            this.Resolved.Text = "Continue rebase";
            this.Resolved.UseVisualStyleBackColor = true;
            this.Resolved.Click += new System.EventHandler(this.Resolved_Click);
            // 
            // Abort
            // 
            this.Abort.Location = new System.Drawing.Point(2, 237);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(102, 23);
            this.Abort.TabIndex = 12;
            this.Abort.Text = "Abort";
            this.Abort.UseVisualStyleBackColor = true;
            this.Abort.Click += new System.EventHandler(this.Abort_Click);
            // 
            // Skip
            // 
            this.Skip.Location = new System.Drawing.Point(2, 208);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(102, 23);
            this.Skip.TabIndex = 11;
            this.Skip.Text = "Skip this commit";
            this.Skip.UseVisualStyleBackColor = true;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // Mergetool
            // 
            this.Mergetool.Location = new System.Drawing.Point(2, 79);
            this.Mergetool.Name = "Mergetool";
            this.Mergetool.Size = new System.Drawing.Size(102, 23);
            this.Mergetool.TabIndex = 10;
            this.Mergetool.Text = "Solve conflicts";
            this.Mergetool.UseVisualStyleBackColor = true;
            this.Mergetool.Click += new System.EventHandler(this.Mergetool_Click);
            // 
            // Output
            // 
            this.Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Output.Location = new System.Drawing.Point(0, 0);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(542, 159);
            this.Output.TabIndex = 15;
            this.Output.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Ok);
            this.splitContainer1.Panel2.Controls.Add(this.Mergetool);
            this.splitContainer1.Panel2.Controls.Add(this.AddFiles);
            this.splitContainer1.Panel2.Controls.Add(this.Abort);
            this.splitContainer1.Panel2.Controls.Add(this.Resolved);
            this.splitContainer1.Panel2.Controls.Add(this.Skip);
            this.splitContainer1.Size = new System.Drawing.Size(653, 459);
            this.splitContainer1.SplitterDistance = 542;
            this.splitContainer1.TabIndex = 17;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.Currentbranch);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.Branches);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(542, 459);
            this.splitContainer2.SplitterDistance = 74;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.patchGrid1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.Output);
            this.splitContainer3.Size = new System.Drawing.Size(542, 381);
            this.splitContainer3.SplitterDistance = 218;
            this.splitContainer3.TabIndex = 0;
            // 
            // patchGrid1
            // 
            this.patchGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patchGrid1.Location = new System.Drawing.Point(0, 0);
            this.patchGrid1.Name = "patchGrid1";
            this.patchGrid1.Size = new System.Drawing.Size(542, 218);
            this.patchGrid1.TabIndex = 16;
            // 
            // FormRebase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 459);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRebase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rebase";
            this.Load += new System.EventHandler(this.FormRebase_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Currentbranch;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddFiles;
        private System.Windows.Forms.Button Resolved;
        private System.Windows.Forms.Button Abort;
        private System.Windows.Forms.Button Skip;
        private System.Windows.Forms.Button Mergetool;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.ComboBox Branches;
        private PatchGrid patchGrid1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}