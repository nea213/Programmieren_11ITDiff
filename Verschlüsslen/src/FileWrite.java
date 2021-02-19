import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.util.List;

public class FileWrite implements IWriter{
    BufferedWriter writer = null;
    private String path;

    public FileWrite(String path) {
        this.path = path;
    }

    public void write(List<String> text) {
        try {
            writer = new BufferedWriter(new FileWriter(path));
            for(String t: text){
                writer.append(t);
            }
            writer.close();
        } catch(IOException e){
            e.printStackTrace();
        }
    }
}
