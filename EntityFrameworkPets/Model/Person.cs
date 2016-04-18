﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPets.Model {
  
  public class Person {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public IList<Pet> Pets { get; set; } = new List<Pet>();
    public IList<Club> Clubs { get; set; } = new List<Club>();
    }
  }
