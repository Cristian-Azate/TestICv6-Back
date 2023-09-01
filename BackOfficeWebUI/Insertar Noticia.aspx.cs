using BackOfficeWebUI.Logica;
using NoticiasBusinessEntities.NoticiaEntitie;
using NoticiasService.Noticia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;
using Unity;
using System.Web.Http.Results;

namespace BackOfficeWebUI
{
    public partial class Insertar_Noticia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendario.SelectedDate = DateTime.Now;
        }

        protected void Button_Insertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox_Titulo.Text) || string.IsNullOrEmpty(TextArea_Cuerpo.Value))
            {
                MensajeOperacion(false, "El titulo y cuerpo de la noticia son campos OBLIGATORIOS");
            }
            else
            {
                var container = (UnityContainer)Application["Container"];
                var noticia = container.Resolve<Noticia>();

                bool result = noticia.InsertarNoticia(TextBox_Titulo.Text, TextArea_Cuerpo.Value.ToString(), Calendario.SelectedDate, ImagePreview);
                if (result == true)
                    MensajeOperacion(result, "NOTICIA REGISTRADA");
                else
                    MensajeOperacion(result, "ERROR AL REGISTRAR NOTICIA");
            }               
        }

        protected void Visualizar_Click(object sender, EventArgs e)
        {
            if (FileUploadImage.HasFile)
            {
                int Tamaño = FileUploadImage.PostedFile.ContentLength;
                byte[] ImagenOriginal = new byte[Tamaño];

                FileUploadImage.PostedFile.InputStream.Read(ImagenOriginal, 0, Tamaño);

                Bitmap ImagenOriginalBinaria = new Bitmap(FileUploadImage.PostedFile.InputStream);
                string ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(ImagenOriginal);

                ImagePreview.ImageUrl = ImagenDataURL64;
            }
            else
            {
                MensajeOperacion(false, "Seleccione una imagen para visualizar");
            }
        }

        protected void MensajeOperacion(bool operacion_exitosa,string message)
        {
            string script = $"alert('{message}');";
            ScriptManager.RegisterStartupScript(this, GetType(), "OperacionCompleta", script, true);
            if (operacion_exitosa == true)
               LimpiarForm();
              
        }

        protected void LimpiarForm()
        {
            TextBox_Titulo.Text = "";
            TextArea_Cuerpo.Value = null;
            Calendario.SelectedDate = DateTime.Now;
            ImagePreview.ImageUrl = null;
            FileUploadImage.Attributes.Clear();
        }

      
    }
}