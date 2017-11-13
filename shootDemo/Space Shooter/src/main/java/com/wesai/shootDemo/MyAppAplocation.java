package com.wesai.shootDemo;

import android.app.Application;

import com.wesai.WesaiSDK;


/**
 * Created by wesai on 2017/9/19.
 */

public class MyAppAplocation extends Application {

    @Override
    public void onCreate() {
        super.onCreate();
        WesaiSDK.initStatistics(this);
    }
}
