﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using buildacomputer.Models;

namespace buildacomputer.Controllers.BuildsController
{
    public class BuildsController : Controller
{
    public ActionResult Index()
{
    return View();
}
    }
}
//    public class BuildsController : Controller
//    {
//        private static PartsAndUsersContext db = new PartsAndUsersContext();

//        //Instantiates a build object with the "possible" lists seeded by the database
//        private static List<long> motherboard = db.motherboards.Select(m => m.motherboard_id).ToList();
//        private static List<long> processor = db.processors.Select(p => p.processor_id).ToList();
//        private static List<long> memory = db.memories.Select(m => m.memory_id).ToList();
//        private static List<long> hardDrive = db.hard_drives.Select(h => h.hard_drive_id).ToList();
//        private static List<long> soundCard = db.sound_cards.Select(s => s.sound_card_id).ToList();
//        private static List<long> videoAdapter = db.video_adapters.Select(v => v.video_adapter_id).ToList();
//        private static List<long> opticalDrive = db.optical_drives.Select(o => o.optical_drive_id).ToList();
//        private static List<long> powerSupply = db.power_supplies.Select(p => p.power_supply_id).ToList();
//        private static List<long> computerCase = db.computer_cases.Select(c => c.computer_case_id).ToList();
//        private int iterator = -1;

//        Build build = new Build(motherboard, processor, memory, hardDrive, soundCard, videoAdapter, opticalDrive, powerSupply, computerCase);
//        // GET: Builds
//        public ActionResult Index(long? id_number = null)
//        {
//            List<string> ViewList = new List<string>();
//            //Switch that uses selection to identify which list to show
//            switch (iterator)
//            {
//                //Turns motherboards held in build into a list of strings
//                case -1:
//                    foreach (long item in build.motherboard_ids)
//                    {
//                        ViewList.Add(db.motherboards.Where(m => m.motherboard_id == item).Select(m => m.motherboard_name).ToString());
//                    }
//                    iterator += 1;
//                    break;
//                //Adds selected motherboard
//                case 0:
//                    build.addMotherboard(id_number);
//                    ViewList.Clear();
//                    foreach (long item in build.processor_ids)
//                    {
//                        ViewList.Add(db.processors.Where(p => p.processor_id == item).Select(p => p.processor_name).ToString());
//                    }
//                    iterator += 1;
//                    break;
//                case 1:
//                    build.addProcessor_id(id_number);
//                    ViewList.Clear();
//                    foreach (long item in build.memory_ids)
//                    {
//                        ViewList.Add(db.memories.Where(m => m.memory_id == item).Select(m => m.memory_name).ToString());
//                    }
//                    iterator += 1;
//                    break;
//                case 2:
//                    build.addMemory_id(id_number);
//                    ViewList.Clear();
//                    foreach (long item in build.hard_drive_ids)
//                    {
//                        ViewList.Add(db.hard_drives.Where(h => h.hard_drive_id == item).Select(h => h.hard_drive_name).ToString());
//                    }
//                    iterator += 1;
//                    break;
//                case 3:
//                    build.addHard_drive_id(id_number);
//                    ViewList.Clear();
//                    foreach (long item in build.sound_card_ids)
//                    {
//                        ViewList.Add(db.sound_cards.Where(s => s.sound_card_id == item).Select(s => s.sound_card_name).ToString());
//                    }
//                    iterator += 1;
//                    break;
//                case 4:
//                    build.addSound_card_id(id_number);
//                    ViewList.Clear();
//                    foreach (long item in build.video_adapter_ids)
//                    {
//                        ViewList.Add(db.video_adapters.Where(v => v.video_adapter_id == item).Select(v => v.video_adapter_name).ToString());
//                    }
//                    iterator += 1;
//                    break;
//                case 5:
//                    build.addVideo_adapter_id(id_number);
//                    ViewList.Clear();
//                    foreach (long item in build.optical_drive_ids)
//                    {
//                        ViewList.Add(db.optical_drives.Where(o => o.optical_drive_id == item).Select(o => o.optical_drive_name).ToString());
//                    }
//                    iterator += 1;
//                    break;
//                case 6:
//                    build.addOptical_drive_id(id_number);
//                    ViewList.Clear();
//                    foreach (long item in build.power_supply_ids)
//                    {
//                        ViewList.Add(db.power_supplies.Where(p => p.power_supply_id == item).Select(p => p.power_supply_name).ToString());
//                    }
//                    iterator += 1;
//                    break;
//                case 7:
//                    build.addPower_supply_id(id_number);
//                    ViewList.Clear();
//                    foreach (long item in build.computer_case_ids)
//                    {
//                        ViewList.Add(db.computer_cases.Where(c => c.computer_case_id == item).Select(c => c.computer_case_name).ToString());
//                    }
//                    iterator += 1;
//                    break;
//                case 8:
//                    build.addComputer_case_id(id_number);
//                    ViewList.Clear();
//                    ViewList.Add("Your build is complete.");
//                    iterator += 1;
//                    break;
//                default:
//                    iterator += 1;
//                    Index(null);
//                    break;
//            }

