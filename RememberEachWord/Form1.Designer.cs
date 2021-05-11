namespace RememberEachWord
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadCurrentGameCtrlRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertRoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.storeRoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.autosaveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.visibleFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unvisibleFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.roundToolStripMenuItem,
            this.editorToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(347, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.saveGameAsToolStripMenuItem,
            this.openGameToolStripMenuItem,
            this.reloadCurrentGameCtrlRToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.newGameToolStripMenuItem.Text = "New Game (Ctrl+\'N\')";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.saveGameToolStripMenuItem.Text = "Save Game (Ctrl+\'S\')";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // saveGameAsToolStripMenuItem
            // 
            this.saveGameAsToolStripMenuItem.Name = "saveGameAsToolStripMenuItem";
            this.saveGameAsToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.saveGameAsToolStripMenuItem.Text = "Save Game As (Ctrl+Shift+\'S\')";
            this.saveGameAsToolStripMenuItem.Click += new System.EventHandler(this.saveGameAsToolStripMenuItem_Click);
            // 
            // openGameToolStripMenuItem
            // 
            this.openGameToolStripMenuItem.Name = "openGameToolStripMenuItem";
            this.openGameToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.openGameToolStripMenuItem.Text = "Open Game (Ctrl+\'O\')";
            this.openGameToolStripMenuItem.Click += new System.EventHandler(this.openGameToolStripMenuItem_Click);
            // 
            // reloadCurrentGameCtrlRToolStripMenuItem
            // 
            this.reloadCurrentGameCtrlRToolStripMenuItem.Name = "reloadCurrentGameCtrlRToolStripMenuItem";
            this.reloadCurrentGameCtrlRToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.reloadCurrentGameCtrlRToolStripMenuItem.Text = "Reload Current Game (Ctrl+\'R\')";
            this.reloadCurrentGameCtrlRToolStripMenuItem.Click += new System.EventHandler(this.reloadCurrentGameCtrlRToolStripMenuItem_Click);
            // 
            // roundToolStripMenuItem
            // 
            this.roundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRoundToolStripMenuItem,
            this.insertRoundToolStripMenuItem,
            this.deleteRoundToolStripMenuItem,
            this.toolStripMenuItem1,
            this.storeRoundToolStripMenuItem});
            this.roundToolStripMenuItem.Name = "roundToolStripMenuItem";
            this.roundToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.roundToolStripMenuItem.Text = "Round";
            // 
            // newRoundToolStripMenuItem
            // 
            this.newRoundToolStripMenuItem.Name = "newRoundToolStripMenuItem";
            this.newRoundToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.newRoundToolStripMenuItem.Text = "Add Round (Ctrl+\'+\')";
            this.newRoundToolStripMenuItem.Click += new System.EventHandler(this.newRoundToolStripMenuItem_Click);
            // 
            // insertRoundToolStripMenuItem
            // 
            this.insertRoundToolStripMenuItem.Name = "insertRoundToolStripMenuItem";
            this.insertRoundToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.insertRoundToolStripMenuItem.Text = "Insert Round (Ctrl+\'Insert\')";
            this.insertRoundToolStripMenuItem.Click += new System.EventHandler(this.insertRoundToolStripMenuItem_Click);
            // 
            // deleteRoundToolStripMenuItem
            // 
            this.deleteRoundToolStripMenuItem.Name = "deleteRoundToolStripMenuItem";
            this.deleteRoundToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.deleteRoundToolStripMenuItem.Text = "Delete Round (Ctrl+\'Del\')";
            this.deleteRoundToolStripMenuItem.Click += new System.EventHandler(this.deleteRoundToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(253, 6);
            // 
            // storeRoundToolStripMenuItem
            // 
            this.storeRoundToolStripMenuItem.Name = "storeRoundToolStripMenuItem";
            this.storeRoundToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.storeRoundToolStripMenuItem.Text = "Store Round (Ctrl+\'M\')";
            this.storeRoundToolStripMenuItem.Click += new System.EventHandler(this.storeRoundToolStripMenuItem_Click);
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem6,
            this.toolStripMenuItem5,
            this.autosaveChangesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem2,
            this.visibleFontToolStripMenuItem,
            this.unvisibleFontToolStripMenuItem});
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.editorToolStripMenuItem.Text = "Game";
            // 
            // showHideToolStripMenuItem
            // 
            this.showHideToolStripMenuItem.Name = "showHideToolStripMenuItem";
            this.showHideToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.showHideToolStripMenuItem.Text = "Show/Hide (~)";
            this.showHideToolStripMenuItem.Click += new System.EventHandler(this.showHideToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(267, 26);
            this.toolStripMenuItem3.Text = "Fullscreen (Ctrl+Enter)";
            this.toolStripMenuItem3.CheckedChanged += new System.EventHandler(this.toolStripMenuItem3_CheckedChanged);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(267, 26);
            this.toolStripMenuItem6.Text = "Show All Words (Ctrl+\'A\')";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(264, 6);
            // 
            // autosaveChangesToolStripMenuItem
            // 
            this.autosaveChangesToolStripMenuItem.CheckOnClick = true;
            this.autosaveChangesToolStripMenuItem.Name = "autosaveChangesToolStripMenuItem";
            this.autosaveChangesToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.autosaveChangesToolStripMenuItem.Text = "Autosave Changes (Ctrl+\'C\')";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.CheckOnClick = true;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(267, 26);
            this.toolStripMenuItem4.Text = "Play Sound (Ctrl+P)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(264, 6);
            // 
            // visibleFontToolStripMenuItem
            // 
            this.visibleFontToolStripMenuItem.Name = "visibleFontToolStripMenuItem";
            this.visibleFontToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.visibleFontToolStripMenuItem.Text = "Visible font (F1)";
            this.visibleFontToolStripMenuItem.Click += new System.EventHandler(this.visibleFontToolStripMenuItem_Click);
            // 
            // unvisibleFontToolStripMenuItem
            // 
            this.unvisibleFontToolStripMenuItem.Name = "unvisibleFontToolStripMenuItem";
            this.unvisibleFontToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.unvisibleFontToolStripMenuItem.Text = "Unvisible font (F2)";
            this.unvisibleFontToolStripMenuItem.Click += new System.EventHandler(this.unvisibleFontToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(0, 28);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(347, 605);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox1_DragOver);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            this.listBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(347, 633);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Remembe Each Word";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRoundToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem insertRoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem visibleFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unvisibleFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem storeRoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadCurrentGameCtrlRToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem autosaveChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;



    }
}

