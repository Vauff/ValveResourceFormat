using GUI.Controls;

namespace GUI.Types.Viewers;

partial class EntityViewer
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

        if (disposing)
        {
            VisibleChanged -= EntityViewer_VisibleChanged;
            EntityInfo.OutputsGrid.CellDoubleClick -= EntityInfoGrid_CellDoubleClick;
        }

        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
        groupBox5 = new ThemedGroupBox();
        EntityViewerGrid = new System.Windows.Forms.ListView();
        ListHeaderClass = new System.Windows.Forms.ColumnHeader();
        ListHeaderName = new System.Windows.Forms.ColumnHeader();
        tableLayoutPanelFiltersContainer = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanelKeysContainers = new System.Windows.Forms.TableLayoutPanel();
        groupBox3 = new ThemedGroupBox();
        tableLayoutPanelKeys = new System.Windows.Forms.TableLayoutPanel();
        KeyValue_Key = new ThemedTextBox();
        KeyValue_Value = new ThemedTextBox();
        KeyValue_MatchWholeValue = new System.Windows.Forms.CheckBox();
        label1 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        groupBoxEntityIo = new ThemedGroupBox();
        tableLayoutPanelEntityIo = new System.Windows.Forms.TableLayoutPanel();
        EntityIo_Output = new ThemedTextBox();
        EntityIo_Target = new ThemedTextBox();
        EntityIo_Input = new ThemedTextBox();
        EntityIo_Parameter = new ThemedTextBox();
        labelEntityIoOutput = new System.Windows.Forms.Label();
        labelEntityIoTarget = new System.Windows.Forms.Label();
        labelEntityIoInput = new System.Windows.Forms.Label();
        labelEntityIoParameter = new System.Windows.Forms.Label();
        groupBox2 = new ThemedGroupBox();
        tableLayoutPanelObjects = new System.Windows.Forms.TableLayoutPanel();
        ObjectsToInclude_Everything = new System.Windows.Forms.RadioButton();
        ObjectsToInclude_MeshEntities = new System.Windows.Forms.RadioButton();
        ObjectsToInclude_PointEntities = new System.Windows.Forms.RadioButton();
        ObjectsToInclude_ClassTextBox = new ThemedTextBox();
        label2 = new System.Windows.Forms.Label();
        EntityPropertiesGroup = new ThemedGroupBox();
        EntityInfo = new GUI.Forms.EntityInfoControl();
        splitContainer = new System.Windows.Forms.SplitContainer();
        tableLayoutPanelLeft.SuspendLayout();
        groupBox5.SuspendLayout();
        tableLayoutPanelFiltersContainer.SuspendLayout();
        tableLayoutPanelKeysContainers.SuspendLayout();
        groupBox3.SuspendLayout();
        tableLayoutPanelKeys.SuspendLayout();
        groupBoxEntityIo.SuspendLayout();
        tableLayoutPanelEntityIo.SuspendLayout();
        groupBox2.SuspendLayout();
        tableLayoutPanelObjects.SuspendLayout();
        EntityPropertiesGroup.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
        splitContainer.Panel1.SuspendLayout();
        splitContainer.Panel2.SuspendLayout();
        splitContainer.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanelLeft
        // 
        tableLayoutPanelLeft.ColumnCount = 1;
        tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanelLeft.Controls.Add(groupBox5, 0, 0);
        tableLayoutPanelLeft.Controls.Add(tableLayoutPanelFiltersContainer, 0, 1);
        tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanelLeft.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanelLeft.Margin = new System.Windows.Forms.Padding(0);
        tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
        tableLayoutPanelLeft.RowCount = 2;
        tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
        tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
        tableLayoutPanelLeft.Size = new System.Drawing.Size(512, 733);
        tableLayoutPanelLeft.TabIndex = 1;
        // 
        // groupBox5
        // 
        groupBox5.BackColor = System.Drawing.SystemColors.Control;
        groupBox5.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
        groupBox5.BorderWidth = 2;
        groupBox5.Controls.Add(EntityViewerGrid);
        groupBox5.CornerRadius = 5;
        groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
        groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        groupBox5.ForeColor = System.Drawing.Color.Black;
        groupBox5.Location = new System.Drawing.Point(0, 0);
        groupBox5.Margin = new System.Windows.Forms.Padding(0);
        groupBox5.Name = "groupBox5";
        groupBox5.Size = new System.Drawing.Size(512, 513);
        groupBox5.TabIndex = 3;
        groupBox5.TabStop = false;
        groupBox5.Text = "Entity List";
        // 
        // EntityViewerGrid
        // 
        EntityViewerGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ListHeaderClass, ListHeaderName });
        EntityViewerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        EntityViewerGrid.FullRowSelect = true;
        EntityViewerGrid.Location = new System.Drawing.Point(3, 19);
        EntityViewerGrid.Name = "EntityViewerGrid";
        EntityViewerGrid.Size = new System.Drawing.Size(506, 491);
        EntityViewerGrid.TabIndex = 0;
        EntityViewerGrid.UseCompatibleStateImageBehavior = false;
        EntityViewerGrid.View = System.Windows.Forms.View.Details;
        EntityViewerGrid.DrawColumnHeader += EntityViewerGrid_DrawColumnHeader;
        EntityViewerGrid.DrawItem += EntityViewerGrid_DrawItem;
        EntityViewerGrid.SelectedIndexChanged += EntityViewerGrid_SelectionChanged;
        EntityViewerGrid.DoubleClick += EntityViewerGrid_CellDoubleClick;
        EntityViewerGrid.Resize += EntityViewerGrid_Resize;
        // 
        // ListHeaderClass
        // 
        ListHeaderClass.Text = "Class";
        ListHeaderClass.Width = 0;
        // 
        // ListHeaderName
        // 
        ListHeaderName.Text = "Name";
        ListHeaderName.Width = 0;
        // 
        // tableLayoutPanelFiltersContainer
        // 
        tableLayoutPanelFiltersContainer.ColumnCount = 2;
        tableLayoutPanelFiltersContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanelFiltersContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanelFiltersContainer.Controls.Add(tableLayoutPanelKeysContainers, 1, 0);
        tableLayoutPanelFiltersContainer.Controls.Add(groupBox2, 0, 0);
        tableLayoutPanelFiltersContainer.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanelFiltersContainer.Location = new System.Drawing.Point(0, 513);
        tableLayoutPanelFiltersContainer.Margin = new System.Windows.Forms.Padding(0);
        tableLayoutPanelFiltersContainer.Name = "tableLayoutPanelFiltersContainer";
        tableLayoutPanelFiltersContainer.RowCount = 1;
        tableLayoutPanelFiltersContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanelFiltersContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
        tableLayoutPanelFiltersContainer.Size = new System.Drawing.Size(512, 220);
        tableLayoutPanelFiltersContainer.TabIndex = 0;
        // 
        // tableLayoutPanelKeysContainers
        // 
        tableLayoutPanelKeysContainers.ColumnCount = 1;
        tableLayoutPanelKeysContainers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanelKeysContainers.Controls.Add(groupBox3, 0, 0);
        tableLayoutPanelKeysContainers.Controls.Add(groupBoxEntityIo, 0, 1);
        tableLayoutPanelKeysContainers.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanelKeysContainers.Location = new System.Drawing.Point(256, 0);
        tableLayoutPanelKeysContainers.Margin = new System.Windows.Forms.Padding(0);
        tableLayoutPanelKeysContainers.Name = "tableLayoutPanelKeysContainers";
        tableLayoutPanelKeysContainers.RowCount = 2;
        tableLayoutPanelKeysContainers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
        tableLayoutPanelKeysContainers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
        tableLayoutPanelKeysContainers.Size = new System.Drawing.Size(256, 220);
        tableLayoutPanelKeysContainers.TabIndex = 0;
        // 
        // groupBox3
        // 
        groupBox3.BackColor = System.Drawing.SystemColors.Control;
        groupBox3.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
        groupBox3.BorderWidth = 2;
        groupBox3.Controls.Add(tableLayoutPanelKeys);
        groupBox3.CornerRadius = 5;
        groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
        groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        groupBox3.ForeColor = System.Drawing.Color.Black;
        groupBox3.Location = new System.Drawing.Point(3, 3);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(250, 115);
        groupBox3.TabIndex = 1;
        groupBox3.TabStop = false;
        groupBox3.Text = "Key / Value";
        // 
        // tableLayoutPanelKeys
        // 
        tableLayoutPanelKeys.ColumnCount = 2;
        tableLayoutPanelKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        tableLayoutPanelKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        tableLayoutPanelKeys.Controls.Add(KeyValue_Key, 1, 0);
        tableLayoutPanelKeys.Controls.Add(KeyValue_Value, 1, 1);
        tableLayoutPanelKeys.Controls.Add(KeyValue_MatchWholeValue, 1, 2);
        tableLayoutPanelKeys.Controls.Add(label1, 0, 0);
        tableLayoutPanelKeys.Controls.Add(label3, 0, 1);
        tableLayoutPanelKeys.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanelKeys.Location = new System.Drawing.Point(3, 19);
        tableLayoutPanelKeys.Name = "tableLayoutPanelKeys";
        tableLayoutPanelKeys.RowCount = 4;
        tableLayoutPanelKeys.RowStyles.Add(new System.Windows.Forms.RowStyle());
        tableLayoutPanelKeys.RowStyles.Add(new System.Windows.Forms.RowStyle());
        tableLayoutPanelKeys.RowStyles.Add(new System.Windows.Forms.RowStyle());
        tableLayoutPanelKeys.RowStyles.Add(new System.Windows.Forms.RowStyle());
        tableLayoutPanelKeys.Size = new System.Drawing.Size(244, 93);
        tableLayoutPanelKeys.TabIndex = 0;
        // 
        // KeyValue_Key
        // 
        KeyValue_Key.BackColor = System.Drawing.Color.FromArgb(236, 236, 236);
        KeyValue_Key.Dock = System.Windows.Forms.DockStyle.Fill;
        KeyValue_Key.ForeColor = System.Drawing.Color.Black;
        KeyValue_Key.Location = new System.Drawing.Point(41, 3);
        KeyValue_Key.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
        KeyValue_Key.Multiline = true;
        KeyValue_Key.Name = "KeyValue_Key";
        KeyValue_Key.Size = new System.Drawing.Size(203, 23);
        KeyValue_Key.TabIndex = 0;
        KeyValue_Key.TextChanged += KeyValue_Key_TextChanged;
        // 
        // KeyValue_Value
        // 
        KeyValue_Value.BackColor = System.Drawing.Color.FromArgb(236, 236, 236);
        KeyValue_Value.Dock = System.Windows.Forms.DockStyle.Fill;
        KeyValue_Value.ForeColor = System.Drawing.Color.Black;
        KeyValue_Value.Location = new System.Drawing.Point(41, 32);
        KeyValue_Value.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
        KeyValue_Value.Multiline = true;
        KeyValue_Value.Name = "KeyValue_Value";
        KeyValue_Value.Size = new System.Drawing.Size(203, 23);
        KeyValue_Value.TabIndex = 1;
        KeyValue_Value.TextChanged += KeyValue_Value_TextChanged;
        // 
        // KeyValue_MatchWholeValue
        // 
        KeyValue_MatchWholeValue.AutoSize = true;
        KeyValue_MatchWholeValue.Dock = System.Windows.Forms.DockStyle.Fill;
        KeyValue_MatchWholeValue.Location = new System.Drawing.Point(44, 61);
        KeyValue_MatchWholeValue.Name = "KeyValue_MatchWholeValue";
        KeyValue_MatchWholeValue.Size = new System.Drawing.Size(197, 19);
        KeyValue_MatchWholeValue.TabIndex = 2;
        KeyValue_MatchWholeValue.Text = "Match whole value";
        KeyValue_MatchWholeValue.UseVisualStyleBackColor = true;
        KeyValue_MatchWholeValue.CheckedChanged += KeyValue_MatchWholeValue_CheckedChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Location = new System.Drawing.Point(3, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(35, 29);
        label1.TabIndex = 3;
        label1.Text = "Key";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Dock = System.Windows.Forms.DockStyle.Fill;
        label3.Location = new System.Drawing.Point(3, 29);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(35, 29);
        label3.TabIndex = 4;
        label3.Text = "Value";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // groupBoxEntityIo
        //
        groupBoxEntityIo.BackColor = System.Drawing.SystemColors.Control;
        groupBoxEntityIo.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
        groupBoxEntityIo.BorderWidth = 2;
        groupBoxEntityIo.Controls.Add(tableLayoutPanelEntityIo);
        groupBoxEntityIo.CornerRadius = 5;
        groupBoxEntityIo.Dock = System.Windows.Forms.DockStyle.Fill;
        groupBoxEntityIo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        groupBoxEntityIo.ForeColor = System.Drawing.Color.Black;
        groupBoxEntityIo.Location = new System.Drawing.Point(3, 124);
        groupBoxEntityIo.Name = "groupBoxEntityIo";
        groupBoxEntityIo.Size = new System.Drawing.Size(250, 93);
        groupBoxEntityIo.TabIndex = 2;
        groupBoxEntityIo.TabStop = false;
        groupBoxEntityIo.Text = "Entity I/O";
        //
        // tableLayoutPanelEntityIo
        //
        tableLayoutPanelEntityIo.ColumnCount = 4;
        tableLayoutPanelEntityIo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        tableLayoutPanelEntityIo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanelEntityIo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        tableLayoutPanelEntityIo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanelEntityIo.Controls.Add(labelEntityIoOutput, 0, 0);
        tableLayoutPanelEntityIo.Controls.Add(EntityIo_Output, 1, 0);
        tableLayoutPanelEntityIo.Controls.Add(labelEntityIoTarget, 2, 0);
        tableLayoutPanelEntityIo.Controls.Add(EntityIo_Target, 3, 0);
        tableLayoutPanelEntityIo.Controls.Add(labelEntityIoInput, 0, 1);
        tableLayoutPanelEntityIo.Controls.Add(EntityIo_Input, 1, 1);
        tableLayoutPanelEntityIo.Controls.Add(labelEntityIoParameter, 2, 1);
        tableLayoutPanelEntityIo.Controls.Add(EntityIo_Parameter, 3, 1);
        tableLayoutPanelEntityIo.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanelEntityIo.Location = new System.Drawing.Point(3, 19);
        tableLayoutPanelEntityIo.Name = "tableLayoutPanelEntityIo";
        tableLayoutPanelEntityIo.RowCount = 3;
        tableLayoutPanelEntityIo.RowStyles.Add(new System.Windows.Forms.RowStyle());
        tableLayoutPanelEntityIo.RowStyles.Add(new System.Windows.Forms.RowStyle());
        tableLayoutPanelEntityIo.RowStyles.Add(new System.Windows.Forms.RowStyle());
        tableLayoutPanelEntityIo.Size = new System.Drawing.Size(244, 71);
        tableLayoutPanelEntityIo.TabIndex = 0;
        //
        // EntityIo_Output
        //
        EntityIo_Output.BackColor = System.Drawing.Color.FromArgb(236, 236, 236);
        EntityIo_Output.Dock = System.Windows.Forms.DockStyle.Fill;
        EntityIo_Output.ForeColor = System.Drawing.Color.Black;
        EntityIo_Output.Location = new System.Drawing.Point(45, 3);
        EntityIo_Output.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
        EntityIo_Output.Name = "EntityIo_Output";
        EntityIo_Output.Size = new System.Drawing.Size(72, 23);
        EntityIo_Output.TabIndex = 0;
        EntityIo_Output.TextChanged += EntityIo_Output_TextChanged;
        //
        // EntityIo_Target
        //
        EntityIo_Target.BackColor = System.Drawing.Color.FromArgb(236, 236, 236);
        EntityIo_Target.Dock = System.Windows.Forms.DockStyle.Fill;
        EntityIo_Target.ForeColor = System.Drawing.Color.Black;
        EntityIo_Target.Location = new System.Drawing.Point(164, 3);
        EntityIo_Target.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
        EntityIo_Target.Name = "EntityIo_Target";
        EntityIo_Target.Size = new System.Drawing.Size(80, 23);
        EntityIo_Target.TabIndex = 1;
        EntityIo_Target.TextChanged += EntityIo_Target_TextChanged;
        //
        // EntityIo_Input
        //
        EntityIo_Input.BackColor = System.Drawing.Color.FromArgb(236, 236, 236);
        EntityIo_Input.Dock = System.Windows.Forms.DockStyle.Fill;
        EntityIo_Input.ForeColor = System.Drawing.Color.Black;
        EntityIo_Input.Location = new System.Drawing.Point(45, 32);
        EntityIo_Input.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
        EntityIo_Input.Name = "EntityIo_Input";
        EntityIo_Input.Size = new System.Drawing.Size(72, 23);
        EntityIo_Input.TabIndex = 2;
        EntityIo_Input.TextChanged += EntityIo_Input_TextChanged;
        //
        // EntityIo_Parameter
        //
        EntityIo_Parameter.BackColor = System.Drawing.Color.FromArgb(236, 236, 236);
        EntityIo_Parameter.Dock = System.Windows.Forms.DockStyle.Fill;
        EntityIo_Parameter.ForeColor = System.Drawing.Color.Black;
        EntityIo_Parameter.Location = new System.Drawing.Point(164, 32);
        EntityIo_Parameter.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
        EntityIo_Parameter.Name = "EntityIo_Parameter";
        EntityIo_Parameter.Size = new System.Drawing.Size(80, 23);
        EntityIo_Parameter.TabIndex = 3;
        EntityIo_Parameter.TextChanged += EntityIo_Parameter_TextChanged;
        //
        // labelEntityIoOutput
        //
        labelEntityIoOutput.AutoSize = true;
        labelEntityIoOutput.Dock = System.Windows.Forms.DockStyle.Fill;
        labelEntityIoOutput.Location = new System.Drawing.Point(3, 0);
        labelEntityIoOutput.Name = "labelEntityIoOutput";
        labelEntityIoOutput.Size = new System.Drawing.Size(39, 29);
        labelEntityIoOutput.TabIndex = 4;
        labelEntityIoOutput.Text = "Output";
        labelEntityIoOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // labelEntityIoTarget
        //
        labelEntityIoTarget.AutoSize = true;
        labelEntityIoTarget.Dock = System.Windows.Forms.DockStyle.Fill;
        labelEntityIoTarget.Location = new System.Drawing.Point(123, 0);
        labelEntityIoTarget.Name = "labelEntityIoTarget";
        labelEntityIoTarget.Size = new System.Drawing.Size(38, 29);
        labelEntityIoTarget.TabIndex = 5;
        labelEntityIoTarget.Text = "Target";
        labelEntityIoTarget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // labelEntityIoInput
        //
        labelEntityIoInput.AutoSize = true;
        labelEntityIoInput.Dock = System.Windows.Forms.DockStyle.Fill;
        labelEntityIoInput.Location = new System.Drawing.Point(3, 29);
        labelEntityIoInput.Name = "labelEntityIoInput";
        labelEntityIoInput.Size = new System.Drawing.Size(39, 29);
        labelEntityIoInput.TabIndex = 6;
        labelEntityIoInput.Text = "Input";
        labelEntityIoInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // labelEntityIoParameter
        //
        labelEntityIoParameter.AutoSize = true;
        labelEntityIoParameter.Dock = System.Windows.Forms.DockStyle.Fill;
        labelEntityIoParameter.Location = new System.Drawing.Point(123, 29);
        labelEntityIoParameter.Name = "labelEntityIoParameter";
        labelEntityIoParameter.Size = new System.Drawing.Size(38, 29);
        labelEntityIoParameter.TabIndex = 7;
        labelEntityIoParameter.Text = "Param";
        labelEntityIoParameter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // groupBox2
        // 
        groupBox2.BackColor = System.Drawing.SystemColors.Control;
        groupBox2.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
        groupBox2.BorderWidth = 2;
        groupBox2.Controls.Add(tableLayoutPanelObjects);
        groupBox2.CornerRadius = 5;
        groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        groupBox2.ForeColor = System.Drawing.Color.Black;
        groupBox2.Location = new System.Drawing.Point(3, 3);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(250, 214);
        groupBox2.TabIndex = 0;
        groupBox2.TabStop = false;
        groupBox2.Text = "Objects To Include";
        // 
        // tableLayoutPanelObjects
        // 
        tableLayoutPanelObjects.ColumnCount = 1;
        tableLayoutPanelObjects.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanelObjects.Controls.Add(ObjectsToInclude_Everything, 0, 0);
        tableLayoutPanelObjects.Controls.Add(ObjectsToInclude_MeshEntities, 0, 1);
        tableLayoutPanelObjects.Controls.Add(ObjectsToInclude_PointEntities, 0, 2);
        tableLayoutPanelObjects.Controls.Add(ObjectsToInclude_ClassTextBox, 0, 4);
        tableLayoutPanelObjects.Controls.Add(label2, 0, 3);
        tableLayoutPanelObjects.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanelObjects.Location = new System.Drawing.Point(3, 19);
        tableLayoutPanelObjects.Name = "tableLayoutPanelObjects";
        tableLayoutPanelObjects.RowCount = 5;
        tableLayoutPanelObjects.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanelObjects.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanelObjects.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanelObjects.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanelObjects.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanelObjects.Size = new System.Drawing.Size(244, 192);
        tableLayoutPanelObjects.TabIndex = 0;
        // 
        // ObjectsToInclude_Everything
        // 
        ObjectsToInclude_Everything.AutoSize = true;
        ObjectsToInclude_Everything.Checked = true;
        ObjectsToInclude_Everything.Dock = System.Windows.Forms.DockStyle.Fill;
        ObjectsToInclude_Everything.Location = new System.Drawing.Point(3, 3);
        ObjectsToInclude_Everything.Name = "ObjectsToInclude_Everything";
        ObjectsToInclude_Everything.Size = new System.Drawing.Size(238, 25);
        ObjectsToInclude_Everything.TabIndex = 0;
        ObjectsToInclude_Everything.TabStop = true;
        ObjectsToInclude_Everything.Text = "Everything";
        ObjectsToInclude_Everything.UseVisualStyleBackColor = true;
        ObjectsToInclude_Everything.CheckedChanged += ObjectsToInclude_Everything_CheckedChanged;
        // 
        // ObjectsToInclude_MeshEntities
        // 
        ObjectsToInclude_MeshEntities.AutoSize = true;
        ObjectsToInclude_MeshEntities.Dock = System.Windows.Forms.DockStyle.Fill;
        ObjectsToInclude_MeshEntities.Location = new System.Drawing.Point(3, 34);
        ObjectsToInclude_MeshEntities.Name = "ObjectsToInclude_MeshEntities";
        ObjectsToInclude_MeshEntities.Size = new System.Drawing.Size(238, 25);
        ObjectsToInclude_MeshEntities.TabIndex = 1;
        ObjectsToInclude_MeshEntities.Text = "Mesh Entities";
        ObjectsToInclude_MeshEntities.UseVisualStyleBackColor = true;
        ObjectsToInclude_MeshEntities.CheckedChanged += ObjectsToInclude_MeshEntities_CheckedChanged;
        // 
        // ObjectsToInclude_PointEntities
        // 
        ObjectsToInclude_PointEntities.AutoSize = true;
        ObjectsToInclude_PointEntities.Dock = System.Windows.Forms.DockStyle.Fill;
        ObjectsToInclude_PointEntities.Location = new System.Drawing.Point(3, 65);
        ObjectsToInclude_PointEntities.Name = "ObjectsToInclude_PointEntities";
        ObjectsToInclude_PointEntities.Size = new System.Drawing.Size(238, 25);
        ObjectsToInclude_PointEntities.TabIndex = 2;
        ObjectsToInclude_PointEntities.Text = "Point Entities";
        ObjectsToInclude_PointEntities.UseVisualStyleBackColor = true;
        ObjectsToInclude_PointEntities.CheckedChanged += ObjectsToInclude_PointEntities_CheckedChanged;
        // 
        // ObjectsToInclude_ClassTextBox
        // 
        ObjectsToInclude_ClassTextBox.BackColor = System.Drawing.Color.FromArgb(236, 236, 236);
        ObjectsToInclude_ClassTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        ObjectsToInclude_ClassTextBox.ForeColor = System.Drawing.Color.Black;
        ObjectsToInclude_ClassTextBox.Location = new System.Drawing.Point(0, 127);
        ObjectsToInclude_ClassTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
        ObjectsToInclude_ClassTextBox.Multiline = true;
        ObjectsToInclude_ClassTextBox.Name = "ObjectsToInclude_ClassTextBox";
        ObjectsToInclude_ClassTextBox.Size = new System.Drawing.Size(244, 26);
        ObjectsToInclude_ClassTextBox.TabIndex = 4;
        ObjectsToInclude_ClassTextBox.TextChanged += ObjectsToInclude_ClassTextBox_TextChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Dock = System.Windows.Forms.DockStyle.Fill;
        label2.Location = new System.Drawing.Point(3, 93);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(238, 31);
        label2.TabIndex = 5;
        label2.Text = "Classname:";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // EntityPropertiesGroup
        // 
        EntityPropertiesGroup.BackColor = System.Drawing.SystemColors.Control;
        EntityPropertiesGroup.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
        EntityPropertiesGroup.BorderWidth = 2;
        EntityPropertiesGroup.Controls.Add(EntityInfo);
        EntityPropertiesGroup.CornerRadius = 5;
        EntityPropertiesGroup.Dock = System.Windows.Forms.DockStyle.Fill;
        EntityPropertiesGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        EntityPropertiesGroup.ForeColor = System.Drawing.Color.Black;
        EntityPropertiesGroup.Location = new System.Drawing.Point(0, 0);
        EntityPropertiesGroup.Name = "EntityPropertiesGroup";
        EntityPropertiesGroup.Size = new System.Drawing.Size(509, 733);
        EntityPropertiesGroup.TabIndex = 2;
        EntityPropertiesGroup.TabStop = false;
        EntityPropertiesGroup.Text = "Entity Properties - ";
        // 
        // EntityInfo
        // 
        EntityInfo.Dock = System.Windows.Forms.DockStyle.Fill;
        EntityInfo.Location = new System.Drawing.Point(3, 19);
        EntityInfo.Name = "EntityInfo";
        EntityInfo.Size = new System.Drawing.Size(503, 711);
        EntityInfo.TabIndex = 0;
        // 
        // splitContainer
        // 
        splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
        splitContainer.Location = new System.Drawing.Point(0, 8);
        splitContainer.Name = "splitContainer";
        // 
        // splitContainer.Panel1
        // 
        splitContainer.Panel1.Controls.Add(tableLayoutPanelLeft);
        // 
        // splitContainer.Panel2
        // 
        splitContainer.Panel2.Controls.Add(EntityPropertiesGroup);
        splitContainer.Size = new System.Drawing.Size(1025, 733);
        splitContainer.SplitterDistance = 512;
        splitContainer.TabIndex = 2;
        // 
        // EntityViewer
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(splitContainer);
        Name = "EntityViewer";
        Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
        Size = new System.Drawing.Size(1025, 741);
        tableLayoutPanelLeft.ResumeLayout(false);
        groupBox5.ResumeLayout(false);
        tableLayoutPanelFiltersContainer.ResumeLayout(false);
        tableLayoutPanelKeysContainers.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        tableLayoutPanelKeys.ResumeLayout(false);
        tableLayoutPanelKeys.PerformLayout();
        groupBoxEntityIo.ResumeLayout(false);
        tableLayoutPanelEntityIo.ResumeLayout(false);
        tableLayoutPanelEntityIo.PerformLayout();
        groupBox2.ResumeLayout(false);
        tableLayoutPanelObjects.ResumeLayout(false);
        tableLayoutPanelObjects.PerformLayout();
        EntityPropertiesGroup.ResumeLayout(false);
        splitContainer.Panel1.ResumeLayout(false);
        splitContainer.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
        splitContainer.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFiltersContainer;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKeysContainers;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelObjects;
    private System.Windows.Forms.RadioButton ObjectsToInclude_Everything;
    private System.Windows.Forms.RadioButton ObjectsToInclude_MeshEntities;
    private System.Windows.Forms.RadioButton ObjectsToInclude_PointEntities;
    private ThemedTextBox ObjectsToInclude_ClassTextBox;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKeys;
    private ThemedTextBox KeyValue_Key;
    private ThemedTextBox KeyValue_Value;
    private Forms.EntityInfoControl EntityInfo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.CheckBox KeyValue_MatchWholeValue;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private ThemedGroupBox groupBoxEntityIo;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEntityIo;
    private ThemedTextBox EntityIo_Output;
    private ThemedTextBox EntityIo_Target;
    private ThemedTextBox EntityIo_Input;
    private ThemedTextBox EntityIo_Parameter;
    private System.Windows.Forms.Label labelEntityIoOutput;
    private System.Windows.Forms.Label labelEntityIoTarget;
    private System.Windows.Forms.Label labelEntityIoInput;
    private System.Windows.Forms.Label labelEntityIoParameter;
    private System.Windows.Forms.SplitContainer splitContainer;
    private ThemedGroupBox groupBox2;
    private ThemedGroupBox groupBox3;
    private ThemedGroupBox EntityPropertiesGroup;
    private ThemedGroupBox groupBox5;
    private System.Windows.Forms.ListView EntityViewerGrid;
    private System.Windows.Forms.ColumnHeader ListHeaderClass;
    private System.Windows.Forms.ColumnHeader ListHeaderName;
}
