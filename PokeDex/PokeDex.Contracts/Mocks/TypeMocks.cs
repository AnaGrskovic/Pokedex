namespace PokeDex.Contracts.Mocks
{
    public static class TypeMocks
    {
        public static IEnumerable<Models.Type> Types => new List<Models.Type>
        {
            new Models.Type(1, "Normal"),
            new Models.Type(2, "Fire"),
            new Models.Type(3, "Water"),
            new Models.Type(4, "Grass"),
            new Models.Type(5, "Electric"),
            new Models.Type(6, "Ice"),
            new Models.Type(7, "Fighting"),
            new Models.Type(8, "Poison"),
            new Models.Type(9, "Ground"),
            new Models.Type(10, "Flying"),
            new Models.Type(11, "Psychic"),
            new Models.Type(12, "Bug"),
            new Models.Type(13, "Rock"),
            new Models.Type(14, "Ghost"),
            new Models.Type(15, "Dark"),
            new Models.Type(16, "Dragon"),
            new Models.Type(17, "Steel"),
            new Models.Type(18, "Fairy"),
        };
    }
}
