package com.example.smart;

import android.support.annotation.NonNull;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;

import com.firebase.ui.auth.AuthUI;
import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import org.json.JSONObject;

import java.util.HashMap;
import java.util.Map;

public class UserActivity extends AppCompatActivity implements View.OnClickListener{

    private Button signOutButton;
    private FirebaseAuth auth;
    private FirebaseUser firebaseUser;
    private DatabaseReference dbref;
    private User user;
    private Stock testStock;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_user);

        //instanciate fields
        signOutButton = (Button) findViewById(R.id.log_out_button);
        signOutButton.setOnClickListener(this);
        auth = FirebaseAuth.getInstance();
        firebaseUser = auth.getCurrentUser();
        user = new User(firebaseUser);
        testStock = new Stock("aapl","10/19",100,10,100,10,10);

        postAuth();
    }

    //user log-out
    @Override
    public void onClick(View v) {
        if(v.getId() == R.id.log_out_button) {
            AuthUI.getInstance().signOut(this)
                    .addOnCompleteListener(new OnCompleteListener<Void>() {
                        @Override
                        public void onComplete(@NonNull Task<Void> task) {
                            Log.d("AUTH","USER LOGGED OUT");
                            auth.signOut();
                            finish();
                        }
                    });
        }
    }

    //tasks to be performed upon login
    protected void postAuth() {
        dbref = FirebaseDatabase.getInstance().getReference().child("users"); //db reference for entire db

        //check if user exists in database on application start
        dbref.addListenerForSingleValueEvent(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
                if(!dataSnapshot.child(firebaseUser.getUid()).exists()) {
                    //User does not exist in database, must instantiate
                    dbref.child(firebaseUser.getUid()).setValue(user.getUserID());
                }
            }

            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {
                Log.w("loadUser:onCancelled",databaseError.toException());
            }
        });

        //attaches event listener to dbref, allowing for reading/writing
        dbref.child(user.getUserID()).addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
                //user = dataSnapshot.getValue(User.class);
                //System.out.println(user.getUserID());
            }

            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {
                Log.w("readUser:onCancelled",databaseError.toException());
            }
        });

        //test writing stock to Firebase
        try {dbref.child(user.getUserID()).updateChildren(testStock.toMap());}
        catch(Exception e) {e.printStackTrace();}
    }

}
