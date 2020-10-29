using System;
using System.Collections.Generic;
using System.Text;

using CameraReview.Product;

namespace CameraReview.Review
{
    public interface IReview
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public IProduct Product { get; set; }
}
}
