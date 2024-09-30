namespace LAS_Sorteador
{
    partial class MeuMsgBox
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
            tableLayoutPanel1 = new TableLayoutPanel();
            resultTextBox = new TextBox();
            label1 = new Label();
            copyButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(resultTextBox, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(copyButton, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            tableLayoutPanel1.Size = new Size(439, 267);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // resultTextBox
            // 
            resultTextBox.Anchor = AnchorStyles.None;
            resultTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultTextBox.Location = new Point(18, 45);
            resultTextBox.MaxLength = 0;
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.ScrollBars = ScrollBars.Vertical;
            resultTextBox.Size = new Size(402, 171);
            resultTextBox.TabIndex = 1;
            resultTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 15);
            label1.Name = "label1";
            label1.Size = new Size(200, 25);
            label1.TabIndex = 3;
            label1.Text = "Resultado do Sorteio";
            // 
            // copyButton
            // 
            copyButton.Anchor = AnchorStyles.Top;
            copyButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            copyButton.Location = new Point(173, 224);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(92, 35);
            copyButton.TabIndex = 2;
            copyButton.Text = "Copiar";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // MeuMsgBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 267);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(100, 100);
            Name = "MeuMsgBox";
            Text = "Resultado do Sorteio";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox resultTextBox;
        private Label label1;
        private Button copyButton;
    }
}