import java.io.BufferedReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Base64;
import java.util.List;

public class FileReader implements IReader {
    BufferedReader reader = null;
    private String path;

    public FileReader(String path) {
        this.path = path;
    }

    public List<String> read() {
        List<String> lines = new ArrayList<>();
        try {
            reader = new BufferedReader(new java.io.FileReader(path));
            String line = reader.readLine();
            while(line != null){
                String encryptedLine = Base64.getEncoder().encodeToString(line.getBytes());
                lines.add(encryptedLine);
                line = reader.readLine();
            }
        } catch(IOException e){
            e.printStackTrace();
        }

        return lines;
    }
}
