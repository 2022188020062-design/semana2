var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://localhost:8000");
var app = builder.Build();

app.MapGet("/", () => {
    return new { mensagem= "API em execução..."};
});

/*
app.MapGet("/calcula/{opcao}/{valor1}/{valor2}", (int opcao, int valor1, int valor2)=> {
    int resultado = 0;

            switch(opcao) {
                case 1 :
                   resultado = valor1 + valor2;
                   return Results.Ok(new {
                    operacao = "soma",
                    valor1 = valor1,
                    valor2 = valor2,
                    resultado = resultado
                   });
                    case 2 :
                    resultado = valor1 + valor2;
                   return Results.Ok(new {
                    operacao = "subtraçao",
                    valor1 = valor1,
                    valor2 = valor2,
                    resultado = resultado
                   });
                    case 3 :
                      resultado = valor1 + valor2;
                   return Results.Ok(new {
                    operacao = "subtraçao",
                    valor1 = valor1,
                    valor2 = valor2,
                    resultado = resultado
                   });
                   case 4:
                    resultado = valor1 + valor2;
                   return Results.Ok(new {
                    operacao = "subtraçao",
                    valor1 = valor1,
                    valor2 = valor2,
                    resultado = resultado
                   });
                    default :
                    return new { mensagem= "opção ivalida..."};
                    
                    
            }
});*/

app.MapGet("/calcula/soma/{a}/{b}", (int a, int b) => {
    int result = a + b;

    return Results.Ok(new
            {
                operacao = "soma",
                valor1 = a,
                valor2 = b,
                result= result
            });
});

app.MapGet("/calcula/subtracao/{a}/{b}", (int a, int b) => {
    int result = a - b;

    return Results.Ok(new
            {
                operacao = "subtracao",
                valor1 = a,
                valor2 = b,
                result= result
            });
});

            app.MapGet("/calcula/divisao/{a}/{b}", (int a, int b) => {
    int result = a / b;

    return Results.Ok(new
            {
                operacao = "divisao",
                valor1 = a,
                valor2 = b,
                result= result
            });
});

            app.MapGet("/calcula/multiplicacao/{a}/{b}", (int a, int b) => {
    int result = a * b;

    return Results.Ok(new
            {
                operacao = "mutiplicacao",
                valor1 = a,
                valor2 = b,
                result= result
            });
  });

app.Run();
