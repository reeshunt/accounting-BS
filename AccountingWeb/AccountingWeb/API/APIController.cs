using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingWeb.AppDbContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AccountingWeb.ModelVirtual;
using AutoMapper;
using AccountingWeb.Models;

namespace AccountingWeb.API
{
    public class APIController : Controller
    {
        private readonly AccountingDbContext _db;
        public APIController(AccountingDbContext db)
        {
            _db = db;
        }
        [AllowAnonymous]
        [HttpPost("api/getFirmName")]
        public JsonResult getFirmName(string username)
        {
            List<firmVM> firmList = new List<firmVM>();
            try
            {
                firmList = (from i in _db.firm
                                join ur in _db.UserRights on i.FirmID equals ur.FirmID
                                join ucs in _db.ucs_users on i.USERID equals ucs.userID
                                where 
                                //ucs.userName.ToUpper() == username.ToString().ToUpper()&& 
                                ur.IsRequire == true
                                select new
                                firmVM
                                {
                                    FirmID = i.FirmID,
                                    FirmName = i.FirmName
                                }).ToList();
                return Json(new { msg = firmList });
            }
            catch (Exception Ex)
            {
                return Json(new { msg = Ex.Message.ToList() });
            }
        }

        [AllowAnonymous]
        [HttpPost("api/bookSelect")]
        public JsonResult bookSelect(string keyword) {
            try
            {
                List<VBook> Query = new List<VBook>();
                List<VBook> response = new List<VBook>();

                 var bookIds = (from i in _db.transmain
                             where (i.TransactionTypeID == 41 || i.TransactionTypeID == 42 || i.TransactionTypeID == 43 || i.TransactionTypeID == 44)
                             select i.BookID.ToString()).ToList();
                 Query = (from i in _db.VBook
                             select new VBook
                             {
                                 BBookID = i.BBookID,
                                 BookName = i.BookName
                             }).ToList();
                string bookIdCollection = string.Join(",", new List<string>(bookIds).ToArray());
                response = (from i in Query
                            where bookIdCollection.Contains(i.BBookID.ToString())
                            select new VBook
                            {
                                BBookID = i.BBookID,
                                BookName = i.BookName
                            }).OrderBy(x=>x.BookName).ToList();
                if (keyword != ""&&keyword!=null) {
                    response = response.Where(x=>x.BookName.StartsWith(keyword.ToString())).ToList();
                }
                return Json(new { msg = response });
            }
            catch (Exception Ex) {
                return Json(new { msg = Ex.Message.ToString() });

            }
        }
    }
}