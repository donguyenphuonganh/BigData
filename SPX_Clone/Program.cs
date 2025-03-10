var builder = WebApplication.CreateBuilder(args);

// Bỏ đăng ký IOrderService và các dịch vụ không cần thiết
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Định nghĩa route mặc định
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Manager}/{action=Index}/{id?}");

app.Run();