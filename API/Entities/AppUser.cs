using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {   
        /* Fields are public for Entity Framwork to access it. */
        /* Entity framework recognize 'id' as convention, primary key */
        public int Id { get; set; }
        /* ASP CORE identity uses 'UserName' as convention. Case sensitive */ 
        public string UserName { get; set; }
    }
}