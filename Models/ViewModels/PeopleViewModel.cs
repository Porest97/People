﻿using People.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.Models.ViewModels
{
    public class PeopleViewModel
    {      

        public List<Person> People { get; internal set; }
    }
}
