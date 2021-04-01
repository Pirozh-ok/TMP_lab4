
namespace TCP_Server
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bStartServer = new System.Windows.Forms.Button();
            this.tSendServer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tGetServer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tIP
            // 
            this.tIP.Location = new System.Drawing.Point(80, 39);
            this.tIP.Name = "tIP";
            this.tIP.Size = new System.Drawing.Size(202, 22);
            this.tIP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Полученно сервером";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отправленно сервером";
            // 
            // bStartServer
            // 
            this.bStartServer.Location = new System.Drawing.Point(80, 527);
            this.bStartServer.Name = "bStartServer";
            this.bStartServer.Size = new System.Drawing.Size(157, 39);
            this.bStartServer.TabIndex = 6;
            this.bStartServer.Text = "Запустить сервер";
            this.bStartServer.UseVisualStyleBackColor = true;
            this.bStartServer.Click += new System.EventHandler(this.bStartServer_Click);
            // 
            // tSendServer
            // 
            this.tSendServer.Location = new System.Drawing.Point(326, 110);
            this.tSendServer.Multiline = true;
            this.tSendServer.Name = "tSendServer";
            this.tSendServer.Size = new System.Drawing.Size(293, 399);
            this.tSendServer.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Остановить сервер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tGetServer
            // 
            this.tGetServer.Location = new System.Drawing.Point(38, 110);
            this.tGetServer.Multiline = true;
            this.tGetServer.Name = "tGetServer";
            this.tGetServer.Size = new System.Drawing.Size(252, 399);
            this.tGetServer.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 578);
            this.Controls.Add(this.tGetServer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tSendServer);
            this.Controls.Add(this.bStartServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tIP);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bStartServer;
        private System.Windows.Forms.TextBox tSendServer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tGetServer;
    }
}

