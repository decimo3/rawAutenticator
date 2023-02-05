/*
Padrão de regex para validação de password com lookahead através da leitura do artigo:
https://www.vivaolinux.com.br/artigo/Expressoes-Regulares-Entenda-o-que-sao-Lookahead-e-Lookbehind
*/

namespace Utility;
public static class formValidation
{
  public static bool username(string username)
  {
    var regex = new System.Text.RegularExpressions.Regex(@"[A-z][a-z]{5,15}");
    return regex.Match(username).Success;
  }
  public static bool password(string password)
  {
    string patern = "^"; // ancora de inicio da linha
    // lookahead que seu texto terá uma letra maiúscula
    patern += "(?=.*[A-Z])";
    // lookahead que seu texto terá pelo menos um símbolo
    patern += "(?=.*[!@#$&*])";
    // lookahead que seu texto terá pelo menos um número
    patern += "(?=.*[0-9])";
    // lookahead que seu texto terá uma letras minúsculas
    patern += "(?=.*[a-z])";
    // testa se seu texto tem entre 8 e 40 caracteres
    patern += ".{8,40}";
    patern += "$"; // ancora de final da linha
    var regex = new System.Text.RegularExpressions.Regex(patern);
    return regex.Match(password).Success;
  }
  public static bool isValidadAnswer(string answer)
  {
    var regexValidate = new System.Text.RegularExpressions.Regex("^[yYnNSs]$");
    return regexValidate.Match(answer).Success;
  }
  public static bool isPositiveAnswer(string answer)
  {
    var regexPositive = new System.Text.RegularExpressions.Regex("^[yYSs]$");
    return regexPositive.Match(answer).Success;
  }
}