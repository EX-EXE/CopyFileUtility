﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class CopyFileUtility
{
    public class CopyFileOptions
    {
        public int BufferSize { get; set; } = 1024 * 1024;
        public int PoolSize { get; set; } = 16;

        public bool OverrideExistFile { get; set; } = false;

        public TimeSpan ReportInterval { get; set; } = TimeSpan.FromMilliseconds(500);

    }
}
