import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("請輸入你的暱稱");

        String name=scanner.next();

        System.out.println("-----------------------");
        System.out.println("嗨，"+name+"!");
        System.out.println("恭喜!你的Git和Java環境(包含輸入功能)全部設定成功!");

        scanner.close();
    }
}