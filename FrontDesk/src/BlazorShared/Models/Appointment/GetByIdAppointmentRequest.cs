﻿using System;

namespace BlazorShared.Models.Appointment
{
  public class GetByIdAppointmentRequest : BaseRequest
  {
    public const string Route = "api/schedule/{scheduleId}/appointments/{appointmentId}";

    public Guid ScheduleId { get; set; }
    public Guid AppointmentId { get; set; }
  }
}
