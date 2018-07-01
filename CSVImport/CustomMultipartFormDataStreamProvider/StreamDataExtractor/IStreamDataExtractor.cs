﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Model;

namespace CustomMultipartFormDataStreamProvider.StreamDataExtractor
{
    public interface IStreamDataExtractor
    {
        List<Company> ExtractDataFromStream(Stream stream);
    }
}
