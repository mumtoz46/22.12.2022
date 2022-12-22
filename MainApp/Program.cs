using Domain.Models;
var st = new Student();

st.id = 1;
st.FirstName = "Mumtoz";
st.LastName = "Sharipov";
st.BirthDate = DateTime.Now;
st.Address = "Softclub";
var st2 = new Student();

st2.id = 2;
st2.FirstName = "Nizom";
st2.LastName = "Mahmadql";
st2.BirthDate = DateTime.Now;
st2.Address = "76";
var stServiece = new StudentService();

stServiece.AddStudent(st);
stServiece.AddStudent(st2);


foreach (var stEl in stServiece.GetStudents())
{
    System.Console.WriteLine($"{stEl.id} {stEl.FirstName} {stEl.LastName} {stEl.BirthDate} {stEl.Address}");
}
stServiece.Delete(1);
foreach (var stEl in stServiece.GetStudents())
{
    System.Console.WriteLine();
    System.Console.WriteLine($"{stEl.id} {stEl.FirstName} {stEl.LastName} {stEl.BirthDate} {stEl.Address}");
}
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("UpDates");
st2.id = 2;
st2.FirstName = "gtrnv";
st2.LastName = "gtrv";
st2.BirthDate = DateTime.Now;
st2.Address = "8464";
stServiece.UpdateStudent(st2);
foreach (var stEl in stServiece.GetStudents())
{
    System.Console.WriteLine();
    System.Console.WriteLine($"{stEl.id} {stEl.FirstName} {stEl.LastName} {stEl.BirthDate} {stEl.Address}");
}