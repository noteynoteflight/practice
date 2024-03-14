using Groups.Implementions;

namespace Students.Implementations;

public class TeacherEntity : PersonEntity
{
    public int TeacherId { get; set; }
    public List<SubjectEntity> Subjects { get; set; }

    public TeacherEntity()
    {
        Subjects = new List<SubjectEntity>();
    }
}