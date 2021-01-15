import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.URL;
import java.util.ArrayList;
import java.util.Base64;
import java.util.List;

public class VerschluesselungsModule {

    IReader reader;
    IWriter writer;

    public VerschluesselungsModule(IReader r, IWriter w) {
        this.writer = w;
        this.reader = r;
    }

    public void encrypt() {
        List<String> text = reader.read();
        List<String> encrypt = new ArrayList<>();

        for (String s: text) {
            encrypt.add(Base64.getEncoder().encodeToString(s.getBytes()));
        }
        writer.write(encrypt);
    }
}
