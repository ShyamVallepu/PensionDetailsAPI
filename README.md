##  Pensioner Detail Service
  
  **Description**
      
      This microservice is responsible for Provides information about the registered pensioner detail i.e., 
      Pensioner name,DOB,Salary,Allowances,pension type PAN, bank name, bank account number, bank type – private or public
    
   **Steps and Action**
   
      => This Microservice is to fetch the pensioner detail by the Aadhaar number.
      => Flat file(CSV file with pre-defined data) should be created as part of the Microservice. 
      => This file has to contain data for 20 Pensioners. This has to be read and loaded into List for 
         ALL the operations of the microservice.
      
   **Endpoint**
   
      url- https://localhost:44391/swagger/index.html/111122223333
      This endpoint accept the user request and provides the Pensioner details. Access this using the POSTMAN client
      
      Input - Aadhaar Number => 111122223333
      
**Valid Response**
      
```
{
    "name": "Dipika",
    "dateofbirth": "1998-01-03T00:00:00",
    "pan": "BCFPN1234F",
    "salaryEarned": 40000,
    "allowances": 5000,
    "aadharNumber": "111122223333",
    "pensionType": 2,
    "bankName": "HDFC",
    "accountNumber": "123456789876",
    "bankType": 2
}
```
**Invalid Response**
       
```
{
  "message": "Aadhaar Number Not Found",
  "timestamp": "2021-08-03T11:00:23.7960535",
  "fieldErrors": [
    "Aadhaar Number Not Found"
  ]
}
```
