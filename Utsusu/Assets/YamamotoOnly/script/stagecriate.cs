﻿using UnityEngine;
using System.Collections;

public class stagecriate : MonoBehaviour
{
    Warp warp;

    public GameObject block, ClearZone, deathzone, neadle, warpin, warpout, BB,
        BajiBlock, bajilisk;
    int startX = 3, startY = 3, massWidth = 3, massHeighth = 3;
    int warpincount = 0, warpoutcount = 0, bajicount = 0;
    static int stageNum = 1;
    public mynumber MyNum;
    //左から６ブロック目がスライムの誕生地点です。
    string[] stage1 = { "      b     b        ddddddd",
                        "     b   b    b      ddddddd",
                        "dddddbbbbbbbbbbbcccccddddddd",
                        "dddddddddddddddddddddddddddd"
                        };

    string[] stage2 = { "",
                        "E        bb  bbdb  b b            dddddd                                ",
                        "     bbbdb dbbbbdb  b  bbb  bbbbbbdddddd                                ",
                        "     bdddddddddddddddddddbwwdddddddddddd                                ",
                        "                                                                dddddddd",
                        "                                                                dddddddd",
                        "                                                                dddddddd",
                        "   E         d                                                  dddddddd",
                        "     bbbWWbbbb    dd                                      W     dddddddd",
                        "              bbbbbb    d                                       dddddddd",
                        "                   bbbbbb    dd                                 dddddddd",
                        "                         bbbbbb     d                           dddddddd",
                        "                               bbbbbb    dd                     dddddddd",
                        "                                     bbbbbbBBB                  dddddddd",
                        " dddddddddddddddddddddddddddddddddddddddddd   w                 dddddddd",
                        "dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddcccccdddddddd"
                        };

    string[] stage3 = { "      b     b    bb             dddddd",
                        "     b   b    b b  b bb         dddddd",
                        "dddddbbbb   bbbbbb  b  bbbbcccccdddddd",
                        "dddddddddddddddddddddddddddddddddddddd" };

    string[] stage4 = { "      b     b     b b b  b      bbbbdddd",
                        "E    b   b    b         bb      bbbbdddd",
                        "    bbbbbbbbb  bbbbbbb   b bbbbbbw     bbbdddd",
                        "      dd       b   b      ddddddddddddd",
                        "              bb   bb   bb   bbbb",
                        "          E                b   bb                   dddddd",
                        "               Wbbb   bb            b               dddddd",
                        "WBB          ddd   bb bbbbbbbbbb bbb bbbb bbbwdddddddddddd",
                        "   BB      ddd       ddddddddddddddddddddddddddddddddddddd",
                        "     BBB             dddddd",
                        "        BBBBBBBccccccdddddd",
                        "ddddddddddddddddddddddddddd"};

    string[] stage5 = { "   bbb       bbbw      Wbbbb           dddddd",
                        "bbbbbbbbbbbw       bbb      Wbbbbbcccccdddddd",
                        "ddddddddddddddddddddddddddddddddddddddddddddd"};

    string[] stage6 = {" bW    b     b b bdddddddddddd",
                        "b   b    b      bbddddddddddd",
                        "bbbbbbbbbbbbbb  bdddddddddddd",
                        "          dddd  ddddddddddddd",
                        "          dddd  ddddddddddddd",
                        "          dddd  ddddddddddddd",
                        "          dddd  dddddddddddd",
                        "          dddd  dddddddddd",
                        "            dd  ddddddd",
                        "W",
                        "  BB            d        dddddddddddddddddd",
                        "     E     W  bb wwwcccccdddddddddddddddddd",
                        "ddddddddddddddddddddddddddddddddddddddddddd"};

    string[] stage7 = { "        ddddddddddddddddddddddddddddddddddd",
                        "              dddddbbbb   bb     db           ddddddddd",
                        "bbbbbbbwbbwbbwdddddbbbbbb        bb           ddddddddd",
                        "dddddddddddddddddbbbbbbbbWbbbbbbbbbbbbbbbbbbbbddddddddd",
                        "ddddddddddddddddddddddddddddddddddddddddddd",
                        "ddddddddddddddddddddddddddddddddddddddddddd",
                        "d ddddddddddddddd",
                        "dWddddddddddddddd",
                        "",
                        "",
                        "",
                        "",
                        "           dddddd",
                        "Wbbbbbccccccdddddd",
                        "dddddddddddddddddd"};

