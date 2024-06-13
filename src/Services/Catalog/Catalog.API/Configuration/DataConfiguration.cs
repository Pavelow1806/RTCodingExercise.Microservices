namespace Catalog.API.Configuration
{
    public static class DataConfiguration
    {
        private static decimal markupMultiplier = 0.2m;
        public static decimal MarkupMultiplier => markupMultiplier;

        private static int itemsPerPage = 20;
        public static int ItemsPerPage => itemsPerPage;

        public static void Initialise(decimal _markupMultiplier, int _itemsPerPage)
        {
            markupMultiplier = _markupMultiplier;
            itemsPerPage = _itemsPerPage;
        }
    }
}
