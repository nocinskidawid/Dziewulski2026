package com.example.egazminstyczen2026;

import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }

    public void rzut(View view) {
        for(int i=0; i<+5; i++){
            int random = (int)(Math.random() * 6) + 1;

       //     String KoscName = "kosc"+String.valueOf(i);
            ImageView kosc = findViewById(R.id.kosc+String.valueOf(i));
            kosc.setImageResource(R.drawable.kosc+String.valueOf(i));
        }
    }
}