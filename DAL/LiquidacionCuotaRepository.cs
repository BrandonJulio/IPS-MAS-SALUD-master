using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
        
        public class LiquidacionCuotaRepository
        {
        private readonly SqlConnection _connection;

        public LiquidacionCuotaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
            
            public void Guardar(LiquidacionCuotaModeradora liquidacion)
            {
                using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into Ips (NumeroLiquidacion,FechaLiquidacion,Identificacion, TipoAfiliacion, SalarioDevengado,ValorServicioHospitalizacion,
                                                            CuotaModeradoraFinal,CuotaModeradoraReal,Tarifa,AplicaTope)
                                       values (@NumeroLiquidacion,@FechaLiquidacion,@Identificacion, @TipoAfiliacion,@SalarioDevengado,@ValorServicioHospitalizacion,
                                                            @CuotaModeradoraFinal,@CuotaModeradoraReal,@Tarifa,@AplicaTope)";
                command.Parameters.AddWithValue("@NumeroLiquidacion",liquidacion.NumeroLiquidacion);
                command.Parameters.AddWithValue("@FechaLiquidacion", liquidacion.FechaLiquidacion);
                command.Parameters.AddWithValue("@Identificacion", liquidacion.Identificacion);
                command.Parameters.AddWithValue("@TipoAfiliacion", liquidacion.TipoAfiliacion);
                command.Parameters.AddWithValue("@SalarioDevengado", liquidacion.SalarioDevengado);
                command.Parameters.AddWithValue("@ValorServicioHospitalizacion", liquidacion.ValorServicioHospitalizacion);
                command.Parameters.AddWithValue("@CuotaModeradoraFinal", liquidacion.CuotaModeradoraFinal);
                command.Parameters.AddWithValue("@CuotaModeradoraReal",liquidacion.CuotaModeradoraReal);
                command.Parameters.AddWithValue("@Tarifa", liquidacion.Tarifa);
                command.Parameters.AddWithValue("@AplicaTope", liquidacion.AplicaTope);
                var filas = command.ExecuteNonQuery();
                }
                
            }
        }


        //public IList<LiquidacionCuotaModeradora> Consultar()
        //{


        //}
            //public void Eliminar(string identificacion)
            //{
                
                
            //}

            //public void Modificar(LiquidacionCuotaModeradora liquidacion)
            //{
            //}

            //public LiquidacionCuotaModeradora Buscar(string identificacion)
            //{
                
            //}



        //    public IEnumerable<LiquidacionCuotaModeradora> ListarContributivo()
        //    {
        //        //return liquidaciones.Where(p => p.TipoAfiliacion.Equals("Contributivo"));
        //    }
        //    public IEnumerable<LiquidacionCuotaModeradora> ListarSubsidiado()
        //    {
        //        //return liquidaciones.Where(p => p.TipoAfiliacion.Equals("Subsidiado"));
        //    }

        //    public int TotalizarContributivo()
        //    {
        //        return liquidaciones.Where(p => p.TipoAfiliacion.Equals("Contributivo")).Count();
        //    }
        //    public int TotalizarSubsidiado()
        //    {
        //        return liquidaciones.Where(p => p.TipoAfiliacion.Equals("Subsidiado")).Count();
        //    }


        //    public int TotalizarTodos()
        //    {
        //        return liquidaciones.Where(p => p.TipoAfiliacion.Equals("Subsidiado") || p.TipoAfiliacion.Equals("Contributivo")).Count();
        //    }

        //    public double ValorTotalLiquidacion()
        //    {
        //        return liquidaciones.Where(p => p.TipoAfiliacion.Equals("Contributivo") || p.TipoAfiliacion.Equals("Subsidiado") && p.CuotaModeradoraFinal.Equals(p.CuotaModeradoraFinal)).Sum(p => p.CuotaModeradoraFinal);
        //    }



        //    public double ValorTotalLiquidacionContributivo()
        //    {
        //        return liquidaciones.Where(p => p.TipoAfiliacion.Equals("Contributivo") && p.CuotaModeradoraFinal.Equals(p.CuotaModeradoraFinal)).Sum(p => p.CuotaModeradoraFinal);
        //    }

        //    public double ValorTotalLiquidacionSubsidiado()
        //    {
        //        return liquidaciones.Where(p => p.TipoAfiliacion.Equals("Subsidiado") && p.CuotaModeradoraFinal.Equals(p.CuotaModeradoraFinal)).Sum(p => p.CuotaModeradoraFinal);
        //    }

        //}
}