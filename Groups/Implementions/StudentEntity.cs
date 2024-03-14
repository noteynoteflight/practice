namespace Groups.Implementions;

public class StudentEntity : PersonEntity
{
    public int StudentId { get; set; }
    public List<SubjectEntity> Subjects { get; set; }

    public StudentEntity()
    {
        Subjects = new List<SubjectEntity>();
    }
}