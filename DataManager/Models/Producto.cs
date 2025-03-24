namespace CRUD_Console.Models
{
  public class Producto 
  {
    public int Id { get; set;}
    public string Nombre { get; set;} = "";
    public decimal Valor { get; set;}
    public int Stock { get; set;}
  }
}
