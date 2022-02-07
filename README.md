# Credit Card number validation library

Validate your credit card numbers based on their brand using data anotations

---
# How to use

### .NET CLI
```
dotnet add package FUtils.CreditCard.Validations
```

### Nuget
```
Install-Package FUtils.CreditCard.Validations
```

---
## Validate MasterCard credit card
```cs
public class CreditCardModel
{
    //choose the desired credit card brand
    //in this case MasterCard
    [MasterCard]
    public string CreditCardNumber { get; set; }
}
```

```cs
public class CreditCardController : Controller
{
    //Use your model as the model that get's the data
    [HttpPost]
    [Route("/")]
    public IActionResult MyRoute([FromBody] CreditCardModel myModel)
    {
        //This will check if the credit card number is valid
        //You can then return an error message to your taste
        if(ModelState.IsValid)
        {
            return StatusCode(StatusCodes.400BadRequest);
        }
        
        //Apply your logic
        //...
        
        return StatusCode(StatusCodes.200OK);
    }
}
```
