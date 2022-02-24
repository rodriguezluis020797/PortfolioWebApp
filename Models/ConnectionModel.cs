using System;
using System.ComponentModel.Design;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PortfolioWebApp.Models
{
    [Table("Connections")]
    public class ConnectionModel
    {
        [Key]
        public Int64 ConnectionId { get; set; }
        public DateTime DateTime { get; set; }

        public void assignNewObject(){
            this.DateTime = DateTime.UtcNow.ToLocalTime();
        }

    }
}