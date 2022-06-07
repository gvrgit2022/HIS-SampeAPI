using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblErrorLog
    {
        public int? ErrId { get; set; }
        public string ErrModule { get; set; }
        public string ErrType { get; set; }
        public string ErrValue { get; set; }
        public string ErrMsg { get; set; }
        public string ErrProc { get; set; }
        public string ErrState { get; set; }
        public string ErrSeverity { get; set; }
        public string ErrNum { get; set; }
        public DateTime? ErrDate { get; set; }
    }
}
