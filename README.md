# Homework2

In this homework assignment, we focus on the binary search O(log n) approach. Its intention is to reduce it by half after each search. The goal is to find the unique element. 

First, we look the array “arrnum” which contains integers that are being considered. All integers in the array appear twice, with the exception of one unique element. We then focus on the “FindUniqueElement” method as it looks for the unique element in the array, The result is printed via Console.WriteLine(“Number is”…)

The left and right pointers states the start and end of the array. Furthermore, we look at the Binary Search loop which indicates the formulas that are being calculated, and tells us that the middle index, ‘mid’, is being calculated. If mid is found to be odd, we decrease it by 1, hence turning it into an even integer. The element is then compared with the other element ‘mid + 1’.  If both elements are equal, the unique element should be in the right half, thus ‘left is then moved to ‘mid + 2’. On the contrary, if they are not equal, the unique element has to be on the right half, therefore, ‘right’ is moved to ‘mid’. When ‘left’ equals to ‘right’, the unique element is found. 

One issue that I found myself having is testing it with two unique numbers. It would only work if only one unique number is present as I was not as familiar with the ‘FindUniqueElement’. Another Issue that I was having, which correlates to the previous issue, was having an even number array length. Since I had two unique numbers, I’m assuming the algorithm computed both unique numbers as a possible pair. Upon realizing what the issue was, I solved it by deleting one of the two unique numbers. This allowed the code to properly work. 
