var builder = WebApplication.CreateBuilder(args);


//services
builder.Services.AddControllersWithViews();



var app = builder.Build();
//pipeline
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();//controller/view/id
});

app.Run();


//Yapýlacaklar
//1-Northwind veritabaný'nýn DbFirst olarak yansýmasýný projeye dahil edin. (Microsoft.EntityFrameworkCore.SqlServer, Microsoft.EntityFrameworkCore.Tools)
//2-Category ve Product için ayrý controller oluþturun.
//3-Anasayfada Kategoriler ve Ürünler listelensin.

//4-CategoryController içerisinde kategori oluþturma action tanýmlayýn.
//5-ProductController içerisinde ürün oluþtuma açtion tanýmlayýn.