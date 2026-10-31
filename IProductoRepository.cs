namespace GestorProductos;
// La interfaz define un contrato que debe cumplir cualquier clase que la implemente
// está OBLIGADA a tener todos los métodos que definimos aca

public interface IProductoRepository
{
    // "void" significa que el método no devuelve ningún valor
    //Recibe como parametro el objeto producto que queremoos guardar
    void Agregar(Producto producto);

    // Devuelve una lista ("List<Producto>") de productos guardados
    List<Producto> ObtenerTodos();

    // Devuelve un producto específico según su Id
    // El signo de interrogación "?" indica que el método puede devolver un valor nulo si no encuentra el producto
    Producto? ObtenerPorId(int id);

    // Devuelve una lista de productos que pertenecen a una categoría indicada por texto
    List<Producto> BuscarPorCategoria(string categoria);
}