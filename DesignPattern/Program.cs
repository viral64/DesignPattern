using AbstractFactory;
using System;
using System.ComponentModel.DataAnnotations;
using Strategy;
using StrategyPatternHeadFirst;
using StrategyPatternHeadFirst.Interface;


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
            Duck model = new DuckModel();
           
            
           model.PerformQuack();


            model.SetQuackBehavior(new Quack());

            model.PerformQuack();
           

        }
    }
}