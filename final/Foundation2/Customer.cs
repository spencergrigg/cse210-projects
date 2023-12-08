public class Customer{
    private string _name;
    Address _custAddress;

    
    public Customer(string name, Address customerAddress){
        _name = name;
        _custAddress = customerAddress;
    }

    public Customer(){
        _name = "default";
    }

    public string GetName(){
        return _name;
    }

    public string GetShippingAddress(){
        return _custAddress.GetAddress();
    }

    public bool GetUSA(){
        if (_custAddress.IsUSA())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}