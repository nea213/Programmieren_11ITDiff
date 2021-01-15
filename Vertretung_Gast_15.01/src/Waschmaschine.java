public class Waschmaschine implements SchaltServer {
    private boolean zustand = false;

    public void ein() {
        if(!zustand){
            System.out.println("Waschmaschine an");
            zustand = !zustand;
        }
    }

    public void aus() {
        if(zustand){
            System.out.println("Waschmaschine aus");
            zustand = !zustand;
        }
    }
}
