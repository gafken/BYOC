﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Linq;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using buildacomputer.Models;
using System.Web.Services;
using System.Threading.Tasks;
using buildacomputer.ViewModel;
using Microsoft.AspNet.Identity;

namespace buildacomputer.Controllers
{
    public class BuildsController : Controller
    {
        private static PartsAndUsersContext db = new PartsAndUsersContext();
       // Build _build = new Build();
       

       // HttpContext.Current.Session.Add("SessionBuild", new Build);

        // GET: Builds
        //public ActionResult Index(long? id_number = null)
        [Authorize]
        public ActionResult Index(string obj, long? id_number)
        {
            ViewBag.mb = new List<motherboard>();
            ViewBag.pr = new List<processor>();
            ViewBag.me = new List<memory>();
            ViewBag.hd = new List<hard_drives>();
            ViewBag.sc = new List<sound_cards>();
            ViewBag.va = new List<video_adapters>();
            ViewBag.od = new List<optical_drives>();
            ViewBag.ps = new List<power_supplies>();
            ViewBag.cc = new List<computer_cases>();
            Build build = (Build)this.Session["SessionBuild"];

            if (id_number != null)
            {
                // the controller action was invoked with an AJAX request
                if (obj == "mb")
                {
                    build.addMotherboard(id_number);
                    #region Recreate Lists
                    foreach (var x in build.motherboard_ids)
                    {
                        ViewBag.mb.AddRange(db.motherboards.Where(m => m.motherboard_id == x));
                    }
                    foreach (var x in build.processor_ids)
                    {
                        ViewBag.pr.AddRange(db.processors.Where(m => m.processor_id == x));
                    }
                    foreach (var x in build.memory_ids)
                    {
                        ViewBag.me.AddRange(db.memories.Where(m => m.memory_id == x));
                    }
                    foreach (var x in build.hard_drive_ids)
                    {
                        ViewBag.hd.AddRange(db.hard_drives.Where(m => m.hard_drive_id == x));
                    }
                    foreach (var x in build.sound_card_ids)
                    {
                        ViewBag.sc.AddRange(db.sound_cards.Where(m => m.sound_card_id == x));
                    }
                    foreach (var x in build.video_adapter_ids)
                    {
                        ViewBag.va.AddRange(db.video_adapters.Where(m => m.video_adapter_id == x));
                    }
                    foreach (var x in build.optical_drive_ids)
                    {
                        ViewBag.od.AddRange(db.optical_drives.Where(m => m.optical_drive_id == x));
                    }
                    foreach (var x in build.power_supply_ids)
                    {
                        ViewBag.ps.AddRange(db.power_supplies.Where(m => m.power_supply_id == x));
                    }
                    foreach (var x in build.computer_case_ids)
                    {
                        ViewBag.cc.AddRange(db.computer_cases.Where(m => m.computer_case_id == x));
                    }
                    #endregion
                }
                else if (obj == "pr")
                {
                    build.addProcessor_id(id_number);
                    #region Recreate Lists
                    foreach (var x in build.motherboard_ids)
                    {
                        ViewBag.mb.AddRange(db.motherboards.Where(m => m.motherboard_id == x));
                    }
                    foreach (var x in build.processor_ids)
                    {
                        ViewBag.pr.AddRange(db.processors.Where(m => m.processor_id == x));
                    }
                    foreach (var x in build.memory_ids)
                    {
                        ViewBag.me.AddRange(db.memories.Where(m => m.memory_id == x));
                    }
                    foreach (var x in build.hard_drive_ids)
                    {
                        ViewBag.hd.AddRange(db.hard_drives.Where(m => m.hard_drive_id == x));
                    }
                    foreach (var x in build.sound_card_ids)
                    {
                        ViewBag.sc.AddRange(db.sound_cards.Where(m => m.sound_card_id == x));
                    }
                    foreach (var x in build.video_adapter_ids)
                    {
                        ViewBag.va.AddRange(db.video_adapters.Where(m => m.video_adapter_id == x));
                    }
                    foreach (var x in build.optical_drive_ids)
                    {
                        ViewBag.od.AddRange(db.optical_drives.Where(m => m.optical_drive_id == x));
                    }
                    foreach (var x in build.power_supply_ids)
                    {
                        ViewBag.ps.AddRange(db.power_supplies.Where(m => m.power_supply_id == x));
                    }
                    foreach (var x in build.computer_case_ids)
                    {
                        ViewBag.cc.AddRange(db.computer_cases.Where(m => m.computer_case_id == x));
                    }
                    #endregion
                }
                else if (obj == "me")
                {
                    build.addMemory_id(id_number);
                    #region Recreate Lists
                    foreach (var x in build.motherboard_ids)
                    {
                        ViewBag.mb.AddRange(db.motherboards.Where(m => m.motherboard_id == x));
                    }
                    foreach (var x in build.processor_ids)
                    {
                        ViewBag.pr.AddRange(db.processors.Where(m => m.processor_id == x));
                    }
                    foreach (var x in build.memory_ids)
                    {
                        ViewBag.me.AddRange(db.memories.Where(m => m.memory_id == x));
                    }
                    foreach (var x in build.hard_drive_ids)
                    {
                        ViewBag.hd.AddRange(db.hard_drives.Where(m => m.hard_drive_id == x));
                    }
                    foreach (var x in build.sound_card_ids)
                    {
                        ViewBag.sc.AddRange(db.sound_cards.Where(m => m.sound_card_id == x));
                    }
                    foreach (var x in build.video_adapter_ids)
                    {
                        ViewBag.va.AddRange(db.video_adapters.Where(m => m.video_adapter_id == x));
                    }
                    foreach (var x in build.optical_drive_ids)
                    {
                        ViewBag.od.AddRange(db.optical_drives.Where(m => m.optical_drive_id == x));
                    }
                    foreach (var x in build.power_supply_ids)
                    {
                        ViewBag.ps.AddRange(db.power_supplies.Where(m => m.power_supply_id == x));
                    }
                    foreach (var x in build.computer_case_ids)
                    {
                        ViewBag.cc.AddRange(db.computer_cases.Where(m => m.computer_case_id == x));
                    }
                    #endregion
                }
                else if (obj == "hd")
                {
                    build.addHard_drive_id(id_number);
                    #region Recreate Lists
                    foreach (var x in build.motherboard_ids)
                    {
                        ViewBag.mb.AddRange(db.motherboards.Where(m => m.motherboard_id == x));
                    }
                    foreach (var x in build.processor_ids)
                    {
                        ViewBag.pr.AddRange(db.processors.Where(m => m.processor_id == x));
                    }
                    foreach (var x in build.memory_ids)
                    {
                        ViewBag.me.AddRange(db.memories.Where(m => m.memory_id == x));
                    }
                    foreach (var x in build.hard_drive_ids)
                    {
                        ViewBag.hd.AddRange(db.hard_drives.Where(m => m.hard_drive_id == x));
                    }
                    foreach (var x in build.sound_card_ids)
                    {
                        ViewBag.sc.AddRange(db.sound_cards.Where(m => m.sound_card_id == x));
                    }
                    foreach (var x in build.video_adapter_ids)
                    {
                        ViewBag.va.AddRange(db.video_adapters.Where(m => m.video_adapter_id == x));
                    }
                    foreach (var x in build.optical_drive_ids)
                    {
                        ViewBag.od.AddRange(db.optical_drives.Where(m => m.optical_drive_id == x));
                    }
                    foreach (var x in build.power_supply_ids)
                    {
                        ViewBag.ps.AddRange(db.power_supplies.Where(m => m.power_supply_id == x));
                    }
                    foreach (var x in build.computer_case_ids)
                    {
                        ViewBag.cc.AddRange(db.computer_cases.Where(m => m.computer_case_id == x));
                    }
                    #endregion
                }
                else if (obj == "sc")
                {
                    build.addSound_card_id(id_number);
                    #region Recreate Lists
                    foreach (var x in build.motherboard_ids)
                    {
                        ViewBag.mb.AddRange(db.motherboards.Where(m => m.motherboard_id == x));
                    }
                    foreach (var x in build.processor_ids)
                    {
                        ViewBag.pr.AddRange(db.processors.Where(m => m.processor_id == x));
                    }
                    foreach (var x in build.memory_ids)
                    {
                        ViewBag.me.AddRange(db.memories.Where(m => m.memory_id == x));
                    }
                    foreach (var x in build.hard_drive_ids)
                    {
                        ViewBag.hd.AddRange(db.hard_drives.Where(m => m.hard_drive_id == x));
                    }
                    foreach (var x in build.sound_card_ids)
                    {
                        ViewBag.sc.AddRange(db.sound_cards.Where(m => m.sound_card_id == x));
                    }
                    foreach (var x in build.video_adapter_ids)
                    {
                        ViewBag.va.AddRange(db.video_adapters.Where(m => m.video_adapter_id == x));
                    }
                    foreach (var x in build.optical_drive_ids)
                    {
                        ViewBag.od.AddRange(db.optical_drives.Where(m => m.optical_drive_id == x));
                    }
                    foreach (var x in build.power_supply_ids)
                    {
                        ViewBag.ps.AddRange(db.power_supplies.Where(m => m.power_supply_id == x));
                    }
                    foreach (var x in build.computer_case_ids)
                    {
                        ViewBag.cc.AddRange(db.computer_cases.Where(m => m.computer_case_id == x));
                    }
                    #endregion
                }
                else if (obj == "va")
                {
                    build.addVideo_adapter_id(id_number);
                    #region Recreate Lists
                    foreach (var x in build.motherboard_ids)
                    {
                        ViewBag.mb.AddRange(db.motherboards.Where(m => m.motherboard_id == x));
                    }
                    foreach (var x in build.processor_ids)
                    {
                        ViewBag.pr.AddRange(db.processors.Where(m => m.processor_id == x));
                    }
                    foreach (var x in build.memory_ids)
                    {
                        ViewBag.me.AddRange(db.memories.Where(m => m.memory_id == x));
                    }
                    foreach (var x in build.hard_drive_ids)
                    {
                        ViewBag.hd.AddRange(db.hard_drives.Where(m => m.hard_drive_id == x));
                    }
                    foreach (var x in build.sound_card_ids)
                    {
                        ViewBag.sc.AddRange(db.sound_cards.Where(m => m.sound_card_id == x));
                    }
                    foreach (var x in build.video_adapter_ids)
                    {
                        ViewBag.va.AddRange(db.video_adapters.Where(m => m.video_adapter_id == x));
                    }
                    foreach (var x in build.optical_drive_ids)
                    {
                        ViewBag.od.AddRange(db.optical_drives.Where(m => m.optical_drive_id == x));
                    }
                    foreach (var x in build.power_supply_ids)
                    {
                        ViewBag.ps.AddRange(db.power_supplies.Where(m => m.power_supply_id == x));
                    }
                    foreach (var x in build.computer_case_ids)
                    {
                        ViewBag.cc.AddRange(db.computer_cases.Where(m => m.computer_case_id == x));
                    }
                    #endregion
                }
                else if (obj == "od")
                {
                    build.addOptical_drive_id(id_number);
                    #region Recreate Lists
                    foreach (var x in build.motherboard_ids)
                    {
                        ViewBag.mb.AddRange(db.motherboards.Where(m => m.motherboard_id == x));
                    }
                    foreach (var x in build.processor_ids)
                    {
                        ViewBag.pr.AddRange(db.processors.Where(m => m.processor_id == x));
                    }
                    foreach (var x in build.memory_ids)
                    {
                        ViewBag.me.AddRange(db.memories.Where(m => m.memory_id == x));
                    }
                    foreach (var x in build.hard_drive_ids)
                    {
                        ViewBag.hd.AddRange(db.hard_drives.Where(m => m.hard_drive_id == x));
                    }
                    foreach (var x in build.sound_card_ids)
                    {
                        ViewBag.sc.AddRange(db.sound_cards.Where(m => m.sound_card_id == x));
                    }
                    foreach (var x in build.video_adapter_ids)
                    {
                        ViewBag.va.AddRange(db.video_adapters.Where(m => m.video_adapter_id == x));
                    }
                    foreach (var x in build.optical_drive_ids)
                    {
                        ViewBag.od.AddRange(db.optical_drives.Where(m => m.optical_drive_id == x));
                    }
                    foreach (var x in build.power_supply_ids)
                    {
                        ViewBag.ps.AddRange(db.power_supplies.Where(m => m.power_supply_id == x));
                    }
                    foreach (var x in build.computer_case_ids)
                    {
                        ViewBag.cc.AddRange(db.computer_cases.Where(m => m.computer_case_id == x));
                    }
                    #endregion
                }
                else if (obj == "ps")
                {
                    build.addPower_supply_id(id_number);
                    #region Recreate Lists
                    foreach (var x in build.motherboard_ids)
                    {
                        ViewBag.mb.AddRange(db.motherboards.Where(m => m.motherboard_id == x));
                    }
                    foreach (var x in build.processor_ids)
                    {
                        ViewBag.pr.AddRange(db.processors.Where(m => m.processor_id == x));
                    }
                    foreach (var x in build.memory_ids)
                    {
                        ViewBag.me.AddRange(db.memories.Where(m => m.memory_id == x));
                    }
                    foreach (var x in build.hard_drive_ids)
                    {
                        ViewBag.hd.AddRange(db.hard_drives.Where(m => m.hard_drive_id == x));
                    }
                    foreach (var x in build.sound_card_ids)
                    {
                        ViewBag.sc.AddRange(db.sound_cards.Where(m => m.sound_card_id == x));
                    }
                    foreach (var x in build.video_adapter_ids)
                    {
                        ViewBag.va.AddRange(db.video_adapters.Where(m => m.video_adapter_id == x));
                    }
                    foreach (var x in build.optical_drive_ids)
                    {
                        ViewBag.od.AddRange(db.optical_drives.Where(m => m.optical_drive_id == x));
                    }
                    foreach (var x in build.power_supply_ids)
                    {
                        ViewBag.ps.AddRange(db.power_supplies.Where(m => m.power_supply_id == x));
                    }
                    foreach (var x in build.computer_case_ids)
                    {
                        ViewBag.cc.AddRange(db.computer_cases.Where(m => m.computer_case_id == x));
                    }
                    #endregion
                }
                else if (obj == "cc")
                {
                    build.addComputer_case_id(id_number);
                    #region Recreate Lists
                    foreach (var x in build.motherboard_ids)
                    {
                        ViewBag.mb.AddRange(db.motherboards.Where(m => m.motherboard_id == x));
                    }
                    foreach (var x in build.processor_ids)
                    {
                        ViewBag.pr.AddRange(db.processors.Where(m => m.processor_id == x));
                    }
                    foreach (var x in build.memory_ids)
                    {
                        ViewBag.me.AddRange(db.memories.Where(m => m.memory_id == x));
                    }
                    foreach (var x in build.hard_drive_ids)
                    {
                        ViewBag.hd.AddRange(db.hard_drives.Where(m => m.hard_drive_id == x));
                    }
                    foreach (var x in build.sound_card_ids)
                    {
                        ViewBag.sc.AddRange(db.sound_cards.Where(m => m.sound_card_id == x));
                    }
                    foreach (var x in build.video_adapter_ids)
                    {
                        ViewBag.va.AddRange(db.video_adapters.Where(m => m.video_adapter_id == x));
                    }
                    foreach (var x in build.optical_drive_ids)
                    {
                        ViewBag.od.AddRange(db.optical_drives.Where(m => m.optical_drive_id == x));
                    }
                    foreach (var x in build.power_supply_ids)
                    {
                        ViewBag.ps.AddRange(db.power_supplies.Where(m => m.power_supply_id == x));
                    }
                    foreach (var x in build.computer_case_ids)
                    {
                        ViewBag.cc.AddRange(db.computer_cases.Where(m => m.computer_case_id == x));
                    }
                    #endregion
                    #region To Save
                    if (build.motherboard_id != null && build.processor_id != null && build.memory_id != null &&
                        build.hard_drive_id != null && (db.motherboards.Where(m => m.motherboard_id == build.motherboard_id)
                        .Select(m => m.gpu_id) != null || build.video_adapter_id != null) && build.power_supply_id != null &&
                        build.computer_case_id != null)
                        Url.Action("Save");
                    #endregion
                }
                else
                {
                    build.subtractPart(obj);
                }
                this.Session["SessionBuild"] = build;
                ViewBag.build = build;
                return PartialView();
            }
            #region View
            else
            {
                foreach (long x in build.motherboard_ids)
                    ViewBag.mb.AddRange(db.motherboards.Where(m => m.motherboard_id == x).ToList());
                foreach (long x in build.processor_ids)
                    ViewBag.pr.AddRange(db.processors.Where(m => m.processor_id == x).ToList());
                foreach (long x in build.memory_ids)
                    ViewBag.me.AddRange(db.memories.Where(m => m.memory_id == x).ToList());
                foreach (long x in build.hard_drive_ids)
                    ViewBag.hd.AddRange(db.hard_drives.Where(m => m.hard_drive_id == x).ToList());
                foreach (long x in build.sound_card_ids)
                    ViewBag.sc.AddRange(db.sound_cards.Where(m => m.sound_card_id == x).ToList());
                foreach (long x in build.video_adapter_ids)
                    ViewBag.va.AddRange(db.video_adapters.Where(m => m.video_adapter_id == x).ToList());
                foreach (long x in build.optical_drive_ids)
                    ViewBag.od.AddRange(db.optical_drives.Where(m => m.optical_drive_id == x).ToList());
                foreach (long x in build.power_supply_ids)
                    ViewBag.ps.AddRange(db.power_supplies.Where(m => m.power_supply_id == x).ToList());
                foreach (long x in build.computer_case_ids)
                    ViewBag.cc.AddRange(db.computer_cases.Where(m => m.computer_case_id == x).ToList());

                //Returns the list of motherboard strings to the view
                this.Session["SessionBuild"] = build;
                ViewBag.build = build;
                return View();
            }
            #endregion
        }

