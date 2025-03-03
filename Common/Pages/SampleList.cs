#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        internal SampleConfig()
        {
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DataGrid",
                Category = "Grids",
                Directory = "Grid",
                Type = SampleType.None,
                Samples = DataGrid,
                ControllerName = "DataGrid",
                DemoPath = "datagrid/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Pivot Table",
                Category = "Grids",
                Directory = "PivotView/PivotTable",
                Type = SampleType.Updated,
                Samples = PivotTable,
                ControllerName = "PivotTable",
                DemoPath = "pivot-table/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Tree Grid",
                Category = "Grids",
                Directory = "TreeGrid/TreeGrid",
                Type = SampleType.Updated,
                Samples = TreeGrid,
                ControllerName = "TreeGrid",
                CustomDocLink = "treegrid/getting-started/",
                DemoPath = "tree-grid/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Charts",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.Updated,
                Samples = Chart,
                ControllerName = "Chart",
                DemoPath = "chart/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Barcode Generator",
                Category = "Data Visualization",
                Directory = "Barcodes",
                Type = SampleType.None,
                Samples = Barcode,
                ControllerName = "Barcodes",
                CustomDocLink = "barcode/getting-started",
                DemoPath = "barcodes/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Bullet Chart",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.None,
                Samples = BulletChart,
                ControllerName = "BulletChart",
                DemoPath = "bullet-chart/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Circular Gauge",
                Category = "Data Visualization",
                Directory = "CircularGauge",
                Type = SampleType.None,
                Samples = CircularGauge,
                ControllerName = "CircularGauge",
                DemoPath = "circular-gauge/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Arc Gauge",
                Category = "Data Visualization",
                Directory = "ArcGauge",
                Type = SampleType.New,
                Samples = ArcGauge,
                ControllerName = "ArcGauge",
                DemoPath = "arc-gauge/default"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Diagram (Classic)",
                Category = "Data Visualization",
                Directory = "Diagram",
                Type = SampleType.None,
                Samples = Diagram,
                ControllerName = "Diagram",
                IsHideFromHomePageList = true,
                IsHide = true,
                DemoPath = "diagram/flowchart"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Diagram",
                Category = "Data Visualization",
                Directory = "DiagramComponent",
                Type = SampleType.Updated,
                Samples = DiagramComponent,
                ControllerName = "DiagramComponent",
                DemoPath = "diagramcomponent/flowchart",
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "HeatMap Chart",
                Category = "Data Visualization",
                Directory = "HeatMapChart/HeatMapChart",
                Type = SampleType.None,
                Samples = HeatMapChart,
                ControllerName = "HeatMapChart",
                DemoPath = "heatmap-chart/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Kanban",
                Category = "Data Visualization",
                Directory = "Kanban/Kanban",
                Samples = Kanban,
                ControllerName = "Kanban",
                DemoPath = "kanban/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Linear Gauge",
                Category = "Data Visualization",
                Directory = "LinearGauge/LinearGauge",
                Type = SampleType.None,
                Samples = LinearGauge,
                ControllerName = "LinearGauge",
                DemoPath = "linear-gauge/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Maps",
                Category = "Data Visualization",
                Directory = "Maps/Maps",
                Type = SampleType.None,
                Samples = Maps,
                ControllerName = "Maps",
                DemoPath = "maps/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Range Selector",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.None,
                Samples = RangeNavigator,
                ControllerName = "RangeSelector",
                DemoPath = "range-selector/range-navigator"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Smith Chart",
                Category = "Data Visualization",
                Directory = "Charts/SmithChart",
                Type = SampleType.None,
                Samples = SmithChart,
                ControllerName = "SmithChart",
                DemoPath = "smith-chart/default-functionalities"
            });

            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Sparkline Charts",
                Category = "Data Visualization",
                Directory = "Charts/Sparkline",
                Type = SampleType.None,
                Samples = SparklineCharts,
                ControllerName = "Sparkline",
                DemoPath = "sparkline/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Stock Chart",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.None,
                Samples = StockChart,
                ControllerName = "StockChart",
                DemoPath = "stock-chart/stock-chart"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TreeMap",
                Category = "Data Visualization",
                Directory = "TreeMap/TreeMap",
                Type = SampleType.None,
                Samples = TreeMap,
                ControllerName = "TreeMap",
                DemoPath = "treemap/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "InPlace Editor",
                Category = "File Viewers & Editors",
                Directory = "Editors/InPlaceEditor",
                Type = SampleType.None,
                Samples = InPlaceEditor,
                ControllerName = "InPlaceEditor",
                DemoPath = "in-place-editor/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Rich Text Editor",
                Category = "File Viewers & Editors",
                Directory = "RichTextEditor/RichTextEditor",
                Samples = RichTextEditor,
                Type = SampleType.Updated,
                ControllerName = "RichTextEditor",
                DemoPath = "rich-text-editor/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Word Processor",
                Category = "File Viewers & Editors",
                Directory = "DocumentEditor/DocumentEditor",
                Samples = DocumentEditor,
                Type = SampleType.Updated,
                ControllerName = "DocumentEditor",
                CustomDocLink = "document-editor/getting-started/features",
                DemoPath = "document-editor/default-functionalities",
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "PDF Viewer",
                Category = "File Viewers & Editors",
                Directory = "Viewer/PdfViewer",
                Samples = PDFViewer,
                Type = SampleType.Updated,
                ControllerName = "PdfViewer",
                CustomDocLink = "pdfviewer/getting-started",
                DemoPath = "pdf-viewer/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Scheduler",
                Category = "Calendars",
                Directory = "Schedule/Scheduler",
                Samples = Scheduler,
                ControllerName = "Scheduler",
                DemoPath = "scheduler/overview",
                Type = SampleType.Updated
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Gantt Chart",
                Category = "Calendars",
                Directory = "GanttChart/GanttChart",
                Type = SampleType.Updated,
                Samples = GanttChart,
                ControllerName = "GanttChart",
                DemoPath = "gantt-chart/default-functionalities",

            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Calendar",
                Category = "Calendars",
                Directory = "Calendars/Calendar",
                Type = SampleType.None,
                Samples = Calendar,
                ControllerName = "Calendar",
                DemoPath = "calendar/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DatePicker",
                Category = "Calendars",
                Directory = "Calendars/DatePicker",
                Type = SampleType.Updated,
                Samples = DatePicker,
                ControllerName = "DatePicker",
                DemoPath = "datepicker/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DateRangePicker",
                Category = "Calendars",
                Directory = "Calendars/DateRangePicker",
                Type = SampleType.None,
                Samples = DateRangePicker,
                ControllerName = "DateRangePicker",
                DemoPath = "daterangepicker/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DateTime Picker",
                Category = "Calendars",
                Directory = "Calendars/DateTimePicker",
                Type = SampleType.Updated,
                Samples = DateTimePicker,
                ControllerName = "DateTimePicker",
                DemoPath = "datetime-picker/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TimePicker",
                Category = "Calendars",
                Directory = "Calendars/TimePicker",
                Type = SampleType.Updated,
                Samples = TimePicker,
                ControllerName = "TimePicker",
                DemoPath = "timepicker/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Button",
                Category = "Buttons",
                Directory = "Buttons",
                Samples = Button,
                ControllerName = "Buttons",
                CustomDocLink = "button/getting-started",
                DemoPath = "buttons/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Button Group",
                Category = "Buttons",
                Directory = "Buttons",
                Samples = Button,
                ControllerName = "Buttons",
                CustomDocLink = "button/getting-started",
                DemoPath = "buttons/button-group"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Chips",
                Category = "Buttons",
                Directory = "Buttons/Chips",
                Type = SampleType.None,
                Samples = Chips,
                ControllerName = "Chips",
                CustomDocLink = "chip/getting-started",
                DemoPath = "chips/default-functionalities"
            });
			SampleBrowser.SampleList.Add(new SampleList
			{
                Name = "Floating Action Button",
                Category = "Buttons",
                Directory = "Buttons/FAB",                
                Type = SampleType.None,
                Samples = FAB,
                ControllerName = "FAB",
                DemoPath = "fab/overview"
			});
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Dropdown Menu",
                Category = "Buttons",
                Directory = "Buttons",
                Samples = Button,
                ControllerName = "Buttons",
                CustomDocLink = "button/getting-started",
                DemoPath = "buttons/dropdown-menu"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Progress Button",
                Category = "Buttons",
                Directory = "Buttons",
                Samples = Button,
                ControllerName = "Buttons",
                CustomDocLink = "button/getting-started",
                DemoPath = "buttons/progress-button"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Split Button",
                Category = "Buttons",
                Directory = "Buttons",
                Samples = Button,
                ControllerName = "Buttons",
                CustomDocLink = "button/getting-started",
                DemoPath = "buttons/split-button"
            });
			SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Speed Dial",
                Category = "Buttons",
                Directory = "Buttons/SpeedDial",
                Type = SampleType.None,
                Samples = SpeedDial,
                ControllerName = "SpeedDial",
                DemoPath = "speeddial/defaultfunctionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "AutoComplete",
                Category = "DropDowns",
                Directory = "DropDowns/AutoComplete",
                Type = SampleType.None,
                Samples = AutoComplete,
                ControllerName = "AutoComplete",
                DemoPath = "autocomplete/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ComboBox",
                Category = "DropDowns",
                Directory = "DropDowns/ComboBox",
                Type = SampleType.None,
                Samples = ComboBox,
                ControllerName = "ComboBox",
                DemoPath = "combobox/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Dropdown List",
                Category = "DropDowns",
                Directory = "DropDowns/DropDownList",
                Type = SampleType.None,
                Samples = DropDownList,
                ControllerName = "DropDownList",
                DemoPath = "dropdown-list/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ListBox",
                Category = "DropDowns",
                Directory = "DropDowns/ListBox",
                Samples = ListBox,
                ControllerName = "ListBox",
                DemoPath = "listbox/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "MultiSelect Dropdown",
                Category = "DropDowns",
                Directory = "DropDowns/MultiSelect",
                Type = SampleType.None,
                Samples = MultiSelectDropdown,
                ControllerName = "MultiSelectDropdown",
                DemoPath = "multiselect-dropdown/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Mention",
                Category = "DropDowns",
                Directory = "DropDowns/Mention",
                Type = SampleType.Preview,
                Samples = Mention,
                ControllerName = "Mention",
                IsPreview = true,
                DemoPath = "mention/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Checkbox",
                Category = "Inputs",
                Directory = "Buttons",
                Type = SampleType.None,
                Samples = Button,
                ControllerName = "Buttons",
                DemoPath = "buttons/checkbox"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Color Picker",
                Category = "Inputs",
                Directory = "Inputs/ColorPicker",
                Samples = ColorPicker,
                ControllerName = "ColorPicker",
                DemoPath = "color-picker/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Color Palette ",
                Category = "Inputs",
                Directory = "Inputs/ColorPicker",
                Samples = ColorPicker,
                ControllerName = "ColorPicker",
                DemoPath = "color-picker/inline"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Signature",
                Category = "Inputs",
                Directory = "Inputs/Signature",
                Samples = Signature,
                ControllerName = "Signature",
                DemoPath = "signature/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "File Upload",
                Category = "Inputs",
                Directory = "Inputs/Uploader",
                Type = SampleType.None,
                Samples = FileUpload,
                ControllerName = "FileUpload",
                DemoPath = "file-upload/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Input Mask",
                Category = "Inputs",
                Directory = "Inputs/MaskedTextBox",
                Type = SampleType.None,
                Samples = InputMask,
                ControllerName = "InputMask",
                DemoPath = "input-mask/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Numeric Textbox",
                Category = "Inputs",
                Directory = "Inputs/NumericTextBox",
                Type = SampleType.None,
                Samples = NumericTextbox,
                ControllerName = "NumericTextBox",
                DemoPath = "numeric-textbox/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Radio Button",
                Category = "Inputs",
                Directory = "Buttons",
                Type = SampleType.None,
                Samples = Button,
                ControllerName = "Buttons",
                DemoPath = "buttons/radio-button"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Range Slider",
                Category = "Inputs",
                Directory = "Inputs/RangeSlider",
                Type = SampleType.None,
                Samples = RangeSlider,
                ControllerName = "RangeSlider",
                DemoPath = "range-slider/default"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TextBox",
                Category = "Inputs",
                Directory = "Inputs",
                Type = SampleType.None,
                Samples = TextBox,
                ControllerName = "TextBox",
                DemoPath = "textbox/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Toggle Switch Button",
                Category = "Inputs",
                Directory = "Buttons",
                Type = SampleType.None,
                Samples = Button,
                ControllerName = "Buttons",
                DemoPath = "buttons/toggle-switch-button"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Rating",
                Category = "Inputs",
                Directory = "Inputs/Rating",
                Type = SampleType.Preview,
                IsPreview = true,
                Samples = Rating,
                ControllerName = "Rating",
                DemoPath = "rating/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Accordion",
                Category = "Navigation",
                Directory = "Navigations/Accordion",
                Samples = Accordion,
                ControllerName = "Accordion",
                DemoPath = "accordion/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Breadcrumb",
                Category = "Navigation",
                Directory = "Navigations/Breadcrumb",
                Samples = BreadCrumb,
                ControllerName = "Breadcrumb",
                DemoPath = "breadcrumb/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Carousel",
                Category = "Navigation",
                Directory = "Navigations/Carousel",
                Samples = Carousel,
                ControllerName = "Carousel",
                DemoPath = "carousel/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Context Menu",
                Category = "Navigation",
                Directory = "Navigations/ContextMenu",
                Samples = ContextMenu,
                ControllerName = "ContextMenu",
                DemoPath = "context-menu/default-functionalities",
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "File Manager",
                Category = "Navigation",
                Directory = "Navigations/FileManager",
                Type = SampleType.None,
                Samples = FileManager,
                ControllerName = "FileManager",
                DemoPath = "file-manager/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "MenuBar",
                Category = "Navigation",
                Directory = "Navigations/MenuBar",
                Samples = MenuBar,
                ControllerName = "MenuBar",
                DemoPath = "menu-bar/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Pager",
                Category = "Navigation",
                Directory = "Navigation/Pager",
                Type = SampleType.None,
                Samples = Pager,
                ControllerName = "Pager",
                DemoPath = "pager/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Sidebar",
                Category = "Navigation",
                Directory = "Navigations/Sidebar",
                Type = SampleType.None,
                Samples = Sidebar,
                ControllerName = "Sidebar",
                DemoPath = "sidebar/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Tabs",
                Category = "Navigation",
                Directory = "Navigations/Tabs",
                Samples = Tabs,
                ControllerName = "Tabs",
                DemoPath = "tabs/default-functionalities",
                Type = SampleType.Updated
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Toolbar",
                Category = "Navigation",
                Directory = "Navigations/Toolbar",
                Samples = Toolbar,
                ControllerName = "Toolbar",
                DemoPath = "toolbar/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TreeView",
                Category = "Navigation",
                Directory = "Navigations/TreeView",
                Type = SampleType.None,
                Samples = TreeView,
                ControllerName = "TreeView",
                DemoPath = "treeview/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "AppBar",
                Category = "Navigation",
                Directory = "Navigations/AppBar",
                Samples = AppBar,
                ControllerName = "AppBar",
                DemoPath = "appbar/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Card",
                Category = "Layout",
                Directory = "Cards",
                Type = SampleType.None,
                Samples = Card,
                ControllerName = "Card",
                DemoPath = "card/basic-card"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Dashboard Layout",
                Category = "Layout",
                Directory = "Layouts/DashboardLayout",
                Type = SampleType.None,
                Samples = DashboardLayout,
                ControllerName = "DashboardLayout",
                DemoPath = "dashboard-layout/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Dialog",
                Category = "Layout",
                Directory = "Popups/Dialog",
                Samples = Dialog,
                ControllerName = "Dialog",
                DemoPath = "dialog/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Predefined Dialogs",
                Category = "Layout",
                Directory = "Popups/PredefinedDialogs",
                Samples = PredefinedDialogs,
                ControllerName = "PredefinedDialogs",
                DemoPath = "predefined-dialogs/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ListView",
                Category = "Layout",
                Directory = "Layouts/ListView",
                Type = SampleType.None,
                Samples = ListView,
                ControllerName = "ListView",
                DemoPath = "listview/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Splitter",
                Category = "Layout",
                Directory = "Layouts/Splitter",
                Samples = Splitter,
                Type = SampleType.None,
                ControllerName = "Splitter",
                DemoPath = "splitter/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Tooltip",
                Category = "Layout",
                Directory = "Layouts/Tooltip",
                Type = SampleType.None,
                Samples = Tooltip,
                ControllerName = "Tooltip",
                DemoPath = "tooltip/default"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Media Query",
                Category = "Layout",
                Directory = "MediaQuery",
                Type = SampleType.Preview,
                Samples = MediaQuery,
                ControllerName = "MediaQuery",
                IsPreview = true,
                DemoPath = "media-query/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Message",
                Category = "Notifications",
                Directory = "Notifications/Message",
                Samples = Message,
                ControllerName = "Message",
                DemoPath = "message/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Progress Bar",
                Category = "Notifications",
                Directory = "ProgressBar",
                Type = SampleType.None,
                Samples = ProgressBar,
                ControllerName = "ProgressBar",
                DemoPath = "progress-bar/linear"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Toast",
                Category = "Notifications",
                Directory = "Notifications/Toast",
                Type = SampleType.None,
                Samples = Toast,
                ControllerName = "Toast",
                DemoPath = "toast/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Spinner",
                Category = "Notifications",
                Directory = "Notifications/Spinner",
                Type = SampleType.None,
                Samples = Spinner,
                ControllerName = "Spinner",
                DemoPath = "spinner/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Skeleton",
                Category = "Notifications",
                Directory = "Notifications/Skeleton",
                IsPreview = true,
                Type = SampleType.Preview,
                Samples = Skeleton,
                ControllerName = "Skeleton",
                DemoPath = "skeleton/defaultfunctionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Query Builder",
                Category = "Forms",
                Directory = "Forms/QueryBuilder",
                Samples = QueryBuilder,
                ControllerName = "QueryBuilder",
                DemoPath = "query-builder/default-functionalities"
            });
#if !WASM
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Word (DocIO)",
                Category = "Document Processing Libraries",
                Directory = "DocumentProcessing/Word",
                Type = SampleType.Updated,
                Samples = DocIO,
                ControllerName = "Word",
                DemoPath = "word/hello-world",
                ComponentIconName = "word"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "PDF",
                Category = "Document Processing Libraries",
                Directory = "DocumentProcessing/PDF",
                Type = SampleType.None,
                Samples = PDF,
                ControllerName = "PDF",
                DemoPath = "pdf/hello-world"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "PowerPoint (Presentation)",
                Category = "Document Processing Libraries",
                Directory = "DocumentProcessing/PowerPoint",
                Type = SampleType.Updated,
                Samples = Presentation,
                ControllerName = "PowerPoint",
                DemoPath = "powerpoint/getting-started",
                ComponentIconName = "powerpoint"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Excel (XlsIO)",
                Category = "Document Processing Libraries",
                Directory = "DocumentProcessing/Excel",
                Samples = XlsIO,
                ControllerName = "Excel",
                DemoPath = "excel/create-excel",
                ComponentIconName = "excel"
            });
#endif
        }
    }
}
