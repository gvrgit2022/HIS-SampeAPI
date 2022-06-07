using SampleAPI.Application.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAPI.Application.Test.Model
{
    public class TutorialsTblModelcs:BaseModel    {
        public int TutorialId { get; set; }
        public string TutorialTitle { get; set; }
        public string TutorialAuthor { get; set; }
        public DateTime? SubmissionDate { get; set; }
    }
}
