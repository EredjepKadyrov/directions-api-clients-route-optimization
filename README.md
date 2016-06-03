## Various clients for the GraphHopper Route Optimization API

This project creates API clients automatically from [our swagger specification](https://graphhopper.com/api/1/vrp/swagger.json) for the different languages.

Please see the successfully created one in the subfolders.

language  |  created?| tested?| alternative
:---------|:---------|:-------|:------------
java      |  yes     | no     | [official client](https://github.com/graphhopper/directions-api-java-client)
javascript|  no      | -      | Use the [official client](https://github.com/graphhopper/directions-api-js-client) please
python    |  yes     | no     |
csharp    |  yes     | no     | [contributed client](https://github.com/Schuby80/WpfGraphHopper)
ruby      |  yes     | no     |
sinatra (ruby)| yes  | no     |
php       |  yes     | no     |
perl      |  yes     | no     |
scala     |  yes     | no     |
swift     |  yes     | no     |
objc      |  yes     | no     |
tizen     |  yes     | no     |
nodejs    |  yes     | no     |
dart      |  yes     | no     |
go        |  no      | -      |
clojure   |  no      | -      |
qt5cpp    |  yes     | no     |
haskell   |  no      | -      |

Description:

 * created=yes: this means we were able to create the client with the swagger library
 * tested=yes: this means we or one of our customers has successfully used the library

### Update all clients

./create.sh

### Update one client of your choice

./create.sh [yourlanguage]