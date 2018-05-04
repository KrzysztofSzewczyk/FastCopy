
# FastCopy

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

FastCopy is propably the fastest copy utility made in pure C#. Useful links:
 * [Project WIKI (not ready)](https://github.com/KrzysztofSzewczyk/MEdit/wiki)
 * [Issues](https://github.com/KrzysztofSzewczyk/MEdit/issues)
 * [Pull Requests](https://github.com/KrzysztofSzewczyk/MEdit/pulls)

## Features

FastCopy has many features:

* Buffer sizes from 512 B, to 256 MB.
* On fastest settings, highest memory usage that I've noticed for copying 10 GB, was 1 GB.
* Plans for optimization to over 10 GB / min, from HDD to slow pendrive (hdtune benchmarks suggest transfer speed to 30 MBps).
* Current copying speed on max settings: 8 GB / min, from HDD to pendrive.
* Using only .NET features.
* Putting most processing power on kernel.
* Turbo speed available to use (CPU frying option).
* And MANY MORE!

## Setup

Building this project is really simple, just lanunch any Visual Studio (>8.0), convert files to version you are using, and just hit "Rebuild Solution". Warning: You may have to remove .pfx keys references, as I didn't include them here (for obvious reasons). It's recommended to build from source.

## Dependencies

There are no depedencies for actually building this project. On MASTER branch, code is using only .NET features.
Branch Windows will contain windows-only code.

## Why not GPL?

Why not use GPL (aka the Gnu Virus License)?  Well, there are three
big problems with it.  The first is that if you are a commercial
developer, and have some spare time to contribute to a freeware
product, after spending 10 hours wading through someone else's code,
getting familiar with it, and improving it or bug fixing it, all the
time you spent is wasted, as far as being able to reuse any routines
you found in a commercial product is concerned.  

The second is that encourages others to join the dog-in-the-manger 
brigade.  Someone who ordinarily would be happy to contribute something
to the public domain, once and for all, now instead goes and spends their 
effort on a GPL product, meaning the world still doesn't get the code 
freely available for ALL use (ie in public domain projects AND commercial 
projects, not JUST other GPL projects).

The third is that it is actually technology-inhibitive.  E.g. let's
say there's a GPL wordprocessor, but it doesn't support italics.
Quite a lot of people want italics, but no-one to date has been 
willing to do that work for free.  Let's say a portion of the market
wants italics.  But no one individual can afford to pay the cost of
development by themselves.  Normally this is where a company would
jump in, do the work, and then sell the new version to the market,
meaning that each individual only has to pay a fraction of the
development cost.  But the problem is that the company CAN'T just
make those changes and sell them, because it can't make those
changes proprietary, as it needs to do in order to sell them.  So
instead, the commercial operation needs to develop the entire
equivalent of the GPL wordprocessor, and THEN add italics.  But it
is too expensive for the company to do that, so the technology is
simply never developed!

GPL code will eventually become as useful as public domain code - 50 
years after the death of the original author, when it becomes public 
domain!  That's a long time to have to wait.  Until then, unless your
lawyer informs you that the 2756 license agreement conditions don't 
affect you, the GPL work is only useful as reference material.

Quoted from work of Paul Edwards:
Date:     2007-08-14
Internet: fight.subjugation@gmail.com

Actually, in my opinion GPL can be used to non-reference code - that
means, useless code that author meant to be not-free.

## Misc

This project is my attempt to create useful too. I accidentally, CPU benchmarking tool. Such project would be useful for me. I have to copy something everytime, and it's best solution in my opinion.
