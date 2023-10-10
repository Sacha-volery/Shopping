using System;
using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart
    {
        #region private attributes
<<<<<<< HEAD
        private List<Article> _articles = new List<Article>();


=======
        private List<CartItem> _cartItems = new List<CartItem>();
>>>>>>> c465cf211419088b80ff30ba2e443a59a7fc41a4
        #endregion private attributes

        #region public methods
        public void Add(List<CartItem> cartItems)
        {
            _articles = articles;
        }

        public void Remove(List<CartItem> cartItemsToRemove)
        {
            throw new NotImplementedException();
        }

        public List<CartItem> CartItems
        {
            get
            {
                return _articles;
            }
        }

        public float Price
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        #endregion public methods
    }
}
