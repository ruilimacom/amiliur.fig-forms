﻿using amiliur.figforms.shared.Attributes.Datagrid.Enums;

namespace amiliur.figforms.shared.Attributes.Datagrid.Models.ColumnTypes;

public class LinkCol : TextCol
{
    public override TypeOfColumn TypeOfColumn => TypeOfColumn.Link;

    public string? LinkFormat { get; set; }

    public LinkCol(string field, string name) : base(field, name)
    {
    }
}
