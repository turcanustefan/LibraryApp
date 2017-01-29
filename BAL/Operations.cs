using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using DAL;


namespace BAL
{
    public class Operations // Connects Data Layer and Presentation Layer(User Interface)
    {
        private Data linkDataLayer;
        public Operations()
        {
            linkDataLayer = new Data();
            linkDataLayer.logHandler = new LogHandler();
        }
        // LOGIN----------------------------------------------------------
        public int addUser(String _username, String _password, int _privileges)
        {
            return linkDataLayer.addUser(_username, _password, _privileges);
        }
        public int verifyUser(String _username, String _password)
        {
            return linkDataLayer.verifyUser(_username, _password);
        }
        public int getUserPrivilege(String _username, String _password)
        {
            return linkDataLayer.getUserPrivilege(_username, _password);
        }
        // LOGS----------------------------------------------------------
        public String readLogs(String filename)
        {
            return linkDataLayer.logHandler.ReadLogs(filename);
        }
        public void writeLogs(String logs)
        {
            linkDataLayer.logHandler.WriteLogs(logs);
        }
        public String getCurrentLogFile()
        {
            return linkDataLayer.logHandler.getFileName();
        }
        // GET----------------------------------------------------------
        public int getBookID(String _title, String _author)
        {
            return linkDataLayer.getBookID(_title, _author);
        }
        public int getMemberID(String _name, String _surname)
        {
            return linkDataLayer.getMemberID(_name, _surname);
        }
        public int getLoanID(int _bid, int _mid)
        {
            return linkDataLayer.getLoanID(_bid, _mid);
        }
        public int getBooksCount()
        {
            return linkDataLayer.getBooksCount() + linkDataLayer.getLoansCount();
        }
        public int getMembersCount()
        {
            return linkDataLayer.getMembersCount();
        }
        public int getLoansCount()
        {
            return linkDataLayer.getLoansCount();
        }
        public DataTable getBooks()
        {
            return linkDataLayer.getBooks();
        }

        public DataTable getMembers()
        {
            return linkDataLayer.getMembers();
        }
        public DataTable getLoans()
        {
            return linkDataLayer.getLoans();
        }
        // SEARCH-------------------------------------------------------
        public DataTable searchBooksByTitle(String _title)
        {
            return linkDataLayer.searchBooksByTitle(_title);
        }
        public DataTable searchBooksByAuthor(String _author)
        {
            return linkDataLayer.searchBooksByAuthor(_author);
        }
        public DataTable searchBooksByISBN(String _isbn)
        {
            return linkDataLayer.searchBooksByISBN(_isbn);
        }
        public DataTable searchBooksByYear(int _year)
        {
            return linkDataLayer.searchBooksByYear(_year);
        }
        public DataTable searchMembersByID(int _id)
        {
            return linkDataLayer.searchMembersByID(_id);
        }
        public DataTable searchMembersByName(String _name)
        {
            return linkDataLayer.searchMembersByName(_name);
        }
        public DataTable searchMembersByCNP(String _cnp)
        {
            return linkDataLayer.searchMembersByCNP(_cnp);
        }
        public DataTable searchMembersByPhone(String _phone)
        {
            return linkDataLayer.searchMembersByPhone(_phone);
        }
        public DataTable searchLoansByMember(String _member)
        {
            return linkDataLayer.searchLoansByMember(_member);
        }
        public DataTable searchLoansByBook(String _book)
        {
            return linkDataLayer.searchLoansByBook(_book);
        }
        // INSERT-------------------------------------------------------

        public bool insertBook(string _title, string _author, string _isbn, string _publisher, string _year, int _copies)
        {
            return linkDataLayer.insertBook(_title, _author, _isbn, _publisher, _year, _copies);
        }
        public bool insertMember(string _name, string _surname, string _cnp, string _address, string _phone, string _email)
        {
            return linkDataLayer.insertMember(_name, _surname, _cnp, _address, _phone, _email);
        }
        public bool insertLoan(int _bookID, int _memberID, string _date, string _expDate)
        {
            return linkDataLayer.insertLoan(_bookID, _memberID, _date, _expDate);
        }
        // DELETE-------------------------------------------------------
        public bool deleteBook(string _title, string _author, string _isbn, string _year, int _copies)
        {
            return linkDataLayer.deleteBook(_title, _author, _isbn, _year, _copies);
        }
        public bool deleteMember(string _name, string _surname, string _cnp)
        {
            return linkDataLayer.deleteMember(_name, _surname, _cnp);
        }
        public bool deleteLoan(int _id, int _bookID, int _memberID, string _date, string _expDate)
        {
            return linkDataLayer.deleteLoan(_id, _bookID, _memberID, _date, _expDate);
        }
        // UPDATE--------------------------------------------------------

        public bool updateBook(int _id, string _title, string _author, string _isbn, string _publisher, string _year, int _copies)
        {

            return linkDataLayer.updateBook(_id, _title, _author, _isbn, _publisher, _year, _copies);
        }
        public bool updateMember(int _id, string _name, string _surname, string _cnp, string _address, string _phone, string _email)
        {
            return linkDataLayer.updateMember(_id,_name,_surname,_cnp,_address,_phone,_email);
        }
        public bool updateLoan(int _id, int _bookID, int _memberID, string _date, string _expDate)
        {
            return linkDataLayer.updateLoan(_id, _bookID, _memberID, _date, _expDate);
        }
    }
}
