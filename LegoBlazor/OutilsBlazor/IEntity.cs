namespace OutilsBlazor
{
    public interface IEntity
    {
        string Nom { get; set; }

        void Insert();
        void Update();
        void Delete();
    }
}