using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Textbook_Tracker
{
    public partial class Form1 : Form
    {
        DataGrid myDataGrid;

        SqlConnection databaseConnection;
        SqlCommand myCommand;
        SqlDataReader sqlReader;

        StringReader myStringReader;

        String connectionString, filterString, studentsTeacher, studentsTextbook, course, section, updateCommand, insertCommand, printString;
        int studentNumber, deleteEYCIIndex, deleteDataIndex; /*textbookBarcode, checkInBarcode; */
        double textbookBarcode, checkInBarcode;
        String[] teacher, textbook, courseCodes;
        Boolean inFormLoad;

        public Form1()
        {
            InitializeComponent();

            connectionString = "Data Source=DBNAME; Initial Catalog = TextbookTrackerDbo; User ID=username; Password =password;";
            databaseConnection = new SqlConnection(connectionString);
            myCommand = databaseConnection.CreateCommand();

            deleteEYCIIndex = 0;
            deleteDataIndex = 0;

            teacher = new String[17];
            teacher[0] = "teacher0";
            teacher[1] = "teacher1";
            teacher[2] = "teacher2";
            teacher[3] = "teacher3";
            teacher[4] = "teacher4";
            teacher[5] = "teacher5";
            teacher[6] = "teacher6";
            teacher[7] = "teacher7";
            teacher[8] = "teacher8";
            teacher[9] = "teacher9";
            teacher[10] = "teacher10";
            teacher[11] = "teacher11";
            teacher[12] = "teacher12";
            teacher[13] = "teacher13";
            teacher[14] = "teacher14";
            teacher[15] = "teacher15";
            teacher[16] = "teacher16";

            courseCodes = new String[14];
            courseCodes[0] = "MFM1P1";
            courseCodes[1] = "MPM1D1";
            courseCodes[2] = "MPM1D3";
            courseCodes[3] = "MFM2P1";
            courseCodes[4] = "MPM2D1";
            courseCodes[5] = "MPM2D3";
            courseCodes[6] = "MBF3C1";
            courseCodes[7] = "MCF3M1";
            courseCodes[8] = "MCR3U1";
            courseCodes[9] = "MCR3U3";
            courseCodes[10] = "MAP4C1";
            courseCodes[11] = "MDM4U1";
            courseCodes[12] = "MHF4U1";
            courseCodes[13] = "MCV4U1";

            textbook = new String[11];
            textbook[0] = "Mathematics 9 Applying the Concepts";
            textbook[1] = "Principles of Mathematics 9";
            textbook[2] = "Mathematics 10 Applying the Concepts";
            textbook[3] = "Principles of Mathematics 10";
            textbook[4] = "Foundations for College Math";
            textbook[5] = "Functions and Applications 11";
            textbook[6] = "Mathematics 11";
            textbook[7] = "Grade 12 College Mathematics";
            textbook[8] = "Math of Data Management";
            textbook[9] = "Advanced Functions";
            textbook[10] = "Calculus and Vectors";

            myDataGrid = new DataGrid(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inFormLoad = true;

            for (int i = 0; i < teacher.Length; i++)
            {
                comboBoxTeachers.Items.Add(teacher[i]);
                comboBoxSearchByTeach.Items.Add(teacher[i]);
                comboBoxTeachTC.Items.Add(teacher[i]);
            }

            for (int i = 0; i < courseCodes.Length; i++)
            {
                comboBoxCourseCode.Items.Add(courseCodes[i]);
                comboBoxCourseCodeSearch.Items.Add(courseCodes[i]);
                comboBoxSearchByCourse.Items.Add(courseCodes[i]);
                comboBoxCourseTC.Items.Add(courseCodes[i]);
            }

            for (int i = 0; i < textbook.Length; i++)
            {
                comboBoxTextbooks.Items.Add(textbook[i]);
            }

            comboBoxTeachers.SelectedIndex = 0;
            comboBoxCourseCode.SelectedIndex = 0;
            comboBoxCourseCodeSearch.SelectedIndex = 0;
            comboBoxTextbooks.SelectedIndex = 0;
            comboBoxSearchByTeach.SelectedIndex = 0;
            comboBoxSearchByCourse.SelectedIndex = 0;
            comboBoxTeachTC.SelectedIndex = 0;
            comboBoxCourseTC.SelectedIndex = 0;

            inFormLoad = false;
            textBoxStudentNumber.Select();
        }

        private void textBoxStudentNumber_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStudentNumber.Text.Length == 9)
            {
                Boolean go = true;
                try
                {
                    studentNumber = int.Parse(textBoxStudentNumber.Text);
                }

                catch (FormatException)
                {
                    go = false;
                }

                if (go)
                {
                    if (myDataGrid.HasBooksOut(studentNumber))
                    {
                        filterString = "Number = '" + studentNumber.ToString() + "' AND CheckedIn = 'false'";
                        myDataGrid.SetDisplayInfo(filterString);
                        dataGridView.DataSource = myDataGrid.GetDataView();
                        SetReadOnly();
                    }

                    else
                    {
                        filterString = "Number = '" + studentNumber.ToString() + "'";
                        myDataGrid.SetDisplayInfoEYCI(filterString);
                        dataGridView.DataSource = myDataGrid.GetDataView();
                        SetReadOnly();
                    }
                }
    //            MessageBox.Show(myDataGrid.GetString());
            }
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            Boolean go = true;

            try
            {
                studentNumber = int.Parse(textBoxStudentNumber.Text);
                textbookBarcode = double.Parse(textBoxTextbookBarcodeOut.Text);
            }

            catch (FormatException)
            {
                go = false;
                MessageBox.Show("Error: Student number or textbook barcode invalid.");
            }

            if (go)
            {
                Boolean shouldntGo = true;
                databaseConnection.Open();
                myCommand.CommandText = "SELECT Number FROM dbo.EYCI";
                sqlReader = myCommand.ExecuteReader();

                while (sqlReader.Read())
                {
                    if (studentNumber.ToString() == sqlReader["Number"].ToString())
                    {
                        shouldntGo = false;
                    }
                }

                sqlReader.Close();
                databaseConnection.Close();

                if (shouldntGo == false)
                {
                    studentsTeacher = teacher[comboBoxTeachers.SelectedIndex];
                    studentsTextbook = textbook[comboBoxTextbooks.SelectedIndex];
                    course = courseCodes[comboBoxCourseCode.SelectedIndex];
                    section  = textBoxSection.Text;

                    databaseConnection.Open();
                    myCommand.CommandText = "SELECT TextbookNumber, CheckedIn FROM dbo.TextbookTable";
                    sqlReader = myCommand.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        if (textbookBarcode.ToString() == sqlReader["TextbookNumber"].ToString() && sqlReader["CheckedIn"].ToString() == "false")
                        {
                            shouldntGo = true;
                        }
                    }

                    sqlReader.Close();
                    databaseConnection.Close();

                    if (shouldntGo == false)
                    {
                        /*           updateCommand = "UPDATE dbo.EYCI SET TextbookNumber = '" + textbookBarcode.ToString() + "', TextbookName = '" + studentsTextbook + "', TeacherName = '" + studentsTeacher + "', CheckedIn = 'false' WHERE Number = '" + studentNumber.ToString() + "'";
                                   myCommand.CommandText = updateCommand;

                                   databaseConnection.Open();
                                   myCommand.ExecuteNonQuery();
                                   databaseConnection.Close(); */

                        myDataGrid.FindInfoFromEYCI(studentNumber);
                        insertCommand = myDataGrid.GetInfo();

                        insertCommand = insertCommand + ", '" + course + "', '" + section + "', '" + textbookBarcode.ToString() + "', '" + studentsTextbook + "', '" + studentsTeacher + "', 'false')";

                        myDataGrid.AddPersonToDatabase(insertCommand);

                        filterString = "Number = '" + studentNumber.ToString() + "' AND CheckedIn = 'false'";

                        myDataGrid.SetDisplayInfo(filterString);
                        dataGridView.DataSource = myDataGrid.GetDataView();
                        SetReadOnly();

                        textBoxStudentNumber.Clear();
                        textBoxTextbookBarcodeOut.Clear();
                    }

                    else
                    {
                        MessageBox.Show("This textbook is still checked out by another student!");
                    }
                }

                else
                {
                    MessageBox.Show("There is no student in the database with this student number.");
                }
            }
       //     MessageBox.Show(myDataGrid.GetString());
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            Boolean go = true;
            try
            {
                checkInBarcode = double.Parse(textBoxTextbookBarcodeIn.Text);
            }

            catch (FormatException)
            {
                go = false;
                MessageBox.Show("Error: Textbook barcode invalid.");
            }

            if (go)
            {
                Boolean shouldntGo = true;
                databaseConnection.Open();
                myCommand.CommandText = "SELECT TextbookNumber FROM dbo.TextbookTable";
                sqlReader = myCommand.ExecuteReader();

                while (sqlReader.Read())
                {
                    if (checkInBarcode.ToString() == sqlReader["TextbookNumber"].ToString())
                    {
                        shouldntGo = false;
                    }
                }
                sqlReader.Close();
                databaseConnection.Close();

                if (shouldntGo == false)
                {
                    filterString = "TextbookNumber = '" + checkInBarcode.ToString() + "'";

                    updateCommand = "UPDATE dbo.TextbookTable SET CheckedIn = 'true' WHERE TextbookNumber = '" + checkInBarcode + "'";
                    myCommand.CommandText = updateCommand;

                    databaseConnection.Open();
                    myCommand.ExecuteNonQuery();
                    databaseConnection.Close();

                    myDataGrid.SetDisplayInfo(filterString);
                    dataGridView.DataSource = myDataGrid.GetDataView();
                    SetReadOnly();

                    textBoxTextbookBarcodeIn.Clear();
                }

                else
                {
                    MessageBox.Show("There is no student in the database that has checked out this textbook.");
                }
            }
        }

        private void textBoxSearchLast_TextChanged(object sender, EventArgs e)
        {
            string searchLast;
            searchLast = textBoxSearchLast.Text;
            filterString = "Last = '" + searchLast + "' AND CheckedIn = 'false'";;
            myDataGrid.SetDisplayInfo(filterString);
            dataGridView.DataSource = myDataGrid.GetDataView();
            SetReadOnly();
        }

        private void textBoxSearchLastEYCI_TextChanged(object sender, EventArgs e)
        {
            string searchLast;
            searchLast = textBoxSearchLastEYCI.Text;
            filterString = "Last = '" + searchLast + "'";
            myDataGrid.SetDisplayInfoEYCI(filterString);
            dataGridView.DataSource = myDataGrid.GetDataView();
            SetReadOnly();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPosition = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;
            Font printFont = new Font("Times New Roman", 10);
            SolidBrush myBrush = new SolidBrush(Color.Black);
            // Work out the number of lines per page, using the MarginBounds.
            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
            // Iterate over the string using the StringReader, printing each line.
            while (count < linesPerPage && ((line = myStringReader.ReadLine()) != null))
            {
                // calculate the next line position based on the height of the font according to the printing device
                yPosition = topMargin + (count * printFont.GetHeight(ev.Graphics));
                // draw the next line in the rich edit control
                ev.Graphics.DrawString(line, printFont, myBrush, leftMargin, yPosition, new StringFormat());
                count++;
            }
            // If there are more lines, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
            myBrush.Dispose();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SetPrintString();
                string strText = printString; // read string from editor window
                myStringReader = new StringReader(strText);
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog(); // instantiate new print preview dialog
                printPreviewDialog1.Document = this.printDocument1;
                //        printPreviewDialog1.BorderStyle = FormBorderStyle.Fixed3D;
                printPreviewDialog1.ShowDialog(); // Show the print preview dialog, uses print page event to draw preview screen
            }
            catch (Exception exp)
            {
                System.Console.WriteLine(exp.Message.ToString());
            } 
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            SetPrintString();
            string strText = printString;
            myStringReader = new StringReader(strText);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxTextbookBarcodeOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCheckOut_Click(sender, e);
            }
        }

        private void textBoxStudentNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCheckOut_Click(sender, e);
            }
        }

        private void textBoxTextbookBarcodeIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCheckIn_Click(sender, e);
            }
        }

        private void textBoxTextbookBarcodeIn_TextChanged(object sender, EventArgs e)
        {
            Boolean go = true;
     //       MessageBox.Show("Incase");
            try
            {
                checkInBarcode = double.Parse(textBoxTextbookBarcodeIn.Text);
            }

            catch (FormatException)
            {
                go = false;
            }

            if (go)
            {
                filterString = "TextbookNumber = '" + checkInBarcode.ToString() + "' AND CheckedIn = 'false'";
                myDataGrid.SetDisplayInfo(filterString);
                dataGridView.DataSource = myDataGrid.GetDataView();
                SetReadOnly();
            }
        }

        private void textBoxSectionSearch_TextChanged(object sender, EventArgs e)
        {
            course = courseCodes[comboBoxCourseCodeSearch.SelectedIndex];
            section = textBoxSectionSearch.Text;

            filterString = "Course = '" + course + "' AND Section = '" + section + "' AND CheckedIn = 'false'";
            myDataGrid.SetDisplayInfo(filterString);
            dataGridView.DataSource = myDataGrid.GetDataView();
            SetReadOnly();
        }

        private void comboBoxCourseCodeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inFormLoad == false)
            {
                course = courseCodes[comboBoxCourseCodeSearch.SelectedIndex];
                section = textBoxSectionSearch.Text;

                filterString = "Course = '" + course + "' AND Section = '" + section + "' AND CheckedIn = 'false'";
                myDataGrid.SetDisplayInfo(filterString);
                dataGridView.DataSource = myDataGrid.GetDataView();
                SetReadOnly();
            }
        }

        private void comboBoxSearchByTeach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inFormLoad == false)
            {
                studentsTeacher = teacher[comboBoxSearchByTeach.SelectedIndex];
                filterString = "TeacherName = '" + studentsTeacher + "' AND CheckedIn = 'false'";
                myDataGrid.SetDisplayInfo(filterString);
                dataGridView.DataSource = myDataGrid.GetDataView();
                SetReadOnly();
            }
        }

        private void comboBoxSearchByCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inFormLoad == false)
            {
                course = courseCodes[comboBoxSearchByCourse.SelectedIndex];
                filterString = "Course = '" + course + "' AND CheckedIn = 'false'";
                myDataGrid.SetDisplayInfo(filterString);
                dataGridView.DataSource = myDataGrid.GetDataView();
                SetReadOnly();
            }
        }

        private void comboBoxTeachTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inFormLoad == false)
            {
                studentsTeacher = teacher[comboBoxTeachTC.SelectedIndex];
                course = courseCodes[comboBoxCourseTC.SelectedIndex];
                filterString = "Course = '" + course + "' AND TeacherName = '" + studentsTeacher + "' AND CheckedIn = 'false'";
                myDataGrid.SetDisplayInfo(filterString);
                dataGridView.DataSource = myDataGrid.GetDataView();
                SetReadOnly();
            }
        }

        private void comboBoxCourseTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inFormLoad == false)
            {
                studentsTeacher = teacher[comboBoxTeachTC.SelectedIndex];
                course = courseCodes[comboBoxCourseTC.SelectedIndex];
                filterString = "Course = '" + course + "' AND TeacherName = '" + studentsTeacher + "' AND CheckedIn = 'false'";
                myDataGrid.SetDisplayInfo(filterString);
                dataGridView.DataSource = myDataGrid.GetDataView();
                SetReadOnly();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterString = "CheckedIn = 'false'";
            myDataGrid.SetDisplayInfo(filterString);
            dataGridView.DataSource = myDataGrid.GetDataView();
            SetReadOnly();
        }

        private void buttonEYCIOK_Click(object sender, EventArgs e)
        {
            deleteEYCIIndex++;

            if (deleteEYCIIndex == 1)
            {
                labelDeleteEYCI.Text = "All data will not be retrievable.";
                buttonEYCICANCEL.Visible = true;
            }

            else if (deleteEYCIIndex == 2)
            {
                labelDeleteEYCI.Text = "The program will be unable to function until new student information is imported.";
            }

            else if (deleteEYCIIndex == 3)
            {
                labelDeleteEYCI.Text = "Do you still wish to proceed?";
            }

            else if (deleteEYCIIndex == 4)
            {
                labelDeleteEYCI.Text = "This is the absolute last warning. Are you absolutely sure you wish to proceed?";
            }

            else if (deleteEYCIIndex == 5)
            {
                labelDeleteEYCI.Text = "All student information has been deleted.";
                buttonEYCICANCEL.Visible = false;

                databaseConnection.Open();
                myCommand.CommandText = "DROP TABLE dbo.EYCI";

                try
                {
                    myCommand.ExecuteNonQuery();
                }

                catch (Exception)
                {
                    deleteEYCIIndex = 0;
                    labelDeleteEYCI.Text = "WARNING: This button will delete all the student information.";
                    MessageBox.Show("The student information does not exist and cannot be deleted.");
                }

                databaseConnection.Close();
            }

            else
            {
                deleteEYCIIndex = 0;
                labelDeleteEYCI.Text = "WARNING: This button will delete all the student information.";
            }
        }

        private void buttonEYCICANCEL_Click(object sender, EventArgs e)
        {
            deleteEYCIIndex = 0;
            labelDeleteEYCI.Text = "WARNING: This button will delete all the student information.";
            buttonEYCICANCEL.Visible = false;
        }

        private void buttonDeleteDatabase_Click(object sender, EventArgs e)
        {
            deleteDataIndex++;

            if (deleteDataIndex == 1)
            {
                labelDeleteData.Text = "All data will be lost forever.";
                buttonCancelDelDatabase.Visible = true;
            }

            else if (deleteDataIndex == 2)
            {
                labelDeleteData.Text = "The database and all information on checked out textbooks will be lost.";
            }

            else if (deleteDataIndex == 3)
            {
                labelDeleteData.Text = "Do you still wish to proceed?";
            }

            else if (deleteDataIndex == 4)
            {
                labelDeleteData.Text = "This is the absolute last warning. There's no turning back. Continue?";
            }

            else if (deleteDataIndex == 5)
            {
                labelDeleteData.Text = "The old database has been deleted and a new one has been created.";
                buttonCancelDelDatabase.Visible = false;

                myCommand.CommandText = "DROP TABLE dbo.TextbookTable";

                databaseConnection.Open();
                myCommand.ExecuteNonQuery();

                myCommand.CommandText = "CREATE TABLE dbo.TextbookTable(Last text,First varchar(50), Gender text,Number varchar(50),HF1 text,[DOB(YearMMDD)] text,Courses text,Course text,Section text,TextbookNumber varchar(50),TextbookName text,TeacherName text,CheckedIn text)";
                myCommand.ExecuteNonQuery();

                databaseConnection.Close();
            }

            else
            {
                deleteDataIndex = 0;
                labelDeleteData.Text = "WARNING: This button deletes the database with the checked out textbooks.";
            }
        }

        private void buttonCancelDelDatabase_Click(object sender, EventArgs e)
        {
            deleteDataIndex = 0;
            labelDeleteData.Text = "WARNING: This button deletes the database with the checked out textbooks.";
            buttonCancelDelDatabase.Visible = false;
        }

        private void SetReadOnly()
        {
            int rowNum, columnNum;
            rowNum = dataGridView.RowCount;
            columnNum = dataGridView.ColumnCount;
            for (int i = 0; i < rowNum; i++)
            {
                dataGridView.Rows[i].Cells[3].ReadOnly = true;

                if (columnNum >= 6)
                {
                    dataGridView.Rows[i].Cells[6].ReadOnly = true;
                }
            }
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //      dataGridView.Rows[0].Cells[0].ReadOnly = true;
            /*     DataTable dt;
                 DataSet myDataSet;
                 dt = dataGridView.DataSource;
             //    dataGridView.DataSource;
                 MessageBox.Show("k"); */

            //       int r = dataGridView.CurrentCell.RowIndex;
            //  int c = dataGridView.CurrentCell.Selected;
            string columnName = "";
            string value;
            double barNum;

            /*         for (int i = 0; i < 4; i++)
                     {
                         if (dataGridView.CurrentCell.Selected)
                         {
                             v = dataGridView.Rows[r].Cells[i].Value.ToString();
                         }
                     } */

            //         columnName = dataGridView.Rows[r].Cells[e.ColumnIndex].Value.ToString() + dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

            int r = e.RowIndex;

            if (e.ColumnIndex == 0)
            {
                columnName = "Last";
            }

            else if (e.ColumnIndex == 1)
            {
                columnName = "First";
            }

            else if (e.ColumnIndex == 2)
            {
                columnName = "Gender";
            }

            else if (e.ColumnIndex == 4)
            {
                columnName = "Course";
            }

            else if (e.ColumnIndex == 5)
            {
                columnName = "Section";
            }

            else if (e.ColumnIndex == 6)
            {
                columnName = "TextbookNumber";
            }

            else if (e.ColumnIndex == 7)
            {
                columnName = "TextbookName";
            }

            else if (e.ColumnIndex == 8)
            {
                columnName = "TeacherName";
            }

            else if (e.ColumnIndex == 9)
            {
                columnName = "CheckedIn";
            }

            value = dataGridView.Rows[r].Cells[e.ColumnIndex].Value.ToString();
            barNum = double.Parse(dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString());

            updateCommand = "UPDATE dbo.TextbookTable SET " + columnName + " = '" + value + "' WHERE TextbookNumber = '" + barNum.ToString() + "'";

            myCommand.CommandText = updateCommand;

            databaseConnection.Open();
            myCommand.ExecuteNonQuery();
            databaseConnection.Close();
            //    MessageBox.Show(columnName + " " + value + " " + studentNum);
        }

        public void SetPrintString()
        {
            if (dataGridView.ColumnCount <= 4)
            {
                printString = "Last, First, Gender, Student Number" + Environment.NewLine + Environment.NewLine;
            }

            else
            {
                printString = "Last, First, Gender, Student Number, Course, Section, Textbook Barcode, Textbook Name, Teacher Name, Checked In" + Environment.NewLine + Environment.NewLine;
            }

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    if (j == dataGridView.ColumnCount - 1)
                    {
                        printString = printString + dataGridView.Rows[i].Cells[j].Value.ToString() + Environment.NewLine;
                    }

                    else
                    {
                        printString = printString + dataGridView.Rows[i].Cells[j].Value.ToString() + ", ";
                    }
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
