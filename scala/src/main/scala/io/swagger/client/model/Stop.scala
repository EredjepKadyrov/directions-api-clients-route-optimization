package io.swagger.client.model




case class Stop (
  address: Address,
  /* duration of stop, i.e. time in ms the corresponding activity takes */
  duration: Long,
  /* array of time windows. currently, only a single time window is allowed */
  time_windows: List[TimeWindow])
  
