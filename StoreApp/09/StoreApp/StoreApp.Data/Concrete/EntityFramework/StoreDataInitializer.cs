using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Data.Concrete.EntityFramework
{
    public class StoreDataInitializer : DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            new List<Category>()
            {
                new Category() {  Name="Telefon"},
                new Category() {  Name="Bilgisayar"},
                new Category() {  Name="Tablet"},
                new Category() {  Name="Kitap"},
                new Category() {  Name="Eğitim"}
            }.ForEach(i => context.Categories.Add(i));

            context.SaveChanges();

            new List<Product>
            {
                new Product() { Name="Samsung S5", Description="idare eder", Price=800, CategoryId=1},
                new Product() { Name="Samsung S6", Description="idare eder", Price=1000, CategoryId=1},
                new Product() { Name="Samsung S5", Description="idare eder", Price=800, CategoryId=1},
                new Product() { Name="Samsung S5", Description="idare eder", Price=800, CategoryId=1},
                new Product() { Name="IPhone 5", Description="idare eder", Price=800, CategoryId=1},
                new Product() { Name="IPhone 6", Description="idare eder", Price=800, CategoryId=1},
                new Product() { Name="IPhone 7", Description="güzel", Price=3500, CategoryId=2},
                new Product() { Name="IPhone 6S", Description="daha iyi", Price=100, CategoryId=2},
                new Product() { Name="Samsung S5", Description="idare eder", Price=800, CategoryId=2},
                new Product() { Name="Samsung S5", Description="idare eder", Price=800, CategoryId=2},
                new Product() { Name="Samsung S5", Description="idare eder", Price=800, CategoryId=2},
                new Product() { Name="Samsung S5", Description="idare eder", Price=800, CategoryId=1},
                new Product() { Name="Web Api Eğitimi : Single Page Application", Description="süper :)", Price=1000, CategoryId=5},
                new Product() { Name="Web Api Eğitimi : Single Page Application", Description="süper :)", Price=500, CategoryId=5},
                new Product() { Name="Samsung S5", Description="idare eder", Price=800, CategoryId=4},
                new Product() { Name="IPhone 5", Description="idare eder", Price=800, CategoryId=4},
                new Product() { Name="IPhone 6", Description="idare eder", Price=800, CategoryId=4},
                new Product() { Name="Web Api Eğitimi : Single Page Application", Description="süper :)", Price=800, CategoryId=5},
                new Product() { Name="Web Api Eğitimi : Single Page Application", Description="süper :)", Price=200, CategoryId=5},
                new Product() { Name="Samsung S5", Description="idare eder", Price=800, CategoryId=3},
                new Product() { Name="Samsung S5", Description="idare eder", Price=800, CategoryId=3},
                new Product() { Name="Samsung S5", Description="idare eder", Price=800, CategoryId=3}
            }.ForEach(i => context.Products.Add(i));

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
