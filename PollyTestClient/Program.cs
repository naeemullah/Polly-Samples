﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Polly;

namespace PollyTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Execute samples:

            Samples.RetryForever.Execute();
        }
    }
}
