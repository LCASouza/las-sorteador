namespace LAS_Sorteador
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            tableLayoutPanel1 = new TableLayoutPanel();
            drawButton = new Button();
            drawNumber = new Label();
            exitButton = new Button();
            resetCounterButton = new Button();
            numerosSorteadosArmazenadosTextBox = new TextBox();
            repeatNumbersButton = new CheckBox();
            sortearLabel = new Label();
            eLabel = new Label();
            numeroDeSorteiosLabel = new Label();
            labelNumeros = new Label();
            initialNumberNumeric = new NumericUpDown();
            finalNumberNumeric = new NumericUpDown();
            numberOfDrawsNumeric = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)initialNumberNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)finalNumberNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberOfDrawsNumeric).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(drawButton, 1, 1);
            tableLayoutPanel1.Controls.Add(drawNumber, 1, 0);
            tableLayoutPanel1.Controls.Add(exitButton, 2, 2);
            tableLayoutPanel1.Controls.Add(resetCounterButton, 0, 2);
            tableLayoutPanel1.Controls.Add(numerosSorteadosArmazenadosTextBox, 1, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // drawButton
            // 
            resources.ApplyResources(drawButton, "drawButton");
            drawButton.Name = "drawButton";
            drawButton.UseVisualStyleBackColor = true;
            drawButton.Click += drawButton_Click;
            // 
            // drawNumber
            // 
            resources.ApplyResources(drawNumber, "drawNumber");
            drawNumber.Name = "drawNumber";
            // 
            // exitButton
            // 
            resources.ApplyResources(exitButton, "exitButton");
            exitButton.Name = "exitButton";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // resetCounterButton
            // 
            resources.ApplyResources(resetCounterButton, "resetCounterButton");
            resetCounterButton.Image = Properties.Resources.RestartMenor;
            resetCounterButton.Name = "resetCounterButton";
            resetCounterButton.UseVisualStyleBackColor = true;
            resetCounterButton.Click += resetCounterButton_Click;
            // 
            // numerosSorteadosArmazenadosTextBox
            // 
            resources.ApplyResources(numerosSorteadosArmazenadosTextBox, "numerosSorteadosArmazenadosTextBox");
            numerosSorteadosArmazenadosTextBox.Name = "numerosSorteadosArmazenadosTextBox";
            numerosSorteadosArmazenadosTextBox.ReadOnly = true;
            // 
            // repeatNumbersButton
            // 
            resources.ApplyResources(repeatNumbersButton, "repeatNumbersButton");
            repeatNumbersButton.Name = "repeatNumbersButton";
            repeatNumbersButton.UseVisualStyleBackColor = true;
            // 
            // sortearLabel
            // 
            resources.ApplyResources(sortearLabel, "sortearLabel");
            sortearLabel.Name = "sortearLabel";
            // 
            // eLabel
            // 
            resources.ApplyResources(eLabel, "eLabel");
            eLabel.Name = "eLabel";
            // 
            // numeroDeSorteiosLabel
            // 
            resources.ApplyResources(numeroDeSorteiosLabel, "numeroDeSorteiosLabel");
            numeroDeSorteiosLabel.Name = "numeroDeSorteiosLabel";
            // 
            // labelNumeros
            // 
            resources.ApplyResources(labelNumeros, "labelNumeros");
            labelNumeros.Name = "labelNumeros";
            // 
            // initialNumberNumeric
            // 
            resources.ApplyResources(initialNumberNumeric, "initialNumberNumeric");
            initialNumberNumeric.Maximum = new decimal(new int[] { 90000, 0, 0, 0 });
            initialNumberNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            initialNumberNumeric.Name = "initialNumberNumeric";
            initialNumberNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            initialNumberNumeric.Leave += initialNumberNumeric_Leave;
            // 
            // finalNumberNumeric
            // 
            resources.ApplyResources(finalNumberNumeric, "finalNumberNumeric");
            finalNumberNumeric.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            finalNumberNumeric.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            finalNumberNumeric.Name = "finalNumberNumeric";
            finalNumberNumeric.Value = new decimal(new int[] { 100, 0, 0, 0 });
            finalNumberNumeric.Leave += finalNumberNumeric_Leave;
            // 
            // numberOfDrawsNumeric
            // 
            resources.ApplyResources(numberOfDrawsNumeric, "numberOfDrawsNumeric");
            numberOfDrawsNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numberOfDrawsNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberOfDrawsNumeric.Name = "numberOfDrawsNumeric";
            numberOfDrawsNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numberOfDrawsNumeric.Leave += numberOfDrawsNumeric_Leave;
            // 
            // Principal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numberOfDrawsNumeric);
            Controls.Add(finalNumberNumeric);
            Controls.Add(initialNumberNumeric);
            Controls.Add(repeatNumbersButton);
            Controls.Add(labelNumeros);
            Controls.Add(numeroDeSorteiosLabel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(sortearLabel);
            Controls.Add(eLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Principal";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)initialNumberNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)finalNumberNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberOfDrawsNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button exitButton;
        private Button drawButton;
        private Label drawNumber;
        private CheckBox repeatNumbersButton;
        private Label sortearLabel;
        private Label eLabel;
        private Label numeroDeSorteiosLabel;
        private Label labelNumeros;
        private NumericUpDown initialNumberNumeric;
        private NumericUpDown finalNumberNumeric;
        private NumericUpDown numberOfDrawsNumeric;
        private Button resetCounterButton;
        private TextBox numerosSorteadosArmazenadosTextBox;
    }
}
