namespace ConceptosPOO
{
    public abstract class Employee : IPay
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; } // fecha de contratacion
        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id} - {FirstName} {lastName}, " +
                $"Birth: {BirthDate}, " +
                $"Hiring: {HiringDate}, " +
                $"Is active: {IsActive}";
        }
    }
}