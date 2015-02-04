namespace Textbook_Tracker
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSectionSearch = new System.Windows.Forms.TextBox();
            this.comboBoxCourseCodeSearch = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSearchLastEYCI = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSearchLast = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTextbookBarcodeIn = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxSection = new System.Windows.Forms.TextBox();
            this.textBoxStudentNumber = new System.Windows.Forms.TextBox();
            this.textBoxTextbookBarcodeOut = new System.Windows.Forms.TextBox();
            this.comboBoxCourseCode = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTextbooks = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTeachers = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSearchByTeach = new System.Windows.Forms.ComboBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.comboBoxSearchByCourse = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.comboBoxCourseTC = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxTeachTC = new System.Windows.Forms.ComboBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.buttonListAll = new System.Windows.Forms.Button();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.buttonEYCICANCEL = new System.Windows.Forms.Button();
            this.buttonEYCIOK = new System.Windows.Forms.Button();
            this.labelDeleteEYCI = new System.Windows.Forms.Label();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.buttonCancelDelDatabase = new System.Windows.Forms.Button();
            this.buttonDeleteDatabase = new System.Windows.Forms.Button();
            this.labelDeleteData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 292);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1009, 249);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.BurlyWood;
            this.tabPage7.Controls.Add(this.label12);
            this.tabPage7.Controls.Add(this.textBoxSectionSearch);
            this.tabPage7.Controls.Add(this.comboBoxCourseCodeSearch);
            this.tabPage7.Controls.Add(this.label13);
            this.tabPage7.Location = new System.Drawing.Point(4, 32);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1001, 216);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Search by Section";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(620, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 23);
            this.label12.TabIndex = 16;
            this.label12.Text = "Section";
            // 
            // textBoxSectionSearch
            // 
            this.textBoxSectionSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSectionSearch.Location = new System.Drawing.Point(635, 92);
            this.textBoxSectionSearch.Name = "textBoxSectionSearch";
            this.textBoxSectionSearch.Size = new System.Drawing.Size(37, 30);
            this.textBoxSectionSearch.TabIndex = 15;
            this.textBoxSectionSearch.TextChanged += new System.EventHandler(this.textBoxSectionSearch_TextChanged);
            // 
            // comboBoxCourseCodeSearch
            // 
            this.comboBoxCourseCodeSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourseCodeSearch.FormattingEnabled = true;
            this.comboBoxCourseCodeSearch.Location = new System.Drawing.Point(449, 92);
            this.comboBoxCourseCodeSearch.Name = "comboBoxCourseCodeSearch";
            this.comboBoxCourseCodeSearch.Size = new System.Drawing.Size(170, 31);
            this.comboBoxCourseCodeSearch.TabIndex = 14;
            this.comboBoxCourseCodeSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourseCodeSearch_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(318, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 23);
            this.label13.TabIndex = 13;
            this.label13.Text = "Course Code";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.textBoxSearchLastEYCI);
            this.tabPage5.Location = new System.Drawing.Point(4, 32);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1001, 216);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Find Student Number by Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label8.Location = new System.Drawing.Point(376, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Last Name";
            // 
            // textBoxSearchLastEYCI
            // 
            this.textBoxSearchLastEYCI.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.textBoxSearchLastEYCI.Location = new System.Drawing.Point(482, 86);
            this.textBoxSearchLastEYCI.Name = "textBoxSearchLastEYCI";
            this.textBoxSearchLastEYCI.Size = new System.Drawing.Size(145, 30);
            this.textBoxSearchLastEYCI.TabIndex = 7;
            this.textBoxSearchLastEYCI.TextChanged += new System.EventHandler(this.textBoxSearchLastEYCI_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Khaki;
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textBoxSearchLast);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1001, 216);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Search For Books by Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Last Name";
            // 
            // textBoxSearchLast
            // 
            this.textBoxSearchLast.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchLast.Location = new System.Drawing.Point(482, 86);
            this.textBoxSearchLast.Name = "textBoxSearchLast";
            this.textBoxSearchLast.Size = new System.Drawing.Size(145, 30);
            this.textBoxSearchLast.TabIndex = 5;
            this.textBoxSearchLast.TextChanged += new System.EventHandler(this.textBoxSearchLast_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.buttonCheckIn);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxTextbookBarcodeIn);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1001, 216);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Checking In Books";
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonCheckIn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckIn.Location = new System.Drawing.Point(533, 127);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(127, 44);
            this.buttonCheckIn.TabIndex = 4;
            this.buttonCheckIn.Text = "Check In Book";
            this.buttonCheckIn.UseVisualStyleBackColor = false;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Textbook Barcode";
            // 
            // textBoxTextbookBarcodeIn
            // 
            this.textBoxTextbookBarcodeIn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTextbookBarcodeIn.Location = new System.Drawing.Point(506, 61);
            this.textBoxTextbookBarcodeIn.Name = "textBoxTextbookBarcodeIn";
            this.textBoxTextbookBarcodeIn.Size = new System.Drawing.Size(154, 30);
            this.textBoxTextbookBarcodeIn.TabIndex = 3;
            this.textBoxTextbookBarcodeIn.TextChanged += new System.EventHandler(this.textBoxTextbookBarcodeIn_TextChanged);
            this.textBoxTextbookBarcodeIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTextbookBarcodeIn_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.textBoxSection);
            this.tabPage1.Controls.Add(this.textBoxStudentNumber);
            this.tabPage1.Controls.Add(this.textBoxTextbookBarcodeOut);
            this.tabPage1.Controls.Add(this.comboBoxCourseCode);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.buttonCheckOut);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBoxTextbooks);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBoxTeachers);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1001, 216);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Checking Out Books";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(803, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "Section";
            // 
            // textBoxSection
            // 
            this.textBoxSection.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSection.Location = new System.Drawing.Point(818, 97);
            this.textBoxSection.Name = "textBoxSection";
            this.textBoxSection.Size = new System.Drawing.Size(37, 30);
            this.textBoxSection.TabIndex = 11;
            // 
            // textBoxStudentNumber
            // 
            this.textBoxStudentNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentNumber.Location = new System.Drawing.Point(168, 25);
            this.textBoxStudentNumber.MaxLength = 9;
            this.textBoxStudentNumber.Name = "textBoxStudentNumber";
            this.textBoxStudentNumber.Size = new System.Drawing.Size(170, 30);
            this.textBoxStudentNumber.TabIndex = 0;
            this.textBoxStudentNumber.TextChanged += new System.EventHandler(this.textBoxStudentNumber_TextChanged);
            this.textBoxStudentNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxStudentNumber_KeyDown);
            // 
            // textBoxTextbookBarcodeOut
            // 
            this.textBoxTextbookBarcodeOut.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTextbookBarcodeOut.Location = new System.Drawing.Point(168, 97);
            this.textBoxTextbookBarcodeOut.Name = "textBoxTextbookBarcodeOut";
            this.textBoxTextbookBarcodeOut.Size = new System.Drawing.Size(170, 30);
            this.textBoxTextbookBarcodeOut.TabIndex = 1;
            this.textBoxTextbookBarcodeOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTextbookBarcodeOut_KeyDown);
            // 
            // comboBoxCourseCode
            // 
            this.comboBoxCourseCode.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourseCode.FormattingEnabled = true;
            this.comboBoxCourseCode.Location = new System.Drawing.Point(571, 97);
            this.comboBoxCourseCode.Name = "comboBoxCourseCode";
            this.comboBoxCourseCode.Size = new System.Drawing.Size(230, 31);
            this.comboBoxCourseCode.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(440, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Course Code";
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonCheckOut.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckOut.Location = new System.Drawing.Point(838, 148);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(112, 56);
            this.buttonCheckOut.TabIndex = 2;
            this.buttonCheckOut.Text = "Check Out Book";
            this.buttonCheckOut.UseVisualStyleBackColor = false;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Textbook Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Teacher";
            // 
            // comboBoxTextbooks
            // 
            this.comboBoxTextbooks.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTextbooks.FormattingEnabled = true;
            this.comboBoxTextbooks.Location = new System.Drawing.Point(571, 162);
            this.comboBoxTextbooks.Name = "comboBoxTextbooks";
            this.comboBoxTextbooks.Size = new System.Drawing.Size(230, 31);
            this.comboBoxTextbooks.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Textbook Barcode";
            // 
            // comboBoxTeachers
            // 
            this.comboBoxTeachers.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTeachers.FormattingEnabled = true;
            this.comboBoxTeachers.Location = new System.Drawing.Point(571, 28);
            this.comboBoxTeachers.Name = "comboBoxTeachers";
            this.comboBoxTeachers.Size = new System.Drawing.Size(230, 31);
            this.comboBoxTeachers.TabIndex = 5;
            this.comboBoxTeachers.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeachers_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 252);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.comboBoxSearchByTeach);
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1001, 216);
            this.tabPage4.TabIndex = 7;
            this.tabPage4.Text = "Search by Teacher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(334, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Teacher";
            // 
            // comboBoxSearchByTeach
            // 
            this.comboBoxSearchByTeach.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchByTeach.FormattingEnabled = true;
            this.comboBoxSearchByTeach.Location = new System.Drawing.Point(465, 87);
            this.comboBoxSearchByTeach.Name = "comboBoxSearchByTeach";
            this.comboBoxSearchByTeach.Size = new System.Drawing.Size(230, 31);
            this.comboBoxSearchByTeach.TabIndex = 8;
            this.comboBoxSearchByTeach.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchByTeach_SelectedIndexChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage6.Controls.Add(this.comboBoxSearchByCourse);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Location = new System.Drawing.Point(4, 32);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1001, 216);
            this.tabPage6.TabIndex = 8;
            this.tabPage6.Text = "Search by Course";
            // 
            // comboBoxSearchByCourse
            // 
            this.comboBoxSearchByCourse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchByCourse.FormattingEnabled = true;
            this.comboBoxSearchByCourse.Location = new System.Drawing.Point(474, 89);
            this.comboBoxSearchByCourse.Name = "comboBoxSearchByCourse";
            this.comboBoxSearchByCourse.Size = new System.Drawing.Size(230, 31);
            this.comboBoxSearchByCourse.TabIndex = 12;
            this.comboBoxSearchByCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchByCourse_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(343, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Course Code";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.LawnGreen;
            this.tabPage8.Controls.Add(this.comboBoxCourseTC);
            this.tabPage8.Controls.Add(this.label15);
            this.tabPage8.Controls.Add(this.label14);
            this.tabPage8.Controls.Add(this.comboBoxTeachTC);
            this.tabPage8.Location = new System.Drawing.Point(4, 32);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1001, 216);
            this.tabPage8.TabIndex = 9;
            this.tabPage8.Text = "Search by Teacher and Course";
            // 
            // comboBoxCourseTC
            // 
            this.comboBoxCourseTC.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourseTC.FormattingEnabled = true;
            this.comboBoxCourseTC.Location = new System.Drawing.Point(481, 125);
            this.comboBoxCourseTC.Name = "comboBoxCourseTC";
            this.comboBoxCourseTC.Size = new System.Drawing.Size(230, 31);
            this.comboBoxCourseTC.TabIndex = 14;
            this.comboBoxCourseTC.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourseTC_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(350, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 23);
            this.label15.TabIndex = 13;
            this.label15.Text = "Course Code";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(350, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 23);
            this.label14.TabIndex = 11;
            this.label14.Text = "Teacher";
            // 
            // comboBoxTeachTC
            // 
            this.comboBoxTeachTC.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTeachTC.FormattingEnabled = true;
            this.comboBoxTeachTC.Location = new System.Drawing.Point(481, 54);
            this.comboBoxTeachTC.Name = "comboBoxTeachTC";
            this.comboBoxTeachTC.Size = new System.Drawing.Size(230, 31);
            this.comboBoxTeachTC.TabIndex = 10;
            this.comboBoxTeachTC.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeachTC_SelectedIndexChanged);
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.SandyBrown;
            this.tabPage9.Controls.Add(this.buttonListAll);
            this.tabPage9.Location = new System.Drawing.Point(4, 32);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1001, 216);
            this.tabPage9.TabIndex = 10;
            this.tabPage9.Text = "List All Checked Out Books";
            // 
            // buttonListAll
            // 
            this.buttonListAll.BackColor = System.Drawing.Color.Lime;
            this.buttonListAll.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListAll.Location = new System.Drawing.Point(438, 73);
            this.buttonListAll.Name = "buttonListAll";
            this.buttonListAll.Size = new System.Drawing.Size(181, 57);
            this.buttonListAll.TabIndex = 0;
            this.buttonListAll.Text = "List All Checked Out Books";
            this.buttonListAll.UseVisualStyleBackColor = false;
            this.buttonListAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.Red;
            this.tabPage10.Controls.Add(this.buttonEYCICANCEL);
            this.tabPage10.Controls.Add(this.buttonEYCIOK);
            this.tabPage10.Controls.Add(this.labelDeleteEYCI);
            this.tabPage10.Location = new System.Drawing.Point(4, 32);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1001, 216);
            this.tabPage10.TabIndex = 11;
            this.tabPage10.Text = "Delete Students (Text file Imported)";
            // 
            // buttonEYCICANCEL
            // 
            this.buttonEYCICANCEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonEYCICANCEL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEYCICANCEL.Location = new System.Drawing.Point(854, 135);
            this.buttonEYCICANCEL.Name = "buttonEYCICANCEL";
            this.buttonEYCICANCEL.Size = new System.Drawing.Size(107, 59);
            this.buttonEYCICANCEL.TabIndex = 2;
            this.buttonEYCICANCEL.Text = "CANCEL";
            this.buttonEYCICANCEL.UseVisualStyleBackColor = false;
            this.buttonEYCICANCEL.Visible = false;
            this.buttonEYCICANCEL.Click += new System.EventHandler(this.buttonEYCICANCEL_Click);
            // 
            // buttonEYCIOK
            // 
            this.buttonEYCIOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonEYCIOK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEYCIOK.Location = new System.Drawing.Point(632, 135);
            this.buttonEYCIOK.Name = "buttonEYCIOK";
            this.buttonEYCIOK.Size = new System.Drawing.Size(111, 59);
            this.buttonEYCIOK.TabIndex = 1;
            this.buttonEYCIOK.Text = "OK";
            this.buttonEYCIOK.UseVisualStyleBackColor = false;
            this.buttonEYCIOK.Click += new System.EventHandler(this.buttonEYCIOK_Click);
            // 
            // labelDeleteEYCI
            // 
            this.labelDeleteEYCI.AutoSize = true;
            this.labelDeleteEYCI.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteEYCI.Location = new System.Drawing.Point(17, 24);
            this.labelDeleteEYCI.Name = "labelDeleteEYCI";
            this.labelDeleteEYCI.Size = new System.Drawing.Size(980, 23);
            this.labelDeleteEYCI.TabIndex = 0;
            this.labelDeleteEYCI.Text = "WARNING: This button will delete all the information that was imported from a tex" +
    "t file. ";
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.Color.DarkRed;
            this.tabPage11.Controls.Add(this.buttonCancelDelDatabase);
            this.tabPage11.Controls.Add(this.buttonDeleteDatabase);
            this.tabPage11.Controls.Add(this.labelDeleteData);
            this.tabPage11.Location = new System.Drawing.Point(4, 32);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(1001, 216);
            this.tabPage11.TabIndex = 12;
            this.tabPage11.Text = "Delete Database";
            // 
            // buttonCancelDelDatabase
            // 
            this.buttonCancelDelDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCancelDelDatabase.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelDelDatabase.Location = new System.Drawing.Point(854, 135);
            this.buttonCancelDelDatabase.Name = "buttonCancelDelDatabase";
            this.buttonCancelDelDatabase.Size = new System.Drawing.Size(107, 59);
            this.buttonCancelDelDatabase.TabIndex = 4;
            this.buttonCancelDelDatabase.Text = "CANCEL";
            this.buttonCancelDelDatabase.UseVisualStyleBackColor = false;
            this.buttonCancelDelDatabase.Visible = false;
            this.buttonCancelDelDatabase.Click += new System.EventHandler(this.buttonCancelDelDatabase_Click);
            // 
            // buttonDeleteDatabase
            // 
            this.buttonDeleteDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonDeleteDatabase.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteDatabase.Location = new System.Drawing.Point(632, 135);
            this.buttonDeleteDatabase.Name = "buttonDeleteDatabase";
            this.buttonDeleteDatabase.Size = new System.Drawing.Size(111, 59);
            this.buttonDeleteDatabase.TabIndex = 3;
            this.buttonDeleteDatabase.Text = "OK";
            this.buttonDeleteDatabase.UseVisualStyleBackColor = false;
            this.buttonDeleteDatabase.Click += new System.EventHandler(this.buttonDeleteDatabase_Click);
            // 
            // labelDeleteData
            // 
            this.labelDeleteData.AutoSize = true;
            this.labelDeleteData.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteData.Location = new System.Drawing.Point(21, 24);
            this.labelDeleteData.Name = "labelDeleteData";
            this.labelDeleteData.Size = new System.Drawing.Size(922, 25);
            this.labelDeleteData.TabIndex = 0;
            this.labelDeleteData.Text = "WARNING: This button deletes the database with the checked out textbooks.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1030, 553);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Textbook Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSectionSearch;
        private System.Windows.Forms.ComboBox comboBoxCourseCodeSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSearchLastEYCI;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSearchLast;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTextbookBarcodeIn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxSection;
        private System.Windows.Forms.TextBox textBoxStudentNumber;
        private System.Windows.Forms.TextBox textBoxTextbookBarcodeOut;
        private System.Windows.Forms.ComboBox comboBoxCourseCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTextbooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTeachers;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSearchByTeach;
        private System.Windows.Forms.ComboBox comboBoxSearchByCourse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.ComboBox comboBoxCourseTC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxTeachTC;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button buttonListAll;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Button buttonEYCICANCEL;
        private System.Windows.Forms.Button buttonEYCIOK;
        private System.Windows.Forms.Label labelDeleteEYCI;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.Label labelDeleteData;
        private System.Windows.Forms.Button buttonCancelDelDatabase;
        private System.Windows.Forms.Button buttonDeleteDatabase;
    }
}

