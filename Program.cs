using GestorProductos;

// 1. Instanciamos el repositorio a través de la interfaz (Polimorfismo / POO)
IProductoRepository repo = new ProductoRepository();

Console.WriteLine("=== PRACTICO BLOQUE 1: GESTOR DE PRODUCTOS ===\n");

// -------------------------------------------------------------
// PRUEBA 1: Mostrar la lista completa inicial (Seed Data)
// -------------------------------------------------------------
Console.WriteLine("--- 1. Lista completa de productos iniciales ---");
List<Producto> listaInicial = repo.ObtenerTodos();
foreach (var p in listaInicial)
{
    Console.WriteLine($"ID: {p.Id} | Nombre: {p.Nombre} | Precio: ${p.Precio} | Categoria: {p.Categoria} | Activo: {p.Activo}");
}

// -------------------------------------------------------------
// PRUEBA 2: Agregar un nuevo producto al catálogo
// -------------------------------------------------------------
Console.WriteLine("\n--- 2. Agregar un nuevo producto ---");
Producto nuevoProducto = new Producto
{
    Id = 5,
    Nombre = "Auriculares Gamer",
    Precio = 48000,
    Categoria = "Accesorios",
    Activo = true
};

// Llamamos al método Agregar del repositorio
repo.Agregar(nuevoProducto);
Console.WriteLine($"Producto agregado correctamente: {nuevoProducto.Nombre}");

// Mostramos la lista para confirmar que ahora son 5 productos
Console.WriteLine("\nCatalogo actualizado con el nuevo producto:");
foreach (var p in repo.ObtenerTodos())
{
    Console.WriteLine($"ID: {p.Id} | Nombre: {p.Nombre} | Categoria: {p.Categoria} | Precio: ${p.Precio}");
}

// -------------------------------------------------------------
// PRUEBA 3: Buscar un producto por su ID
// -------------------------------------------------------------
Console.WriteLine("\n--- 3. Buscar producto por ID ---");
int idABuscar = 2;
Producto? encontrado = repo.ObtenerPorId(idABuscar);

// Validamos si lo encontró o si vino null
if (encontrado != null)
{
    Console.WriteLine($"Encontrado -> ID: {encontrado.Id}, Nombre: {encontrado.Nombre}, Precio: ${encontrado.Precio}");
}
else
{
    Console.WriteLine($"No existe ningun producto con el ID {idABuscar}");
}

// -------------------------------------------------------------
// PRUEBA 4: Filtrar productos por categoría
// -------------------------------------------------------------
Console.WriteLine("\n--- 4. Filtrar productos por categoria ---");
string categoriaFiltro = "Accesorios";
Console.WriteLine($"Productos encontrados en la categoria '{categoriaFiltro}':");

List<Producto> productosFiltrados = repo.BuscarPorCategoria(categoriaFiltro);
foreach (var p in productosFiltrados)
{
    Console.WriteLine($"- {p.Nombre} (${p.Precio})");
}

Console.WriteLine("\nPruebas finalizadas con exito.");