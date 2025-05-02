import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import HomePage from './pages/HomePage';
import RestaurantListingPage from './pages/RestaurantListingPage';
import MenuPage from './pages/MenuPage';
import CartCheckoutPage from './pages/CartCheckoutPage';
import OrderTrackingPage from './pages/OrderTrackingPage';
import logo from './logo.svg';
import './App.css';

const App = () => {
    return (
        <Router>
            <Routes>
                <Route path="/" element={<HomePage />} />
                <Route path="/restaurants" element={<RestaurantListingPage />} />
                <Route path="/menu/:restaurantId" element={<MenuPage />} />
                <Route path="/cart" element={<CartCheckoutPage />} />
                <Route path="/order-tracking/:orderId" element={<OrderTrackingPage />} />
                {/* Add more routes here */}
            </Routes>
        </Router>
    );
};

export default App;
