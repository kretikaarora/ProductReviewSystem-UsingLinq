// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductManagement.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
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
            Console.WriteLine("Group by ProductId");
            Console.WriteLine();
            var records = (list.GroupBy(p => p.productId).Select(x => new { ProductId = x.Key, Count = x.Count() }));
            foreach (var record in records)
            {
                Console.WriteLine("ProductId : " + record.ProductId + "  Count : " + record.Count);
            }
        }

        /// <summary>
        /// Retrievin ProductId And Review
        /// UC5,UC7(same as UC5)
        /// </summary>
        /// <param name="list"></param>
        public void RetrievingProductIdAndReview(List<ProductReview> list)
        {
            Console.WriteLine("Retrieving Product and Review from List");
            var records = (from product in list
                           select (product.productId, product.review));
            foreach (var record in records)
            {
                Console.WriteLine("ProductId : " + record.productId + "  Review :" + record.review);
            }
        }

        /// <summary>
        /// Skipping Top Five
        /// UC6
        /// </summary>
        /// <param name="list"></param>
        public void SkipTopFive(List<ProductReview> list)
        {
            Console.WriteLine("Skipping Top Five");
            var records = (from product in list
                           select (product)).Skip(5);
            foreach (var record in records)
            {
                Console.WriteLine($"ProductId : {record.productId}, UserId : {record.userId}, Rating : {record.rating}, Review : {record.review}, isLike :{record.isLike}");
            }
        }

        /// <summary>
        /// Creating DataTable
        /// UC8
        /// </summary>
        public void AddDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("productId");
            table.Columns.Add("userId");
            table.Columns.Add("rating");
            table.Columns.Add("review");
            table.Columns.Add("isLike");

            table.Rows.Add("101","1","1","Low","true");
            table.Rows.Add("201", "2", "2", "Low", "true");
            table.Rows.Add("301", "3", "6", "Good", "true");
            table.Rows.Add("401", "4", "5", "Good", "false");
            table.Rows.Add("501", "5", "4", "Average", "true");
            table.Rows.Add("201", "6", "3", "Average", "true");
            table.Rows.Add("301", "7", "6", "Good", "true");
            table.Rows.Add("501", "8", "4", "Average", "true");
            DisplayDataTable(table);
        }

        public void DisplayDataTable(DataTable table)
        {
            var records = table.AsEnumerable().Where(r => r.Field<string>("isLike") == "true");
            Console.WriteLine("product id  for where islike is true");
            foreach(var record in records)
            {               
             Console.WriteLine($"ProductId : {record.Field<string>("productId")}, UserId : {record.Field<string>("userId")}, Rating : {record.Field<string>("rating").ToString()}, Review : {record.Field<string>("review")}, isLike :{record.Field<string>("isLike").ToString()}");
            }                            
        }
    }
}




