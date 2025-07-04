namespace Library.ApplicationCore.Entities;

public class BookItem
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public DateTime AcquisitionDate { get; set; }
    public string? Condition { get; set; }
    public Book? Book { get; set; }

    public bool IsAvailable { get; set; } // Indicates if the book is available
    public DateTime? ReturnDueDate { get; set; } // Stores the return due date if the book is on loan

    public string GetAvailabilityStatus()
    {
        if (IsAvailable)
        {
            return "The book is available for loan.";
        }
        else if (ReturnDueDate.HasValue)
        {
            return $"The book is currently on loan and is due back on {ReturnDueDate.Value.ToShortDateString()}.";
        }
        else
        {
            return "The book's availability status is unknown.";
        }
    }
}
