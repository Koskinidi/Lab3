using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Avto
    {
        private string? car_brand;
        public string? getCar_brand() { return car_brand; }
        public void setCar_brand(string brand) { car_brand = brand; }


        private int max_count_of_passangers;
        public int getMax_count_of_passangers() { return max_count_of_passangers;}
        public void setMax_count_of_passangers(int max_count) { max_count_of_passangers = max_count; }


        private double price;
        public double getPrice() { return price; }
        public void setPrice(double price_avto) { price = price_avto; }

        private int quantity_in_stock;
        public int getQuantity_in_stock() { return quantity_in_stock; }
        public void setQuantity_in_stock(int quantity_in_stock) { this.quantity_in_stock = quantity_in_stock; }


        private bool availability;
        public bool getAvailability() { return availability;}
        public void setAvailability(bool availability) {  this.availability = availability;}
    }
}
