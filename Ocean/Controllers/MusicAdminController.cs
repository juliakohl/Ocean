﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ocean.Controllers
{
    public class MusicAdminController : Controller
    {
        // GET: MusicAdmin
        public ActionResult AddMusic()
        {
            return View();
        }

        // GET: MusicAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MusicAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MusicAdmin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MusicAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MusicAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MusicAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MusicAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