        //GET Add info to the build
        public ActionResult Save()
        {
            UserBuildViewModel model = new UserBuildViewModel();
            model.build = (Build)Session["SessionBuild"];
            
            ViewBag.mbs = db.motherboards.Where(m => m.motherboard_id == model.build.motherboard_id).Select(m => m.motherboard_name).SingleOrDefault().ToString();
            ViewBag.prs = db.processors.Where(p => p.processor_id == model.build.processor_id).Select(p => p.processor_name).SingleOrDefault().ToString();
            ViewBag.mes = db.memories.Where(m => m.memory_id == model.build.memory_id).Select(m => m.memory_name).SingleOrDefault().ToString();
            ViewBag.hds = db.hard_drives.Where(h => h.hard_drive_id == model.build.hard_drive_id).Select(h => h.hard_drive_name).SingleOrDefault().ToString();
            if (model.build.sound_card_id != null)
            {
                ViewBag.scs = db.sound_cards.Where(s => s.sound_card_id == model.build.sound_card_id).Select(s => s.sound_card_name).SingleOrDefault().ToString();
            }
            else
            {
                ViewBag.scs = "No Selection";
            }
            if (model.build.video_adapter_id != null)
            {
                ViewBag.vas = db.video_adapters.Where(v => v.video_adapter_id == model.build.video_adapter_id).Select(v => v.video_adapter_name).SingleOrDefault().ToString();
            }
            else
            {
                ViewBag.vas = "No Selection";
            }
            if (model.build.optical_drive_id != null)
            {
                ViewBag.ods = db.optical_drives.Where(o => o.optical_drive_id == model.build.optical_drive_id).Select(o => o.optical_drive_name).SingleOrDefault().ToString();
            }
            else
            {
                ViewBag.ods = "No Selection";
            }
            ViewBag.pss = db.power_supplies.Where(p => p.power_supply_id == model.build.power_supply_id).Select(p => p.power_supply_name).SingleOrDefault().ToString();
            ViewBag.ccs = db.computer_cases.Where(c => c.computer_case_id == model.build.computer_case_id).Select(c => c.computer_case_name).SingleOrDefault().ToString();
            return View(model);
        }
        
