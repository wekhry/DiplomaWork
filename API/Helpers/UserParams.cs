namespace API.Helpers
{
    public class UserParams : PaginationParams
    {
        public string CurrentUsername { get; set; }
        public string Gender { get; set; }
        public int MinAge { get; set; } = 16;
        public int MaxAge { get; set; } = 100;
        public string OrderBy {get; set;} = "lastActive";
    }
}