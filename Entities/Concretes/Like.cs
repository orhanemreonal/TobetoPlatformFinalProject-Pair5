using Core.Entities;

namespace Entities.Concretes
{
    public class Like : Entity<Guid>
    {
        public Guid CourseId { get; set; }
        public Guid TitleId { get; set; }
        public Course? Course { get; set; }  //async sync ulasıyo mu bakıcaz
        public Title? Title { get; set; }
        public List<StudentLike>? StudentLikes { get; set; }
        public List<AsyncVideo>? AsyncVideos { get; set; }

    }
}