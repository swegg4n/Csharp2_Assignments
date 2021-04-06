using System;

namespace Assignment6
{
    class Invoice
    {
        public Invoice(string[] lines)
        {
            int ptr = 0;

            InvoiceNr = int.Parse(lines[ptr++]);
            InvoiceDate = lines[ptr++];
            DueDate = lines[ptr++];
            RecieverContact = new Contact(lines, ref ptr);

            int itemsCount = int.Parse(lines[ptr++]);
            Items = new Item[itemsCount];
            for (int i = 0; i < itemsCount; i++)
            {
                Items[i] = new Item(lines, ref ptr);
            }

            SenderContact = new Contact(lines, ref ptr);
            PhoneNr = lines[ptr++];
            WebPageURL = lines[ptr++];
        }

        public int InvoiceNr { get; private set; }
        public string InvoiceDate { get; private set; }
        public string DueDate { get; private set; }

        public Contact RecieverContact { get; private set; }
        public Item[] Items { get; private set; }
        public Contact SenderContact { get; private set; }

        public string PhoneNr { get; private set; }
        public string WebPageURL { get; private set; }


        public new string ToString()
        {
            string returnString =
                $"{InvoiceNr}\n" +
                $"{InvoiceDate}\n" +
                $"{DueDate}\n" +
                $"{RecieverContact}\n";

            for (int i = 0; i < Items.Length; i++)
                returnString += Items[i].ToString() + "\n";

            returnString +=
                $"{SenderContact}\n" +
                $"{PhoneNr}\n" +
                $"{WebPageURL}";

            return returnString;
        }
    }

    class Contact
    {
        public Contact(string[] lines, ref int ptr)
        {
            CompanyName = lines[ptr++];
            PersonName = lines[ptr++];
            Address = lines[ptr++];
            Zipcode = lines[ptr++];
            City = lines[ptr++];
            Country = lines[ptr++];
        }

        public string CompanyName { get; private set; }
        public string PersonName { get; private set; }
        public string Address { get; private set; }
        public string Zipcode { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }


        public new string ToString()
        {
            return $"{CompanyName}\n" +
                   $"{PersonName}\n" +
                   $"{Address}\n" +
                   $"{Zipcode}\n" +
                   $"{City}\n" +
                   $"{Country}";
        }
    }

    class Item
    {
        public Item(string[] lines, ref int ptr)
        {
            Description = lines[ptr++];
            Quantity = int.Parse(lines[ptr++]);
            Price = float.Parse(lines[ptr++]);
            TaxPercentage = float.Parse(lines[ptr++]);
        }

        public string Description { get; private set; }
        public int Quantity { get; private set; }
        public float Price { get; private set; }
        public float TaxPercentage { get; private set; }
        public float TotalTax { get { return Price * (TaxPercentage / 100) * Quantity; } }
        public float Total { get { return Price * Quantity + TotalTax; } }


        public new string ToString()
        {
            return $"{Description}\n" +
                   $"{Quantity}\n" +
                   $"{Price}\n" +
                   $"{TaxPercentage}\n" +
                   $"{Total}";
        }
    }

}
