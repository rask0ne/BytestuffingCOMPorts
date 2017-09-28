namespace RS232_Communicator
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
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.recvTextA = new System.Windows.Forms.TextBox();
            this.portButtonA = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comBoxA = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.baudBoxA = new System.Windows.Forms.ComboBox();
            this.msgBoxA = new System.Windows.Forms.TextBox();
            this.sendButtonA = new System.Windows.Forms.Button();
            this.groupBoxB = new System.Windows.Forms.GroupBox();
            this.recvTextB = new System.Windows.Forms.TextBox();
            this.portButtonB = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comBoxB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.baudBoxB = new System.Windows.Forms.ComboBox();
            this.msgBoxB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.sendButtonB = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBoxA.SuspendLayout();
            this.groupBoxB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate:";
            // 
            // groupBoxA
            // 
            this.groupBoxA.Controls.Add(this.portButtonA);
            this.groupBoxA.Controls.Add(this.recvTextA);
            this.groupBoxA.Controls.Add(this.label4);
            this.groupBoxA.Controls.Add(this.comBoxA);
            this.groupBoxA.Controls.Add(this.label3);
            this.groupBoxA.Controls.Add(this.baudBoxA);
            this.groupBoxA.Controls.Add(this.msgBoxA);
            this.groupBoxA.Controls.Add(this.label2);
            this.groupBoxA.Controls.Add(this.sendButtonA);
            this.groupBoxA.Controls.Add(this.label1);
            this.groupBoxA.Location = new System.Drawing.Point(16, 15);
            this.groupBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxA.Size = new System.Drawing.Size(480, 141);
            this.groupBoxA.TabIndex = 2;
            this.groupBoxA.TabStop = false;
            this.groupBoxA.Text = "Port A";
            // 
            // recvTextA
            // 
            this.recvTextA.Location = new System.Drawing.Point(87, 110);
            this.recvTextA.Margin = new System.Windows.Forms.Padding(4);
            this.recvTextA.Name = "recvTextA";
            this.recvTextA.Size = new System.Drawing.Size(248, 22);
            this.recvTextA.TabIndex = 14;
            // 
            // portButtonA
            // 
            this.portButtonA.Location = new System.Drawing.Point(351, 14);
            this.portButtonA.Margin = new System.Windows.Forms.Padding(4);
            this.portButtonA.Name = "portButtonA";
            this.portButtonA.Size = new System.Drawing.Size(121, 28);
            this.portButtonA.TabIndex = 13;
            this.portButtonA.Text = "Connect";
            this.portButtonA.UseVisualStyleBackColor = true;
            this.portButtonA.Click += new System.EventHandler(this.connectButtonA_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Received:";
            // 
            // comBoxA
            // 
            this.comBoxA.FormattingEnabled = true;
            this.comBoxA.Location = new System.Drawing.Point(87, 16);
            this.comBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxA.Name = "comBoxA";
            this.comBoxA.Size = new System.Drawing.Size(160, 24);
            this.comBoxA.Sorted = true;
            this.comBoxA.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Com Port:";
            // 
            // baudBoxA
            // 
            this.baudBoxA.FormattingEnabled = true;
            this.baudBoxA.Location = new System.Drawing.Point(87, 49);
            this.baudBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.baudBoxA.Name = "baudBoxA";
            this.baudBoxA.Size = new System.Drawing.Size(160, 24);
            this.baudBoxA.TabIndex = 4;
            // 
            // msgBoxA
            // 
            this.msgBoxA.Location = new System.Drawing.Point(87, 81);
            this.msgBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.msgBoxA.Name = "msgBoxA";
            this.msgBoxA.Size = new System.Drawing.Size(248, 22);
            this.msgBoxA.TabIndex = 3;
            // 
            // sendButtonA
            // 
            this.sendButtonA.Location = new System.Drawing.Point(351, 78);
            this.sendButtonA.Margin = new System.Windows.Forms.Padding(4);
            this.sendButtonA.Name = "sendButtonA";
            this.sendButtonA.Size = new System.Drawing.Size(121, 28);
            this.sendButtonA.TabIndex = 2;
            this.sendButtonA.Text = "Send Message";
            this.sendButtonA.UseVisualStyleBackColor = true;
            this.sendButtonA.Click += new System.EventHandler(this.sendButtonA_Click);
            // 
            // groupBoxB
            // 
            this.groupBoxB.Controls.Add(this.portButtonB);
            this.groupBoxB.Controls.Add(this.recvTextB);
            this.groupBoxB.Controls.Add(this.label10);
            this.groupBoxB.Controls.Add(this.comBoxB);
            this.groupBoxB.Controls.Add(this.label11);
            this.groupBoxB.Controls.Add(this.baudBoxB);
            this.groupBoxB.Controls.Add(this.msgBoxB);
            this.groupBoxB.Controls.Add(this.label12);
            this.groupBoxB.Controls.Add(this.sendButtonB);
            this.groupBoxB.Controls.Add(this.label13);
            this.groupBoxB.Location = new System.Drawing.Point(16, 164);
            this.groupBoxB.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxB.Name = "groupBoxB";
            this.groupBoxB.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxB.Size = new System.Drawing.Size(480, 146);
            this.groupBoxB.TabIndex = 3;
            this.groupBoxB.TabStop = false;
            this.groupBoxB.Text = "Port B";
            // 
            // recvTextB
            // 
            this.recvTextB.Location = new System.Drawing.Point(85, 115);
            this.recvTextB.Margin = new System.Windows.Forms.Padding(4);
            this.recvTextB.Name = "recvTextB";
            this.recvTextB.Size = new System.Drawing.Size(248, 22);
            this.recvTextB.TabIndex = 13;
            // 
            // portButtonB
            // 
            this.portButtonB.Location = new System.Drawing.Point(351, 14);
            this.portButtonB.Margin = new System.Windows.Forms.Padding(4);
            this.portButtonB.Name = "portButtonB";
            this.portButtonB.Size = new System.Drawing.Size(124, 28);
            this.portButtonB.TabIndex = 12;
            this.portButtonB.Text = "Connect";
            this.portButtonB.UseVisualStyleBackColor = true;
            this.portButtonB.Click += new System.EventHandler(this.connectButtonB_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Received:";
            // 
            // comBoxB
            // 
            this.comBoxB.FormattingEnabled = true;
            this.comBoxB.Location = new System.Drawing.Point(87, 16);
            this.comBoxB.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxB.Name = "comBoxB";
            this.comBoxB.Size = new System.Drawing.Size(160, 24);
            this.comBoxB.Sorted = true;
            this.comBoxB.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Com Port:";
            // 
            // baudBoxB
            // 
            this.baudBoxB.FormattingEnabled = true;
            this.baudBoxB.Location = new System.Drawing.Point(87, 49);
            this.baudBoxB.Margin = new System.Windows.Forms.Padding(4);
            this.baudBoxB.Name = "baudBoxB";
            this.baudBoxB.Size = new System.Drawing.Size(160, 24);
            this.baudBoxB.TabIndex = 4;
            // 
            // msgBoxB
            // 
            this.msgBoxB.Location = new System.Drawing.Point(85, 81);
            this.msgBoxB.Margin = new System.Windows.Forms.Padding(4);
            this.msgBoxB.Name = "msgBoxB";
            this.msgBoxB.Size = new System.Drawing.Size(248, 22);
            this.msgBoxB.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 53);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Baud Rate:";
            // 
            // sendButtonB
            // 
            this.sendButtonB.Location = new System.Drawing.Point(351, 78);
            this.sendButtonB.Margin = new System.Windows.Forms.Padding(4);
            this.sendButtonB.Name = "sendButtonB";
            this.sendButtonB.Size = new System.Drawing.Size(121, 28);
            this.sendButtonB.TabIndex = 2;
            this.sendButtonB.Text = "Send Message";
            this.sendButtonB.UseVisualStyleBackColor = true;
            this.sendButtonB.Click += new System.EventHandler(this.sendButtonB_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Message:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 328);
            this.Controls.Add(this.groupBoxB);
            this.Controls.Add(this.groupBoxA);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Com Port Communicator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxA.ResumeLayout(false);
            this.groupBoxA.PerformLayout();
            this.groupBoxB.ResumeLayout(false);
            this.groupBoxB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxA;
        private System.Windows.Forms.TextBox msgBoxA;
        private System.Windows.Forms.Button sendButtonA;
        private System.Windows.Forms.ComboBox baudBoxA;
              private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comBoxA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxB;
        private System.Windows.Forms.Button portButtonB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comBoxB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox baudBoxB;
        private System.Windows.Forms.TextBox msgBoxB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button sendButtonB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button portButtonA;
        private System.Windows.Forms.TextBox recvTextA;
        private System.Windows.Forms.TextBox recvTextB;
    }
}

