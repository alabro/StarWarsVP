﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsVP
{
    public interface Armed
    {
        public List<Bullet> Shoot();
    }
}