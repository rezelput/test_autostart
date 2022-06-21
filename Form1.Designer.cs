namespace test_autostart
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.автозапускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.start_service = new System.Windows.Forms.ToolStripMenuItem();
            this.end_service = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit_btn = new System.Windows.Forms.ToolStripButton();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exit_closemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSeparator1,
            this.exit_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автозапускToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(69, 22);
            this.toolStripSplitButton1.Text = "Службы";
            // 
            // автозапускToolStripMenuItem
            // 
            this.автозапускToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.start_service,
            this.end_service});
            this.автозапускToolStripMenuItem.Name = "автозапускToolStripMenuItem";
            this.автозапускToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.автозапускToolStripMenuItem.Text = "Логи базы";
            // 
            // start_service
            // 
            this.start_service.Name = "start_service";
            this.start_service.Size = new System.Drawing.Size(180, 22);
            this.start_service.Text = "вкл";
            this.start_service.Click += new System.EventHandler(this.start_service_Click);
            // 
            // end_service
            // 
            this.end_service.Name = "end_service";
            this.end_service.Size = new System.Drawing.Size(180, 22);
            this.end_service.Text = "откл";
            this.end_service.Click += new System.EventHandler(this.end_service_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // exit_btn
            // 
            this.exit_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("exit_btn.Image")));
            this.exit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(46, 22);
            this.exit_btn.Text = "Выход";
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // notify
            // 
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "notify";
            this.notify.Visible = true;
            this.notify.Click += new System.EventHandler(this.notify_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit_closemenu});
            this.MenuStrip.Name = "contextMenuStrip1";
            this.MenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // exit_closemenu
            // 
            this.exit_closemenu.Name = "exit_closemenu";
            this.exit_closemenu.Size = new System.Drawing.Size(180, 22);
            this.exit_closemenu.Text = "Выход";
            this.exit_closemenu.Click += new System.EventHandler(this.exit_closemenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem автозапускToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem start_service;
        private System.Windows.Forms.ToolStripMenuItem end_service;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton exit_btn;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exit_closemenu;
    }
}

