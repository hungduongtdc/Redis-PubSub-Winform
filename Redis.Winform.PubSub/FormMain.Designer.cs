namespace Redis.Winform.PubSub
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRedisConnectionString = new System.Windows.Forms.TextBox();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.btnSubcribe = new System.Windows.Forms.Button();
            this.btnPublish = new System.Windows.Forms.Button();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Channel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Redis Connection string";
            // 
            // txtRedisConnectionString
            // 
            this.txtRedisConnectionString.Location = new System.Drawing.Point(154, 13);
            this.txtRedisConnectionString.Name = "txtRedisConnectionString";
            this.txtRedisConnectionString.Size = new System.Drawing.Size(348, 23);
            this.txtRedisConnectionString.TabIndex = 2;
            this.txtRedisConnectionString.Text = "localhost:6379";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(154, 57);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(348, 23);
            this.txtChannel.TabIndex = 3;
            this.txtChannel.Text = "CHANNEL";
            // 
            // btnSubcribe
            // 
            this.btnSubcribe.Location = new System.Drawing.Point(529, 13);
            this.btnSubcribe.Name = "btnSubcribe";
            this.btnSubcribe.Size = new System.Drawing.Size(75, 23);
            this.btnSubcribe.TabIndex = 4;
            this.btnSubcribe.Text = "Subcribe";
            this.btnSubcribe.UseVisualStyleBackColor = true;
            this.btnSubcribe.Click += new System.EventHandler(this.btnSubcribe_Click);
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(506, 81);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(75, 23);
            this.btnPublish.TabIndex = 5;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            // 
            // txtMessages
            // 
            this.txtMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessages.Location = new System.Drawing.Point(0, 124);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(1283, 473);
            this.txtMessages.TabIndex = 6;
            this.txtMessages.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPublish);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtChannel);
            this.panel1.Controls.Add(this.btnSubcribe);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRedisConnectionString);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 124);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 597);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtRedisConnectionString;
        private TextBox txtChannel;
        private Button btnSubcribe;
        private Button btnPublish;
        private TextBox txtMessages;
        private Panel panel1;
    }
}