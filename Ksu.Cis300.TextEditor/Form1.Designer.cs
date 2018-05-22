namespace Ksu.Cis300.TextEditor
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
            this.uxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.uxFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.uxTextEditorBody = new System.Windows.Forms.TextBox();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveAsDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFileMenu});
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Size = new System.Drawing.Size(525, 24);
            this.uxMenuStrip.TabIndex = 0;
            this.uxMenuStrip.Text = "menuStrip1";
            // 
            // uxFileMenu
            // 
            this.uxFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpen,
            this.uxSaveAs});
            this.uxFileMenu.Name = "uxFileMenu";
            this.uxFileMenu.Size = new System.Drawing.Size(37, 20);
            this.uxFileMenu.Text = "File";
            // 
            // uxOpen
            // 
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(180, 22);
            this.uxOpen.Text = "Open";
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxSaveAs
            // 
            this.uxSaveAs.Name = "uxSaveAs";
            this.uxSaveAs.Size = new System.Drawing.Size(180, 22);
            this.uxSaveAs.Text = "Save As";
            this.uxSaveAs.Click += new System.EventHandler(this.uxSaveAs_Click);
            // 
            // uxTextEditorBody
            // 
            this.uxTextEditorBody.Location = new System.Drawing.Point(12, 27);
            this.uxTextEditorBody.Multiline = true;
            this.uxTextEditorBody.Name = "uxTextEditorBody";
            this.uxTextEditorBody.Size = new System.Drawing.Size(501, 302);
            this.uxTextEditorBody.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 341);
            this.Controls.Add(this.uxTextEditorBody);
            this.Controls.Add(this.uxMenuStrip);
            this.MainMenuStrip = this.uxMenuStrip;
            this.Name = "Form1";
            this.Text = "Text Editor";
            this.uxMenuStrip.ResumeLayout(false);
            this.uxMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem uxFileMenu;
        private System.Windows.Forms.ToolStripMenuItem uxOpen;
        private System.Windows.Forms.ToolStripMenuItem uxSaveAs;
        private System.Windows.Forms.TextBox uxTextEditorBody;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveAsDialog;
    }
}

