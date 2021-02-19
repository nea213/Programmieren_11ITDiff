public class Schalter {

    private boolean zustand = false;
    private SchaltServer device;

    public Schalter(SchaltServer device){
        this.device = device;
    }

    public void einschalten(){
        if(!zustand){
            System.out.println("Einschalten");
            device.ein();
            zustand = !zustand;
        }
    }

    public void ausschalten(){
        if(zustand){
            System.out.println("Ausschalten");
            device.aus();
            zustand = !zustand;
        }
    }

}