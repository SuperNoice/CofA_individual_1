using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace individual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Importbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = ".txt";
            openFile.AddExtension = true;
            openFile.Title = "Открыть...";
            openFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFile.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            TextBoxIn.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = ".txt";
            saveFile.AddExtension = true;
            saveFile.Title = "Сохранить как...";
            saveFile.OverwritePrompt = true;
            saveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFile.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, TextBoxOut.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            TextBoxIn.Clear();
            TextBoxOut.Clear();
        }

        private Graph setGraph()
        {
            // Проверки
            if (TextBoxIn.Text.Length == 0)
            {
                TextBoxOut.AppendText("Введите матрицу!");
                return null;
            }
            // Инициализация
            string reference = TextBoxIn.Text.Trim();
            string[] str = reference.Split('\n');
            int size = str.Length;
            int[,] matr = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                string[] stl = str[i].Split(' ');

                if (stl.Length != size)
                {
                    TextBoxOut.AppendText("Неверный формат матрицы!");
                    return null;
                }

                for (int j = 0; j < size; j++)
                    matr[i, j] = System.Convert.ToInt32(stl[j]);
            }

            Graph G = new Graph();
            G.setupGraph(matr);

            return G;
        }

        private void Processbutton_Click(object sender, EventArgs e)
        {
            TextBoxOut.Clear();

            if (TextBoxParamN.Text.Length == 0)
            {
                TextBoxOut.AppendText("Параметр N не задан!");
                return;
            }

            Graph G = setGraph();
            if (G == null) return;

            int N = System.Convert.ToInt32(TextBoxParamN.Text);

            // Поиск количества путей
            int res = G.countWays(N);
            // Вывод результата
            TextBoxOut.AppendText(System.Convert.ToString(res));
        }

        private void Processbutton2_Click(object sender, EventArgs e)
        {
            TextBoxOut.Clear();

            Graph G = setGraph();
            if (G == null) return;

            List<Vertex> res = G.maximum_independent_set_of_vertexes();

            if (res.Count == 0)
            {
                TextBoxOut.Text = "Независимое множество вершин отсутствует";
                return;
            }

            TextBoxOut.Text = "Все вершины: ";
            foreach (Vertex item in G.getVertexList()) TextBoxOut.Text += System.Convert.ToString(item.getVertexId()) + " ";
            TextBoxOut.Text += "\nНезависимое множество вершин: ";

            foreach (Vertex item in res) TextBoxOut.Text += System.Convert.ToString(item.getVertexId()) + " ";


        }

        private void Processbutton3_Click(object sender, EventArgs e)
        {
            TextBoxOut.Clear();

            Graph G = setGraph();
            if (G == null) return;

            if (G.topology_sort() == 1) { TextBoxOut.Text = "Граф не может быть отсортирован!"; return; }

            TextBoxOut.Text += "Отсортированный граф: ";
            foreach (var Vertex in G.getVertexList()) TextBoxOut.Text += System.Convert.ToString(Vertex.getVertexId()) + " ";

        }

        private void Processbutton4_Click(object sender, EventArgs e)
        {
            TextBoxOut.Clear();

            Graph G = setGraph();
            if (G == null) return;

            if (G.isTree()) TextBoxOut.Text = "Дерево: да";
            else TextBoxOut.Text = "Дерево: нет";
        }

        private void Processbutton5_Click(object sender, EventArgs e)
        {
            TextBoxOut.Clear();

            Graph G = setGraph();
            if (G == null) return;

            if (StartVertex.Text == "") { TextBoxOut.Text = "Введите начальную вершину!"; return; }
            int start = System.Convert.ToInt32(StartVertex.Text);
            if (start > G.getVertexList().Count - 1 || start < 0) { TextBoxOut.Text = "Неправильная стартовая точка! Нумерация вершин от нуля."; return; }

            List<int> dist = G.BFShortWay(start);

            for (int i = 0; i < dist.Count; i++)
            {
                if (i != start && dist[i] != int.MaxValue)
                    TextBoxOut.Text += System.Convert.ToString(start) + "->" + System.Convert.ToString(i) + "=" + System.Convert.ToString(dist[i]) + "\n";
            }
        }
    }

}