    string[] stage8 = { "       dd    d    d  d   ddddddddddddddd  W    dddddddddddddd",
                        "bbbbbbbbbbbBBBWBBBBbbbwbbddddddddddddddd    w  dddddddddddddd",
                        "bbbbbbbbbbbddddddddbbbbbbddddddddddddddd      wdddddddddddddd",
                        "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbdddddddddddddddddddddddddddddddd",
                        "d    dd                               ddddddddddddddddddddddd",
                        "dWBBBddbwBBB                                 dddddddddddddddd",
                        "ddd  dd     ddd                              dddddddddddddddd",
                        "ddd  dd  ddd                                 dddddddddddddddd",
                        "ddd  dd                                      dddddddddddddddd",
                        "ddd  dd                                      dddddddddddddddd",
                        "ddd  dd                                      dddddddddddddddd",
                        "ddd                                          dddddddddddddddd",
                        "EddBWBBBBBBBBBBBBBBB  BB  BB  BB  BB  Wccccccdddddddddddddddd",
                        "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd"
    };

    string[] stage9 =  {"E             bbbdddd                                         ",
                        "  BBBBBBBBBBBwbbbdddd                                         ",
                        "  dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                        "  d       b      b      b      b      b      d      b     bddd",
                        "  d       b      b      b      b      d      d      d     bddd",
                        "  d      bdb    bdb    ddd    ddd    ddd    ddd    ddd    bddd",
                        "  d       b      d      b      d      d      d     ddd    bddd",
                        "E d                                                       bddd",
                        "  bbWWbbb   bbbb   bbbb   bbbb   bbbb   bbbb   bbbb   bbbwbddd",
                        "  ddddddd   dddd   dddd   dddd   dddd   dddd   dddd   dddddddd",
                        "  ddddddd   dddd   dddd   dddd   dddd   dddd   dddd   dddddddd",
                        "  ddddddd   dddd   dddd   dddd   dddd   dddd   dddd   dddddddd",
                        "  ddddddd   dddd   dddd   dddd   dddd   dddd   dddd   dddddddd",
                        "  ddddddd   dddd   dddd   dddd   dddd   dddd   dddd   dddddddd",
                        "  dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "  dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "  dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "  dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "  dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "  dddddddddddddd   ddddddddddd   ddddddddddd   ddddddddddddddd",
                        "  dddddddddddddddddddddddddddd   ddddddddddddddddddddddddddddd",
                        "  dddddddddddddddddddddddddddd   ddddddddddddddddddddddddddddd",
                        "  dddddddddddddddddddddddddddd   ddddddddddddddddddddddddddddd",
                        "  dddddddddddddddddddddddddddd   ddddddddddddddddddddddddddddd",
                        "  dddddddddddddddddddddddddddd   ddddddddddddddddddddddddddddd",
                        "  dddddddddddddddddddddddddddcccccdddddddddddddddddddddddddddd",
    };

    string[] stage10=   {"EE   bbb                           bddddddddd",
                         "EE   bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbb                           bddddddddd",
                         "     bbbwwwccbwwwccbwwwccbwwwccbwwwbddddddddd",
                         "     dddddddddddddddddddddddddddddddddddddddd",
                         "     ddd   ddd   ddd   ddd   ddd   dddddddddd",
                         "     dddWWWdddWWWdddWWWdddWWWdddWWWdddddddddd",
                        };


