namespace Pratik_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.surname_textbox = new System.Windows.Forms.TextBox();
            this.phonenumber_maskedbox = new System.Windows.Forms.MaskedTextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.values_listbox = new System.Windows.Forms.ListBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(233, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(233, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(233, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone Number :";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(386, 28);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(136, 22);
            this.name_textbox.TabIndex = 0;
            // 
            // surname_textbox
            // 
            this.surname_textbox.Location = new System.Drawing.Point(386, 68);
            this.surname_textbox.Name = "surname_textbox";
            this.surname_textbox.Size = new System.Drawing.Size(136, 22);
            this.surname_textbox.TabIndex = 1;
            // 
            // phonenumber_maskedbox
            // 
            this.phonenumber_maskedbox.Location = new System.Drawing.Point(386, 109);
            this.phonenumber_maskedbox.Mask = "(999) 000-0000";
            this.phonenumber_maskedbox.Name = "phonenumber_maskedbox";
            this.phonenumber_maskedbox.Size = new System.Drawing.Size(136, 22);
            this.phonenumber_maskedbox.TabIndex = 2;
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(238, 148);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(141, 41);
            this.add_button.TabIndex = 3;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // values_listbox
            // 
            this.values_listbox.FormattingEnabled = true;
            this.values_listbox.ItemHeight = 16;
            this.values_listbox.Location = new System.Drawing.Point(30, 199);
            this.values_listbox.Name = "values_listbox";
            this.values_listbox.Size = new System.Drawing.Size(713, 228);
            this.values_listbox.TabIndex = 4;
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clear_button.Location = new System.Drawing.Point(386, 148);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(136, 41);
            this.clear_button.TabIndex = 4;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(778, 439);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.values_listbox);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.phonenumber_maskedbox);
            this.Controls.Add(this.surname_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Registration Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox surname_textbox;
        private System.Windows.Forms.MaskedTextBox phonenumber_maskedbox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ListBox values_listbox;
        private System.Windows.Forms.Button clear_button;
    }
}

