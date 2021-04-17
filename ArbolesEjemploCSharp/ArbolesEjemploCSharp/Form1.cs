using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolesEjemploCSharp
{
    public partial class Form1 : Form
    {
        Nodo raiz;
        Nodo seleccionado;
        public Form1()
        {
            InitializeComponent();
        }

        //Metodo para crear nodo con los datos de nombre y edad pedidos por un InputBox
        Nodo crearNodo()
        {
            string nombre = Interaction.InputBox("Ingrese nombre del familiar");
            int edad = Convert.ToInt32(Interaction.InputBox("Ingrese la edad del familiar"));
            //Se devuelve el nodo creado con los datos ingresados
            return new Nodo(nombre,edad);
        }

        //Metodo para obtener la altura y el ancho del arbol para mostrar en Form a través de labels
        void EvaluarArbol()
        {
            this.lblAltura.Text = $"Altura:{Alto(raiz)}";
            int inicio = 0;
            this.lblAncho.Text = $"Ancho:{Ancho(raiz,ref inicio)}";
        }
        int Ancho(Nodo n, ref int ancho)
        {
            //Se obtiene el ancho luego del recorrido un acumulador
            if (n.Derecha == null && n.Izquierda == null)
                ancho += 1;

            if (n.Derecha != null)  Ancho(n.Derecha, ref ancho);
            if (n.Izquierda != null)  Ancho(n.Izquierda, ref ancho);

            return ancho;
        }
        int Alto(Nodo n)
        {
            //Se obtiene el alto luego del recorrido con acumuladores, luego se devuelve el de mayor valor
            if (n == null) return 0;

            int izq = Alto(n.Izquierda) + 1;
            int der = Alto(n.Derecha) + 1;
            return Math.Max(izq, der);
        }

        //Metodo para trabajar sobre el nodo seleccionado del arbol en el Treeview
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            CambiarSeleccion((Nodo)e.Node.Tag);
        }

        //Metodo para cambiar el nodo seleccionado a trabajar del arbol en el Treeview
        void CambiarSeleccion(Nodo n)
        {
            seleccionado = n;
            this.lblNombreNodo.Text = $"{n.Nombre} - {n.Edad}";
        }

        //Metodo para llenar el Treeview y mostrar, incluyendo el alto y ancho
        public void LlenarTreeView()
        {
            treeView1.Nodes.Clear();
            MostrarNodo(raiz, null, string.Empty);
            treeView1.ExpandAll(); //para mostrar el Treeview desplegado
            EvaluarArbol();
        }

        //Metodo para mostrar el arbol con sus nodos en el Treeview del Form
        public void MostrarNodo(Nodo n, TreeNode tnpadre, string lado)
        {
            if (n == null) return;

            TreeNode nuevo = new TreeNode();
            if (tnpadre == null && lado==String.Empty)
            {
                //Cuando se trata del nodo inicial o nodo raiz
                tnpadre = new TreeNode();
                nuevo.Text = $"{n.Nombre} - {n.Edad}";
                nuevo.Tag = n;
                treeView1.Nodes.Add(nuevo);
            }
            else
            {
                //Cuando es un nodo sucesor o hijo
                nuevo.Text = $"{lado} - {n.Nombre} - {n.Edad}";
                nuevo.Tag = n;
                tnpadre.Nodes.Add(nuevo);
            }

            if (n.Derecha != null) MostrarNodo(n.Derecha, nuevo, "D");
            if (n.Izquierda != null) MostrarNodo(n.Izquierda, nuevo, "I");
        }

        //Boton para agregar familiar (nodo raiz)
        private void button1_Click(object sender, EventArgs e)
        {
            //En caso de que ya haya un nodo inicial o raiz, se pregunta si se quiere reemplazar
            if (raiz != null)
            {
                DialogResult r = MessageBox.Show("Se eliminará el árbol, desea continuar?", "Consulta", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    raiz = crearNodo();
                }
            }
            else
            {
                //En caso de no haber nodo inicial o raiz, se crea
                raiz = crearNodo();
            }
            //Metodo para mostrar label y seleccionar raiz en Treeview
            CambiarSeleccion(raiz);
            //Metodo para llenar el Treeview
            LlenarTreeView();
        }

        //Boton para agregar un familiar a la derecha del nodo selecciondo
        private void button2_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                seleccionado.Derecha = crearNodo();
                LlenarTreeView();
            }
            else
                MessageBox.Show("Debe tener algun nodo seleccionado");
        }
        
        //Boton para agregar un familiar a la izquierda del nodo selecciondo
        private void button3_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                seleccionado.Izquierda = crearNodo();
                LlenarTreeView();
            }
            else
                MessageBox.Show("Debe tener algun nodo seleccionado");
        }

        //Metodo de impresion de los recorridos del arbol, que muestra los nodos visitados por el recorrido
        void Visitar(Nodo n)
        {
            this.txtRecorrido.Text += "---" + n.Nombre + n.Edad;
        }

        //Boton para recorrido InOrden
        private void button4_Click(object sender, EventArgs e)
        {
            this.txtRecorrido.Text = string.Empty;
            RecorridoInOrden(raiz);
        }

        //Metodo con algoritmo del recorrido InOrden
        void RecorridoInOrden(Nodo n)
        {
            if (n.Izquierda!=null)  RecorridoInOrden(n.Izquierda);
            Visitar(n); //Raiz en el medio
            if (n.Derecha != null) RecorridoInOrden(n.Derecha);
        }

        //Boton para recorrido PreOrden
        private void button5_Click(object sender, EventArgs e)
        {
            this.txtRecorrido.Text = string.Empty;
            RecorridoPreOrden(raiz);
        }
        //Metodo con algoritmo del recorrido PreOrden
        void RecorridoPreOrden(Nodo n)
        {
            Visitar(n); //Raiz al principio
            if (n.Izquierda != null) RecorridoPreOrden(n.Izquierda);
            if (n.Derecha != null) RecorridoPreOrden(n.Derecha);
        }
        //Boton para recorrido PostOrden
        private void button6_Click(object sender, EventArgs e)
        {
            this.txtRecorrido.Text = string.Empty;
            RecorridoPostOrden(raiz);
        }
        //Metodo con algoritmo del recorrido PostOrden
        void RecorridoPostOrden(Nodo n)
        {
            if (n.Izquierda != null) RecorridoPostOrden(n.Izquierda);
            if (n.Derecha != null) RecorridoPostOrden(n.Derecha);
            Visitar(n); //Raiz al final
        }
        //Boton para recorrido en Amplitud
        private void button7_Click(object sender, EventArgs e)
        {
            this.txtRecorrido.Text = string.Empty;
            RecorridoAmplitud(raiz);
        }
        //Metodo con algoritmo del recorrido en Amplitud
        void RecorridoAmplitud(Nodo n)
        {
            //Se pasan los datos a una cola y se imprime la cola
            Queue<Nodo> Cola = new Queue<Nodo>();
            Cola.Enqueue(raiz);
            while (Cola.Count > 0)
            {
                Nodo Actual = Cola.Dequeue();
                if (Actual == null)
                    continue;
                Cola.Enqueue(Actual.Izquierda);
                Cola.Enqueue(Actual.Derecha);

                Visitar(Actual);
            } 
        }
      
        //Boton para busqueda del nombre del familiar
        private void button8_Click(object sender, EventArgs e)
        {
            Nodo buscado = new Nodo(txtBusqueda.Text, 0);
            Busqueda(raiz, buscado);
        }
        //Metodo con algoritmo de busqueda del nombre del familiar
        void Busqueda(Nodo n, Nodo buscado)
        {
            if (n != null)
            {
                if (n.Nombre == buscado.Nombre) {
                    buscado = n;
                    MessageBox.Show($"El edad de {buscado.Nombre} es de {buscado.Edad}");
                }
                else {
                    if (n.Izquierda != null) Busqueda(n.Izquierda, buscado);
                    if (n.Derecha != null) Busqueda(n.Derecha, buscado);
                }
                if (buscado.Edad == 0)
                {
                    MessageBox.Show("No se encontraron coincidencias");
                }
                
            }
            else
                MessageBox.Show("Debe escribir algún nombre!");
        }
    }
}
