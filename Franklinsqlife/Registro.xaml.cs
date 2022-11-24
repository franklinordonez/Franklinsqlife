using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Franklinsqlife.Modelos;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Franklinsqlife
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        private SQLiteAsyncConnection con;
        public Registro()
        {
            InitializeComponent();
            con = DependencyService.Get<Database>().GetConnection();
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var datosRegistro = new Estudiante { Nombre = txtNombre.Text, Usuario = txtUsuario.Text, Contrasena = txtContrasena.Text};
                con.InsertAsync(datosRegistro);
                txtUsuario.Text = "";
                txtNombre.Text = "";
                txtContrasena.Text = "";

            }
            catch (Exception ex)
            {

                DisplayAlert("Mensaje", ex.Message, "cerrar");
            }
        }
    }
}