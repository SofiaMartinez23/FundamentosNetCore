namespace FundamentosNetCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Algo aqui ...";
            this.SuspendLayout();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            this.textNombre.Location = new Point(20, 10);
            this.textNombre.Text = "Soy un string";
            this.textNombre.Width = 220;
            this.textNombre.TextAlign = HorizontalAlignment.Right;
            this.btnPulsar.BackColor = Color.CornflowerBlue;
        }
    }
}
