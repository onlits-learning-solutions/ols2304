package cindepth;

import java.util.Scanner;

public class TestFirstBit {
    public static void main(String[] args) {
        int mask = 0x1;
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter a number: ");
        int n = scanner.nextInt();
        if ((n & mask) == 0)
            System.out.println("The first bit is 0.");
        else
            System.out.println("The first bit is 1.");
        scanner.close();
    }
}