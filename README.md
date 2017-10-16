# Drink'ool - GUI Vending Machine
**Version 1.0**

An upgraded version of my console vending machine where I added Graphical User Interface to make it look fancier than before.
 
## How it works?
* The program will prompt the GUI vending machine which looks like the image below:    

  ![pic1_initial_loading](https://user-images.githubusercontent.com/24326950/31598659-0ffe6760-b20c-11e7-82ea-e8bdd1143309.JPG)  
  *Note: The area where it says "powered by" with my logo will be replaced by its another feature on its upcoming version 1.1.*  

* The user cannot type the number in the text box, instead the user will use the keypad under the text box to enter the number code.  
* If the user enters an invalid code, "Invalid Code Entry" will be prompted and the text box will be cleared:
  
  ![pic2_wrong_codenumber](https://user-images.githubusercontent.com/24326950/31598895-5c362e64-b20d-11e7-8690-057788dd3586.JPG)  

* Once the user entered a valid code, it will enable the "Pay" and the text box where the user can enter the money to pay for the item purchased.  
* If the user entered an amount less than the price of the item, a message box will show up and will ask bring back the user to enter an amount greater than the price of the item:  
  
  ![pic4_invalid_moneyentry](https://user-images.githubusercontent.com/24326950/31599068-009f521e-b20e-11e7-96b5-3b342fac5fa6.JPG)  

* Once the user entered a valid payment, it will calculate the total price and the change. The program will print the Purchase Summary:  
  
  ![pic5_purchase_summary](https://user-images.githubusercontent.com/24326950/31599135-497eb0e2-b20e-11e7-95c5-2e9d5d545d1b.JPG)  
  *Note: I just realized that I forgot to include the price of the item in the purchase summmary. That will be added on the next update of this program.* ^_^  

* Lastly, when the user press "OK" from the "Purchase Summary" message box, the user will be asked if he/she wants to exit the program as shown in the image below:  
  
  ![pic6_yes_or_no](https://user-images.githubusercontent.com/24326950/31599241-c688be7a-b20e-11e7-8e79-2309d8dc3a70.JPG)  
  *Note: If the user chooses, "YES", the program will be terminated. If the user chooses "NO", it will go clear all the textboxes and start purchasing again.*
  

## Coverage

For this program I covered the following:
* constant variables
* integer, string and double variables
* switch statements
* Utilized GUI tools
* Created Custom methods 
* Imported and utilized external resources (images)

## IDE
Visual Studio Community 2015





