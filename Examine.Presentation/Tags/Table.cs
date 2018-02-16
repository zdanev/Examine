namespace Examine.Presentation.Tags
{
    public class Table : BodyElement
    {
        public Table(params TableRow[] rows) : base("table", rows)
        {           
        }
    }

    public class TableRow : BodyElement
    {
        public TableRow(params TableCell[] cells) : base("tr", cells)
        {
        }
    }

    public class TableCell : BodyElement
    {
        public TableCell(params BodyElement[] content) : base("td", content)
        {
        }
    }

    public static partial class Fluent
    {
        public static Table Table(params TableRow[] rows) => new Table(rows);

        public static TableRow TR(params TableCell[] cells) => new TableRow(cells);

        public static TableCell TD(params BodyElement[] content) => new TableCell(content);
    }
}