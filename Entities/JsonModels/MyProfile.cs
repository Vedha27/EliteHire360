namespace Entities.JsonModels
{
    public class MyProfile
    {
        public About? About { get; set; }
        public List<Experience>? Experience { get; set; }
        public List<Education>? Education { get; set; }
        public List<Certification>? Certifications { get; set; }
        public Skills? Skills { get; set; }
        public List<Project>? Projects { get; set; }
    }
}