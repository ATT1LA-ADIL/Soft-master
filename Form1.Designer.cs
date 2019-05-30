using Программное_обеспечение_для_Диспетчеров_Службы_Спасения.WpfForm.LoadWpfTo_WinForm;

namespace Программное_обеспечение_для_Диспетчеров_Службы_Спасения
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMainWindows = new System.Windows.Forms.Panel();
            this.btnexpandthewindow = new System.Windows.Forms.Button();
            this.btnturn = new System.Windows.Forms.Button();
            this.btnreducethewindow = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.panelleftmenu = new System.Windows.Forms.Panel();
            this.pnlswitch = new System.Windows.Forms.Panel();
            this.btnstatistics = new System.Windows.Forms.Button();
            this.btnperformed = new System.Windows.Forms.Button();
            this.btnapplications = new System.Windows.Forms.Button();
            this.lbldispatcher = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelcontent = new System.Windows.Forms.Panel();
            this.LoadHost = new System.Windows.Forms.Integration.ElementHost();
            this.panelMainWindows.SuspendLayout();
            this.panelleftmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelcontent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainWindows
            // 
            this.panelMainWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(74)))), ((int)(((byte)(104)))));
            this.panelMainWindows.Controls.Add(this.btnexpandthewindow);
            this.panelMainWindows.Controls.Add(this.btnturn);
            this.panelMainWindows.Controls.Add(this.btnreducethewindow);
            this.panelMainWindows.Controls.Add(this.btnexit);
            this.panelMainWindows.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainWindows.Location = new System.Drawing.Point(0, 0);
            this.panelMainWindows.Name = "panelMainWindows";
            this.panelMainWindows.Size = new System.Drawing.Size(1100, 40);
            this.panelMainWindows.TabIndex = 0;
            // 
            // btnexpandthewindow
            // 
            this.btnexpandthewindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexpandthewindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexpandthewindow.FlatAppearance.BorderSize = 0;
            this.btnexpandthewindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnexpandthewindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.btnexpandthewindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexpandthewindow.Image = global::Программное_обеспечение_для_Диспетчеров_Службы_Спасения.Properties.Resources.ic_video_label_white_18dp;
            this.btnexpandthewindow.Location = new System.Drawing.Point(1011, 0);
            this.btnexpandthewindow.Name = "btnexpandthewindow";
            this.btnexpandthewindow.Size = new System.Drawing.Size(40, 40);
            this.btnexpandthewindow.TabIndex = 3;
            this.btnexpandthewindow.UseVisualStyleBackColor = true;
            this.btnexpandthewindow.Visible = false;
            this.btnexpandthewindow.Click += new System.EventHandler(this.Btnexpandthewindow_Click);
            // 
            // btnturn
            // 
            this.btnturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnturn.FlatAppearance.BorderSize = 0;
            this.btnturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.btnturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnturn.Image = global::Программное_обеспечение_для_Диспетчеров_Службы_Спасения.Properties.Resources.ic_remove_white_18dp;
            this.btnturn.Location = new System.Drawing.Point(965, 0);
            this.btnturn.Name = "btnturn";
            this.btnturn.Size = new System.Drawing.Size(40, 40);
            this.btnturn.TabIndex = 2;
            this.btnturn.UseVisualStyleBackColor = true;
            this.btnturn.Click += new System.EventHandler(this.Btnturn_Click);
            // 
            // btnreducethewindow
            // 
            this.btnreducethewindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnreducethewindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreducethewindow.FlatAppearance.BorderSize = 0;
            this.btnreducethewindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnreducethewindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.btnreducethewindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreducethewindow.Image = global::Программное_обеспечение_для_Диспетчеров_Службы_Спасения.Properties.Resources.ic_branding_watermark_white_18dp;
            this.btnreducethewindow.Location = new System.Drawing.Point(1011, 0);
            this.btnreducethewindow.Name = "btnreducethewindow";
            this.btnreducethewindow.Size = new System.Drawing.Size(40, 40);
            this.btnreducethewindow.TabIndex = 1;
            this.btnreducethewindow.UseVisualStyleBackColor = true;
            this.btnreducethewindow.Click += new System.EventHandler(this.Btnreducethewindow_Click);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnexit.Image = global::Программное_обеспечение_для_Диспетчеров_Службы_Спасения.Properties.Resources.ic_clear_white_18dp;
            this.btnexit.Location = new System.Drawing.Point(1057, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(40, 40);
            this.btnexit.TabIndex = 0;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // panelleftmenu
            // 
            this.panelleftmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(94)))), ((int)(((byte)(121)))));
            this.panelleftmenu.Controls.Add(this.pnlswitch);
            this.panelleftmenu.Controls.Add(this.btnstatistics);
            this.panelleftmenu.Controls.Add(this.btnperformed);
            this.panelleftmenu.Controls.Add(this.btnapplications);
            this.panelleftmenu.Controls.Add(this.lbldispatcher);
            this.panelleftmenu.Controls.Add(this.pictureBox1);
            this.panelleftmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleftmenu.Location = new System.Drawing.Point(0, 40);
            this.panelleftmenu.Name = "panelleftmenu";
            this.panelleftmenu.Size = new System.Drawing.Size(200, 540);
            this.panelleftmenu.TabIndex = 1;
            // 
            // pnlswitch
            // 
            this.pnlswitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(154)))), ((int)(((byte)(209)))));
            this.pnlswitch.Location = new System.Drawing.Point(0, 153);
            this.pnlswitch.Name = "pnlswitch";
            this.pnlswitch.Size = new System.Drawing.Size(5, 36);
            this.pnlswitch.TabIndex = 0;
            // 
            // btnstatistics
            // 
            this.btnstatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstatistics.FlatAppearance.BorderSize = 0;
            this.btnstatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnstatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.btnstatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstatistics.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstatistics.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnstatistics.Image = global::Программное_обеспечение_для_Диспетчеров_Службы_Спасения.Properties.Resources.ic_equalizer_white_24dp;
            this.btnstatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstatistics.Location = new System.Drawing.Point(3, 237);
            this.btnstatistics.Name = "btnstatistics";
            this.btnstatistics.Size = new System.Drawing.Size(191, 36);
            this.btnstatistics.TabIndex = 4;
            this.btnstatistics.Text = "  Статистика";
            this.btnstatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnstatistics.UseVisualStyleBackColor = true;
            this.btnstatistics.Click += new System.EventHandler(this.Btnstatistics_Click);
            // 
            // btnperformed
            // 
            this.btnperformed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnperformed.FlatAppearance.BorderSize = 0;
            this.btnperformed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnperformed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.btnperformed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnperformed.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnperformed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnperformed.Image = global::Программное_обеспечение_для_Диспетчеров_Службы_Спасения.Properties.Resources.ic_assignment_turned_in_white_24dp;
            this.btnperformed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnperformed.Location = new System.Drawing.Point(3, 195);
            this.btnperformed.Name = "btnperformed";
            this.btnperformed.Size = new System.Drawing.Size(191, 36);
            this.btnperformed.TabIndex = 3;
            this.btnperformed.Text = "  Выполненные";
            this.btnperformed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnperformed.UseVisualStyleBackColor = true;
            this.btnperformed.Click += new System.EventHandler(this.Btnperformed_Click);
            // 
            // btnapplications
            // 
            this.btnapplications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnapplications.FlatAppearance.BorderSize = 0;
            this.btnapplications.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnapplications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.btnapplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnapplications.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapplications.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnapplications.Image = global::Программное_обеспечение_для_Диспетчеров_Службы_Спасения.Properties.Resources.ic_contact_phone_white_24dp;
            this.btnapplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnapplications.Location = new System.Drawing.Point(3, 153);
            this.btnapplications.Name = "btnapplications";
            this.btnapplications.Size = new System.Drawing.Size(191, 36);
            this.btnapplications.TabIndex = 2;
            this.btnapplications.Text = "  Заявки";
            this.btnapplications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnapplications.UseVisualStyleBackColor = true;
            this.btnapplications.Click += new System.EventHandler(this.Btnapplications_Click);
            // 
            // lbldispatcher
            // 
            this.lbldispatcher.AutoSize = true;
            this.lbldispatcher.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldispatcher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldispatcher.Location = new System.Drawing.Point(39, 109);
            this.lbldispatcher.Name = "lbldispatcher";
            this.lbldispatcher.Size = new System.Drawing.Size(117, 27);
            this.lbldispatcher.TabIndex = 1;
            this.lbldispatcher.Text = "Диспетчер";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Программное_обеспечение_для_Диспетчеров_Службы_Спасения.Properties.Resources.ic_headset_mic_white_48dp;
            this.pictureBox1.Location = new System.Drawing.Point(44, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelcontent
            // 
            this.panelcontent.Controls.Add(this.LoadHost);
            this.panelcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontent.ForeColor = System.Drawing.Color.Red;
            this.panelcontent.Location = new System.Drawing.Point(200, 40);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(900, 540);
            this.panelcontent.TabIndex = 2;
            // 
            // LoadHost
            // 
            this.LoadHost.Location = new System.Drawing.Point(0, 0);
            this.LoadHost.Name = "LoadHost";
            this.LoadHost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoadHost.Size = new System.Drawing.Size(900, 540);
            this.LoadHost.TabIndex = 0;
            this.LoadHost.Text = "LoadHost";
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 580);
            this.Controls.Add(this.panelcontent);
            this.Controls.Add(this.panelleftmenu);
            this.Controls.Add(this.panelMainWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMainWindows.ResumeLayout(false);
            this.panelleftmenu.ResumeLayout(false);
            this.panelleftmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelcontent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        /// <summary>
        /// Загрузка наших страниц
        /// </summary>
        
        private System.Windows.Forms.Panel panelMainWindows;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panelleftmenu;
        private System.Windows.Forms.Panel panelcontent;
        private System.Windows.Forms.Button btnreducethewindow;
        private System.Windows.Forms.Button btnturn;
        private System.Windows.Forms.Button btnexpandthewindow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbldispatcher;
        private System.Windows.Forms.Button btnapplications;
        private System.Windows.Forms.Button btnstatistics;
        private System.Windows.Forms.Button btnperformed;
        private System.Windows.Forms.Panel pnlswitch;
        private System.Windows.Forms.Integration.ElementHost LoadHost;
    }
}

