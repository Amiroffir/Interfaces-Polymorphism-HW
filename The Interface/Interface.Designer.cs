namespace TheInterface
{
    partial class Interface
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
            this.name = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.dayInput = new System.Windows.Forms.TextBox();
            this.ageInput = new System.Windows.Forms.TextBox();
            this.addToFileBtn = new System.Windows.Forms.Button();
            this.loadFromFile = new System.Windows.Forms.Button();
            this.ItemCreate = new System.Windows.Forms.Button();
            this.colaBtn = new System.Windows.Forms.Button();
            this.kinleyBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(57, 56);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(49, 19);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.day.Location = new System.Drawing.Point(58, 106);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(35, 19);
            this.day.TabIndex = 1;
            this.day.Text = "Day";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.age.Location = new System.Drawing.Point(59, 154);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(36, 19);
            this.age.TabIndex = 2;
            this.age.Text = "Age";
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameInput.Location = new System.Drawing.Point(123, 61);
            this.nameInput.Name = "nameInput";
            this.nameInput.PlaceholderText = "Your Name";
            this.nameInput.Size = new System.Drawing.Size(100, 16);
            this.nameInput.TabIndex = 3;
            // 
            // dayInput
            // 
            this.dayInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dayInput.Location = new System.Drawing.Point(123, 106);
            this.dayInput.Name = "dayInput";
            this.dayInput.PlaceholderText = "Birth Day";
            this.dayInput.Size = new System.Drawing.Size(100, 16);
            this.dayInput.TabIndex = 4;
            // 
            // ageInput
            // 
            this.ageInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ageInput.Location = new System.Drawing.Point(123, 154);
            this.ageInput.Name = "ageInput";
            this.ageInput.PlaceholderText = "Your Age";
            this.ageInput.Size = new System.Drawing.Size(100, 16);
            this.ageInput.TabIndex = 5;
            // 
            // addToFileBtn
            // 
            this.addToFileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToFileBtn.Location = new System.Drawing.Point(38, 215);
            this.addToFileBtn.Name = "addToFileBtn";
            this.addToFileBtn.Size = new System.Drawing.Size(75, 23);
            this.addToFileBtn.TabIndex = 6;
            this.addToFileBtn.Text = "Add To File";
            this.addToFileBtn.UseVisualStyleBackColor = true;
            this.addToFileBtn.UseWaitCursor = true;
            this.addToFileBtn.Click += new System.EventHandler(this.addToFileBtn_Click);
            // 
            // loadFromFile
            // 
            this.loadFromFile.Location = new System.Drawing.Point(138, 215);
            this.loadFromFile.Name = "loadFromFile";
            this.loadFromFile.Size = new System.Drawing.Size(107, 23);
            this.loadFromFile.TabIndex = 7;
            this.loadFromFile.Text = "Load From File";
            this.loadFromFile.UseVisualStyleBackColor = true;
            this.loadFromFile.Click += new System.EventHandler(this.loadFromFile_Click);
            // 
            // ItemCreate
            // 
            this.ItemCreate.Location = new System.Drawing.Point(266, 215);
            this.ItemCreate.Name = "ItemCreate";
            this.ItemCreate.Size = new System.Drawing.Size(103, 23);
            this.ItemCreate.TabIndex = 8;
            this.ItemCreate.Text = "Create Item";
            this.ItemCreate.UseVisualStyleBackColor = true;
            this.ItemCreate.Click += new System.EventHandler(this.ItemCreate_Click);
            // 
            // colaBtn
            // 
            this.colaBtn.Location = new System.Drawing.Point(334, 80);
            this.colaBtn.Name = "colaBtn";
            this.colaBtn.Size = new System.Drawing.Size(75, 23);
            this.colaBtn.TabIndex = 9;
            this.colaBtn.Text = "Add Cola";
            this.colaBtn.UseVisualStyleBackColor = true;
            this.colaBtn.Click += new System.EventHandler(this.colaBtn_Click);
            // 
            // kinleyBtn
            // 
            this.kinleyBtn.Location = new System.Drawing.Point(334, 134);
            this.kinleyBtn.Name = "kinleyBtn";
            this.kinleyBtn.Size = new System.Drawing.Size(75, 23);
            this.kinleyBtn.TabIndex = 10;
            this.kinleyBtn.Text = "Add Kinley";
            this.kinleyBtn.UseVisualStyleBackColor = true;
            this.kinleyBtn.Click += new System.EventHandler(this.kinleyBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(452, 290);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 23);
            this.printBtn.TabIndex = 11;
            this.printBtn.Text = "Print List";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 340);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.kinleyBtn);
            this.Controls.Add(this.colaBtn);
            this.Controls.Add(this.ItemCreate);
            this.Controls.Add(this.loadFromFile);
            this.Controls.Add(this.addToFileBtn);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.dayInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.age);
            this.Controls.Add(this.day);
            this.Controls.Add(this.name);
            this.Name = "Interface";
            this.Text = "Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label name;
        private Label day;
        private Label age;
        private TextBox nameInput;
        private TextBox dayInput;
        private TextBox ageInput;
        private Button addToFileBtn;
        private Button loadFromFile;
        private Button ItemCreate;
        private Button colaBtn;
        private Button kinleyBtn;
        private Button printBtn;
    }
}