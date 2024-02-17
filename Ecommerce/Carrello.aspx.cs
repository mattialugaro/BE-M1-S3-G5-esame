using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Ecommerce._Default;

namespace Ecommerce
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string op = Request.QueryString["op"];

            if (string.IsNullOrEmpty(op))
            {
                // Lista di prodotti nel Carrello
                List<Arredo> carrello = Session["Carrello"] as List<Arredo>;

                // Se la lista non è vuota, la ciclo e creo una card per ognuno di essi
                if (carrello != null && carrello.Count > 0)
                {
                    foreach (_Default.Arredo item in carrello)
                    {
                        string card = $@"   <div class='card'>
                                            <img src='{item.Img}' class='card-img-top' alt='{item.Nome}' height='220px' style='object-fit:contain'>
                                            <div class='card-body'>                                                   
                                                <h5 class='card-title'>{item.Nome}</h5>
                                                <p class='d-none'>{item.Descrizione}</p>
                                                <p>{item.Prezzo}</p>
                                                <a href='Carrello.aspx?idItem={item.idItem}&op=deleteItem' class='btn btn-danger'>Elimina</a>  
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
            else
            {
                // gestire diverse operazioni (op) dando per scontato che il carrello esista
                List<Arredo> carrello = Session["Carrello"] as List<Arredo>;
                
                switch (op)
                {
                    case "deleteItem":
                        string idItemValue = Request.QueryString["idItem"];
                        int idItem = int.Parse(idItemValue);
                        Arredo arredoToRemove = carrello.Find(a => a.idItem == idItem);
                        carrello.Remove(arredoToRemove);
                        Response.Redirect("Carrello");
                        break;
                }
            }
        }

        protected void SvuotaCarrello_Click(object sender, EventArgs e)
        {
            List<Arredo> carrello = Session["Carrello"] as List<Arredo>;
            if (carrello != null)
            {
                //  Session["Carrello"] =  new List<Arredo>();
                carrello.Clear();
            }
            Response.Redirect("Default");
        }

        protected void EliminaArredo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default");
        }
    }
}