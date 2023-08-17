using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalumNotification.Dtos
{
    public class NotificationResponseDTO
    {
        public int HttpStatusCode {get;set;}
        public string Message {get;set;}
    }
}