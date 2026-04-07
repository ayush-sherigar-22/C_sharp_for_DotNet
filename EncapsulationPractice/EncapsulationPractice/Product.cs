namespace Encapsultion
{
    public class Product
        {
            
            private string _name;
            private float _price;
            private float _discount;

            public string Name => _name;
            public float Price => _price;
            public float Discount => _discount;
            public Product(string name, float price )
            {
               

                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentNullException("Invalid Name");
                }
                _name = name;
             
                SetPrice(price);
            }

            private void SetPrice(float amnt)
            {
                if (amnt <= 0)
                {
                    throw new InvalidOperationException("Invalid Price");
                }
                _price = amnt;
            }
            
            public void SetDiscount(float amnt)
            {
                if(amnt < 0 || amnt > 50)
                {
                    throw new InvalidOperationException("Discount is invalid");
                }
                _discount = amnt;
            }
      
            public float FinalPrice()
            {
                return _price-(_price*_discount/100);
            }

            

            public void DisplayDetails()
            {
                Console.WriteLine($"Product Discount  : {_discount} ");
                Console.WriteLine($"Product name is: {_name}");
                Console.WriteLine($"Product price is: {_price}");
            }
        }
    }








