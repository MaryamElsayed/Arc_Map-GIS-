using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesGDB;


namespace millestone_1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        IMapDocument mapDoc; // for accessing map
        IMap map, M, focusMap;
        IActiveView act_map;
        IEnvelope FullExtent;
        int index;
        int len;
        DialogResult d;
        //read map file in the form
        private void Form1_Load(object sender, EventArgs e)   
        {                                                     
            dataGridView1.Visible = false;
            mapDoc = new MapDocumentClass();
            mapDoc.Open(@"C:\Data\Maps\Map1.mxd");
            //get dataframes into list
            for (int i = 0; i < mapDoc.MapCount; i++)
            {
                Load_box.Items.Add(mapDoc.get_Map(i).Name);
            }
        }
        //load Map function
        private void LoadMap_Click(object sender, EventArgs e)
        {
            //Load_box.Items.Clear();
            //get first layer in arcMap
            if (Load_box.SelectedItem == null)
            {
                d = MessageBox.Show("please choose map");
                if (d == DialogResult.Yes)
                {
                    map = mapDoc.get_Map(Load_box.SelectedIndex);
                    //Load_box.Text = mapDoc.get_Map(0).Name;
                    axMapControl1.Map = map;//load map in the mapconrol
                    act_map = (IActiveView)map;//return map if its active
                    //FullExtent = act_map.FullExtent;
                    axMapControl1.ActiveView.Extent = act_map.Extent;
                    axMapControl1.Refresh();
                }
            }
            else
            {
                map = mapDoc.get_Map(Load_box.SelectedIndex);
                //Load_box.Text = mapDoc.get_Map(0).Name;
                axMapControl1.Map = map;
                act_map = (IActiveView)map;
                //FullExtent = act_map.FullExtent;
                axMapControl1.ActiveView.Extent = act_map.Extent;
                axMapControl1.Refresh();
            }



        }
        //Navigate between Maps
        private void Load_box_SelectedIndexChanged(object sender, EventArgs e)
        {

            //M = mapDoc.get_Map(Load_box.SelectedIndex);
            //axMapControl1.Map = M;
            //act_map_ref = (IActiveView)M;
            //axMapControl1.ActiveView.Extent = act_map_ref.Extent;
            //axMapControl1.Refresh();
        }
        //Loading Layers
        private void LoadLayer_Click_1(object sender, EventArgs e)
        {
            //get map selected from listbox
            M = mapDoc.get_Map(Load_box.SelectedIndex);
            //--------------------------------------------------- loading layers -------------------------------------------------------------//
            Layer_box.Items.Clear();
            IEnumLayer numLayer = M.get_Layers();//return all layers
            ILayer layer = numLayer.Next();//return one specific layer
            Layer_box.Text = "...";
            while (layer != null)
            {
                Layer_box.Items.Add(layer.Name);
                targetBox.Items.Add(layer.Name);
                layer.Visible = true;
                layer = numLayer.Next();
            }

        }
        //disable layer
        private void Disable_Click(object sender, EventArgs e)
        {
            index = Layer_box.SelectedIndex;
            ILayer layer_selected = mapDoc.get_Layer(Load_box.SelectedIndex, Layer_box.SelectedIndex);
            //ILayer original = layer_selected;
            layer_selected.Visible = false;
            //original.Name = layer_selected.Name;
            //original.Name = layer_selected.Name;
            string n = layer_selected.Name;
            len = n.Length;
            //Layer_box.Items.Remove(layer_selected.Name);
            // Layer_box.Items.Add(original.Name); 
            layer_selected.Name = layer_selected.Name + "(Disabled)";
            Layer_box.Text = " ";
            Refresh_Layer();
        }
        //enable layer
        private void Enable_Click(object sender, EventArgs e)
        {
            ILayer layerDisabled_selected = mapDoc.get_Layer(Load_box.SelectedIndex, Layer_box.SelectedIndex);
            //index = Layer_box.SelectedIndex;
            if (layerDisabled_selected.Visible == true)
            {

                d = MessageBox.Show("Layer Already Enabled");
            }
            else
            {
                // layerDisabled_selected.Name = original.Name;
                layerDisabled_selected.Visible = true;
                layerDisabled_selected.Name = layerDisabled_selected.Name.Remove(len , 10);//remove disable word
                Layer_box.Text = " "; //clear textbox
                Refresh_Layer();
            }
        }
        //add layer from geodatabase----use workspace
        private void Add_Click(object sender, EventArgs e)
        {
            IMap focusMap = axMapControl1.ActiveView.FocusMap;
            IWorkspaceFactory workSpaceFactory = new AccessWorkspaceFactoryClass();
            IWorkspace workSpace;
            //open connection
            //check which map is selected
            int flag; // 0 for us , 1 for wilson
            if (Load_box.SelectedIndex == 1)
            {
                flag = 1;
            }
            else
            {
                flag = 0;
            }
            if (flag == 1)//select willson
            {
                workSpace = workSpaceFactory.OpenFromFile(@"C:\Data\GIS Databases\Wilson.mdb",0);
            }
            else
            {
                workSpace = workSpaceFactory.OpenFromFile(@"C:\Data\GIS Databases\UnitedStates.mdb",0);
            }

            //access clases
            IFeatureWorkspace feature = (IFeatureWorkspace)workSpace;
            IFeatureClass feat_class;
            //open feature class that will be add on the map 
            //according to map selected
            if (flag == 1)
            {
                feat_class = feature.OpenFeatureClass("City_Centerlines");
            }
            else
            {
                feat_class = feature.OpenFeatureClass("USRoads");
            }
            //initialize layer
            IFeatureLayer feat_layer = new FeatureLayerClass();
            //add data to the new layer
            feat_layer.FeatureClass = feat_class;
            //set name to the added layer
            if (flag == 1)
            {
                feat_layer.Name = "City_Centerlines";
            }
            if (flag == 0)
            {
                feat_layer.Name = "USRoads";
            }
            focusMap.AddLayer(feat_layer);
            //add position of the new layer
            focusMap.MoveLayer(feat_layer, 1);
            Refresh_Layer();

        }
        //remove layer from map
        private void Remove_Click(object sender, EventArgs e)
        {
            focusMap = axMapControl1.ActiveView.FocusMap;
            ILayer focusLayer = focusMap.get_Layer(Layer_box.SelectedIndex);
            focusMap.DeleteLayer(focusLayer);
            Layer_box.Text = " ";
            Refresh_Layer();
        }
        //zooming in
        private void zoomin_Click(object sender, EventArgs e)
        {
            IEnvelope pExtent = act_map.Extent;
            pExtent.Expand(0.5, 0.5, true);
            axMapControl1.Extent = pExtent;
            axMapControl1.Refresh();
        }
        //full extent
        private void fullExtent_Click(object sender, EventArgs e)
        {
            FullExtent = act_map.FullExtent;
            axMapControl1.Extent = FullExtent;
            axMapControl1.Refresh();
        }
        //zooming out
        private void zoomout_Click(object sender, EventArgs e)
        {
            IEnvelope pExtent = act_map.Extent;
            pExtent.Expand(2, 2, true);
            axMapControl1.Extent = pExtent;
            axMapControl1.Refresh();
        }
        //set coordinates x,y
        private void axMapControl1_OnMouseMove(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseMoveEvent e)
        {
            coordinates_lbl.Text = "x: " + e.mapX.ToString() + " " + "y: " + e.mapY.ToString();
        }
        private void Apply_btn_Click(object sender, EventArgs e)
        {
        }
        //refresh function
        private void Refresh_Layer()
        {
            ILayer layer;
            IEnumLayer numLayer;
            Layer_box.Items.Clear();
            numLayer = axMapControl1.ActiveView.FocusMap.get_Layers(null, true);
            layer = numLayer.Next();
            while (layer != null)
            {
                Layer_box.Items.Add(layer.Name);
                layer = numLayer.Next();
            }
            axMapControl1.Refresh();
        }

        private void Layer_box_SelectedIndexChanged(object sender, EventArgs e) //on selecting layer uploading its feilds
        {
            //set label in select query according to selected layer
            string curItem = Layer_box.SelectedItem.ToString();
            label4.Text = "Select * From" + " " + curItem + " " + "Where";
            //load fields of layer
            fields_lst.Items.Clear();
            ILayer layer_selected = mapDoc.get_Layer(Load_box.SelectedIndex, Layer_box.SelectedIndex);
            var lFields = layer_selected as ILayerFields;
            if (lFields != null)//there are feilds exist
            {
                // Add Field Names
                for (int lFieldIndex = 0; lFieldIndex < lFields.FieldCount; lFieldIndex++)
                {
                    var lFieldName = lFields.Field[lFieldIndex].Name;

                    fields_lst.Items.Add("[" + lFieldName + "]");
                }
            }
        }

        //on selecting on item in filed listbox add it to the where clause
        private void fields_lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_txt.Text += fields_lst.SelectedItem.ToString();
        }

        //select buttons in query builder(clear where claus)
        private void clear_Click(object sender, EventArgs e)
        {
            select_txt.Clear();
        }
        //--------------------------------------------------------------------select by attribute---------------------------------------------------------------------------------//
        private void Apply_Click(object sender, EventArgs e)
        {
            focusMap = axMapControl1.ActiveView.FocusMap;
            ILayer focusLayer = focusMap.get_Layer(Layer_box.SelectedIndex);
            IFeatureLayer layer_selected = (IFeatureLayer)focusLayer;
            //Query Data
           //IFeatureCursor featureCursor;
            IQueryFilter queryFilter = new QueryFilterClass();
            queryFilter.WhereClause = select_txt.Text;
            //selection
            IFeatureSelection featureSelection = layer_selected as IFeatureSelection;
            //check on method (create ,remove,add)
            String method = method_box.SelectedItem.ToString();

            if (method.Equals("Create new selection"))
            {
                map = mapDoc.get_Map(Load_box.SelectedIndex);
                map.ClearSelection();
                axMapControl1.Refresh();
                featureSelection.SelectFeatures(queryFilter, esriSelectionResultEnum.esriSelectionResultNew, false);
            }
            if (method.Equals("Add to current selection"))
            {
                featureSelection.SelectFeatures(queryFilter, esriSelectionResultEnum.esriSelectionResultAdd, false);
            }
            if (method.Equals("Remove from current selection"))
            {
                featureSelection.SelectFeatures(queryFilter, esriSelectionResultEnum.esriSelectionResultSubtract, false);
            }

            axMapControl1.Refresh();

        }
        //get unigue values for each field
        private void getUnique_Click_1(object sender, EventArgs e)
        {
            uniqueValues_lst.Items.Clear();
            //create render
            IUniqueValueRenderer uniqueRender = new UniqueValueRendererClass();
            uniqueRender.FieldCount = 1;
            String fieldName = fields_lst.SelectedItem.ToString();
            string trimedFieldName = fieldName.TrimStart('[').TrimEnd(']');
            uniqueRender.set_Field(0, trimedFieldName);
            //get values of selected field
            ILayer geoLayer = mapDoc.get_Layer(Load_box.SelectedIndex, Layer_box.SelectedIndex);//get layer
            int fieldIndex;
            IFeatureLayer featLayer = geoLayer as IFeatureLayer;
            fieldIndex = featLayer.FeatureClass.FindField(trimedFieldName);//get field index
            IFeatureCursor fCursor;
            IQueryFilter qFilter;
            qFilter = new QueryFilterClass();
            qFilter.SubFields = trimedFieldName;
            fCursor = featLayer.FeatureClass.Search(qFilter, true);
            //put values in the listbox
            IFeature feat = fCursor.NextFeature();
            while (feat != null)
            {

                if (feat.get_Value(fieldIndex) is string)
                {
                    String res = "'" + feat.get_Value(fieldIndex) + "'";
                    if (uniqueValues_lst.Items.Contains(res))
                    {
                        feat = fCursor.NextFeature();
                        continue;
                    }
                    else
                    {
                        uniqueValues_lst.Items.Add(res);
                        feat = fCursor.NextFeature();
                    }

                }
                else if (feat.get_Value(fieldIndex) is IESRIShape)
                {
                    string shape = feat.Shape.GeometryType.ToString();

                    uniqueValues_lst.Items.Add(shape.Remove(0,12));
                    feat = fCursor.NextFeature();
                }
                else
                {

                    uniqueValues_lst.Items.Add(feat.get_Value(fieldIndex));
                    feat = fCursor.NextFeature();
                }

            }
        }

        private void equal_Click_1(object sender, EventArgs e)
        {
            select_txt.Text += "=";
        }

        private void notEqual_Click(object sender, EventArgs e)
        {
            select_txt.Text += "<>";
        }

        private void like_Click(object sender, EventArgs e)
        {
            select_txt.Text += "LIKE";
        }

        private void greaterThan_Click(object sender, EventArgs e)
        {
            select_txt.Text += ">";
        }

        private void greaterThan_orEqual_Click(object sender, EventArgs e)
        {
            select_txt.Text += ">=";
        }

        private void and_Click(object sender, EventArgs e)
        {
            select_txt.Text += "AND";
        }

        private void lessThan_Click(object sender, EventArgs e)
        {
            select_txt.Text += "<";
        }

        private void lessThan_orEqual_Click(object sender, EventArgs e)
        {
            select_txt.Text += "<=";
        }

        private void or_Click(object sender, EventArgs e)
        {
            select_txt.Text += "OR";
        }

        private void Is_Click(object sender, EventArgs e)
        {
            select_txt.Text += "IS";
        }

        private void brackets_Click(object sender, EventArgs e)
        {
            select_txt.Text += "()";
        }

        private void not_Click(object sender, EventArgs e)
        {
            select_txt.Text += "NOT";
        }
        //selecting uniquevalue
        private void uniqueValues_lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_txt.Text += uniqueValues_lst.SelectedItem.ToString();
        }
        private void Apply_location_filter_Click(object sender, EventArgs e)
        {
            //select the features from source layer based on where clause in selection by attribute
            ILayer layer_selected = focusMap.get_Layer(Layer_box.SelectedIndex);
            IFeatureLayer sourceLayer = (IFeatureLayer)layer_selected;
            IQueryFilter queryFilter = new QueryFilterClass();
            queryFilter.WhereClause = select_txt.Text;
            IFeatureCursor featureCursor;
            featureCursor = sourceLayer.FeatureClass.Search(queryFilter, true);
            axMapControl1.Refresh();
            IFeatureSelection fSelection;
            //select the featuer from target layer that are in the selected feature from attribute query
            IFeature feat = featureCursor.NextFeature();
            ISpatialFilter sfilter = new SpatialFilterClass();//for selecting by location
            sfilter.Geometry = feat.Shape; // save ploygon selected from source layer
            String method = locationMethod.SelectedItem.ToString();
            if (method.Equals("intersect the source layer feature"))
            {
                sfilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIntersects;
            }
            if (method.Equals("within the source layer feature"))
            {
                sfilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelWithin;
            }
            if (method.Equals("contain the source layer feature"))
            {
                sfilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelContains;
            }
            if (method.Equals("touch the boundary of the source layer feature"))
            {
                sfilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelTouches;

            }
            ILayer layer2_selected = focusMap.get_Layer(targetBox.SelectedIndex);
            IFeatureLayer targetLayer = (IFeatureLayer)layer2_selected;
            //get the target layer 
            fSelection = targetLayer as IFeatureSelection;
            //select feature in first regin then loop on the other regions and add on the selection
            fSelection.SelectFeatures(sfilter, esriSelectionResultEnum.esriSelectionResultNew, false);
            feat = featureCursor.NextFeature();
            while (feat != null)
            {
                sfilter.Geometry = feat.Shape;
                fSelection.SelectFeatures(sfilter, esriSelectionResultEnum.esriSelectionResultAdd, false);
                feat = featureCursor.NextFeature();
            }
            axMapControl1.Refresh();

        }
  //------------------------------clear selection on map-----------------------//
        private void clear_Selection_Click(object sender, EventArgs e)
        {
            map = mapDoc.get_Map(Load_box.SelectedIndex);
            map.ClearSelection();
            axMapControl1.Refresh();
        }

        private void attribute_table_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            //get layer
            IFeatureLayer pFeatureLayer = (IFeatureLayer)axMapControl1.Map.get_Layer(Layer_box.SelectedIndex);
            //get all fields in the layer and put it in cursour
            IFeatureCursor pFeatureCursor = pFeatureLayer.Search(null, true);
            IFeature pFeature = pFeatureCursor.NextFeature();
            //loop on fields (coulmn :field name ,row:field value)
            //fill coulmns with fields names
            for (int i = 0; i < pFeature.Fields.FieldCount; i++)
            {
                dataGridView1.ColumnCount = pFeature.Fields.FieldCount;
                dataGridView1.Columns[i].Name = pFeature.Fields.get_Field(i).Name;
               
            }
            //fill rows
            string[] row;
            while (pFeature != null)
            {
                row = new string[pFeature.Fields.FieldCount];
                for (int j = 0; j < pFeature.Fields.FieldCount; j++)
                {
                    if (pFeature.Value[j].ToString().Equals("System.__ComObject"))
                    {
                        string shape = pFeature.Shape.GeometryType.ToString();
                        row.SetValue(shape.Remove(0, 12), j);
                    }
                    else
                    {
                        row.SetValue(pFeature.Value[j].ToString(), j);
                    }
                }
                dataGridView1.Rows.Add(row);
                pFeature = pFeatureCursor.NextFeature();
            }
            dataGridView1.Visible = true;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }
        //definition query
        private void Apply_btn_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Where_txt.Text))
            {
                d = MessageBox.Show("please enter the query");
            }
            focusMap = axMapControl1.ActiveView.FocusMap;
            ILayer focusLayer = focusMap.get_Layer(Layer_box.SelectedIndex);
            IFeatureLayerDefinition feat_definition = (IFeatureLayerDefinition)focusLayer;
            feat_definition.DefinitionExpression = Where_txt.Text;
            axMapControl1.ActiveView.Refresh();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void method_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

