public class Cook:Worker {
    public Cook(int _salary): base(_salary) {
    }
    public void cook() {
        this.foodList = this.orderList;
    }
    public void giveFood(Server server) {
        server.foodList = this.foodList;
    }
    public void getOrderFood(List<Menu> order_list){
        this.orderList = order_list;
        this.cook();
    }
}
