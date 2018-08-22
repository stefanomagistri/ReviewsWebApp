using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using ReviewsWebApp.Controllers;
using ReviewsWebApp.Models;
using ReviewsWebApp.Patterns;

namespace ReviewsWebApp.Tests
{
    [TestClass]
    public class ReviewUnitTest
    {
        [TestMethod]
        public void Review_Index()
        {
            var ctrl = new ReviewController("reviews.json");
            var result = ctrl.Index();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Review_Index_PageIndex_One()
        {
            var ctrl = new ReviewController("reviews.json");
            var result = ctrl.Index(pageNumber: 1) as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as ReviewsViewModel;
            Assert.IsNotNull(model);
            Assert.AreEqual(1, model.PageNumber);
            Assert.AreEqual(4, model.PageCount);
            Assert.IsTrue(model.IsNextPageEnabled);
            Assert.IsFalse(model.IsPreviousPageEnabled);
        }
        [TestMethod]
        public void Review_Index_PageIndex_Two()
        {
            var ctrl = new ReviewController("reviews.json");
            var result = ctrl.Index(pageNumber: 2) as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as ReviewsViewModel;
            Assert.IsNotNull(model);
            Assert.AreEqual(2, model.PageNumber);
            Assert.AreEqual(4, model.PageCount);
            Assert.IsTrue(model.IsNextPageEnabled);
            Assert.IsTrue(model.IsPreviousPageEnabled);
        }
        [TestMethod]
        public void Review_Index_PageIndex_Three()
        {
            var ctrl = new ReviewController("reviews.json");
            var result = ctrl.Index(pageNumber: 3) as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as ReviewsViewModel;
            Assert.IsNotNull(model);
            Assert.AreEqual(3, model.PageNumber);
            Assert.AreEqual(4, model.PageCount);
            Assert.IsTrue(model.IsNextPageEnabled);
            Assert.IsTrue(model.IsPreviousPageEnabled);
        }
        [TestMethod]
        public void Review_Index_PageIndex_Four()
        {
            var ctrl = new ReviewController("reviews.json");
            var result = ctrl.Index(pageNumber: 4) as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as ReviewsViewModel;
            Assert.IsNotNull(model);
            Assert.AreEqual(4, model.PageNumber);
            Assert.AreEqual(4, model.PageCount);
            Assert.IsFalse(model.IsNextPageEnabled);
            Assert.IsTrue(model.IsPreviousPageEnabled);
        }

        [TestMethod]
        public void Review_Index_PageIndex_Five()
        {
            var ctrl = new ReviewController("reviews.json");
            var result = ctrl.Index(pageNumber: 5) as ViewResult;
            Assert.IsNotNull(result);
            var model = result.Model as ReviewsViewModel;
            Assert.IsNotNull(model);
            Assert.AreEqual(0, model.PageNumber);
            Assert.AreEqual(0, model.PageCount);
            Assert.IsFalse(model.Reviews.Any());
            Assert.IsFalse(model.IsNextPageEnabled);
            Assert.IsFalse(model.IsPreviousPageEnabled);
        }

    }
}
