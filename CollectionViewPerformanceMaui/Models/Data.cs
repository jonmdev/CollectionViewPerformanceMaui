using CollectionViewPerformanceMaui.Enums;
using CollectionViewPerformanceMaui.Helpers;
using CollectionViewPerformanceMaui.Resources.Fonts;

namespace CollectionViewPerformanceMaui.Models
{
	public sealed class Data
	{
		public Template Template { get; set; }

        public string RestaurantName { get; set; } = string.Empty;

        public string RestaurantDescription { get; set; } = string.Empty;

        public string RestaurantAddress { get; set; } = string.Empty;

        public string Rating { get; set; } = string.Empty;

		public string Review { get; set; } = string.Empty;

		public List<string> Reviews { get; set; } = new();

        public List<string> SocialMedia { get; set; } = new();

        public ImageSource PhotoImageSource { get; set; } = null;

        List<string> imageStrings = new() {
                "CollectionViewPerformanceMaui.Resources.Photos.cat1.jpg",
                "CollectionViewPerformanceMaui.Resources.Photos.cat2.jpg",
                "CollectionViewPerformanceMaui.Resources.Photos.cat3.jpg",
                "CollectionViewPerformanceMaui.Resources.Photos.cat4.jpg",
                "CollectionViewPerformanceMaui.Resources.Photos.cat5.jpg",
                "CollectionViewPerformanceMaui.Resources.Photos.cat6.jpg",
                "CollectionViewPerformanceMaui.Resources.Photos.cat7.jpg",
                "CollectionViewPerformanceMaui.Resources.Photos.cat8.jpg",
                "CollectionViewPerformanceMaui.Resources.Photos.cat9.jpg",
                "CollectionViewPerformanceMaui.Resources.Photos.cat10.jpg",
                "CollectionViewPerformanceMaui.Resources.Photos.cat11.jpg",
                "CollectionViewPerformanceMaui.Resources.Photos.cat12.jpg",
                "CollectionViewPerformanceMaui.Resources.Photos.cat13.jpg",
                "CollectionViewPerformanceMaui.Resources.Photos.cat14.jpg",
            };

        public Data()
		{
			var random = new Random();

			this.Template = Template.CardWithTheLot;
			this.RestaurantName = RandomContentHelper.GenerateRandomRestaurantName();
			this.RestaurantDescription = RandomContentHelper.GenerateRandomSentence(5);
			this.RestaurantAddress = RandomContentHelper.GenerateRandomAddress();

			this.Rating = RandomContentHelper.GenerateRandomRating();

            this.Review = RandomContentHelper.GenerateRandomSentence(random.Next(6, 12));
            this.Reviews = new List<string>()
            {
                RandomContentHelper.GenerateRandomSentence(random.Next(6, 12)),
                RandomContentHelper.GenerateRandomSentence(random.Next(6, 12)),
                RandomContentHelper.GenerateRandomSentence(random.Next(6, 12))
            };

			this.SocialMedia = new List<string>()
			{
				FontAwesome.Instagram,
				FontAwesome.Facebook,
				FontAwesome.Tiktok,
			};
            this.PhotoImageSource = ImageSource.FromResource(imageStrings[new Random().Next(0, imageStrings.Count)]);

            // random.Next(0, 2) == 1; // 50/50 chance
        }
    }
}
