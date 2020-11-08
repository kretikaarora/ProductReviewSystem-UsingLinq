
﻿
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

        /// <summary>
        /// Top Three Records With Product Id 1,4,9 and Rating 3
        /// UC3
        /// </summary>
        /// <param name="list"></param>
        public void TopThreeRecordsWithSelectedId(List<ProductReview> list)
        {
            var records = (from product in list
                           where ((product.rating == 3) && (product.productId == 1 || product.productId == 4 || product.productId == 9))
                           select product).Take(3);
            Console.WriteLine();
            Console.WriteLine("Top Three Records With Product Id 1,4,9 and Rating 3");
            foreach (var record in records)
            {
                Console.WriteLine($"ProductId : {record.productId}, UserId : {record.userId}, Rating : {record.rating}, Review : {record.review}, isLike :{record.isLike}");
            }

        }

        /// <summary>
        /// Count For Product Id
        /// UC4
        /// </summary>
        /// <param name="list"></param>
        public void CountForProductId(List<ProductReview> list)
        {
            var records = (list.GroupBy(p => p.productId).Select(x => new { ProductId = x.Key, Count = x.Count() }));
            Console.WriteLine("Group by ProductId");
            Console.WriteLine();
            foreach (var record in records)
            {
                Console.WriteLine("ProductId : " + record.ProductId +"  Count : "+record.Count );
            }
        }
    }
}




