import React, { useState, useEffect } from "react"
import { CustomDropdown } from "./component/drop-down-component";

export const Home = () => {
    const [prices, setPrices] = useState([]);
    const [ticks, setTicks] = useState([]);
    const [priceDetails, setPriceDetails] = useState([]);
    const [tick, setTick] = useState(null);
    const [price, setPrice] = useState(null);

    useEffect(() => {
        async function loadLookups() {
            fetch('https://localhost:5001/api/price/price-source')
                .then((response) => response.json())
                .then((res) => setPrices(res));

            fetch('https://localhost:5001/api/price/ticker')
                .then((response) => response.json())
                .then((res) => setTicks(res))
        }
        loadLookups();
    }, []);

    const handlePriceChange = (e) => {
        if (tick) {
            let priceDetails = `https://localhost:5001/api/price/price-details?priceId=${e.target.value}&tickerId=${tick}`
            fetch(priceDetails)
                .then((response) => response.json())
                .then((res) => setPriceDetails(res));
        }
        setPrice(e.target.value)
    }

    const handleTickChange = (e) => {
        console.log(price);
        console.log(e.target.value);
        if (price) {
            let priceDetails = `https://localhost:5001/api/price/price-details?priceId=${price}&tickerId=${e.target.value}`
            fetch(priceDetails)
                .then((response) => response.json())
                .then((res) => setPriceDetails(res));
        }
        setTick(e.target.value);
    }
    return (

        <div className="container mt-4">
            <CustomDropdown
                name={prices.key}
                options={prices}
                title="Price source"
                onChange={(e) => handlePriceChange(e)}
            />
            <br />
            <CustomDropdown
                name={prices.key}
                options={ticks}
                title="Ticker"
                onChange={(e) => handleTickChange(e)}
            />
            <br />
            <table class="table">
                <thead class="thead-dark">
                    <tr>
                        <th>
                            Time
                        </th>
                        <th>
                            Price
                        </th>
                    </tr>
                </thead>
                <tbody>
                    {priceDetails.map((item) => (
                        <tr>
                            <td>{item.time}</td>
                            <td>{item.pice}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    )
}