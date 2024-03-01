//Concrete Decorator
public class OnionDecorator : PizzaDecorator
{
    public OnionDecorator(IPizza pizza) : base(pizza) { }

    public override string GetPizzaType()
    {
        string type = base.GetPizzaType();
        type += "\r\n with extra onion";
        return type;
    }
}
