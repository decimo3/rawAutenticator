Aplicação para prática de aplicação com persistência de dados em banco de dados

* Caso o usuário já tenha logado anteriormente, o programa deverá encontrar o token em _~/.config/rawAutenticator_ para usuários Linux ou _%USERPROFILE%/AppData/Local/rawAutenticator_ para usuários Windows. Se o token for válido, deve realizar o login automágicamente;
* Caso o usuário não tenha logado anteriormente, ele deverá escolher entre login e cadastro;
  * Ao escolher cadastro, ele deverá escrever um nome de usuário válido e único e uma senha forte. Ao final de um cadastro bem sucedido, o usuário será direcionado para o login;
  * Caso o usuário escolha logar, ele deverá escrever um nome de usuário existente e a senha correta. Ao fazer um login com sucesso, será gerado um token que será gravado no arquivo ~/.config/rawAutenticator para usuários Linux ou _%USERPROFILE%/AppData/Local/rawAutenticator_ para usuários Windows;
