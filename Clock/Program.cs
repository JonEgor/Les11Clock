using Clock;


Time time = new();
Viewer viewer = new Viewer();
viewer.timeTimer = 11;
time.AddViewer(viewer);
viewer.AddTime(time);
time.TimeEvent.Invoke(null, EventArgs.Empty);