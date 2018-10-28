namespace EmojiMakerGUI
{
    partial class Form1
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
            this.regional = new System.Windows.Forms.Button();
            this.originalText = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.claps = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.custom = new System.Windows.Forms.CheckBox();
            this.customtext = new System.Windows.Forms.TextBox();
            this.customEmoji = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regional
            // 
            this.regional.Location = new System.Drawing.Point(90, 114);
            this.regional.Name = "regional";
            this.regional.Size = new System.Drawing.Size(154, 55);
            this.regional.TabIndex = 0;
            this.regional.Text = "Convert To Regional Indicator";
            this.regional.UseVisualStyleBackColor = true;
            this.regional.Click += new System.EventHandler(this.button1_Click);
            // 
            // originalText
            // 
            this.originalText.Location = new System.Drawing.Point(90, 57);
            this.originalText.Name = "originalText";
            this.originalText.Size = new System.Drawing.Size(501, 20);
            this.originalText.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AccessibleName = "output";
            this.richTextBox1.Location = new System.Drawing.Point(90, 219);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(501, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // claps
            // 
            this.claps.Location = new System.Drawing.Point(437, 114);
            this.claps.Name = "claps";
            this.claps.Size = new System.Drawing.Size(154, 55);
            this.claps.TabIndex = 3;
            this.claps.Text = "Add claps in between";
            this.claps.UseVisualStyleBackColor = true;
            this.claps.Click += new System.EventHandler(this.claps_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(299, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 47);
            this.button3.TabIndex = 6;
            this.button3.Text = "Copy Output";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // custom
            // 
            this.custom.AutoSize = true;
            this.custom.Location = new System.Drawing.Point(267, 106);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(143, 17);
            this.custom.TabIndex = 7;
            this.custom.Text = "Custom in between emoji";
            this.custom.UseVisualStyleBackColor = true;
            this.custom.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // customtext
            // 
            this.customtext.Location = new System.Drawing.Point(267, 142);
            this.customtext.Name = "customtext";
            this.customtext.Size = new System.Drawing.Size(143, 20);
            this.customtext.TabIndex = 8;
            this.customtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customtext.Visible = false;
            // 
            // customEmoji
            // 
            this.customEmoji.Location = new System.Drawing.Point(267, 176);
            this.customEmoji.Name = "customEmoji";
            this.customEmoji.Size = new System.Drawing.Size(143, 23);
            this.customEmoji.TabIndex = 9;
            this.customEmoji.Text = "Add custom in between";
            this.customEmoji.UseVisualStyleBackColor = true;
            this.customEmoji.Visible = false;
            this.customEmoji.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = ":";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = ":";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 378);
            this.Controls.Add(this.claps);
            this.Controls.Add(this.customtext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customEmoji);
            this.Controls.Add(this.custom);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.originalText);
            this.Controls.Add(this.regional);
            this.Name = "Form1";
            this.Text = "Discord Emoji Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regional;
        private System.Windows.Forms.TextBox originalText;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button claps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox custom;
        private System.Windows.Forms.TextBox customtext;
        private System.Windows.Forms.Button customEmoji;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

