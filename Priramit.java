class Priramit{
    public static void main(String[] args) {
        // We want 4 lines in total
        for (int i = 1; i <= 4; i++) {
            // Print characters in each line
            for (int j = 1; j <= i + 1; j++) {
                // First and last character should be '1'
                if (j == 1 || j == i + 1) {
                    System.out.print("1");
                } else {
                    System.out.print("0");
                }
            }
            System.out.println(); // move to next line
        }
    }
}
