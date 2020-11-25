namespace EasyCalculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.copyResult = new MonoFlat.MonoFlat_Button();
            this.expressionIncorrect = new MonoFlat.MonoFlat_Label();
            this.latestCalculation = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Separator1 = new MonoFlat.MonoFlat_Separator();
            this.calculationResult = new MonoFlat.MonoFlat_Label();
            this.calculationInput = new MonoFlat.MonoFlat_TextBox();
            this.exitButton = new MonoFlat.MonoFlat_Button();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.copyResult);
            this.monoFlat_ThemeContainer1.Controls.Add(this.expressionIncorrect);
            this.monoFlat_ThemeContainer1.Controls.Add(this.latestCalculation);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Separator1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.calculationResult);
            this.monoFlat_ThemeContainer1.Controls.Add(this.calculationInput);
            this.monoFlat_ThemeContainer1.Controls.Add(this.exitButton);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(477, 234);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.monoFlat_ThemeContainer1.TabIndex = 2;
            this.monoFlat_ThemeContainer1.Text = "EasyCalculator";
            // 
            // copyResult
            // 
            this.copyResult.BackColor = System.Drawing.Color.Transparent;
            this.copyResult.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.copyResult.Image = null;
            this.copyResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyResult.Location = new System.Drawing.Point(295, 206);
            this.copyResult.Name = "copyResult";
            this.copyResult.Size = new System.Drawing.Size(95, 21);
            this.copyResult.TabIndex = 13;
            this.copyResult.Text = "Copy Result";
            this.copyResult.TextAlignment = System.Drawing.StringAlignment.Center;
            this.copyResult.Click += new System.EventHandler(this.copyResult_Click);
            // 
            // expressionIncorrect
            // 
            this.expressionIncorrect.AutoSize = true;
            this.expressionIncorrect.BackColor = System.Drawing.Color.Transparent;
            this.expressionIncorrect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expressionIncorrect.ForeColor = System.Drawing.Color.Red;
            this.expressionIncorrect.Location = new System.Drawing.Point(339, 165);
            this.expressionIncorrect.Name = "expressionIncorrect";
            this.expressionIncorrect.Size = new System.Drawing.Size(127, 15);
            this.expressionIncorrect.TabIndex = 12;
            this.expressionIncorrect.Text = "Expression is incorrect.";
            this.expressionIncorrect.Visible = false;
            // 
            // latestCalculation
            // 
            this.latestCalculation.AutoSize = true;
            this.latestCalculation.BackColor = System.Drawing.Color.Transparent;
            this.latestCalculation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.latestCalculation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.latestCalculation.Location = new System.Drawing.Point(18, 165);
            this.latestCalculation.Name = "latestCalculation";
            this.latestCalculation.Size = new System.Drawing.Size(134, 15);
            this.latestCalculation.TabIndex = 11;
            this.latestCalculation.Text = "Latest calculation: None";
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label1.Location = new System.Drawing.Point(18, 210);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(125, 15);
            this.monoFlat_Label1.TabIndex = 10;
            this.monoFlat_Label1.Text = "Made by Furkan Bilgin";
            // 
            // monoFlat_Separator1
            // 
            this.monoFlat_Separator1.Location = new System.Drawing.Point(13, 190);
            this.monoFlat_Separator1.Name = "monoFlat_Separator1";
            this.monoFlat_Separator1.Size = new System.Drawing.Size(453, 10);
            this.monoFlat_Separator1.TabIndex = 9;
            this.monoFlat_Separator1.Text = "monoFlat_Separator1";
            // 
            // calculationResult
            // 
            this.calculationResult.AutoSize = true;
            this.calculationResult.BackColor = System.Drawing.Color.Transparent;
            this.calculationResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculationResult.ForeColor = System.Drawing.Color.DarkGray;
            this.calculationResult.Location = new System.Drawing.Point(15, 70);
            this.calculationResult.Name = "calculationResult";
            this.calculationResult.Size = new System.Drawing.Size(268, 32);
            this.calculationResult.TabIndex = 8;
            this.calculationResult.Text = "Calculate something...";
            // 
            // calculationInput
            // 
            this.calculationInput.BackColor = System.Drawing.Color.Transparent;
            this.calculationInput.Font = new System.Drawing.Font("Tahoma", 11F);
            this.calculationInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.calculationInput.Image = null;
            this.calculationInput.Location = new System.Drawing.Point(13, 116);
            this.calculationInput.MaxLength = 32767;
            this.calculationInput.Multiline = false;
            this.calculationInput.Name = "calculationInput";
            this.calculationInput.ReadOnly = false;
            this.calculationInput.Size = new System.Drawing.Size(453, 41);
            this.calculationInput.TabIndex = 7;
            this.calculationInput.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.calculationInput.UseSystemPasswordChar = false;
            this.calculationInput.TextChanged += new System.EventHandler(this.calculationInput_TextChanged);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.exitButton.Image = null;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(396, 206);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(68, 21);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 234);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "EasyCalculator";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MonoFlat.MonoFlat_Label expressionIncorrect;
        private MonoFlat.MonoFlat_Label latestCalculation;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private MonoFlat.MonoFlat_Separator monoFlat_Separator1;
        private MonoFlat.MonoFlat_Label calculationResult;
        private MonoFlat.MonoFlat_TextBox calculationInput;
        private MonoFlat.MonoFlat_Button exitButton;
        private MonoFlat.MonoFlat_Button copyResult;
    }
}

