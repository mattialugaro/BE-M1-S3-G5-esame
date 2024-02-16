using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Ecommerce.Global;

namespace Ecommerce
{
    public partial class _Default : Page
    {
        public class Arredo // creazione della classe
        {
            public int idItem {  get; set; }
            public string Nome { get; set; }
            public string Img { get; set; }
            public double Prezzo { get; set; }
            public string Descrizione {  get; set; }



            public Arredo(int id, string nome, string img, double prezzo, string descrizione) // istanza della classe
            {
                idItem = id;
                Nome = nome;
                Img = img;
                Prezzo = prezzo;
                Descrizione = descrizione;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Catalogo"] = new List<Arredo> // al caricamento della pagina creo gli oggetti Arredo
                    {
                        new Arredo (1, "Libreria in Rovere Rustico", "content/img/libreria.jpeg", 400.00, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Reiciendis, at."),
                        new Arredo (2, "Cubi da Parete Rovere Rustico", "content/img/libreriapic.jpg", 60.00, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Reiciendis, at."),
                        new Arredo (3, "Sedia Imbottita Giallo Senape", "content/img/sedia2.jpg", 70.00, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Reiciendis, at."),
                        new Arredo (4, "Credenza in Noce", "content/img/credenza.jpg", 940.00, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Reiciendis, at."),
                        new Arredo (5, "Mobile Porta Tv Rovere Rustico", "content/img/mobile.jpeg", 180.00, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Reiciendis, at."),
                        new Arredo (6, "Poltrona Egg Chair", "content/img/sedia.jpg", 600.00, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Reiciendis, at."),

                    };
            if (!IsPostBack)
            {
                List<Arredo> catalogo = Session["Catalogo"] as List<Arredo>;

                foreach (Arredo item in catalogo) // creo con un cliclo gli le card con le info prima scritte
                {
                    string card = $@"   <div class='card'>
                                            <img src='{item.Img}' class='card-img-top' alt='{item.Nome}' height='420px' style='object-fit:contain'>
                                            <div class='card-body d-flex justify-content-between align-items-center'>                                                   
                                                <h5 class='card-title'>{item.Nome}</h5>
                                                <p class='d-none'>{item.Descrizione}</p>
                                                <p class='d-none'>{item.Prezzo}</p>
                                                <a href='Dettaglio.aspx?idItem={item.idItem}' class='btn btn-primary'>Dettagli</a>  
                                            </div>
                                        </div>";
                    container.InnerHtml += card;
                }

            }


        }
    }
}