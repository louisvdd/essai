using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Model;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Labo3
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public  partial class MainPage : Page
    {
        private List<Contact> lstContacts = new List<Contact>()
        {
            new Contact("Charlier", "Isabelle", "isabelle.charlier@henallux.be"),
            new Contact("Scholtes", "Samuel", "samuel.scholtes@henallux.be")
        };

        public MainPage()
        {
            this.InitializeComponent();
            DataContext = lstContacts;
        }
    }
}
