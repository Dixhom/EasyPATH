namespace EasyPATH
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_system = new System.Windows.Forms.ListBox();
            this.listBox_user = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_delete_sys = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_add_sys = new System.Windows.Forms.Button();
            this.button_up_sys = new System.Windows.Forms.Button();
            this.button_down_sys = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_user_to_sys = new System.Windows.Forms.Button();
            this.button_sys_to_user = new System.Windows.Forms.Button();
            this.button_delete_user = new System.Windows.Forms.Button();
            this.button_add_user = new System.Windows.Forms.Button();
            this.button_up_user = new System.Windows.Forms.Button();
            this.button_down_user = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_system
            // 
            this.listBox_system.FormattingEnabled = true;
            this.listBox_system.ItemHeight = 18;
            this.listBox_system.Location = new System.Drawing.Point(38, 110);
            this.listBox_system.Name = "listBox_system";
            this.listBox_system.Size = new System.Drawing.Size(628, 184);
            this.listBox_system.TabIndex = 0;
            this.listBox_system.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // listBox_user
            // 
            this.listBox_user.FormattingEnabled = true;
            this.listBox_user.ItemHeight = 18;
            this.listBox_user.Location = new System.Drawing.Point(38, 351);
            this.listBox_user.Name = "listBox_user";
            this.listBox_user.Size = new System.Drawing.Size(628, 184);
            this.listBox_user.TabIndex = 0;
            this.listBox_user.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox2_DrawItem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(442, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Red text indicates non-existent path.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Envinronment PATH";
            // 
            // button_refresh
            // 
            this.button_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_refresh.BackgroundImage")));
            this.button_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_refresh.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Location = new System.Drawing.Point(282, 31);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(139, 48);
            this.button_refresh.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button_refresh, "This refreshes items in System Envrionment PATH and User Environment PATH.");
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_delete_sys
            // 
            this.button_delete_sys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_delete_sys.BackgroundImage")));
            this.button_delete_sys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_delete_sys.Location = new System.Drawing.Point(674, 159);
            this.button_delete_sys.Name = "button_delete_sys";
            this.button_delete_sys.Size = new System.Drawing.Size(44, 44);
            this.button_delete_sys.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_delete_sys, "This deletes an item in System Environment PATH ListBox.");
            this.button_delete_sys.UseVisualStyleBackColor = true;
            this.button_delete_sys.Click += new System.EventHandler(this.button_delete_sys_Click);
            // 
            // button_save
            // 
            this.button_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_save.BackgroundImage")));
            this.button_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_save.Location = new System.Drawing.Point(370, 552);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(51, 44);
            this.button_save.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_save, "This saves the contents of System Environment PATH and User Environment PATH List" +
        "Box to actual variables.");
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_add_sys
            // 
            this.button_add_sys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_add_sys.BackgroundImage")));
            this.button_add_sys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_add_sys.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_add_sys.Location = new System.Drawing.Point(672, 110);
            this.button_add_sys.Name = "button_add_sys";
            this.button_add_sys.Size = new System.Drawing.Size(46, 44);
            this.button_add_sys.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_add_sys, "This adds an item to System Environment PATH ListBox.");
            this.button_add_sys.UseVisualStyleBackColor = true;
            this.button_add_sys.Click += new System.EventHandler(this.button_add_sys_Click);
            // 
            // button_up_sys
            // 
            this.button_up_sys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_up_sys.BackgroundImage")));
            this.button_up_sys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_up_sys.Location = new System.Drawing.Point(672, 209);
            this.button_up_sys.Name = "button_up_sys";
            this.button_up_sys.Size = new System.Drawing.Size(46, 41);
            this.button_up_sys.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_up_sys, "This moves up an item in System Environment PATH ListBox.");
            this.button_up_sys.UseVisualStyleBackColor = true;
            this.button_up_sys.Click += new System.EventHandler(this.button_up_sys_Click);
            // 
            // button_down_sys
            // 
            this.button_down_sys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_down_sys.BackgroundImage")));
            this.button_down_sys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_down_sys.Location = new System.Drawing.Point(674, 256);
            this.button_down_sys.Name = "button_down_sys";
            this.button_down_sys.Size = new System.Drawing.Size(44, 41);
            this.button_down_sys.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_down_sys, "This moves down an item in System Environment PATH ListBox.");
            this.button_down_sys.UseVisualStyleBackColor = true;
            this.button_down_sys.Click += new System.EventHandler(this.button_down_sys_Click);
            // 
            // button_clean
            // 
            this.button_clean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_clean.BackgroundImage")));
            this.button_clean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_clean.Location = new System.Drawing.Point(270, 552);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(51, 44);
            this.button_clean.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button_clean, "This automatically deletes all non-exsistent PATHs indicated by red characters in" +
        " System Environment PATH and User Environment PATH ListBox.");
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // button_user_to_sys
            // 
            this.button_user_to_sys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_user_to_sys.BackgroundImage")));
            this.button_user_to_sys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_user_to_sys.Location = new System.Drawing.Point(275, 300);
            this.button_user_to_sys.Name = "button_user_to_sys";
            this.button_user_to_sys.Size = new System.Drawing.Size(46, 41);
            this.button_user_to_sys.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_user_to_sys, "This transfers items in User Environment PATH ListBox to System Envrionment PATH " +
        "ListBox.");
            this.button_user_to_sys.UseVisualStyleBackColor = true;
            this.button_user_to_sys.Click += new System.EventHandler(this.button_user_to_sys_Click);
            // 
            // button_sys_to_user
            // 
            this.button_sys_to_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sys_to_user.BackgroundImage")));
            this.button_sys_to_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_sys_to_user.Location = new System.Drawing.Point(370, 300);
            this.button_sys_to_user.Name = "button_sys_to_user";
            this.button_sys_to_user.Size = new System.Drawing.Size(44, 41);
            this.button_sys_to_user.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_sys_to_user, "This transfers items in System Envrionment PATH ListBox to User Environment PATH " +
        "ListBox ");
            this.button_sys_to_user.UseVisualStyleBackColor = true;
            this.button_sys_to_user.Click += new System.EventHandler(this.button_sys_to_user_Click);
            // 
            // button_delete_user
            // 
            this.button_delete_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_delete_user.BackgroundImage")));
            this.button_delete_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_delete_user.Location = new System.Drawing.Point(674, 401);
            this.button_delete_user.Name = "button_delete_user";
            this.button_delete_user.Size = new System.Drawing.Size(44, 44);
            this.button_delete_user.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_delete_user, "This deletes an item to User Environment PATH ListBox.");
            this.button_delete_user.UseVisualStyleBackColor = true;
            this.button_delete_user.Click += new System.EventHandler(this.button_delete_user_Click);
            // 
            // button_add_user
            // 
            this.button_add_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_add_user.BackgroundImage")));
            this.button_add_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_add_user.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_add_user.Location = new System.Drawing.Point(672, 351);
            this.button_add_user.Name = "button_add_user";
            this.button_add_user.Size = new System.Drawing.Size(46, 44);
            this.button_add_user.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_add_user, "This adds an item to User Envrironment PATH ListBox.");
            this.button_add_user.UseVisualStyleBackColor = true;
            this.button_add_user.Click += new System.EventHandler(this.button_add_user_Click);
            // 
            // button_up_user
            // 
            this.button_up_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_up_user.BackgroundImage")));
            this.button_up_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_up_user.Location = new System.Drawing.Point(674, 451);
            this.button_up_user.Name = "button_up_user";
            this.button_up_user.Size = new System.Drawing.Size(46, 41);
            this.button_up_user.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_up_user, "This moves up an item in User Environment PATH ListBox.");
            this.button_up_user.UseVisualStyleBackColor = true;
            this.button_up_user.Click += new System.EventHandler(this.button_up_user_Click);
            // 
            // button_down_user
            // 
            this.button_down_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_down_user.BackgroundImage")));
            this.button_down_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_down_user.Location = new System.Drawing.Point(676, 498);
            this.button_down_user.Name = "button_down_user";
            this.button_down_user.Size = new System.Drawing.Size(44, 41);
            this.button_down_user.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_down_user, "This moves down an item in User Environment PATH ListBox.");
            this.button_down_user.UseVisualStyleBackColor = true;
            this.button_down_user.Click += new System.EventHandler(this.button_down_user_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(442, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Red text indicates non-existent path.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 608);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_sys_to_user);
            this.Controls.Add(this.button_down_user);
            this.Controls.Add(this.button_down_sys);
            this.Controls.Add(this.button_user_to_sys);
            this.Controls.Add(this.button_up_user);
            this.Controls.Add(this.button_up_sys);
            this.Controls.Add(this.button_add_user);
            this.Controls.Add(this.button_delete_user);
            this.Controls.Add(this.button_add_sys);
            this.Controls.Add(this.button_delete_sys);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_user);
            this.Controls.Add(this.listBox_system);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "EasyPATH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_system;
        private System.Windows.Forms.ListBox listBox_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_delete_sys;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_add_sys;
        private System.Windows.Forms.Button button_up_sys;
        private System.Windows.Forms.Button button_down_sys;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_user_to_sys;
        private System.Windows.Forms.Button button_sys_to_user;
        private System.Windows.Forms.Button button_delete_user;
        private System.Windows.Forms.Button button_add_user;
        private System.Windows.Forms.Button button_up_user;
        private System.Windows.Forms.Button button_down_user;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
    }
}

