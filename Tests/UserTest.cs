using System;
using Xunit;
using models;
using BL;
namespace Tests
{
    public class UserTest
    {
        [Fact]
        public void UserNameAccurate()
        {
            string name = "georg";
            AppUser guineapig = new AppUser()
            {
                UserName = name
            };
            Assert.Equal(name, guineapig.UserName);
        }
        [Fact]
        public void UserTypeAccurate()
        {
            string type = "manager";
            AppUser guineapig = new AppUser()
            {
                userType = type
            };
            Assert.Equal(type, guineapig.userType);
        }
        [Fact]
        public void UserPhoneAccurate()
        {
            string _phone = "123456789";
            AppUser guineapig = new AppUser()
            {
                Phone = _phone
            };
            Assert.Equal(_phone, guineapig.Phone);
        }
        [Fact]
        public void UserAddressAccurate()
        {
            string _addr = "123 road";
            AppUser guineapig = new AppUser()
            {
                Address = _addr
            };
            Assert.Equal(_addr, guineapig.Address);
        }
        [Fact]
        public void OrderUserIDAccurate()
        {
            int userId = 77;
            Order guineapig = new Order()
            {
                UserId = userId
            };
            Assert.Equal(userId, guineapig.UserId);
        }
        [Fact]
        public void OrderTotalAccurate()
        {
            int tot = 77;
            Order guineapig = new Order()
            {
                Total = tot
            };
            Assert.Equal(tot, guineapig.Total);
        }
        [Fact]
        public void OrderLocIDAccurate()
        {
            int loc = 77;
            Order guineapig = new Order()
            {
               LocationId = loc
            };
            Assert.Equal(loc, guineapig.LocationId);
        }
        [Fact]
        public void ProductNameAccurate()
        {
            string n = "gromp";
            Products guineapig = new Products()
            {

                ItemName = n
            };
            Assert.Equal(n, guineapig.ItemName);
        }
        [Fact]
        public void ProductPriceAccurate()
        {
            int p = 3;
            Products guineapig = new Products()
            {

                Price = p
            };
            Assert.Equal(p, guineapig.Price);
        }
        [Fact]
        public void LocationAddressAccurate()
        {
            string _addr = "123 road";
            Location guineapig = new Location()
            {
                Address = _addr
            };
            Assert.Equal(_addr, guineapig.Address);
        }
        [Fact]
        public void LocationPhoneAccurate()
        {
            string _phone = "123456789";
            Location guineapig = new Location()
            {
                Phone = _phone
            };
            Assert.Equal(_phone, guineapig.Phone);
        }
        [Fact]
        public void InventoryLocationIDAccurate()
        {
            int locId = 77;
            Inventory guineapig = new Inventory()
            {
                LocationId = locId
            };
            Assert.Equal(locId, guineapig.LocationId);
        }
        [Fact]
        public void InventoryProductIDAccurate()
        {
            int pId = 77;
            Inventory guineapig = new Inventory()
            {
                ProductId = pId
            };
            Assert.Equal(pId, guineapig.ProductId);
        }
        [Fact]
        public void InventoryQuantityAccurate()
        {
            int q = 77;
            Inventory guineapig = new Inventory()
            {
                Quantity = q 
            };
            Assert.Equal(q, guineapig.Quantity);
        }
        [Fact]
        public void ItemProductIDAccurate()
        {
            int pId = 77;
            LineItem guineapig = new LineItem()
            {
                ProductId = pId
            };
            Assert.Equal(pId, guineapig.ProductId);
        }
        [Fact]
        public void ItemOrderIDAccurate()
        {
            int oId = 77;
            LineItem guineapig = new LineItem()
            {
                OrderId = oId
            };
            Assert.Equal(oId, guineapig.OrderId);
        }
    }
}
