using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XMLFeedLector
{
    /// <summary>
    /// 
    /// </summary>
    /// 07/03/2010 by Sebastián J. Seba
    public partial class formularioPrincipal : Form
    {
        string URLFeed = "";
        XmlDocument feedXML = new XmlDocument();

        /// <summary>
        /// Initializes a new instance of the <see cref="formularioPrincipal"/> class.
        /// </summary>
        public formularioPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the salirToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the Click event of the limpiarToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoAjustarTodasLasColumnas();
        }

        /// <summary>
        /// Handles the Click event of the limpiarListaToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void limpiarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarListado();
        }

        /// <summary>
        /// Ingresars the URL de feed tool strip menu item_ click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        /// 07/03/2010 by Sebastian
        private void ingresarURLDeFeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            URLFeed = Microsoft.VisualBasic.Interaction.InputBox("Ingresar URL de feed a procesar", "URL de feed", "http://www.ingeniemos.com.ar/feed/", this.Left + 200, this.Top + 200).Trim();
            
            procesarFeed(URLFeed);
        }

        /// <summary>
        /// Listadoes the items feed_ mouse click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        /// 07/03/2010 by Sebastian
        private void listadoItemsFeed_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                enlace1ToolStripMenuItem.Text = listadoItemsFeed.HitTest(e.Location).Item.SubItems[1].Text;
                enlace2ToolStripMenuItem.Text = listadoItemsFeed.HitTest(e.Location).Item.SubItems[5].Text;
                contextMenuStrip1.Show(this.listadoItemsFeed,e.Location);
            }
        }

        /// <summary>
        /// Enlace1s the tool strip menu item_ click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        /// 07/03/2010 by Sebastian
        private void enlace1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(enlace1ToolStripMenuItem.Text);
        }

        /// <summary>
        /// Enlace2s the tool strip menu item_ click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        /// 07/03/2010 by Sebastian
        private void enlace2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(enlace2ToolStripMenuItem.Text);
        }

        /// <summary>
        /// Autoajustars the todas las columnas tool strip menu item_ click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        /// 07/03/2010 by Sebastian
        private void autoajustarTodasLasColumnasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoAjustarTodasLasColumnas();
        }

        /// <summary>
        /// Autoes the ajustar todas las columnas.
        /// </summary>
        /// 07/03/2010 by Sebastian
        private void autoAjustarTodasLasColumnas()
        {
            listadoItemsFeed.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /// <summary>
        /// Limpiars the listado.
        /// </summary>
        /// 07/03/2010 by Sebastian
        private void limpiarListado()
        {
            listadoItemsFeed.Items.Clear();
        }

        /// <summary>
        /// Limpiars the lista tool strip menu item1_ click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        /// 07/03/2010 by Sebastian
        private void limpiarListaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            limpiarListado();
        }

        /// <summary>
        /// Releers the feed tool strip menu item1_ click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        /// 07/03/2010 by Sebastian
        private void releerFeedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                limpiarListado();
                procesarFeed(URLFeed);
         }

        /// <summary>
        /// Procesars the feed.
        /// </summary>
        /// <param name="urlFeed">The URL feed.</param>
        /// 07/03/2010 by Sebastian
        private void procesarFeed(string urlFeed)
        {
            try
            {

                feedXML.Load(URLFeed);

                XmlNodeList channelFeed = feedXML.GetElementsByTagName("channel");
                XmlNodeList itemFeed = ((XmlElement)channelFeed[0]).GetElementsByTagName("item");

                foreach (XmlElement Nodo in itemFeed)
                {

                    ListViewItem feedItem = new ListViewItem();

                    XmlNodeList tituloFeed = Nodo.GetElementsByTagName("title");
                    feedItem.Text = tituloFeed[0].InnerText;

                    XmlNodeList enlaceFeed = Nodo.GetElementsByTagName("link");
                    feedItem.SubItems.Add(enlaceFeed[0].InnerText);

                    XmlNodeList fechaPublicacionFeed = Nodo.GetElementsByTagName("pubDate");
                    feedItem.SubItems.Add(fechaPublicacionFeed[0].InnerText);

                    XmlNodeList autorFeed = Nodo.GetElementsByTagName("dc:creator");
                    feedItem.SubItems.Add(autorFeed[0].InnerText);

                    XmlNodeList descripcionFeed = Nodo.GetElementsByTagName("description");
                    feedItem.SubItems.Add(descripcionFeed[0].InnerText);

                    XmlNodeList enlaceOriginalFeed = Nodo.GetElementsByTagName("feedburner:origLink");
                                                       
                    if (enlaceOriginalFeed.Count != 0)
                    {
                        feedItem.SubItems.Add(enlaceOriginalFeed[0].InnerText);
                    }
                    else
                    {
                        feedItem.SubItems.Add("N/A");
                        textoExcepciones.Text += "Puede que este feed no sea generado por FeedBurner \r\n";
                    }
                                        
                    listadoItemsFeed.Items.Add(feedItem);
                   
                }
            }
            catch (XmlException xml)
            {
                textoExcepciones.Text += xml.Message + "\r\n";
            }
            catch (NullReferenceException)
            {
                textoExcepciones.Text += "Refencia nula \r\n";
            }
            catch (ArgumentException)
            {
                textoExcepciones.Text += "Error de argumento \r\n";
            }
           }

        /// <summary>
        /// Releers the feed tool strip menu item_ click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        /// 07/03/2010 by Sebastian
        private void releerFeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarListado();
            procesarFeed(URLFeed);
        }
   }
}