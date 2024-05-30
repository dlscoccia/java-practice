public class Functions {
    public static void main(String[] args) {
        double radio = 3;

        // Circle Area
        //pi * r2
        System.out.println(circleArea(radio));

        // Sphere Area
        //4*PI*r2
        System.out.println(spehereArea(radio));

        // Sphere Volume
        //(4/3)*pi * r3
        System.out.println(spehereVolume(radio));

        System.out.println(convertToDollar(200, "MXN"));
        System.out.println(convertToDollar(20000, "COP"));
    }

    public static double circleArea(double radio) {
        return Math.PI * Math.pow(radio,2);
    }

    public static double spehereArea(double radio) {
        return 4 * Math.PI * Math.pow(radio,2);
    }

    public static double spehereVolume(double radio) {
        return (4/3) * Math.PI * Math.pow(radio,3);
    }

    /**
     * Description: Function that converts multiple currencies to USD Dollars
     * @param qty: Amount to convert
     * @param currency: Type of currency (MXN or COP)
     * @return Amount in USD Dollars
     */
    public static double convertToDollar(double qty, String currency) {
        switch (currency) {
            case "MXN":
                qty *= 0.052;
                break;
            case "COP":
                qty *= 0.00031;
                break;

        }
        return qty;
    }
}
