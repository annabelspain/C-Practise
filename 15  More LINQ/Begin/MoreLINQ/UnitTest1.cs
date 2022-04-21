using MoreLINQ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using static MoreLINQ.Data.Product;
using Xunit;

namespace MoreLINQ
{
    public class UnitTest1
    {
            //  #############################################
            //  ############ READ THIS FIRST ################
            //  #############################################

            // These tests are in increasing order of difficulty
            // Each test shows the imperative style of solving a problem
            // We then invite you to do the LINQ style of solving the same problem
            // and give you some hints as to which LINQ methods you would likely find useful

            // work your way through them, but don't be surprised if at some point
            // you just can't figure it out

            // We've provided the LINQ solutions in the LINQ Solutions folder of this project

            // It takes time to 'Think LINQ'
            // Don't expect this to be an immediate conversion process so don't get despondent if
            // it doesn't 'click' straight away.
            // Some of the LINQ shown here is hard - even for seasoned LINQers - but it's important you
            // get to see the range of things that LINQ can do and hence see the benefit of 
            // a declarative style of programming

            // Some tests use GetProducts(). If you're curious, this is in the Data folder, but you don't need
            // to know the detail to do complete the tests

        [Fact]
        public void Show_Lazy_Evaluation()
        {
            // There is nothing to do in this test.
            // Look at the 2 Asserts
            // In the first one, even thought the select increments 'i', it has not yet been executed
            // Doing anything with 'result' triggers the evaluation of the LINQ statement and i is incremented on each iteration
            int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int i = 0;
            var result =
                from num in numbers
                select i++;

            Assert.Equal(0, i);
            result.Count();
            Assert.Equal(10, i);
        }

        [Fact]
        public void Only_Odd_Numbers()
        {
            // Loop round all numbers testing if the remainder when divided by 2 is zero

            int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };

            //bool containsOnlyOddNumbers = true;
            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        containsOnlyOddNumbers = false;
            //    }
            //}

            //Only need to use one of the below 

            Assert.False(numbers.Any(i => i % 2 == 0));
            Assert.True(numbers.All(i => i % 2 != 0));

            // LINQ (hint: Any() All()
        }

        [Fact]
        public void Identical_Sequences()
        {
            // If the collections are of diffrent lengths, then they cannot possibly be identical
            // Loop round both comparing each element and do a logical AND such that if the match
            // is ever false, then it remains false
            // Try it by modifying the collection & see NCrunch turn red
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "cherry", "apple", "blueberry" };

            bool match1 = wordsA.Length == wordsB.Length;
            for (int i = 0; i < wordsA.Length; i++)
            {
                match1 = match1 && wordsA[i] == wordsB[i];
            }
            Assert.True(match1);

            bool match2 = wordsA.SequenceEqual(wordsB);
            Assert.True(match2);


            Assert.True(wordsA.SequenceEqual(wordsB));
            //Assert.True(match1.SequenceEquals(wordsA => wordsA[i] == wordsB[i]));

