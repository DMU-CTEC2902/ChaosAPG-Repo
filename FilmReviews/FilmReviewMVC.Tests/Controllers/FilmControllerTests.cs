using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using FilmReviewMVC.Controllers;
using FilmReviewMVC.Models;

namespace FilmReviewMVC.Tests.Controllers
{
    [TestClass]
    public class FilmControllerTests
    {
        private Film _film;
        private FilmsController _filmsController;

        [TestInitialize]
        public void SetUp()
        {
            _film = new Film
            {
                FilmID = 1,
                ActorID = 1,
                DirectorID = 1,
                GenreID = 1,
                FilmName = "Downsizing",
                ReleaseDate = new DateTime(2016, 03, 11),
                Rating = "7",
                Runtime = "2 hours",
                Studio = "Marvel"

            };

            _filmsController = new FilmsController();
        }
        [TestMethod]
        public void TestThatAnFilmIsAddedSuccessfully()
        {

            RedirectToRouteResult result = _filmsController.Edit(_film) as RedirectToRouteResult;

            Assert.AreEqual("success", result.RouteValues["Outcome"]);

        }

    }
}
