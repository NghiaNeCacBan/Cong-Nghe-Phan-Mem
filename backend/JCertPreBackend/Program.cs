// backend/JCertPreBackend/Program.cs
     using Microsoft.EntityFrameworkCore;
     using JCertPreBackend.Data;
     using Microsoft.AspNetCore.Builder;
     using Microsoft.Extensions.DependencyInjection;
     using Microsoft.Extensions.Hosting;
     using Swashbuckle.AspNetCore.Swagger;
     using Swashbuckle.AspNetCore.SwaggerUI;

     var builder = WebApplication.CreateBuilder(args);
     builder.Services.AddControllers();
     builder.Services.AddDbContext<JCertPreContext>(options => options.UseInMemoryDatabase("JCertPreDb"));
     builder.Services.AddCors(options =>
     {
         options.AddPolicy("AllowAll", builder =>
             builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
     });
     builder.Services.AddEndpointsApiExplorer();
     builder.Services.AddSwaggerGen();

     var app = builder.Build();
     if (app.Environment.IsDevelopment())
     {
         app.UseSwagger();
         app.UseSwaggerUI();
     }
     app.UseCors("AllowAll");
     app.UseHttpsRedirection();
     app.UseAuthorization();
     app.MapControllers();
     app.Run();