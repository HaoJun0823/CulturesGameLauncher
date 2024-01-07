namespace CulturesGameLauncher
{
    partial class CulturesGameLauncher
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl_Main = new System.Windows.Forms.TabControl();
            this.TabPage_Game = new System.Windows.Forms.TabPage();
            this.TabPage_Video = new System.Windows.Forms.TabPage();
            this.TabPage_Maps = new System.Windows.Forms.TabPage();
            this.TableLayoutPanel_Game = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel_Video = new System.Windows.Forms.TableLayoutPanel();
            this.Label_Video_Width = new System.Windows.Forms.Label();
            this.ComboBox_Video_Width = new System.Windows.Forms.ComboBox();
            this.Label_Video_Height = new System.Windows.Forms.Label();
            this.ComboBox_Video_Height = new System.Windows.Forms.ComboBox();
            this.Label_Video_Depth = new System.Windows.Forms.Label();
            this.ComboBox_Video_Depth = new System.Windows.Forms.ComboBox();
            this.RadioButton_Video_FullScreen = new System.Windows.Forms.RadioButton();
            this.MenuStrip_Main.SuspendLayout();
            this.TabControl_Main.SuspendLayout();
            this.TabPage_Game.SuspendLayout();
            this.TabPage_Video.SuspendLayout();
            this.TableLayoutPanel_Video.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(624, 25);
            this.MenuStrip_Main.TabIndex = 0;
            this.MenuStrip_Main.Text = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Controls.Add(this.TabPage_Game);
            this.TabControl_Main.Controls.Add(this.TabPage_Video);
            this.TabControl_Main.Controls.Add(this.TabPage_Maps);
            this.TabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_Main.Location = new System.Drawing.Point(0, 25);
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(624, 256);
            this.TabControl_Main.TabIndex = 1;
            // 
            // TabPage_Game
            // 
            this.TabPage_Game.Controls.Add(this.TableLayoutPanel_Game);
            this.TabPage_Game.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Game.Name = "TabPage_Game";
            this.TabPage_Game.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Game.Size = new System.Drawing.Size(616, 230);
            this.TabPage_Game.TabIndex = 0;
            this.TabPage_Game.Text = "Game";
            this.TabPage_Game.UseVisualStyleBackColor = true;
            // 
            // TabPage_Video
            // 
            this.TabPage_Video.Controls.Add(this.TableLayoutPanel_Video);
            this.TabPage_Video.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Video.Name = "TabPage_Video";
            this.TabPage_Video.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Video.Size = new System.Drawing.Size(616, 230);
            this.TabPage_Video.TabIndex = 1;
            this.TabPage_Video.Text = "Video";
            this.TabPage_Video.UseVisualStyleBackColor = true;
            // 
            // TabPage_Maps
            // 
            this.TabPage_Maps.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Maps.Name = "TabPage_Maps";
            this.TabPage_Maps.Size = new System.Drawing.Size(616, 230);
            this.TabPage_Maps.TabIndex = 2;
            this.TabPage_Maps.Text = "Maps";
            this.TabPage_Maps.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel_Game
            // 
            this.TableLayoutPanel_Game.ColumnCount = 2;
            this.TableLayoutPanel_Game.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Game.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel_Game.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel_Game.Name = "TableLayoutPanel_Game";
            this.TableLayoutPanel_Game.RowCount = 2;
            this.TableLayoutPanel_Game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Game.Size = new System.Drawing.Size(610, 224);
            this.TableLayoutPanel_Game.TabIndex = 0;
            // 
            // TableLayoutPanel_Video
            // 
            this.TableLayoutPanel_Video.ColumnCount = 10;
            this.TableLayoutPanel_Video.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.Controls.Add(this.ComboBox_Video_Depth, 8, 1);
            this.TableLayoutPanel_Video.Controls.Add(this.Label_Video_Depth, 7, 1);
            this.TableLayoutPanel_Video.Controls.Add(this.Label_Video_Height, 4, 1);
            this.TableLayoutPanel_Video.Controls.Add(this.ComboBox_Video_Height, 5, 1);
            this.TableLayoutPanel_Video.Controls.Add(this.Label_Video_Width, 1, 1);
            this.TableLayoutPanel_Video.Controls.Add(this.ComboBox_Video_Width, 2, 1);
            this.TableLayoutPanel_Video.Controls.Add(this.RadioButton_Video_FullScreen, 2, 3);
            this.TableLayoutPanel_Video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel_Video.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel_Video.Name = "TableLayoutPanel_Video";
            this.TableLayoutPanel_Video.RowCount = 10;
            this.TableLayoutPanel_Video.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Video.Size = new System.Drawing.Size(610, 224);
            this.TableLayoutPanel_Video.TabIndex = 0;
            // 
            // Label_Video_Width
            // 
            this.Label_Video_Width.AutoSize = true;
            this.Label_Video_Width.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Video_Width.Location = new System.Drawing.Point(64, 22);
            this.Label_Video_Width.Name = "Label_Video_Width";
            this.Label_Video_Width.Size = new System.Drawing.Size(55, 22);
            this.Label_Video_Width.TabIndex = 0;
            this.Label_Video_Width.Text = "Width：";
            this.Label_Video_Width.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBox_Video_Width
            // 
            this.TableLayoutPanel_Video.SetColumnSpan(this.ComboBox_Video_Width, 2);
            this.ComboBox_Video_Width.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_Video_Width.FormattingEnabled = true;
            this.ComboBox_Video_Width.Location = new System.Drawing.Point(125, 25);
            this.ComboBox_Video_Width.Name = "ComboBox_Video_Width";
            this.ComboBox_Video_Width.Size = new System.Drawing.Size(116, 20);
            this.ComboBox_Video_Width.TabIndex = 1;
            // 
            // Label_Video_Height
            // 
            this.Label_Video_Height.AutoSize = true;
            this.Label_Video_Height.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Video_Height.Location = new System.Drawing.Point(247, 22);
            this.Label_Video_Height.Name = "Label_Video_Height";
            this.Label_Video_Height.Size = new System.Drawing.Size(55, 22);
            this.Label_Video_Height.TabIndex = 4;
            this.Label_Video_Height.Text = "Height：";
            this.Label_Video_Height.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBox_Video_Height
            // 
            this.TableLayoutPanel_Video.SetColumnSpan(this.ComboBox_Video_Height, 2);
            this.ComboBox_Video_Height.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_Video_Height.FormattingEnabled = true;
            this.ComboBox_Video_Height.Location = new System.Drawing.Point(308, 25);
            this.ComboBox_Video_Height.Name = "ComboBox_Video_Height";
            this.ComboBox_Video_Height.Size = new System.Drawing.Size(116, 20);
            this.ComboBox_Video_Height.TabIndex = 5;
            // 
            // Label_Video_Depth
            // 
            this.Label_Video_Depth.AutoSize = true;
            this.Label_Video_Depth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Video_Depth.Location = new System.Drawing.Point(430, 22);
            this.Label_Video_Depth.Name = "Label_Video_Depth";
            this.Label_Video_Depth.Size = new System.Drawing.Size(55, 22);
            this.Label_Video_Depth.TabIndex = 6;
            this.Label_Video_Depth.Text = "Depth：";
            this.Label_Video_Depth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBox_Video_Depth
            // 
            this.ComboBox_Video_Depth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_Video_Depth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Video_Depth.FormattingEnabled = true;
            this.ComboBox_Video_Depth.Location = new System.Drawing.Point(491, 25);
            this.ComboBox_Video_Depth.Name = "ComboBox_Video_Depth";
            this.ComboBox_Video_Depth.Size = new System.Drawing.Size(55, 20);
            this.ComboBox_Video_Depth.TabIndex = 7;
            // 
            // RadioButton_Video_FullScreen
            // 
            this.RadioButton_Video_FullScreen.AutoSize = true;
            this.TableLayoutPanel_Video.SetColumnSpan(this.RadioButton_Video_FullScreen, 2);
            this.RadioButton_Video_FullScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadioButton_Video_FullScreen.Location = new System.Drawing.Point(125, 69);
            this.RadioButton_Video_FullScreen.Name = "RadioButton_Video_FullScreen";
            this.RadioButton_Video_FullScreen.Size = new System.Drawing.Size(116, 16);
            this.RadioButton_Video_FullScreen.TabIndex = 8;
            this.RadioButton_Video_FullScreen.TabStop = true;
            this.RadioButton_Video_FullScreen.Text = "FullScreen";
            this.RadioButton_Video_FullScreen.UseVisualStyleBackColor = true;
            // 
            // CulturesGameLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 281);
            this.Controls.Add(this.TabControl_Main);
            this.Controls.Add(this.MenuStrip_Main);
            this.MainMenuStrip = this.MenuStrip_Main;
            this.Name = "CulturesGameLauncher";
            this.Text = "CulturesGameLauncher";
            this.Load += new System.EventHandler(this.CulturesGameLauncher_Load);
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.TabControl_Main.ResumeLayout(false);
            this.TabPage_Game.ResumeLayout(false);
            this.TabPage_Video.ResumeLayout(false);
            this.TableLayoutPanel_Video.ResumeLayout(false);
            this.TableLayoutPanel_Video.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.TabControl TabControl_Main;
        private System.Windows.Forms.TabPage TabPage_Game;
        private System.Windows.Forms.TabPage TabPage_Video;
        private System.Windows.Forms.TabPage TabPage_Maps;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_Game;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_Video;
        private System.Windows.Forms.Label Label_Video_Width;
        private System.Windows.Forms.ComboBox ComboBox_Video_Width;
        private System.Windows.Forms.Label Label_Video_Depth;
        private System.Windows.Forms.Label Label_Video_Height;
        private System.Windows.Forms.ComboBox ComboBox_Video_Height;
        private System.Windows.Forms.ComboBox ComboBox_Video_Depth;
        private System.Windows.Forms.RadioButton RadioButton_Video_FullScreen;
    }
}

