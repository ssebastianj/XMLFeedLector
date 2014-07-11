namespace XMLFeedLector
{
    partial class formularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarURLDeFeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releerFeedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoItemsFeed = new System.Windows.Forms.ListView();
            this.columnaTitulo = new System.Windows.Forms.ColumnHeader();
            this.columnaEnlaceFeedBurner = new System.Windows.Forms.ColumnHeader();
            this.columnaFechaPublicacion = new System.Windows.Forms.ColumnHeader();
            this.columnaAutor = new System.Windows.Forms.ColumnHeader();
            this.columnaDescripcion = new System.Windows.Forms.ColumnHeader();
            this.columnaEnlaceOriginal = new System.Windows.Forms.ColumnHeader();
            this.columnaGUID = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enlace1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enlace2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.autoajustarTodasLasColumnasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarListaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.releerFeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textoExcepciones = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ingresarURLDeFeedToolStripMenuItem,
            this.limpiarToolStripMenuItem,
            this.limpiarListaToolStripMenuItem,
            this.releerFeedToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ingresarURLDeFeedToolStripMenuItem
            // 
            this.ingresarURLDeFeedToolStripMenuItem.Name = "ingresarURLDeFeedToolStripMenuItem";
            this.ingresarURLDeFeedToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.ingresarURLDeFeedToolStripMenuItem.Text = "Ingresar URL de feed...";
            this.ingresarURLDeFeedToolStripMenuItem.Click += new System.EventHandler(this.ingresarURLDeFeedToolStripMenuItem_Click);
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(184, 20);
            this.limpiarToolStripMenuItem.Text = "A&utoajustar todas las columnas";
            this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.limpiarToolStripMenuItem_Click);
            // 
            // limpiarListaToolStripMenuItem
            // 
            this.limpiarListaToolStripMenuItem.Name = "limpiarListaToolStripMenuItem";
            this.limpiarListaToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.limpiarListaToolStripMenuItem.Text = "Li&mpiar lista";
            this.limpiarListaToolStripMenuItem.Click += new System.EventHandler(this.limpiarListaToolStripMenuItem_Click);
            // 
            // releerFeedToolStripMenuItem1
            // 
            this.releerFeedToolStripMenuItem1.Name = "releerFeedToolStripMenuItem1";
            this.releerFeedToolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.releerFeedToolStripMenuItem1.Text = "Releer feed";
            this.releerFeedToolStripMenuItem1.Click += new System.EventHandler(this.releerFeedToolStripMenuItem1_Click);
            // 
            // listadoItemsFeed
            // 
            this.listadoItemsFeed.AllowColumnReorder = true;
            this.listadoItemsFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listadoItemsFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listadoItemsFeed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaTitulo,
            this.columnaEnlaceFeedBurner,
            this.columnaFechaPublicacion,
            this.columnaAutor,
            this.columnaDescripcion,
            this.columnaEnlaceOriginal,
            this.columnaGUID});
            this.listadoItemsFeed.FullRowSelect = true;
            this.listadoItemsFeed.GridLines = true;
            this.listadoItemsFeed.Location = new System.Drawing.Point(0, 27);
            this.listadoItemsFeed.Name = "listadoItemsFeed";
            this.listadoItemsFeed.ShowItemToolTips = true;
            this.listadoItemsFeed.Size = new System.Drawing.Size(861, 469);
            this.listadoItemsFeed.TabIndex = 1;
            this.listadoItemsFeed.UseCompatibleStateImageBehavior = false;
            this.listadoItemsFeed.View = System.Windows.Forms.View.Details;
            this.listadoItemsFeed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listadoItemsFeed_MouseClick);
            // 
            // columnaTitulo
            // 
            this.columnaTitulo.Text = "Título";
            this.columnaTitulo.Width = 100;
            // 
            // columnaEnlaceFeedBurner
            // 
            this.columnaEnlaceFeedBurner.Text = "Enlace FeedBurner";
            this.columnaEnlaceFeedBurner.Width = 111;
            // 
            // columnaFechaPublicacion
            // 
            this.columnaFechaPublicacion.Text = "Fecha de publicación";
            this.columnaFechaPublicacion.Width = 139;
            // 
            // columnaAutor
            // 
            this.columnaAutor.Text = "Autor";
            this.columnaAutor.Width = 118;
            // 
            // columnaDescripcion
            // 
            this.columnaDescripcion.Text = "Descripción";
            this.columnaDescripcion.Width = 98;
            // 
            // columnaEnlaceOriginal
            // 
            this.columnaEnlaceOriginal.Text = "Enlace original";
            this.columnaEnlaceOriginal.Width = 102;
            // 
            // columnaGUID
            // 
            this.columnaGUID.Text = "GUID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.toolStripSeparator1,
            this.autoajustarTodasLasColumnasToolStripMenuItem,
            this.limpiarListaToolStripMenuItem1,
            this.releerFeedToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(240, 98);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enlace1ToolStripMenuItem,
            this.enlace2ToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.abrirToolStripMenuItem.Text = "Abrir enlace";
            // 
            // enlace1ToolStripMenuItem
            // 
            this.enlace1ToolStripMenuItem.Name = "enlace1ToolStripMenuItem";
            this.enlace1ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.enlace1ToolStripMenuItem.Text = "Enlace 1";
            this.enlace1ToolStripMenuItem.Click += new System.EventHandler(this.enlace1ToolStripMenuItem_Click);
            // 
            // enlace2ToolStripMenuItem
            // 
            this.enlace2ToolStripMenuItem.Name = "enlace2ToolStripMenuItem";
            this.enlace2ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.enlace2ToolStripMenuItem.Text = "Enlace 2";
            this.enlace2ToolStripMenuItem.Click += new System.EventHandler(this.enlace2ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(236, 6);
            // 
            // autoajustarTodasLasColumnasToolStripMenuItem
            // 
            this.autoajustarTodasLasColumnasToolStripMenuItem.Name = "autoajustarTodasLasColumnasToolStripMenuItem";
            this.autoajustarTodasLasColumnasToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.autoajustarTodasLasColumnasToolStripMenuItem.Text = "Autoajustar todas las columnas";
            this.autoajustarTodasLasColumnasToolStripMenuItem.Click += new System.EventHandler(this.autoajustarTodasLasColumnasToolStripMenuItem_Click);
            // 
            // limpiarListaToolStripMenuItem1
            // 
            this.limpiarListaToolStripMenuItem1.Name = "limpiarListaToolStripMenuItem1";
            this.limpiarListaToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
            this.limpiarListaToolStripMenuItem1.Text = "Limpiar lista";
            this.limpiarListaToolStripMenuItem1.Click += new System.EventHandler(this.limpiarListaToolStripMenuItem1_Click);
            // 
            // releerFeedToolStripMenuItem
            // 
            this.releerFeedToolStripMenuItem.Name = "releerFeedToolStripMenuItem";
            this.releerFeedToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.releerFeedToolStripMenuItem.Text = "Releer feed";
            this.releerFeedToolStripMenuItem.Click += new System.EventHandler(this.releerFeedToolStripMenuItem_Click);
            // 
            // textoExcepciones
            // 
            this.textoExcepciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textoExcepciones.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textoExcepciones.Location = new System.Drawing.Point(0, 502);
            this.textoExcepciones.Multiline = true;
            this.textoExcepciones.Name = "textoExcepciones";
            this.textoExcepciones.ReadOnly = true;
            this.textoExcepciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textoExcepciones.Size = new System.Drawing.Size(861, 52);
            this.textoExcepciones.TabIndex = 2;
            // 
            // formularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 555);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textoExcepciones);
            this.Controls.Add(this.listadoItemsFeed);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(877, 593);
            this.Name = "formularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XMLFeedLector";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListView listadoItemsFeed;
        private System.Windows.Forms.ColumnHeader columnaTitulo;
        private System.Windows.Forms.ColumnHeader columnaEnlaceFeedBurner;
        private System.Windows.Forms.ColumnHeader columnaFechaPublicacion;
        private System.Windows.Forms.ColumnHeader columnaAutor;
        private System.Windows.Forms.ColumnHeader columnaDescripcion;
        private System.Windows.Forms.ColumnHeader columnaEnlaceOriginal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarURLDeFeedToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnaGUID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem enlace1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enlace2ToolStripMenuItem;
        private System.Windows.Forms.TextBox textoExcepciones;
        private System.Windows.Forms.ToolStripMenuItem releerFeedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autoajustarTodasLasColumnasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarListaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem releerFeedToolStripMenuItem;
    }
}

