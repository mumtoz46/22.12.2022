using Domain.Models;
public class TeacherService
{
    public List<Teacher> teachers;
    public List<Teacher> GetTeacher ()
    {
return teachers;
    }
    public void AddTeacher (Teacher teacher )
    {
        teachers.Add(teacher);
    }
     public void UpdateTeacher (Teacher teacher)
    {
        var find  = teachers.FirstOrDefault(x=>x.id == teacher.id);
        find.FirstName =teacher.FirstName;
        find.id =teacher.id;
        find.Position =teacher.Position;
        
    }
    public void Delete (int id)
    {
       var find  = teachers.FirstOrDefault(x=>x.id == id); 
       teachers.Remove(find);
    }
}