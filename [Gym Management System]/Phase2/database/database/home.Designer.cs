
namespace database
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectedModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectedModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.secondReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuText;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectedModeToolStripMenuItem,
            this.disconnectedModeToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 66);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectedModeToolStripMenuItem
            // 
            this.connectedModeToolStripMenuItem.Font = new System.Drawing.Font("Dutch801 XBd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedModeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.connectedModeToolStripMenuItem.Name = "connectedModeToolStripMenuItem";
            this.connectedModeToolStripMenuItem.Size = new System.Drawing.Size(141, 61);
            this.connectedModeToolStripMenuItem.Text = "connected mode";
            this.connectedModeToolStripMenuItem.Click += new System.EventHandler(this.connectedModeToolStripMenuItem_Click);
            // 
            // disconnectedModeToolStripMenuItem
            // 
            this.disconnectedModeToolStripMenuItem.Font = new System.Drawing.Font("Dutch801 XBd BT", 12F);
            this.disconnectedModeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.disconnectedModeToolStripMenuItem.Name = "disconnectedModeToolStripMenuItem";
            this.disconnectedModeToolStripMenuItem.Size = new System.Drawing.Size(162, 61);
            this.disconnectedModeToolStripMenuItem.Text = "disconnected mode";
            this.disconnectedModeToolStripMenuItem.Click += new System.EventHandler(this.disconnectedModeToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.secondReportToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Dutch801 XBd BT", 12F);
            this.reportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(67, 61);
            this.reportToolStripMenuItem.Text = "report";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.generateToolStripMenuItem.Text = "First Report";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // secondReportToolStripMenuItem
            // 
            this.secondReportToolStripMenuItem.Name = "secondReportToolStripMenuItem";
            this.secondReportToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.secondReportToolStripMenuItem.Text = "Second Report";
            this.secondReportToolStripMenuItem.Click += new System.EventHandler(this.secondReportToolStripMenuItem_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "home";
            this.Text = "home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectedModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectedModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem secondReportToolStripMenuItem;
    }
}