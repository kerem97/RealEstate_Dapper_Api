﻿namespace RealEstate_Dapper_Api.Dtos.ProductDtos
{
    public class ResultProductWithCategoryDto
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        public string CategoryName { get; set; }
        public string CoverImage { get; set; }
        public string Type { get; set; }
        public string Adress { get; set; }
    }
}
