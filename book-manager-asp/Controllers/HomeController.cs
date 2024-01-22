﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using book_manager_asp.Models;
using System.Web.Security;

namespace book_manager_asp.Controllers
{
	public class HomeController : Controller
	{
		/*
		public ActionResult Index()
		{
			return View();
		}
		*/

		/// <summary>
		/// home page (login) 表示
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		/// <summary>
		/// ログイン処理
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		[HttpPost]
		public ActionResult Login(AuthModel model)
		{
			// サンプルの為、ハードコーディング
			if (model.EmpNum == "1" && model.EmpPass == "1")
			{
				// ユーザー認証 成功
				FormsAuthentication.SetAuthCookie(model.EmpNum, true);
				return RedirectToAction("Index", "Home");
			}
			else
			{
				// ユーザー認証 失敗
				this.ModelState.AddModelError(string.Empty, "指定されたユーザー名またはパスワードが正しくありません。");
				return RedirectToAction("Index", "Home");
			}
		}

		/// <summary>
		/// ログアウト処理
		/// </summary>
		/// <returns></returns>
		public ActionResult Logout()
		{
			FormsAuthentication.SignOut();
			return RedirectToAction("Index", "Home");
		}
	}
}