namespace SLST
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
            this.open = new System.Windows.Forms.Button();
            this.files = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.remove = new System.Windows.Forms.Button();
            this.createFrag = new System.Windows.Forms.Button();
            this.runBlast = new System.Windows.Forms.Button();
            this.createTree = new System.Windows.Forms.Button();
            this.blast = new System.Windows.Forms.Button();
            this.mega = new System.Windows.Forms.Button();
            this.files.SuspendLayout();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(12, 12);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(150, 32);
            this.open.TabIndex = 0;
            this.open.Text = "Add File";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // files
            // 
            this.files.Controls.Add(this.listBox1);
            this.files.Location = new System.Drawing.Point(12, 88);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(462, 256);
            this.files.TabIndex = 1;
            this.files.TabStop = false;
            this.files.Text = "Loaded Files";
            this.files.Enter += new System.EventHandler(this.files_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(450, 228);
            this.listBox1.TabIndex = 0;
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(168, 12);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(150, 32);
            this.remove.TabIndex = 2;
            this.remove.Text = "Remove File";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // createFrag
            // 
            this.createFrag.CausesValidation = false;
            this.createFrag.Location = new System.Drawing.Point(12, 50);
            this.createFrag.Name = "createFrag";
            this.createFrag.Size = new System.Drawing.Size(150, 32);
            this.createFrag.TabIndex = 3;
            this.createFrag.Text = "Create Fragments";
            this.createFrag.UseVisualStyleBackColor = true;
            // 
            // runBlast
            // 
            this.runBlast.Location = new System.Drawing.Point(168, 50);
            this.runBlast.Name = "runBlast";
            this.runBlast.Size = new System.Drawing.Size(150, 32);
            this.runBlast.TabIndex = 4;
            this.runBlast.Text = "Run Blast";
            this.runBlast.UseVisualStyleBackColor = true;
            // 
            // createTree
            // 
            this.createTree.Location = new System.Drawing.Point(324, 50);
            this.createTree.Name = "createTree";
            this.createTree.Size = new System.Drawing.Size(150, 32);
            this.createTree.TabIndex = 5;
            this.createTree.Text = "Create Tree";
            this.createTree.UseVisualStyleBackColor = true;
            // 
            // blast
            // 
            this.blast.Enabled = false;
            this.blast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blast.Location = new System.Drawing.Point(324, 12);
            this.blast.Name = "blast";
            this.blast.Size = new System.Drawing.Size(72, 32);
            this.blast.TabIndex = 6;
            this.blast.Text = "Blast";
            this.blast.UseVisualStyleBackColor = true;
            // 
            // mega
            // 
            this.mega.Enabled = false;
            this.mega.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mega.Location = new System.Drawing.Point(402, 12);
            this.mega.Name = "mega";
            this.mega.Size = new System.Drawing.Size(72, 32);
            this.mega.TabIndex = 7;
            this.mega.Text = "Mega";
            this.mega.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(489, 354);
            this.Controls.Add(this.mega);
            this.Controls.Add(this.blast);
            this.Controls.Add(this.createTree);
            this.Controls.Add(this.runBlast);
            this.Controls.Add(this.createFrag);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.files);
            this.Controls.Add(this.open);
            this.Name = "Form1";
            this.Text = "SLST";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.files.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open;
        private System.Windows.Forms.GroupBox files;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button createFrag;
        private System.Windows.Forms.Button runBlast;
        private System.Windows.Forms.Button createTree;
        private System.Windows.Forms.Button blast;
        private System.Windows.Forms.Button mega;
    }
}

