namespace proyectoFinalAPI.Conexion
{
    public class ConexionBD
    {
        private string connectionString = string.Empty;
        public ConexionBD()
        {
            var constructor = new ConfigurationBuilder().SetBasePath
            (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            // Se accede al archivo de configuracion para extraer el valor de la conexion 
            connectionString = constructor.GetSection("ConnectionStrings:conexionMaestra").Value; 
        }
        // Se consume la conexion
        public string cadenaSQL()
        {
            return connectionString;
        }
    }
}
