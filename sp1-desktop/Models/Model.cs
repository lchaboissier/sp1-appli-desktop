using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sp1_desktop.Models
{
    class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public int Seats { get; set; }
        public int? Brand_id{ get; set; }
    }
}
