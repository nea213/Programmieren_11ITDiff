import java.util.HashMap;

public class Datenbank {

    private static HashMap<Integer, String> data = new HashMap<>();
    private static int counter = 0;

	public int write(String input) {
        counter++;
        data.put(counter, input);
        System.out.println("ID: " + counter + " MSG: " + input);
        return counter;
	}
    
}
