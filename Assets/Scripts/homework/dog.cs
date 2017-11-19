using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dog  {
    public int age;
    public float weight;
    public bool gender;
    public string name;
    public bool hungry;
    public float energy;
    public string color;
    // Use this for initialization

    public dog(int _age, float _weight, bool _gender, string _name, bool _hungery, float _energy, string _color)
    {
        age = _age;
        weight = _weight;
        gender = true;
        name = _name;
        hungry = true;
        energy = 100;
        color = _color;

    }
    //Functions(Methods)
    public int GetDogAge()
    {
        return age;
    }
    public float GetDogWeight()
    {
        return weight;
    }
 
    public string GetDogName()
    {
        return name;
    }
    public string GetDogColor()
    {
        return color;
    }


    public void DailyLife()
    {
        Ageing();
        Eating();
        Sleeping();
        Playing();
    }
    private void Ageing()
    {
        age = age + 1;
        energy = energy -1;
    }
    private void Eating()
    {
        hungry = false;
        energy = energy +1;

    }
    private void Sleeping()
    {
        hungry = true;
        energy = energy + 1;
    }
    private void Playing()
    {
        hungry = true;
        energy = energy -1;
    }

}
