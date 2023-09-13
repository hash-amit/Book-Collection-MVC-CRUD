using MVC_CRUD_PRACTICE_02.Data;
using MVC_CRUD_PRACTICE_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CRUD_PRACTICE_02.Controllers
{
    public class BookController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            BookDAO bookDAO = new BookDAO();
            List<BookModel> books = bookDAO.FetchAll();
            return View("Index", books);
        }

        public ActionResult Create()
        {
            return View("Create", new BookModel());
        }

        public ActionResult ProcessCreate(BookModel bookModel)
        {
            BookDAO bookDAO = new BookDAO();
            bookDAO.CreateOrUpdate(bookModel);
            return View("Details", bookModel);
        }

        public ActionResult Details(int id)
        {
            BookDAO bookDAO = new BookDAO();
            BookModel bookModel = bookDAO.fetchOne(id);
            return View("Details", bookModel);
        }

        public ActionResult Edit(int id)
        {
            BookDAO bookDAO = new BookDAO();
            BookModel bookModel = bookDAO.fetchOne(id);
            return View("Create", bookModel);
        }

        public ActionResult Delete(int id)
        {
            BookDAO bookDAO = new BookDAO();
            bookDAO.Delete(id);
            List<BookModel> books = bookDAO.FetchAll();
            return View("Index", books);
        }

        public ActionResult Search(string searchPhrase)
        {
            BookDAO bookDAO = new BookDAO();
            List<BookModel> books = bookDAO.FetchAll(searchPhrase);
            return View("Index", books);
        }
    }
}