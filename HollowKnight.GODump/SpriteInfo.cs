﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modding;

namespace GODump
{
    [Serializable]
    public class SpriteInfo
    {
        public List<int> sid;
        public List<int> sx;
        public List<int> sy;

        public List<string> scollectionname;
        public List<string> spath;

        public List<bool> sfilpped;

        public SpriteInfo()
        {
            sid = new List<int>();
            sx = new List<int>();
            sy = new List<int>();

            scollectionname = new List<string>();
            spath = new List<string>();

            sfilpped = new List<bool>();
        }

        public void Add(int _sid, int _sx, int _sy, string _scollectionname, string _spath, bool _sfilpped)
        {
            sid.Add(_sid);
            sx.Add(_sx);
            sy.Add(_sy);
            scollectionname.Add(_scollectionname);
            spath.Add(_spath);
            sfilpped.Add(_sfilpped);
        }


    }
}
