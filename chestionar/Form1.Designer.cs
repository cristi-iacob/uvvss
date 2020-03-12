namespace chestionar
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
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.IntrebareLabel = new System.Windows.Forms.Label();
            this.VariantaALabel = new System.Windows.Forms.Label();
            this.VariantaBLabel = new System.Windows.Forms.Label();
            this.VariantaCLabel = new System.Windows.Forms.Label();
            this.VariantaDLabel = new System.Windows.Forms.Label();
            this.IntrebareTextBox = new System.Windows.Forms.RichTextBox();
            this.VariantaATextBox = new System.Windows.Forms.RichTextBox();
            this.VariantaBTextBox = new System.Windows.Forms.RichTextBox();
            this.VariantaCTextBox = new System.Windows.Forms.RichTextBox();
            this.VariantaDTextBox = new System.Windows.Forms.RichTextBox();
            this.VariantaACheckBox = new System.Windows.Forms.CheckBox();
            this.VariantaBCheckBox = new System.Windows.Forms.CheckBox();
            this.VariantaCCheckBox = new System.Windows.Forms.CheckBox();
            this.VariantaDCheckBox = new System.Windows.Forms.CheckBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.DeleteAnswersButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.AddQuestionButton = new System.Windows.Forms.Button();
            this.CorecteLabel = new System.Windows.Forms.Label();
            this.NumarCorecteLabel = new System.Windows.Forms.Label();
            this.GresiteLabel = new System.Windows.Forms.Label();
            this.NumarGresiteLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextField = new System.Windows.Forms.RichTextBox();
            this.Timp = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(648, 32);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(111, 32);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // IntrebareLabel
            // 
            this.IntrebareLabel.AutoSize = true;
            this.IntrebareLabel.Location = new System.Drawing.Point(97, 134);
            this.IntrebareLabel.Name = "IntrebareLabel";
            this.IntrebareLabel.Size = new System.Drawing.Size(65, 17);
            this.IntrebareLabel.TabIndex = 2;
            this.IntrebareLabel.Text = "Intrebare";
            this.IntrebareLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // VariantaALabel
            // 
            this.VariantaALabel.AutoSize = true;
            this.VariantaALabel.Location = new System.Drawing.Point(97, 201);
            this.VariantaALabel.Name = "VariantaALabel";
            this.VariantaALabel.Size = new System.Drawing.Size(74, 17);
            this.VariantaALabel.TabIndex = 3;
            this.VariantaALabel.Text = "Varianta A";
            // 
            // VariantaBLabel
            // 
            this.VariantaBLabel.AutoSize = true;
            this.VariantaBLabel.Location = new System.Drawing.Point(97, 261);
            this.VariantaBLabel.Name = "VariantaBLabel";
            this.VariantaBLabel.Size = new System.Drawing.Size(74, 17);
            this.VariantaBLabel.TabIndex = 4;
            this.VariantaBLabel.Text = "Varianta B";
            this.VariantaBLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // VariantaCLabel
            // 
            this.VariantaCLabel.AutoSize = true;
            this.VariantaCLabel.Location = new System.Drawing.Point(97, 306);
            this.VariantaCLabel.Name = "VariantaCLabel";
            this.VariantaCLabel.Size = new System.Drawing.Size(74, 17);
            this.VariantaCLabel.TabIndex = 5;
            this.VariantaCLabel.Text = "Varianta C";
            this.VariantaCLabel.Click += new System.EventHandler(this.VariantaCLabel_Click);
            // 
            // VariantaDLabel
            // 
            this.VariantaDLabel.AutoSize = true;
            this.VariantaDLabel.Location = new System.Drawing.Point(97, 357);
            this.VariantaDLabel.Name = "VariantaDLabel";
            this.VariantaDLabel.Size = new System.Drawing.Size(75, 17);
            this.VariantaDLabel.TabIndex = 6;
            this.VariantaDLabel.Text = "Varianta D";
            // 
            // IntrebareTextBox
            // 
            this.IntrebareTextBox.Location = new System.Drawing.Point(209, 131);
            this.IntrebareTextBox.Name = "IntrebareTextBox";
            this.IntrebareTextBox.Size = new System.Drawing.Size(550, 33);
            this.IntrebareTextBox.TabIndex = 7;
            this.IntrebareTextBox.Text = "";
            // 
            // VariantaATextBox
            // 
            this.VariantaATextBox.Location = new System.Drawing.Point(209, 198);
            this.VariantaATextBox.Name = "VariantaATextBox";
            this.VariantaATextBox.Size = new System.Drawing.Size(550, 28);
            this.VariantaATextBox.TabIndex = 8;
            this.VariantaATextBox.Text = "";
            this.VariantaATextBox.TextChanged += new System.EventHandler(this.VariantaATextBox_TextChanged);
            // 
            // VariantaBTextBox
            // 
            this.VariantaBTextBox.Location = new System.Drawing.Point(209, 258);
            this.VariantaBTextBox.Name = "VariantaBTextBox";
            this.VariantaBTextBox.Size = new System.Drawing.Size(550, 27);
            this.VariantaBTextBox.TabIndex = 9;
            this.VariantaBTextBox.Text = "";
            // 
            // VariantaCTextBox
            // 
            this.VariantaCTextBox.Location = new System.Drawing.Point(209, 303);
            this.VariantaCTextBox.Name = "VariantaCTextBox";
            this.VariantaCTextBox.Size = new System.Drawing.Size(550, 27);
            this.VariantaCTextBox.TabIndex = 10;
            this.VariantaCTextBox.Text = "";
            // 
            // VariantaDTextBox
            // 
            this.VariantaDTextBox.Location = new System.Drawing.Point(209, 354);
            this.VariantaDTextBox.Name = "VariantaDTextBox";
            this.VariantaDTextBox.Size = new System.Drawing.Size(550, 28);
            this.VariantaDTextBox.TabIndex = 11;
            this.VariantaDTextBox.Text = "";
            // 
            // VariantaACheckBox
            // 
            this.VariantaACheckBox.AutoSize = true;
            this.VariantaACheckBox.Location = new System.Drawing.Point(765, 202);
            this.VariantaACheckBox.Name = "VariantaACheckBox";
            this.VariantaACheckBox.Size = new System.Drawing.Size(18, 17);
            this.VariantaACheckBox.TabIndex = 12;
            this.VariantaACheckBox.UseVisualStyleBackColor = true;
            // 
            // VariantaBCheckBox
            // 
            this.VariantaBCheckBox.AutoSize = true;
            this.VariantaBCheckBox.Location = new System.Drawing.Point(765, 262);
            this.VariantaBCheckBox.Name = "VariantaBCheckBox";
            this.VariantaBCheckBox.Size = new System.Drawing.Size(18, 17);
            this.VariantaBCheckBox.TabIndex = 13;
            this.VariantaBCheckBox.UseVisualStyleBackColor = true;
            // 
            // VariantaCCheckBox
            // 
            this.VariantaCCheckBox.AutoSize = true;
            this.VariantaCCheckBox.Location = new System.Drawing.Point(765, 307);
            this.VariantaCCheckBox.Name = "VariantaCCheckBox";
            this.VariantaCCheckBox.Size = new System.Drawing.Size(18, 17);
            this.VariantaCCheckBox.TabIndex = 14;
            this.VariantaCCheckBox.UseVisualStyleBackColor = true;
            // 
            // VariantaDCheckBox
            // 
            this.VariantaDCheckBox.AutoSize = true;
            this.VariantaDCheckBox.Location = new System.Drawing.Point(765, 361);
            this.VariantaDCheckBox.Name = "VariantaDCheckBox";
            this.VariantaDCheckBox.Size = new System.Drawing.Size(18, 17);
            this.VariantaDCheckBox.TabIndex = 15;
            this.VariantaDCheckBox.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(647, 444);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(112, 34);
            this.NextButton.TabIndex = 16;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // DeleteAnswersButton
            // 
            this.DeleteAnswersButton.Location = new System.Drawing.Point(422, 444);
            this.DeleteAnswersButton.Name = "DeleteAnswersButton";
            this.DeleteAnswersButton.Size = new System.Drawing.Size(135, 34);
            this.DeleteAnswersButton.TabIndex = 17;
            this.DeleteAnswersButton.Text = "Delete Answers";
            this.DeleteAnswersButton.UseVisualStyleBackColor = true;
            this.DeleteAnswersButton.Click += new System.EventHandler(this.DeleteAnswersButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(440, 32);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(130, 32);
            this.ResetButton.TabIndex = 18;
            this.ResetButton.Text = "Reset quiz";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AddQuestionButton
            // 
            this.AddQuestionButton.Location = new System.Drawing.Point(232, 32);
            this.AddQuestionButton.Name = "AddQuestionButton";
            this.AddQuestionButton.Size = new System.Drawing.Size(136, 32);
            this.AddQuestionButton.TabIndex = 19;
            this.AddQuestionButton.Text = "Add question";
            this.AddQuestionButton.UseVisualStyleBackColor = true;
            this.AddQuestionButton.Click += new System.EventHandler(this.AddQuestionButton_Click);
            // 
            // CorecteLabel
            // 
            this.CorecteLabel.AutoSize = true;
            this.CorecteLabel.Location = new System.Drawing.Point(38, 32);
            this.CorecteLabel.Name = "CorecteLabel";
            this.CorecteLabel.Size = new System.Drawing.Size(65, 17);
            this.CorecteLabel.TabIndex = 20;
            this.CorecteLabel.Text = "Corecte: ";
            // 
            // NumarCorecteLabel
            // 
            this.NumarCorecteLabel.AutoSize = true;
            this.NumarCorecteLabel.Location = new System.Drawing.Point(110, 31);
            this.NumarCorecteLabel.Name = "NumarCorecteLabel";
            this.NumarCorecteLabel.Size = new System.Drawing.Size(16, 17);
            this.NumarCorecteLabel.TabIndex = 21;
            this.NumarCorecteLabel.Text = "0";
            // 
            // GresiteLabel
            // 
            this.GresiteLabel.AutoSize = true;
            this.GresiteLabel.Location = new System.Drawing.Point(38, 63);
            this.GresiteLabel.Name = "GresiteLabel";
            this.GresiteLabel.Size = new System.Drawing.Size(58, 17);
            this.GresiteLabel.TabIndex = 22;
            this.GresiteLabel.Text = "Gresite:";
            // 
            // NumarGresiteLabel
            // 
            this.NumarGresiteLabel.AutoSize = true;
            this.NumarGresiteLabel.Location = new System.Drawing.Point(110, 63);
            this.NumarGresiteLabel.Name = "NumarGresiteLabel";
            this.NumarGresiteLabel.Size = new System.Drawing.Size(16, 17);
            this.NumarGresiteLabel.TabIndex = 23;
            this.NumarGresiteLabel.Text = "0";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(105, 407);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 17);
            this.IDLabel.TabIndex = 24;
            this.IDLabel.Text = "ID";
            // 
            // IDTextField
            // 
            this.IDTextField.Location = new System.Drawing.Point(209, 404);
            this.IDTextField.Name = "IDTextField";
            this.IDTextField.Size = new System.Drawing.Size(550, 31);
            this.IDTextField.TabIndex = 25;
            this.IDTextField.Text = "";
            // 
            // Timp
            // 
            this.Timp.Interval = 1000;
            this.Timp.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(41, 103);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(44, 17);
            this.TimeLabel.TabIndex = 26;
            this.TimeLabel.Text = "30:00";
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(272, 444);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(112, 33);
            this.MenuButton.TabIndex = 27;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 509);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.IDTextField);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.NumarGresiteLabel);
            this.Controls.Add(this.GresiteLabel);
            this.Controls.Add(this.NumarCorecteLabel);
            this.Controls.Add(this.CorecteLabel);
            this.Controls.Add(this.AddQuestionButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.DeleteAnswersButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.VariantaDCheckBox);
            this.Controls.Add(this.VariantaCCheckBox);
            this.Controls.Add(this.VariantaBCheckBox);
            this.Controls.Add(this.VariantaACheckBox);
            this.Controls.Add(this.VariantaDTextBox);
            this.Controls.Add(this.VariantaCTextBox);
            this.Controls.Add(this.VariantaBTextBox);
            this.Controls.Add(this.VariantaATextBox);
            this.Controls.Add(this.IntrebareTextBox);
            this.Controls.Add(this.VariantaDLabel);
            this.Controls.Add(this.VariantaCLabel);
            this.Controls.Add(this.VariantaBLabel);
            this.Controls.Add(this.VariantaALabel);
            this.Controls.Add(this.IntrebareLabel);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label IntrebareLabel;
        private System.Windows.Forms.Label VariantaALabel;
        private System.Windows.Forms.Label VariantaBLabel;
        private System.Windows.Forms.Label VariantaCLabel;
        private System.Windows.Forms.Label VariantaDLabel;
        private System.Windows.Forms.RichTextBox IntrebareTextBox;
        private System.Windows.Forms.RichTextBox VariantaATextBox;
        private System.Windows.Forms.RichTextBox VariantaBTextBox;
        private System.Windows.Forms.RichTextBox VariantaCTextBox;
        private System.Windows.Forms.RichTextBox VariantaDTextBox;
        private System.Windows.Forms.CheckBox VariantaACheckBox;
        private System.Windows.Forms.CheckBox VariantaBCheckBox;
        private System.Windows.Forms.CheckBox VariantaCCheckBox;
        private System.Windows.Forms.CheckBox VariantaDCheckBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button DeleteAnswersButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button AddQuestionButton;
        private System.Windows.Forms.Label CorecteLabel;
        private System.Windows.Forms.Label NumarCorecteLabel;
        private System.Windows.Forms.Label GresiteLabel;
        private System.Windows.Forms.Label NumarGresiteLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.RichTextBox IDTextField;
        private System.Windows.Forms.Timer Timp;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button MenuButton;
    }
}

