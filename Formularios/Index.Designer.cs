
namespace RandomNamePicker
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.Randomizer = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.MaximizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.AnimationDespliegueMenu = new System.Windows.Forms.Timer(this.components);
            this.UserList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectedUser = new System.Windows.Forms.Label();
            this.RandomAnim = new System.Windows.Forms.Timer(this.components);
            this.winFeedback = new System.Windows.Forms.PictureBox();
            this.LeftPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.FormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LeftPanel.Controls.Add(this.Randomizer);
            this.LeftPanel.Controls.Add(this.Delete);
            this.LeftPanel.Controls.Add(this.Insert);
            this.LeftPanel.Controls.Add(this.Menu);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(266, 496);
            this.LeftPanel.TabIndex = 0;
            // 
            // Randomizer
            // 
            this.Randomizer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Randomizer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Randomizer.FlatAppearance.BorderSize = 0;
            this.Randomizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Randomizer.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Randomizer.ForeColor = System.Drawing.Color.Gainsboro;
            this.Randomizer.Location = new System.Drawing.Point(0, 255);
            this.Randomizer.Name = "Randomizer";
            this.Randomizer.Size = new System.Drawing.Size(266, 79);
            this.Randomizer.TabIndex = 5;
            this.Randomizer.Text = "Randomizar";
            this.Randomizer.UseVisualStyleBackColor = true;
            this.Randomizer.Click += new System.EventHandler(this.Randomizer_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Gainsboro;
            this.Delete.Location = new System.Drawing.Point(0, 170);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(266, 79);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Eliminar Participante";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Insert
            // 
            this.Insert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insert.FlatAppearance.BorderSize = 0;
            this.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.ForeColor = System.Drawing.Color.Gainsboro;
            this.Insert.Location = new System.Drawing.Point(0, 85);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(266, 79);
            this.Insert.TabIndex = 3;
            this.Insert.Text = "Insertar Participante";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Menu
            // 
            this.Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu.FlatAppearance.BorderSize = 0;
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.Font = new System.Drawing.Font("Ubuntu", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.Gainsboro;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(266, 79);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "☰";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TopPanel.Controls.Add(this.MinimizeButton);
            this.TopPanel.Controls.Add(this.MaximizeButton);
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(266, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(656, 32);
            this.TopPanel.TabIndex = 1;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MinimizeButton.BackColor = System.Drawing.Color.Silver;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.Black;
            this.MinimizeButton.Location = new System.Drawing.Point(428, 1);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(76, 31);
            this.MinimizeButton.TabIndex = 6;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MaximizeButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MaximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeButton.ForeColor = System.Drawing.Color.Black;
            this.MaximizeButton.Location = new System.Drawing.Point(504, 1);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(76, 31);
            this.MaximizeButton.TabIndex = 5;
            this.MaximizeButton.Text = "❒";
            this.MaximizeButton.UseVisualStyleBackColor = false;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(580, 1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(76, 31);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FormPanel
            // 
            this.FormPanel.Controls.Add(this.winFeedback);
            this.FormPanel.Controls.Add(this.SelectedUser);
            this.FormPanel.Controls.Add(this.label2);
            this.FormPanel.Controls.Add(this.label1);
            this.FormPanel.Controls.Add(this.UserList);
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(266, 32);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(656, 464);
            this.FormPanel.TabIndex = 2;
            // 
            // AnimationDespliegueMenu
            // 
            this.AnimationDespliegueMenu.Interval = 1;
            this.AnimationDespliegueMenu.Tick += new System.EventHandler(this.AnimationDespliegueMenu_Tick);
            // 
            // UserList
            // 
            this.UserList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UserList.FormattingEnabled = true;
            this.UserList.HorizontalScrollbar = true;
            this.UserList.ItemHeight = 17;
            this.UserList.Location = new System.Drawing.Point(7, 29);
            this.UserList.Name = "UserList";
            this.UserList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.UserList.Size = new System.Drawing.Size(150, 429);
            this.UserList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(30, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Participantes";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(228, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Participante Seleccionado";
            // 
            // SelectedUser
            // 
            this.SelectedUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SelectedUser.Font = new System.Drawing.Font("Ubuntu", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedUser.ForeColor = System.Drawing.SystemColors.MenuText;
            this.SelectedUser.Location = new System.Drawing.Point(165, 176);
            this.SelectedUser.Name = "SelectedUser";
            this.SelectedUser.Size = new System.Drawing.Size(481, 109);
            this.SelectedUser.TabIndex = 3;
            this.SelectedUser.Text = "Ganador =)";
            this.SelectedUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RandomAnim
            // 
            this.RandomAnim.Tick += new System.EventHandler(this.RandomAnim_Tick);
            // 
            // winFeedback
            // 
            this.winFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.winFeedback.BackColor = System.Drawing.Color.Red;
            this.winFeedback.Location = new System.Drawing.Point(625, 288);
            this.winFeedback.Name = "winFeedback";
            this.winFeedback.Size = new System.Drawing.Size(20, 20);
            this.winFeedback.TabIndex = 4;
            this.winFeedback.TabStop = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(922, 496);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            this.LeftPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winFeedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button MaximizeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Randomizer;
        private System.Windows.Forms.Panel FormPanel;
        public System.Windows.Forms.Timer AnimationDespliegueMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SelectedUser;
        public System.Windows.Forms.Timer RandomAnim;
        private System.Windows.Forms.PictureBox winFeedback;
    }
}

