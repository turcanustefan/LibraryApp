using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    
    public class Data
    {
        private dbConnection connection; // Database interface.
        public LogHandler logHandler;
        public Data()
        {
            connection = new dbConnection();
        }
        // LOGIN--------------------------------------------------------
        public int addUser(String _username, String _password, int _privileges)
        {

            String query = String.Format("AddUser");

            SqlParameter[] parameters = new SqlParameter[3];

            parameters[0] = new SqlParameter("@user", SqlDbType.NVarChar);
            parameters[0].Value = Convert.ToString(_username);
            parameters[1] = new SqlParameter("@pass", SqlDbType.NVarChar);
            parameters[1].Value = Convert.ToString(_password);
            parameters[2] = new SqlParameter("@privilege", SqlDbType.Int);
            parameters[2].Value = Convert.ToInt32(_privileges);
            return connection.ExecuteStoredProcedureCount(query, parameters);

        }
        public int verifyUser(String _username, String _password)
        {
            String query = String.Format("VerifyUser");

            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@username", SqlDbType.NVarChar);
            parameters[0].Value = Convert.ToString(_username);
            parameters[1] = new SqlParameter("@password", SqlDbType.NVarChar);
            parameters[1].Value = Convert.ToString(_password);
            return connection.ExecuteStoredProcedureCount(query, parameters);
        }
        public int getUserPrivilege(String _username, String _password)
        {
            String query = String.Format("GetUserPrivilege");

            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@username", SqlDbType.NVarChar);
            parameters[0].Value = Convert.ToString(_username);
            parameters[1] = new SqlParameter("@password", SqlDbType.NVarChar);
            parameters[1].Value = Convert.ToString(_password);
            return connection.ExecuteStoredProcedureCount(query, parameters);
        }
        // GET----------------------------------------------------------
        public int getBookID(String _title,String _author)
        {
            String query = String.Format("GetBookID");
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@title", SqlDbType.NVarChar);
            parameters[0].Value = Convert.ToString(_title);
            parameters[1] = new SqlParameter("@author", SqlDbType.NVarChar);
            parameters[1].Value = Convert.ToString(_author);

            return connection.ExecuteStoredProcedureCount(query, parameters);
        }
        public int getMemberID(String _name, String _surname)
        {
            String query = String.Format("GetMemberID");
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@name", SqlDbType.NVarChar);
            parameters[0].Value = Convert.ToString(_name);
            parameters[1] = new SqlParameter("@surname", SqlDbType.NVarChar);
            parameters[1].Value = Convert.ToString(_surname);
            return connection.ExecuteStoredProcedureCount(query, parameters);
        }
        public int getLoanID(int _bid, int _mid)
        {
            String query = String.Format("GetLoanID");
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@bookid", SqlDbType.Int);
            parameters[0].Value = Convert.ToString(_bid);
            parameters[1] = new SqlParameter("@memberid", SqlDbType.Int);
            parameters[1].Value = Convert.ToString(_mid);
            return connection.ExecuteStoredProcedureCount(query, parameters);
        }
        public int getBooksCount()
        {
            String query = String.Format("BookCount");
            return connection.ExecuteStoredProcedureCount(query, null);
        }
        public int getMembersCount()
        {
            String query = String.Format("MemberCount");
            return connection.ExecuteStoredProcedureCount(query, null);
        }
        public int getLoansCount()
        {
            String query = String.Format("LoanCount");
            return connection.ExecuteStoredProcedureCount(query, null);
        }
        public DataTable getBooks()
        {
            String query = String.Format(@"SELECT Title,Author,Year,Publisher,ISBN,Copies FROM Books");

            return connection.SelectQuery(query, null);
        }
        public DataTable getMembers()
        {
            String query = String.Format(@"SELECT Name,Surname,CNP,Address,Telephone,[Email Address] 
                                           FROM Members");
            return connection.SelectQuery(query, null);
        }
        public DataTable getLoans()
        {
            String query = String.Format(@"SELECT Members.Name,Members.Surname,Books.Title,Books.Author,Books.ISBN,Loans.Date,Loans.[Expiry Date]
                                           FROM Loans
                                           INNER JOIN Books ON Loans.[Book ID] = Books.ID
                                           INNER JOIN Members ON Members.ID = Loans.[Member ID]");

            return connection.SelectQuery(query, null);
        }
        // SEARCH-------------------------------------------------------
        public DataTable searchBooksByTitle(String _title)
        {
            String query = String.Format("EXECUTE FindBooksByTitle @title");
            SqlParameter parameters = new SqlParameter();
            parameters = new SqlParameter("@title",SqlDbType.NVarChar);
            parameters.Value = Convert.ToString(_title);

            return connection.SingleSelectQuery(query, parameters);
        }
        public DataTable searchBooksByAuthor(String _author)
        {
            String query = String.Format("EXECUTE FindBooksByAuthor @author");
            SqlParameter parameters = new SqlParameter("@author", SqlDbType.NVarChar);
            parameters.Value = Convert.ToString(_author);

            return connection.SingleSelectQuery(query, parameters);
        }
        public DataTable searchBooksByISBN(String _isbn)
        {
            String query = String.Format("EXECUTE FindBooksByISBN @isbn");
            SqlParameter parameters = new SqlParameter("@isbn", SqlDbType.NVarChar);
            parameters.Value = Convert.ToString(_isbn);

            return connection.SingleSelectQuery(query, parameters);
        }
        public DataTable searchBooksByYear(int _year)
        {
            String query = String.Format("EXECUTE FindBooksByYear @year");
            SqlParameter parameters = new SqlParameter("@year", SqlDbType.NChar);
            parameters.Value = Convert.ToString(_year);

            return connection.SingleSelectQuery(query, parameters);
        }
        public DataTable searchMembersByID(int _id)
        {
            String query = String.Format("EXECUTE FindMembersByID @id");
            SqlParameter parameters = new SqlParameter("@id", SqlDbType.Int);
            parameters.Value = Convert.ToInt32(_id);

            return connection.SingleSelectQuery(query, parameters);
        }
        public DataTable searchMembersByName(String _name)
        {
            String query = String.Format("EXECUTE FindMembersByName @name");
            SqlParameter parameters = new SqlParameter("@name", SqlDbType.NVarChar);
            parameters.Value = Convert.ToString(_name);

            return connection.SingleSelectQuery(query, parameters);
        }
        public DataTable searchMembersByCNP(String _cnp)
        {
            String query = String.Format("EXECUTE FindMembersByCNP @cnp");
            SqlParameter parameters = new SqlParameter("@cnp", SqlDbType.NChar);
            parameters.Value = Convert.ToString(_cnp);

            return connection.SingleSelectQuery(query, parameters);
        }
        public DataTable searchMembersByPhone(String _phone)
        {
            String query = String.Format("EXECUTE FindMembersByPhone @phone");
            SqlParameter parameters = new SqlParameter("@phone", SqlDbType.NVarChar);
            parameters.Value = Convert.ToString(_phone);

            return connection.SingleSelectQuery(query, parameters);
        }
        public DataTable searchLoansByBook(String _bookName)
        {
            String query = String.Format("EXECUTE FindLoansByBook @title");
            SqlParameter parameters = new SqlParameter("@title", SqlDbType.NVarChar);
            parameters.Value = Convert.ToString(_bookName);

            return connection.SingleSelectQuery(query, parameters);
        }
        public DataTable searchLoansByMember(String _memberName)
        {
            String query = String.Format("EXECUTE FindLoansByMember @name");
            SqlParameter parameters = new SqlParameter("@name", SqlDbType.NVarChar);
            parameters.Value = Convert.ToString(_memberName);

            return connection.SingleSelectQuery(query, parameters);
        }
        // INSERT-------------------------------------------------------

        public bool insertBook(string _title, string _author, string _isbn, string _publisher, string _year, int _copies)
        {
            String query = String.Format("InsertBook");
            SqlParameter[] parameters = new SqlParameter[6];

            parameters[0] = new SqlParameter("@title", SqlDbType.NVarChar);
            parameters[0].Value = Convert.ToString(_title);
            parameters[1] = new SqlParameter("@author", SqlDbType.NVarChar);
            parameters[1].Value = Convert.ToString(_author);
            parameters[2] = new SqlParameter("@isbn", SqlDbType.NVarChar);
            parameters[2].Value = Convert.ToString(_isbn);
            parameters[3] = new SqlParameter("@publisher", SqlDbType.NChar);
            parameters[3].Value = Convert.ToString(_publisher);
            parameters[4] = new SqlParameter("@year", SqlDbType.NChar);
            parameters[4].Value = Convert.ToString(_year);
            parameters[5] = new SqlParameter("@copies", SqlDbType.Int);
            parameters[5].Value = Convert.ToInt32(_copies);

            return connection.ExecuteStoredProcedure(query, parameters);
        }
        public bool insertMember(string _name, string _surname, string _cnp, string _address, string _phone, string _email)
        {
            String query = String.Format("InsertMember");
            SqlParameter[] parameters = new SqlParameter[6];

            parameters[0] = new SqlParameter("@name", SqlDbType.NVarChar);
            parameters[0].Value = Convert.ToString(_name);
            parameters[1] = new SqlParameter("@surname", SqlDbType.NVarChar);
            parameters[1].Value = Convert.ToString(_surname);
            parameters[2] = new SqlParameter("@cnp", SqlDbType.NChar);
            parameters[2].Value = Convert.ToString(_cnp);
            parameters[3] = new SqlParameter("@address", SqlDbType.NVarChar);
            parameters[3].Value = Convert.ToString(_address);
            parameters[4] = new SqlParameter("@phone", SqlDbType.NVarChar);
            parameters[4].Value = Convert.ToString(_phone);
            parameters[5] = new SqlParameter("@email", SqlDbType.NVarChar);
            parameters[5].Value = Convert.ToString(_email);

            return connection.ExecuteStoredProcedure(query, parameters);
        }
        public bool insertLoan(int _bookID, int _memberID, string _date, string _expDate)
        {
            String query = String.Format("InsertLoan");
            SqlParameter[] parameters = new SqlParameter[4];

            parameters[0] = new SqlParameter("@book", SqlDbType.Int);
            parameters[0].Value = Convert.ToInt32(_bookID);
            parameters[1] = new SqlParameter("@member", SqlDbType.Int);
            parameters[1].Value = Convert.ToInt32(_memberID);
            parameters[2] = new SqlParameter("@date", SqlDbType.Date);
            parameters[2].Value = Convert.ToString(_date);
            parameters[3] = new SqlParameter("@expDate", SqlDbType.Date);
            parameters[3].Value = Convert.ToString(_expDate);

            return connection.ExecuteStoredProcedure(query, parameters);
        }
        // UPDATE--------------------------------------------------------

        public bool updateBook(int _id, string _title, string _author, string _isbn, string _publisher, string _year, int _copies)
        {
            String query = String.Format("UpdateBook");
            SqlParameter[] parameters = new SqlParameter[7];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = Convert.ToInt32(_id);
            parameters[1] = new SqlParameter("@title", SqlDbType.NVarChar);
            parameters[1].Value = Convert.ToString(_title);
            parameters[2] = new SqlParameter("@author", SqlDbType.NVarChar);
            parameters[2].Value = Convert.ToString(_author);
            parameters[3] = new SqlParameter("@isbn", SqlDbType.NVarChar);
            parameters[3].Value = Convert.ToString(_isbn);
            parameters[4] = new SqlParameter("@publisher", SqlDbType.NChar);
            parameters[4].Value = Convert.ToString(_publisher);
            parameters[5] = new SqlParameter("@year", SqlDbType.NChar);
            parameters[5].Value = Convert.ToString(_year);
            parameters[6] = new SqlParameter("@copies", SqlDbType.Int);
            parameters[6].Value = Convert.ToInt32(_copies);

            return connection.ExecuteStoredProcedure(query, parameters);
        }
        public bool updateMember(int _id, string _name, string _surname, string _cnp, string _address, string _phone, string _email)
        {
            String query = String.Format("UpdateMember");
            SqlParameter[] parameters = new SqlParameter[7];

            parameters[0] = new SqlParameter("@id", SqlDbType.NVarChar);
            parameters[0].Value = Convert.ToInt32(_id);
            parameters[1] = new SqlParameter("@name", SqlDbType.NVarChar);
            parameters[1].Value = Convert.ToString(_name);
            parameters[2] = new SqlParameter("@surname", SqlDbType.NVarChar);
            parameters[2].Value = Convert.ToString(_surname);
            parameters[3] = new SqlParameter("@cnp", SqlDbType.NChar);
            parameters[3].Value = Convert.ToString(_cnp);
            parameters[4] = new SqlParameter("@address", SqlDbType.NVarChar);
            parameters[4].Value = Convert.ToString(_address);
            parameters[5] = new SqlParameter("@phone", SqlDbType.NVarChar);
            parameters[5].Value = Convert.ToString(_phone);
            parameters[6] = new SqlParameter("@email", SqlDbType.NVarChar);
            parameters[6].Value = Convert.ToString(_email);

            return connection.ExecuteStoredProcedure(query, parameters);
        }
        public bool updateLoan(int _id, int _bookID, int _memberID, string _date, string _expDate)
        {
            String query = String.Format("UpdateLoan");
            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = Convert.ToInt32(_id);
            parameters[1] = new SqlParameter("@book", SqlDbType.Int);
            parameters[1].Value = Convert.ToInt32(_bookID);
            parameters[2] = new SqlParameter("@member", SqlDbType.Int);
            parameters[2].Value = Convert.ToInt32(_memberID);
            parameters[3] = new SqlParameter("@date", SqlDbType.Date);
            parameters[3].Value = Convert.ToDateTime(_date);
            parameters[4] = new SqlParameter("@expDate", SqlDbType.Date);
            parameters[4].Value = Convert.ToDateTime(_expDate);

            return connection.ExecuteStoredProcedure(query, parameters);
        }
        // DELETE---------------------------------------------------------

        public bool deleteBook(string _title, string _author, string _isbn, string _year, int _copies)
        {
            String query = String.Format("DeleteBook");
            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@title", SqlDbType.NVarChar);
            parameters[0].Value = Convert.ToString(_title);
            parameters[1] = new SqlParameter("@author", SqlDbType.NVarChar);
            parameters[1].Value = Convert.ToString(_author);
            parameters[2] = new SqlParameter("@isbn", SqlDbType.NVarChar);
            parameters[2].Value = Convert.ToString(_isbn);
            parameters[3] = new SqlParameter("@year", SqlDbType.NChar);
            parameters[3].Value = Convert.ToString(_year);
            parameters[4] = new SqlParameter("@copies", SqlDbType.Int);
            parameters[4].Value = Convert.ToInt32(_copies);

            return connection.ExecuteStoredProcedure(query, parameters);
        }
        public bool deleteMember(string _name, string _surname, string _cnp)
        {
            
            String query = String.Format("DeleteMember");
            SqlParameter[] parameters = new SqlParameter[3];

            parameters[0] = new SqlParameter("@name", SqlDbType.NVarChar);
            parameters[0].Value = Convert.ToString(_name);
            parameters[1] = new SqlParameter("@surname", SqlDbType.NVarChar);
            parameters[1].Value = Convert.ToString(_surname);
            parameters[2] = new SqlParameter("@cnp", SqlDbType.NChar);
            parameters[2].Value = Convert.ToString(_cnp);

            return connection.ExecuteStoredProcedure(query, parameters);
            
        }
        public bool deleteLoan(int _id, int _bookID, int _memberID, string _date, string _expDate)
        {
            String query = String.Format("DeleteLoan");
            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = Convert.ToInt32(_id);
            parameters[1] = new SqlParameter("@book", SqlDbType.Int);
            parameters[1].Value = Convert.ToInt32(_bookID);
            parameters[2] = new SqlParameter("@member", SqlDbType.Int);
            parameters[2].Value = Convert.ToInt32(_memberID);
            parameters[3] = new SqlParameter("@date", SqlDbType.Date);
            parameters[3].Value = Convert.ToString(_date);
            parameters[4] = new SqlParameter("@expDate", SqlDbType.Date);
            parameters[4].Value = Convert.ToString(_expDate);

            return connection.ExecuteStoredProcedure(query,parameters);
        }

    }
}
