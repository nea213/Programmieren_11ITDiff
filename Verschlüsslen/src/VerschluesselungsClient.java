public class VerschluesselungsClient {
    
    public static void main(String[] args) {
        FileReader fileReader = new FileReader("input.txt");
        FileWrite fileWrite = new FileWrite("output.txt");

        NetReader netReader = new NetReader("https://pastebin.com/raw/gJ2pgz2D");
        NetWriter netWriter = new NetWriter();

        VerschluesselungsModule fileEncrypt = new VerschluesselungsModule(fileReader, fileWrite);
        fileEncrypt.encrypt();

        VerschluesselungsModule netEncrypt = new VerschluesselungsModule(netReader, netWriter);
        netEncrypt.encrypt();
    }
}
