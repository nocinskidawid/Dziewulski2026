package com.example.egazminstyczen2026;

import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.stream.IntStream;

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
        public int[] suma = {0,0,0,0,0};

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


    public void rzut(View view)
    {
        for(int i = 0; i < kosci.length; i++){
            ImageView kosc = findViewById(kosci[i]);
            int tag = Integer.parseInt(kosc.getTag().toString());

            if(tag == 1){
                int los = (int)(Math.random() * 6) + 1;
                kosc.setImageResource(obrazki[los]);
                suma[i]=los;
            }
        }
        TextView result = findViewById(R.id.result);
        int resultValue = IntStream.of(suma).sum();
        result.setText(String.valueOf(resultValue));
    }


    public void ToogleLock(View view) {
        int tag = Integer.parseInt(view.getTag().toString());

        if(tag==1){
            view.setTag("0");
            view.setAlpha(0.5f);
        }
        else if(tag==0){
            view.setTag("1");
            view.setAlpha(1f);
        }
    }
}
