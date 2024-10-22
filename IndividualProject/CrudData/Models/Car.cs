﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CrudData.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string Vin { get; set; }

    public int Year { get; set; }

    public int MakeId { get; set; }

    public string Model { get; set; }

    public string Color { get; set; }

    public string Type { get; set; }

    public virtual Make Make { get; set; }

    public override string ToString()
    {
        return $"{Vin} {Year} {Make} {Model} {Color} {Type}";
    }

    //create a public override bool Equals that allows the combobox to load in with the correct car
    public override bool Equals(object obj)
    {
        return obj is Car car &&
               CarId == car.CarId &&
               Vin == car.Vin &&
               Year == car.Year &&
               MakeId == car.MakeId &&
               Model == car.Model &&
               Color == car.Color &&
               Type == car.Type;
    }
    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
}