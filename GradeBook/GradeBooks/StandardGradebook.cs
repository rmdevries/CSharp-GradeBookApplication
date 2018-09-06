using System;
using System.Collections.Generic;
using System.Text;

using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    class StandardGradebook : BaseGradeBook
    {
        public StandardGradebook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = GradeBookType.Standard;
        }
    }
}
