# Zennet - > QuickCarry Project - > "Almacen Api"



## Documentation

[Documentation](https://dotnet.microsoft.com/en-us/apps/aspnet)




## DatabaseConnector
        public string dbip;
        public string dbUser;
        public string dbPassword;
        public string dbDatabaseName;

        public MySqlConnection Connection;
        public MySqlCommand Command;
        public MySqlDataReader Reader;
        - > Se definen los tipos de datos.
        public abstract class DatabaseConnector - > Se declara abstracta para despues heredarla y poder hacer la conexion a la base de datos
    {
        public DatabaseConnector()
        {
            this.dbip = "ip db";
            this.dbUser = "root";
            this.dbPassword = "passwordDB";
            this.dbDatabaseName = "databaseName";

            this.Connection = new MySqlConnection(
                $"server={this.dbip};" +
                $"user={this.dbUser};" +
                $"password={this.dbPassword};" +
                $"database={this.dbDatabaseName};"); - > Se establece la conexion con la base de datos

            this.Connection.Open(); - > Se abre la conexion
            this.Command = new MySqlCommand(); - > con command podremos enviarle querys a la base de datos.
            this.Command.Connection = this.Connection;
    }
}

-----------------------------------------------------
## Models
#ProductModel Class
    IDProduct { get; set; }
    ProductName { get; set; }
    ProductDescription { get; set;}
    ProductWeight { get; set; }
    ProductAmount { get; set; }
#BatchModel Class
    IDBatch { get; set; }
    DateTime DateOfCreation { get; set; } - > Tipo de variable DateTime/FechaHora
    int ProductAmountOnBatch { get; set; }
#AssignProductModel Class
    IDLote { get; set; }
    IDProduct { get; set; }
-----------------------------------------------------
Con estos elementos podremos traer y enviar informacion a la base de datos mediante peticiones http, cada modelo representa una entidad de la base de datos.
-----------------------------------------------------
Seguido de la representacion del modelo de cada clase seguiran los metodos o crud para realizar las inserciones a la base de datos.

metodo Save() - > Almacena los datos recibidos en la base de datos mediante la consulta SQL.

List<classNameModels> getAllProducts() - > Este metodo es el encargado de traer y listar todos los elementos de una tabla en la base de datos mediante la consulta sql select * from x.
-----------------------------------------------------
Metodo edit() - > Editaras una columna seleccionada mediante, usara la query "UPDATE name SET(datos, datos2) WHERE id_name = id"
-----------------------------------------------------
Metodo Delete() - > Sera el encargado de eliminar los datos, usa la consulta "DELETE FROM nameTable WHERE ID= id"
-----------------------------------------------------
## Controller
Se debera heredar la clase "ApiController" para poder crear controladres Api Web y usar abstracciones http.
# 
        [Route("api/v1/productos")] - > se define la ruta donde estara alojado este metodo de tipo "POST"
        public IHttpActionResult Post([FromBody]    ProductModel producto) - > Devuelve un resultado http, usa metodo POST, y mediante el body de la peticion se debe obtener el producto.
        {
            if (!ModelState.IsValid || producto == null)
            {
                return BadRequest("Error en el ingreso de datos");
            } - > Condicion para evaluar que los datos ingresados sigan el modelo de en este caso "ProductModel"
            producto.Save(); - > Se utiliza el metodo mencionado anteriormente, ProductModel metodo Save.
            return Ok($"Producto {producto.ProductName} guardado con exito"); - > Devuelve una respuesta http Ok(200)
        }
-------------------
[Route("api/v1/productos")] - > Definicion de ruta.
        public IHttpActionResult Get() - > resultado http y metodo de tipo "GET"
        {
            ProductModel productos = new ProductModel(); - > Instanciamos la clase ProductModel como productos
            var listaproductos = productos.GetAllProducts(); - > Se declara en listaproductos el metodo productos.GetAllProducts()
            var productosView = listaproductos.Select(everyProduct => new GetProductsView 
            {
                IDProduct = everyProduct.IDProduct,
                ProductName = everyProduct.ProductName,
                ProductWeight = everyProduct.ProductWeight,
                ProductAmount = everyProduct.ProductAmount,
                ProductDescription = everyProduct.ProductDescription
            }
            ).ToList(); - > En esta funcion se utiliza una consulta integrada para instanciar cada dato en la clase "filtro" llamada GetProductsView donde solo traemos id,name,weight,amount,description, al final la convertimos en tipo "lista"

            return Ok(productosView); - > Devolvemos un status Ok(200) con la lista de los productos.
        }
-------------------
[Route("api/v1/productos/{id:int}")] - > En este caso en la ruta se pide un id de tipo entero/int.
        public IHttpActionResult Get(int id) - >Se espera recibir un id de tipo entero
        {
            ProductModel product = new ProductModel();
            var productList = product.GetAllProducts();
            var selectedProduct = productList.FirstOrDefault(p => p.IDProduct == id); - > Expresion lambda que busca en nuestra base de datos el id especificado.

            if (selectedProduct == null)
            {
                return NotFound();
            }
            else
            {
                var productoView = new GetProductsView
                {
                    IDProduct = selectedProduct.IDProduct,
                    ProductName = selectedProduct.ProductName,
                    ProductWeight = selectedProduct.ProductWeight,
                    ProductAmount = selectedProduct.ProductAmount,
                    ProductDescription = selectedProduct.ProductDescription
                }; - > Condicion que evalua si el id especificado existe o si no es valido, de ser valido traera ese item.

                return Ok(productoView); - > status Ok(200) con la lista de los productos.
            }
        }
-------------------
        [Route("api/v1/productos/{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            ProductModel product = new ProductModel();
            var productList = product.GetAllProducts();
            var selectedProduct = productList.FirstOrDefault(everyProduct => everyProduct.IDProduct == id);
            if (selectedProduct == null)
            {
                return NotFound(); - > Devuelve un status http(404)
            }
            else
            {
                selectedProduct.DeleteProduct(); - > Se elimina el producto seleccionado
                return Ok($"Producto con ID {id} eliminado con éxito");
            } - > Condicion que evalua si el id existe o si recibe un id.
        }
-------------------
        [Route("api/v1/productos/{id:int}")]
        public IHttpActionResult Put(int id, [FromBody] ProductModel product)
        {
            if (!ModelState.IsValid || product == null)
            {
                return BadRequest("Error en el ingreso de datos");
            }
            product.IDProduct = id;
            product.Edit(); - Se accede a ese producto con su respectivo id recibido por  el body de la peticion y se editan los datos por peticion de tipo "Put"

            return Ok($"Producto {product.ProductName} editado con éxito");
        }


