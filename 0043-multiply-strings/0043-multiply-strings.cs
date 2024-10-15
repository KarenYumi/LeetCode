public class Solution {
    public string Multiply(string num1, string num2) {
        BigInteger i = BigInteger.Parse(num1); //usado BigInteger por conta de sua capacidade de 64 bits enquanto int é de 32bits;
        BigInteger j = BigInteger.Parse(num2);
        BigInteger resultado = i*j;
        return resultado.ToString();
    }
}