namespace CookHub.Shared.Entities
{
    public class RecipeImage
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }

        public string Path { get; set; }
    }
}
