using Scaffold_Test_User.Areas.Identity.Data;

namespace Scaffold_Test_User.Discounts
{
    public interface IDiscountFactory
    {
        IDiscount CreateDiscount(ApplicationUser user);
    }

    public interface IDiscount
    {
        double ApplyDiscount(double totalPrice);
    }

    public class BasicDiscount : IDiscount
    {
        public double ApplyDiscount(double totalPrice)
        {
            return totalPrice;
        }
    }

    public class PremiumDiscount : IDiscount
    {
        public double ApplyDiscount(double totalPrice)
        {
            return totalPrice * 0.9;
        }
    }

    public class VipDiscount : IDiscount
    {
        public double ApplyDiscount(double totalPrice)
        {
            return totalPrice * 0.8;
        }
    }

    public class ReservationDiscountFactory : IDiscountFactory
    {
        public IDiscount CreateDiscount(ApplicationUser user)
        {
            if (user.reservationCount < 5)
            {
                return new BasicDiscount();
            }
            else if (user.reservationCount < 10)
            {
                return new PremiumDiscount();
            }
            else
            {
                return new VipDiscount();
            }
        }
    }

}
