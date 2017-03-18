using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication3.ViewModel
{
    class StudentCollectionViewModel
    {       public StudentCollectionViewModel()
                    {
            GroupList.Add(new Model.Group());

                    }
        [BindableProperty]
        public virtual ObservableCollection<Model.Student> StudentList { get; set; }
        public virtual ObservableCollection<Model.ExpilledStudent> ExpilliedStudentList { get; set; }

        public virtual ObservableCollection<Model.Group> GroupList { get; set; }
        [BindableProperty]
        public virtual Model.Student CurrentStudent { get; set; }
        [Command]
        public void NewStudent()
            {
            StudentList.Add(new Model.Student());
            }
        [Command]
        public void DeleteStudent(Model.Student stud)
            { 
            }
        [Command]
        public void RemoveStudent(Model.Student stud) {

        }
        [Command]
        public void StudentOnExpullsion(Model.Student stud) {
           var S= StudentList.Single(w => w.Id == stud.Id);
            StudentList.Remove(S);
            ExpilliedStudentList.Add(new Model.ExpilledStudent());

        }
    }
}
