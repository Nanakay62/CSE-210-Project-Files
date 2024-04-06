public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double TotalPrice()
    {
        double total = products.Sum(p => p.TotalCost());
        total += customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string PackingLabel()
    {
        return string.Join("\n", products.Select(p => $"{p.GetName()} (ID: {p.GetId()})"));
    }

    public string ShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddress()}";
    }
}