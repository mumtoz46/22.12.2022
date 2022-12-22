using Domain.Models;
public class StudentService
{
    public List<Student> students;
    public List<Student> GetStudents ()
    {
return students;
    }
    public StudentService()
    {
        students = new List<Student>();
    }
    public void AddStudent (Student student )
    {
        students.Add(student);
    }
     public void UpdateStudent (Student student)
    {
        var find  = students.FirstOrDefault(x=>x.id == student.id);
        find.Address =student.Address;
        find.BirthDate =student.BirthDate;
        find.FirstName =student.FirstName;
        
    }
    public void Delete (int id)
    {
       var find  = students.FirstOrDefault(x=>x.id == id); 
       students.Remove(find);
    }
}