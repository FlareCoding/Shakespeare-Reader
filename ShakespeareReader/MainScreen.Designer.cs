namespace ShakespeareReader
{
    partial class MainScreen
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
            this.ReadBtn = new System.Windows.Forms.Button();
            this.InputTextfield = new System.Windows.Forms.TextBox();
            this.ScriptBoxLbl = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.OutputField = new System.Windows.Forms.TextBox();
            this.TimeScaleSlider = new System.Windows.Forms.TrackBar();
            this.TimeScaleLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TimeScaleSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(235, 246);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(178, 41);
            this.ReadBtn.TabIndex = 0;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // InputTextfield
            // 
            this.InputTextfield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InputTextfield.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextfield.ForeColor = System.Drawing.SystemColors.InfoText;
            this.InputTextfield.Location = new System.Drawing.Point(825, 293);
            this.InputTextfield.MaxLength = 65534;
            this.InputTextfield.Multiline = true;
            this.InputTextfield.Name = "InputTextfield";
            this.InputTextfield.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InputTextfield.Size = new System.Drawing.Size(308, 559);
            this.InputTextfield.TabIndex = 1;
            // 
            // ScriptBoxLbl
            // 
            this.ScriptBoxLbl.AutoSize = true;
            this.ScriptBoxLbl.Font = new System.Drawing.Font("Sitka Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptBoxLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScriptBoxLbl.Location = new System.Drawing.Point(894, 246);
            this.ScriptBoxLbl.Name = "ScriptBoxLbl";
            this.ScriptBoxLbl.Size = new System.Drawing.Size(184, 28);
            this.ScriptBoxLbl.TabIndex = 2;
            this.ScriptBoxLbl.Text = "Paste Script Below";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(34, 246);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(178, 41);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(439, 246);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(178, 41);
            this.StopBtn.TabIndex = 4;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            // 
            // OutputField
            // 
            this.OutputField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OutputField.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.OutputField.ForeColor = System.Drawing.SystemColors.Menu;
            this.OutputField.Location = new System.Drawing.Point(34, 316);
            this.OutputField.MaxLength = 65534;
            this.OutputField.Multiline = true;
            this.OutputField.Name = "OutputField";
            this.OutputField.ReadOnly = true;
            this.OutputField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputField.Size = new System.Drawing.Size(772, 536);
            this.OutputField.TabIndex = 5;
            // 
            // TimeScaleSlider
            // 
            this.TimeScaleSlider.LargeChange = 50;
            this.TimeScaleSlider.Location = new System.Drawing.Point(34, 162);
            this.TimeScaleSlider.Maximum = 300;
            this.TimeScaleSlider.Name = "TimeScaleSlider";
            this.TimeScaleSlider.Size = new System.Drawing.Size(379, 45);
            this.TimeScaleSlider.SmallChange = 10;
            this.TimeScaleSlider.TabIndex = 6;
            this.TimeScaleSlider.Value = 100;
            this.TimeScaleSlider.ValueChanged += new System.EventHandler(this.TimeScaleSlider_ValueChanged);
            // 
            // TimeScaleLbl
            // 
            this.TimeScaleLbl.AutoSize = true;
            this.TimeScaleLbl.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold);
            this.TimeScaleLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.TimeScaleLbl.Location = new System.Drawing.Point(177, 131);
            this.TimeScaleLbl.Name = "TimeScaleLbl";
            this.TimeScaleLbl.Size = new System.Drawing.Size(113, 28);
            this.TimeScaleLbl.TabIndex = 7;
            this.TimeScaleLbl.Text = "Speed Rate: 1";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1145, 864);
            this.Controls.Add(this.TimeScaleLbl);
            this.Controls.Add(this.TimeScaleSlider);
            this.Controls.Add(this.OutputField);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ScriptBoxLbl);
            this.Controls.Add(this.InputTextfield);
            this.Controls.Add(this.ReadBtn);
            this.Name = "MainScreen";
            this.Text = "Shakespeare Reader";
            ((System.ComponentModel.ISupportInitialize)(this.TimeScaleSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.TextBox InputTextfield;
        private System.Windows.Forms.Label ScriptBoxLbl;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.TextBox OutputField;
        private System.Windows.Forms.TrackBar TimeScaleSlider;
        private System.Windows.Forms.Label TimeScaleLbl;
    }
}

