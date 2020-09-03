using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CS_ExtendMethod
{
    //數據類
    public static class PatentData
    {
        public static readonly Inventor[] Inventors = new Inventor[] {
                 new Inventor(){
                     Name="Benjamin Franklin",
                     City="Philadelphia",
                     State="PA",
                     Country="USA",
                     Id=1
                 },
                 new Inventor(){
                     Name="Orville Wright",
                     City="Kitty Hawk",
                     State="NC",
                     Country="USA",
                     Id=2
                 },
                 new Inventor(){
                     Name="Wilbur Wright",
                     City="Kitty Hawk",
                     State="NC",
                     Country="USA",
                     Id=3
                 },
                 new Inventor(){
                     Name="Samuel Morse",
                     City="New York",
                     State="NY",
                     Country="USA",
                     Id=4
                 },
                 new Inventor(){
                     Name="George Stephenson",
                     City="Wylam",
                     State="Northumberland",
                     Country="UK",
                     Id=5
                 },
                 new Inventor(){
                     Name="John Michaelis",
                     City="Chicago",
                     State="IL",
                     Country="USA",
                     Id=6
                 },
                 new Inventor(){
                     Name="Mary Phelps Jacob",
                     City="New York",
                     State="NY",
                     Country="USA",
                     Id=7
                 }
             };


        public static readonly Patent[] Patents = new Patent[] {
                 new Patent(){
                     Title="Bifocals",
                     YearOfPublication="1784",
                     InventorIds=new long[]{1}
                 },
                 new Patent(){
                     Title="Phonograph",
                     YearOfPublication="1877",
                     InventorIds=new long[]{1}
                 },
                 new Patent(){
                     Title="Kinetoscope",
                     YearOfPublication="1888",
                     InventorIds=new long[]{1}
                 },
                 new Patent(){
                     Title="Electrical Telegraph",
                     YearOfPublication="1837",
                     InventorIds=new long[]{4}
                 },
                 new Patent(){
                     Title="Flying machine",
                     YearOfPublication="1903",
                     InventorIds=new long[]{2,3}
                 },
                 new Patent(){
                     Title="Steam Locomotive",
                     YearOfPublication="1815",
                     InventorIds=new long[]{5}
                 },
                 new Patent(){
                     Title="Droplet deposition apparatus",
                     YearOfPublication="1989",
                     InventorIds=new long[]{6}
                 },
                 new Patent(){
                     Title="Backless Brassiere",
                     YearOfPublication="1914",
                     InventorIds=new long[]{7}
                 }
             };
    }
}
