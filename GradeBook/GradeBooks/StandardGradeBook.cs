using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool IsWeighted) : base (name, isWeighted:)
        {
            Type = GradeBookType.Standard;
        }
    }
}