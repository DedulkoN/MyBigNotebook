﻿namespace MyBigNotebook
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonDiary = new System.Windows.Forms.Button();
            this.buttonFinansial = new System.Windows.Forms.Button();
            this.buttonInformation = new System.Windows.Forms.Button();
            this.buttonNotes = new System.Windows.Forms.Button();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonPhoto = new System.Windows.Forms.Button();
            this.buttonPlants = new System.Windows.Forms.Button();
            this.contextMenuStripNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.календарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дневникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.финансовыйПомошникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заметкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фотогалереяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.планыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripmain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInTray = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStripNotify.SuspendLayout();
            this.toolStripmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.Location = new System.Drawing.Point(26, 12);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(175, 23);
            this.buttonCalendar.TabIndex = 0;
            this.buttonCalendar.Text = "Календарь";
            this.buttonCalendar.UseVisualStyleBackColor = true;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // buttonDiary
            // 
            this.buttonDiary.Location = new System.Drawing.Point(26, 42);
            this.buttonDiary.Name = "buttonDiary";
            this.buttonDiary.Size = new System.Drawing.Size(175, 23);
            this.buttonDiary.TabIndex = 1;
            this.buttonDiary.Text = "Дневник";
            this.buttonDiary.UseVisualStyleBackColor = true;
            this.buttonDiary.Click += new System.EventHandler(this.buttonDiary_Click);
            // 
            // buttonFinansial
            // 
            this.buttonFinansial.Location = new System.Drawing.Point(26, 71);
            this.buttonFinansial.Name = "buttonFinansial";
            this.buttonFinansial.Size = new System.Drawing.Size(175, 23);
            this.buttonFinansial.TabIndex = 2;
            this.buttonFinansial.Text = "Финансовый помошник";
            this.buttonFinansial.UseVisualStyleBackColor = true;
            this.buttonFinansial.Click += new System.EventHandler(this.buttonFinansial_Click);
            // 
            // buttonInformation
            // 
            this.buttonInformation.Location = new System.Drawing.Point(26, 101);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.Size = new System.Drawing.Size(175, 23);
            this.buttonInformation.TabIndex = 3;
            this.buttonInformation.Text = "Информация";
            this.buttonInformation.UseVisualStyleBackColor = true;
            this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // buttonNotes
            // 
            this.buttonNotes.Location = new System.Drawing.Point(26, 131);
            this.buttonNotes.Name = "buttonNotes";
            this.buttonNotes.Size = new System.Drawing.Size(175, 23);
            this.buttonNotes.TabIndex = 4;
            this.buttonNotes.Text = "Заметки";
            this.buttonNotes.UseVisualStyleBackColor = true;
            this.buttonNotes.Click += new System.EventHandler(this.buttonNotes_Click);
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.BalloonTipText = "записная книжка";
            this.notifyIconMain.ContextMenuStrip = this.contextMenuStripNotify;
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "Записная книжка";
            this.notifyIconMain.Visible = true;
            this.notifyIconMain.DoubleClick += new System.EventHandler(this.notifyIconMain_DoubleClick);
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Location = new System.Drawing.Point(26, 161);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(175, 23);
            this.buttonPhoto.TabIndex = 5;
            this.buttonPhoto.Text = "Фотогалерея";
            this.buttonPhoto.UseVisualStyleBackColor = true;
            this.buttonPhoto.Click += new System.EventHandler(this.buttonPhoto_Click);
            // 
            // buttonPlants
            // 
            this.buttonPlants.Location = new System.Drawing.Point(26, 191);
            this.buttonPlants.Name = "buttonPlants";
            this.buttonPlants.Size = new System.Drawing.Size(175, 23);
            this.buttonPlants.TabIndex = 6;
            this.buttonPlants.Text = "Планы";
            this.buttonPlants.UseVisualStyleBackColor = true;
            this.buttonPlants.Click += new System.EventHandler(this.buttonPlants_Click);
            // 
            // contextMenuStripNotify
            // 
            this.contextMenuStripNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.календарьToolStripMenuItem,
            this.дневникToolStripMenuItem,
            this.финансовыйПомошникToolStripMenuItem,
            this.информацияToolStripMenuItem,
            this.заметкиToolStripMenuItem,
            this.фотогалереяToolStripMenuItem,
            this.планыToolStripMenuItem});
            this.contextMenuStripNotify.Name = "contextMenuStripNotify";
            this.contextMenuStripNotify.Size = new System.Drawing.Size(210, 158);
            this.contextMenuStripNotify.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripNotify_Opening);
            // 
            // календарьToolStripMenuItem
            // 
            this.календарьToolStripMenuItem.Name = "календарьToolStripMenuItem";
            this.календарьToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.календарьToolStripMenuItem.Text = "Календарь";
            this.календарьToolStripMenuItem.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // дневникToolStripMenuItem
            // 
            this.дневникToolStripMenuItem.Name = "дневникToolStripMenuItem";
            this.дневникToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.дневникToolStripMenuItem.Text = "Дневник";
            this.дневникToolStripMenuItem.Click += new System.EventHandler(this.buttonDiary_Click);
            // 
            // финансовыйПомошникToolStripMenuItem
            // 
            this.финансовыйПомошникToolStripMenuItem.Name = "финансовыйПомошникToolStripMenuItem";
            this.финансовыйПомошникToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.финансовыйПомошникToolStripMenuItem.Text = "Финансовый помошник";
            this.финансовыйПомошникToolStripMenuItem.Click += new System.EventHandler(this.buttonFinansial_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.информацияToolStripMenuItem.Text = "Информация";
            this.информацияToolStripMenuItem.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // заметкиToolStripMenuItem
            // 
            this.заметкиToolStripMenuItem.Name = "заметкиToolStripMenuItem";
            this.заметкиToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.заметкиToolStripMenuItem.Text = "Заметки";
            this.заметкиToolStripMenuItem.Click += new System.EventHandler(this.buttonNotes_Click);
            // 
            // фотогалереяToolStripMenuItem
            // 
            this.фотогалереяToolStripMenuItem.Name = "фотогалереяToolStripMenuItem";
            this.фотогалереяToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.фотогалереяToolStripMenuItem.Text = "Фотогалерея";
            this.фотогалереяToolStripMenuItem.Click += new System.EventHandler(this.buttonPhoto_Click);
            // 
            // планыToolStripMenuItem
            // 
            this.планыToolStripMenuItem.Name = "планыToolStripMenuItem";
            this.планыToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.планыToolStripMenuItem.Text = "Планы";
            this.планыToolStripMenuItem.Click += new System.EventHandler(this.buttonPlants_Click);
            // 
            // toolStripmain
            // 
            this.toolStripmain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInTray});
            this.toolStripmain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripmain.Location = new System.Drawing.Point(0, 231);
            this.toolStripmain.Name = "toolStripmain";
            this.toolStripmain.Size = new System.Drawing.Size(222, 23);
            this.toolStripmain.TabIndex = 8;
            // 
            // toolStripButtonInTray
            // 
            this.toolStripButtonInTray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInTray.Image = global::MyBigNotebook.Properties.Resources.baseline_call_received_black_24dp;
            this.toolStripButtonInTray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInTray.Name = "toolStripButtonInTray";
            this.toolStripButtonInTray.Size = new System.Drawing.Size(23, 20);
            this.toolStripButtonInTray.Text = "В трей";
            this.toolStripButtonInTray.Click += new System.EventHandler(this.toolStripButtonInTray_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 254);
            this.Controls.Add(this.toolStripmain);
            this.Controls.Add(this.buttonPlants);
            this.Controls.Add(this.buttonPhoto);
            this.Controls.Add(this.buttonNotes);
            this.Controls.Add(this.buttonInformation);
            this.Controls.Add(this.buttonFinansial);
            this.Controls.Add(this.buttonDiary);
            this.Controls.Add(this.buttonCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.contextMenuStripNotify.ResumeLayout(false);
            this.toolStripmain.ResumeLayout(false);
            this.toolStripmain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.Button buttonDiary;
        private System.Windows.Forms.Button buttonFinansial;
        private System.Windows.Forms.Button buttonInformation;
        private System.Windows.Forms.Button buttonNotes;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.Button buttonPhoto;
        private System.Windows.Forms.Button buttonPlants;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotify;
        private System.Windows.Forms.ToolStripMenuItem календарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дневникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem финансовыйПомошникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заметкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фотогалереяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem планыToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripmain;
        private System.Windows.Forms.ToolStripButton toolStripButtonInTray;
    }
}