//            //Returns the list of motherboard strings to the view
//            return View(ViewList);
//        }

//        //// GET: Builds/Details/5
//        //public ActionResult Details(long? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//        //    }
//        //    Build build = db.Build.Find(id);
//        //    if (build == null)
//        //    {
//        //        return HttpNotFound();
//        //    }
//        //    return View(build);
//        //}

//        //// GET: Builds/Create
//        //public ActionResult Create()
//        //{
//        //    ViewBag.computer_case_id = new SelectList(db.computer_cases, "computer_case_id", "color");
//        //    ViewBag.hard_drive_id = new SelectList(db.hard_drives, "hard_drive_id", "hard_drive_name");
//        //    ViewBag.memory_id = new SelectList(db.memories, "memory_id", "memory_name");
//        //    ViewBag.motherboard_id = new SelectList(db.motherboards, "motherboard_id", "motherboard_name");
//        //    ViewBag.optical_drive_id = new SelectList(db.optical_drives, "optical_drive_id", "optical_drive_name");
//        //    ViewBag.power_supply_id = new SelectList(db.power_supplies, "power_supply_id", "power_supply_name");
//        //    ViewBag.sound_card_id = new SelectList(db.sound_cards, "sound_card_id", "sound_card_name");
//        //    ViewBag.video_adapter_id = new SelectList(db.video_adapters, "video_adapter_id", "video_adapter_name");
//        //    return View();
//        //}

//        //// POST: Builds/Create
//        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public ActionResult Create([Bind(Include = "buildID,motherboard_id,computer_case_id,hard_drive_id,optical_drive_id,power_supply_id,processer_id,sound_card_id,video_adapter_id,memory_id,buildType,iterator,BuildTime")] Build build)
//        //{
//        //    if (ModelState.IsValid)
//        //    {
//        //        db.Build.Add(build);
//        //        db.SaveChanges();
//        //        return RedirectToAction("Index");
//        //    }

//        //    ViewBag.computer_case_id = new SelectList(db.computer_cases, "computer_case_id", "color", build.computer_case_id);
//        //    ViewBag.hard_drive_id = new SelectList(db.hard_drives, "hard_drive_id", "hard_drive_name", build.hard_drive_id);
//        //    ViewBag.memory_id = new SelectList(db.memories, "memory_id", "memory_name", build.memory_id);
//        //    ViewBag.motherboard_id = new SelectList(db.motherboards, "motherboard_id", "motherboard_name", build.motherboard_id);
//        //    ViewBag.optical_drive_id = new SelectList(db.optical_drives, "optical_drive_id", "optical_drive_name", build.optical_drive_id);
//        //    ViewBag.power_supply_id = new SelectList(db.power_supplies, "power_supply_id", "power_supply_name", build.power_supply_id);
//        //    ViewBag.sound_card_id = new SelectList(db.sound_cards, "sound_card_id", "sound_card_name", build.sound_card_id);
//        //    ViewBag.video_adapter_id = new SelectList(db.video_adapters, "video_adapter_id", "video_adapter_name", build.video_adapter_id);
//        //    return View(build);
//        //}

