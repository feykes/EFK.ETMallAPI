using EFK.ETMall.Infrastructure.Filters;
using EFK.ETMallAPI.Application.Validators.Products;
using EFK.ETMallAPI.Persistance;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistenceService();

builder.Services.AddCors(options=>options.AddDefaultPolicy(policy=>
policy.WithOrigins("http://localhost:4200", "https://localhost:4200").AllowAnyHeader().AllowAnyMethod()
));

builder.Services.AddControllers(options=>options.Filters.Add<ValidationFilter>())
    .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<CreateProductValidator>()) //Her validator eklendi�inde bunu yazmaya gerek yok bir tanesinden hepsini g�rebiliyor.
    .ConfigureApiBehaviorOptions(options=>options.SuppressModelStateInvalidFilter=true); 

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
