using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalAssignment_Part2.Models;

//ProductModelsController.cs
//Naga Rimmalapudi 200277598 Chandra Reddy 200275643
//CRUD Controller for products.

namespace FinalAssignment_Part2.Controllers
{
    public class ProductModelsController : Controller
    {
        private FoodCourtModel db = new FoodCourtModel();

        // GET: ProductModels
        public async Task<ActionResult> Index()
        {
            return View(await db.ProductModels.ToListAsync());
        }

        // GET: ProductModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductModel productModels = await db.ProductModels.FindAsync(id);
            if (productModels == null)
            {
                return HttpNotFound();
            }
            return View(productModels);
        }

        // GET: ProductModels/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Create([Bind(Include = "ID,ProductName,ProductPrice,BottleSize,ShortDesc,LongDesc,ThumbnailURL,FullsizeURL")] ProductModel productModels)
        {
            if (ModelState.IsValid)
            {
                db.ProductModels.Add(productModels);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(productModels);
        }

        // GET: ProductModels/Edit/5
        [Authorize]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductModel productModels = await db.ProductModels.FindAsync(id);
            if (productModels == null)
            {
                return HttpNotFound();
            }
            return View(productModels);
        }

        // POST: ProductModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Edit([Bind(Include = "ID,ProductName,ProductPrice,BottleSize,ShortDesc,LongDesc,ThumbnailURL,FullsizeURL")] ProductModel productModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productModels).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(productModels);
        }

        // GET: ProductModels/Delete/5
        [Authorize]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductModel productModels = await db.ProductModels.FindAsync(id);
            if (productModels == null)
            {
                return HttpNotFound();
            }
            return View(productModels);
        }

        // POST: ProductModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ProductModel productModels = await db.ProductModels.FindAsync(id);
            db.ProductModels.Remove(productModels);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}