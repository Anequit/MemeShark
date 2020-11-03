namespace MemeShark
{
    partial class MemeSharkUi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.BrowserSelector = new System.Windows.Forms.ComboBox();
            this.Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.StartBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.StopBtn, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 101);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(315, 125);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // StartBtn
            // 
            this.StartBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartBtn.Location = new System.Drawing.Point(3, 3);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(151, 119);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StopBtn.Location = new System.Drawing.Point(160, 3);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(152, 119);
            this.StopBtn.TabIndex = 1;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // BrowserSelector
            // 
            this.BrowserSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrowserSelector.FormattingEnabled = true;
            this.BrowserSelector.Items.AddRange(new object[] {
            "Google Chrome",
            "Firefox",
            "Edge",
            "Internet Explorer",
            "Opera",
            "Safari"});
            this.BrowserSelector.Location = new System.Drawing.Point(12, 50);
            this.BrowserSelector.Name = "BrowserSelector";
            this.BrowserSelector.Size = new System.Drawing.Size(291, 28);
            this.BrowserSelector.TabIndex = 1;
            this.BrowserSelector.SelectionChangeCommitted += new System.EventHandler(this.BrowserSelector_SelectionChangeCommitted);
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label.Location = new System.Drawing.Point(12, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(291, 28);
            this.Label.TabIndex = 2;
            this.Label.Text = "Browser";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemeSharkUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(315, 226);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.BrowserSelector);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "MemeSharkUi";
            this.Text = "MemeShark";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.ComboBox BrowserSelector;
        private System.Windows.Forms.Label Label;
    }
}

