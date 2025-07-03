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


//Yap�lacaklar
//1-Northwind veritaban�'n�n DbFirst olarak yans�mas�n� projeye dahil edin. (Microsoft.EntityFrameworkCore.SqlServer, Microsoft.EntityFrameworkCore.Tools)
//2-Category ve Product i�in ayr� controller olu�turun.
//3-Anasayfada Kategoriler ve �r�nler listelensin.

//4-CategoryController i�erisinde kategori olu�turma action tan�mlay�n.
//5-ProductController i�erisinde �r�n olu�tuma a�tion tan�mlay�n.