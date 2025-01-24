# Project Title: DataGridView2
 
 Este proyecto consiste en una aplicacion que ingresa y elimina 
 los productos a vender de un DataGrid en el que se establece 
 la cantidad de productos a llevar y el total de la venta.


# Descripcion

 Este proyecto consiste en el desarrollo de una aplicacion que 
 lleva a cabo la venta de productos que inicialmente deben ser
 ingresados al DataGrid o pueden ser Eliminados para luego hacer
 el calculo de los productos dependiendo de la cantidad que lleven
 de cada producto. 
 
 # Actualizacion: 23/01/2025
 # Hora: 23:04

Detalles técnicos del proyecto:
Idioma: C#.NET
Versión del framework: 4.7.2

## Autores

- [@ozzies-code](https://www.github.com/ozzies-code)

## Contribuciones

¡Las contribuciones son siempre bienvenidas!

Consulta `contributing.md` para conocer cómo comenzar.

Por favor, respeta el `código de conducta` de este proyecto.

## Despliegue

Para implementar este proyecto, descargue los archivos del proyecto
del repositorio y el código del proyecto que se encuentra
en el archivo README.md

## 🚀 Acerca de Mi
Soy un apasionado desarrollador fullstack de Venezuela 🇻🇪 y Países Bajos 🇳🇱


🔭 Actualmente estoy trabajando en .NET Framework

🔭 Actualmente estoy trabajando en desarrollo web

🔭 Actualmente estoy trabajando en proyectos de .Console

🔭 Actualmente estoy trabajando en bases de datos .SQL

🌱 Actualmente estoy aprendiendo sobre frameworks, cursos, tutoriales y libros electrónicos

💬 Pregúntame sobre desarrollo de software

📫 Cómo contactarme oswaldojmp.nl@proton.me

👨‍💻 Todos mis proyectos están disponibles en https://developerandtechnologyozziescode.blogspot.com/ (mi sitio web)

📝 Escribo artículos regularmente en Medium.com/Ozzies.Code

    ## 🔗 Links
[![portfolio](https://img.shields.io/badge/my_portfolio-000?style=for-the-badge&logo=ko-fi&logoColor=white)]( https://developerandtechnologyozziescode.blogspot.com)
[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](www.linkedin.com/in/oswaldo-jesús-marín-pagés-ab4499a4)
[![twitter](https://img.shields.io/badge/twitter-1DA1F2?style=for-the-badge&logo=twitter&logoColor=white)](https://twitter.com/ozzies_code)

## Lecciones Aprendidas

- Manejo del DataGrid
- eventos de un Datagrid
- logica de programacion

## image of the Project

![imagen](https://github.com/user-attachments/assets/d3f9d6cb-27b4-40fe-9523-3f36d4d2728c)

## Soporte

Para soporte, email oswaldojmp.nl@proton.me

## Pila de tecnología

**Plataforma:** Visual studio 2022

**Lenguaje:** C#.NET

Codigo del Proyecto:

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView2
{
    public partial class Form1 : Form
    {

        private double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataGridViewColumn codigo = new DataGridViewColumn();
            //codigo.HeaderText = "Codigo";
            //codigo.CellTemplate = new DataGridViewTextBoxCell();
            ////Platillas para Texto

            //codigo.ReadOnly = true;

            //DataGridViewColumn descripcion = new DataGridViewColumn();
            //descripcion.HeaderText = "Descripcion Producto";
            //descripcion.CellTemplate = new DataGridViewTextBoxCell();
            ////Platillas para Texto

            //codigo.ReadOnly = true;

            //dGVProductos.Columns.Add(codigo);
            //dGVProductos.Columns.Add(descripcion);
            ////Se agrega una columna
            ///
           lblTotalProductos.Text = "Cantidad de Productos:";
        }

        private void dGVProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Se agregan los productos al DataGridView con los valores de los TextBox
            //Se calcula el total de la compra
            //Se muestra la cantidad de productos en el Label
            total = 0;

            dGVProductos.Rows.Add(txtCodigo.Text, txtDP.Text, txtPrecio.Text);

            for(int i = 0; i<dGVProductos.Rows.Count-1;i++)
            {
                total = total + double.Parse(dGVProductos.Rows[i].Cells[2].Value.ToString());
            }

            txtTotalCompra.Text = "" + total;
            lblTotalProductos.Text = "Cantidad de Productos:" + "" + (dGVProductos.Rows.Count - 1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            //Se elimina la fila seleccionada
            //Se muestra un mensaje de error si ocurre una excepcion
            try
            {
                dGVProductos.Rows.RemoveAt(dGVProductos.CurrentCell.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
            //Metodo de la coleccion Rows
            //Propiedad RowIndex: Devuelve el indice de la fila.
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Se limpian los TextBox
            txtCodigo.Clear();
            txtDP.Clear();
            txtPrecio.Clear();
            txtTotalCompra.Clear();
        }
    }
}