    string[] stage11 = {"       d   d  　  bddd                                                        ",
                        "bbbbbbbbbbbbbBBbwbdddd                                                        ",
                        "dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                        "ddddd       bdddb dddddddddd       bdddb dddddddddd       bddddddddddddddddddd",
                        "dddddbWbwbbwbbddbWbdbdddddddbWbwbbwbdddbWbdddddddddbWbwbbwbddddddddddddddddddd",
                        "d       bdddb dddddddddd       bddddddb ddddddddddb dddddd       bb dddddddddd",
                        "dbWbwBBwbdddbWbdddddddddbWbwBBwbddddddbWddddddddddbWbdddddBBBBBBwbbWbddddddddd",
                        "dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                        "                                                          d                   ",
                        "                                                          d                   ",
                        "                                                          dbWbbbcccccccccccccc",
                       };

    string[] stage12= { "E            dd   dd  ddd  dd    ddddddddddddddddddddd",
                        "bbbbbbb    bbbbbbbbbbbbbbbbbb        ddddddddddddddddd",
                        "   b                        dBb      dd    ddddddddddd",
                        " b b b                      ddddBBBbbdd     dddddddddd",
                        "  bbb            dd         dddddddddddd    dd   ddddd",
                        "   b   bbbbbbbbbbbb         d    ddddddddBBbbb    dddd",
                        "                   bbbddbbbbb    ddddddddddddd     ddd",
                        "                                 dddddddddddddd     dd",
                        "                                 d    d    d   d      ",
                        "                             dbbbdbbbbbbbbbbbbbdcccccc",
                       };

    string[] stage13 = {"E              ddd    ddd    bddddddddddddddddddddddddddddddddd",
                        "bWWWbbbbb   bbbbbbbbbbbbbbbbwbddddddddddddddddddddddddddddddddd",
                        "        b    ddd            dd   dd             ddd   dd       ",
                        " d      b    ddd            dd   dd             ddd   dd       ",
                        "  dd    bbbbbbbbbbbbbb   bbbbbbbbbbbbbbbbb   bbbbbbbbbbbbbbcccc",
                        "                     b     dd  dd    bddbb    ddd   ddd    bddd",
                        "                     b     dd  dd    bddbb    ddd   ddd    bddd",
                        "                     bbbbbbbbbbbbbbbwddddbbbbbbbbbbbbbbbbbwbddd",
                       };

 string[] stage14 = {  "E            d          b     b        b         bbbdddddddddddddw",
                       "bbbbbbbb  bbbbbbBBBBbbbddbb  bbBBBBBbbbbbBBbbbbbwbbbdddddddddddddd",
                       "dddddddd  dddddd    ddddddddddd     dddddddddddddddddd            ",
                       "dddddddddddddddd    ddddddddddd     dddddddddddddddddd            ",
                       "dddddddddddddddd    dddddddddddd    ddddddddddddddddddbWcccccccccc",
                       "dddddddddddddddd    dddddddddddd    ddddddddd     dddddddddddddddd",
                       "dddddddddddddddd    dddddddddddd    d   ddddd     dddddddddddddddd",
                       "dddddddddddddddddddddddddddddddd    d   ddddd  W  dddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddd   d   ddddd     dddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddd   d   ddddd     dddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddd   d   ddddd     dddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddd   d   dddddddddddddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddd   d   d                         ",
                       "ddddddddddddddddddddddddddddddddd   d   d    d                    ",
                       "ddddddddddddddddddddddddddddddddd   d   d     d                   ",
                       "ddddddddddddddddddddddddddddddddd   d   d  ddddd                  ",
                       "ddddddddddddddddddddddddddddddddddddd   d     d                   ",
                       "ddddddddddddddddddddddddddddddddddddd   d    d                    ",
                       "ddddddddddddddddddddddddddddddddddddd   d                         ",
                       "ddddddddddddddddddddddddddddddddddddd   d                         ",
                       "ddddddddddddddddddddddddddddddddddddd   d                         ",
                       "ddddddddddddddddddddddddddddddddddddd   d                         ",
                       "ddddddddddddddddddddddddddddddddddddd   d                         ",
                       "ddddddddddddddddddddddddddddddddddddd   d                         ",
                       "ddddddddddddddddddddddddddddddddddddd   d                         ",
                       "ddddddddddddddddddddddddddddddddddddd   d                         ",
                       "ddddddddddddddddddddddddddddddddddddd   dddddddddddddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddddddd                             ",
                       "dddddddddddddddddddddddddddddddddddddccccccccccccccccccccccccccccc",
                       };

