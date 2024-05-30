public class dataTypes {
    public static void main(String[] args) {
        // Number
        int nInt = 1234567890;
        long nLong = 123456789012345L;

        double nDouble = 3.141516;
        float nFloat = 3.141516F;

        // Text
        char letter = 'A';
        String word = "Word";

        // Bool
        boolean isLogged = true;
        boolean isFalse = false;

        // Var
        var nIntVar = 1234567890;
        var wordVar = "Word";
        var isTrueVar = true;

        var salary = 1000;
        var pension = salary * 0.03;
        var totalSalary = salary - pension;

        System.out.println(salary);
        System.out.println(pension);
        System.out.println(totalSalary);

        var employeeName = "Fonzi";

        System.out.println("Employee: " + employeeName + " Salary: " + totalSalary);
    }
}
