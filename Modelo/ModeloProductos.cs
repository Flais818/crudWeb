namespace proyectoFinalAPI.Modelo
{
    public class ModeloProductos
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        // Cuando se trabaja con "money" en SQL
        // El equivalente en C# es decimal
        public decimal precio { get; set; }

    }
}
