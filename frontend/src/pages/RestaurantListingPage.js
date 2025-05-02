import React, { useEffect, useState } from 'react';
import axios from 'axios';

const RestaurantListingPage = () => {
    const [restaurants, setRestaurants] = useState([]);

    useEffect(() => {
        // Fetch restaurants from the backend
        axios.get('/restaurant')
            .then(response => setRestaurants(response.data))
            .catch(error => console.error('Error fetching restaurants:', error));
    }, []);

    return (
        <div className="container mx-auto p-4">
            <h1 className="text-2xl font-bold mb-4">Restaurants</h1>
            <ul>
                {restaurants.map(restaurant => (
                    <li key={restaurant.id} className="mb-2">
                        <h2 className="text-xl font-semibold">{restaurant.name}</h2>
                        <p>{restaurant.cuisine}</p>
                    </li>
                ))}
            </ul>
        </div>
    );
};

export default RestaurantListingPage;