namespace LegoBlazor.Data
{
    public class Theme
    {
        public Theme(ThemeJson j)
        {
            Id = j.Id;
            Name = j.Name;
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public string Uri => $"themes/{Id}";
    }
}