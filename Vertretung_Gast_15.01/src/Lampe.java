public class Lampe implements SchaltServer {
    boolean zustand = false;

    public void ein(){
        if(!zustand){
            System.out.println("Lampe an");
            zustand = !zustand;
        }
    }

    public void aus(){
        if(zustand){
            System.out.println("Lampe aus");
            zustand = !zustand;
        }
    }
}
