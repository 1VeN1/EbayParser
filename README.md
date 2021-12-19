
# eBay Parser

![eBayParser](https://user-images.githubusercontent.com/92044949/146420769-d1ba7db9-7654-407b-9325-82d0dca11108.PNG)

Parser eBay is a program that parses eBay product information and adds it to the database.
The EntityFramework v 6.2.0 library and HtmlAgilityPack are used.
And for the GUI, Windows Forms was used.


For parsing:
1. You need to set a link to specific products from the eBay site.
2. Click on "Parse" and wait for loading
3. After successful download, you need to click on "Output".

Since the program parsed the information, it saves it in the database and the next time you start the program, you just need to click "Output" to display the data that was parsed.

When parsing, an exception "Connection error" may appear - this is the blocking of the site. This means that the parser could not work properly, since the site is blocking the visit data. However, the parser can parse the data inadequately (that is, not all products from the first page) and save them to the database, which is why you can click the output button again. If, when pressed, it does not display anything, then first you need to click on Delete All so that the next time you click on Output, artifacts do not appear. Then we press Parse and wait for the full-fledged data parse where the succesfull will be displayed. 

The program is not a commercial product! 
