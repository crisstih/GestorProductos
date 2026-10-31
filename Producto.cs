//mis anotaciones Diaz Cris
// el namespace sirve para organizar el codigo y agrupar las clases del proyecto bajo un mismo nombre
namespace GestorProductos;

// La clase es como el "molde" o plantilla que define las caracteristicas que tendra cada producto
public class Producto
{   // { get y set} son propiedades        automáticas: "get" permite leer el valor y "set" modificarlo
    public int Id {get; set;}
    public string Nombre {get; set;} = string.Empty; //inicializa la variable con texto vacio para evitar errores de valores nulos
    public decimal Precio {get; set;}
    public string Categoria {get; set;} = string.Empty;
    // Estado del producto (tipo bool = booleano: true o false). 
    // True si está disponible para la venta, False si está dado de baja o inactivo.
    public bool Activo {get; set;}
}