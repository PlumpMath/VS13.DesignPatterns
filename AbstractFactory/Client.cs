using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns {
    //
    class Client {
        internal ProductA ProductA {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }

        internal ProductB ProductB {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }

        internal AbstractFactory AbstractFactory {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }
        //
        static void Main(string[] args) {
            //Create a catalogue with a known, single family of products 
            Catalogue catalogue = CreateCatalogue();
            Console.WriteLine(catalogue.ListProducts());

            //Create a catalogue with a family of default products
            AbstractFactory factory = new AbstractFactory();
            catalogue = CreateCatalogue(factory);
            Console.WriteLine(catalogue.ListProducts());

            //Create another catalogue with a new family of products
            AbstractFactory factory1 = new ConcreteFactory1();
            Catalogue catalogue1 = CreateCatalogue(factory1);
            Console.WriteLine(catalogue1.ListProducts());

            //Create another catalogue with another new family of products
            AbstractFactory factory2 = new ConcreteFactory2();
            Catalogue catalogue2 = CreateCatalogue(factory2);
            Console.WriteLine(catalogue2.ListProducts());
            Console.Read();
        }
        static Catalogue CreateCatalogue() {
            //Create a catalogue by adding known products to it
            //Here we have knowledge of how to construct a catalogue 
            Catalogue catalogue = new Catalogue("Catalogue");
            catalogue.AddProductA(new ProductA("1"));
            catalogue.AddProductB(new ProductB("1"));
            return catalogue;
        }
        static Catalogue CreateCatalogue(AbstractFactory factory) {
            //Create a catalogue by adding factory products to it
            //Here we use the same construction process but allow the catalogue to contain a differet family of products
            Catalogue catalogue = factory.MakeCatalogue("Catalogue (Factory Made)");
            catalogue.AddProductA(factory.MakeProductA("1"));
            catalogue.AddProductA(factory.MakeProductA("2"));
            catalogue.AddProductA(factory.MakeProductA("3"));
            catalogue.AddProductB(factory.MakeProductB("1"));
            return catalogue;
        }
    }
}
