﻿namespace amiliur.figforms.shared.Attributes;

public class BaseFormFieldAttribute : Attribute
{
    public FormMode? FormMode { get; set; }
    
    public string? Label { get; set; }
    public string? Description { get; set; }
    public bool IsHidden { get; set; } = false;
    
}