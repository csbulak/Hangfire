// Hangfire ve hizmetlerle ilgili ad uzaylarını dahil edin
using Hangfire;
using HangfireWithDotnet.Services;

// Web uygulamasını oluştur
var builder = WebApplication.CreateBuilder(args);

// Kontrolörleri servislere ekleyin
builder.Services.AddControllers();

// Swagger / OpenAPI yapılandırmasını servislere ekleyin
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Hangfire hizmetini ve SQL Server depolamasını yapılandırın
builder.Services.AddHangfire(x => { x.UseSqlServerStorage(builder.Configuration.GetConnectionString("DBConnection")); });

// IJobTestService arayüzünün JobTestService ile eşleşmesi için Services koleksiyonuna bir kapsamı hizmet ekleyin
builder.Services.AddScoped<IJobTestService, JobTestService>();

// Hangfire sunucusunu yapılandırın
builder.Services.AddHangfireServer();

// Uygulamayı oluştur
var app = builder.Build();

// HTTP istek boru hattını yapılandırın
if (app.Environment.IsDevelopment())
{
    // Eğer uygulama geliştirme ortamında çalışıyorsa, Swagger UI'ı kullan
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Hangfire dashboard'ını kullan
app.UseHangfireDashboard();

// HTTPS yönlendirmesini kullan
app.UseHttpsRedirection();

// Authorization middleware'ini kullan
app.UseAuthorization();

// Kontroller için endpoint'leri ilet
app.MapControllers();

// Uygulamayı çalıştır
app.Run();