using System;

public class SimpleMathExam : Exam
{
    private int problemsSolved;
    public int ProblemsSolved {
        get
        {
            return this.problemsSolved;
        } 
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid problems solved devined as parameter in constuctor of SimpleMathExam class");
            }
            if (value > 10)
            {
                throw new ArgumentException("Invalid problems solved devined as parameter in constuctor of SimpleMathExam class");
            }
            this.problemsSolved = value;
        }
    }

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public override ExamResult Check()
    {
        if (ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: nothing done.");
        }
        else if (ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Average result: nothing done.");
        }

        throw new Exception("Invalid problems solved");
    }
}
