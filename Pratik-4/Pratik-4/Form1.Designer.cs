namespace Pratik_4
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
            this.processor_combobox = new System.Windows.Forms.ComboBox();
            this.ram_combobox = new System.Windows.Forms.ComboBox();
            this.graphicCard_combobox = new System.Windows.Forms.ComboBox();
            this.price_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Processor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ram :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Graphic Card :";
            // 
            // processor_combobox
            // 
            this.processor_combobox.FormattingEnabled = true;
            this.processor_combobox.Items.AddRange(new object[] {
            "i5",
            "Ryzen 3",
            "i9"});
            this.processor_combobox.Location = new System.Drawing.Point(162, 24);
            this.processor_combobox.Name = "processor_combobox";
            this.processor_combobox.Size = new System.Drawing.Size(205, 24);
            this.processor_combobox.TabIndex = 0;
            this.processor_combobox.SelectedIndexChanged += new System.EventHandler(this.processor_combobox_SelectedIndexChanged);
            // 
            // ram_combobox
            // 
            this.ram_combobox.FormattingEnabled = true;
            this.ram_combobox.Items.AddRange(new object[] {
            "8 GB",
            "16 GB"});
            this.ram_combobox.Location = new System.Drawing.Point(162, 66);
            this.ram_combobox.Name = "ram_combobox";
            this.ram_combobox.Size = new System.Drawing.Size(205, 24);
            this.ram_combobox.TabIndex = 1;
            this.ram_combobox.SelectedIndexChanged += new System.EventHandler(this.ram_combobox_SelectedIndexChanged);
            // 
            // graphicCard_combobox
            // 
            this.graphicCard_combobox.FormattingEnabled = true;
            this.graphicCard_combobox.Items.AddRange(new object[] {
            "RTX 3060 Ti",
            "RTX 3070",
            "RTX 3090"});
            this.graphicCard_combobox.Location = new System.Drawing.Point(162, 109);
            this.graphicCard_combobox.Name = "graphicCard_combobox";
            this.graphicCard_combobox.Size = new System.Drawing.Size(205, 24);
            this.graphicCard_combobox.TabIndex = 2;
            this.graphicCard_combobox.SelectedIndexChanged += new System.EventHandler(this.graphicCard_combobox_SelectedIndexChanged);
            // 
            // price_button
            // 
            this.price_button.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.price_button.Location = new System.Drawing.Point(30, 155);
            this.price_button.Name = "price_button";
            this.price_button.Size = new System.Drawing.Size(337, 45);
            this.price_button.TabIndex = 3;
            this.price_button.Text = "Calculate the price";
            this.price_button.UseVisualStyleBackColor = true;
            this.price_button.Click += new System.EventHandler(this.price_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Price :";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.price_label.Location = new System.Drawing.Point(147, 227);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(84, 27);
            this.price_label.TabIndex = 4;
            this.price_label.Text = "0 Dollars";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(401, 279);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price_button);
            this.Controls.Add(this.graphicCard_combobox);
            this.Controls.Add(this.ram_combobox);
            this.Controls.Add(this.processor_combobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox processor_combobox;
        private System.Windows.Forms.ComboBox ram_combobox;
        private System.Windows.Forms.ComboBox graphicCard_combobox;
        private System.Windows.Forms.Button price_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label price_label;
    }
}

