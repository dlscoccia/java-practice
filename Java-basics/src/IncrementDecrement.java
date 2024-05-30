public class IncrementDecrement {
    public static void main(String[] args) {

        int lives = 5;
        lives = lives - 1;
        System.out.println(lives); //4

        lives--; // Decrement
        System.out.println(lives); //3

        lives++; // Increment
        System.out.println(lives); //4


        //Prefix
        // Increment + 1
        int gift = 100 + ++lives; //prefijo
        System.out.println(gift);
        System.out.println(lives); //5


    }
}