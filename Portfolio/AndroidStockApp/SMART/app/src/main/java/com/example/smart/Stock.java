package com.example.smart;

import org.json.JSONObject;

import java.util.HashMap;
import java.util.Map;

/**
 * Alex Stack
 * STOCK object, which contains all the necessary fields for a particular stock
 * This class is to be used whenever dealing with any stocks, as all necessary information can be
 *      stored within this class and allows for easy implementation with the Firebase realtime
 *      database
 * 3-29-2019
 * Created STOCK class and necessary attributes
 *      included constructors and required GET and SET methods
 */

public class Stock {
    //Stock attributes
    //Stock code = "aapl", bought(date) = "mm/yy"
    private String stockCode,bought;
    private double price,shares,profit,low,high;
    private JSONObject stockData;

    //generic constructor
    public Stock() {}

    //constructor with JSON object
    public Stock(JSONObject json) {
        try {
            this.stockData = json;
            this.stockCode = json.getString("stockCode");
            this.bought = json.getString("bought");
            this.price = json.getDouble("price");
            this.shares = json.getDouble("shares");
            this.profit = json.getDouble("profit");
            this.low = json.getDouble("low");
            this.high = json.getDouble("high");
        } catch(Exception e) {
            e.printStackTrace();
        }
    }

    //constructor with values
    public Stock(String stockCode, String bought, double price, double shares, double profit, double low, double high) {
        try {
            stockData = new JSONObject();
            this.stockCode = stockCode; stockData.put("stockCode", stockCode);
            this.bought = bought; stockData.put("bought", bought);
            this.price = price; stockData.put("price", price);
            this.shares = shares; stockData.put("shares", shares);
            this.profit = profit; stockData.put("profit", profit);
            this.low = low; stockData.put("low", low);
            this.high = high; stockData.put("high", high);
        } catch(Exception e) {
            e.printStackTrace();
        }
    }

    //GETTERs and SETTERs for stock data
    //GET JSON object of stock data
    public JSONObject getStockData() {
        return stockData;
    }

    //SET stock data with JSON object
    public void setStockData(JSONObject json) {
        try {
            this.stockData = json;
            this.stockCode = json.getString("stockCode");
            this.bought = json.getString("bought");
            this.price = json.getDouble("price");
            this.shares = json.getDouble("shares");
            this.profit = json.getDouble("profit");
            this.low = json.getDouble("low");
            this.high = json.getDouble("high");
        } catch(Exception e) {
            e.printStackTrace();
        }
    }

    //SET stock data with values
    public void setStockData(String stockCode, String bought, double price, double shares, double profit, double low, double high) {
        try {
            this.stockCode = stockCode; stockData.put("stockCode", stockCode);
            this.bought = bought; stockData.put("bought", bought);
            this.price = price; stockData.put("price", price);
            this.shares = shares; stockData.put("shares", shares);
            this.profit = profit; stockData.put("profit", profit);
            this.low = low; stockData.put("low", low);
            this.high = high; stockData.put("high", high);
        } catch(Exception e) {
            e.printStackTrace();
        }
    }

    //converts a stock into a map, which can be written to the Firebase
    public Map<String,Object> toMap() {
        HashMap<String,Object> result = new HashMap<>();

        result.put("stockCode",stockCode);
        result.put("bought",bought);
        result.put("price",price);
        result.put("shares",shares);
        result.put("profit",profit);
        result.put("low",low);
        result.put("high",high);

        return result;
    }
}
