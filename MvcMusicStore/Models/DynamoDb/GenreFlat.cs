﻿using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models.DynamoDb
{
    [DynamoDBTable("AlbumFlat")]
    public class GenreFlat : Genre
    {
        [DynamoDBHashKey("PK")]
        public string Type { get; set; }
    }
}