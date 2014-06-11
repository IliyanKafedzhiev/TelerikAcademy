using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentException("grade is less than 0");
        }
        if (minGrade < 0)
        {
            throw new ArgumentException("minGrade is less than 0");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("maxGrade is less than minGrade");
        }
        if (comments == null)
        {
            throw new ArgumentNullException("comments parameter is null");
        }
        if (comments == "")
        {
            throw new ArgumentException("empty comments");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
