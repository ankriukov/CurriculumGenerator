namespace Curriculum.DBresourse
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pair")]
    public partial class Pair
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pair()
        {
            WorkDay = new HashSet<WorkDay>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int number { get; set; }

        public int Id_Room { get; set; }

        public int Id_LessonTypeLesson { get; set; }

        public int Id_Teacher { get; set; }

        public int Id_Group { get; set; }

        public virtual Group_ Group_ { get; set; }

        public virtual LessonTypeLesson LessonTypeLesson { get; set; }

        public virtual Room Room { get; set; }

        public virtual Teacher Teacher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkDay> WorkDay { get; set; }
    }
}
