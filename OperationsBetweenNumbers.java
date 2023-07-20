import java.util.Scanner;

public class OperationsBetweenNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Double num1= Double.parseDouble(scanner.nextLine());
        Double num2= Double.parseDouble(scanner.nextLine());
        char a = scanner.nextLine().charAt(0);
        double b=0;
        switch (a)
        {
            case '+':
                b = num1 + num2;
                if (b%2==0)
                {
                    System.out.printf("%d %s %d = %d - even", num1, a,num2,b);
                }
                else
                {
                    System.out.printf("%d %s %d = %d - odd", num1, a,num2,b);
                }
                break;
            case '-':
                b = num1 - num2;
                if (b%2==0)
                {
                    System.out.printf("%d %s %d = %d - even", num1, a,num2,b);
                }
                else
                {
                    System.out.printf("%d %s %d = %d - odd", num1, a,num2,b);
                }
                break;
            case '*':
                b = num1 * num2;
                if (b%2==0)
                {
                    System.out.printf("%d %s %d = %d - even", num1, a,num2,b);
                }
                else
                {
                    System.out.printf("%d %s %d = %d - odd", num1, a,num2,b);
                }
                break;
            case '/':
                if(num2==0)
                {
                    System.out.printf("Cannot divide %d by zero", num1);
                }
                else
                {
                    b = num1 / num2;
                    System.out.printf("%d %s %d = %.2f", num1, a,num2,b);
                }
                break;
            case'%':
                if(num2==0)
                {
                    System.out.printf("Cannot divide %d by zero", num1);
                }
                else
                {
                    b = num1 % num2;
                    System.out.printf("%d %s %d = %d", num1, a,num2,b);
                }
                break;

        }
    }
}
