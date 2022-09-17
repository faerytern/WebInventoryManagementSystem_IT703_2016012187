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
    public class OutgoingOrdersController : Controller
    {
        private readonly WebInventoryManagementSystem_IT703_2016012187Context _context;

        public OutgoingOrdersController(WebInventoryManagementSystem_IT703_2016012187Context context)
        {
            _context = context;
        }

        // GET: OutgoingOrders
        public async Task<IActionResult> Index()
        {
            var webInventoryManagementSystem_IT703_2016012187Context = _context.OutgoingOrder.Include(o => o.Client).Include(o => o.Inventory);
            return View(await webInventoryManagementSystem_IT703_2016012187Context.ToListAsync());
        }

        // GET: OutgoingOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OutgoingOrder == null)
            {
                return NotFound();
            }

            var outgoingOrder = await _context.OutgoingOrder
                .Include(o => o.Client)
                .Include(o => o.Inventory)
                .FirstOrDefaultAsync(m => m.OutgoingOrderId == id);
            if (outgoingOrder == null)
            {
                return NotFound();
            }

            return View(outgoingOrder);
        }

        // GET: OutgoingOrders/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId");
            ViewData["InventoryId"] = new SelectList(_context.Inventory, "InventoryId", "InventoryId");
            return View();
        }

        // POST: OutgoingOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OutgoingOrderId,Quantity,OrderedOn,ReceivedOn,ClientId,InventoryId")] OutgoingOrder outgoingOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(outgoingOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId", outgoingOrder.ClientId);
            ViewData["InventoryId"] = new SelectList(_context.Inventory, "InventoryId", "InventoryId", outgoingOrder.InventoryId);
            return View(outgoingOrder);
        }

        // GET: OutgoingOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OutgoingOrder == null)
            {
                return NotFound();
            }

            var outgoingOrder = await _context.OutgoingOrder.FindAsync(id);
            if (outgoingOrder == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId", outgoingOrder.ClientId);
            ViewData["InventoryId"] = new SelectList(_context.Inventory, "InventoryId", "InventoryId", outgoingOrder.InventoryId);
            return View(outgoingOrder);
        }

        // POST: OutgoingOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OutgoingOrderId,Quantity,OrderedOn,ReceivedOn,ClientId,InventoryId")] OutgoingOrder outgoingOrder)
        {
            if (id != outgoingOrder.OutgoingOrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(outgoingOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OutgoingOrderExists(outgoingOrder.OutgoingOrderId))
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
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId", outgoingOrder.ClientId);
            ViewData["InventoryId"] = new SelectList(_context.Inventory, "InventoryId", "InventoryId", outgoingOrder.InventoryId);
            return View(outgoingOrder);
        }

        // GET: OutgoingOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OutgoingOrder == null)
            {
                return NotFound();
            }

            var outgoingOrder = await _context.OutgoingOrder
                .Include(o => o.Client)
                .Include(o => o.Inventory)
                .FirstOrDefaultAsync(m => m.OutgoingOrderId == id);
            if (outgoingOrder == null)
            {
                return NotFound();
            }

            return View(outgoingOrder);
        }

        // POST: OutgoingOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OutgoingOrder == null)
            {
                return Problem("Entity set 'WebInventoryManagementSystem_IT703_2016012187Context.OutgoingOrder'  is null.");
            }
            var outgoingOrder = await _context.OutgoingOrder.FindAsync(id);
            if (outgoingOrder != null)
            {
                _context.OutgoingOrder.Remove(outgoingOrder);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OutgoingOrderExists(int id)
        {
          return _context.OutgoingOrder.Any(e => e.OutgoingOrderId == id);
        }
    }
}
