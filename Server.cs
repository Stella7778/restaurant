public class Server: Worker {

    public int soldMoney;
    public Server(int _salary): base(_salary) {
        soldMoney = 0;
    }

    public void serving(Customer customer) {
        customer.getServing(this.foodList);
}
    public void getOrder(List<Menu> order_list){
        this.orderList = order_list;
    }
public void getGiveFood(List<Menu> food_list){
    this.foodList = food_list;
}
    public void giveMoney(Owner owner) {
        owner.getGiveMoney(this.soldMoney);
        this.soldMoney = 0;
    }
    public void orderFood(Cook cook) {
        cook.getOrderFood(this.orderList);
    }
    public void getPay(int totalCost) {
        this.soldMoney+= totalCost;
    }
}