        //POST Save the build to the database and link it to the current user
        [HttpPost]
        public ActionResult Save(UserBuildViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Initialize new instance of the data model
            model.build = (Build)this.Session["SessionBuild"];
            Models.UserBuilds currentLink = new Models.UserBuilds();

            int i = 0;
            int currentBuildID;
            //Dictionary<String, String> buildDictionary = new Dictionary<String, String>();

            //pull i from db

            if (db.Builds.Any((b => b.motherboard_id == model.build.motherboard_id && b.processor_id == model.build.processor_id && b.memory_id == model.build.memory_id && b.hard_drive_id == model.build.hard_drive_id && b.sound_card_id == model.build.sound_card_id && b.video_adapter_id == model.build.video_adapter_id && b.optical_drive_id == model.build.optical_drive_id && b.power_supply_id == model.build.power_supply_id && b.computer_case_id == model.build.computer_case_id)))
            {
                i = db.Builds.Where((b => b.motherboard_id == model.build.motherboard_id && b.processor_id == model.build.processor_id && b.memory_id == model.build.memory_id && b.hard_drive_id == model.build.hard_drive_id && b.sound_card_id == model.build.sound_card_id && b.video_adapter_id == model.build.video_adapter_id && b.optical_drive_id == model.build.optical_drive_id && b.power_supply_id == model.build.power_supply_id && b.computer_case_id == model.build.computer_case_id)).Select(b => b.iterator).SingleOrDefault();
            }

            //Need to add user input to: BuildType, BuildName, BuildTime

            //if i not null update iterator
            if (!(i == 0))
            {
                Build buildQuery = (from b in db.Builds
                                    where b.motherboard_id == model.build.motherboard_id && b.processor_id == model.build.processor_id && b.memory_id == model.build.memory_id && b.hard_drive_id == model.build.hard_drive_id && b.sound_card_id == model.build.sound_card_id && b.video_adapter_id == model.build.video_adapter_id && b.optical_drive_id == model.build.optical_drive_id && b.power_supply_id == model.build.power_supply_id && b.computer_case_id == model.build.computer_case_id
                                    select b).Single<Build>();
                buildQuery.iterator = i + 1;
                buildQuery.buildType = model.buildType;
                buildQuery.BuildTime = DateTime.Now;
                currentBuildID = (int)buildQuery.buildID;
            }

            //else add Build with user input
            else
            {
                model.build.iterator = 1;
                model.build.buildType = model.buildType;
                model.build.BuildTime = DateTime.Now;
                model.build.buildID = db.Builds.Max(b => b.buildID) + 1;
                db.Builds.Add(model.build);
                currentBuildID = model.build.buildID;
            }

            currentLink.UserId = User.Identity.GetUserId();
            currentLink.buildName = model.buildName;
            currentLink.buildID = currentBuildID;
            
            // Save and redirect
            db.UserBuilds.Add(currentLink);
            db.SaveChanges();

            this.Session["SessionBuild"] = new Build();

            return RedirectToAction("Index", "Home");
        }
        
