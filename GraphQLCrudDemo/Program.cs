

using GraphQLCrudDemo.Data;
using GraphQLCrudDemo.GraphQL;
using GraphQLCrudDemo.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetValue<string>("ConnectionStrings:DefaultConnection")));
//Add services to the container.
builder.Services.AddScoped<EmployeeRepository>();
//GraphQL Config
builder.Services.AddGraphQLServer()
    .AddQueryType<EmployeeQueryTypes>()
    .AddMutationType<EmployeeMutations>();

var app = builder.Build();

app.MapGraphQL(path: "/graphql");
app.UseHttpsRedirection();
app.Run();