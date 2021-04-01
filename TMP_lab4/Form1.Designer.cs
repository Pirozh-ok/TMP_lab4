
namespace TMP_lab4
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
            this.label4 = new System.Windows.Forms.Label();
            this.tIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bSendServer = new System.Windows.Forms.Button();
            this.tChoiseUser = new System.Windows.Forms.TextBox();
            this.bChoiseObject = new System.Windows.Forms.Button();
            this.tGetClient = new System.Windows.Forms.TextBox();
            this.bConnect1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ответ от сервера";
            // 
            // tIP
            // 
            this.tIP.Location = new System.Drawing.Point(107, 357);
            this.tIP.Name = "tIP";
            this.tIP.Size = new System.Drawing.Size(161, 22);
            this.tIP.TabIndex = 7;
            this.tIP.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "IP - адресс";
            // 
            // bSendServer
            // 
            this.bSendServer.Location = new System.Drawing.Point(150, 403);
            this.bSendServer.Name = "bSendServer";
            this.bSendServer.Size = new System.Drawing.Size(118, 50);
            this.bSendServer.TabIndex = 15;
            this.bSendServer.Text = "Передать серверу";
            this.bSendServer.UseVisualStyleBackColor = true;
            this.bSendServer.Click += new System.EventHandler(this.bSendServer_Click);
            // 
            // tChoiseUser
            // 
            this.tChoiseUser.Location = new System.Drawing.Point(12, 121);
            this.tChoiseUser.Multiline = true;
            this.tChoiseUser.Name = "tChoiseUser";
            this.tChoiseUser.Size = new System.Drawing.Size(290, 205);
            this.tChoiseUser.TabIndex = 16;
            // 
            // bChoiseObject
            // 
            this.bChoiseObject.Location = new System.Drawing.Point(77, 43);
            this.bChoiseObject.Name = "bChoiseObject";
            this.bChoiseObject.Size = new System.Drawing.Size(153, 52);
            this.bChoiseObject.TabIndex = 17;
            this.bChoiseObject.Text = "Выбор каталога/файла для передачи";
            this.bChoiseObject.UseVisualStyleBackColor = true;
            this.bChoiseObject.Click += new System.EventHandler(this.bChoiseObject_Click);
            // 
            // tGetClient
            // 
            this.tGetClient.Location = new System.Drawing.Point(357, 43);
            this.tGetClient.Multiline = true;
            this.tGetClient.Name = "tGetClient";
            this.tGetClient.Size = new System.Drawing.Size(296, 434);
            this.tGetClient.TabIndex = 18;
            // 
            // bConnect1
            // 
            this.bConnect1.Location = new System.Drawing.Point(12, 409);
            this.bConnect1.Name = "bConnect1";
            this.bConnect1.Size = new System.Drawing.Size(118, 44);
            this.bConnect1.TabIndex = 13;
            this.bConnect1.Text = "Соединиться";
            this.bConnect1.UseVisualStyleBackColor = true;
            this.bConnect1.Click += new System.EventHandler(this.bConnect1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 505);
            this.Controls.Add(this.tGetClient);
            this.Controls.Add(this.bChoiseObject);
            this.Controls.Add(this.tChoiseUser);
            this.Controls.Add(this.bSendServer);
            this.Controls.Add(this.bConnect1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tIP);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSendServer;
        private System.Windows.Forms.TextBox tChoiseUser;
        private System.Windows.Forms.Button bChoiseObject;
        private System.Windows.Forms.TextBox tGetClient;
        private System.Windows.Forms.Button bConnect1;
    }
}