        ////GET Save the build to the database
        //public ActionResult Save()
        //{
        //    Build build = (Build)this.Session["SessionBuild"];
        //    int i = 0;
        //    //Dictionary<String, String> buildDictionary = new Dictionary<String, String>();

        //    //pull i from db

        //    i = db.Builds.Where((b => b.motherboard_id == build.motherboard_id && b.processor_id == build.processor_id && b.memory_id == build.memory_id && b.hard_drive_id == build.hard_drive_id && b.sound_card_id == build.sound_card_id && b.video_adapter_id == build.video_adapter_id && b.optical_drive_id == build.optical_drive_id && b.power_supply_id == build.power_supply_id && b.computer_case_id == build.computer_case_id)).Select(b => b.iterator).SingleOrDefault();

        //    //Need to add user input to: BuildType, BuildName, BuildTime

        //    //if i not null update iterator
        //    if (!(i == 0))
        //    {
        //        Build buildQuery = (from b in db.Builds
        //                            where b.motherboard_id == build.motherboard_id && b.processor_id == build.processor_id && b.memory_id == build.memory_id && b.hard_drive_id == build.hard_drive_id && b.sound_card_id == build.sound_card_id && b.video_adapter_id == build.video_adapter_id && b.optical_drive_id == build.optical_drive_id && b.power_supply_id == build.power_supply_id && b.computer_case_id == build.computer_case_id
        //                            select b).Single<Build>();
        //        buildQuery.iterator = i + 1;
        //    }

