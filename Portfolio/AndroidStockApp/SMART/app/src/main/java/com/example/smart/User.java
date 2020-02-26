package com.example.smart;

import com.google.firebase.auth.FirebaseUser;

import org.json.JSONObject;

import java.util.ArrayList;
import java.util.List;

/**
 * Alex Stack
 * USER object, allows for easy management of application users
 * This class is to be used whenever a user is created within the database, as the included
 *      methods will allow for easy user management and connection with our Firebase Database
 * 3-29-2019
 * Created USER class and implemented initial attributes
 *      included basic standard constructors, GET and SET methods
 * TODO
 * Complete all required methods, research about what all more fields are necessary, implement into project
 *
 * 4-2-2019
 * Removed unecessary fields
 */

public class User {
    //User class attributes
    private FirebaseUser user;
    private ArrayList<Stock> userStocks;

    //generic constructor
    public User() {}

    //constructor with Firebase user
    public User(FirebaseUser user) {
        try{
            this.user = user;
            userStocks = new ArrayList<Stock>();
        } catch(Exception e) {
            e.printStackTrace();
        }
    }
    public User(FirebaseUser user, ArrayList<Stock> userStocks) {
        try{
            this.user = user;
            this.userStocks = userStocks;
        } catch(Exception e) {
            e.printStackTrace();
        }
    }

    //GET and SET for users stocks, may need to add more GETTERS and SETTERS in the future
    //set userStocks to existing array
    public void setStocks(ArrayList<Stock> stocks) { this.userStocks = stocks; }

    //adds stock to users stock list
    public void addStock(Stock stock) {
        userStocks.add(stock);
    }

    //attempts to return Stock with given name, else return null
    public Stock getStock(String stockName) {
        try {
            for (Stock stock : userStocks) {
                if (stock.getStockData().getString("stockCode").equals(stockName)) {
                    return stock;
                }
            }
        } catch(Exception e) {
            e.printStackTrace();
        }
        return null;
    }

    //GET id
    public String getUserID() {
        return user.getUid();
    }
    public ArrayList<Stock> getUserStocks() {return userStocks;}
}
