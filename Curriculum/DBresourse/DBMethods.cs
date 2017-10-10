using System;
using System.Collections.Generic;
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

        public static List<Group> getGroups()
        {
            using (var query = new SQLiteCommand("SELECT * FROM Group_", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                List<Group> lg = new List<Group>();
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

        public static List<GroupLessonTypeLesson> getGroupLTypeL()
        {
            using (var query = new SQLiteCommand("SELECT * FROM GroupLessonTypeLesson", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                List<GroupLessonTypeLesson> gltl = new List<GroupLessonTypeLesson>();
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

        public static List<Lesson> getLesson()
        {
            using (var query = new SQLiteCommand("SELECT * FROM Lesson", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                List<Lesson> ll = new List<Lesson>();
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

        public static List<LessonTypeLesson> getLesTypeLes()
        {
            using (var query = new SQLiteCommand("SELECT * FROM LessonTypeLesson", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                List<LessonTypeLesson> ltl = new List<LessonTypeLesson>();
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

        public static List<LessonTypeLessonTypeRoom> getLTypeLTypeRoom()
        {
            using (var query = new SQLiteCommand("SELECT * FROM LessonTypeLessonTypeRoom", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                List<LessonTypeLessonTypeRoom> ltltr = new List<LessonTypeLessonTypeRoom>();
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

        public static List<Pair> getPair()
        {
            using (var query = new SQLiteCommand("SELECT * FROM Pair", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                List<Pair> lp = new List<Pair>();
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

        public static List<Room> getRoom()
        {
            using (var query = new SQLiteCommand("SELECT * FROM Room", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                List<Room> lr = new List<Room>();
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

        public static List<RoomTypeRoom> getRoomTypeRoom()
        {
            using (var query = new SQLiteCommand("SELECT * FROM RoomTypeRoom", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                List<RoomTypeRoom> lrtr = new List<RoomTypeRoom>();
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

        public static List<Teacher> getTeacher()
        {
            using (var query = new SQLiteCommand("SELECT * FROM Teacher", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                List<Teacher> lt = new List<Teacher>();
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

        public static List<TeacherLesson> getTeacherLesson()
        {
            using (var query = new SQLiteCommand("SELECT * FROM TeacherLesson", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                List<TeacherLesson> ltl = new List<TeacherLesson>();
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

        public static List<TypeLesson> getTypeLesson()
        {
            using (var query = new SQLiteCommand("SELECT * FROM TypeLesson", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                List<TypeLesson> ltl = new List<TypeLesson>();
                while (reader.Read())
                {
                    ltl.Add(new TypeLesson
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                    });
                }
                return ltl;
            }
        }

        public static List<WorkDay> getWorkDay()
        {
            using (var query = new SQLiteCommand("SELECT * FROM WorkDay", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                List<WorkDay> lwd = new List<WorkDay>();
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

        public static List<WorkDayPairs> getWorkDayPairs()
        {
            using (var query = new SQLiteCommand("SELECT * FROM WorkDayPairs", connection))
            {
                connection.Open();
                SQLiteDataReader reader = query.ExecuteReader();
                List<WorkDayPairs> lwdp = new List<WorkDayPairs>();
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

