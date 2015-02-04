using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Textbook_Tracker
{
    class DataGrid
    {
        SqlConnection databaseConnection;
        DataSet myDataSet;
        DataView myDataView;
        SqlDataAdapter adapter;
        SqlCommand myCommand;
        SqlDataReader Reader;
        string selectAllCommand, selectAllCommandEYCI, filterString, info;//, sF;// s;
  //      string[] s, s2;
  //      int index;
   //     Boolean noBooks;

        public DataGrid(string connection)
        {
            selectAllCommand = "SELECT Last, First, Gender, Number, Course, Section, TextBookNumber, TextbookName, TeacherName, CheckedIn FROM dbo.TextbookTable";
            selectAllCommandEYCI = "SELECT Last, First, Gender, Number FROM dbo.EYCI";
            databaseConnection = new SqlConnection(connection);
            myCommand = databaseConnection.CreateCommand();
  //          s = new string[2000];
  //          index = 0;
        }

        public void SetDisplayInfo(string filter)
        {
            filterString = filter;
            Console.WriteLine(filterString);
            myDataSet = new DataSet();
            myDataView = new DataView();
            myCommand.CommandText = selectAllCommand;
            adapter = new SqlDataAdapter(myCommand);
            adapter.Fill(myDataSet);
            myDataView = myDataSet.Tables[0].DefaultView;
            myDataView.RowFilter = filterString;
         
		 // OLD CODE
   /*         s = new string[2000];
            index = 0;
      //      s = "Last, First, Gender, Student Number, Course, Section, Textbook Barcode, Textbook Name, Teacher Name, Checked In" + Environment.NewLine + Environment.NewLine;
            foreach (DataRowView drv in myDataView)
            {
                s[index] += drv["Last"].ToString() + ", ";
                s[index] += drv["First"].ToString() + ", ";
                s[index] += drv["Gender"].ToString() + ", ";
                s[index] += drv["Number"].ToString() + ", ";
                s[index] += drv["Course"].ToString() + ", ";
                s[index] += drv["Section"].ToString() + ", ";
                s[index] += drv["TextbookNumber"].ToString() + ", ";
                s[index] += drv["TextbookName"].ToString() + ", ";
                s[index] += drv["TeacherName"].ToString() + ", ";
                s[index] += drv["CheckedIn"].ToString();// +Environment.NewLine;
                index++;

                if (index == s.Length)
                {
                    increaseArraySize();
                }
            }

            noBooks = false;
            Sort();
            CreatesF(); */
        }

  /*      private void increaseArraySize()
        {
            s2 = s;
            s = new string[index * 2];

            for (int i = 0; i < s2.Length; i++)
            {
                s[i] = s2[i];
            }
        }

        private void Sort()
        {
            int sorts = 1;
            string sub, sub2, temp;

            while (sorts > 0)
            {
                sorts = 0;

                for (int i = 0; i < index - 1; i++)
                {
                    sub = s[i].Substring(0, s[i].IndexOf(","));
                    sub2 = s[i + 1].Substring(0, s[i + 1].IndexOf(","));

                    if (sub.CompareTo(sub2) == 1)
                    {
                        temp = s[i];
                        s[i] = s[i + 1];
                        s[i + 1] = temp;
                        sorts++;
                    }
                }
            }
        }

        private void CreatesF()
        {
            if (noBooks == false)
            {
                sF = "Last, First, Gender, Student Number, Course, Section, Textbook Barcode, Textbook Name, Teacher Name, Checked In" + Environment.NewLine + Environment.NewLine;
            }

            else
            {
                sF = "Last, First, Gender, Student Number" + Environment.NewLine + Environment.NewLine;
            }

            for (int i = 0; i < index; i++)
            {
                sF += s[i] + Environment.NewLine;
            }

            sF = sF + Environment.NewLine;
        } */

        public void SetDisplayInfoEYCI(string filter)
        {
            filterString = filter;

            myDataSet = new DataSet();
            myDataView = new DataView();
            myCommand.CommandText = selectAllCommandEYCI;
            adapter = new SqlDataAdapter(myCommand);
            adapter.Fill(myDataSet);
            myDataView = myDataSet.Tables[0].DefaultView;
            myDataView.RowFilter = filterString;

    /*        s = new string[2000];
            index = 0;
      //      s = "Last, First, Gender, Student Number" + Environment.NewLine + Environment.NewLine;
            foreach (DataRowView drv in myDataView)
            {
                s[index] += drv["Last"].ToString() + ", ";
                s[index] += drv["First"].ToString() + ", ";
                s[index] += drv["Gender"].ToString() + ", ";
                s[index] += drv["Number"].ToString();
    //            s += drv["TextbookNumber"].ToString() + ", ";
    //            s += drv["TextbookName"].ToString() + ", ";
    //            s += drv["TeacherName"].ToString() + ", ";
    //            s += drv["CheckedIn"].ToString() + Environment.NewLine;
                index++;

                if (index == s.Length)
                {
                    increaseArraySize();
                }
            }

            noBooks = true;
            Sort();
            CreatesF(); */
        }

  /*      public string GetString()
        {
            return sF;
        } */

        public DataView GetDataView()
        {
            return myDataView;
        }

        public Boolean HasBooksOut(int theStudentNumber)
        {
            Boolean BooksOut = false;
            int StudentNumber = theStudentNumber;
            myCommand.CommandText = selectAllCommand;

            databaseConnection.Open();
            Reader = myCommand.ExecuteReader();

            while(Reader.Read())
            {
                if (StudentNumber == int.Parse(Reader["Number"].ToString()) && Reader["CheckedIn"].ToString() == "false")
                {
                    BooksOut = true;
                }
            }

            databaseConnection.Close();
            return BooksOut;
        } 

        public void FindInfoFromEYCI(int theStudentNumber)
        {
            int StudentNumber = theStudentNumber;

            myCommand.CommandText = selectAllCommandEYCI;

            databaseConnection.Open();
            Reader = myCommand.ExecuteReader();

            while (Reader.Read())
            {
                if (StudentNumber == int.Parse(Reader["Number"].ToString()))
                {
                    info = "INSERT dbo.TextbookTable(Last, First, Gender, Number, Course, Section, TextBookNumber, TextbookName, TeacherName, CheckedIn) VALUES('" + Reader["Last"].ToString() + "', '" + Reader["First"].ToString() + "', '" + Reader["Gender"].ToString() + "', '" + Reader["Number"].ToString() + "'";
                }
            }

            databaseConnection.Close();
        }

        public string GetInfo()
        {
            return info;
        }

        public void AddPersonToDatabase(string theInsertCommand)
        {
            string insertCommand;
            insertCommand = theInsertCommand;
            myCommand.CommandText = insertCommand;

            databaseConnection.Open();
            myCommand.ExecuteNonQuery();
            databaseConnection.Close();
        }
    }
}