        //    //else add Build with user input
        //    else
        //    {
        //        build.iterator = 1;
        //    }
        //    ViewData["Motherboard"] = db.motherboards.Where(m => m.motherboard_id == build.motherboard_id).Select(m => m.motherboard_name).SingleOrDefault();
        //    ViewData["Processor"] = db.processors.Where(p => p.processor_id == build.processor_id).Select(p => p.processor_name).SingleOrDefault();
        //    ViewData["Memory"] = db.memories.Where(m => m.memory_id == build.memory_id).Select(m => m.memory_name).SingleOrDefault();
        //    ViewData["Hard Drive"] = db.hard_drives.Where(h => h.hard_drive_id == build.hard_drive_id).Select(h => h.hard_drive_name).SingleOrDefault();
        //    ViewData["Sound Card"] = db.sound_cards.Where(s => s.sound_card_id == build.sound_card_id).Select(s => s.sound_card_name).SingleOrDefault();
        //    ViewData["Video Adapter"] = db.video_adapters.Where(v => v.video_adapter_id == build.video_adapter_id).Select(v => v.video_adapter_name).SingleOrDefault();
        //    ViewData["Optical Drive"] = db.optical_drives.Where(o => o.optical_drive_id == build.optical_drive_id).Select(o => o.optical_drive_name).SingleOrDefault();
        //    ViewData["Power Supply"] = db.power_supplies.Where(p => p.power_supply_id == build.power_supply_id).Select(p => p.power_supply_name).SingleOrDefault();
        //    ViewData["Computer Case"] = db.computer_cases.Where(c => c.computer_case_id == build.computer_case_id).Select(c => c.computer_case_name).SingleOrDefault();
        //    return View();
        }
        ////POST Save Build to the database
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Saved([Bind(Include = "buildID,motherboard_id,computer_case_id,hard_drive_id,optical_drive_id,power_supply_id,processer_id,sound_card_id,video_adapter_id,memory_id,buildType,iterator,BuildTime")] Build build, string buildName, string buildType)
        //{

