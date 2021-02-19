public class Led implements SchaltServer {
    private boolean zustand = false;

    public void ein() {
        if(!zustand){
            System.out.println("LED an");
            zustand = !zustand;
        }
    }

    public void aus() {
        if(zustand){
            System.out.println("LED aus");
            zustand = !zustand;
        }
    }
}
