namespace WASP_tasks.store;

public interface IStoreItem
{
    public double Price { get; set; }

    public void DiscountPrice(int percent)
    {
        this.Price *= (double)(100 - percent) / 100;
    }
}   