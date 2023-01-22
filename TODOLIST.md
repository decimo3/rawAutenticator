# Fluxograma do programa

1. **Program.cs:** programa é iniciado e é carregado o utilitário _DotNetLoadDotEnv.cs_;
2. **DotNetLoadDotEnv.cs:** A classe carrega as variáveis de ambiente presentes no arquivo _.env_;
3. **Program.cs:** a classe estática _accountManager.cs_ é invocada;
4. **accountManager.cs:** a classe estática _localManager.cs_ é invocada em um bloco try-catch;
5. **localManager.cs:** irá verificar a existência do token, se existir, irá invocar _TokenManager.cs_;
6. **TokenManager.cs:** receberá o token e irá desserializar se for válido e irá retornar para _localManager.cs_;
7. **localManager.cs:** ele irá returnar o token, se não existir, irá lançar um erro;
8. **accountManager.cs:** verifica se o token é valido, e recupera as informações do usuário no banco de dados com a classe _userDAO.cs_;
9. **userDAO.cs:** recupera os dados do usuário no banco de dados e retorna o objeto User para _accountManager.cs_;
10. **wellcome.cs:** exibe as mensagens e procedimentos para login ou cadastro e retorna o objeto User para _accountManager.cs_;
11. **accountManager.cs:** após a autenticação, retorna para _Program.cs_;
