using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Windows.Forms;
using Coupons.Web.Infrastructure;
using Coupons.Web.Models;
using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OAuth.Messages;


namespace Coupons.Web.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        private Context db = new Context();
        private bool isValid = true;

        public UserController()
        {

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Exclude = "DisplayPicture")]UserModel userModel, HttpPostedFileBase DisplayPicture)
        {
            userModel.DisplayPicture = GetByteArrayFromFile();

            userModel = CheckLoginValidity(userModel);

            if (isValid)
            {
                db.UserModels.Add(userModel);
                db.SaveChanges();

                Session["UserName"] = userModel.UserName;
                Session["Address"] = userModel.Address;
                Session["BusinessName"] = userModel.BusinessName;
                Session["DisplayPicture"] = userModel.DisplayPicture;

                return RedirectToAction("index", "home", null);
            }
            return View(userModel);
        }

        [HttpPost]
        public ActionResult LogOff()
        {
            Session["UserName"] = null;
            Session["Address"] = null;
            Session["BusinessName"] = null;
            Session["DisplayPicture"] = null;

            return RedirectToAction("Initial", "Home", null);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserModel userModel)
        {
            foreach (var item in db.UserModels)
            {
                if (item.UserName == userModel.UserName && item.Password == userModel.Password)
                {
                    Session["UserName"] = item.UserName;
                    Session["Address"] = item.Address;
                    Session["BusinessName"] = item.BusinessName;
                    Session["DisplayPicture"] = item.DisplayPicture;

                    return RedirectToAction("index", "home", null);
                }
            }
            return View(userModel);
        }

        private byte[] GetByteArrayFromFile()
        {
            byte[] byteArray = new byte[0];

            WebImage image = WebImage.GetImageFromRequest();

            if (image == null)
            {
            }
            else
            {
                byteArray = image.GetBytes();
            }

            return byteArray;
        }

        private UserModel CheckLoginValidity(UserModel userModel)
        {
            if (userModel.DisplayPicture.Length == 0)
            {
                ViewBag.Message1 = "Please select a display picture";
                isValid = false;
            }
            if (userModel.UserName == null)
            {
                ViewBag.Message2 = "Please enter a Username";
                isValid = false;
            }
            else
            {
                foreach (var item in db.UserModels)
                {
                    if (item.UserName == userModel.UserName)
                    {
                        isValid = false;
                        ViewBag.Message2 = "That username has already been registered";
                    }
                    else
                    {
                    }
                }
                if (userModel.UserName.Contains(" "))
                {
                    ViewBag.Message2 = "Your username cannot contain any spaces";
                    isValid = false;
                }
                if (userModel.UserName.Length > 15)
                {
                    ViewBag.Message2 = "Your username must be less than 15 characters";
                    isValid = false;
                }
                if (userModel.UserName.Length < 6)
                {
                    ViewBag.Message2 = "Your username must be at least 6 characters long";
                    isValid = false;
                }
            }
            if (userModel.BusinessName == null)
            {
                ViewBag.Message3 = "Please enter a Business Name";
                isValid = false;
            }
            else
            {
                if (userModel.BusinessName.Contains("!@#$%^&*()-_=+,<.>?/;:]}[{`~"))
                {
                    ViewBag.Message3 = "Your Compmpany Name contains invalid characters";
                    isValid = false;
                }
            }
            if (userModel.Email == null)
            {
                ViewBag.Message4 = "Please enter a Email Address";
                isValid = false;
            }
            else
            {
                if (userModel.Email.Contains("@"))
                {
                    if (userModel.Email.Contains("."))
                    {
                        userModel.Email = "";
                    }
                    else
                    {
                        ViewBag.Message4 = "Your email address is an invalid format";
                        isValid = false;
                    }
                }
            }
            if (userModel.Address == null)
            {
                ViewBag.Message5 = "Please enter a Physical Address";
                isValid = false;
            }
            else
            {
                if (!Regex.IsMatch(userModel.Address, @"([a-z \ , \ a-z \ , \ a-z])$"))
                {
                    ViewBag.Message5 = "Please make sure you pick an address from the dropdown menu";
                    isValid = false;
                }
            }
            if (userModel.Password == null)
            {
                ViewBag.Message6 = "Please enter a Password";
                isValid = false;
            }
            else
            {
                foreach (char letter in userModel.Password)
                {
                    if (Char.IsUpper(letter))
                    {
                        break;
                    }
                    ViewBag.Message6 = "Your password must contain at least one uppercase letter";
                    isValid = false;

                }
                if (!userModel.Password.Any(c => char.IsDigit(c)))
                {
                    ViewBag.Message6 = "Your password must contain at least one number";
                    isValid = false;
                }
            }
            if (userModel.ConfirmPassword == null)
            {
                ViewBag.Message7 = "Please re-enter your Password"; 
                isValid = false;
            }
            else
            {
                if (userModel.Password != userModel.ConfirmPassword)
                {
                    ViewBag.Message7 = "The passwords do not match";
                    isValid = false;
                }
            }


            return userModel;
        }


    }
}
