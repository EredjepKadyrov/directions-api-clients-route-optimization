package io.swagger.client.model




case class Solution (
  /* overall costs of solution */
  costs: Integer,
  /* overall travel distance in meters */
  distance: Integer,
  /* overall travel time in ms */
  time: Long,
  /* number of jobs that could not be assigned to final solution */
  no_unassigned: Integer,
  /* An array of routes */
  routes: List[Route],
  unassigned: Any)
  
