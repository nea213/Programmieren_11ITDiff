import java.util.List;

public class NetWriter implements IWriter {

    public void write(List<String> text) {
        Datenbank db = new Datenbank();
        for(String s : text) {
            db.write(s);
        }
    }
}
