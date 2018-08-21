# Function App with authorization

Small Function App to test out the different authorization levels you can use within an Azure Function.

## `System` and `User` authorization

The `System` and `User` aren't very well documented. 

From what I gather, the `User` authorization level isn't implemented fully yet. 
This feature is tracked in the following issue: https://github.com/Azure/azure-functions-host/issues/33

The `System` authorization should be similar to the `Admin` level. 
The `System` level should only accept the `_master` key and the `Admin` level ALL host keys. 
However, I couldn't get the `Admin` level to work with any other host key except for the `_master` key.