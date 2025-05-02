import React, { useContext } from 'react';
import { CartContext } from '../context/CartContext';
import axios from 'axios';

const CartCheckoutPage = () => {
    const { cart, removeFromCart } = useContext(CartContext);

    const handleCheckout = () => {
        // Mock checkout logic
        axios.post('/order', { items: cart, total: cart.reduce((sum, item) => sum + item.price, 0) })
            .then(response => alert('Order placed successfully!'))
            .catch(error => console.error('Error placing order:', error));
    };

    return (
        <div className="container mx-auto p-4">
            <h1 className="text-2xl font-bold mb-4">Cart</h1>
            <ul>
                {cart.map(item => (
                    <li key={item.id} className="mb-2">
                        <h2 className="text-xl font-semibold">{item.name}</h2>
                        <p>Price: ${item.price.toFixed(2)}</p>
                        <button 
                            className="bg-red-500 text-white px-4 py-2 mt-2"
                            onClick={() => removeFromCart(item.id)}
                        >
                            Remove
                        </button>
                    </li>
                ))}
            </ul>
            <button 
                className="bg-green-500 text-white px-4 py-2 mt-4"
                onClick={handleCheckout}
            >
                Checkout
            </button>
        </div>
    );
};

export default CartCheckoutPage;