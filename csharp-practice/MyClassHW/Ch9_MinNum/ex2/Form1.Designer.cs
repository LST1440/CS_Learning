namespace ex2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.input4 = new System.Windows.Forms.TextBox();
            this.input5 = new System.Windows.Forms.TextBox();
            this.input6 = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F);
            this.label1.Location = new System.Drawing.Point(69, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入6個整數";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(74, 120);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 25);
            this.input1.TabIndex = 1;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(180, 120);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 25);
            this.input2.TabIndex = 2;
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(286, 120);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(100, 25);
            this.input3.TabIndex = 3;
            // 
            // input4
            // 
            this.input4.Location = new System.Drawing.Point(392, 120);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(100, 25);
            this.input4.TabIndex = 4;
            // 
            // input5
            // 
            this.input5.Location = new System.Drawing.Point(498, 120);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(100, 25);
            this.input5.TabIndex = 5;
            // 
            // input6
            // 
            this.input6.Location = new System.Drawing.Point(604, 120);
            this.input6.Name = "input6";
            this.input6.Size = new System.Drawing.Size(100, 25);
            this.input6.TabIndex = 6;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ControlLight;
            this.output.Font = new System.Drawing.Font("新細明體", 17F);
            this.output.Location = new System.Drawing.Point(309, 177);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(395, 41);
            this.output.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.CausesValidation = false;
            this.button1.Font = new System.Drawing.Font("新細明體", 17F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(74, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "呼叫arrMain()";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 294);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input6);
            this.Controls.Add(this.input5);
            this.Controls.Add(this.input4);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ex2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.TextBox input4;
        private System.Windows.Forms.TextBox input5;
        private System.Windows.Forms.TextBox input6;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button button1;
    }
}

