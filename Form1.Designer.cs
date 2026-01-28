namespace excuseMaker
{
    partial class excuseMaker
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
            this.sentence1 = new System.Windows.Forms.Label();
            this.sentence2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sentence1
            // 
            this.sentence1.AutoSize = true;
            this.sentence1.Font = new System.Drawing.Font("Sans Serif Collection", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentence1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(43)))), ((int)(((byte)(37)))));
            this.sentence1.Location = new System.Drawing.Point(18, 121);
            this.sentence1.Name = "sentence1";
            this.sentence1.Size = new System.Drawing.Size(158, 85);
            this.sentence1.TabIndex = 0;
            this.sentence1.Text = "Opening...";
            this.sentence1.Click += new System.EventHandler(this.sentence1_Click);
            // 
            // sentence2
            // 
            this.sentence2.AutoSize = true;
            this.sentence2.Font = new System.Drawing.Font("Sans Serif Collection", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentence2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(43)))), ((int)(((byte)(37)))));
            this.sentence2.Location = new System.Drawing.Point(18, 192);
            this.sentence2.Name = "sentence2";
            this.sentence2.Size = new System.Drawing.Size(143, 85);
            this.sentence2.TabIndex = 1;
            this.sentence2.Text = "Closing...";
            this.sentence2.Click += new System.EventHandler(this.sentence2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(255)))), ((int)(((byte)(172)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(73)))), ((int)(((byte)(65)))));
            this.button1.Location = new System.Drawing.Point(33, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "PRESS TO RANDOMIZE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(255)))), ((int)(((byte)(172)))));
            this.copyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(73)))), ((int)(((byte)(65)))));
            this.copyButton.Location = new System.Drawing.Point(529, 322);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(128, 68);
            this.copyButton.TabIndex = 3;
            this.copyButton.Text = "Copy The Sentence";
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(43)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(779, 68);
            this.label1.TabIndex = 4;
            this.label1.Text = "You\'re too lazy to make excuses for being late...OH BOY I GOT THE THING FOR YOU!!" +
    "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(43)))), ((int)(((byte)(37)))));
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 68);
            this.label2.TabIndex = 5;
            this.label2.Text = "Just press the button and you shall get an excuse";
            // 
            // excuseMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(220)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(927, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sentence2);
            this.Controls.Add(this.sentence1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "excuseMaker";
            this.Text = "EXCUSE MAKER 9000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sentence1;
        private System.Windows.Forms.Label sentence2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

