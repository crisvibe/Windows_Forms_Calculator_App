namespace BetterWinFormsDemo
{
    partial class MainForm
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
            calculateButton = new Button();
            numberInput1 = new TextBox();
            numberInput2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            addButton = new Button();
            subtractButton = new Button();
            textOperator = new Label();
            divideButton = new Button();
            multiplyButton = new Button();
            label3 = new Label();
            resultLabel = new Label();
            resultContent = new Label();
            clearButton = new Button();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(158, 319);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(142, 84);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // numberInput1
            // 
            numberInput1.Location = new Point(180, 70);
            numberInput1.Name = "numberInput1";
            numberInput1.Size = new Size(221, 30);
            numberInput1.TabIndex = 1;
            // 
            // numberInput2
            // 
            numberInput2.Location = new Point(180, 126);
            numberInput2.Name = "numberInput2";
            numberInput2.Size = new Size(221, 30);
            numberInput2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 73);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 2;
            label1.Text = "First Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 129);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 3;
            label2.Text = "Second Number";
            // 
            // addButton
            // 
            addButton.Location = new Point(180, 176);
            addButton.Name = "addButton";
            addButton.Size = new Size(42, 44);
            addButton.TabIndex = 4;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.Location = new Point(240, 176);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(42, 44);
            subtractButton.TabIndex = 4;
            subtractButton.Text = "-";
            subtractButton.UseVisualStyleBackColor = true;
            subtractButton.Click += subtractButton_Click;
            // 
            // textOperator
            // 
            textOperator.AutoSize = true;
            textOperator.FlatStyle = FlatStyle.Flat;
            textOperator.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textOperator.Location = new Point(130, 261);
            textOperator.Name = "textOperator";
            textOperator.Size = new Size(204, 28);
            textOperator.TabIndex = 5;
            textOperator.Text = "Arithmetic Operator";
            textOperator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divideButton
            // 
            divideButton.Location = new Point(300, 176);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(42, 44);
            divideButton.TabIndex = 6;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Location = new Point(359, 176);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(42, 44);
            multiplyButton.TabIndex = 7;
            multiplyButton.Text = "*";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 187);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 8;
            label3.Text = "Calculation Type";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 12F);
            resultLabel.Location = new Point(98, 486);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(68, 28);
            resultLabel.TabIndex = 9;
            resultLabel.Text = "Result:";
            // 
            // resultContent
            // 
            resultContent.AutoSize = true;
            resultContent.Font = new Font("Segoe UI", 14F);
            resultContent.Location = new Point(220, 486);
            resultContent.Name = "resultContent";
            resultContent.Size = new Size(0, 32);
            resultContent.TabIndex = 9;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(158, 409);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(142, 29);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear Numbers";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(457, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 578);
            Controls.Add(clearButton);
            Controls.Add(resultContent);
            Controls.Add(resultLabel);
            Controls.Add(label3);
            Controls.Add(multiplyButton);
            Controls.Add(divideButton);
            Controls.Add(textOperator);
            Controls.Add(subtractButton);
            Controls.Add(addButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numberInput2);
            Controls.Add(numberInput1);
            Controls.Add(calculateButton);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10F);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "My Calculator    ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private TextBox numberInput1;
        private TextBox numberInput2;
        private Label label1;
        private Label label2;
        private Button addButton;
        private Button subtractButton;
        private Label textOperator;
        private Button divideButton;
        private Button multiplyButton;
        private Label label3;
        private Label resultLabel;
        private Label resultContent;
        private Button clearButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
