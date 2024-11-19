namespace printer_tester
{
    partial class Body
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Body));
            TestButton = new Button();
            CMD = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox1 = new TextBox();
            checkBox2 = new CheckBox();
            Title = new TextBox();
            textBox2 = new TextBox();
            IpInput = new TextBox();
            HowToUse = new Button();
            SuspendLayout();
            // 
            // TestButton
            // 
            TestButton.Location = new Point(12, 69);
            TestButton.Name = "TestButton";
            TestButton.Size = new Size(235, 36);
            TestButton.TabIndex = 0;
            TestButton.Text = "Testar Impressora";
            TestButton.UseVisualStyleBackColor = true;
            TestButton.Click += TestButton_Click;
            // 
            // CMD
            // 
            CMD.BackColor = SystemColors.InfoText;
            CMD.BorderStyle = BorderStyle.None;
            CMD.Cursor = Cursors.No;
            CMD.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CMD.ForeColor = Color.Lime;
            CMD.Location = new Point(12, 148);
            CMD.Multiline = true;
            CMD.Name = "CMD";
            CMD.ReadOnly = true;
            CMD.Size = new Size(535, 290);
            CMD.TabIndex = 3;
            CMD.Text = "Printer Tester [versão 0.1.1]\r\n(c) Davi Menezes. Todos os direitos reservados.\r\nTester:\r\n";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(253, 41);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 101);
            textBox1.TabIndex = 8;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 111);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(162, 19);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Impressão ao fim do teste";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            Title.BackColor = SystemColors.Control;
            Title.BorderStyle = BorderStyle.None;
            Title.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(253, 12);
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Size = new Size(294, 18);
            Title.TabIndex = 11;
            Title.Text = "Impressão de teste";
            Title.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(2, 17);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(245, 18);
            textBox2.TabIndex = 12;
            textBox2.Text = "Informe o Ip a ser Testado";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // IpInput
            // 
            IpInput.AcceptsTab = true;
            IpInput.Location = new Point(12, 40);
            IpInput.Name = "IpInput";
            IpInput.Size = new Size(235, 23);
            IpInput.TabIndex = 13;
            IpInput.TextChanged += IpInput_TextChanged;
            // 
            // HowToUse
            // 
            HowToUse.Location = new Point(513, 2);
            HowToUse.Name = "HowToUse";
            HowToUse.Size = new Size(34, 28);
            HowToUse.TabIndex = 14;
            HowToUse.Text = "?";
            HowToUse.UseVisualStyleBackColor = true;
            HowToUse.Click += HowToUse_Click;
            // 
            // Body
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 450);
            Controls.Add(HowToUse);
            Controls.Add(IpInput);
            Controls.Add(textBox2);
            Controls.Add(Title);
            Controls.Add(checkBox2);
            Controls.Add(textBox1);
            Controls.Add(CMD);
            Controls.Add(TestButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Body";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ferramenta para Teste de Impressoras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button TestButton;
        public TextBox CMD;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
        private CheckBox checkBox2;
        private TextBox Title;
        private TextBox textBox2;
        private TextBox IpInput;
        private Button HowToUse;
    }
}
