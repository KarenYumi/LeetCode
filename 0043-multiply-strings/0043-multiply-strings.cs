public class Solution {
    public string Multiply(string num1, string num2) {
        BigInteger i = BigInteger.Parse(num1);
        BigInteger j = BigInteger.Parse(num2);
        BigInteger resultado = i*j;
        return resultado.ToString();
    }
}