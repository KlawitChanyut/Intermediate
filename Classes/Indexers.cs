﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Classes
{
    public class Indexers
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public Indexers()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public void SetItem(string key, string vaiue)
        {

        }

        public string GetItem(string key)
        {

        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
