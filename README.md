# UsuarioAPI
Como utilizar o IdentityAPI e liberar acesso somente para maiores de 18 anos.

Como utiilzar o Secrets onde irá colocar as suas senhas.

Vá até a pasta raiz do projeto e digite o comando

dotnet user-secrets init

Com isso ele irá gerar uma linha de código no projeto mostrando o id da secret, para encontrar vc precisa abrir o arquivo do Projeto UsuarioAPI.
Esse arquivo irá ficar na sua máquina. Se for windows
c:\Users\SeuUsuario\AppData\Roaming\Microsoft\UserSecrets
Devemos alocar a senha dentro do secret key e o comando está abaixo.

dotnet user-secrets set "Nome da sua chave" "Aqui fica a senha que você deseja esconder"

Quando for um caminho do banco de dados por exemplo irá mudar.

dotnet user-secrets set "ConnectionStrings:NomeDaConexao" "URI da conexão completa"


Como pegar as senhas no dotnet.

builder.Configuration["Nome da sua chave"]
builder.Configuration["ConnectionStrings:NomeDaConexao"];

Dentro das classes precisamos fazer a Inj de Depend
private readonly IConfiguration _configuration;

No construtor

public Classe(IConfiguration configuration)
{
  _configuration = configuration;
}

No local que irá utilizar
_configuration["SymmetricSecurityKey"]
