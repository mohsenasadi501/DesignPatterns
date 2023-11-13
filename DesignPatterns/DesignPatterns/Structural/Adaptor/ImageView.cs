namespace DesignPatterns.Structural.Adaptor
{
    internal class ImageView
    {
        private Image _image;

        public ImageView(Image image)
        {
            _image = image;
        }

        public void apply(IFilter filter)
        {
            filter.apply(_image);
        }
    }
}
