## Various clients for the GraphHopper Route Optimization API

This project creates API clients automatically from [our swagger specification](https://graphhopper.com/api/1/vrp/swagger.json) for the different languages.

Please see the successfully created one in the subfolders.

language  |  tested? | alternative
:---------|:---------|:-------------
java      |  no      | [official client](https://github.com/graphhopper/directions-api-java-client)
javascript|  no      | [official client](https://github.com/graphhopper/directions-api-js-client)
python    |  no      |
csharp    |  no      |
ruby      |  no      |
php       |  no      |
perl      |  no      |
scala     |  no      |
swift     |  no      |
objc      |  no      |
tizen     |  no      |


### Update all clients

./create.sh

### Update one client of your choice

./create.sh [yourlanguage]