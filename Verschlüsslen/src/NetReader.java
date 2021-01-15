import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.URL;
import java.util.ArrayList;
import java.util.Base64;
import java.util.List;

public class NetReader implements IReader {

    private String path;

    public NetReader(String path) {
        this.path = path;
    }

    public List<String> read() {
        List<String> text = new ArrayList<>();
        try{
            URL url = new URL(path);
            InputStream stream = url.openStream();
            InputStreamReader reader = new InputStreamReader(stream);
            StringBuilder sb = new StringBuilder();
            int c = reader.read();
            while(c != -1){
                sb.append((char)c);
                System.out.println((char)c);
                c = reader.read();
            }
            String msg = sb.toString();
            String encryptedMsg = Base64.getEncoder().encodeToString(msg.getBytes());
        }catch(Exception e){
            e.printStackTrace();
        }
        return text;
    }
}
