namespace SecondHand
{
    partial class SecondHandForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.ViewTextBox = new System.Windows.Forms.TextBox();
            this.IntervalTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ViewTextBox
            // 
            this.ViewTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewTextBox.Location = new System.Drawing.Point(0, 0);
            this.ViewTextBox.Name = "ViewTextBox";
            this.ViewTextBox.ReadOnly = true;
            this.ViewTextBox.Size = new System.Drawing.Size(131, 19);
            this.ViewTextBox.TabIndex = 0;
            this.ViewTextBox.Text = "2019-09-15 日 15:32:40";
            // 
            // IntervalTimer
            // 
            this.IntervalTimer.Enabled = true;
            this.IntervalTimer.Tick += new System.EventHandler(this.IntervalTimer_Tick);
            // 
            // SecondHandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(131, 20);
            this.Controls.Add(this.ViewTextBox);
            this.Name = "SecondHandForm";
            this.Text = "SecondHand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ViewTextBox;
        private System.Windows.Forms.Timer IntervalTimer;
    }
}

