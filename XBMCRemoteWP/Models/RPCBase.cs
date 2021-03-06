﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XBMCRemoteWP.Models
{
    /// <summary>
    /// Base class for all the RPC requests. Defauts value of id to 1 and jsonrpc to 2.0
    /// </summary>
    public class RPCBase
    {
        private int _id = 1;
        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    _id = value;
                }
            }
        }

        private string _jsonrpc = "2.0";
        public string jsonrpc
        {
            get
            {
                return _jsonrpc;
            }
            set
            {
                if (_jsonrpc != value)
                {
                    _jsonrpc = value;
                }
            }
        }
    }
}
