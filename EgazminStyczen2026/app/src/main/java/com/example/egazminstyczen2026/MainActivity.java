package com.example.egazminstyczen2026;

import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    public int[] kosci = {
            R.id.kosc0,
            R.id.kosc1,
            R.id.kosc2,
            R.id.kosc3,
            R.id.kosc4
    };

    public int[] obrazki = {
            R.drawable.kosc0,
            R.drawable.kosc1,
            R.drawable.kosc2,
            R.drawable.kosc3,
            R.drawable.kosc4,
            R.drawable.kosc5,
            R.drawable.kosc6
    };

    public int[] wartosciKosci = {0, 0, 0, 0, 0};
    public int suma = 0;

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

    public void rzutKoscia(int viewId){
        int los = (int)(Math.random() * 6) + 1;
        ImageView kosc = findViewById(viewId);
        int index = 0;

        for (int i = 0; i < kosci.length; i++) {
            if (kosci[i] == viewId) {
                index = i;
                break;
            }
        }

        suma -= wartosciKosci[index];
        suma += los;

        wartosciKosci[index] = los;
        kosc.setImageResource(obrazki[los]);

        TextView result = findViewById(R.id.result);
        result.setText(String.valueOf(suma));
    }
    public void rzut(View view) {
        //Toast.makeText(this, "Debug: tutaj jestem", Toast.LENGTH_SHORT).show();
        int tag = Integer.parseInt(view.getTag().toString());
        if(tag>=0){
            rzutKoscia(kosci[tag]);
        }
        else if(tag == -1){
            for(int i = 0; i < kosci.length; i++){
                rzutKoscia(kosci[i]);
            }
        }
        else{
            //catch exception
        }
    }
}
