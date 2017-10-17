using Curriculum.DBresourse;
using Curriculum.Infrastructure;
using Curriculum.Model;
using Curriculum.Model.Flyout;
using Curriculum.Model.Flyout.StaticData;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Curriculum.ViewModel
{
    public class Commands
    {
        private ICommand addLesson;
        public ICommand AddLesson
        {
            get
            {
                return addLesson ??
                    (addLesson = new RelayCommand(obj =>
                    {
                        var lesson = obj as Lesson;
                        if (lesson == null)
                            return;

                        StaticProxy.Lessons.Add(lesson);

                    }));
            }
        }

        #region in Flyout New Subject
        private ICommand sendTypeLesson;
        public ICommand SendTypeLesson
        {
            get
            {
                return sendTypeLesson ??
                    (sendTypeLesson = new RelayCommand(obj =>
                    {
                        var typeLesson = obj as TypeLesson;
                        if(typeLesson == null)
                            return;

                        if (TabNewLesson.CheckedTypesLesson.Contains(typeLesson))
                            TabNewLesson.CheckedTypesLesson.Remove(typeLesson);
                        else
                            TabNewLesson.CheckedTypesLesson.Add(typeLesson);
                           
                    }));
            }
        }

        private ICommand sendTeacher;
        public ICommand SendTeacher
        {
            get
            {
                return sendTeacher ??
                    (sendTeacher = new RelayCommand(obj =>
                    {
                        var teacher = obj as Teacher;
                        if (teacher == null)
                            return;

                        if (TabNewLesson.NewLesson.Teacher.Contains(teacher))
                            TabNewLesson.NewLesson.Teacher.Remove(teacher);
                        else
                            TabNewLesson.NewLesson.Teacher.Add(teacher);
                    }));
            }
        }
        #endregion

        #region in Flyout New Teacher
        private ICommand sendTeachersLesson;
        public ICommand SendTeachersLesson
        {
            get
            {
                return sendTeachersLesson ??
                    (sendTeachersLesson = new RelayCommand(obj =>
                    {
                        var lesson = obj as Lesson;
                        if (lesson == null)
                            return;

                        if (TabNewTeacher.NewTeacher.Lesson.Contains(lesson))
                            TabNewTeacher.NewTeacher.Lesson.Remove(lesson);
                        else
                            TabNewTeacher.NewTeacher.Lesson.Add(lesson);
                    }));
            }
        }
        #endregion
    }
}
