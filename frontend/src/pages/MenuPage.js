import React, { useEffect, useState, useContext } from 'react';
import axios from 'axios';
import { CartContext } from '../context/CartContext';

const MenuPage = ({ restaurantId }) => {
    const [menuItems, setMenuItems] = useState([]);
    const { addToCart } = useContext(CartContext);

    useEffect(() => {
        // Fetch menu items for the selected restaurant
        axios.get(`/menu?restaurantId=${restaurantId}`)
            .then(response => setMenuItems(response.data))
            .catch(error => console.error('Error fetching menu items:', error));
    }, [restaurantId]);

    return (
        <div className="container mx-auto p-4">
            <h1 className="text-2xl font-bold mb-4">Menu</h1>
            <ul>
                {menuItems.map(item => (
                    <li key={item.id} className="mb-2">
                        <h2 className="text-xl font-semibold">{item.name}</h2>
                        <p>Category: {item.category}</p>
                        <p>Price: ${item.price.toFixed(2)}</p>
                        <button 
                            className="bg-blue-500 text-white px-4 py-2 mt-2"
                            onClick={() => addToCart(item)}
                        >
                            Add to Cart
                        </button>
                    </li>
                ))}
            </ul>
        </div>
    );
};

export default MenuPage;