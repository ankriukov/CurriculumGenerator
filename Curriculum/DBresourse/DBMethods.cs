using Curriculum.DBresourse.Classes;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.DBresourse
{
    public class DBMethods
    {
        public static SQLiteConnection connection = new SQLiteConnection(@"Data Source=..\..\Resources\DBCurriculum;Version=3;");
        #region Groups
        public static List<Group> getGroups()
        {
            List<Group> lg = new List<Group>();
            try
            {
                using (var query = new SQLiteCommand("SELECT * FROM Group_", connection))
                {
                    connection.Open();
                    SQLiteDataReader reader = query.ExecuteReader();
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
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("getGroups", ex.Message, ex.StackTrace);
                return lg;
            }
        }

        public static bool addGroups(Group g)
        {
            try
            {
                using (var query = new SQLiteCommand("INSERT INTO Group_ (Number, Specialty) values (@Number, @Specialty)", connection))
                {
                    connection.Open();

                    query.Parameters.Add(new SQLiteParameter("@Number", g.Number));
                    query.Parameters.Add(new SQLiteParameter("@Specialty", g.Specialty));
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("addGroups", ex.Message, ex.StackTrace);
                return false;
            }
        }

        public static bool updateGroups(Group g)
        {
            try
            {
                using (var query = new SQLiteCommand("UPDATE Group_ SET Number = @Number, Specialty = @Specialty WHERE Id = @Id", connection))
                {
                    connection.Open();
                    query.Parameters.AddWithValue("@Id", g.Id);
                    query.Parameters.AddWithValue("@Number", g.Number);
                    query.Parameters.AddWithValue("@Specialty", g.Specialty);
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("updateGroups", ex.Message, ex.StackTrace);
                return false;
            }
        }

        public static bool deleteGroups(int id)
        {
            try
            {
                connection.Open();
                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = String.Format("DELETE FROM Group_ WHERE Id={0}", id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("deleteGroups", ex.Message, ex.StackTrace);
                return false;
            }
        }
        #endregion

        #region GroupLTypeL
        public static List<GroupLessonTypeLesson> getGroupLTypeL()
        {
            List<GroupLessonTypeLesson> gltl = new List<GroupLessonTypeLesson>();
            try
            {
                using (var query = new SQLiteCommand("SELECT * FROM GroupLessonTypeLesson", connection))
                {
                    connection.Open();
                    SQLiteDataReader reader = query.ExecuteReader();
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
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("addGroupLTypeL", ex.Message, ex.StackTrace);
                return gltl;
            }
        }

        public static bool addGroupLTypeL(GroupLessonTypeLesson g)
        {
            try
            {
                using (var query = new SQLiteCommand("INSERT INTO GroupLessonTypeLesson (Id_Group, Id_LessonTypeLesson) values (@Id_Group, @Id_LessonTypeLesson)", connection))
                {
                    connection.Open();
                    query.Parameters.Add(new SQLiteParameter("@Id_Group", g.Id_Group));
                    query.Parameters.Add(new SQLiteParameter("@Id_LessonTypeLesson", g.Id_LessonTypeLesson));
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("addGroupLTypeL", ex.Message, ex.StackTrace);
                return false;
            }
        }

        //public static bool updateGroupLTypeL(GroupLessonTypeLesson g)
        //{
        //    try
        //    {
        //        using (var query = new SQLiteCommand("UPDATE GroupLessonTypeLesson SET Id_Group = @Id_Group, Id_LessonTypeLesson = @Id_LessonTypeLesson WHERE Id = @Id", connection))
        //        {
        //            connection.Open();
        //            query.Parameters.AddWithValue("@Id", g.Id);
        //            query.Parameters.AddWithValue("@Id_Group", g.Id_Group);
        //            query.Parameters.AddWithValue("@Id_LessonTypeLesson", g.Id_LessonTypeLesson);
        //            query.ExecuteNonQuery();

        //            connection.Close();
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        connection.Close();
        //        ExceptionLogging.logWrite("updateGroupLTypeL", ex.Message, ex.StackTrace);
        //        return false;
        //    }
        //}

        //public static bool deleteGroupLTypeL(int id)
        //{
        //    try
        //    {
        //        connection.Open();
        //        using (SQLiteCommand cmd = connection.CreateCommand())
        //        {
        //            cmd.CommandText = String.Format("DELETE FROM GroupLessonTypeLesson WHERE Id={0}", id);
        //            cmd.ExecuteNonQuery();
        //        }
        //        connection.Close();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        connection.Close();
        //        ExceptionLogging.logWrite("deleteGroupLTypeL", ex.Message, ex.StackTrace);
        //        return false;
        //    }
        //}
        #endregion

        #region Lesson
        public static List<Lesson> getLesson()
        {
            List<Lesson> ll = new List<Lesson>();
            try
            {
                using (var query = new SQLiteCommand("SELECT * FROM Lesson", connection))
                {
                    connection.Open();
                    SQLiteDataReader reader = query.ExecuteReader();
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
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("getLesson", ex.Message, ex.StackTrace);
                return ll;
            }
        }

        public static bool addLesson(Lesson g)
        {
            try
            {
                using (var query = new SQLiteCommand("INSERT INTO Lesson (Name) values (@Name)", connection))
                {
                    connection.Open();

                    query.Parameters.Add(new SQLiteParameter("@Name", g.Name));
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("addLesson", ex.Message, ex.StackTrace);
                return false;
            }
        }

        public static bool updateLesson(Lesson g)
        {
            try
            {
                using (var query = new SQLiteCommand("UPDATE Lesson SET Name = @Name WHERE Id = @Id", connection))
                {
                    connection.Open();
                    query.Parameters.AddWithValue("@Id", g.Id);
                    query.Parameters.AddWithValue("@Name", g.Name);
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("updateLesson", ex.Message, ex.StackTrace);
                return false;
            }
        }

        public static bool deleteLesson(int id)
        {
            try
            {
                connection.Open();
                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = String.Format("DELETE FROM Lesson WHERE Id={0}", id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("deleteLesson", ex.Message, ex.StackTrace);
                return false;
            }
        }

        #endregion

        #region LesTypeLes
        public static List<LessonTypeLesson> getLesTypeLes()
        {
            List<LessonTypeLesson> ltl = new List<LessonTypeLesson>();
            try
            {
                using (var query = new SQLiteCommand("SELECT * FROM LessonTypeLesson", connection))
                {
                    connection.Open();
                    SQLiteDataReader reader = query.ExecuteReader();
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
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("getLesTypeLes", ex.Message, ex.StackTrace);
                return ltl;
            }
        }

        public static bool addTypeLes(LessonTypeLesson g)
        {
            try
            {
                using (var query = new SQLiteCommand("INSERT INTO LessonTypeLesson (Id_Lesson, Id_TypeLesson, Hours) values (@Id_Lesson, @Id_TypeLesson, @Hours)", connection))
                {
                    connection.Open();

                    query.Parameters.Add(new SQLiteParameter("@Number", g.Id_Lesson));
                    query.Parameters.Add(new SQLiteParameter("@Specialty", g.Id_TypeLesson));
                    query.Parameters.Add(new SQLiteParameter("@Specialty", g.Hours));
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("addTypeLes", ex.Message, ex.StackTrace);
                return false;
            }
        }

        public static bool updateTypeLes(LessonTypeLesson g)
        {
            try
            {
                using (var query = new SQLiteCommand("UPDATE LessonTypeLesson SET Id_Lesson = @Id_Lesson, Id_TypeLesson = @Id_TypeLesson, Hours = @Hours WHERE Id = @Id", connection))
                {
                    connection.Open();
                    query.Parameters.AddWithValue("@Id", g.Id);
                    query.Parameters.Add(new SQLiteParameter("@Number", g.Id_Lesson));
                    query.Parameters.Add(new SQLiteParameter("@Specialty", g.Id_TypeLesson));
                    query.Parameters.Add(new SQLiteParameter("@Specialty", g.Hours));
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("updateTypeLes", ex.Message, ex.StackTrace);
                return false;
            }
        }

        public static bool deleteTypeLes(int id)
        {
            try
            {
                connection.Open();
                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = String.Format("DELETE FROM LessonTypeLesson WHERE Id={0}", id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("deleteTypeLes", ex.Message, ex.StackTrace);
                return false;
            }
        }
        #endregion

        #region LTypeLTypeRoom
        public static List<LessonTypeLessonTypeRoom> getLTypeLTypeRoom()
        {
            List<LessonTypeLessonTypeRoom> ltltr = new List<LessonTypeLessonTypeRoom>();
            try
            {
                using (var query = new SQLiteCommand("SELECT * FROM LessonTypeLessonTypeRoom", connection))
                {
                    connection.Open();
                    SQLiteDataReader reader = query.ExecuteReader();

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
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("getLTypeLTypeRoom", ex.Message, ex.StackTrace);
                return ltltr;
            }
        }

        public static bool addLTypeLTypeRoom(LessonTypeLessonTypeRoom g)
        {
            try
            {
                using (var query = new SQLiteCommand("INSERT INTO GroupLessonTypeLesson (Id_LessonTypeLesson, Id_TypeRoom) values (@Id_LessonTypeLesson, @Id_TypeRoom)", connection))
                {
                    connection.Open();
                    query.Parameters.Add(new SQLiteParameter("@Id_LessonTypeLesson", g.Id_LessonTypeLesson));
                    query.Parameters.Add(new SQLiteParameter("@Id_TypeRoom", g.Id_TypeRoom));
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("addLTypeLTypeRoom", ex.Message, ex.StackTrace);
                return false;
            }
        }
        #endregion

        #region Pair
        public static List<Pair> getPair()
        {
            List<Pair> lp = new List<Pair>();
            try {
                using (var query = new SQLiteCommand("SELECT * FROM Pair", connection))
                {
                    connection.Open();
                    SQLiteDataReader reader = query.ExecuteReader();
                   
                    while (reader.Read())
                    {
                        lp.Add(new Pair
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Number = Convert.ToInt32(reader["number"]),
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
            catch(Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("getPair", ex.Message, ex.StackTrace);
                return lp;
            }
        }

        public static bool addPair(Pair g)
        {
            try
            {
                using (var query = new SQLiteCommand("INSERT INTO Pair (number, Id_LessonTypeLesson, Id_Teacher, Id_Room, Id_Group) values (@number, @Id_LessonTypeLesson, @Id_Teacher, @Id_Room, @Id_Group)", connection))
                {
                    connection.Open();

                    query.Parameters.Add(new SQLiteParameter("@number", g.Number));
                    query.Parameters.Add(new SQLiteParameter("@Id_LessonTypeLesson", g.Id_LessonTypeLesson));
                    query.Parameters.Add(new SQLiteParameter("@Id_Teacher", g.Id_Teacher));
                    query.Parameters.Add(new SQLiteParameter("@Id_Room", g.Id_Room));
                    query.Parameters.Add(new SQLiteParameter("@Id_Group", g.Id_Group));
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("addPair", ex.Message, ex.StackTrace);
                return false;
            }
        }

        public static bool updatePair(Pair g)
        {
            try
            {
                using (var query = new SQLiteCommand("UPDATE Group_ SET number = @number, Id_LessonTypeLesson = @Id_LessonTypeLesson, Id_Teacher = @Id_Teacher, Id_Room = @Id_Room, Id_Group = @Id_Group WHERE Id = @Id", connection))
                {
                    connection.Open();
                    query.Parameters.AddWithValue("@Id", g.Id);
                    query.Parameters.Add(new SQLiteParameter("@number", g.Number));
                    query.Parameters.Add(new SQLiteParameter("@Id_LessonTypeLesson", g.Id_LessonTypeLesson));
                    query.Parameters.Add(new SQLiteParameter("@Id_Teacher", g.Id_Teacher));
                    query.Parameters.Add(new SQLiteParameter("@Id_Room", g.Id_Room));
                    query.Parameters.Add(new SQLiteParameter("@Id_Group", g.Id_Group));
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("updatePair", ex.Message, ex.StackTrace);
                return false;
            }
        }

        public static bool deletePair(int id)
        {
            try
            {
                connection.Open();
                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = String.Format("DELETE FROM Pair WHERE Id={0}", id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("deletePair", ex.Message, ex.StackTrace);
                return false;
            }
        }
        #endregion

        #region Room
        public static List<Room> getRoom()
        {
            List<Room> lr = new List<Room>();
            try
            {
                using (var query = new SQLiteCommand("SELECT * FROM Room", connection))
                {
                    connection.Open();
                    SQLiteDataReader reader = query.ExecuteReader();
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
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("getRoom", ex.Message, ex.StackTrace);
                return lr;
            }
        }

        public static bool addRoom(Room g)
        {
            try
            {
                using (var query = new SQLiteCommand("INSERT INTO Room (Number) values (@Number)", connection))
                {
                    connection.Open();

                    query.Parameters.Add(new SQLiteParameter("@Number", g.Number));
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("addRoom", ex.Message, ex.StackTrace);
                return false;
            }
        }

        public static bool updateRoom(Room g)
        {
            try
            {
                using (var query = new SQLiteCommand("UPDATE Group_ SET Number = @Number WHERE Id = @Id", connection))
                {
                    connection.Open();
                    query.Parameters.AddWithValue("@Id", g.Id);
                    query.Parameters.AddWithValue("@Number", g.Number);
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("updateRoom", ex.Message, ex.StackTrace);
                return false;
            }
        }

        public static bool deleteRoom(int id)
        {
            try
            {
                connection.Open();
                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = String.Format("DELETE FROM Room WHERE Id={0}", id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("deleteRoom", ex.Message, ex.StackTrace);
                return false;
            }
        }
        #endregion

        #region RoomTypeRoom
        public static List<RoomTypeRoom> getRoomTypeRoom()
        {
            List<RoomTypeRoom> lrtr = new List<RoomTypeRoom>();
            try {
                using (var query = new SQLiteCommand("SELECT * FROM RoomTypeRoom", connection))
                {
                    connection.Open();
                    SQLiteDataReader reader = query.ExecuteReader();

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
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("getRoomTypeRoom", ex.Message, ex.StackTrace);
                return lrtr;
            }
        }

        public static bool addRoomTypeRoom(RoomTypeRoom g)
        {
            try
            {
                using (var query = new SQLiteCommand("INSERT INTO RoomTypeRoom (Id_Room, Id_TypeRoom) values (@Id_Room, @Id_TypeRoom)", connection))
                {
                    connection.Open();
                    query.Parameters.Add(new SQLiteParameter("@Id_Room", g.Id_Room));
                    query.Parameters.Add(new SQLiteParameter("@Id_TypeRoom", g.Id_TypeRoom));
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("addRoomTypeRoom", ex.Message, ex.StackTrace);
                return false;
            }
        }
        #endregion

        #region Teacher
        public static List<Teacher> getTeacher()
        {
            List<Teacher> lt = new List<Teacher>();
            try {
                using (var query = new SQLiteCommand("SELECT * FROM Teacher", connection))
                {
                    connection.Open();
                    SQLiteDataReader reader = query.ExecuteReader();
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
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("getTeacher", ex.Message, ex.StackTrace);
                return lt;
            }
        }

        public static bool addTeacher(Teacher g)
        {
            try
            {
                using (var query = new SQLiteCommand("INSERT INTO Teacher (Name, Patronomic, Surname, Age) values (@Name, @Patronomic, @Surname, @Age)", connection))
                {
                    connection.Open();

                    query.Parameters.Add(new SQLiteParameter("@Name", g.Name));
                    query.Parameters.Add(new SQLiteParameter("@Patronomic", g.Patronomic));
                    query.Parameters.Add(new SQLiteParameter("@Surname", g.Surname));
                    query.Parameters.Add(new SQLiteParameter("@Age", g.Age));
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("addTeacher", ex.Message, ex.StackTrace);
                return false;
            }
        }

        public static bool updateTeacher(Teacher g)
        {
            try
            {
                using (var query = new SQLiteCommand("UPDATE Teacher SET Name = @Name, Patronomic = @Patronomic, Surname = @Surname, Age = @Age WHERE Id = @Id", connection))
                {
                    connection.Open();
                    query.Parameters.AddWithValue("@Id", g.Id);
                    query.Parameters.Add(new SQLiteParameter("@Name", g.Name));
                    query.Parameters.Add(new SQLiteParameter("@Patronomic", g.Patronomic));
                    query.Parameters.Add(new SQLiteParameter("@Surname", g.Surname));
                    query.Parameters.Add(new SQLiteParameter("@Age", g.Age));
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("updateTeacher", ex.Message, ex.StackTrace);
                return false;
            }
        }

        public static bool deleteTeacher(int id)
        {
            try
            {
                connection.Open();
                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = String.Format("DELETE FROM Teacher WHERE Id={0}", id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("deleteTeacher", ex.Message, ex.StackTrace);
                return false;
            }
        }
        #endregion

        #region TeacherLesson
        public static List<TeacherLesson> getTeacherLesson()
        {
            List<TeacherLesson> ltl = new List<TeacherLesson>();
            try
            {
                using (var query = new SQLiteCommand("SELECT * FROM TeacherLesson", connection))
                {
                    connection.Open();
                    SQLiteDataReader reader = query.ExecuteReader();
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
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("getTeacherLesson", ex.Message, ex.StackTrace);
                return ltl;
            }
        }

        public static bool addTeacherLesson(TeacherLesson g)
        {
            try
            {
                using (var query = new SQLiteCommand("INSERT INTO TeacherLesson (Id_Teacher, Id_Lesson) values (@Id_Teacher, @Id_Lesson)", connection))
                {
                    connection.Open();
                    query.Parameters.Add(new SQLiteParameter("@Id_Teacher", g.Id_Teacher));
                    query.Parameters.Add(new SQLiteParameter("@Id_Lesson", g.Id_Lesson));
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("addTeacherLesson", ex.Message, ex.StackTrace);
                return false;
            }
        }
        #endregion

        #region TypeLesson
        public static List<TypeLesson> getTypeLesson()
        {
            List<TypeLesson> ltl = new List<TypeLesson>();
            try
            {
                using (var query = new SQLiteCommand("SELECT * FROM TypeLesson", connection))
                {
                    connection.Open();
                    SQLiteDataReader reader = query.ExecuteReader();
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
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("getTypeLesson", ex.Message, ex.StackTrace);
                return ltl;
            }
        }

        public static bool addTypeLesson(TypeLesson g)
        {
            try
            {
                using (var query = new SQLiteCommand("INSERT INTO TypeLesson (Name) values (@Name)", connection))
                {
                    connection.Open();

                    query.Parameters.Add(new SQLiteParameter("@Name", g.Name));
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("addTypeLesson", ex.Message, ex.StackTrace);
                return false;
            }
        }

        public static bool updateTypeLesson(TypeLesson g)
        {
            try
            {
                using (var query = new SQLiteCommand("UPDATE TypeLesson SET Name = @Name WHERE Id = @Id", connection))
                {
                    connection.Open();
                    query.Parameters.AddWithValue("@Id", g.Id);
                    query.Parameters.AddWithValue("@Name", g.Name);
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("updateTypeLesson", ex.Message, ex.StackTrace);
                return false;
            }
        }

        public static bool deleteTypeLesson(int id)
        {
            try
            {
                connection.Open();
                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = String.Format("DELETE FROM TypeLesson WHERE Id={0}", id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("deleteTypeLesson", ex.Message, ex.StackTrace);
                return false;
            }
        }

        #endregion

        #region WorkDay
        public static List<WorkDay> getWorkDay()
        {
            List<WorkDay> lwd = new List<WorkDay>();
            try
            {
                using (var query = new SQLiteCommand("SELECT * FROM WorkDay", connection))
                {
                    connection.Open();
                    SQLiteDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        lwd.Add(new WorkDay
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Date = DateTime.ParseExact(reader["Date"].ToString(), "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                        });
                    }
                    connection.Close();
                    return lwd;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("getWorkDay", ex.Message, ex.StackTrace);
                return lwd;
            }
        }

        public static bool addWorkDay(WorkDay g)
        {
            try
            {
                using (var query = new SQLiteCommand("INSERT INTO WorkDay (Date) values (@Date)", connection))
                {
                    connection.Open();

                    query.Parameters.Add(new SQLiteParameter("@Date", g.Date));
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("addWorkDay", ex.Message, ex.StackTrace);
                return false;
            }
        }

        public static bool updateWorkDay(WorkDay g)
        {
            try
            {
                using (var query = new SQLiteCommand("UPDATE WorkDay SET Date = @Date WHERE Id = @Id", connection))
                {
                    connection.Open();
                    query.Parameters.AddWithValue("@Id", g.Id);
                    query.Parameters.AddWithValue("@Date", g.Date);
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("updateWorkDay", ex.Message, ex.StackTrace);
                return false;
            }
        }

        public static bool deleteWorkDay(int id)
        {
            try
            {
                connection.Open();
                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = String.Format("DELETE FROM WorkDay WHERE Id={0}", id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("deleteWorkDay", ex.Message, ex.StackTrace);
                return false;
            }
        }
        #endregion

        #region WorkDayPairs
        public static List<WorkDayPairs> getWorkDayPairs()
        {
            List<WorkDayPairs> lwdp = new List<WorkDayPairs>();
            try
            {
                using (var query = new SQLiteCommand("SELECT * FROM WorkDayPairs", connection))
                {
                    connection.Open();
                    SQLiteDataReader reader = query.ExecuteReader();
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
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("getWorkDayPairs", ex.Message, ex.StackTrace);
                return lwdp;
            }
        }

        public static bool addWorkDayPairs(WorkDayPairs g)
        {
            try
            {
                using (var query = new SQLiteCommand("INSERT INTO WorkDayPairs (Id_WorkDay, Id_Pair) values (@Id_WorkDay, @Id_Pair)", connection))
                {
                    connection.Open();
                    query.Parameters.Add(new SQLiteParameter("@Id_WorkDay", g.Id_WorkDay));
                    query.Parameters.Add(new SQLiteParameter("@Id_Pair", g.Id_Pair));
                    query.ExecuteNonQuery();

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                ExceptionLogging.logWrite("addWorkDayPairs", ex.Message, ex.StackTrace);
                return false;
            }
        }
        #endregion
    }
}