    string[] stage15 ={"E            d    dd        d      d              bdddddddd",
                       "wbbbbWbbbbBBbbbBBbbbbbbBBbbddBBbbbbbddBBbbbddbbbwbddddddddd",
                       "ddddddddddddddddddddddd        bdddb       dddddddddddddddd",
                       "dddddddddddddddddddddddb      bbbbbbb     bdddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddddddcccccccdddddddddddddddd",
                       "",
                       "",
                       "",
                       "",
                       "",
                       "",
                       "E            d    dd        d      d              bdddddddd",
                       "bbbbbWbbbbBBbbbBBbbbbbbBBbbddBBbbbbbddBBbbbddbbbwbddddddddd",
                       "ddddddddddddddddddddddd        bdddb       dddddddddddddddd",
                       "dddddddddddddddddddddddb      bbbbbbb     bdddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddddddcccccccdddddddddddddddd",
                       "",
                       "",
                       "",
                       "",
                       "",
                       "",
                       "E            d    dd        d      d              bdddddddd",
                       "bbbbbWbbbbBBbbbBBbbbbbbBBbbddBBbbbbbddBBbbbddbbbwbddddddddd",
                       "ddddddddddddddddddddddd        bdddb       dddddddddddddddd",
                       "dddddddddddddddddddddddb      bbbbbbb     bdddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd",
                       "",
                       "",
                       "",
                       "",
                       "",
                       "",
                       "E            d    dd        d      d              bdddddddd",
                       "bbbbbWbbbbBBbbbBBbbbbbbBBbbddBBbbbbbddBBbbbddbbbwbddddddddd",
                       "ddddddddddddddddddddddd        bdddb       dddddddddddddddd",
                       "dddddddddddddddddddddddb      bbbbbbb     bdddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddddddd",
                       "ddddddddddddddddddddddd        bbbbb       dddddddddddd   d",
                       "dddddddddddddddddddddddccccccccddddddddddddddddddddddddbWbd",
                       };

    string[] stage16 ={"",
                       };

  /*  string[] stage9 ={ "                   dddddd",
                        "Wbbbbbbbbwbbbbbwbbbddddddd",
                        "  dd   dd    dd    ddddddd",
                        "Wbbbbbbbbbbbbbbbbccddddddd",
                        "  d    d   d   d   dddddd",
                        "Wbbbbbbbbbbbbbbbbbwddddddd",
                        "  d    dd  d  dd   ddddddd",
                        "Wbbbbbbbbbbbbbbbbbwddddddd",
                        "dddddddddddddddddddddddddd"};

    string[] stage10 ={ "                   dddddd",
                        "Wbbbbbbbbwbbbbbwbbbddddddd",
                        "  dd   dd    dd    ddddddd",
                        "Wbbbbbbbbbbbbbbbbccddddddd",
                        "  d    d   d   d   dddddd",
                        "Wbbbbbbbbbbbbbbbbbwddddddd",
                        "  d    dd  d  dd   ddddddd",
                        "Wbbbbbbbbbbbbbbbbbwddddddd",
                        "dddddddddddddddddddddddddd"};
    string[] stage11 ={ "                   dddddd",
                        "Wbbbbbbbbwbbbbbwbbbddddddd",
                        "  dd   dd    dd    ddddddd",
                        "Wbbbbbbbbbbbbbbbbccddddddd",
                        "  d    d   d   d   dddddd",
                        "Wbbbbbbbbbbbbbbbbbwddddddd",
                        "  d    dd  d  dd   ddddddd",
                        "Wbbbbbbbbbbbbbbbbbwddddddd",
                        "dddddddddddddddddddddddddd"};

    string[] stage12 ={ "                   dddddd",
                        "Wbbbbbbbbwbbbbbwbbbddddddd",
                        "  dd   dd    dd    ddddddd",
                        "Wbbbbbbbbbbbbbbbbccddddddd",
                        "  d    d   d   d   dddddd",
                        "Wbbbbbbbbbbbbbbbbbwddddddd",
                        "  d    dd  d  dd   ddddddd",
                        "Wbbbbbbbbbbbbbbbbbwddddddd",
                        "dddddddddddddddddddddddddd"};

    string[] stage13 ={ "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage14 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage15 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage16 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};
*/
    string[] stage17 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage18 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage19 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage20 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage21 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage22 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage23 ={  "  dd  dB d   bdddb b",
                        "d bBd B bbbbdb b dbB",
                        "ddbb B  Bbddb d BBB ",
                        "bbdBbdddb d  bBBBBBB",
                        "Bdb dd dB dbdbd  b b",
                        "bbBBdddBbBbBB  d d d",
                        "dBBbbbbdBdBbddbdBbbB"};

