# Hotel Rates Filter API - Read Me

This project is built using Visual Stuido 2022 and .NET 6.  Clone the repository to your local machine and use Visual Studio to open the solution file HotelRatesFilterAPI.sln. Press CTRL+F5 to execute WebAPI project which will display Swagger API landing page. You will find a single GET method accepting two parameters: hotelId : integer and arrivalDate : string.  Provide values in both fields for e.g. 

hotelId : 7294
arrivalDate  "2016-03-15T00:00:00.000+01:00"

Press Execute and scroll down , server call should return with Code 200 and JSON data in Response Body section. This is the filtered data as per task requirements. 
You'll findd a second project for Unit Testing  **HotelRatesUnitTest**. Open Test Explore and press 'Run All Tests in View' button . All tests written should pass successfully.
