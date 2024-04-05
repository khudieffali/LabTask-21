namespace LabTask_21
{

        class Gallery
        {
        public string Name { get; set; }
        public Car[] Cars { get; set; }

        public Gallery(string name, Car[] cars)
        {
            Name= name;
            Cars= cars;
        }
        public void GetGalleryCarShow()
        {
            foreach (var item in Cars)
            {
                item.GetInfoCar();
            }

        }
        public void GetGalleryCarById(int id)
        {
            foreach (var item in Cars)
            {
                if(item.Id == id)
                {
                    item.GetInfoCar();
                }
            }
        }
        public void SumCar()
        {
            int sum=0;
            foreach (var item in Cars)
            {
                sum += item.Price;

            }
            Console.WriteLine(sum);
        }

    }
}
