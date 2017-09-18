namespace ArcadeGameStartupFormative
{
    partial class ArcadeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArcadeGame));
            this.titleLabel = new System.Windows.Forms.Label();
            this.playButton1 = new System.Windows.Forms.Button();
            this.countLabel1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Black;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("OCR A Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(45, 31);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(188, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Arcade Game";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playButton1
            // 
            this.playButton1.BackColor = System.Drawing.Color.Black;
            this.playButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.playButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton1.Font = new System.Drawing.Font("OCR A Std", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton1.ForeColor = System.Drawing.Color.White;
            this.playButton1.Location = new System.Drawing.Point(103, 143);
            this.playButton1.Name = "playButton1";
            this.playButton1.Size = new System.Drawing.Size(88, 58);
            this.playButton1.TabIndex = 1;
            this.playButton1.Text = "Play Game";
            this.playButton1.UseVisualStyleBackColor = false;
            this.playButton1.Click += new System.EventHandler(this.playButton1_Click);
            // 
            // countLabel1
            // 
            this.countLabel1.Font = new System.Drawing.Font("OCR A Std", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel1.ForeColor = System.Drawing.Color.White;
            this.countLabel1.Location = new System.Drawing.Point(12, 72);
            this.countLabel1.Name = "countLabel1";
            this.countLabel1.Size = new System.Drawing.Size(260, 68);
            this.countLabel1.TabIndex = 2;
            this.countLabel1.Text = "3";
            this.countLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countLabel1.Visible = false;
            // 
            // ArcadeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.countLabel1);
            this.Controls.Add(this.playButton1);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArcadeGame";
            this.Text = "Arcade Game";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button playButton1;
        private System.Windows.Forms.Label countLabel1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

