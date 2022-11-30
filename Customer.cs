public class Customer {
    protected int totalCost;
    public List<Menu> orderList = new List<Menu>();
    public List<Menu> foodList = new List<Menu>();

    public Customer() {
        totalCost = 0;
    }
    public void order(Menu menu) {
        this.totalCost += menu.cost;
        orderList.Add(menu);
    }
    public void passOrder(Server server) {
        server.orderList = this.orderList;
    }
    public void getServing(List<Menu> food_list){
        foodList = food_list;
    }
    public void pay(Server server) {
        server.getPay(totalCost);
        totalCost = 0;
    }
}
