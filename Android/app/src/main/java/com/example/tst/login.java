package com.example.tst;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class login extends AppCompatActivity {
    EditText user, senha;
    Button btn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        user = (EditText) findViewById(R.id.user);
        senha = (EditText) findViewById(R.id.senha);
        btn = (Button) findViewById(R.id.btn);
    /*
        btn.setOnClickListener((View) -> {
            startActivity(new Intent(login.this, MainActivity.class));
        });

     */
    }

    public void clicaBotao(View view){
        if (user.getText().toString().equals("fabiano.novais") && senha.getText().toString().equals("123456"))
        startActivity(new Intent(login.this, MainActivity.class));
        else
            Toast.makeText(this, "login or password incorrect", Toast.LENGTH_LONG).show();


    }


}