//        //// GET: Builds/Edit/5
//        //public ActionResult Edit(long? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//        //    }
//        //    Build build = db.Build.Find(id);
//        //    if (build == null)
//        //    {
//        //        return HttpNotFound();
//        //    }
//        //    ViewBag.computer_case_id = new SelectList(db.computer_cases, "computer_case_id", "color", build.computer_case_id);
//        //    ViewBag.hard_drive_id = new SelectList(db.hard_drives, "hard_drive_id", "hard_drive_name", build.hard_drive_id);
//        //    ViewBag.memory_id = new SelectList(db.memories, "memory_id", "memory_name", build.memory_id);
//        //    ViewBag.motherboard_id = new SelectList(db.motherboards, "motherboard_id", "motherboard_name", build.motherboard_id);
//        //    ViewBag.optical_drive_id = new SelectList(db.optical_drives, "optical_drive_id", "optical_drive_name", build.optical_drive_id);
//        //    ViewBag.power_supply_id = new SelectList(db.power_supplies, "power_supply_id", "power_supply_name", build.power_supply_id);
//        //    ViewBag.sound_card_id = new SelectList(db.sound_cards, "sound_card_id", "sound_card_name", build.sound_card_id);
//        //    ViewBag.video_adapter_id = new SelectList(db.video_adapters, "video_adapter_id", "video_adapter_name", build.video_adapter_id);
//        //    return View(build);
//        //}

//        //// POST: Builds/Edit/5
//        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public ActionResult Edit([Bind(Include = "buildID,motherboard_id,computer_case_id,hard_drive_id,optical_drive_id,power_supply_id,processer_id,sound_card_id,video_adapter_id,memory_id,buildType,iterator,BuildTime")] Build build)
//        //{
//        //    if (ModelState.IsValid)
//        //    {
//        //        db.Entry(build).State = EntityState.Modified;
//        //        db.SaveChanges();
//        //        return RedirectToAction("Index");
//        //    }
//        //    ViewBag.computer_case_id = new SelectList(db.computer_cases, "computer_case_id", "color", build.computer_case_id);
//        //    ViewBag.hard_drive_id = new SelectList(db.hard_drives, "hard_drive_id", "hard_drive_name", build.hard_drive_id);
//        //    ViewBag.memory_id = new SelectList(db.memories, "memory_id", "memory_name", build.memory_id);
//        //    ViewBag.motherboard_id = new SelectList(db.motherboards, "motherboard_id", "motherboard_name", build.motherboard_id);
//        //    ViewBag.optical_drive_id = new SelectList(db.optical_drives, "optical_drive_id", "optical_drive_name", build.optical_drive_id);
//        //    ViewBag.power_supply_id = new SelectList(db.power_supplies, "power_supply_id", "power_supply_name", build.power_supply_id);
//        //    ViewBag.sound_card_id = new SelectList(db.sound_cards, "sound_card_id", "sound_card_name", build.sound_card_id);
//        //    ViewBag.video_adapter_id = new SelectList(db.video_adapters, "video_adapter_id", "video_adapter_name", build.video_adapter_id);
//        //    return View(build);
//        //}

//        //// GET: Builds/Delete/5
//        //public ActionResult Delete(long? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//        //    }
//        //    Build build = db.Build.Find(id);
//        //    if (build == null)
//        //    {
//        //        return HttpNotFound();
//        //    }
//        //    return View(build);
//        //}

//        //// POST: Builds/Delete/5
//        //[HttpPost, ActionName("Delete")]
//        //[ValidateAntiForgeryToken]
//        //public ActionResult DeleteConfirmed(long id)
//        //{
//        //    Build build = db.Build.Find(id);
//        //    db.Build.Remove(build);
//        //    db.SaveChanges();
//        //    return RedirectToAction("Index");
//        //}

//        //protected override void Dispose(bool disposing)
//        //{
//        //    if (disposing)
//        //    {
//        //        db.Dispose();
//        //    }
//        //    base.Dispose(disposing);
//        //}
//    }
//}
