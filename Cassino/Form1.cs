namespace Cassino
{
    public partial class Form1 : Form
    {
        int[] roleta;
        int[] ciclos;
        Label[] tela;
        Random r;
        public Form1()
        {
            InitializeComponent();
            roleta = new int[3];
            ciclos = new int[3];
            tela = new Label[] { lbl1, lbl2, lbl3 };
            r = new Random();
            for (int i = 0; i < roleta.Length; i++)
            {
                roleta[i] = r.Next(0, 10);
                Atualizar(i);
            }
        }
        void Atualizar(int i)
        {
            tela[i].Text = roleta[i].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ciclos.Length; i++)
            {
                ciclos[i] = r.Next(1, 21);
                tela[i].ForeColor = Color.Black;
            }
            Array.Sort(ciclos);
            btGirar.Enabled = false;
            tmrGiro.Enabled = true;
        }

        private void tmrGiro_Tick(object sender, EventArgs e)
        {
            bool parado = true;
            for (int i = 0; i < ciclos.Length; i++)
            {
                if (ciclos[i] > 0)
                {
                    ciclos[i]--;
                    if (ciclos[i] == 0)
                    {
                        tela[i].ForeColor = Color.Red;
                    }
                    roleta[i]++;
                    if (roleta[i] == 10)
                    {
                        roleta[i] = 0;
                    }
                    Atualizar(i);
                    parado &= false;
                }
                else
                {
                    parado &= true;
                }
            }
            if (parado)
            {
                tmrGiro.Enabled = false;
                btGirar.Enabled = true;
                if (tela[0].Text == tela[1].Text && tela[1].Text == tela[2].Text)
                {
                    MessageBox.Show("Você ganhou!");
                }
                lbxUltimos.Items.Add($"{roleta[0]} - {roleta[1]} - {roleta[2]}");
            }
        }

        List<string> jogadas;
        private void chbVitorias_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVitorias.Checked)
            {
                btGirar.Enabled = false;
                jogadas = new List<string>();
                foreach (string item in lbxUltimos.Items)
                {
                    jogadas.Add(item);
                }

                lbxUltimos.Items.Clear();

                foreach (string item in jogadas)
                {
                    string[] nums = item.Split('-');
                    string n1 = nums[0].Trim();
                    string n2 = nums[1].Trim();
                    string n3 = nums[2].Trim();

                    if (n1 == n2 && n2 == n3)
                    {
                        lbxUltimos.Items.Add(item);
                    }
                }
            }
            else
            {
                btGirar.Enabled = true;
                lbxUltimos.Items.Clear();
                foreach (string item in jogadas)
                {
                    lbxUltimos.Items.Add(item);
                }
            }
        }
    }
}