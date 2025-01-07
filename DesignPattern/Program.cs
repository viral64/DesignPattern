using AbstractFactory;
using System;
using System.ComponentModel.DataAnnotations;
using Strategy;
using StrategyPatternHeadFirst;
using StrategyPatternHeadFirst.Interface;
using ObserverPatternHeadFirst;
using DecoratorPattern_HeadFirst;
using DecoratorPattern_HeadFirst.TypesofBeverage;
using DecoratorPattern_HeadFirst.ConcreteBeverage;
using DecoratorPattern_HeadFirst.ConcreteCondiment;


namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////AbstractFactory
            //// Creating cars for North America
            //CarFactory northAmericaFactory = new NorthAmericaCarFactory();
            //Car northAmericaCar = northAmericaFactory.createCar();
            //CarSpecification northAmericaSpec = northAmericaFactory.createSpecification();

            //northAmericaCar.assemble();
            //northAmericaSpec.display();

            //// Creating cars for Europe
            //CarFactory europeFactory = new EuropeCarFactory();
            //Car europeCar = europeFactory.createCar();
            //CarSpecification europeSpec = europeFactory.createSpecification();

            //europeCar.assemble();
            //europeSpec.display();

            //-----------------------------------------------------------------------------
            //Strategy Design Pattern

            //SortingContext sortingContext = new SortingContext(new BubbleSort());
            //int[] arr = { 1, 2, 4 };
            //sortingContext.performSort(arr);


            //sortingContext.setSortingStrategy(new QuickSort());
            //sortingContext.performSort(arr);

            //sortingContext.setSortingStrategy(new MergeSort());
            //sortingContext.performSort(arr);



            //-------------------------------------------------------------------------------
            //StrategyDesign Pattern Head First
            //Duck model = new DuckModel();
            //model.PerformQuack();
            //model.SetQuackBehavior(new Quack());
            //model.PerformQuack();




            //-----------------------------------------------------------------------------
            //Observer DesignPattern Head First

            //           WeatherData weatherData = new WeatherData();
            //           CurrentConditionsDisplay currentDisplay =
            //new CurrentConditionsDisplay(weatherData);
            //           weatherData.setMeasurements(80, 65, 30.4f);
            //           weatherData.setMeasurements(82, 70, 29.2f);



            //------------------------------------------------------------------------------
            //DecoratorPattern
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription()+" $"+beverage.cost());

            Beverage beverage1 = new DarkRoast();
            beverage1 = new Mocha(beverage1);
            beverage1=new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            Console.WriteLine(beverage1.getDescription() + " $" + beverage1.cost());

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Soy(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.getDescription()+" $"+beverage2.cost());

            Console.ReadKey();
        }
    }
}