namespace Tools.Utilities.UI.Graphics
{
    partial class ElementTile
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElementTile));
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelBottomCenter = new System.Windows.Forms.Panel();
            this.panelCOrnerBottomLeft = new System.Windows.Forms.Panel();
            this.panelCornerRight = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelTopCenter = new System.Windows.Forms.Panel();
            this.panelCornerTopRight = new System.Windows.Forms.Panel();
            this.panelCornerLeft = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(4, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(16, 16);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.panelCenter);
            this.panelMain.Controls.Add(this.panelBottom);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Location = new System.Drawing.Point(24, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(304, 150);
            this.panelMain.TabIndex = 1;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.Black;
            this.panelCenter.Controls.Add(this.panelRight);
            this.panelCenter.Controls.Add(this.panelLeft);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 25);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(304, 110);
            this.panelCenter.TabIndex = 3;
            this.panelCenter.MouseLeave += new System.EventHandler(this.ElementTile_MouseLeave);
            this.panelCenter.MouseHover += new System.EventHandler(this.ElementTile_MouseHover);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(302, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(2, 110);
            this.panelRight.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(2, 110);
            this.panelLeft.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelBottomCenter);
            this.panelBottom.Controls.Add(this.panelCOrnerBottomLeft);
            this.panelBottom.Controls.Add(this.panelCornerRight);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 135);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(304, 15);
            this.panelBottom.TabIndex = 0;
            // 
            // panelBottomCenter
            // 
            this.panelBottomCenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBottomCenter.BackgroundImage")));
            this.panelBottomCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottomCenter.Location = new System.Drawing.Point(25, 0);
            this.panelBottomCenter.Name = "panelBottomCenter";
            this.panelBottomCenter.Size = new System.Drawing.Size(254, 15);
            this.panelBottomCenter.TabIndex = 3;
            // 
            // panelCOrnerBottomLeft
            // 
            this.panelCOrnerBottomLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCOrnerBottomLeft.BackgroundImage")));
            this.panelCOrnerBottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCOrnerBottomLeft.Location = new System.Drawing.Point(0, 0);
            this.panelCOrnerBottomLeft.Name = "panelCOrnerBottomLeft";
            this.panelCOrnerBottomLeft.Size = new System.Drawing.Size(25, 15);
            this.panelCOrnerBottomLeft.TabIndex = 2;
            // 
            // panelCornerRight
            // 
            this.panelCornerRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCornerRight.BackgroundImage")));
            this.panelCornerRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCornerRight.Location = new System.Drawing.Point(279, 0);
            this.panelCornerRight.Name = "panelCornerRight";
            this.panelCornerRight.Size = new System.Drawing.Size(25, 15);
            this.panelCornerRight.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelTopCenter);
            this.panelTop.Controls.Add(this.panelCornerTopRight);
            this.panelTop.Controls.Add(this.panelCornerLeft);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(304, 25);
            this.panelTop.TabIndex = 2;
            // 
            // panelTopCenter
            // 
            this.panelTopCenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTopCenter.BackgroundImage")));
            this.panelTopCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopCenter.Location = new System.Drawing.Point(25, 0);
            this.panelTopCenter.Name = "panelTopCenter";
            this.panelTopCenter.Size = new System.Drawing.Size(254, 25);
            this.panelTopCenter.TabIndex = 0;
            // 
            // panelCornerTopRight
            // 
            this.panelCornerTopRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCornerTopRight.BackgroundImage")));
            this.panelCornerTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCornerTopRight.Location = new System.Drawing.Point(279, 0);
            this.panelCornerTopRight.Name = "panelCornerTopRight";
            this.panelCornerTopRight.Size = new System.Drawing.Size(25, 25);
            this.panelCornerTopRight.TabIndex = 1;
            // 
            // panelCornerLeft
            // 
            this.panelCornerLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCornerLeft.BackgroundImage")));
            this.panelCornerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCornerLeft.Location = new System.Drawing.Point(0, 0);
            this.panelCornerLeft.Name = "panelCornerLeft";
            this.panelCornerLeft.Size = new System.Drawing.Size(25, 25);
            this.panelCornerLeft.TabIndex = 0;
            // 
            // ElementTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.buttonClose);
            this.Name = "ElementTile";
            this.Size = new System.Drawing.Size(333, 179);
            this.MouseLeave += new System.EventHandler(this.ElementTile_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ElementTile_MouseHover);
            this.panelMain.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelCornerRight;
        private System.Windows.Forms.Panel panelCornerLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelCornerTopRight;
        private System.Windows.Forms.Panel panelCOrnerBottomLeft;
        private System.Windows.Forms.Panel panelTopCenter;
        private System.Windows.Forms.Panel panelBottomCenter;
    }
}
