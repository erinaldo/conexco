﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.31
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 1591

namespace Orders {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.ComponentModel.ToolboxItem(true)]
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [System.Xml.Serialization.XmlRootAttribute("OrdersDataSet")]
    [System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class OrdersDataSet : System.Data.DataSet {
        
        private OrdersDataTable tableOrders;
        
        private System.Data.SchemaSerializationMode _schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public OrdersDataSet() {
            this.BeginInit();
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected OrdersDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == System.Data.SchemaSerializationMode.IncludeSchema)) {
                System.Data.DataSet ds = new System.Data.DataSet();
                ds.ReadXmlSchema(new System.Xml.XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Orders"] != null)) {
                    base.Tables.Add(new OrdersDataTable(ds.Tables["Orders"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new System.Xml.XmlTextReader(new System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public OrdersDataTable Orders {
            get {
                return this.tableOrders;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override System.Data.DataSet Clone() {
            OrdersDataSet cln = ((OrdersDataSet)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void ReadXmlSerializable(System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                System.Data.DataSet ds = new System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["Orders"] != null)) {
                    base.Tables.Add(new OrdersDataTable(ds.Tables["Orders"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new System.Xml.XmlTextReader(stream), null);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal void InitVars(bool initTable) {
            this.tableOrders = ((OrdersDataTable)(base.Tables["Orders"]));
            if ((initTable == true)) {
                if ((this.tableOrders != null)) {
                    this.tableOrders.InitVars();
                }
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitClass() {
            this.DataSetName = "OrdersDataSet";
            this.Prefix = "";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.tableOrders = new OrdersDataTable();
            base.Tables.Add(this.tableOrders);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private bool ShouldSerializeOrders() {
            return false;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(System.Xml.Schema.XmlSchemaSet xs) {
            OrdersDataSet ds = new OrdersDataSet();
            System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
            System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
            xs.Add(ds.GetSchemaSerializable());
            System.Xml.Schema.XmlSchemaAny any = new System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            return type;
        }
        
        public delegate void OrdersRowChangeEventHandler(object sender, OrdersRowChangeEvent e);
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        [System.Serializable()]
        [System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class OrdersDataTable : System.Data.DataTable, System.Collections.IEnumerable {
            
            private System.Data.DataColumn columnOrderID;
            
            private System.Data.DataColumn columnOrderDate;
            
            private System.Data.DataColumn columnRequiredDate;
            
            private System.Data.DataColumn columnShippedDate;
            
            private System.Data.DataColumn columnShipVia;
            
            private System.Data.DataColumn columnFreight;
            
            private System.Data.DataColumn columnShipName;
            
            private System.Data.DataColumn columnShipCity;
            
            private System.Data.DataColumn columnShipPostalCode;
            
            private System.Data.DataColumn columnShipCountry;
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public OrdersDataTable() {
                this.TableName = "Orders";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal OrdersDataTable(System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected OrdersDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.Data.DataColumn OrderIDColumn {
                get {
                    return this.columnOrderID;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.Data.DataColumn OrderDateColumn {
                get {
                    return this.columnOrderDate;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.Data.DataColumn RequiredDateColumn {
                get {
                    return this.columnRequiredDate;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.Data.DataColumn ShippedDateColumn {
                get {
                    return this.columnShippedDate;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.Data.DataColumn ShipViaColumn {
                get {
                    return this.columnShipVia;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.Data.DataColumn FreightColumn {
                get {
                    return this.columnFreight;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.Data.DataColumn ShipNameColumn {
                get {
                    return this.columnShipName;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.Data.DataColumn ShipCityColumn {
                get {
                    return this.columnShipCity;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.Data.DataColumn ShipPostalCodeColumn {
                get {
                    return this.columnShipPostalCode;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.Data.DataColumn ShipCountryColumn {
                get {
                    return this.columnShipCountry;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public OrdersRow this[int index] {
                get {
                    return ((OrdersRow)(this.Rows[index]));
                }
            }
            
            public event OrdersRowChangeEventHandler OrdersRowChanging;
            
            public event OrdersRowChangeEventHandler OrdersRowChanged;
            
            public event OrdersRowChangeEventHandler OrdersRowDeleting;
            
            public event OrdersRowChangeEventHandler OrdersRowDeleted;
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void AddOrdersRow(OrdersRow row) {
                this.Rows.Add(row);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public OrdersRow AddOrdersRow(System.DateTime OrderDate, System.DateTime RequiredDate, System.DateTime ShippedDate, int ShipVia, decimal Freight, string ShipName, string ShipCity, string ShipPostalCode, string ShipCountry) {
                OrdersRow rowOrdersRow = ((OrdersRow)(this.NewRow()));
                rowOrdersRow.ItemArray = new object[] {
                        null,
                        OrderDate,
                        RequiredDate,
                        ShippedDate,
                        ShipVia,
                        Freight,
                        ShipName,
                        ShipCity,
                        ShipPostalCode,
                        ShipCountry};
                this.Rows.Add(rowOrdersRow);
                return rowOrdersRow;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public virtual System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public override System.Data.DataTable Clone() {
                OrdersDataTable cln = ((OrdersDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override System.Data.DataTable CreateInstance() {
                return new OrdersDataTable();
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal void InitVars() {
                this.columnOrderID = base.Columns["OrderID"];
                this.columnOrderDate = base.Columns["OrderDate"];
                this.columnRequiredDate = base.Columns["RequiredDate"];
                this.columnShippedDate = base.Columns["ShippedDate"];
                this.columnShipVia = base.Columns["ShipVia"];
                this.columnFreight = base.Columns["Freight"];
                this.columnShipName = base.Columns["ShipName"];
                this.columnShipCity = base.Columns["ShipCity"];
                this.columnShipPostalCode = base.Columns["ShipPostalCode"];
                this.columnShipCountry = base.Columns["ShipCountry"];
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private void InitClass() {
                this.columnOrderID = new System.Data.DataColumn("OrderID", typeof(int), null, System.Data.MappingType.Element);
                base.Columns.Add(this.columnOrderID);
                this.columnOrderDate = new System.Data.DataColumn("OrderDate", typeof(System.DateTime), null, System.Data.MappingType.Element);
                base.Columns.Add(this.columnOrderDate);
                this.columnRequiredDate = new System.Data.DataColumn("RequiredDate", typeof(System.DateTime), null, System.Data.MappingType.Element);
                base.Columns.Add(this.columnRequiredDate);
                this.columnShippedDate = new System.Data.DataColumn("ShippedDate", typeof(System.DateTime), null, System.Data.MappingType.Element);
                base.Columns.Add(this.columnShippedDate);
                this.columnShipVia = new System.Data.DataColumn("ShipVia", typeof(int), null, System.Data.MappingType.Element);
                base.Columns.Add(this.columnShipVia);
                this.columnFreight = new System.Data.DataColumn("Freight", typeof(decimal), null, System.Data.MappingType.Element);
                base.Columns.Add(this.columnFreight);
                this.columnShipName = new System.Data.DataColumn("ShipName", typeof(string), null, System.Data.MappingType.Element);
                base.Columns.Add(this.columnShipName);
                this.columnShipCity = new System.Data.DataColumn("ShipCity", typeof(string), null, System.Data.MappingType.Element);
                base.Columns.Add(this.columnShipCity);
                this.columnShipPostalCode = new System.Data.DataColumn("ShipPostalCode", typeof(string), null, System.Data.MappingType.Element);
                base.Columns.Add(this.columnShipPostalCode);
                this.columnShipCountry = new System.Data.DataColumn("ShipCountry", typeof(string), null, System.Data.MappingType.Element);
                base.Columns.Add(this.columnShipCountry);
                this.columnOrderID.AutoIncrement = true;
                this.columnOrderID.AllowDBNull = false;
                this.columnOrderID.ReadOnly = true;
                this.columnShipName.MaxLength = 40;
                this.columnShipCity.MaxLength = 15;
                this.columnShipPostalCode.MaxLength = 10;
                this.columnShipCountry.MaxLength = 15;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public OrdersRow NewOrdersRow() {
                return ((OrdersRow)(this.NewRow()));
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) {
                return new OrdersRow(builder);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override System.Type GetRowType() {
                return typeof(OrdersRow);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowChanged(System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.OrdersRowChanged != null)) {
                    this.OrdersRowChanged(this, new OrdersRowChangeEvent(((OrdersRow)(e.Row)), e.Action));
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowChanging(System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.OrdersRowChanging != null)) {
                    this.OrdersRowChanging(this, new OrdersRowChangeEvent(((OrdersRow)(e.Row)), e.Action));
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowDeleted(System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.OrdersRowDeleted != null)) {
                    this.OrdersRowDeleted(this, new OrdersRowChangeEvent(((OrdersRow)(e.Row)), e.Action));
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowDeleting(System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.OrdersRowDeleting != null)) {
                    this.OrdersRowDeleting(this, new OrdersRowChangeEvent(((OrdersRow)(e.Row)), e.Action));
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void RemoveOrdersRow(OrdersRow row) {
                this.Rows.Remove(row);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public static System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet xs) {
                System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
                System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
                OrdersDataSet ds = new OrdersDataSet();
                xs.Add(ds.GetSchemaSerializable());
                System.Xml.Schema.XmlSchemaAny any1 = new System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                System.Xml.Schema.XmlSchemaAny any2 = new System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                System.Xml.Schema.XmlSchemaAttribute attribute1 = new System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                System.Xml.Schema.XmlSchemaAttribute attribute2 = new System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "OrdersDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                return type;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public partial class OrdersRow : System.Data.DataRow {
            
            private OrdersDataTable tableOrders;
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal OrdersRow(System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableOrders = ((OrdersDataTable)(this.Table));
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public int OrderID {
                get {
                    return ((int)(this[this.tableOrders.OrderIDColumn]));
                }
                set {
                    this[this.tableOrders.OrderIDColumn] = value;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.DateTime OrderDate {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableOrders.OrderDateColumn]));
                    }
                    catch (System.InvalidCastException e) {
                        throw new System.Data.StrongTypingException("The value for column \'OrderDate\' in table \'Orders\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.OrderDateColumn] = value;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.DateTime RequiredDate {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableOrders.RequiredDateColumn]));
                    }
                    catch (System.InvalidCastException e) {
                        throw new System.Data.StrongTypingException("The value for column \'RequiredDate\' in table \'Orders\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.RequiredDateColumn] = value;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.DateTime ShippedDate {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableOrders.ShippedDateColumn]));
                    }
                    catch (System.InvalidCastException e) {
                        throw new System.Data.StrongTypingException("The value for column \'ShippedDate\' in table \'Orders\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.ShippedDateColumn] = value;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public int ShipVia {
                get {
                    try {
                        return ((int)(this[this.tableOrders.ShipViaColumn]));
                    }
                    catch (System.InvalidCastException e) {
                        throw new System.Data.StrongTypingException("The value for column \'ShipVia\' in table \'Orders\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.ShipViaColumn] = value;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public decimal Freight {
                get {
                    try {
                        return ((decimal)(this[this.tableOrders.FreightColumn]));
                    }
                    catch (System.InvalidCastException e) {
                        throw new System.Data.StrongTypingException("The value for column \'Freight\' in table \'Orders\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.FreightColumn] = value;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string ShipName {
                get {
                    try {
                        return ((string)(this[this.tableOrders.ShipNameColumn]));
                    }
                    catch (System.InvalidCastException e) {
                        throw new System.Data.StrongTypingException("The value for column \'ShipName\' in table \'Orders\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.ShipNameColumn] = value;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string ShipCity {
                get {
                    try {
                        return ((string)(this[this.tableOrders.ShipCityColumn]));
                    }
                    catch (System.InvalidCastException e) {
                        throw new System.Data.StrongTypingException("The value for column \'ShipCity\' in table \'Orders\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.ShipCityColumn] = value;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string ShipPostalCode {
                get {
                    try {
                        return ((string)(this[this.tableOrders.ShipPostalCodeColumn]));
                    }
                    catch (System.InvalidCastException e) {
                        throw new System.Data.StrongTypingException("The value for column \'ShipPostalCode\' in table \'Orders\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.ShipPostalCodeColumn] = value;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string ShipCountry {
                get {
                    try {
                        return ((string)(this[this.tableOrders.ShipCountryColumn]));
                    }
                    catch (System.InvalidCastException e) {
                        throw new System.Data.StrongTypingException("The value for column \'ShipCountry\' in table \'Orders\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableOrders.ShipCountryColumn] = value;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsOrderDateNull() {
                return this.IsNull(this.tableOrders.OrderDateColumn);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetOrderDateNull() {
                this[this.tableOrders.OrderDateColumn] = System.Convert.DBNull;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsRequiredDateNull() {
                return this.IsNull(this.tableOrders.RequiredDateColumn);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetRequiredDateNull() {
                this[this.tableOrders.RequiredDateColumn] = System.Convert.DBNull;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsShippedDateNull() {
                return this.IsNull(this.tableOrders.ShippedDateColumn);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetShippedDateNull() {
                this[this.tableOrders.ShippedDateColumn] = System.Convert.DBNull;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsShipViaNull() {
                return this.IsNull(this.tableOrders.ShipViaColumn);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetShipViaNull() {
                this[this.tableOrders.ShipViaColumn] = System.Convert.DBNull;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsFreightNull() {
                return this.IsNull(this.tableOrders.FreightColumn);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetFreightNull() {
                this[this.tableOrders.FreightColumn] = System.Convert.DBNull;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsShipNameNull() {
                return this.IsNull(this.tableOrders.ShipNameColumn);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetShipNameNull() {
                this[this.tableOrders.ShipNameColumn] = System.Convert.DBNull;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsShipCityNull() {
                return this.IsNull(this.tableOrders.ShipCityColumn);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetShipCityNull() {
                this[this.tableOrders.ShipCityColumn] = System.Convert.DBNull;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsShipPostalCodeNull() {
                return this.IsNull(this.tableOrders.ShipPostalCodeColumn);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetShipPostalCodeNull() {
                this[this.tableOrders.ShipPostalCodeColumn] = System.Convert.DBNull;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsShipCountryNull() {
                return this.IsNull(this.tableOrders.ShipCountryColumn);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetShipCountryNull() {
                this[this.tableOrders.ShipCountryColumn] = System.Convert.DBNull;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class OrdersRowChangeEvent : System.EventArgs {
            
            private OrdersRow eventRow;
            
            private System.Data.DataRowAction eventAction;
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public OrdersRowChangeEvent(OrdersRow row, System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public OrdersRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}

#pragma warning restore 1591