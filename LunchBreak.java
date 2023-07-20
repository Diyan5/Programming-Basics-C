import java.security.interfaces.RSAPrivateCrtKey;
import java.util.Scanner;

public class LunchBreak {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String name = scanner.nextLine();
        int  epizodTime=Integer.parseInt(scanner.nextLine());
        int breakTime=Integer.parseInt(scanner.nextLine());
        double obqd = breakTime/8.0;
        double otdih = breakTime/4.0;
        double sum = breakTime - obqd - otdih;
        if (sum>=epizodTime){System.out.printf("You have enough time to watch "+ name +" and left with "+ Math.round(sum-epizodTime)+" minutes free time.");
        }
        else {
            System.out.printf("You don't have enough time to watch "+ name + ", you need "+ Math.round(epizodTime-sum) + " more minutes.");
        }

    }
}