            // LINQ {hint: SequenceEquals() )
        }

        [Fact]
        public void Expensive_In_Stock_Products()
        {
            // Create a List to store the expensive stock
            // Get each product in turn from GetProducts()
            // If its in stock and > �3 then add it to the expensive stock list
            //List<Product> expensiveInStockProducts1 = new List<Product>();
            //foreach (Product prod in GetProducts())
            //{
            //    if (prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M)
            //    {
            //        expensiveInStockProducts1.Add(prod);
            //    }
            //}
            //Assert.Equal(71, expensiveInStockProducts1.Count);

            // Using LINQ (hint: from/where/select Count() )

            var products =
                from p in GetProducts()
                where (p.UnitsInStock > 0 && p.UnitPrice > 3.00M)
                select p;
            Assert.Equal(71, products.Count());
        }

        [Fact]
        public void Length_Of_Word_Less_Than_Index()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            // Create a list to hold those numbers where the string length of the number is <= number
            // loop round each string and do the comparison
            // if the answer is 'yes', the length is less than or equal to the index
            // then store the index

            //List<int> lengthLTIndex1 = new List<int>();
            //for (int i = 0; i < digits.Length; i++)
            //{
            //    if (digits[i].Length <= i)
            //    {
            //        lengthLTIndex1.Add(i);
            //    }
            //}
            //Assert.Equal(6, lengthLTIndex1.Count);

            // Using LINQ (hint: Where() )
            var LengthLTIndex2 = digits.Where((str, index) => str.Length <= index);
            Assert.Equal(6, LengthLTIndex2.Count());
        }

        [Fact]
        public void Sorted_Words()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            List<string> sortedWords1 = new List<string>(); // put the sorted words into here
            // Take each 'word' in turn from 'words'
            // Loop round all the words you've sorted so far
            // if the current word is 'larger' than the one in sortedWords1 that you're currently considering
            // then keep going
            // otherwise insert 'word' at that point
            // If you reach the end of sortedWords1 then bung this 'word' on the end
            foreach (string word in words)
            {
                if (sortedWords1.Count==0)
                {
                    sortedWords1.Add(word);
                } else
                {
                    for(int i=0;i<sortedWords1.Count;i++)
                    {
                        if (string.Compare(word, sortedWords1[i])>0) 
                        {
                            continue;
                        } else
                        {
                            sortedWords1.Insert(i,word);
                            goto quit;
                        }
                    }
                    sortedWords1.Add(word);
                    quit:;
                }
            }
            Assert.Equal("cherry", sortedWords1[2]);

            // Using LINQ (hint: from/orderby/select ToList())


            var sortedWords2 = from w in words
                               orderby w
                               select w;
            //Above is the same as below ^ v so could use either 
            sortedWords2 = words.OrderBy(w => w);


           Assert.Equal("cherry", sortedWords2.ToList()[2]);

        }

        [Fact]
        public void Show_Top_10_Expensive_Items()
        {
            // Get all the products and put them into a list of increasing price order
            // Then remove all but the last 10
            List<Product> productsInPriceOrder = new List<Product>();
            foreach (Product prod in GetProducts())
            {
                if (productsInPriceOrder.Count == 0)
                {
                    productsInPriceOrder.Add(prod);
                }
                else
                {
                    for (int i = 0; i < productsInPriceOrder.Count; i++)
                    {
                        if (productsInPriceOrder[i].UnitPrice > prod.UnitPrice)
                        {
                            productsInPriceOrder.Insert(i, prod);
                            goto quit;
                        }
                    }
                    productsInPriceOrder.Add(prod);
                    quit:;
                }
            }
            productsInPriceOrder.RemoveRange(0, productsInPriceOrder.Count - 10);
            Assert.Equal(45.6M, productsInPriceOrder[0].UnitPrice);


            // Using LINQ (hint: from/orderby/descending/select, Take(), Reverse(), First())
            //We want the last 10, so first we take the last then and then change it to ascending order, which is why we use descending to take the last 10 and then reverse it to the correct ascending order 
            var productsInPriceOrder2 = from g in GetProducts()
                                        orderby g.UnitPrice descending 
                                        select g.UnitPrice;

            //Both lines below are the same 
            Assert.Equal(45.6M, productsInPriceOrder2.Take(10).Reverse().ToList()[0]);
            Assert.Equal(45.6M, productsInPriceOrder2.Take(10).Reverse().First());

        }

        [Fact]
        public void Display_3rd_Page_With_10_Per_Page_Of_UnitsInStock()
        {
            // This is the sort of pagination problem you get when displaying records that are
            // too numerous to fit onto 1 page. You have to paginate
            // First get a list of all products that are in stock
            // Then loop round this list discarding those that would be on Page1 and Page2
            // and store the next 10 as what must be shown on Page3

            const int PRODUCTS_PER_PAGE = 10;
            int pageNumber = 3;

            List<Product> paginate1 = new List<Product>();
            List<Product> productsInStock = new List<Product>();
            foreach(Product prod in GetProducts())
            {
                if (prod.UnitsInStock>0)
                {
                    productsInStock.Add(prod);
                }
            }
            for(int i= (pageNumber-1)* PRODUCTS_PER_PAGE; i< (pageNumber) * 10; i++) 
            {
                paginate1.Add(productsInStock[i]);
            }
            Assert.Equal(23, paginate1.First().ProductID);
            Assert.Equal(34, paginate1.Last().ProductID);

            // Using LINQ (hint: from/where/select Skip(), Take() )

            var paginate2 = from p in GetProducts()
                            where p.UnitsInStock > 0
                            select p;

            paginate2 = paginate2.Skip((pageNumber - 1) * PRODUCTS_PER_PAGE).Take(PRODUCTS_PER_PAGE);

            Assert.Equal(23, paginate1.First().ProductID);
            Assert.Equal(34, paginate1.Last().ProductID);

        }

        [Fact]
        public void Find_Union_Of_First_Letters()
        {
            // First get a list of all the first characters of all the products, discarding duplicates
            // Likewise get a list of all the first characters of all the categories, discarding duplicates
            // Then loop round one list checking to see if each character also appears in the first list
            // If it does, store it
            List<char> productNamesFirstChar = new List<char>();
            List<char> categoriesFirstChar = new List<char>();

            foreach (Product prod in GetProducts())
            {
                char p1 = prod.ProductName[0];
                char c1 = prod.Category[0];
                if (!productNamesFirstChar.Contains(p1))
                {
                    productNamesFirstChar.Add(p1);
                }
                if (!categoriesFirstChar.Contains(c1))
                {
                    categoriesFirstChar.Add(c1);
                }
            }
            List<char> intersection = new List<char>();
            foreach (char p in productNamesFirstChar)
            {
                if (categoriesFirstChar.Contains(p))
                {
                    intersection.Add(p);
                }
            }
            Assert.Equal(6, intersection.Count);

            // LINQ (hint: Select(), Intersect() )

            var intersection2 = GetProducts().Select(p => p.ProductName[0]).Intersect(GetProducts().Select(p => p.Category[0]));

            Assert.Equal(6, intersection2.Count());

        }

        [Fact]
        public void Find_Cheapest_And_Most_Expensive_Categories()
        {
            // First, get all the products and put them into a dictionary indexed by the category
            // Create variables to hold the category name & price of the category which, when you add up all
            // the prices of the products in that category, is the most expensive.
            // Likewise create variables for the category whose products sum to the cheapest
            // Then loop round all the categories summing the prices of their products 
            // and storing the largest and smallest
            Dictionary<string, List<Product>> groupByCategory = new Dictionary<string, List<Product>>();
            foreach (Product prod in GetProducts())
            {
                if (!groupByCategory.ContainsKey(prod.Category))
                {
                    groupByCategory.Add(prod.Category, new List<Product>());
                }
                groupByCategory[prod.Category].Add(prod);
            }

            string strMaxCategoryName1 = "";
            decimal maxCategoryPrices1 = decimal.MinValue;

            string strMinCategoryName1 = "";
            decimal minCategoryPrices1 = decimal.MaxValue;

            foreach (string category in groupByCategory.Keys)
            {
                decimal totalPrices = 0;
                foreach (Product prod in groupByCategory[category])
                {
                    totalPrices += prod.UnitPrice;
                }
                if (totalPrices > maxCategoryPrices1)
                {
                    strMaxCategoryName1 = category;
                    maxCategoryPrices1 = totalPrices;
                }
                if (totalPrices < maxCategoryPrices1)
                {
                    strMinCategoryName1 = category;
                    minCategoryPrices1 = totalPrices;
                }
            }
            Assert.Equal("Beverages", strMaxCategoryName1);
            Assert.Equal(455.75M, maxCategoryPrices1);

            Assert.Equal("Grains/Cereals", strMinCategoryName1);
            Assert.Equal(141.75M, minCategoryPrices1);


            // Using LINQ (hint: from/group, OrderBy(), First(), Last(), Sum()

            // for every category, give us a list of products, is why we do not need the select statement here 
            var groupByCategory2 = from p in GetProducts()
                                   group p by p.Category;
            //These two statements are the same ^ v 
            groupByCategory2 = GetProducts().GroupBy(p => p.Category);


            //order categories 
            var orderedCategory = groupByCategory2.OrderBy(g => g.Sum(p => p.UnitPrice));


            string strMaxCategoryName2 = orderedCategory.Last().Key;
            string strMinCategoryName2 = orderedCategory.First().Key;
            decimal maxCategoryPrices2 = orderedCategory.Last().Sum(p => p.UnitPrice);
            decimal minCategoryPrices2 = orderedCategory.First().Sum(p => p.UnitPrice);
            // This is the same as the above code just using the min max value
            maxCategoryPrices2 = groupByCategory.Max(g => g.Value.Sum(p => p.UnitPrice));


            Assert.Equal("Beverages", strMaxCategoryName2);
            Assert.Equal(455.75M, maxCategoryPrices2);

            Assert.Equal("Grains/Cereals", strMinCategoryName2);
            Assert.Equal(141.75M, minCategoryPrices2);

        }

    }
}
