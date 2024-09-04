# Puzzle 48 - Virtually Nothing

In this puzzle, we have a Blazor QuickGrid that is configured to display a list of previous Blazor Puzzle episodes using a WebAssembly interactive home page and a minimal API that delivers the list of episodes.

The list appears in a small block on the screen and we would like to have it virtualized, loading more content as it becomes available.  For some reason, setting the `Virtualize` attribute to true on the QuickGrid changes the behavior of the Grid and no data is displayed.  If the `Virtualize` value is set to false, data is presented.

Can you help us fix the grid in this demo?