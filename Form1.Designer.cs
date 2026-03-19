namespace EchoMessenger
{
    partial class Form1
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
            label1 = new Label();
            lstb = new ListBox();
            txtb = new TextBox();
            bt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("휴먼둥근헤드라인", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(486, 49);
            label1.TabIndex = 0;
            label1.Text = "Echo Messenger";
            label1.Click += label1_Click;
            // 
            // lstb
            // 
            lstb.BackColor = SystemColors.Info;
            lstb.FormattingEnabled = true;
            lstb.Location = new Point(12, 89);
            lstb.Name = "lstb";
            lstb.Size = new Size(725, 264);
            lstb.TabIndex = 1;
            lstb.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtb
            // 
            txtb.Font = new Font("맑은 고딕", 15F);
            txtb.Location = new Point(12, 392);
            txtb.Name = "txtb";
            txtb.Size = new Size(563, 41);
            txtb.TabIndex = 2;
            txtb.Text = "(여기에 입력하세요)";
            txtb.TextChanged += txtb_TextChanged;
            // 
            // bt
            // 
            bt.BackColor = SystemColors.MenuHighlight;
            bt.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            bt.ForeColor = Color.FromArgb(128, 255, 128);
            bt.Location = new Point(643, 382);
            bt.Name = "bt";
            bt.Size = new Size(94, 56);
            bt.TabIndex = 3;
            bt.Text = "전송";
            bt.UseVisualStyleBackColor = false;
            bt.Click += bt_Click;
            bt.MouseClick += bt_MouseClick;
            // 
            // Form1
            // 
            AcceptButton = bt;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt);
            Controls.Add(txtb);
            Controls.Add(lstb);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstb;
        private TextBox txtb;
        private Button bt;
    }
}
