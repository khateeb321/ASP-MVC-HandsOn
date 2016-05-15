# ASP-MVC-HandsOn
I was taking ASP.NET course from YouTube by [kudvenkat](https://www.youtube.com/playlist?list=PL6n9fhu94yhVm6S8I2xd6nYz2ZORd7X2v) and some other random resources. So, this is my practice repo.


## MVC
MVC Stands for **M**odel **V**iew **C**ontroller. Motivation behind is
> Controller responds to URL request
> Controller get data from Model
> Controller hands over the data to View
> View renders the data.
Modoles can b either enitities or business objects.

###1. Passing List from Controller to View
In this module, there is a demonstration of passing list from Controller to View.
![Image](https://github.com/khateeb321/ASP-MVC-HandsOn/blob/master/Screenshots/1.png)


###2. Simple MVC Project
- You have to pass __employee__ from _Controller_ to _View_ so that it is accessible, *null exception* will be thrown otherwise.
- If you controller action method is not *Index* then you have to specify that in URL. Let say your controller name is **employee** and action method name is **details**, then your URL must be http://localhost/SimpleMVC/*employee*/*details*. (My controller name is *Employee* not *Home* so, I have to enter *localhost/employee* in URL)
- While creating a view, *strogly-typed view* is recommended. (for that, you need to build the project first)
![Image](https://github.com/khateeb321/ASP-MVC-HandsOn/blob/master/Screenshots/2.PNG)