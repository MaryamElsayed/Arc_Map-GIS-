namespace millestone_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoadMap = new System.Windows.Forms.Button();
            this.LoadLayer = new System.Windows.Forms.Button();
            this.Disable = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Enable = new System.Windows.Forms.Button();
            this.zoomin = new System.Windows.Forms.Button();
            this.zoomout = new System.Windows.Forms.Button();
            this.fullExtent = new System.Windows.Forms.Button();
            this.coordinates_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Load_box = new System.Windows.Forms.ComboBox();
            this.Layer_box = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Apply_btn = new System.Windows.Forms.Button();
            this.Where_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.attribute_table = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Apply_location_filter = new System.Windows.Forms.Button();
            this.locationMethod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.targetBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clear_Selection = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.method_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fields_lst = new System.Windows.Forms.ListBox();
            this.equal = new System.Windows.Forms.Button();
            this.greaterThan = new System.Windows.Forms.Button();
            this.lessThan = new System.Windows.Forms.Button();
            this.or = new System.Windows.Forms.Button();
            this.notEqual = new System.Windows.Forms.Button();
            this.greaterThan_orEqual = new System.Windows.Forms.Button();
            this.and = new System.Windows.Forms.Button();
            this.lessThan_orEqual = new System.Windows.Forms.Button();
            this.like = new System.Windows.Forms.Button();
            this.Is = new System.Windows.Forms.Button();
            this.brackets = new System.Windows.Forms.Button();
            this.not = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.select_txt = new System.Windows.Forms.TextBox();
            this.uniqueValues_lst = new System.Windows.Forms.ListBox();
            this.getUnique = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Close = new System.Windows.Forms.Button();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadMap
            // 
            this.LoadMap.Location = new System.Drawing.Point(22, 12);
            this.LoadMap.Name = "LoadMap";
            this.LoadMap.Size = new System.Drawing.Size(209, 23);
            this.LoadMap.TabIndex = 1;
            this.LoadMap.Text = "Load Map";
            this.LoadMap.UseVisualStyleBackColor = true;
            this.LoadMap.Click += new System.EventHandler(this.LoadMap_Click);
            // 
            // LoadLayer
            // 
            this.LoadLayer.Location = new System.Drawing.Point(19, 51);
            this.LoadLayer.Name = "LoadLayer";
            this.LoadLayer.Size = new System.Drawing.Size(212, 26);
            this.LoadLayer.TabIndex = 3;
            this.LoadLayer.Text = "Feature Layers";
            this.LoadLayer.UseVisualStyleBackColor = true;
            this.LoadLayer.Click += new System.EventHandler(this.LoadLayer_Click_1);
            // 
            // Disable
            // 
            this.Disable.Location = new System.Drawing.Point(109, 59);
            this.Disable.Name = "Disable";
            this.Disable.Size = new System.Drawing.Size(120, 28);
            this.Disable.TabIndex = 5;
            this.Disable.Text = "Disable Layer";
            this.Disable.UseVisualStyleBackColor = true;
            this.Disable.Click += new System.EventHandler(this.Disable_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(109, 23);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(120, 30);
            this.Remove.TabIndex = 6;
            this.Remove.Text = "Remove Layer";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(6, 23);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(97, 30);
            this.Add.TabIndex = 7;
            this.Add.Text = "Add Layer";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Enable
            // 
            this.Enable.Location = new System.Drawing.Point(6, 59);
            this.Enable.Name = "Enable";
            this.Enable.Size = new System.Drawing.Size(97, 28);
            this.Enable.TabIndex = 8;
            this.Enable.Text = "Enable Layer";
            this.Enable.UseVisualStyleBackColor = true;
            this.Enable.Click += new System.EventHandler(this.Enable_Click);
            // 
            // zoomin
            // 
            this.zoomin.Location = new System.Drawing.Point(461, 12);
            this.zoomin.Name = "zoomin";
            this.zoomin.Size = new System.Drawing.Size(26, 23);
            this.zoomin.TabIndex = 9;
            this.zoomin.Text = "+";
            this.zoomin.UseVisualStyleBackColor = true;
            this.zoomin.Click += new System.EventHandler(this.zoomin_Click);
            // 
            // zoomout
            // 
            this.zoomout.Location = new System.Drawing.Point(493, 12);
            this.zoomout.Name = "zoomout";
            this.zoomout.Size = new System.Drawing.Size(25, 23);
            this.zoomout.TabIndex = 10;
            this.zoomout.Text = "-";
            this.zoomout.UseVisualStyleBackColor = true;
            this.zoomout.Click += new System.EventHandler(this.zoomout_Click);
            // 
            // fullExtent
            // 
            this.fullExtent.Location = new System.Drawing.Point(524, 12);
            this.fullExtent.Name = "fullExtent";
            this.fullExtent.Size = new System.Drawing.Size(85, 23);
            this.fullExtent.TabIndex = 11;
            this.fullExtent.Text = "full extent";
            this.fullExtent.UseVisualStyleBackColor = true;
            this.fullExtent.Click += new System.EventHandler(this.fullExtent_Click);
            // 
            // coordinates_lbl
            // 
            this.coordinates_lbl.AutoSize = true;
            this.coordinates_lbl.Location = new System.Drawing.Point(72, 29);
            this.coordinates_lbl.Name = "coordinates_lbl";
            this.coordinates_lbl.Size = new System.Drawing.Size(0, 17);
            this.coordinates_lbl.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.Remove);
            this.groupBox1.Controls.Add(this.Enable);
            this.groupBox1.Controls.Add(this.Disable);
            this.groupBox1.Location = new System.Drawing.Point(22, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 99);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Updating Layers";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.coordinates_lbl);
            this.groupBox3.Location = new System.Drawing.Point(1114, 518);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 64);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Coordinates";
            // 
            // Load_box
            // 
            this.Load_box.FormattingEnabled = true;
            this.Load_box.Location = new System.Drawing.Point(237, 12);
            this.Load_box.Name = "Load_box";
            this.Load_box.Size = new System.Drawing.Size(218, 24);
            this.Load_box.TabIndex = 16;
            this.Load_box.SelectedIndexChanged += new System.EventHandler(this.Load_box_SelectedIndexChanged);
            // 
            // Layer_box
            // 
            this.Layer_box.FormattingEnabled = true;
            this.Layer_box.Location = new System.Drawing.Point(237, 51);
            this.Layer_box.Name = "Layer_box";
            this.Layer_box.Size = new System.Drawing.Size(218, 24);
            this.Layer_box.TabIndex = 17;
            this.Layer_box.SelectedIndexChanged += new System.EventHandler(this.Layer_box_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Apply_btn);
            this.groupBox2.Controls.Add(this.Where_txt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(1098, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 112);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Definition Query";
            // 
            // Apply_btn
            // 
            this.Apply_btn.Location = new System.Drawing.Point(252, 49);
            this.Apply_btn.Name = "Apply_btn";
            this.Apply_btn.Size = new System.Drawing.Size(75, 50);
            this.Apply_btn.TabIndex = 2;
            this.Apply_btn.Text = "Apply Query";
            this.Apply_btn.UseVisualStyleBackColor = true;
            this.Apply_btn.Click += new System.EventHandler(this.Apply_btn_Click_1);
            // 
            // Where_txt
            // 
            this.Where_txt.Location = new System.Drawing.Point(16, 63);
            this.Where_txt.Multiline = true;
            this.Where_txt.Name = "Where_txt";
            this.Where_txt.Size = new System.Drawing.Size(191, 39);
            this.Where_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Where Clause : ";
            // 
            // attribute_table
            // 
            this.attribute_table.Location = new System.Drawing.Point(461, 51);
            this.attribute_table.Name = "attribute_table";
            this.attribute_table.Size = new System.Drawing.Size(148, 23);
            this.attribute_table.TabIndex = 20;
            this.attribute_table.Text = "open attribute table";
            this.attribute_table.UseVisualStyleBackColor = true;
            this.attribute_table.Click += new System.EventHandler(this.attribute_table_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Apply_location_filter);
            this.groupBox5.Controls.Add(this.locationMethod);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.targetBox);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(1098, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(384, 231);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select By Location";
            // 
            // Apply_location_filter
            // 
            this.Apply_location_filter.Location = new System.Drawing.Point(129, 176);
            this.Apply_location_filter.Name = "Apply_location_filter";
            this.Apply_location_filter.Size = new System.Drawing.Size(92, 34);
            this.Apply_location_filter.TabIndex = 21;
            this.Apply_location_filter.Text = "Apply";
            this.Apply_location_filter.UseVisualStyleBackColor = true;
            this.Apply_location_filter.Click += new System.EventHandler(this.Apply_location_filter_Click);
            // 
            // locationMethod
            // 
            this.locationMethod.FormattingEnabled = true;
            this.locationMethod.Items.AddRange(new object[] {
            "intersect the source layer feature",
            "contain the source layer feature",
            "within the source layer feature",
            "touch the boundary of the source layer feature"});
            this.locationMethod.Location = new System.Drawing.Point(16, 130);
            this.locationMethod.Name = "locationMethod";
            this.locationMethod.Size = new System.Drawing.Size(311, 24);
            this.locationMethod.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "spatial selection method for target feature layer";
            // 
            // targetBox
            // 
            this.targetBox.FormattingEnabled = true;
            this.targetBox.Location = new System.Drawing.Point(116, 35);
            this.targetBox.Name = "targetBox";
            this.targetBox.Size = new System.Drawing.Size(218, 24);
            this.targetBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Target Layer :";
            // 
            // clear_Selection
            // 
            this.clear_Selection.Location = new System.Drawing.Point(1214, 456);
            this.clear_Selection.Name = "clear_Selection";
            this.clear_Selection.Size = new System.Drawing.Size(140, 52);
            this.clear_Selection.TabIndex = 22;
            this.clear_Selection.Text = "Clear Selection";
            this.clear_Selection.UseVisualStyleBackColor = true;
            this.clear_Selection.Click += new System.EventHandler(this.clear_Selection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Method";
            // 
            // method_box
            // 
            this.method_box.FormattingEnabled = true;
            this.method_box.Items.AddRange(new object[] {
            "Create new selection",
            "Add to current selection",
            "Remove from current selection"});
            this.method_box.Location = new System.Drawing.Point(98, 38);
            this.method_box.Name = "method_box";
            this.method_box.Size = new System.Drawing.Size(348, 24);
            this.method_box.TabIndex = 17;
            this.method_box.SelectedIndexChanged += new System.EventHandler(this.method_box_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fields";
            // 
            // fields_lst
            // 
            this.fields_lst.FormattingEnabled = true;
            this.fields_lst.ItemHeight = 16;
            this.fields_lst.Location = new System.Drawing.Point(16, 110);
            this.fields_lst.Name = "fields_lst";
            this.fields_lst.Size = new System.Drawing.Size(376, 100);
            this.fields_lst.TabIndex = 19;
            this.fields_lst.SelectedIndexChanged += new System.EventHandler(this.fields_lst_SelectedIndexChanged);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(24, 228);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(43, 29);
            this.equal.TabIndex = 20;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click_1);
            // 
            // greaterThan
            // 
            this.greaterThan.Location = new System.Drawing.Point(24, 263);
            this.greaterThan.Name = "greaterThan";
            this.greaterThan.Size = new System.Drawing.Size(43, 29);
            this.greaterThan.TabIndex = 21;
            this.greaterThan.Text = ">";
            this.greaterThan.UseVisualStyleBackColor = true;
            this.greaterThan.Click += new System.EventHandler(this.greaterThan_Click);
            // 
            // lessThan
            // 
            this.lessThan.Location = new System.Drawing.Point(24, 298);
            this.lessThan.Name = "lessThan";
            this.lessThan.Size = new System.Drawing.Size(43, 29);
            this.lessThan.TabIndex = 22;
            this.lessThan.Text = "<";
            this.lessThan.UseVisualStyleBackColor = true;
            this.lessThan.Click += new System.EventHandler(this.lessThan_Click);
            // 
            // or
            // 
            this.or.Location = new System.Drawing.Point(123, 301);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(55, 29);
            this.or.TabIndex = 23;
            this.or.Text = "Or";
            this.or.UseVisualStyleBackColor = true;
            this.or.Click += new System.EventHandler(this.or_Click);
            // 
            // notEqual
            // 
            this.notEqual.Location = new System.Drawing.Point(73, 231);
            this.notEqual.Name = "notEqual";
            this.notEqual.Size = new System.Drawing.Size(44, 29);
            this.notEqual.TabIndex = 24;
            this.notEqual.Text = "<>";
            this.notEqual.UseVisualStyleBackColor = true;
            this.notEqual.Click += new System.EventHandler(this.notEqual_Click);
            // 
            // greaterThan_orEqual
            // 
            this.greaterThan_orEqual.Location = new System.Drawing.Point(73, 266);
            this.greaterThan_orEqual.Name = "greaterThan_orEqual";
            this.greaterThan_orEqual.Size = new System.Drawing.Size(44, 29);
            this.greaterThan_orEqual.TabIndex = 25;
            this.greaterThan_orEqual.Text = ">=";
            this.greaterThan_orEqual.UseVisualStyleBackColor = true;
            this.greaterThan_orEqual.Click += new System.EventHandler(this.greaterThan_orEqual_Click);
            // 
            // and
            // 
            this.and.Location = new System.Drawing.Point(122, 266);
            this.and.Name = "and";
            this.and.Size = new System.Drawing.Size(55, 29);
            this.and.TabIndex = 26;
            this.and.Text = "And";
            this.and.UseVisualStyleBackColor = true;
            this.and.Click += new System.EventHandler(this.and_Click);
            // 
            // lessThan_orEqual
            // 
            this.lessThan_orEqual.Location = new System.Drawing.Point(73, 298);
            this.lessThan_orEqual.Name = "lessThan_orEqual";
            this.lessThan_orEqual.Size = new System.Drawing.Size(44, 29);
            this.lessThan_orEqual.TabIndex = 27;
            this.lessThan_orEqual.Text = "<=";
            this.lessThan_orEqual.UseVisualStyleBackColor = true;
            this.lessThan_orEqual.Click += new System.EventHandler(this.lessThan_orEqual_Click);
            // 
            // like
            // 
            this.like.Location = new System.Drawing.Point(123, 231);
            this.like.Name = "like";
            this.like.Size = new System.Drawing.Size(55, 29);
            this.like.TabIndex = 28;
            this.like.Text = "like";
            this.like.UseVisualStyleBackColor = true;
            this.like.Click += new System.EventHandler(this.like_Click);
            // 
            // Is
            // 
            this.Is.Location = new System.Drawing.Point(24, 333);
            this.Is.Name = "Is";
            this.Is.Size = new System.Drawing.Size(43, 29);
            this.Is.TabIndex = 29;
            this.Is.Text = "Is";
            this.Is.UseVisualStyleBackColor = true;
            this.Is.Click += new System.EventHandler(this.Is_Click);
            // 
            // brackets
            // 
            this.brackets.Location = new System.Drawing.Point(73, 333);
            this.brackets.Name = "brackets";
            this.brackets.Size = new System.Drawing.Size(43, 29);
            this.brackets.TabIndex = 30;
            this.brackets.Text = "()";
            this.brackets.UseVisualStyleBackColor = true;
            this.brackets.Click += new System.EventHandler(this.brackets_Click);
            // 
            // not
            // 
            this.not.Location = new System.Drawing.Point(122, 336);
            this.not.Name = "not";
            this.not.Size = new System.Drawing.Size(55, 29);
            this.not.TabIndex = 31;
            this.not.Text = "Not";
            this.not.UseVisualStyleBackColor = true;
            this.not.Click += new System.EventHandler(this.not_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "select statement";
            // 
            // select_txt
            // 
            this.select_txt.Location = new System.Drawing.Point(28, 395);
            this.select_txt.Multiline = true;
            this.select_txt.Name = "select_txt";
            this.select_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.select_txt.Size = new System.Drawing.Size(418, 101);
            this.select_txt.TabIndex = 33;
            // 
            // uniqueValues_lst
            // 
            this.uniqueValues_lst.FormattingEnabled = true;
            this.uniqueValues_lst.ItemHeight = 16;
            this.uniqueValues_lst.Location = new System.Drawing.Point(193, 228);
            this.uniqueValues_lst.Name = "uniqueValues_lst";
            this.uniqueValues_lst.Size = new System.Drawing.Size(228, 100);
            this.uniqueValues_lst.TabIndex = 34;
            this.uniqueValues_lst.SelectedIndexChanged += new System.EventHandler(this.uniqueValues_lst_SelectedIndexChanged);
            // 
            // getUnique
            // 
            this.getUnique.Location = new System.Drawing.Point(193, 336);
            this.getUnique.Name = "getUnique";
            this.getUnique.Size = new System.Drawing.Size(155, 31);
            this.getUnique.TabIndex = 35;
            this.getUnique.Text = "Get Unique Values";
            this.getUnique.UseVisualStyleBackColor = true;
            this.getUnique.Click += new System.EventHandler(this.getUnique_Click_1);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(273, 506);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 34);
            this.clear.TabIndex = 36;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(123, 506);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 34);
            this.Apply.TabIndex = 37;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Apply);
            this.groupBox4.Controls.Add(this.clear);
            this.groupBox4.Controls.Add(this.getUnique);
            this.groupBox4.Controls.Add(this.uniqueValues_lst);
            this.groupBox4.Controls.Add(this.select_txt);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.not);
            this.groupBox4.Controls.Add(this.brackets);
            this.groupBox4.Controls.Add(this.Is);
            this.groupBox4.Controls.Add(this.like);
            this.groupBox4.Controls.Add(this.lessThan_orEqual);
            this.groupBox4.Controls.Add(this.and);
            this.groupBox4.Controls.Add(this.greaterThan_orEqual);
            this.groupBox4.Controls.Add(this.notEqual);
            this.groupBox4.Controls.Add(this.or);
            this.groupBox4.Controls.Add(this.lessThan);
            this.groupBox4.Controls.Add(this.greaterThan);
            this.groupBox4.Controls.Add(this.equal);
            this.groupBox4.Controls.Add(this.fields_lst);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.method_box);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(638, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(454, 561);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "select By Attribute";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(222, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(808, 472);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(461, 83);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(148, 23);
            this.Close.TabIndex = 23;
            this.Close.Text = "Close attribute Table";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // axMapControl1
            // 
            this.axMapControl1.Location = new System.Drawing.Point(12, 188);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(597, 367);
            this.axMapControl1.TabIndex = 0;
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 606);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.clear_Selection);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.attribute_table);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Layer_box);
            this.Controls.Add(this.Load_box);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fullExtent);
            this.Controls.Add(this.zoomout);
            this.Controls.Add(this.zoomin);
            this.Controls.Add(this.LoadLayer);
            this.Controls.Add(this.LoadMap);
            this.Controls.Add(this.axMapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.Button LoadMap;
        private System.Windows.Forms.Button LoadLayer;
        private System.Windows.Forms.Button Disable;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Enable;
        private System.Windows.Forms.Button zoomin;
        private System.Windows.Forms.Button zoomout;
        private System.Windows.Forms.Button fullExtent;
        private System.Windows.Forms.Label coordinates_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox Load_box;
        public System.Windows.Forms.ComboBox Layer_box;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Apply_btn;
        private System.Windows.Forms.TextBox Where_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button attribute_table;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox targetBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clear_Selection;
        private System.Windows.Forms.Button Apply_location_filter;
        private System.Windows.Forms.ComboBox locationMethod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox method_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox fields_lst;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button greaterThan;
        private System.Windows.Forms.Button lessThan;
        private System.Windows.Forms.Button or;
        private System.Windows.Forms.Button notEqual;
        private System.Windows.Forms.Button greaterThan_orEqual;
        private System.Windows.Forms.Button and;
        private System.Windows.Forms.Button lessThan_orEqual;
        private System.Windows.Forms.Button like;
        private System.Windows.Forms.Button Is;
        private System.Windows.Forms.Button brackets;
        private System.Windows.Forms.Button not;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox select_txt;
        private System.Windows.Forms.ListBox uniqueValues_lst;
        private System.Windows.Forms.Button getUnique;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Close;
    }
}

