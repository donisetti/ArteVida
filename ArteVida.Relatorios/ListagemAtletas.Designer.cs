namespace ArteVida.Relatorios
{
    partial class ListagemAtletas
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListagemAtletas));
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            this.Cabecalho = new Telerik.Reporting.PageHeaderSection();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.pictureBox1 = new Telerik.Reporting.PictureBox();
            this.Dados = new Telerik.Reporting.DetailSection();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.txtCodigo = new Telerik.Reporting.TextBox();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.DadosAtleta = new Telerik.Reporting.SqlDataSource();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Cabecalho
            // 
            this.Cabecalho.Height = Telerik.Reporting.Drawing.Unit.Cm(4.5998997688293457D);
            this.Cabecalho.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.pictureBox1,
            this.textBox5,
            this.textBox4,
            this.textBox6});
            this.Cabecalho.Name = "Cabecalho";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.999799728393555D), Telerik.Reporting.Drawing.Unit.Cm(4.5998997688293457D));
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(20D);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            resources.ApplyResources(this.textBox1, "textBox1");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448D), Telerik.Reporting.Drawing.Unit.Cm(0.2000001072883606D));
            this.pictureBox1.MimeType = "image/png";
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.4999995231628418D), Telerik.Reporting.Drawing.Unit.Cm(3.4000003337860107D));
            this.pictureBox1.Value = ((object)(resources.GetObject("pictureBox1.Value")));
            // 
            // Dados
            // 
            this.Dados.Height = Telerik.Reporting.Drawing.Unit.Cm(0.50010037422180176D);
            this.Dados.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox2,
            this.txtCodigo,
            this.textBox3});
            this.Dados.Name = "Dados";
            this.Dados.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.70029878616333D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.19959831237793D), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433D));
            this.textBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            resources.ApplyResources(this.textBox2, "textBox2");
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6999998092651367D), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433D));
            this.txtCodigo.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.txtCodigo.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtCodigo.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            resources.ApplyResources(this.txtCodigo, "txtCodigo");
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(1D);
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // DadosAtleta
            // 
            this.DadosAtleta.ConnectionString = "ArteVida.Relatorios.Properties.Settings.ArteVidaDBAzure";
            this.DadosAtleta.Name = "DadosAtleta";
            this.DadosAtleta.SelectCommand = resources.GetString("DadosAtleta.SelectCommand");
            // 
            // textBox3
            // 
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.9000978469848633D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.0998015403747559D), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433D));
            this.textBox3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            resources.ApplyResources(this.textBox3, "textBox3");
            // 
            // textBox4
            // 
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.9000978469848633D), Telerik.Reporting.Drawing.Unit.Cm(4.0996994972229D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.0998015403747559D), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433D));
            this.textBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.Font.Bold = true;
            this.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            resources.ApplyResources(this.textBox4, "textBox4");
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(4.0996994972229D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6999999284744263D), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433D));
            this.textBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.Font.Bold = true;
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            resources.ApplyResources(this.textBox5, "textBox5");
            // 
            // textBox6
            // 
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.7002003192901611D), Telerik.Reporting.Drawing.Unit.Cm(4.0996994972229D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.19969654083252D), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433D));
            this.textBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox6.Style.Font.Bold = true;
            this.textBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            resources.ApplyResources(this.textBox6, "textBox6");
            // 
            // ListagemAtletas
            // 
            this.Culture = new System.Globalization.CultureInfo("");
            this.DataSource = this.DadosAtleta;
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.Cabecalho,
            this.Dados,
            this.pageFooterSection1});
            this.Name = "ListagemAtletas";
            this.PageSettings.ColumnCount = 1;
            this.PageSettings.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Cm(0D);
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(2D), Telerik.Reporting.Drawing.Unit.Cm(2D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(16D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.PageHeaderSection Cabecalho;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.DetailSection Dados;
        private Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.PictureBox pictureBox1;
        private Telerik.Reporting.SqlDataSource DadosAtleta;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox txtCodigo;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox6;
    }
}