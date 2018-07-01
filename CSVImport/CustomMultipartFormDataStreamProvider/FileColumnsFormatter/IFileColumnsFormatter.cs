﻿using System.Collections.Generic;
using Data;

namespace CustomMultipartFormDataStreamProvider.FileColumnsFormatter
{
    public interface IFileColumnsFormatter
    {
        Dictionary<string, int> ReadColumnIndexes(string[] headers, List<int> columnsList);

        Company FormCompany(string[] values, List<int> columnsList);
    }
}
