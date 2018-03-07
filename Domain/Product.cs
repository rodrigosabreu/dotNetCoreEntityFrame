using dotNetCoreEntityFramework.Models;

namespace dotNetCoreEntityFramework.Domain
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        

    }
}