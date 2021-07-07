﻿using System;
using System.Collections.Generic;

namespace SpecFlow.ExternalData.SpecFlowPlugin.DataSources
{
    public class DataList
    {
        public IList<DataValue> Items { get; } = new List<DataValue>();
    }

    public class DataTable
    {
        public string[] Header { get; }
        public IList<DataRecord> Items { get; } = new List<DataRecord>();

        public DataTable(string[] header)
        {
            Header = header ?? throw new ArgumentNullException(nameof(header));
        }
    }
}