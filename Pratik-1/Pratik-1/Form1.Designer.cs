namespace Pratik_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.visa_textbox = new System.Windows.Forms.TextBox();
            this.final_textbox = new System.Windows.Forms.TextBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grade_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // visa_textbox
            // 
            resources.ApplyResources(this.visa_textbox, "visa_textbox");
            this.visa_textbox.Name = "visa_textbox";
            // 
            // final_textbox
            // 
            resources.ApplyResources(this.final_textbox, "final_textbox");
            this.final_textbox.Name = "final_textbox";
            // 
            // calculate_button
            // 
            resources.ApplyResources(this.calculate_button, "calculate_button");
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // grade_label
            // 
            resources.ApplyResources(this.grade_label, "grade_label");
            this.grade_label.Name = "grade_label";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.Controls.Add(this.grade_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.final_textbox);
            this.Controls.Add(this.visa_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox visa_textbox;
        private System.Windows.Forms.TextBox final_textbox;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label grade_label;
    }
}

