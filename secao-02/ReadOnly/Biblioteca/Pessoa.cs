namespace ReadOnly.Biblioteca
{
    public class Pessoa
    {
        public readonly float Pi = 3.14f;

        private string _Name;

        public string Name {
            get => this._Name.ToUpper();
            set => this._Name = value;
        }
    }
}
