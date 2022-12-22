using Domain.Models;
public class CourseService
{
    public List<Course> courses;
    public List<Course> GetCourses ()
    {
return courses;
    }
    public void AddCourses (Course course )
    {
        courses.Add(course);
    }
     public void UpdateCourse (Course course)
    {
        var find  = courses.FirstOrDefault(x=>x.id == course.id);
        find.Title =course.Title;
        find.id =course.id;
        find.Fee =course.Fee;
        
    }
    public void Delete (int id)
    {
       var find  = courses.FirstOrDefault(x=>x.id == id); 
       courses.Remove(find);
    }
}