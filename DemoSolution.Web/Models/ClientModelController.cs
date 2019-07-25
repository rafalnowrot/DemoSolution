﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoSolution.Web.Models
{
    public class ClientModelController : Controller
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PlateName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}