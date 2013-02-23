namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.rtxtMsg = new System.Windows.Forms.RichTextBox();
            this.btreceber = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.btConectar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotSMS = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enviar SMS(Problemas)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mensagem";
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(30, 26);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(100, 20);
            this.txtFone.TabIndex = 3;
            // 
            // rtxtMsg
            // 
            this.rtxtMsg.Location = new System.Drawing.Point(30, 190);
            this.rtxtMsg.Name = "rtxtMsg";
            this.rtxtMsg.Size = new System.Drawing.Size(218, 116);
            this.rtxtMsg.TabIndex = 4;
            this.rtxtMsg.Text = "";
            // 
            // btreceber
            // 
            this.btreceber.Location = new System.Drawing.Point(486, 37);
            this.btreceber.Name = "btreceber";
            this.btreceber.Size = new System.Drawing.Size(98, 23);
            this.btreceber.TabIndex = 5;
            this.btreceber.Text = "Receber SMS";
            this.btreceber.UseVisualStyleBackColor = true;
            this.btreceber.Click += new System.EventHandler(this.btreceber_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Enviar SMS 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Porta";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(33, 70);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(100, 20);
            this.txtPorta.TabIndex = 8;
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(382, 8);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(98, 23);
            this.btConectar.TabIndex = 9;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(486, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Desconectar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(30, 147);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(35, 13);
            this.status.TabIndex = 11;
            this.status.Text = "label4";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(486, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Receber DadosSMS 2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(324, 117);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(281, 189);
            this.resultado.TabIndex = 13;
            this.resultado.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total SMS";
            // 
            // txtTotSMS
            // 
            this.txtTotSMS.Location = new System.Drawing.Point(33, 117);
            this.txtTotSMS.Name = "txtTotSMS";
            this.txtTotSMS.Size = new System.Drawing.Size(100, 20);
            this.txtTotSMS.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(139, 114);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Total SMS";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(174, 53);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "Deletar Todas";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(278, 53);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 23);
            this.button7.TabIndex = 18;
            this.button7.Text = "Deletar Lidos";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 318);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtTotSMS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.status);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btreceber);
            this.Controls.Add(this.rtxtMsg);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.RichTextBox rtxtMsg;
        private System.Windows.Forms.Button btreceber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox resultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotSMS;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

