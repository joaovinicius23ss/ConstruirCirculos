/*Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 02 / 06 / 2026
 * Autor do Projeto: João Vinícius dos Santos Costa
 *
 * Turma: 3J
 * Atividade de Plotar circulo na tela
 * 
 * ******************************************************************/
namespace ConstruirCirculos
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Color Cor(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }


        public Pen CriaCaneta(int r, int g, int b)
        {
            return new Pen(Cor(r, g, b), 1);
        }


        public void PintaPonto(PaintEventArgs e, Pen pen, int x, int y)
        {
            e.Graphics.DrawLine(pen, x, y, x + 1, y);
        }

		public void DesenhaArco(PaintEventArgs e, Pen pen, int xc, int yc, int raio, double ti, double tf)
		{
			for (double teta = ti; teta <= tf; teta += 0.01)
			{
				int x = (int)(xc + raio * Math.Cos(teta));
				int y = (int)(yc + raio * Math.Sin(teta));

				PintaPonto(e, pen, x, y);
			}
		}


		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			DesenhaArco(e, CriaCaneta(0, 255, 0), 200, 200, 100, 0, 2 * 3.14);
		}
	}
}
