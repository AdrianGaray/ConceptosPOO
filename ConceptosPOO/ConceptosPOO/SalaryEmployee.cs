namespace ConceptosPOO
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            /*
            return $"{base.ToString()}" +
                $"\n\tValue to pay: {GetValueToPay()}"; 
            */
            //Imprime=  1815453,45
            
            return $"{base.ToString()}" +
                $"\n\tValue to pay.........: {$"{GetValueToPay():C2}",18}";
            // C2 = Corrency con 2 decimales
            // {GetValueToPay():C2}",18}, significa que ocupe en 18 caracteres y se alinea a la derecha
            // Imprime= Value to pay.........:     $ 1.815.453,45

        }
    }
}
