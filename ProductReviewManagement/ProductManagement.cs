using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ProductReviewManagement
{
    public class ProductManagement
    {
        /// <summary>
        /// Retrieving Top Three Records
        /// UC2
        /// </summary>
        /// <param name="list"></param>
        public void TopRecords(List<ProductReview> list)
        {
            var records = (from product in list
                           orderby product.rating descending
                           select product).Take(3);
            Console.WriteLine();
            Console.WriteLine("Top Three Records With Higest Rating");
            foreach (var record in records)
            {
                Console.WriteLine($"ProductId : {record.productId}, UserId : {record.userId}, Rating : {record.rating}, Review : {record.review}, isLike :{record.isLike}");
            }
        }      
    }
}
