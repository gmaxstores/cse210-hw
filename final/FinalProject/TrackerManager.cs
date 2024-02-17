using System;

using System.Collections.Generic;

public class TrackerManager
{
    private List<ExpensesTracker> _expenses;
    private List<PeriodTracker> _cycles;
    private List<AppointmentTracker> _appointments;
    private List<NoteTracker> _notes;

    public TrackerManager()
    {
        _appointments = new List<AppointmentTracker>();
        _cycles = new List<PeriodTracker>();
        _expenses = new List<ExpensesTracker>();
        _notes = new List<NoteTracker>();
    }

    public void Start()
    {
        
    }

    public void Save()
    {

    }

    public void Load()
    {
        
    }
}