        //}

        //// GET: Builds/Details/5
        //public ActionResult Details(long? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Build build = db.Build.Find(id);
        //    if (build == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(build);
        //}

        //// GET: Builds/Create
        //public ActionResult Create()
        //{
        //    ViewBag.computer_case_id = new SelectList(db.computer_cases, "computer_case_id", "color");
        //    ViewBag.hard_drive_id = new SelectList(db.hard_drives, "hard_drive_id", "hard_drive_name");
        //    ViewBag.memory_id = new SelectList(db.memories, "memory_id", "memory_name");
        //    ViewBag.motherboard_id = new SelectList(db.motherboards, "motherboard_id", "motherboard_name");
        //    ViewBag.optical_drive_id = new SelectList(db.optical_drives, "optical_drive_id", "optical_drive_name");
        //    ViewBag.power_supply_id = new SelectList(db.power_supplies, "power_supply_id", "power_supply_name");
        //    ViewBag.sound_card_id = new SelectList(db.sound_cards, "sound_card_id", "sound_card_name");
        //    ViewBag.video_adapter_id = new SelectList(db.video_adapters, "video_adapter_id", "video_adapter_name");
        //    return View();
        //}

        //// POST: Builds/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "buildID,motherboard_id,computer_case_id,hard_drive_id,optical_drive_id,power_supply_id,processer_id,sound_card_id,video_adapter_id,memory_id,buildType,iterator,BuildTime")] Build build)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Build.Add(build);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.computer_case_id = new SelectList(db.computer_cases, "computer_case_id", "color", build.computer_case_id);
        //    ViewBag.hard_drive_id = new SelectList(db.hard_drives, "hard_drive_id", "hard_drive_name", build.hard_drive_id);
        //    ViewBag.memory_id = new SelectList(db.memories, "memory_id", "memory_name", build.memory_id);
        //    ViewBag.motherboard_id = new SelectList(db.motherboards, "motherboard_id", "motherboard_name", build.motherboard_id);
        //    ViewBag.optical_drive_id = new SelectList(db.optical_drives, "optical_drive_id", "optical_drive_name", build.optical_drive_id);
        //    ViewBag.power_supply_id = new SelectList(db.power_supplies, "power_supply_id", "power_supply_name", build.power_supply_id);
        //    ViewBag.sound_card_id = new SelectList(db.sound_cards, "sound_card_id", "sound_card_name", build.sound_card_id);
        //    ViewBag.video_adapter_id = new SelectList(db.video_adapters, "video_adapter_id", "video_adapter_name", build.video_adapter_id);
        //    return View(build);
        //}

