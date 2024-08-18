﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RadioCabProject.Controllers
{
	public class Contact : Controller
	{
		// GET: Contact
		public ActionResult Index()
		{
			return View();
		}

		// GET: Contact/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: Contact/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Contact/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: Contact/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: Contact/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: Contact/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: Contact/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
