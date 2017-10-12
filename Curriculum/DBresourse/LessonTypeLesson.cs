namespace Curriculum.DBresourse
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LessonTypeLesson")]
    public partial class LessonTypeLesson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LessonTypeLesson()
        {
            Pair = new HashSet<Pair>();
            Group_ = new HashSet<Group_>();
            TypeRoom = new HashSet<TypeRoom>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int Hours { get; set; }

        public int Id_TypeLesson { get; set; }

        public int Id_Lesson { get; set; }

        public virtual Lesson Lesson { get; set; }

        public virtual TypeLesson TypeLesson { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pair> Pair { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group_> Group_ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TypeRoom> TypeRoom { get; set; }
    }
}
