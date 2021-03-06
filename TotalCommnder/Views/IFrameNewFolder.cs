﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommnder
{
    public interface IFrameNewFolder
    {
        List<DirectoryElement> Directories { set; }
        string GetNewFolderName { get; }
        string GetNewFolderDestination { get; }
        event Action call;
    }
}
