public class Owner {
    public int totalMoney;

    public Owner(int _totalMoney) {
        totalMoney = _totalMoney;
    }
    public void giveSalary(int amount) {
        this.totalMoney -= amount;
    }
    public void getGiveMoney(int soldMoney){
        this.totalMoney += soldMoney;
    }
}
