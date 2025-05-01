using Microsoft.AspNetCore.Mvc.Rendering;

namespace LoginWorkWithTheHelpOFDBFirst.Models
{
    public class StudentListModel
    {
        public int Id { get; set; }
        public List<SelectListItem> StudentList { get; set; }

        public Student SelectedStudent { get; set; }

    }
}
