namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avtosalon avtosalon1 = new Avtosalon();
            avtosalon1.setName("Авто-плюс");
            Console.WriteLine(avtosalon1.getName());

            Avto avto1 = new Avto();            
            avto1.setCar_brand("Mercedes");
            avto1.setMax_count_of_passangers(5);
            avto1.setPrice(23600000);
            avto1.setQuantity_in_stock(7);
            avto1.setAvailability(true);
            //Console.WriteLine(avto1.autosa);

            Avto avto2 = new Avto();
            avto2.setCar_brand("Hyundai");
            avto2.setMax_count_of_passangers(5);
            avto2.setPrice(1400000);
            avto2.setQuantity_in_stock(20);
            avto2.setAvailability(true);

            Purchase_request request1 = new Purchase_request();
            request1.setFull_name("Ellina");
            request1.setTelephone_number("89234567384");

            Purchase_request request2 = new Purchase_request();
            request2.setFull_name("Alex");
            request2.setTelephone_number("89234754574");

            Purchase_request request3 = new Purchase_request();
            request3.setFull_name("Naomi");
            request3.setTelephone_number("89234754574");

            Console.WriteLine(avto2.getCar_brand());
        }
    }
}