    string[] stage24 = { "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbccc" };
    



    string[] stageCopy = { "" };
    void Start()
    {
        //Debug.Log("今" + MyNum.GetstageNum() + "ステージ");
        switch (MyNum.GetstageNum()/*stageNum*/)//stageを判別、ステージ番と同じコードのStringをStageCopyにコピペする。
        {
            case 1:
                stageCopy = stage1;
                break;
            case 2:
                stageCopy = stage2;
                break;
            case 3:
                stageCopy = stage3;
                break;
            case 4:
                stageCopy = stage4;
                break;
            case 5:
                stageCopy = stage5;
                break;
            case 6:
                stageCopy = stage6;
                break;
            case 7:
                stageCopy = stage7;
                break;
            case 8:
                stageCopy = stage8;
                break;
            case 9:
                stageCopy = stage9;
                break;
            case 10:
                stageCopy = stage10;
                break;
            case 11:
                stageCopy = stage11;
                break;
            case 12:
                stageCopy = stage12;

                break;
            case 13:
                stageCopy = stage13;
                break;
            case 14:
                stageCopy = stage14;
                break;
            case 15:
                stageCopy = stage15;
                break;
            case 16:
                stageCopy = stage16;
                break;
            case 17:
                stageCopy = stage17;
                break;
            case 18:
                stageCopy = stage18;
                break;
            case 19:
                stageCopy = stage19;
                break;
            case 20:
                stageCopy = stage20;
                break;
            case 21:
                stageCopy = stage21;
                break;
            case 22:
                stageCopy = stage22;
                break;
            case 23:
                stageCopy = stage23;
                break;
            case 24:
                stageCopy = stage24;
                break;
        }

        for (int i = 0; i < stageCopy.GetLength(0); i++)//stageCopyの文字数をカウントしその分だけ回す
        {
            for (int j = 0; j < stageCopy[i].Length; j++)//横？
            {
                switch (stageCopy[i].Substring(j, 1))
                {

                    case "b":   //唯のブロック
                        Instantiate(block, new Vector3(startX + j * massWidth,
                                      startY - i * massHeighth, 0.0f), Quaternion.identity);
                        break;

                    case "B":	//壊れる床
                        Instantiate(BB, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity);
                        break;

                    case "c":	//クリアするブロック
                        Instantiate(ClearZone, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity);
                        break;

                    case "d":	//死ぬブロック
                        Instantiate(deathzone, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity);
                        break;

                    case "w":	//ワープイン
                        var iw = Instantiate(warpin, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity) as GameObject;
                        iw.name = warpin.name + warpincount;
                        warpincount++;
                        break;

                    case "W":	//ワープアウト
                        var ow = Instantiate(warpout, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity) as GameObject;
                        ow.name = warpout.name + warpin.name + warpoutcount;
                        warpoutcount++;
                        break;

                    case "E":	//バジリスク
                        var baji = Instantiate(bajilisk, new Vector3(startX + j * massWidth,
                            startY - i * massHeighth, 0.0f), Quaternion.identity);
                        baji.name = "" + bajicount;
                        bajicount++;
                        break;
                }
            }
        }
    }
    public static void GetStageNum(int a)//staticをつけてシーンを移動しても保存できる
    {
        stageNum = a;
    }

    public static int RequestStageNum()
    {
        return stageNum;
    }
}