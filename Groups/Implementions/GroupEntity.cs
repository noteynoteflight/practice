using Groups.Implementions;

namespace Groups.Implementions;

public class GroupEntity
{
    public string Name { get; set; }
    public List<StudentEntity> Students { get; set; }
    public TeacherEntity Teacher { get; set; }
}