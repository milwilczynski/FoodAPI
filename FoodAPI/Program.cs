using FoodAPI.Bootstrappers;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddServices();
    builder.Services.AddRepositories();
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    //app.UseAuthorization();
    app.MapControllers();
#if DEBUG
    app.UseSwagger();
    app.UseSwaggerUI();
#endif
    app.Run();
}