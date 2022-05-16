

# Show the dataset
iris
# Show the help page, with information about the dataset 
?iris

# Create plots 

plot(iris[1:4],pch=21, bg=c("red","green3","blue")[unclass(iris$Species)])
      
