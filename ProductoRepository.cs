namespace GestorProductos;

// Usamos ": IProductoRepository" para indicar que esta clase implementa el contrato de la interfaz
public class ProductoRepository : IProductoRepository
{
    // Lista privada en memoria: aca se guardan los productos mientras el programa este ejecutandose.
    // El guion bajo (_productos) es una convencion en C# para identificar variables privadas
    private List<Producto> _productos;

    // CONSTRUCTOR: metodo especial que se ejecuta automaticamente cuando hacemos "new ProductoRepository()".
    public ProductoRepository()
    {
        // Inicializamos la lista con 4 productos de prueba por defecto (seed data)
        _productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Notebook Lenovo", Precio = 750000, Categoria = "Computacion", Activo = true },
            new Producto { Id = 2, Nombre = "Mouse Inalambrico", Precio = 22000, Categoria = "Accesorios", Activo = true },
            new Producto { Id = 3, Nombre = "Teclado Mecanico", Precio = 55000, Categoria = "Accesorios", Activo = true },
            new Producto { Id = 4, Nombre = "Monitor 24 pulgadas", Precio = 190000, Categoria = "Monitores", Activo = false }
        };
    }

    // 1. Agregar: recibe un producto y lo añade a la lista interna usando el metodo .Add()
    public void Agregar(Producto producto)
    {
        _productos.Add(producto);
    }

    // 2. ObtenerTodos: usamos .ToList() de LINQ para devolver una copia de la lista de productos
    public List<Producto> ObtenerTodos()
    {
        return _productos.ToList();
    }

    // 3. ObtenerPorId: usa FirstOrDefault de LINQ
    // Recorre la lista y busca el producto donde "p.Id == id". Si no lo encuentra, devuelve null.
    public Producto? ObtenerPorId(int id)
    {
        return _productos.FirstOrDefault(p => p.Id == id);
    }

    // 4. BuscarPorCategoria: usa Where de LINQ para filtrar.
    // Usamos .ToLower() en ambos lados para que no importe si escriben con mayúscula o minúscula.
    public List<Producto> BuscarPorCategoria(string categoria)
    {
        return _productos
            .Where(p => p.Categoria.ToLower() == categoria.ToLower())
            .ToList();
    }
}