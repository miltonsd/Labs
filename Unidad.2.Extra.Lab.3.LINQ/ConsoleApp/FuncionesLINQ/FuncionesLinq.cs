using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncionesLINQ
{
    public class FuncionesLinq
    {
        public IEnumerable<string> ObtenerProvinciasQueEmpiezanConDeterminadasLetras(IEnumerable<string> provincias)
        {
            var provinciasQueEmpiezanCon = from provincia in provincias
                                           where provincia.StartsWith('S') || provincia.StartsWith('T')
                                           select provincia;
            return provinciasQueEmpiezanCon;                        
        }

        public IEnumerable<int> ObtenerNumerosMayoresA20(IEnumerable<int> numeros)
        {
            var numerosMayores = from numero in numeros
                                 where numero > 20
                                 select numero;
            return numerosMayores;
        }

        public IEnumerable<int> ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminados(IEnumerable<Ciudad> ciudades, string ciudad)
        {
            var codigosPostales = from city in ciudades
                                  where city.Nombre.ToLower().Contains(ciudad)
                                  select city.CodigoPostal;
            return codigosPostales;
        }

        public IEnumerable<Empleado> AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldo(IEnumerable<Empleado> empleados, IEnumerable<Empleado> empleadosParaAgregar, string order)
        {
            var empleadosCombinados = (from empleado in empleados
                                       select empleado)
                                       .Concat(from empleadoAgregado in empleadosParaAgregar
                                               select empleadoAgregado);

            if (order == "ASC")
        	{
                var listaEmpleados = from empleado in empleadosCombinados
                                     orderby empleado.Sueldo ascending
                                     select empleado;
                return listaEmpleados;
            }
            else
	        {
                var listaEmpleados = from empleado in empleadosCombinados
                                     orderby empleado.Sueldo descending
                                     select empleado;
                return listaEmpleados;
            }
        }
    }
}
