using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalumNotification.Dtos
{
    public class NotificationRequestDTO
    {
        public string Email { get; set ; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Type { get; set; }
        public string IdentificationId { get; set; }
        
    }
}