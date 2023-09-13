using MVC_CRUD_PRACTICE_02.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_CRUD_PRACTICE_02.Data
{
    public class BookDAO
    {
        private string con_string = @"Data Source=DESKTOP-IOJE25P\SQLEXPRESS;Initial Catalog=dbLibrary;Integrated Security=true";

        internal void CreateOrUpdate(BookModel bookModel)
        {
            if (bookModel.BookID < 0)
            {
                using (SqlConnection connection = new SqlConnection(con_string))
                {
                    string sqlQuery = "INSERT INTO [dbo].[tblBooks] VALUES (@bookName,@isbn,@netQuantity,@authorName)";
                    SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                    //cmd.Parameters.AddWithValue("@bookid", bookModel.BookID);
                    cmd.Parameters.AddWithValue("@bookName", bookModel.BookName);
                    cmd.Parameters.AddWithValue("@isbn", bookModel.ISBN_10);
                    cmd.Parameters.AddWithValue("@netQuantity", bookModel.NetQuantity);
                    cmd.Parameters.AddWithValue("@authorName", bookModel.AuthorName);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            else if (bookModel.BookID > 0)
            {
                using (SqlConnection connection = new SqlConnection(con_string))
                {
                    string sqlQuery = "UPDATE [dbo].[tblBooks] SET [Book Name] = @bookName, [ISBN-10] = @isbn, [Net Quantity] = @netQuantity, [Author Name] = @authorName WHERE [Book ID] = @bookId";
                    SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                    cmd.Parameters.AddWithValue("@bookId", bookModel.BookID);
                    cmd.Parameters.AddWithValue("@bookName", bookModel.BookName);
                    cmd.Parameters.AddWithValue("@isbn", bookModel.ISBN_10);
                    cmd.Parameters.AddWithValue("@netQuantity", bookModel.NetQuantity);
                    cmd.Parameters.AddWithValue("@authorName", bookModel.AuthorName);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(con_string))
            {
                string sqlQuery = "DELETE FROM [dbo].[tblBooks] WHERE [Book ID] = @bookId";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("@bookId", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        internal List<BookModel> FetchAll()
        {
            List<BookModel> booksList = new List<BookModel>();

            using (SqlConnection connection = new SqlConnection(con_string))
            {
                string sqlQuery = "SELECT * FROM [dbo].[tblBooks]";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        BookModel book = new BookModel();
                        book.BookID = reader.GetInt32(0);
                        book.BookName = reader.GetString(1);
                        book.ISBN_10 = reader.GetInt64(2);
                        book.NetQuantity = reader.GetInt32(3);
                        book.AuthorName = reader.GetString(4);
                        booksList.Add(book);
                    }
                }
            }
            return booksList;
        }

        internal List<BookModel> FetchAll(string searchPhrase)
        {
            List<BookModel> booksList = new List<BookModel>();

            using (SqlConnection connection = new SqlConnection(con_string))
            {
                string sqlQuery = "SELECT * FROM [dbo].[tblBooks] WHERE [Book Name] LIKE @searchPhrase";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("@searchPhrase", "%" + searchPhrase + "%");
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        BookModel book = new BookModel();
                        book.BookID = reader.GetInt32(0);
                        book.BookName = reader.GetString(1);
                        book.ISBN_10 = reader.GetInt64(2);
                        book.NetQuantity = reader.GetInt32(3);
                        book.AuthorName = reader.GetString(4);
                        booksList.Add(book);
                    }
                }
            }
            return booksList;
        }

        internal BookModel fetchOne(int id)
        {
            BookModel book = new BookModel();

            using (SqlConnection connection = new SqlConnection(con_string))
            {
                string sqlQuery = "SELECT * FROM [dbo].[tblBooks] Where [Book ID] = @bookId";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("@bookId", id);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        book.BookID = reader.GetInt32(0);
                        book.BookName = reader.GetString(1);
                        book.ISBN_10 = reader.GetInt64(2);
                        book.NetQuantity = reader.GetInt32(3);
                        book.AuthorName = reader.GetString(4);
                    }
                }
            }
            return book;
        }
    }
}