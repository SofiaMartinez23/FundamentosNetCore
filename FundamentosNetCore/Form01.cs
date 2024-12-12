namespace FundamentosNetCore
{
    public partial class Form01 : Form
    {
        public Form01()
        {
            InitializeComponent();
            this.Text = "Algo aqui ...";
            this.SuspendLayout();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //SOLO ESCRIBIMOS AQUI
            this.textNombre.Location = new Point(20, 10);
            this.textNombre.Text = "Soy un string";
            this.textNombre.Width = 220;
            this.textNombre.TextAlign = HorizontalAlignment.Right;
            this.btnPulsar.BackColor = Color.CornflowerBlue;


            //NO ES CONVERSION AUTOMATICA
            short pequeño = 88;
            int mayor = pequeño;


            //STRING A PRIMITIVO
            string textoNumero = "12345";
            int numero = int.Parse(textoNumero);
            double otro = double.Parse(textoNumero);

            //CASTING PRIMITIVOS
            int mayor1 = 99;
            short peque = (short)mayor1;

            //CUALQUIER OBJETO A STRING
            int num = 88;
            string texto = numero.ToString();
            texto = btnPulsar.ToString();

        }
    }
}
