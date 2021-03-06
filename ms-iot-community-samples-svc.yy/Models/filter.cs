﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ms_iot_community_samples_svc.Models
{
    [Serializable]
    public class FilterAndSortInfo
    {
        public bool LoggedInStatus { get; set; } = false;
        public List<Tuple<string, string>> Filters { get; set; } = null;
        public List<Tuple<string, string>> SortExpressions { get; set; } = null;
        public string LastSort { get; set; } = "";
        public string LastSortDirection { get; set; } = "desc";

        public  FilterAndSortInfo()
        {
            Filters = new List<Tuple<string, string>>();
            SortExpressions = new List<Tuple<string, string>>();
            LastSort = "";
            LastSortDirection = "desc";
            LoggedInStatus = false;
        }
    }
}