public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode resultado = new ListNode(0);
        ListNode atual = resultado;
        int carry =0;
        while(l1 != null || l2 != null){
            int valor1 = l1!= null ? l1.val : 0;
            int valor2 = l2!= null ? l2.val : 0;
            int soma = valor1 + valor2 + carry;
            carry = soma/10;
            atual.next = new ListNode(soma % 10);
            atual = atual.next;
            if(l1 != null) l1 = l1.next;
            if(l2 != null) l2 =l2.next;
        }
        if(carry >0){
            atual.next = new ListNode(carry);
        }
        return resultado.next;
    }
}