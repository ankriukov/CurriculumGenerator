namespace Curriculum.DBresourse
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBStorage : DbContext
    {
        public DBStorage()
            : base("name=DBStorage")
        {
        }

        public virtual DbSet<Group_> Group_ { get; set; }
        public virtual DbSet<Lesson> Lesson { get; set; }
        public virtual DbSet<LessonTypeLesson> LessonTypeLesson { get; set; }
        public virtual DbSet<Pair> Pair { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<TypeLesson> TypeLesson { get; set; }
        public virtual DbSet<TypeRoom> TypeRoom { get; set; }
        public virtual DbSet<WorkDay> WorkDay { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group_>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Group_>()
                .Property(e => e.Specialty)
                .IsUnicode(false);

            modelBuilder.Entity<Group_>()
                .HasMany(e => e.Pair)
                .WithRequired(e => e.Group_)
                .HasForeignKey(e => e.Id_Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lesson>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Lesson>()
                .HasMany(e => e.LessonTypeLesson)
                .WithRequired(e => e.Lesson)
                .HasForeignKey(e => e.Id_Lesson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lesson>()
                .HasMany(e => e.Teacher)
                .WithMany(e => e.Lesson)
                .Map(m => m.ToTable("TeacherLesson").MapLeftKey("Id_Lesson").MapRightKey("Id_Teacher"));

            modelBuilder.Entity<LessonTypeLesson>()
                .HasMany(e => e.Pair)
                .WithRequired(e => e.LessonTypeLesson)
                .HasForeignKey(e => e.Id_LessonTypeLesson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LessonTypeLesson>()
                .HasMany(e => e.Group_)
                .WithMany(e => e.LessonTypeLesson)
                .Map(m => m.ToTable("GroupLessonTypeLesson").MapLeftKey("Id_LessonTypeLesson").MapRightKey("Id_Group"));

            modelBuilder.Entity<Room>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Pair)
                .WithRequired(e => e.Room)
                .HasForeignKey(e => e.Id_Room)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.TypeRoom)
                .WithMany(e => e.Room)
                .Map(m => m.ToTable("RoomTypeRoom").MapLeftKey("Id_Room").MapRightKey("Id_TypeRoom"));

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Patronomic)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Pair)
                .WithRequired(e => e.Teacher)
                .HasForeignKey(e => e.Id_Teacher)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeLesson>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TypeLesson>()
                .HasMany(e => e.LessonTypeLesson)
                .WithRequired(e => e.TypeLesson)
                .HasForeignKey(e => e.Id_TypeLesson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeRoom>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TypeRoom>()
                .HasMany(e => e.LessonTypeLesson)
                .WithMany(e => e.TypeRoom)
                .Map(m => m.ToTable("LessonTypeLessonTypeRoom").MapLeftKey("Id_TypeRoom").MapRightKey("Id_LessonTypeLesson"));

            modelBuilder.Entity<WorkDay>()
                .HasMany(e => e.Pair)
                .WithMany(e => e.WorkDay)
                .Map(m => m.ToTable("WorkDayPairs").MapLeftKey("Id_WorkDay").MapRightKey("Id_Pair"));
        }
    }
}
