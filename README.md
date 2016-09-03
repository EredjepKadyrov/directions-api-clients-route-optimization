## Various clients for the GraphHopper Route Optimization API

This project creates API clients automatically from [our swagger specification](https://graphhopper.com/api/1/vrp/swagger.json) for the different languages.

Please see the successfully created one in the subfolders.

language  |  created?| tested?| alternative
:---------|:---------|:-------|:------------
java      |  yes     | yes    | Use the [official client](https://github.com/graphhopper/directions-api-java-client)
javascript|  no      | -      | Use the [official client](https://github.com/graphhopper/directions-api-js-client)
python    |  yes     | no     |
csharp    |  yes     | no     | [contributed client](https://github.com/Schuby80/WpfGraphHopper)
ruby      |  yes     | [yes](https://github.com/graphhopper/directions-api-clients-route-optimization/issues/3)   |
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
 
### Swagger

Currently we use swagger codegen 2.2.1 to create the projects and e.g. java uses swagger-core 1.5.9

### Update all clients

./create.sh

### Update one client of your choice

./create.sh [yourlanguage]
