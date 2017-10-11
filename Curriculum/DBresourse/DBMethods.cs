using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDll
{
    public class DBMethods
    {
        public static SQLiteConnection connection = new SQLiteConnection(@"Data Source=..\..\Resources\DBCurriculum;Version=3;");

        public static ObservableCollection<Group> getGroups()
        {
            using (var query = new SQLiteCommand("SELECT * FROM Group_", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                ObservableCollection<Group> lg = new ObservableCollection<Group>();
                while (reader.Read())
                {
                    lg.Add(new Group
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Number = reader["Number"].ToString(),
                        Specialty = reader["Specialty"].ToString()
                    });
                }
                connection.Close();
                return lg;
            }
        }

        public static ObservableCollection<GroupLessonTypeLesson> getGroupLTypeL()
        {
            using (var query = new SQLiteCommand("SELECT * FROM GroupLessonTypeLesson", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                ObservableCollection<GroupLessonTypeLesson> gltl = new ObservableCollection<GroupLessonTypeLesson>();
                while (reader.Read())
                {
                    gltl.Add(new GroupLessonTypeLesson
                    {
                        Id_Group = Convert.ToInt32(reader["Id_Group"]),
                        Id_LessonTypeLesson = Convert.ToInt32(reader["Id_LessonTypeLesson"])
                    });
                }
                connection.Close();
                return gltl;
            }
        }

        public static ObservableCollection<Lesson> getLesson()
        {
            using (var query = new SQLiteCommand("SELECT * FROM Lesson", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                ObservableCollection<Lesson> ll = new ObservableCollection<Lesson>();
                while (reader.Read())
                {
                    ll.Add(new Lesson
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString()
                    });
                }
                connection.Close();
                return ll;
            }
        }

        public static ObservableCollection<LessonTypeLesson> getLesTypeLes()
        {
            using (var query = new SQLiteCommand("SELECT * FROM LessonTypeLesson", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                ObservableCollection<LessonTypeLesson> ltl = new ObservableCollection<LessonTypeLesson>();
                while (reader.Read())
                {
                    ltl.Add(new LessonTypeLesson
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Id_Lesson = Convert.ToInt32(reader["Id_Lesson"]),
                        Id_TypeLesson = Convert.ToInt32(reader["Id_TypeLesson"]),
                        Hours = Convert.ToInt32(reader["Hours"]),
                    });
                }
                connection.Close();
                return ltl;
            }
        }

        public static ObservableCollection<LessonTypeLessonTypeRoom> getLTypeLTypeRoom()
        {
            using (var query = new SQLiteCommand("SELECT * FROM LessonTypeLessonTypeRoom", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                ObservableCollection<LessonTypeLessonTypeRoom> ltltr = new ObservableCollection<LessonTypeLessonTypeRoom>();
                while (reader.Read())
                {
                    ltltr.Add(new LessonTypeLessonTypeRoom
                    {
                        Id_LessonTypeLesson = Convert.ToInt32(reader["Id_LessonTypeLesson"]),
                        Id_TypeRoom = Convert.ToInt32(reader["Id_TypeRoom"])
                    });
                }
                connection.Close();
                return ltltr;
            }
        }

        public static ObservableCollection<Pair> getPair()
        {
            using (var query = new SQLiteCommand("SELECT * FROM Pair", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                ObservableCollection<Pair> lp = new ObservableCollection<Pair>();
                while (reader.Read())
                {
                    lp.Add(new Pair
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Number = Convert.ToInt32(reader["Id"]),
                        Id_LessonTypeLesson = Convert.ToInt32(reader["Id_LessonTypeLesson"]),
                        Id_Teacher = Convert.ToInt32(reader["Id_Teacher"]),
                        Id_Room = Convert.ToInt32(reader["Id_Room"]),
                        Id_Group = Convert.ToInt32(reader["Id_Group"])
                    });
                }
                connection.Close();
                return lp;
            }
        }

        public static ObservableCollection<Room> getRoom()
        {
            using (var query = new SQLiteCommand("SELECT * FROM Room", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                ObservableCollection<Room> lr = new ObservableCollection<Room>();
                while (reader.Read())
                {
                    lr.Add(new Room
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Number = reader["Number"].ToString()
                    });
                }
                connection.Close();
                return lr;
            }
        }

        public static ObservableCollection<RoomTypeRoom> getRoomTypeRoom()
        {
            using (var query = new SQLiteCommand("SELECT * FROM RoomTypeRoom", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                ObservableCollection<RoomTypeRoom> lrtr = new ObservableCollection<RoomTypeRoom>();
                while (reader.Read())
                {
                    lrtr.Add(new RoomTypeRoom
                    {
                        Id_Room = Convert.ToInt32(reader["Id_Room"]),
                        Id_TypeRoom = Convert.ToInt32(reader["Id_TypeRoom"])
                    });
                }
                connection.Close();
                return lrtr;
            }
        }

        public static ObservableCollection<Teacher> getTeacher()
        {
            using (var query = new SQLiteCommand("SELECT * FROM Teacher", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                ObservableCollection<Teacher> lt = new ObservableCollection<Teacher>();
                while (reader.Read())
                {
                    lt.Add(new Teacher
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Patronomic = reader["Patronomic"].ToString(),
                        Surname = reader["Surname"].ToString(),
                        Age = Convert.ToInt32(reader["Age"])

                    });
                }
                connection.Close();
                return lt;
            }
        }

        public static ObservableCollection<TeacherLesson> getTeacherLesson()
        {
            using (var query = new SQLiteCommand("SELECT * FROM TeacherLesson", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                ObservableCollection<TeacherLesson> ltl = new ObservableCollection<TeacherLesson>();
                while (reader.Read())
                {
                    ltl.Add(new TeacherLesson
                    {
                        Id_Teacher = Convert.ToInt32(reader["Id_Teacher"]),
                        Id_Lesson = Convert.ToInt32(reader["Id_Lesson"]),
                    });
                }
                connection.Close();
                return ltl;
            }
        }

        public static ObservableCollection<TypeLesson> getTypeLesson()
        {
            using (var query = new SQLiteCommand("SELECT * FROM TypeLesson", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                ObservableCollection<TypeLesson> ltl = new ObservableCollection<TypeLesson>();
                while (reader.Read())
                {
                    ltl.Add(new TypeLesson
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                    });
                }
                connection.Close();
                return ltl;
            }
        }

        public static ObservableCollection<WorkDay> getWorkDay()
        {
            using (var query = new SQLiteCommand("SELECT * FROM WorkDay", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                ObservableCollection<WorkDay> lwd = new ObservableCollection<WorkDay>();
                while (reader.Read())
                {
                    lwd.Add(new WorkDay
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Date = DateTime.ParseExact(reader["Date"].ToString(),"dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    });
                }
                connection.Close();
                return lwd;
            }
        }

        public static ObservableCollection<WorkDayPairs> getWorkDayPairs()
        {
            using (var query = new SQLiteCommand("SELECT * FROM WorkDayPairs", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                ObservableCollection<WorkDayPairs> lwdp = new ObservableCollection<WorkDayPairs>();
                while (reader.Read())
                {
                    lwdp.Add(new WorkDayPairs
                    {
                       Id_WorkDay = Convert.ToInt32(reader["Id_WorkDay"]),
                       Id_Pair = Convert.ToInt32(reader["Id_Pair"]),
                       
                    });
                }
                connection.Close();
                return lwdp;
            }
        }
    }
}

