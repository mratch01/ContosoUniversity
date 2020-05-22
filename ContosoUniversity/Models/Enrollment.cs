namespace TheStore.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int ItemID { get; set; }
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Item Item { get; set; }
    }
}