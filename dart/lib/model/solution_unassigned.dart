part of api;


@Entity()
class SolutionUnassigned {
  /* An array of ids of unassigned services */
  List<String> services = [];
  
  /* An array of ids of unassigned shipments */
  List<String> shipments = [];
  
  
  SolutionUnassigned();

  @override
  String toString()  {
    return 'SolutionUnassigned[services=$services, shipments=$shipments, ]';
  }

}

