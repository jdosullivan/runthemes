﻿using System;
using System.Collections.Generic;

namespace WhiteLabel.Web.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            Photos = new List<string>();
        }

        public Guid Id { get; set; }
        public string AvatarThumbnailUrl { get; set; }
        public string DisplayName { get; set; }
        public string About { get; set; }
        public IEnumerable<string> Photos { get; set; }
    }
}