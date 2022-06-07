using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.Test
{
    public partial class TutorialsTbl
    {
        public int TutorialId { get; set; }
        public string TutorialTitle { get; set; }
        public string TutorialAuthor { get; set; }
        public DateTime? SubmissionDate { get; set; }
    }
}
