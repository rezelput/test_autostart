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
            this.menu_file = new System.Windows.Forms.ToolStripSplitButton();
            this.exit_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.автозапускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.start_service = new System.Windows.Forms.ToolStripMenuItem();
            this.end_service = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exit_closemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.create_new = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.toolStripSeparator1,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(512, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menu_file
            // 
            this.menu_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.create_new,
            this.exit_btn});
            this.menu_file.Image = ((System.Drawing.Image)(resources.GetObject("menu_file.Image")));
            this.menu_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(52, 22);
            this.menu_file.Text = "Файл";
            // 
            // exit_btn
            // 
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(180, 22);
            this.exit_btn.Text = "Выход";
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.автозапускToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.автозапускToolStripMenuItem.Text = "Логи базы";
            // 
            // start_service
            // 
            this.start_service.Name = "start_service";
            this.start_service.Size = new System.Drawing.Size(99, 22);
            this.start_service.Text = "вкл";
            this.start_service.Click += new System.EventHandler(this.start_service_Click);
            // 
            // end_service
            // 
            this.end_service.Name = "end_service";
            this.end_service.Size = new System.Drawing.Size(99, 22);
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
            this.MenuStrip.Size = new System.Drawing.Size(110, 26);
            // 
            // exit_closemenu
            // 
            this.exit_closemenu.Name = "exit_closemenu";
            this.exit_closemenu.Size = new System.Drawing.Size(109, 22);
            this.exit_closemenu.Text = "Выход";
            this.exit_closemenu.Click += new System.EventHandler(this.exit_closemenu_Click);
            // 
            // create_new
            // 
            this.create_new.Name = "create_new";
            this.create_new.Size = new System.Drawing.Size(180, 22);
            this.create_new.Text = "Создать...";
            this.create_new.Click += new System.EventHandler(this.create_new_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 221);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exit_closemenu;
        private System.Windows.Forms.ToolStripSplitButton menu_file;
        private System.Windows.Forms.ToolStripMenuItem exit_btn;
        private System.Windows.Forms.ToolStripMenuItem create_new;
    }
}

