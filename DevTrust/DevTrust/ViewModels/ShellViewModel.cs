﻿using Caliburn.Micro;
using DevTrust.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTrust.ViewModels
{
    internal class ShellViewModel
    {
        public BindableCollection<PersonModel> People { get; set; } = new BindableCollection<PersonModel>();

        public ShellViewModel()
        {
            DataAccess da = new DataAccess();
            People = new BindableCollection<PersonModel>(da.GetPeople());
        }
    }
}
