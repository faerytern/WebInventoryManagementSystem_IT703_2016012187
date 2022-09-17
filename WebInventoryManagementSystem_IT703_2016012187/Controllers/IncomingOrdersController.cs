using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebInventoryManagementSystem_IT703_2016012187.Data;
using WebInventoryManagementSystem_IT703_2016012187.Models;

namespace WebInventoryManagementSystem_IT703_2016012187.Controllers
{
    public class IncomingOrdersController : Controller
    {
        private readonly WebInventoryManagementSystem_IT703_2016012187Context _context;

        public IncomingOrdersController(WebInventoryManagementSystem_IT703_2016012187Context context)
        {
            _context = context;
        }

        // GET: IncomingOrders
        public async Task<IActionResult> Index()
        {
            var webInventoryManagementSystem_IT703_2016012187Context = _context.IncomingOrder.Include(i => i.Inventory).Include(i => i.Supplier);
            return View(await webInventoryManagementSystem_IT703_2016012187Context.ToListAsync());
        }

        // GET: IncomingOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.IncomingOrder == null)
            {
                return NotFound();
            }

            var incomingOrder = await _context.IncomingOrder
                .Include(i => i.Inventory)
                .Include(i => i.Supplier)
                .FirstOrDefaultAsync(m => m.IncomingOrderId == id);
            if (incomingOrder == null)
            {
                return NotFound();
            }

            return View(incomingOrder);
        }

        // GET: IncomingOrders/Create
        public IActionResult Create()
        {
            ViewBag.InventoryId = new SelectList(_context.Inventory, "InventoryId", "InventoryId");
            ViewBag.SupplierId = new SelectList(_context.Supplier, "SupplierId", "SupplierId");
            return View();
        }

        // POST: IncomingOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IncomingOrderId,Quantity,OrderedOn,ReceivedOn,SupplierId,InventoryId")] IncomingOrder incomingOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(incomingOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InventoryId"] = new SelectList(_context.Inventory, "InventoryId", "InventoryId", incomingOrder.InventoryId);
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "SupplierId", incomingOrder.SupplierId);
            return View(incomingOrder);
        }

        // GET: IncomingOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.IncomingOrder == null)
            {
                return NotFound();
            }

            var incomingOrder = await _context.IncomingOrder.FindAsync(id);
            if (incomingOrder == null)
            {
                return NotFound();
            }
            ViewData["InventoryId"] = new SelectList(_context.Inventory, "InventoryId", "InventoryId", incomingOrder.InventoryId);
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "SupplierId", incomingOrder.SupplierId);
            return View(incomingOrder);
        }

        // POST: IncomingOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IncomingOrderId,Quantity,OrderedOn,ReceivedOn,SupplierId,InventoryId")] IncomingOrder incomingOrder)
        {
            if (id != incomingOrder.IncomingOrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(incomingOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IncomingOrderExists(incomingOrder.IncomingOrderId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["InventoryId"] = new SelectList(_context.Inventory, "InventoryId", "InventoryId", incomingOrder.InventoryId);
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "SupplierId", incomingOrder.SupplierId);
            return View(incomingOrder);
        }

        // GET: IncomingOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.IncomingOrder == null)
            {
                return NotFound();
            }

            var incomingOrder = await _context.IncomingOrder
                .Include(i => i.Inventory)
                .Include(i => i.Supplier)
                .FirstOrDefaultAsync(m => m.IncomingOrderId == id);
            if (incomingOrder == null)
            {
                return NotFound();
            }

            return View(incomingOrder);
        }

        // POST: IncomingOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.IncomingOrder == null)
            {
                return Problem("Entity set 'WebInventoryManagementSystem_IT703_2016012187Context.IncomingOrder'  is null.");
            }
            var incomingOrder = await _context.IncomingOrder.FindAsync(id);
            if (incomingOrder != null)
            {
                _context.IncomingOrder.Remove(incomingOrder);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IncomingOrderExists(int id)
        {
          return _context.IncomingOrder.Any(e => e.IncomingOrderId == id);
        }
    }
}
