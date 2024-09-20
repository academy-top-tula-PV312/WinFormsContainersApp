namespace WinFormsContainersApp
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
            grpBoxPerson = new GroupBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            lblAge = new Label();
            lblName = new Label();
            radioMale = new RadioButton();
            radioFemale = new RadioButton();
            radioManager = new RadioButton();
            radioDevops = new RadioButton();
            grpBoxGender = new GroupBox();
            grpBoxPosition = new GroupBox();
            radioTester = new RadioButton();
            button1 = new Button();
            panel1 = new Panel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            flowPanel = new FlowLayoutPanel();
            tableLayoutPanel = new TableLayoutPanel();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            grpBoxPerson.SuspendLayout();
            grpBoxGender.SuspendLayout();
            grpBoxPosition.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxPerson
            // 
            grpBoxPerson.Controls.Add(txtAge);
            grpBoxPerson.Controls.Add(txtName);
            grpBoxPerson.Controls.Add(lblAge);
            grpBoxPerson.Controls.Add(lblName);
            grpBoxPerson.Location = new Point(27, 18);
            grpBoxPerson.Margin = new Padding(8, 9, 8, 9);
            grpBoxPerson.Name = "grpBoxPerson";
            grpBoxPerson.Padding = new Padding(8, 9, 8, 9);
            grpBoxPerson.Size = new Size(471, 231);
            grpBoxPerson.TabIndex = 0;
            grpBoxPerson.TabStop = false;
            grpBoxPerson.Text = "Person Info";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(156, 140);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(288, 50);
            txtAge.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(156, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(288, 50);
            txtName.TabIndex = 1;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(11, 140);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(77, 45);
            lblAge.TabIndex = 0;
            lblAge.Text = "Age";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(11, 61);
            lblName.Name = "lblName";
            lblName.Size = new Size(105, 45);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Location = new Point(17, 49);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(108, 49);
            radioMale.TabIndex = 1;
            radioMale.TabStop = true;
            radioMale.Text = "Male";
            radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Location = new Point(17, 94);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(140, 49);
            radioFemale.TabIndex = 2;
            radioFemale.TabStop = true;
            radioFemale.Text = "Female";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioManager
            // 
            radioManager.AutoSize = true;
            radioManager.Location = new Point(17, 66);
            radioManager.Name = "radioManager";
            radioManager.Size = new Size(164, 49);
            radioManager.TabIndex = 3;
            radioManager.TabStop = true;
            radioManager.Text = "Manager";
            radioManager.UseVisualStyleBackColor = true;
            // 
            // radioDevops
            // 
            radioDevops.AutoSize = true;
            radioDevops.Location = new Point(17, 133);
            radioDevops.Name = "radioDevops";
            radioDevops.Size = new Size(183, 49);
            radioDevops.TabIndex = 4;
            radioDevops.TabStop = true;
            radioDevops.Text = "Developer";
            radioDevops.UseVisualStyleBackColor = true;
            // 
            // grpBoxGender
            // 
            grpBoxGender.BackColor = SystemColors.Control;
            grpBoxGender.Controls.Add(radioMale);
            grpBoxGender.Controls.Add(radioFemale);
            grpBoxGender.Location = new Point(526, 39);
            grpBoxGender.Name = "grpBoxGender";
            grpBoxGender.Size = new Size(420, 169);
            grpBoxGender.TabIndex = 5;
            grpBoxGender.TabStop = false;
            grpBoxGender.Text = "Gender";
            // 
            // grpBoxPosition
            // 
            grpBoxPosition.Controls.Add(radioManager);
            grpBoxPosition.Controls.Add(radioTester);
            grpBoxPosition.Controls.Add(radioDevops);
            grpBoxPosition.Location = new Point(27, 261);
            grpBoxPosition.Name = "grpBoxPosition";
            grpBoxPosition.Size = new Size(420, 264);
            grpBoxPosition.TabIndex = 6;
            grpBoxPosition.TabStop = false;
            grpBoxPosition.Text = "Position";
            // 
            // radioTester
            // 
            radioTester.AutoSize = true;
            radioTester.Location = new Point(17, 198);
            radioTester.Name = "radioTester";
            radioTester.Size = new Size(122, 49);
            radioTester.TabIndex = 4;
            radioTester.TabStop = true;
            radioTester.Text = "Tester";
            radioTester.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(583, 703);
            button1.Name = "button1";
            button1.Size = new Size(233, 96);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(963, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 194);
            panel1.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(22, 244);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(335, 50);
            textBox4.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(22, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(335, 50);
            textBox3.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(335, 50);
            textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 50);
            textBox1.TabIndex = 0;
            // 
            // flowPanel
            // 
            flowPanel.BorderStyle = BorderStyle.FixedSingle;
            flowPanel.Location = new Point(526, 227);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(420, 149);
            flowPanel.TabIndex = 9;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel.Location = new Point(526, 408);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.Size = new Size(420, 175);
            tableLayoutPanel.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(27, 546);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 267);
            panel2.TabIndex = 11;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 18F);
            tabControl1.Location = new Point(986, 283);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(388, 370);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox7);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Location = new Point(4, 41);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(380, 325);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Page 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Location = new Point(4, 41);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(380, 325);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Page 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(55, 48);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(252, 39);
            textBox5.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(55, 123);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(252, 39);
            textBox6.TabIndex = 0;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(55, 183);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(252, 39);
            textBox7.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(53, 32);
            button2.Name = "button2";
            button2.Size = new Size(262, 73);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(53, 127);
            button3.Name = "button3";
            button3.Size = new Size(262, 73);
            button3.TabIndex = 0;
            button3.Text = "button2";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(53, 222);
            button5.Name = "button5";
            button5.Size = new Size(262, 73);
            button5.TabIndex = 0;
            button5.Text = "button2";
            button5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 848);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel);
            Controls.Add(flowPanel);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(grpBoxPosition);
            Controls.Add(grpBoxGender);
            Controls.Add(grpBoxPerson);
            Font = new Font("Segoe UI", 24F);
            Margin = new Padding(8, 9, 8, 9);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            Resize += MainForm_Resize;
            grpBoxPerson.ResumeLayout(false);
            grpBoxPerson.PerformLayout();
            grpBoxGender.ResumeLayout(false);
            grpBoxGender.PerformLayout();
            grpBoxPosition.ResumeLayout(false);
            grpBoxPosition.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxPerson;
        private TextBox txtAge;
        private Label lblAge;
        private Label lblName;
        private RadioButton radioMale;
        private RadioButton radioFemale;
        private RadioButton radioManager;
        private RadioButton radioDevops;
        private GroupBox grpBoxGender;
        private GroupBox grpBoxPosition;
        private RadioButton radioTester;
        private Button button1;
        private Panel panel1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private FlowLayoutPanel flowPanel;
        private TableLayoutPanel tableLayoutPanel;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button button5;
        private Button button3;
        private Button button2;
    }
}
