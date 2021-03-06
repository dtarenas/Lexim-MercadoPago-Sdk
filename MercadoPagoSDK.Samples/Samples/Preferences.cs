﻿using System;
using MercadoPago.Common;
using MercadoPago.DataStructures.Preference;
using MercadoPago.Resources;

namespace MercadoPagoSDK.Samples
{
    internal class WebCheckout : ISample, IRequiresClientCredentials
    {
        public string Name => "WebCheckout Example";

        public string Category => "Checkout";

        public void Run()
        {
            // Create a preference object
            var preference = new Preference
            {
                Items =
                {
                    new Item
                    {
                        Id = "1234",
                        Title = "Small Silk Plate",
                        Quantity = 5,
                        CurrencyId = CurrencyId.ARS,
                        UnitPrice = 44.23m
                    }
                },
                Payer = new Payer
                {
                    Email = "augustus_mckenzie@gmail.com"
                }
            };
            
            // Save and posting preference
            preference.Save();

            Console.WriteLine(preference.Id);
            Console.WriteLine(preference.InitPoint);

            Console.ReadLine();
        }
    }
}
