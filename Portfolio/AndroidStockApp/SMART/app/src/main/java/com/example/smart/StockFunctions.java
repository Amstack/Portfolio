package com.example.smart;

import android.widget.EditText;

import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.URL;
import java.util.Scanner;

import javax.net.ssl.HttpsURLConnection;

/**
 * Alex Stack
 * Collection of functions which interact with the IEX stock API
 * API documentation can be found at https://iextrading.com/developer/
 * Library utilizes JSON objects, as that is how data is represented within the API
 *
 * 2-19-19: Created library and implemented primary functions:
 *     testConnection, getPrice, getDividends, getChart, getHigh, getLow, getChange, getChangePercentage, parseReader
 *
 * 4-2-19: Added new function searchString, which parses API string for given key value
 * getChart function was not working - added parser to generate custom JSON object
 */
public class StockFunctions {

    public final String IEXURL = "https://api.iextrading.com/1.0";

    //attempts to connect to API, return true if successful
    public boolean testConnection() throws Exception {
        try {
            URL url = new URL(IEXURL + "/stock/aapl/price");
            HttpsURLConnection con = (HttpsURLConnection) url.openConnection();
            con.setRequestMethod("GET");
            con.getInputStream();
            return true;
        } catch(Exception e) {
            return false;
        }
    }

    //attempts to return the current price of a given stock
    public double getPrice(String stock) throws Exception {
        try {
            //net code to connect to API - price
            URL url = new URL(IEXURL + "/stock/" + stock + "/price");
            HttpsURLConnection con = (HttpsURLConnection) url.openConnection();
            con.setRequestMethod("GET");

            //parses returned data
            BufferedReader reader = new BufferedReader(new InputStreamReader(con.getInputStream()));
            StringBuilder result = parseReader(reader);

            return Double.parseDouble(result.toString());
        } catch(Exception e) {
            e.printStackTrace();
            return 0;
        }
    }
    public double getPrice(String stock, String date) throws Exception {
        try{
            return getChart(stock, date).getDouble("open");
        } catch(Exception e) {
            e.printStackTrace();
            return 0;
        }
    }

    //attempts to return a JSON object containing the specified dividend for the given stock
    //valid values for divTime are: 1m,3m,6m,ytd,1y,2y,5y
    public JSONObject getDividends(String stock, String time) throws Exception {
        try {
            //net code to connect to API - dividends
            URL url = new URL(IEXURL + "/stock/" + stock + "/dividends/" + time);
            HttpsURLConnection con = (HttpsURLConnection) url.openConnection();
            con.setRequestMethod("GET");

            //parses returned JSON data
            BufferedReader reader = new BufferedReader(new InputStreamReader(con.getInputStream()));
            StringBuilder result = parseReader(reader);

            JSONObject divJSON = new JSONObject(result.toString());
            return divJSON;
        } catch(Exception e) {
            e.printStackTrace();
            return null;
        }
    }

    //attempts to return a JSON object containing Chart data for a given stock.
    //Chart data is a coalition of many data values, i.e. market high, market low, number of trades...
    //valid values for divTime are: 1m,3m,6m,ytd,1y,2y,5y. Specific date - date/yyyymmdd
    public JSONObject getChart(String stock, String time) throws Exception{
        try {
            //net code to connect to API - chart
            URL url = new URL(IEXURL + "/stock/" + stock + "/chart/" + time);
            HttpsURLConnection con = (HttpsURLConnection) url.openConnection();
            con.setRequestMethod("GET");

            //parses returned JSON data
            BufferedReader reader = new BufferedReader(new InputStreamReader(con.getInputStream()));
            StringBuilder result = parseReader(reader);

            JSONObject divJSON = stringToJSON(result.toString());
            return divJSON;
        } catch(Exception e) {
            e.printStackTrace();
            return null;
        }
    }

    //collection of methods that attempt to return market High/Low, Change, for given stock at given time
    //valid values for divTime are: 1m,3m,6m,ytd,1y,2y,5y. Specific date - date/yyyymmdd
    public double getHigh(String stock, String time) throws Exception {
        try{
            return getChart(stock, time).getDouble("high");
        } catch(Exception e) {
            e.printStackTrace();
            return 0;
        }
    }
    public double getLow(String stock, String time) throws Exception {
        try{
            return getChart(stock, time).getDouble("low");
        } catch(Exception e) {
            e.printStackTrace();
            return 0;
        }
    }
    public double getChange(String stock, String time) throws Exception {
        try{
            return getChart(stock, time).getDouble("change");
        } catch(Exception e) {
            e.printStackTrace();
            return 0;
        }
    }
    public double getChangePercent(String stock, String time) throws Exception {
        try{
            return getChart(stock, time).getDouble("changePercent");
        } catch(Exception e) {
            e.printStackTrace();
            return 0;
        }
    }

    //attempts to return StringBuilder containing the data parsed from given BufferedReader
    public StringBuilder parseReader(BufferedReader reader) throws Exception {
        try {
            StringBuilder result = new StringBuilder();
            String s;
            while (true) {
                if ((s = reader.readLine()) != null) { result.append(s);}
                else {break;}
            } reader.close();
            return result;
        } catch(Exception e) {
            e.printStackTrace();
            return null;
        }
    }

    //attempts to parse string for JSON data
    public JSONObject stringToJSON(String string) {
        JSONObject outJson = new JSONObject();
        try {
            Scanner sc = new Scanner(string);
            Scanner lineSc;
            sc.useDelimiter(",");
            String token, key, value;
            while (sc.hasNext()) {
                token = sc.next();
                token = token.replace("{", "");
                token = token.replace("}", "");
                token = token.replace("[", "");
                token = token.replace("]", "");

                lineSc = new Scanner(token);
                lineSc.useDelimiter(":");
                while (lineSc.hasNext()) {
                    key = lineSc.next();
                    try{value = lineSc.next();}catch(Exception e) {break;}
                    if(outJson.has(key)) break;
                    if (value.contains("\"")) {
                        key=key.replace("\"","");
                        value=value.replace("\"","");
                        outJson.put(key,value);
                    }
                    else {
                        key=key.replace("\"","");
                        outJson.put(key,Double.parseDouble(value));
                    }
                }
            }
        } catch (Exception e){
            e.printStackTrace();
        }
        return outJson;
    }

}
