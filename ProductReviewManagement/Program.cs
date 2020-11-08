// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    /// <summary>
    /// Program Class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Creating a List of ProductReview and Adding values into List
        /// UC1 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Product Review Management System");
      
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
               new ProductReview(){productId=1,userId=1,rating=1,review="Low",isLike=true},
               new ProductReview(){productId=2,userId=2,rating=2,review="Low",isLike=true},
               new ProductReview(){productId=3,userId=3,rating=3,review="Average",isLike=true},
               new ProductReview(){productId=4,userId=4,rating=4,review="Average",isLike=true},
               new ProductReview(){productId=5,userId=5,rating=5,review="Good",isLike=true},
               new ProductReview(){productId=6,userId=6,rating=6,review="Good",isLike=true},
               new ProductReview(){productId=1,userId=7,rating=1,review="Low",isLike=true},
               new ProductReview(){productId=1,userId=8,rating=2,review="Low",isLike=true},
               new ProductReview(){productId=2,userId=9,rating=3,review="Average",isLike=true},
               new ProductReview(){productId=5,userId=10,rating=4,review="Good",isLike=true},
               new ProductReview(){productId=6,userId=11,rating=5,review="Good",isLike=true},
            };

            foreach(var productReview in productReviewList)
            {
                Console.WriteLine($"ProductId : {productReview.productId}, UserId : {productReview.userId}, Rating : {productReview.rating}, Review : {productReview.review}, isLike :{productReview.isLike}");
            }
            ProductManagement productManagement = new ProductManagement();

            Console.WriteLine(); 
            productManagement.AddDataTable();

        }
    }
}