        //// GET: Builds/Edit/5
        //public ActionResult Edit(long? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Build build = db.Build.Find(id);
        //    if (build == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.computer_case_id = new SelectList(db.computer_cases, "computer_case_id", "color", build.computer_case_id);
        //    ViewBag.hard_drive_id = new SelectList(db.hard_drives, "hard_drive_id", "hard_drive_name", build.hard_drive_id);
        //    ViewBag.memory_id = new SelectList(db.memories, "memory_id", "memory_name", build.memory_id);
        //    ViewBag.motherboard_id = new SelectList(db.motherboards, "motherboard_id", "motherboard_name", build.motherboard_id);
        //    ViewBag.optical_drive_id = new SelectList(db.optical_drives, "optical_drive_id", "optical_drive_name", build.optical_drive_id);
        //    ViewBag.power_supply_id = new SelectList(db.power_supplies, "power_supply_id", "power_supply_name", build.power_supply_id);
        //    ViewBag.sound_card_id = new SelectList(db.sound_cards, "sound_card_id", "sound_card_name", build.sound_card_id);
        //    ViewBag.video_adapter_id = new SelectList(db.video_adapters, "video_adapter_id", "video_adapter_name", build.video_adapter_id);
        //    return View(build);
        //}

        //// POST: Builds/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "buildID,motherboard_id,computer_case_id,hard_drive_id,optical_drive_id,power_supply_id,processer_id,sound_card_id,video_adapter_id,memory_id,buildType,iterator,BuildTime")] Build build)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(build).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.computer_case_id = new SelectList(db.computer_cases, "computer_case_id", "color", build.computer_case_id);
        //    ViewBag.hard_drive_id = new SelectList(db.hard_drives, "hard_drive_id", "hard_drive_name", build.hard_drive_id);
        //    ViewBag.memory_id = new SelectList(db.memories, "memory_id", "memory_name", build.memory_id);
        //    ViewBag.motherboard_id = new SelectList(db.motherboards, "motherboard_id", "motherboard_name", build.motherboard_id);
        //    ViewBag.optical_drive_id = new SelectList(db.optical_drives, "optical_drive_id", "optical_drive_name", build.optical_drive_id);
        //    ViewBag.power_supply_id = new SelectList(db.power_supplies, "power_supply_id", "power_supply_name", build.power_supply_id);
        //    ViewBag.sound_card_id = new SelectList(db.sound_cards, "sound_card_id", "sound_card_name", build.sound_card_id);
        //    ViewBag.video_adapter_id = new SelectList(db.video_adapters, "video_adapter_id", "video_adapter_name", build.video_adapter_id);
        //    return View(build);
        //}

        //// GET: Builds/Delete/5
        //public ActionResult Delete(long? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Build build = db.Build.Find(id);
        //    if (build == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(build);
        //}

        //// POST: Builds/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(long id)
        //{
        //    Build build = db.Build.Find(id);
        //    db.Build.Remove(build);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
}
