Pod::Spec.new do |s|
  s.name = 'GraphHopper'
  s.ios.deployment_target = '8.0'
  s.osx.deployment_target = '10.9'
  s.version = '0.0.1'
  s.source = { :git => 'git@github.com:swagger-api/swagger-mustache.git', :tag => 'v1.0.0' }
  s.authors = ''
  s.license = 'Apache License, Version 2.0'
  s.homepage = 'https://github.com/graphhopper/directions-api-clients'
  s.summary = 'GraphHopper Directions API swift client'
  s.source_files = 'GraphHopper/Classes/Swaggers/**/*.swift'
  s.dependency 'Alamofire', '~> 3.1.5'
end
