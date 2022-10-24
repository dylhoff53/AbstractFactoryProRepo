using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public int NumberOfWheels;
    public bool Engine;
    public int Passengers;
    public bool Cargo;
    public Text outcomeText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Go()
    {
        // validate our data
        NumberOfWheels = Mathf.Max(NumberOfWheels, 1);
        Passengers = Mathf.Max(Passengers, 1);
        Engine = Cargo;

        VehicleRequirements requirements = new VehicleRequirements();
        requirements.NumberOfWheels = NumberOfWheels;
        requirements.Engine = Engine;
        requirements.Passengers = Passengers;

        //IVehicle v = new Unicycle();
        IVehicle v = GetVehicle(requirements);
        Debug.Log(v);
    }
    private static IVehicle GetVehicle(VehicleRequirements requirements)
    {
        // based on requirements.Engine
        // choose a motorvehicle factory or a cycle factory
        // call create on the factory to get an appropriate vehicle
        // and return it

        //VehicleFactory factory = new VehicleFactory();

        //if (requirements.Engine)
        //{
        //    return factory.MotorVehicleFactory().Create(requirements);
        //}

        //return factory.CycleFactory().Create(requirements);

        VehicleFactory factory = new VehicleFactory(requirements);
        return factory.Create();
    }

    public void MakeOneWheel()
    {
        NumberOfWheels = 1;
    }

    public void MakeTwoWheel()
    {
        NumberOfWheels = 2;
    }

    public void MakeFourWheel()
    {
        NumberOfWheels = 4;
    }

    public void EngineYes()
    {
        Engine = true;
    }

    public void EngineNo()
    {
        Engine = false;
    }

    public void PassOne()
    {
        Passengers = 1;
    }

    public void PassTwo()
    {
        Passengers = 2;
    }

    public void CargoYes()
    {
        Cargo = true;
    }

    public void CargoNo()
    {
        Cargo = false;
    }


}
