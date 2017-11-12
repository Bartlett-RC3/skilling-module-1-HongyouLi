//references


//Scope -- Type -- Name

public class Human
{
    public int age;
    public float height;
    public float weight;
    public bool gender = true;
    public string firstName, familyName;
    public bool hungry;
    public float energy;


    //Variable
    //Constructor 
    public Human(int _age, float _height, float _weight, bool _gender, string _firstName, string _familyName)
    {
        age = _age;
        height = _height;
        weight = _weight;
        gender = _gender;
        firstName = _firstName;
        familyName = _familyName;
        hungry = true;
        energy = 100;

    }
    //Functions(Methods)
    public string GetFirstName() {
        return firstName;
    }

    public void DailyLife() {
        Ageing();
        Eating();
        Sleeping();
    }
    private void Ageing(){
        age = age + 1;
        energy = energy + 1;
    }
    private void Eating() {
        hungry = false;
        energy = energy -1;

    }
    private void Sleeping() {
        hungry = true;
        energy = energy + 1;
    }


   
}
