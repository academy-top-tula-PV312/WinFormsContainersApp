namespace WinFormsContainersApp
{
    public partial class MainForm : Form
    {
        TextBox txtName;
        Button btnHello;

        Color backColor;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //DynamicCreateControls();

            for (int i = 1; i < 10; i++)
            {
                Button btn = new Button();
                btn.Font = new Font(new FontFamily("Calibri"), 12);
                btn.Text = $"Button {i}";
                btn.Dock = DockStyle.Fill;
                tableLayoutPanel.Controls.Add(btn);
            }

            for(int i = 0; i < 5; i++)
            {
                Button btn = new Button();
                btn.Font = new Font(new FontFamily("Calibri"), 12);
                btn.Text = $"Button {i}";
                btn.Dock = DockStyle.Left;

                panel2.Controls.Add(btn);
            }

            TabPage tabPage = new TabPage();
            tabPage.Text = "Page 3";

            Button btn1 = new Button();
            btn1.Font = new Font(new FontFamily("Calibri"), 12);
            btn1.Text = $"Button";

            tabPage.Controls.Add(btn1);

            tabControl1.TabPages.Add(tabPage);
        }

        private void BtnHello_Click(object? sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length > 0)
                MessageBox.Show($"Hello {txtName.Text}", "Message from MainForm");
            else
                txtName.Text = "";
        }

        private void DynamicCreateControls()
        {
            btnHello = new Button();
            btnHello.Location = new Point(350, 300);
            btnHello.Size = new Size(100, 50);
            btnHello.Text = "Say Hello";
            btnHello.Click += BtnHello_Click;
            btnHello.BackColor = Color.Magenta;
            btnHello.ForeColor = Color.White;
            btnHello.TabIndex = 1;

            txtName = new TextBox();
            txtName.Location = new Point(200, 100);
            txtName.Size = new Size(400, 50);
            txtName.Font = new Font(new FontFamily("Calibri"), 30);
            txtName.TabIndex = 0;


            this.Controls.Add(btnHello);
            this.Controls.Add(txtName);


            // GROUP BOX
            RadioButton radioTrans = new RadioButton();
            radioTrans.Text = "Trans";
            radioTrans.Location = new Point(17, 150);
            radioTrans.Size = new Size(150, 40);

            grpBoxGender.Controls.Add(radioTrans);


            // FLOW PANEL
            flowPanel.FlowDirection = FlowDirection.BottomUp;

            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = $"Button {i.ToString()}";
                btn.Font = new Font(new FontFamily("Calibri"), 12);
                flowPanel.Controls.Add(btn);
            }


        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            var x = (this.Width - button1.Width) / 2;

            button1.Location = new Point(x, button1.Location.Y);
        }
    }
}
