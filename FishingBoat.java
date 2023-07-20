import java.util.Scanner;

public class FishingBoat {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int budget = Integer.parseInt(scanner.nextLine());
        String season = scanner.nextLine();
        int fisherman = Integer.parseInt(scanner.nextLine());
        double rent =0;
        switch (season)
        {
            case"Spring":
                rent = 3000;
                if(fisherman<=6)
                {
                    rent -= rent*0.1;
                }
                else if(fisherman>6 &&fisherman<=11)
                {
                    rent -= rent*0.15;
                }
                else if(fisherman>12)
                {
                    rent -= rent*0.25;
                }
                else if(fisherman %2==0)
                {
                    rent-= rent*0.05;
                }
                break;
            case"Summer":
                rent = 4200;
                if(fisherman<=6)
                {
                    rent -= rent*0.1;
                }
                else if(fisherman>6 &&fisherman<=11)
                {
                    rent -= rent*0.15;
                }
                else if(fisherman>12)
                {
                    rent -= rent*0.25;
                }
                else if(fisherman %2==0)
                {
                    rent-= rent*0.05;
                }
                break;
            case"Autumn":
                rent=4200;
                if(fisherman<=6)
                {
                    rent -= rent*0.1;
                }
                else if(fisherman>6 &&fisherman<=11)
                {
                    rent -= rent*0.15;
                }
                else if(fisherman>12)
                {
                    rent -= rent*0.25;
                }
                break;
            case"Winter":
                rent = 2600;
                if(fisherman<=6)
                {
                    rent -= rent*0.1;
                }
                else if(fisherman>6 &&fisherman<=11)
                {
                    rent -= rent*0.15;
                }
                else if(fisherman>12)
                {
                    rent -= rent*0.25;
                }
                else if(fisherman %2==0)
                {
                    rent-= rent*0.05;
                }
                break;
        }
        double diff=Math.abs(budget-rent);
        if(budget>=rent)
        {
            System.out.printf("Yes! You have %.2f leva left." , diff);
        }
        else
        {
            System.out.printf("Not enough money! You need %.2f leva." , diff);
        }
    }
}
