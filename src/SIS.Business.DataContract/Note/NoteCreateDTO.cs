﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Note
{
    public class NoteCreateDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public int OwnerId { get; set; }
    }
}
