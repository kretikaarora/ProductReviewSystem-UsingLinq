// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductReview.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReviewManagement
{
    /// <summary>
    /// Product Review Class
    /// </summary>
     public class ProductReview
     {
        public int productId { get; set; }
        public int userId { get; set; }
        public double rating { get; set; }
        public string review { get; set; }
        public bool isLike { get; set; }
     }
}
