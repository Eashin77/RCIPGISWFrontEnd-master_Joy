using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RCIPGISWFrontEnd.Models
{
    public class User
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public int IsActive { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public Permissions Permissions { get; set; }
        public List<object> Menus { get; set; }
        public List<object> Modules { get; set; }
        public UserOffice UserOffice { get; set; }
        public List<object> UserProjects { get; set; }
        public List<UserLocation> UserLocations { get; set; }
        public int TenantId { get; set; }
    }
}