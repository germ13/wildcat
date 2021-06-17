using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wildcat.App.SHCA.ViewModels;
using Wildcat.App.SHCA.ViewModels.Engineering;
using Wildcat.Entities.PCC.Wildcat;

namespace Wildcat.App.Controllers.Engineering
{
    [Area("SHCA")]
    public class FurnaceAlarmsController : Controller
    {
        private readonly WildcatContext _context;

        public FurnaceAlarmsController(WildcatContext context)
        {
            _context = context;
        }

        #region Subscriptions

        [HttpGet]
        public async Task<IActionResult> SubscriptionManager(string who = "alarms", string alarm = "", string user = "")
        {
            var result = new FurnaceAlarmSubscriptions();
            result.FurnaceAlarmSubscription = new List<FurnaceAlarmSubscription>();

            var subscriptions = _context.Subscription
                                       .Where(s => s.Active == true)
                                       .Where(s => s.CategoryId == 1)
                                       .OrderBy(s => s.Id);

            var workers = _context.Worker
                            .Where(w => w.Active == true)
                            .OrderBy(w => w.FirstName);

            result.WorkersAll = await workers.ToListAsync();

            foreach (var subscription in subscriptions.ToList())
            {
                var item = new FurnaceAlarmSubscription();
                item.Subscription = subscription;
                item.Worker = await GetWorkerWithSubscription(subscription.Id);

                result.FurnaceAlarmSubscription.Add(item);
            }
            return View(result);
        }

        private Task<List<Worker>> GetWorkerWithSubscription(int subscriptionId)
        {
            var workers = new List<Worker>();

            var query = from subscriptionToWorker in _context.SubscriptionWorker
                        join worker in _context.Worker
                            on subscriptionToWorker.WorkerId equals worker.Id
                        where subscriptionToWorker.SubscriptionId == subscriptionId
                        select worker;

            return query.ToListAsync();
        }

        [HttpGet]
        public async Task<IActionResult> ChangeWorkerStatus(int subscriptionId, int workerId, bool check, string change_requestby = "system")
        {
            try
            {
                var query = from stw in _context.SubscriptionWorker
                            where stw.SubscriptionId == subscriptionId && stw.WorkerId == workerId
                            select stw;

                var stw1 = query.FirstOrDefault();

                if (check == false)
                {
                    if (stw1 != null)
                    {
                        _context.Remove(stw1);
                        _context.SaveChanges();
                    }
                }
                else
                {
                    if (stw1 != null)
                    {
                        stw1.Active = true;
                        _context.SaveChanges();
                    }
                    else
                    {
                        var k = new SubscriptionWorker()
                        {
                            WorkerId = workerId,
                            SubscriptionId = subscriptionId,
                            AddedBy = change_requestby
                        };

                        _context.Add(k);
                        _context.SaveChanges();
                    }
                }
                return new JsonResult(new { subscriptionId, workerId, check });
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        #endregion Subscriptions

        #region FurnaceAlarms

        // GET: FurnaceAlarms
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var wildcatContext = _context
                                    .Subscription
                                    .Where(s => s.CategoryId == 1) // FurnaceAlarms
                                    .Include(s => s.Category);
            return View(await wildcatContext.ToListAsync());
        }

        // GET: FurnaceAlarms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscription
                .Include(s => s.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscription == null)
            {
                return NotFound();
            }

            return View(subscription);
        }

        // GET: FurnaceAlarms/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.SubscriptionCategory, "Id", "DisplayName");
            return View();
        }

        // POST: FurnaceAlarms/Create To protect from overposting attacks, please enable the specific
        // properties you want to bind to, for more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryId,NameCode,Describe,Active,Added,AddedBy,Updated,UpdatedBy")] Subscription subscription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subscription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.SubscriptionCategory, "Id", "DisplayName", subscription.CategoryId);
            return View(subscription);
        }

        // GET: FurnaceAlarms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscription.FindAsync(id);
            if (subscription == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.SubscriptionCategory, "Id", "DisplayName", subscription.CategoryId);
            return View(subscription);
        }

        // POST: FurnaceAlarms/Edit/5 To protect from overposting attacks, please enable the specific
        // properties you want to bind to, for more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoryId,NameCode,DisplayName,Active,Added,AddedBy,Updated,UpdatedBy")] Subscription subscription)
        {
            if (id != subscription.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subscription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubscriptionExists(subscription.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.SubscriptionCategory, "Id", "DisplayName", subscription.CategoryId);
            return View(subscription);
        }

        // GET: FurnaceAlarms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscription
                .Include(s => s.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscription == null)
            {
                return NotFound();
            }

            return View(subscription);
        }

        // POST: FurnaceAlarms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subscription = await _context.Subscription.FindAsync(id);
            _context.Subscription.Remove(subscription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubscriptionExists(int id)
        {
            return _context.Subscription.Any(e => e.Id == id);
        }

        #endregion FurnaceAlarms
    }
}