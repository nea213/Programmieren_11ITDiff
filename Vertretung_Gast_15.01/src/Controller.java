public class Controller {
    public static void main(String[] args) {
        Led l = new Led();
        Schalter s1 = new Schalter(l);
        s1.einschalten();
        s1.einschalten();
        s1.ausschalten();

        Waschmaschine w = new Waschmaschine();
        Schalter s2 = new Schalter(w);
        s2.einschalten();
        s2.einschalten();
        s2.ausschalten();
    }
}
