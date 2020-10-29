using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

using CameraReview.Product;
using NSubstitute;
using CameraReview.Product.Camera;

namespace CameraReviewUnitTests.CameraReview.Product
{
    [TestClass]
    public class ProductTest
    {

        [TestMethod]
        public void Product_ShouldReturnContent_Success()
        {
            // setup
            var product = new ProductImpl
            {
                Name = "Producto1",
                SKU = "1234",
                Manufacturer = "empresa"
            };

            // exec
            var content = product.GetContent();

            // assert
            Assert.IsTrue(!string.IsNullOrWhiteSpace(content), "Should return content but obtained null or whitespace.");
        }

        [TestMethod]
        public void CameraProduct_ShouldReturnContentThatIncludeItsFeatures_Success()
        {
            // setup
            var type = "FullFrame";
            var cameraProduct = new Camera {
                Name = "Canon Eos R",
                Type = "FullFrame",
                CropFactor = 1
            };

            // exec
            var content = cameraProduct.GetContent();

            // assert
            Assert.IsTrue(!string.IsNullOrWhiteSpace(content), "Should return content but obtained null or whitespace.");
            Assert.IsTrue(content.Contains(type));
        }

    }
}
