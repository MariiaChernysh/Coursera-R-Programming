// Here are some examples of how to work with mtcars dataset, which I've found in the web.
## It doesn't answer the questions of Quiz 4 in "R Programming" course directly. It is more like a tutorial that helps to understand the topic much better.
## Also in the sourse link you can find more complicated functions, that can be useful for other courses
## Source: http://wiener.math.csi.cuny.edu/Statistics/R/simpleR/stat019.html

# Load the dataset mtcars.
## This dataset is built-in to R. To access it, we need to tell R we want it. Here is how to do so, and how to find out the names of the variables. Use ?mtcars to read the documentation on the data set.

> data(mtcars)
> names(mtcars)
 [1] "mpg"  "cyl"  "disp" "hp"   "drat" "wt"   "qsec" "vs"   "am"   "gear"
[11] "carb"
  
## Access the data.
## The data is in a data frame. This makes it easy to access the data. As a summary, we could access the ``miles per gallon data'' (mpg) lots of ways. Here are a few: Using $ as with mtcars$mpg; as a list element as in mtcars[['mpg']]; or as the first column of data using mtcars[,1]. However, the preferred method is to attach the dataset to your environment. Then the data is directly accessible as this illustrates

> mpg                           # not currently visible
Error: Object "mpg" not found
> attach(mtcars)                # attach the mtcars names
> mpg                           # now it is visible
 [1] 21.0 21.0 22.8 21.4 18.7 18.1 14.3 24.4 22.8 19.2 17.8 16.4 17.3 15.2 10.4
[16] 10.4 14.7 32.4 30.4 33.9 21.5 15.5 15.2 13.3 19.2 27.3 26.0 30.4 15.8 19.7
[31] 15.0 21.4
  
# Categorical Data.
## The value of cylinder is categorical. We can use table to summarize, and barplot to view the values. Here is how

> table(cyl)
cyl
 4  6  8 
11  7 14 
> barplot(cyl)                  # not what you want
> barplot(table(cyl))
  
## If you do so, you will see that for this data 8 cylinder cars are more common. (This is 1974 car data. Read more with the help command: help(mtcars) or ?mtcars.)

# Numerical Data.
## The miles per gallon is numeric. What is the general shape of the distribution? We can view this with a stem and leaf chart, a histogram, or a boxplot. Here are commands to do so

> stem(mpg)

  The decimal point is at the |

  10 | 44
  12 | 3
  14 | 3702258
  16 | 438
  18 | 17227
  20 | 00445
  22 | 88
  24 | 4
  26 | 03
  28 | 
  30 | 44
  32 | 49

> hist(mpg)
> boxplot(mpg)    
  
## From the graphs (in particular the histogram) we can see the miles per gallon are pretty low. What are the summary statistics including the mean? (This stem graph is a bit confusing. 33.9, the max value, reads like 32.9. Using a different scale is better as in stem(mpg,scale=3).)

> mean(mpg)
[1] 20.09062
> mean(mpg,trim=.1)             # trim off 10 percent from top, bottom
[1] 19.69615                    # for a more resistant measure
> summary(mpg)
   Min. 1st Qu.  Median    Mean 3rd Qu.    Max. 
  10.40   15.43   19.20   20.09   22.80   33.90 
  
## So half of the cars get 19.20 miles per gallon or less. What is the variability or spread? There are several ways to measure this: the standard deviation or the IQR or mad (the median absolute deviation). Here are all three

> sd(mpg)
[1] 6.026948
> IQR(mpg)
[1] 7.375
> mad(mpg)
[1] 5.41149
  
## They are all different, but measure approximately the same thing -- spread.

# Subsets of the data.
## What about the average mpg for cars that have just 4 cylinders? This can be answered with the mean function as well, but first we need a subset of the mpg vector corresponding to just the 4 cylinder cars. There is an easy way to do so.

> mpg[cyl == 4]
 [1] 22.8 24.4 22.8 32.4 30.4 33.9 21.5 27.3 26.0 30.4 21.4
> mean(mpg[cyl == 4])
[1] 26.66364
  
## Read this like a sentence -- ``the miles per gallon of the cars with cylinders equal to 4''. Just remember ``equals'' is == and not simply =, and functions use parentheses while accessing data uses square brackets.
