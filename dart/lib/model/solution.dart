part of api;


@Entity()
class Solution {
  /* overall costs of solution */
  int costs = null;
  
  /* overall travel distance in meters */
  int distance = null;
  
  /* overall travel time in ms */
  int time = null;
  
  /* number of jobs that could not be assigned to final solution */
  int noUnassigned = null;
  
  /* An array of routes */
  List<Route> routes = [];
  
  
  SolutionUnassigned unassigned = null;
  
  
  Solution();

  @override
  String toString()  {
    return 'Solution[costs=$costs, distance=$distance, time=$time, noUnassigned=$noUnassigned, routes=$routes, unassigned=$unassigned, ]';
  }

}

