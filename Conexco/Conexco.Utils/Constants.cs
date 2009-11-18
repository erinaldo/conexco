using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conexco.Utils
{
    public class Constants
    {
        public const string ERROR_ACTUALIZAR_STOCK = "Se ha producido un error al intenta actualizar el stock. Inténtelo nuevamente.";
        public const string ERROR_ALTA_ARTICULO = "Se ha producido un error al intenta guardar el articulo. Inténtelo nuevamente.";
        public const string ERROR_EGRESO_STOCK = "Se ha producido un error al intenta realizar el egreso de el/los articulo/s. Inténtelo nuevamente.";

        public const string ERROR_STOCK_INSUFICIENTE = "La cantidad de stock actual es menor a la cantidad que intenta egresar.";

        public const string OK_ACTUALIZAR_STOCK = "El stock se ha actualizado correctamente.";
        public const string OK_ALTA_ARTICULO = "El articulo se ha guardado correctamente.";
        public const string OK_EGRESO_STOCK = "El egreso de articulos se ha realizado correctamente.";
    }
}
