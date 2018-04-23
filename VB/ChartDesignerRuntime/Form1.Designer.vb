Namespace ChartDesignerRuntime
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.btnRunDesigner = New DevExpress.XtraBars.BarButtonItem()
            Me.rpHome = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.productsTableAdapter1 = New ChartDesignerRuntime.nwindDataSetTableAdapters.ProductsTableAdapter()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet1 = New ChartDesignerRuntime.nwindDataSet()
            Me.nwindDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New ChartDesignerRuntime.nwindDataSet()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.btnRunDesigner})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 2
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.rpHome})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl1.Size = New System.Drawing.Size(1264, 147)
            ' 
            ' btnRunDesigner
            ' 
            Me.btnRunDesigner.Caption = "Run Chart Designer"
            Me.btnRunDesigner.Glyph = (DirectCast(resources.GetObject("btnRunDesigner.Glyph"), System.Drawing.Image))
            Me.btnRunDesigner.Id = 1
            Me.btnRunDesigner.LargeGlyph = (DirectCast(resources.GetObject("btnRunDesigner.LargeGlyph"), System.Drawing.Image))
            Me.btnRunDesigner.Name = "btnRunDesigner"
            ' 
            ' rpHome
            ' 
            Me.rpHome.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
            Me.rpHome.Name = "rpHome"
            Me.rpHome.Text = "Home"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.btnRunDesigner)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Chart Designer"
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.DataAdapter = Me.productsTableAdapter1
            Me.chartControl1.DataSource = Me.bindingSource1
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.WholeRange.AlwaysShowZeroLevel = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = True
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartControl1.Location = New System.Drawing.Point(0, 147)
            Me.chartControl1.Name = "chartControl1"
            series1.ArgumentDataMember = "ProductName"
            series1.Name = "Product Unit Price"
            series1.ValueDataMembersSerializable = "UnitPrice"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.chartControl1.Size = New System.Drawing.Size(1264, 534)
            Me.chartControl1.TabIndex = 1
            chartTitle1.Text = "Product Prices Comparison"
            Me.chartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
            ' 
            ' productsTableAdapter1
            ' 
            Me.productsTableAdapter1.ClearBeforeFill = True
            ' 
            ' bindingSource1
            ' 
            Me.bindingSource1.DataMember = "Products"
            Me.bindingSource1.DataSource = Me.nwindDataSet1
            Me.bindingSource1.Sort = ""
            ' 
            ' nwindDataSet1
            ' 
            Me.nwindDataSet1.DataSetName = "nwindDataSet"
            Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' nwindDataSetBindingSource
            ' 
            Me.nwindDataSetBindingSource.DataSource = Me.nwindDataSet
            Me.nwindDataSetBindingSource.Position = 0
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1264, 681)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "Form1"
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private WithEvents btnRunDesigner As DevExpress.XtraBars.BarButtonItem
        Private rpHome As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private chartControl1 As DevExpress.XtraCharts.ChartControl
        Private nwindDataSetBindingSource As System.Windows.Forms.BindingSource
        Private nwindDataSet As nwindDataSet
        Private productsTableAdapter1 As nwindDataSetTableAdapters.ProductsTableAdapter
        Private bindingSource1 As System.Windows.Forms.BindingSource
        Private nwindDataSet1 As nwindDataSet
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel

    End Class
End Namespace

