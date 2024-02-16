using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Lista di prodotti nel Carrello
            List<_Default.Arredo> carello = Session["Carrello"] as List<_Default.Arredo>;

            // Se la lista non è vuota, la ciclo e creo una card per ognuno di essi
            if (carrelloLista != null)
            {
                foreach (_Default.Arredo item in carello)
                {
                    string card = $@"   <div class='card'>
                                            <img src='{item.Img}' class='card-img-top' alt='{item.Nome}' height='220px' style='object-fit:contain'>
                                            <div class='card-body'>                                                   
                                                <h5 class='card-title'>{item.Nome}</h5>
                                                <p class='d-none'>{item.Descrizione}</p>
                                                <p>{item.Prezzo}</p>
                                                <a href='Default.aspx?idItem={item.idItem}' class='btn btn-danger'>Elimina</a>  
                                            </div>
                                        </div>";
                    carrelloLista.InnerHtml += card;
                }
            }
            else
            {
                // Se la lista di prodotti è vuota
                carrelloLista.InnerHtml = "<h3>Il carrello è vuoto</h3>";
            }
        }

        protected void SvuotaCarrello_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default");
        }
    }
}