using System.Collections.Generic;

namespace ClassLibTeam05.Business.Entities
{
    public class ApiResponse<T>
    {
        public List<T> DataTable { get; set; }
        public bool Succeeded { get; set; }
        public List<string> Errors { get; set; }
    }
}
