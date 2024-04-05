using LabTask_21;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new("Mercedes", 300, 22500);
        Car car1 = new("Bmw", 280, 45500);
        Car car2 = new("Ford", 240, 30000);
        Car car3 = new("Mazda", 330, 70000);
        Car car4 = new("Rolls-Roys", 220, 100000);
        Car[] arr = {car,car1, car2, car3, car4};
        Gallery gallery = new ("Auto-Gallery",arr);

        //gallery.GetGalleryCarShow();
        gallery.GetGalleryCarById(2);
        gallery.SumCar();

    }
}