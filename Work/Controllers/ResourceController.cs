using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Work.Models;
using Work.Models.List;

namespace Work.Controllers
{
    public class ResourceController : Controller
    {
        private static ListResource listResource = new ListResource();


        // GET: ResourceController
        public ActionResult Index()
        {
            try
            {
                return View(listResource.ListGetItem());
            }
            catch
            {
                return View();
            }
        }

        // GET: ResourceController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                var Resource = listResource.ListFaindItem(id);
                return View(Resource);
            }
            catch
            {
                return View();
            }
        }

        // GET: ResourceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResourceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("ResourceName,ResourceId")] Resource resource)
        {
            try
            {

                listResource.ListAddItem(resource);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ResourceController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var Resource = listResource.ListFaindItem(id);
                if (Resource == null)
                {
                    return NotFound();
                }
                return View(Resource);
            }
            catch
            {
                return View();
            }
        }

        // POST: ResourceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("ResourceName,ResourceId")] Resource resource)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    listResource.ListEditItem(resource, id);
                    return RedirectToAction(nameof(Index));
                }
                else return View();

            }
            catch
            {
                return View();
            }
        }

        // GET: ResourceController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var Resource = listResource.ListFaindItem(id);
                if (Resource == null)
                {
                    return NotFound();
                }
                return View(Resource);
            }
            catch
            {
                return View();
            }
        }

        // POST: ResourceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                listResource.ListRemoveItem(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
