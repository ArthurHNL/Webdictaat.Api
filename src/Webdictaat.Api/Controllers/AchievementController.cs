﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Webdictaat.Api.Services;
using Webdictaat.CMS.Models;
using Webdictaat.CMS.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Webdictaat.Api.ViewModels;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Webdictaat.Domain.User;
using Webdictaat.Domain;
using Webdictaat.Api.Models;

namespace Webdictaat.Api.Controllers
{
    [Route("api/dictaten/{dictaatName}/[controller]")]
    public class AchievementController : Controller
    {
        private IAchievementRepository _achievementRepo;
        private UserManager<ApplicationUser> _userManager;

        [HttpGet]
        [Authorize]
        public List<AchievementVM> Get(string dictaatName)
        {
            string userId = _userManager.GetUserId(HttpContext.User);
            List<AchievementVM> result = _achievementRepo.GetAllAchievements(dictaatName, userId);
            return result;
        }

        [HttpGet("{achievementId}")]
        [Authorize]
        public AchievementVM Get(int achievementId, string dictaatName)
        {
            string userId = _userManager.GetUserId(HttpContext.User);
            AchievementVM result = _achievementRepo.GetAchievement(achievementId, dictaatName, userId);
            return result;
        }
    }
}