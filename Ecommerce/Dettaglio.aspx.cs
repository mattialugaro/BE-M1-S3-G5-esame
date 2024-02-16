using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Ecommerce._Default;

namespace Ecommerce
{
    public partial class Dettaglio : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // SE nel carrello c'e' gia' qualcosa lo aggiungo ELSE lo creo 
                if (Request.QueryString["idItem"] != null)
                {
                    // Controlla se c'è il parametro nella QueryString, Ottiene ID dall'URl e verifica che sia un numero valido
                    int idItem;
                    if (int.TryParse(Request.QueryString["idItem"], out idItem))
                    {
                        List<Arredo> arredoList = Session["Catalogo"] as List<Arredo>;

                        // Cerca il prodotto nella lista
                        Arredo item = arredoList.FirstOrDefault(p => p.idItem == idItem);

                        if (item != null)
                        {
                            // assegno i valori per visualizzarli nella pagina dettaglio
                            itemNome.InnerText = item.Nome;
                            itemDescrizione.InnerText = item.Descrizione;
                            itemPrezzo.InnerText = item.Prezzo.ToString();
                            itemImg.ImageUrl = item.Img;

                        }
                        else
                        {
                            // Caso in cui non viene trovato l'ID arredo
                            itemNome.InnerText = "Non è presente un prodotto con id " + idItem;
                            
                        }
                    }
                    else
                    {
                        // Caso in cui non sia valido l'ID arredo
                        itemNome.InnerHtml = "ID non valido";
                    }
                }
                else
                {
                    // Unione dei casi precedenti
                    itemNome.InnerHtml = "ID non valido o non presente";
                }
            }
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            Response.Write("Aggiunto al Carrello");
            if (Session["Carrello"] == null)
            {
                // Controlla se c'è il parametro nella QueryString, Ottiene ID dall'URl e verifica che sia un numero valido
                if (Request.QueryString["idItem"] != null)
                {
                    int itemId;

                    if (int.TryParse(Request.QueryString["idItem"], out itemId))
                    {
                        Session["Carrello"] = new List<Arredo>
                        {
                            new Arredo(itemId, itemNome.InnerText, itemImg.ImageUrl, Convert.ToDouble(itemPrezzo.InnerText), itemDescrizione.InnerText ),
                        };
                    }
                }
                else
                {
                    // Caso in cui non sia valido l'ID arredo
                    itemNome.InnerHtml = "ID non valido";
                }
            }
            else
            {
                List<Arredo> carrello = Session["Carrello"] as List<Arredo>;
                // Controlla se c'è il parametro nella QueryString, Ottiene ID dall'URl e verifica che sia un numero valido
                if (Request.QueryString["idItem"] != null)
                {
                    int itemId;

                    if (int.TryParse(Request.QueryString["idItem"], out itemId))
                    {
                        // Aggiungo il prodotto al carrello
                        carrello.Add(new Arredo(itemId, itemNome.InnerText, itemImg.ImageUrl, Convert.ToDouble(itemPrezzo.InnerText), itemDescrizione.InnerText));
                    }
                }
                else
                {
                    // Caso in cui non sia valido l'ID arredo
                    itemNome.InnerHtml = "ID non valido";
                }
            }
            Response.Redirect("Carrello");
        }
    }
}