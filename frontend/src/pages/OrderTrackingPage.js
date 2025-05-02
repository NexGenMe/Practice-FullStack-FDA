import React, { useEffect, useState } from 'react';
import axios from 'axios';

const OrderTrackingPage = ({ orderId }) => {
    const [orderStatus, setOrderStatus] = useState(null);

    useEffect(() => {
        // Fetch order status from the backend
        axios.get(`/delivery/${orderId}`)
            .then(response => setOrderStatus(response.data))
            .catch(error => console.error('Error fetching order status:', error));
    }, [orderId]);

    return (
        <div className="container mx-auto p-4">
            <h1 className="text-2xl font-bold mb-4">Order Tracking</h1>
            {orderStatus ? (
                <div>
                    <p>Status: {orderStatus.status}</p>
                    <p>ETA: {orderStatus.eta}</p>
                </div>
            ) : (
                <p>Loading order status...</p>
            )}
        </div>
    );
};

export default OrderTrackingPage;