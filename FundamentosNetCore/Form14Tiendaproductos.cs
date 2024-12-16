using System;
using System.Linq;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form14Tiendaproductos : Form
    {
        public Form14Tiendaproductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text.Trim();

            if (string.IsNullOrEmpty(producto))
            {
                //MessageBox.Show("Por favor ingrese un producto.");
                return;
            }

            string productoLower = producto.ToLower();
            bool productoExiste = this.lstTienda.Items.Cast<string>().Any(item => item.ToLower() == productoLower);

            if (productoExiste)
            {
                //MessageBox.Show("El producto ya existe en la lista.");
                this.lstTienda.SelectedItem = producto;
                return;
            }

            this.lstTienda.Items.Add(producto);
            this.txtProducto.Clear(); 
            this.txtProducto.Focus(); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numSeleccionados = this.lstTienda.SelectedIndices.Count;
            if (numSeleccionados == 0)
            {
                //MessageBox.Show("Por favor, seleccione al menos un producto de la lista.");
                return;
            }

            for (int i = numSeleccionados - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            if (this.lstTienda.SelectedItems.Count == 0)
            {
                //MessageBox.Show("Por favor, seleccione al menos un producto de la lista.");
                return;
            }

            foreach (var item in this.lstTienda.SelectedItems)
            {
                string itemLower = item.ToString().ToLower();
                bool existeEnAlmacen = this.lstAlmacen.Items.Cast<string>().Any(existingItem => existingItem.ToLower() == itemLower);

                if (!existeEnAlmacen)
                {
                    this.lstAlmacen.Items.Add(item); 
                }
            }

            MessageBox.Show("Productos seleccionados enviados a Almacén.");
        }
        private void btnEnviarTodo_Click(object sender, EventArgs e)
        {
            foreach (var item in this.lstTienda.Items)
            {
                string itemLower = item.ToString().ToLower();
                bool existeEnAlmacen = this.lstAlmacen.Items.Cast<string>().Any(existingItem => existingItem.ToLower() == itemLower);

                if (!existeEnAlmacen)
                {
                    this.lstAlmacen.Items.Add(item); 
                }
            }

            //MessageBox.Show("Todos los productos enviados a Almacén.");
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedItem == null)
            {
                //MessageBox.Show("Por favor, seleccione un producto para mover.");
                return;
            }

            int index = this.lstAlmacen.SelectedIndex;

            if (index > 0) 
            {
                object selectedItem = this.lstAlmacen.SelectedItem;
                this.lstAlmacen.Items.RemoveAt(index);
                this.lstAlmacen.Items.Insert(index - 1, selectedItem);
                this.lstAlmacen.SelectedIndex = index - 1; 
            }
            else
            {
                //MessageBox.Show("Este producto ya está en la primera posición.");
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedItem == null)
            {
                //MessageBox.Show("Por favor, seleccione un producto para mover.");
                return;
            }

            int index = this.lstAlmacen.SelectedIndex;

            if (index < this.lstAlmacen.Items.Count - 1)
            {
                object selectedItem = this.lstAlmacen.SelectedItem;
                this.lstAlmacen.Items.RemoveAt(index);
                this.lstAlmacen.Items.Insert(index + 1, selectedItem); 
                this.lstAlmacen.SelectedIndex = index + 1;
            }
            else
            {
                //MessageBox.Show("Este producto ya está en la última posición.");
            }
        }
    }
}
